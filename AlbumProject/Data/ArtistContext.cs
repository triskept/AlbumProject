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
                    Id = 15,
                    Title = "Songs in A Minor",
                    ArtistId = 4,
                    Image = "/images/songsinaminor.jpg",
                    Label = "J"
                },

                new Album()
                {
                    Id = 16,
                    Title = "The Diary of Alicia Keys",
                    ArtistId = 4,
                    Image = "/images/diaryofakeys.jpg",
                    Label = "J"
                },

                new Album()
                {
                    Id = 17,
                    Title = "As I Am",
                    ArtistId = 4,
                    Image = "/images/asiam.png",
                    Label = "J"
                },

                new Album()
                {
                    Id = 18,
                    Title = "The Element of Freedom",
                    ArtistId = 4,
                    Image = "/images/elementoffreedom.jpg",
                    Label = "J"
                },

                new Album()
                {
                    Id = 19,
                    Title = "Girl on Fire",
                    ArtistId = 4,
                    Image = "/images/girlonfire.jpg",
                    Label = "RCA"
                },

                new Album()
                {
                    Id = 20,
                    Title = "Here",
                    ArtistId = 4,
                    Image = "/images/here.jpg",
                    Label = "RCA"
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
                    Id = 190,
                    Title = "Piano & I",
                    Duration = "1:52",
                    AlbumId = 15
                },

                new Song()
                {
                    Id = 191,
                    Title = "Girlfriend",
                    Duration = "3:34",
                    AlbumId = 15
                },

                new Song()
                {
                    Id = 192,
                    Title = "How Come You Don't Call Me",
                    Duration = "3:57",
                    AlbumId = 15
                },

                new Song()
                {
                    Id = 193,
                    Title = "Fallin",
                    Duration = "3:30",
                    AlbumId = 15
                },

                new Song()
                {
                    Id = 194,
                    Title = "Troubles",
                    Duration = "4:28",
                    AlbumId = 15
                },

                new Song()
                {
                    Id = 195,
                    Title = "Rock wit U",
                    Duration = "5:36",
                    AlbumId = 15
                },

                new Song()
                {
                    Id = 196,
                    Title = "A Woman's Worth",
                    Duration = "5:03",
                    AlbumId = 15
                },

                new Song()
                {
                    Id = 197,
                    Title = "Jane Doe",
                    Duration = "3:48",
                    AlbumId = 15
                },

                new Song()
                {
                    Id = 198,
                    Title = "Goodbye",
                    Duration = "4:20",
                    AlbumId = 15
                },

                new Song()
                {
                    Id = 199,
                    Title = "The Life",
                    Duration = "5:25",
                    AlbumId = 15
                },

                new Song()
                {
                    Id = 200,
                    Title = "Mr. Man",
                    Duration = "4:09",
                    AlbumId = 15
                },

                new Song()
                {
                    Id = 201,
                    Title = "Never Felt This Way",
                    Duration = "2:01",
                    AlbumId = 15
                },

                new Song()
                {
                    Id = 202,
                    Title = "Butterflyz",
                    Duration = "4:08",
                    AlbumId = 15
                },

                new Song()
                {
                    Id = 203,
                    Title = "Why Do I Feel So Sad",
                    Duration = "4:25",
                    AlbumId = 15
                },

                new Song()
                {
                    Id = 204,
                    Title = "Caged Bird",
                    Duration = "3:02",
                    AlbumId = 15
                },

                new Song()
                {
                    Id = 205,
                    Title = "Lovin U",
                    Duration = "3:49",
                    AlbumId = 15
                },

                new Song()
                {
                    Id = 206,
                    Title = "Harlem's Nocturne",
                    Duration = "1:43",
                    AlbumId = 16
                },

                new Song()
                {
                    Id = 207,
                    Title = "Karma",
                    Duration = "4:16",
                    AlbumId = 16
                },

                new Song()
                {
                    Id = 208,
                    Title = "Heartburn",
                    Duration = "3:28",
                    AlbumId = 16
                },

                new Song()
                {
                    Id = 209,
                    Title = "If I Was Your Woman / Walk On By",
                    Duration = "3:06",
                    AlbumId = 16
                },

                new Song()
                {
                    Id = 210,
                    Title = "You Don't Know My Name",
                    Duration = "6:06",
                    AlbumId = 16
                },

                new Song()
                {
                    Id = 211,
                    Title = "If I Ain't Got You",
                    Duration = "3:48",
                    AlbumId = 16
                },

                new Song()
                {
                    Id = 212,
                    Title = "Diary",
                    Duration = "4:45",
                    AlbumId = 16
                },

                new Song()
                {
                    Id = 213,
                    Title = "Dragon Days",
                    Duration = "4:36",
                    AlbumId = 16
                },

                new Song()
                {
                    Id = 214,
                    Title = "Wake Up",
                    Duration = "4:27",
                    AlbumId = 16
                },

                new Song()
                {
                    Id = 215,
                    Title = "So Simple",
                    Duration = "3:49",
                    AlbumId = 16
                },

                new Song()
                {
                    Id = 216,
                    Title = "When You Really Love Someone",
                    Duration = "4:09",
                    AlbumId = 16
                },

                new Song()
                {
                    Id = 217,
                    Title = "Feeling U, Feeling Me",
                    Duration = "2:07",
                    AlbumId = 16
                },

                new Song()
                {
                    Id = 218,
                    Title = "Slow Down",
                    Duration = "4:18",
                    AlbumId = 16
                },

                new Song()
                {
                    Id = 219,
                    Title = "Samsonite Man",
                    Duration = "4:12",
                    AlbumId = 16
                },

                new Song()
                {
                    Id = 220,
                    Title = "Nobody Not Really",
                    Duration = "2:56",
                    AlbumId = 16
                },

                new Song()
                {
                    Id = 221,
                    Title = "As I Am (Intro)",
                    Duration = "1:52",
                    AlbumId = 17
                },

                new Song()
                {
                    Id = 222,
                    Title = "Go Ahead",
                    Duration = "4:36",
                    AlbumId = 17
                },

                new Song()
                {
                    Id = 223,
                    Title = "Superwoman",
                    Duration = "4:34",
                    AlbumId = 17
                },

                new Song()
                {
                    Id = 224,
                    Title = "No One",
                    Duration = "4:12",
                    AlbumId = 17
                },

                new Song()
                {
                    Id = 225,
                    Title = "Like You'll Never See Me Again",
                    Duration = "5:15",
                    AlbumId = 17
                },

                new Song()
                {
                    Id = 226,
                    Title = "Lesson Learned",
                    Duration = "4:14",
                    AlbumId = 17
                },

                new Song()
                {
                    Id = 227,
                    Title = "Wreckless Love",
                    Duration = "3:53",
                    AlbumId = 17
                },

                new Song()
                {
                    Id = 228,
                    Title = "The Thing About Love",
                    Duration = "3:50",
                    AlbumId = 17
                },

                new Song()
                {
                    Id = 229,
                    Title = "Teenage Love Affair",
                    Duration = "3:10",
                    AlbumId = 17
                },

                new Song()
                {
                    Id = 230,
                    Title = "I Need You",
                    Duration = "5:10",
                    AlbumId = 17
                },

                new Song()
                {
                    Id = 231,
                    Title = "Where Do We Go from Here",
                    Duration = "4:11",
                    AlbumId = 17
                },

                new Song()
                {
                    Id = 232,
                    Title = "Prelude to a Kiss",
                    Duration = "2:08",
                    AlbumId = 17
                },

                new Song()
                {
                    Id = 233,
                    Title = "Tell You Something (Nana's Reprise)",
                    Duration = "4:28",
                    AlbumId = 17
                },

                new Song()
                {
                    Id = 234, 
                    Title = "Sure Looks Good to Me",
                    Duration = "4:31",
                    AlbumId = 17
                },

                new Song()
                {
                    Id = 235,
                    Title = "The Element of Freedom (Intro)",
                    Duration = "0:12",
                    AlbumId = 18
                },

                new Song()
                {
                    Id = 236,
                    Title = "Love is Blind",
                    Duration = "3:49",
                    AlbumId = 18
                },

                new Song()
                {
                    Id = 237,
                    Title = "Doesn't Mean Anything",
                    Duration = "4:32",
                    AlbumId = 18
                },

                new Song()
                {
                    Id = 238,
                    Title = "Try Sleeping with a Broken Heart",
                    Duration = "4:09",
                    AlbumId = 18
                },

                new Song()
                {
                    Id = 239,
                    Title = "Wait Til You See My Smile",
                    Duration = "4:01",
                    AlbumId = 18
                },

                new Song()
                {
                    Id = 240,
                    Title = "That's How Strong My Love Is",
                    Duration = "4:04",
                    AlbumId = 18
                },

                new Song()
                {
                    Id = 241,
                    Title = "Un-Thinkable (I'm Ready)",
                    Duration = "4:09",
                    AlbumId = 18
                },

                new Song()
                {
                    Id = 242,
                    Title = "Love Is My Disease",
                    Duration = "4:01",
                    AlbumId = 18
                },

                new Song()
                {
                    Id = 243,
                    Title = "Like the Sea",
                    Duration = "4:13",
                    AlbumId = 18           
                },

                new Song()
                {
                    Id = 244,
                    Title = "Put It in a Love Song",
                    Duration = "3:15",
                    AlbumId = 18
                },

                new Song()
                {
                    Id = 245,
                    Title = "This Bed",
                    Duration = "3:45",
                    AlbumId = 18
                },

                new Song()
                {
                    Id = 246,
                    Title = "Distance and Time",
                    Duration = "4:27",
                    AlbumId = 18
                },

                new Song()
                {
                    Id = 247,
                    Title = "How It Feels to Fly",
                    Duration = "4:42",
                    AlbumId = 18
                },

                new Song()
                {
                    Id = 248,
                    Title = "Empire State of Mind (Part II) Broken Down",
                    Duration = "3:36",
                    AlbumId = 18
                },

                new Song()
                {
                    Id = 249,
                    Title = "De Novo Adagio (Intro)",
                    Duration = "1:19",
                    AlbumId = 19              
                },

                new Song()
                {
                    Id = 250,
                    Title = "Brand New Me",
                    Duration = "3:53",
                    AlbumId = 19
                },

                new Song()
                {
                    Id = 251,
                    Title = "When It's All Over",
                    Duration = "4:34",
                    AlbumId = 19
                },

                new Song()
                {
                    Id = 252,
                    Title = "Listen to Your Heart",
                    Duration = "3:46",
                    AlbumId = 19
                },

                new Song()
                {
                    Id = 253,
                    Title = "New Day",
                    Duration = "4:02",
                    AlbumId = 19
                },

                new Song()
                {
                    Id = 254,
                    Title = "Girl on Fire",
                    Duration = "4:30",
                    AlbumId = 19
                },

                new Song()
                {
                    Id = 255,
                    Title = "Fire We Make",
                    Duration = "5:21",
                    AlbumId = 19
                },

                new Song()
                {
                    Id = 256,
                    Title = "Tears Always Win",
                    Duration = "3:59",
                    AlbumId = 19
                },

                new Song()
                {
                    Id = 257,
                    Title = "Not Even the King",
                    Duration = "3:07",
                    AlbumId = 19
                },

                new Song()
                {
                    Id = 258,
                    Title = "That's When I Knew",
                    Duration = "4:05",
                    AlbumId = 19
                },

                new Song()
                {
                    Id = 259,
                    Title = "Limitedless",
                    Duration = "3:57",
                    AlbumId = 19
                },

                new Song()
                {
                    Id = 260,
                    Title = "One Thing",
                    Duration = "4:08",
                    AlbumId = 19
                },

                new Song()
                {
                    Id = 261,
                    Title = "101",
                    Duration = "6:29",
                    AlbumId = 19
                },

                new Song()
                {
                    Id = 262,
                    Title = "The Beginning",
                    Duration = "1:04",
                    AlbumId = 20
                },

                new Song()
                {
                    Id = 263,
                    Title = "The Gospel",
                    Duration = "3:01",
                    AlbumId = 20
                },

                new Song()
                {
                    Id = 264,
                    Title = "Pawn It All",
                    Duration = "3:10",
                    AlbumId = 20
                },

                new Song()
                {
                    Id = 265,
                    Title = "Elain Brown (interlude)",
                    Duration = "0:50",
                    AlbumId = 20
                },

                new Song()
                {
                    Id = 266,
                    Title = "Kill Your Mama",
                    Duration = "2:40",
                    AlbumId = 20
                },

                new Song()
                {
                    Id = 267,
                    Title = "She Don't Really Care/1 Luv",
                    Duration = "6:07",
                    AlbumId = 20
                },

                new Song()
                {
                    Id = 268,
                    Title = "Elevate (interlude)",
                    Duration = "0:48",
                    AlbumId = 20
                },

                new Song()
                {
                    Id = 269,
                    Title = "Illusion of Bliss",
                    Duration = "5:23",
                    AlbumId = 20
                },

                new Song()
                {
                    Id = 270,
                    Title = "Blended Family (What You Do for Love)",
                    Duration = "3:31",
                    AlbumId = 20                    
                },

                new Song()
                {
                    Id = 271,
                    Title = "Work on It",
                    Duration = "3:34",
                    AlbumId = 20
                },

                new Song()
                {
                    Id = 272,
                    Title = "Cocoa Butter (Cross & Pic Interlude)",
                    Duration = "0:59",
                    AlbumId = 20
                },

                new Song()
                {
                    Id = 273,
                    Title = "Girl Can't Be Herself",
                    Duration = "2:39",
                    AlbumId = 20                
                },

                new Song()
                {
                    Id = 274,
                    Title = "You Glow (interlude)",
                    Duration = "0:25",
                    AlbumId = 20
                },

                new Song()
                {
                    Id = 275,
                    Title = "More than We Know",
                    Duration = "4:35",
                    AlbumId = 20
                },

                new Song()
                {
                    Id = 276,
                    Title = "Where Do We Begin Now",
                    Duration = "2:47",
                    AlbumId = 20
                },

                new Song()
                {
                    Id = 277,
                    Title = "Holy War",
                    Duration = "4:22",
                    AlbumId =20
                });

        }
    }
}
