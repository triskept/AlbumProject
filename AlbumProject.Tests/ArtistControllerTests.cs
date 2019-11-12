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
    public class ArtistControllerTests
    {
        private ArtistController underTest;
        IRepository<Artist> artistRepo;

        public ArtistControllerTests()
        {
            artistRepo = Substitute.For<IRepository<Artist>>();
            underTest = new ArtistController(artistRepo);
        }

        [Fact]
        public void Get_Returns_List_Of_Artists()
        {
            var expectedArtists = new List<Artist>()
            {
                new Artist(1, "Kid Cudi"),
                new Artist(2, "Imagine Dragons")
            };

            artistRepo.GetAll().Returns(expectedArtists);

            var result = underTest.Get();

            Assert.Equal(expectedArtists, result.ToList());
           
        }

        [Fact]
        public void Post_Creates_New_Artist()
        {
            var newArtist = new Artist(1, "New Artist");
            var artistList = new List<Artist>();

            artistRepo.When(t => t.Create(newArtist))
                .Do(t => artistList.Add(newArtist));

            artistRepo.GetAll().Returns(artistList);

            var result = underTest.Post(newArtist);

            Assert.Contains(newArtist, result);
        }

        [Fact]
        public void Delete_Removes_An_Artist()
        {
            var artistId = 1;
            var deletedArtist = new Artist(artistId, "First Artist");
            var artistList = new List<Artist>()
            {
                deletedArtist,
                new Artist(2, "Second Artist")
            };

            artistRepo.GetById(artistId).Returns(deletedArtist);
            artistRepo.When(d => d.Delete(deletedArtist))
                .Do(d => artistList.Remove(deletedArtist));
            artistRepo.GetAll().Returns(artistList);

            var result = underTest.Delete(artistId);

            Assert.All(result, item => Assert.Contains("Second Artist", item.Name));
        }

        [Fact]
        public void Put_Updates_An_Artist()
        {
            var originalArtist = new Artist(1, "First Artist");
            var expectedArtists = new List<Artist>()
            {
                originalArtist
            };

            var updatedArtist = new Artist(1, "Updated Artist");

            artistRepo.When(t => artistRepo.Update(updatedArtist))
                .Do(Callback.First(t => expectedArtists.Remove(originalArtist))
                .Then(t => expectedArtists.Add(updatedArtist)));
            artistRepo.GetAll().Returns(expectedArtists);

            var result = underTest.Put(updatedArtist);

            Assert.All(result, item => Assert.Contains("Updated Artist", item.Name));
        }
    }
}
