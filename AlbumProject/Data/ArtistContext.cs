using AlbumProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumProject.Data
{
    public class ArtistContext : DbContext
    {
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Song> Songs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=ArtistDB;Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(connectionString)
            .UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Album>().HasData(
                new Album()
                {
                    Id = 7,
                    Title = "Night Visions",
                    ArtistId = 2,
                    Image ="/images/nightvisions.jpg",
                    Label = " Kidinakorner and Interscope Records",
                },

                new Album()
                {
                    Id = 8,
                    Title = "Smoke + Mirrors",
                    ArtistId = 2,
                    Image = "/images/smokemirrors_720.jpg",
                    Label = " Kidinakorner and Interscope Records",
                },

                new Album()
                {
                    Id = 9,
                    Title = "Evolve",
                    ArtistId = 2,
                    Image = "/images/evolve.jpg",
                    Label = " Kidinakorner and Interscope Records",
                },

                new Album()
                {
                    Id = 10,
                    Title = "Origins",
                    ArtistId = 2,
                    Image = "/images/origins.jfif",
                    Label = " Kidinakorner and Interscope Records",
                });

            modelBuilder.Entity<Artist>().HasData(
                new Artist()
                {
                    Id = 1,
                    Name = "Kid Cudi",
                    Image = "/images/kidcudi.jpg",
                    Age = 35,
                    Hometown = "Cleveland, Ohio"
                },
                new Artist()
                {
                    Id = 2,
                    Name = "Imagine Dragons",
                    Image = "/images/imaginedragons.jpg",
                    Age = 32,
                    Hometown = "Las Vegas, Nevada"
                },
                new Artist()
                {
                    Id = 3,
                    Name = "Pink Floyd",
                    Image = "/images/pinkfloyd.jpg",
                    Age = 54,
                    Hometown = "London, England"
                },
                new Artist()
                {
                    Id = 4,
                    Name = "Alicia Keys",
                    Image = "/images/alicia-keys.jpg",
                    Age = 38,
                    Hometown = "New York, New York"
                });

            modelBuilder.Entity<Song>().HasData(
                new Song()
                {
                    Id = 1,
                    Title = "Radioactive",
                    Duration = "3:07",
                    AlbumId = 7,
                },

                new Song()
                {
                    Id = 2,
                    Title = "Tiptoe",
                    Duration = "3:14",
                    AlbumId = 7,
                },

                new Song()
                {
                    Id = 3,
                    Title = "It's Time",
                    Duration = "4:01",
                    AlbumId = 7,
                },

                new Song()
                {
                    Id = 4,
                    Title = "Demons",
                    Duration = "2:58",
                    AlbumId = 7,
                },

                new Song()
                {
                    Id = 5,
                    Title = "On Top Of The World",
                    Duration = "3:10",
                    AlbumId = 7,
                },

                new Song()
                {
                    Id = 6,
                    Title = "Amsterdam",
                    Duration = "4:02",
                    AlbumId = 7,
                },

                new Song()
                {
                    Id = 7,
                    Title = "Hear Me",
                    Duration = "3:53",
                    AlbumId = 7,
                },

                new Song()
                {
                    Id = 8,
                    Title = "Every Night",
                    Duration = "3:36",
                    AlbumId = 7,
                },

                new Song()
                {
                    Id = 9,
                    Title = "Bleeding Out",
                    Duration = "3:42",
                    AlbumId = 7,
                },

                new Song()
                {
                    Id = 10,
                    Title = "Underdog",
                    Duration = "3:27",
                    AlbumId = 7,
                },

                new Song()
                {
                    Id = 11,
                    Title = "Nothing Left To Say/Rocks",
                    Duration = "8:57",
                    AlbumId = 7,
                },

                new Song()
                {
                    Id = 12,
                    Title = "Shots",
                    Duration = "3:53",
                    AlbumId = 8,
                },

                new Song()
                {
                    Id = 13,
                    Title = "Gold",
                    Duration = "3:37",
                    AlbumId = 8,
                },

                new Song()
                {
                    Id = 14,
                    Title = "Smoke And Mirrors",
                    Duration = "4:21",
                    AlbumId = 8,
                },

                new Song()
                {
                    Id = 15,
                    Title = "I'm So Sorry",
                    Duration = "3:51",
                    AlbumId = 8,
                },

                new Song()
                {
                    Id = 16,
                    Title = "I Bet My Life",
                    Duration = "3:12",
                    AlbumId = 8,
                },

                new Song()
                {
                    Id = 17,
                    Title = "Polaroid",
                    Duration = "3:52",
                    AlbumId = 8,
                },

                new Song()
                {
                    Id = 18,
                    Title = "Friction",
                    Duration = "3:22",
                    AlbumId = 8,
                },

                new Song()
                {
                    Id = 19,
                    Title = "It Comes Back To You",
                    Duration = "3:38",
                    AlbumId = 8,
                },

                new Song()
                {
                    Id = 20,
                    Title = "Dream",
                    Duration = "4:19",
                    AlbumId = 8,
                },

                new Song()
                {
                    Id = 21,
                    Title = "Trouble",
                    Duration = "3:13",
                    AlbumId = 8,
                },

                new Song()
                {
                    Id = 22,
                    Title = "Summer",
                    Duration = "3:39",
                    AlbumId = 8,
                },

                new Song()
                {
                    Id = 23,
                    Title = "Hopeless Opus",
                    Duration = "4:02",
                    AlbumId = 8,
                },

                new Song()
                {
                    Id = 24,
                    Title = "The Fall",
                    Duration = "6:03",
                    AlbumId = 8,
                },

                new Song()
                {
                    Id = 25,
                    Title = "I Don't Know Why",
                    Duration = "3:11",
                    AlbumId = 9,
                },

                new Song()
                {
                    Id = 26,
                    Title = "Whatever It Takes",
                    Duration = "3:22",
                    AlbumId = 9,
                },

                new Song()
                {
                    Id = 27,
                    Title = "Believer",
                    Duration = "3:25",
                    AlbumId = 9,
                },

                new Song()
                {
                    Id = 28,
                    Title = "Walking The Wire",
                    Duration = "3:53",
                    AlbumId = 9,
                },

                new Song()
                {
                    Id = 29,
                    Title = "Rise Up",
                    Duration = "3:52",
                    AlbumId = 9,
                },

                new Song()
                {
                    Id = 30,
                    Title = "I'll Make It Up To You",
                    Duration = "4:23",
                    AlbumId = 9,
                },

                new Song()
                {
                    Id = 31,
                    Title = "Yesturday",
                    Duration = "3:26",
                    AlbumId = 9,
                },

                new Song()
                {
                    Id = 32,
                    Title = "Mouth Of The River",
                    Duration = "3:42",
                    AlbumId = 9,
                },

                new Song()
                {
                    Id = 33,
                    Title = "Thunder",
                    Duration = "3:08",
                    AlbumId = 9,
                },

                new Song()
                {
                    Id = 34,
                    Title = "Star Over",
                    Duration = "3:27",
                    AlbumId = 9,
                },

                new Song()
                {
                    Id = 35,
                    Title = "Dancing In The Dark",
                    Duration = "3:54",
                    AlbumId = 9,
                },

                new Song()
                {
                    Id = 36,
                    Title = "Natural",
                    Duration = "3:10",
                    AlbumId = 10,
                },

                new Song()
                {
                    Id = 37,
                    Title = "Boomerang",
                    Duration = "3:08",
                    AlbumId = 10,
                },

                new Song()
                {
                    Id = 38,
                    Title = "Machine",
                    Duration = "3:02",
                    AlbumId = 10,
                },

                new Song()
                {
                    Id = 39,
                    Title = "Cool Out",
                    Duration = "3:38",
                    AlbumId = 10,
                },

                new Song()
                {
                    Id = 40,
                    Title = "Bad Liar",
                    Duration = "4:21",
                    AlbumId = 10,
                },

                new Song()
                {
                    Id = 41,
                    Title = "West Coast",
                    Duration = "3:38",
                    AlbumId = 10,
                },

                new Song()
                {
                    Id = 42,
                    Title = "Zero",
                    Duration = "3:31",
                    AlbumId = 10,
                },

                new Song()
                {
                    Id = 43,
                    Title = "Bullet In A Gun",
                    Duration = "3:25",
                    AlbumId = 10,
                },

                new Song()
                {
                    Id = 44,
                    Title = "Digital",
                    Duration = "3:21",
                    AlbumId = 10,
                },

                new Song()
                {
                    Id = 45,
                    Title = "Only",
                    Duration = "3:01",
                    AlbumId = 10,
                },

                new Song()
                {
                    Id = 46,
                    Title = "Stuck",
                    Duration = "3:11",
                    AlbumId = 10,
                },

                new Song()
                {
                    Id = 47,
                    Title = "Love",
                    Duration = "2:47",
                    AlbumId = 10,
                });

        }
    }
}
