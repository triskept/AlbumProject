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
                    Duration = 307,
                    AlbumId = 7,
                },

                new Song()
                {
                    Id = 2,
                    Title = "Tiptoe",
                    Duration = 314,
                    AlbumId = 7,
                },

                new Song()
                {
                    Id = 3,
                    Title = "It's Time",
                    Duration = 401,
                    AlbumId = 7,
                },

                new Song()
                {
                    Id = 4,
                    Title = "Demons",
                    Duration = 258,
                    AlbumId = 7,
                },

                new Song()
                {
                    Id = 5,
                    Title = "On Top Of The World",
                    Duration = 310,
                    AlbumId = 7,
                },

                new Song()
                {
                    Id = 6,
                    Title = "Amsterdam",
                    Duration = 402,
                    AlbumId = 7,
                },

                new Song()
                {
                    Id = 7,
                    Title = "Hear Me",
                    Duration = 353,
                    AlbumId = 7,
                },

                new Song()
                {
                    Id = 8,
                    Title = "Every Night",
                    Duration = 336,
                    AlbumId = 7,
                },

                new Song()
                {
                    Id = 9,
                    Title = "Bleeding Out",
                    Duration = 342,
                    AlbumId = 7,
                },

                new Song()
                {
                    Id = 10,
                    Title = "Underdog",
                    Duration = 327,
                    AlbumId = 7,
                },

                new Song()
                {
                    Id = 11,
                    Title = "Nothing Left To Say/Rocks",
                    Duration = 857,
                    AlbumId = 7,
                },

                new Song()
                {
                    Id = 12,
                    Title = "Shots",
                    Duration = 353,
                    AlbumId = 8,
                },

                new Song()
                {
                    Id = 13,
                    Title = "Gold",
                    Duration = 337,
                    AlbumId = 8,
                },

                new Song()
                {
                    Id = 14,
                    Title = "Smoke And Mirrors",
                    Duration = 421,
                    AlbumId = 8,
                },

                new Song()
                {
                    Id = 15,
                    Title = "I'm So Sorry",
                    Duration = 351,
                    AlbumId = 8,
                },

                new Song()
                {
                    Id = 16,
                    Title = "I Bet My Life",
                    Duration = 312,
                    AlbumId = 8,
                },

                new Song()
                {
                    Id = 17,
                    Title = "Polaroid",
                    Duration = 352,
                    AlbumId = 8,
                },

                new Song()
                {
                    Id = 18,
                    Title = "Friction",
                    Duration = 322,
                    AlbumId = 8,
                },

                new Song()
                {
                    Id = 19,
                    Title = "It Comes Back To You",
                    Duration = 338,
                    AlbumId = 8,
                },

                new Song()
                {
                    Id = 20,
                    Title = "Dream",
                    Duration = 419,
                    AlbumId = 8,
                },

                new Song()
                {
                    Id = 21,
                    Title = "Trouble",
                    Duration = 313,
                    AlbumId = 8,
                },

                new Song()
                {
                    Id = 22,
                    Title = "Summer",
                    Duration = 339,
                    AlbumId = 8,
                },

                new Song()
                {
                    Id = 23,
                    Title = "Hopeless Opus",
                    Duration = 402,
                    AlbumId = 8,
                },

                new Song()
                {
                    Id = 24,
                    Title = "The Fall",
                    Duration = 603,
                    AlbumId = 8,
                },

                new Song()
                {
                });

        }
    }
}
