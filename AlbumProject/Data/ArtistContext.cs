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
                    Id = 11,
                    Title = "The Division Bell",
                    ArtistId = 3,
                    Image = "/images/The-Division-Bell.jpg",
                    Label = "EMI Records"
                },

                new Album()
                {

                    Id = 12,
                    Title = "Atom Heart Mother",
                    ArtistId = 3,
                    Image = "/images/Atom-Heart-Mother.jpg",
                    Label = "Harvest Records"
                },

                new Album()
                {

                     Id = 13,
                     Title = "The Final Cut",
                     ArtistId = 3,
                     Image = "/images/The-Final-Cut.jpg",
                     Label = "Harvest Records"
                },

                new Album()
                { 

                    Id = 14,
                    Title = "The Dark Side of the Moon",
                    ArtistId = 3,
                    Image = "/images/dark-side-of-moon.jpg",
                    Label = "Harvest Records"
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
                    Id = 152,
                    Title = "Cluster One",
                    Duration = "5:56",
                    AlbumId = 11

                },

                new Song()
                {
                    Id = 153,
                    Title = "What Do You Want From Me",
                    Duration = "4:22",
                    AlbumId = 11

                },

                new Song()
                {
                    Id = 154,
                    Title = "Poles Apart",
                    Duration = "7:03",
                    AlbumId = 11

                },

                new Song()
                {
                    Id = 155,
                    Title = "Marooned",
                    Duration = "5:30",
                    AlbumId = 11

                },

                new Song()
                {
                    Id = 156,
                    Title = "A Great Day For Freedom",
                    Duration = "4:17",
                    AlbumId = 11

                },

                new Song()
                {
                    Id = 157,
                    Title = "Wearing The Inside Out",
                    Duration = "6:49",
                    AlbumId = 11

                },

                new Song()
                {
                    Id = 158,
                    Title = "Take It Back",
                    Duration = "6:12",
                    AlbumId = 11

                },

                new Song()
                {
                    Id = 159,
                    Title = "Coming Back To Life",
                    Duration = "6:19",
                    AlbumId = 11

                },

                new Song()
                {
                    Id = 160,
                    Title = "Keep Talking",
                    Duration = "6:11",
                    AlbumId = 11

                },

                new Song()
                {
                    Id = 161,
                    Title = "Lost For Words",
                    Duration = "5:15",
                    AlbumId = 11

                },

                new Song()
                {
                    Id = 162,
                    Title = "High Hopes",
                    Duration = "8:31",
                    AlbumId = 11

                },

                new Song()
                {
                    Id = 163,
                    Title = "Atom Heart Mother",
                    Duration = "23:41",
                    AlbumId = 12

                },

                new Song()
                {
                    Id = 164,
                    Title = "If",
                    Duration = "4:31",
                    AlbumId = 12

                },

                new Song()
                {
                    Id = 165,
                    Title = "Summer '68",
                    Duration = "5:29",
                    AlbumId = 12

                },

                new Song()
                {
                    Id = 166,
                    Title = "Fat Old Sun",
                    Duration = "5:24",
                    AlbumId = 12

                },

                new Song()
                {
                    Id = 167,
                    Title = "Alan's Psychedelic Breakfast",
                    Duration = "12:59",
                    AlbumId = 12

                },

                new Song()
                {
                    Id = 168,
                    Title = "The Post War Dream",
                    Duration = "2:59",
                    AlbumId = 13

                },

                new Song()
                {
                    Id = 169,
                    Title = "Your Possible Pasts",
                    Duration = "4:26",
                    AlbumId = 13

                },

                new Song()
                {
                    Id = 170,
                    Title = "One of the Few",
                    Duration = "1:17",
                    AlbumId = 13

                },

                new Song()
                {
                    Id = 171,
                    Title = "When the Tigers Broke Free",
                    Duration = "3:12",
                    AlbumId = 13

                },

                new Song()
                {
                    Id = 172,
                    Title = "The Hero's Return",
                    Duration = "2:43",
                    AlbumId = 13

                },

                new Song()
                {
                    Id = 173,
                    Title = "The Gunner's Dream",
                    Duration = "5:18",
                    AlbumId = 13

                },

                new Song()
                {
                    Id = 174,
                    Title = "Paranoid Eyes",
                    Duration = "3:42",
                    AlbumId = 13

                },

                new Song()
                {
                    Id = 175,
                    Title = "Get Your Filthy Hands Off My Desert",
                    Duration = "1:17",
                    AlbumId = 13

                },

                new Song()
                {
                    Id = 176,
                    Title = "The Fletcher Memorial Home",
                    Duration = "4:09",
                    AlbumId = 13

                },

                new Song()
                {
                    Id = 177,
                    Title = "Southampton Dock",
                    Duration = "2:13",
                    AlbumId = 13

                },

                new Song()
                {
                    Id = 178,
                    Title = "The Final Cut",
                    Duration = "4:43",
                    AlbumId = 13

                },

                new Song()
                {
                    Id = 179,
                    Title = "Not Now John [Explicit]",
                    Duration = "5:01",
                    AlbumId = 13

                },

                new Song()
                {
                    Id = 180,
                    Title = "Two Suns in the Sunset",
                    Duration = "5:15",
                    AlbumId = 13

                },
                new Song()
                {
                    Id = 181,
                    Title = "Speak To Me/Breathe",
                    Duration = "1:05",
                    AlbumId = 14

                },
                new Song()
                {
                    Id = 182,
                    Title = "On The Run",
                    Duration = "3:45",
                    AlbumId = 14

                },
                new Song()
                {
                    Id = 183,
                    Title = "Time",
                    Duration = "6:54",
                    AlbumId = 14

                },

                new Song()
                {
                    Id = 184,
                    Title = "The Great Gig In The Sky",
                    Duration = "4:44",
                    AlbumId = 14

                },

                new Song()
                {
                    Id = 185,
                    Title = "Money",
                    Duration = "6:23",
                    AlbumId = 14

                },

                new Song()
                {
                    Id = 186,
                    Title = "Us And Them",
                    Duration = "7:49",
                    AlbumId = 14

                },

                new Song()
                {
                    Id = 187,
                    Title = "Any Colour You Like",
                    Duration = "3:26",
                    AlbumId = 14

                },

                new Song()
                {
                    Id = 188,
                    Title = "Brain Damage",
                    Duration = "3:47",
                    AlbumId = 14

                },

                new Song()
                {
                    Id = 189,
                    Title = "Eclipse",
                    Duration = "2:10",
                    AlbumId = 14
                });

        }
    }
}
