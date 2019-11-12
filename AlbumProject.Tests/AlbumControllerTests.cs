using AlbumProject.Controllers;
using System;
using Xunit;
using System.Linq;
using AlbumProject.Data;
using AlbumProject.Repositories;
using NSubstitute;
using AlbumProject.Models;
using System.Collections.Generic;

namespace AlbumProject.Tests
{
    public class AlbumControllerTests
    {
        private AlbumController underTest;
        IRepository<Album> albumRepo;

        public AlbumControllerTests()
        {
            albumRepo = Substitute.For<IRepository<Album>>();
            underTest = new AlbumController(albumRepo);
        }

        [Fact]
        public void Get_Returns_List_Of_Albums()
        {
            var expectedAlbums = new List<Album>()
            {
                new Album(1, "Man on the Moon"),
                new Album(2, "Man on the Moon 2")
            };

            albumRepo.GetAll().Returns(expectedAlbums);

            var result = underTest.Get();

            Assert.Equal(expectedAlbums, result.ToList());

        }

        [Fact]
        public void Post_Creates_New_Album()
        {
            var newAlbum = new Album(1, "New Album");
            var albumList = new List<Album>();

            albumRepo.When(t => t.Create(newAlbum))
                .Do(t => albumList.Add(newAlbum));

            albumRepo.GetAll().Returns(albumList);

            var result = underTest.Post(newAlbum);

            Assert.Contains(newAlbum, result);
        }

        [Fact]
        public void Delete_Removes_An_Album()
        {
            var albumId = 1;
            var deletedAlbum = new Album(albumId, "First Album");
            var albumList = new List<Album>()
            {
                deletedAlbum,
                new Album (2, "Second Album")
            };

            albumRepo.GetById(albumId).Returns(deletedAlbum);
            albumRepo.When(d => d.Delete(deletedAlbum))
                .Do(d => albumList.Remove(deletedAlbum));
            albumRepo.GetAll().Returns(albumList);

            var result = underTest.Delete(albumId);

            Assert.All(result, item => Assert.Contains("Second Album", item.Title));
        }

        [Fact]
        public void Put_Updates_An_Album()
        {
            var originalAlbum  = new Album(1, "First Album");
            var expectedAlbums = new List<Album>()
            {
                originalAlbum
            };

            var updatedAlbum = new Album(1, "Updated Album");

            albumRepo.When(t => albumRepo.Update(updatedAlbum))
                .Do(Callback.First(t => expectedAlbums.Remove(originalAlbum))
                .Then(t => expectedAlbums.Add(updatedAlbum)));
            albumRepo.GetAll().Returns(expectedAlbums);

            var result = underTest.Put(updatedAlbum);

            Assert.All(result, item => Assert.Contains("Updated Artist", item.Title));
        }
    }
}
