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
                });

        }
    }
}
