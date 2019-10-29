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
                    Id = 105,
                    Title = "Radioactive",
                    Duration = "3:07",
                    AlbumId = 7,
                },

                new Song()
                {
                    Id = 106,
                    Title = "Tiptoe",
                    Duration = "3:14",
                    AlbumId = 7,
                },

                new Song()
                {
                    Id = 107,
                    Title = "It's Time",
                    Duration = "4:01",
                    AlbumId = 7,
                },

                new Song()
                {
                    Id = 108,
                    Title = "Demons",
                    Duration = "2:58",
                    AlbumId = 7,
                },

                new Song()
                {
                    Id = 109,
                    Title = "On Top Of The World",
                    Duration = "3:10",
                    AlbumId = 7,
                },

                new Song()
                {
                    Id = 110,
                    Title = "Amsterdam",
                    Duration = "4:02",
                    AlbumId = 7,
                },

                new Song()
                {
                    Id = 111,
                    Title = "Hear Me",
                    Duration = "3:53",
                    AlbumId = 7,
                },

                new Song()
                {
                    Id = 112,
                    Title = "Every Night",
                    Duration = "3:36",
                    AlbumId = 7,
                },

                new Song()
                {
                    Id = 113,
                    Title = "Bleeding Out",
                    Duration = "3:42",
                    AlbumId = 7,
                },

                new Song()
                {
                    Id = 114,
                    Title = "Underdog",
                    Duration = "3:27",
                    AlbumId = 7,
                },

                new Song()
                {
                    Id = 115,
                    Title = "Nothing Left To Say/Rocks",
                    Duration = "8:57",
                    AlbumId = 7,
                },

                new Song()
                {
                    Id = 116,
                    Title = "Shots",
                    Duration = "3:53",
                    AlbumId = 8,
                },

                new Song()
                {
                    Id = 117,
                    Title = "Gold",
                    Duration = "3:37",
                    AlbumId = 8,
                },

                new Song()
                {
                    Id = 118,
                    Title = "Smoke And Mirrors",
                    Duration = "4:21",
                    AlbumId = 8,
                },

                new Song()
                {
                    Id = 119,
                    Title = "I'm So Sorry",
                    Duration = "3:51",
                    AlbumId = 8,
                },

                new Song()
                {
                    Id = 120,
                    Title = "I Bet My Life",
                    Duration = "3:12",
                    AlbumId = 8,
                },

                new Song()
                {
                    Id = 121,
                    Title = "Polaroid",
                    Duration = "3:52",
                    AlbumId = 8,
                },

                new Song()
                {
                    Id = 122,
                    Title = "Friction",
                    Duration = "3:22",
                    AlbumId = 8,
                },

                new Song()
                {
                    Id = 123,
                    Title = "It Comes Back To You",
                    Duration = "3:38",
                    AlbumId = 8,
                },

                new Song()
                {
                    Id = 124,
                    Title = "Dream",
                    Duration = "4:19",
                    AlbumId = 8,
                },

                new Song()
                {
                    Id = 125,
                    Title = "Trouble",
                    Duration = "3:13",
                    AlbumId = 8,
                },

                new Song()
                {
                    Id = 126,
                    Title = "Summer",
                    Duration = "3:39",
                    AlbumId = 8,
                },

                new Song()
                {
                    Id = 127,
                    Title = "Hopeless Opus",
                    Duration = "4:02",
                    AlbumId = 8,
                },

                new Song()
                {
                    Id = 128,
                    Title = "The Fall",
                    Duration = "6:03",
                    AlbumId = 8,
                },

                new Song()
                {
                    Id = 129,
                    Title = "I Don't Know Why",
                    Duration = "3:11",
                    AlbumId = 9,
                },

                new Song()
                {
                    Id = 130,
                    Title = "Whatever It Takes",
                    Duration = "3:22",
                    AlbumId = 9,
                },

                new Song()
                {
                    Id = 131,
                    Title = "Believer",
                    Duration = "3:25",
                    AlbumId = 9,
                },

                new Song()
                {
                    Id = 132,
                    Title = "Walking The Wire",
                    Duration = "3:53",
                    AlbumId = 9,
                },

                new Song()
                {
                    Id = 133,
                    Title = "Rise Up",
                    Duration = "3:52",
                    AlbumId = 9,
                },

                new Song()
                {
                    Id = 134,
                    Title = "I'll Make It Up To You",
                    Duration = "4:23",
                    AlbumId = 9,
                },

                new Song()
                {
                    Id = 135,
                    Title = "Yesturday",
                    Duration = "3:26",
                    AlbumId = 9,
                },

                new Song()
                {
                    Id = 136,
                    Title = "Mouth Of The River",
                    Duration = "3:42",
                    AlbumId = 9,
                },

                new Song()
                {
                    Id = 137,
                    Title = "Thunder",
                    Duration = "3:08",
                    AlbumId = 9,
                },

                new Song()
                {
                    Id = 138,
                    Title = "Star Over",
                    Duration = "3:27",
                    AlbumId = 9,
                },

                new Song()
                {
                    Id = 139,
                    Title = "Dancing In The Dark",
                    Duration = "3:54",
                    AlbumId = 9,
                },

                new Song()
                {
                    Id = 140,
                    Title = "Natural",
                    Duration = "3:10",
                    AlbumId = 10,
                },

                new Song()
                {
                    Id = 141,
                    Title = "Boomerang",
                    Duration = "3:08",
                    AlbumId = 10,
                },

                new Song()
                {
                    Id = 142,
                    Title = "Machine",
                    Duration = "3:02",
                    AlbumId = 10,
                },

                new Song()
                {
                    Id = 143,
                    Title = "Cool Out",
                    Duration = "3:38",
                    AlbumId = 10,
                },

                new Song()
                {
                    Id = 144,
                    Title = "Bad Liar",
                    Duration = "4:21",
                    AlbumId = 10,
                },

                new Song()
                {
                    Id = 145,
                    Title = "West Coast",
                    Duration = "3:38",
                    AlbumId = 10,
                },

                new Song()
                {
                    Id = 146,
                    Title = "Zero",
                    Duration = "3:31",
                    AlbumId = 10,
                },

                new Song()
                {
                    Id = 147,
                    Title = "Bullet In A Gun",
                    Duration = "3:25",
                    AlbumId = 10,
                },

                new Song()
                {
                    Id = 148,
                    Title = "Digital",
                    Duration = "3:21",
                    AlbumId = 10,
                },

                new Song()
                {
                    Id = 149,
                    Title = "Only",
                    Duration = "3:01",
                    AlbumId = 10,
                },

                new Song()
                {
                    Id = 150,
                    Title = "Stuck",
                    Duration = "3:11",
                    AlbumId = 10,
                },

                new Song()
                {
                    Id = 151,
                    Title = "Love",
                    Duration = "2:47",
                    AlbumId = 10,
                });

        }
    }
}
