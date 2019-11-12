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
    public class SongControllerTests
    {
        private SongController underTest;
        IRepository<Song> songRepo;

        public SongControllerTests()
        {
            songRepo = Substitute.For<IRepository<Song>>();
            underTest = new SongController(songRepo);
        }

        [Fact]
        public void Get_Returns_List_Of_Songs()
        {
            var expectedSongs = new List<Song>()
            {
                new Song(1, "In My Dreams"),
                new Song(2, "Soundtrack 2 My Life")
            };

            songRepo.GetAll().Returns(expectedSongs);

            var result = underTest.Get();

            Assert.Equal(expectedSongs, result.ToList());
        }

        [Fact]
        public void Post_Creates_New_Song()
        {
            var newSong = new Song(1, "New Song");
            var songList = new List<Song>();

            songRepo.When(t => t.Create(newSong))
                .Do(t => songList.Add(newSong));

           songRepo.GetAll().Returns(songList);

            var result = underTest.Post(newSong);

            Assert.Contains(newSong, result);
        }

        [Fact]
        public void Delete_Removes_A_Song()
        {
            var songId = 1;
            var deletedSong = new Song(songId, "First Song");
            var songList = new List<Song>()
            {
                deletedSong,
                new Song(2, "Second Song")
            };

            songRepo.GetById(songId).Returns(deletedSong);
            songRepo.When(d => d.Delete(deletedSong))
                .Do(d => songList.Remove(deletedSong));
            songRepo.GetAll().Returns(songList);

            var result = underTest.Delete(songId);

            Assert.All(result, item => Assert.Contains("Second Song", item.Title));
        }

        [Fact]
        public void Put_Updates_A_Song()
        {
            var originalSong = new Song(1, "First Song");
            var expectedSongs = new List<Song>()
            {
                originalSong
            };

            var updatedSong = new Song(1, "Updated Song");

            songRepo.When(t => songRepo.Update(updatedSong))
                .Do(Callback.First(t => expectedSongs.Remove(originalSong))
                .Then(t => expectedSongs.Add(updatedSong)));
            songRepo.GetAll().Returns(expectedSongs);

            var result = underTest.Put(updatedSong);

            Assert.All(result, item => Assert.Contains("Updated Song", item.Title));
        }

    }
}
