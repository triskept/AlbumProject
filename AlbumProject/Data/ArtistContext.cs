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

                }
                
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
                    Id = 1,
                    Title = "Man On The Moon",
                    ArtistId = 1,
                    Image = "/images/MotM1.jpg",
                    Label = "Universal Records"
                },
                new Album()
                {
                    Id = 2,
                    Title = "Man On The Moon 2",
                    ArtistId = 1,
                    Image = "/images/MotM2.jpg",
                    Label = "Universal Motown Records"
                },
                new Album()
                {
                    Id = 3,
                    Title = "Indicud",
                    ArtistId = 1,
                    Image = "/images/Indicud.jpg",
                    Label = "Republic Records"
                },
                new Album()
                {
                    Id = 4,
                    Title = "Satellite Flight: The Journey to Mother Moon",
                    ArtistId = 1,
                    Image = "/images/satellite.jpg",
                    Label = "Kid Cudi P/S"
                },
                new Album()
                {
                    Id = 5,
                    Title = "Speedin' Bullet 2 Heaven",
                    ArtistId = 1,
                    Image = "/images/SB2H.jpg",
                    Label = "Republic Records"
                },
                new Album()
                {
                    Id = 6,
                    Title = "Passion, Pain & Demon Slayin",
                    ArtistId = 1,
                    Image = "/images/PP&DS.jpg",
                    Label = "Republic Records"
                });
                
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
                    Id = 1,
                    Title = "In My Dreams(Cudder Anthem)",
                    Duration = "3:15",
                    AlbumId = 1
                },
                new Song()
                {
                    Id = 2,
                    Title = "Soundtrack 2 My Life",
                    Duration = "3:56",
                    AlbumId = 1
                },
                new Song()
                {
                    Id = 3,
                    Title = "Simple As…",
                    Duration = "2:32",
                    AlbumId = 1
                },
                new Song()
                {
                    Id = 4,
                    Title = "Solo Dolo (Nightmare)",
                    Duration = "4:26",
                    AlbumId = 1
                },
                new Song()
                {
                    Id = 5,
                    Title = "Heart Of A Lion",
                    Duration = "4:21",
                    AlbumId = 1
                },
                new Song()
                {
                    Id = 6,
                    Title = "My World",
                    Duration = "4:03",
                    AlbumId = 1
                },
                new Song()
                {
                    Id = 7,
                    Title = "Day ‘N’ Nite (nightmare)",
                    Duration = "3:42",
                    AlbumId = 1
                },
                new Song()
                {
                    Id = 8,
                    Title = "Sky Might Fall",
                    Duration = "3:41",
                    AlbumId = 1
                },
                new Song()
                {
                    Id = 9,
                    Title = "Enter Galactic (Love Connection Part 1)",
                    Duration = "4:20",
                    AlbumId = 1
                },
                new Song()
                {
                    Id = 10,
                    Title = "Alive (Nightmare)",
                    Duration = "4:06",
                    AlbumId = 1
                },
                new Song()
                {
                    Id = 11,
                    Title = "Make Her Say",
                    Duration = "3:36",
                    AlbumId = 1
                },
                new Song()
                {
                    Id = 12,
                    Title = "Pursuit Of Happiness (Nightmare)",
                    Duration = "4:55",
                    AlbumId = 1
                },
                new Song()
                {
                    Id = 13,
                    Title = "Hyyerr",
                    Duration = "3:32",
                    AlbumId = 1
                },
                new Song()
                {
                    Id = 14,
                    Title = "Up Up & Away",
                    Duration = "3:46",
                    AlbumId = 1
                },
                new Song()
                {
                    Id = 15,
                    Title = "In My Dreams(Cudder Anthem)",
                    Duration = "3:46",
                    AlbumId = 1
                },
                new Song()
                {
                    Id = 16,
                    Title = "Scott Mesucdi Vs The World",
                    Duration = "3:55",
                    AlbumId = 2
                },
                new Song()
                {
                    Id = 17,
                    Title = "REVOFEV",
                    Duration = "3:03",
                    AlbumId = 2
                },
                new Song()
                {
                    Id = 18,
                    Title = "Don’t Play This Song",
                    Duration = "3:43",
                    AlbumId = 2
                },
                new Song()
                {
                    Id = 19,
                    Title = "We Aite (Wake Your Mind Up)",
                    Duration = "1:27",
                    AlbumId = 2
                },
                new Song()
                {
                    Id = 20,
                    Title = "Marijuana",
                    Duration = "4:20",
                    AlbumId = 2
                },
                new Song()
                {
                    Id = 21,
                    Title = "Mojo So Dope",
                    Duration = "3:31",
                    AlbumId = 2
                },
                new Song()
                {
                    Id = 22,
                    Title = "Ashin’ Kusher",
                    Duration = "3:48",
                    AlbumId = 2
                },
                new Song()
                {
                    Id = 23,
                    Title = "Erase Me",
                    Duration = "3:12",
                    AlbumId = 2
                },
                new Song()
                {
                    Id = 24,
                    Title = "Wild’n Cuz I’m Young",
                    Duration = "4:14",
                    AlbumId = 2
                },
                new Song()
                {
                    Id = 25,
                    Title = "The Mood",
                    Duration = "2:36",
                    AlbumId = 2
                },

              new Song()
                {
                    Id = 26,
                    Title = "MANIAC",
                    Duration = "2:58",
                    AlbumId = 2
                },
                new Song()
                {
                    Id = 27,
                    Title = "Mr. Rager",
                    Duration = "4:54",
                    AlbumId = 2
                },
                new Song()
                {
                    Id = 28,
                    Title = "These Worries",
                    Duration = "4:16",
                    AlbumId = 2
                },
                new Song()
                {
                    Id = 29,
                    Title = "The End",
                    Duration = "4:20",
                    AlbumId = 2
                },
                new Song()
                {
                    Id = 30,
                    Title = "All Along",
                    Duration = "3:23",
                    AlbumId = 2
                },
                new Song()
                {
                    Id = 31,
                    Title = "GHOST!",
                    Duration = "4:49",
                    AlbumId = 2
                },
                new Song()
                {
                    Id = 32,
                    Title = "Trapped In My Mind",
                    Duration = "3:33",
                    AlbumId = 2
                },
                new Song()
                {
                    Id = 33,
                    Title = "The Resurrection Of Scott Mescudi",
                    Duration = "2:41",
                    AlbumId = 3
                },
                new Song()
                {
                    Id = 34,
                    Title = "Unfuckwittable",
                    Duration = "4:36",
                    AlbumId = 3
                },
                new Song()
                {
                    Id = 35,
                    Title = "Just What I Am",
                    Duration = "3:48",
                    AlbumId = 3
                },
                new Song()
                {
                    Id = 36,
                    Title = "Young Lady",
                    Duration = "4:24",
                    AlbumId = 3
                },
                new Song()
                {
                    Id = 37,
                    Title = "King Wizard",
                    Duration = "4:16",
                    AlbumId = 3
                },
                new Song()
                {
                    Id = 38,
                    Title = "Immortal",
                    Duration = "5:02",
                    AlbumId = 3
                },
                new Song()
                {
                    Id = 39,
                    Title = "Solo Dolo Part II ",
                    Duration = "3:34",
                    AlbumId = 3
                },
                new Song()
                {
                    Id = 40,
                    Title = "Girls",
                    Duration = "4:28",
                    AlbumId = 3
                },
                new Song()
                {
                    Id = 41,
                    Title = "New York City Rage Fest",
                    Duration = "1:53",
                    AlbumId = 3
                },
                new Song()
                {
                    Id = 42,
                    Title = "Red Eye",
                    Duration = "3:55",
                    AlbumId = 3
                },
                new Song()
                {
                    Id = 43,
                    Title = "Mad Solar",
                    Duration = "4:09",
                    AlbumId = 3
                },
                new Song()
                {
                    Id = 44,
                    Title = "Beez",
                    Duration = "3:13",
                    AlbumId = 3
                },
                new Song()
                {
                    Id = 45,
                    Title = "Brothers",
                    Duration = "4:41",
                    AlbumId = 3
                },
                new Song()
                {
                    Id = 46,
                    Title = "Burn Baby Burn",
                    Duration = "2:58",
                    AlbumId = 3
                },
                new Song()
                {
                    Id = 47,
                    Title = "Lord Of The Sad And Lonely",
                    Duration = "2:47",
                    AlbumId = 3
                },
                new Song()
                {
                    Id = 48,
                    Title = "Cold Blooded",
                    Duration = "2:32",
                    AlbumId = 3
                },
                new Song()
                {
                    Id = 49,
                    Title = "Afterwards (Bring Yo Friends)",
                    Duration = "9:03",
                    AlbumId = 3
                },
                new Song()
                {
                    Id = 50,
                    Title = "The Flight Of The Moon Man",
                    Duration = "2:51",
                    AlbumId = 3
                },
                new Song()
                {
                    Id = 51,
                    Title = "Destination: Mother Moon",
                    Duration = "1:50",
                    AlbumId = 4
                },
                new Song()
                {
                    Id = 52,
                    Title = "Going To The Ceremony",
                    Duration = "3:48",
                    AlbumId = 4
                },
                new Song()
                {
                    Id = 53,
                    Title = "SATELLITE FLIGHT",
                    Duration = "4:35",
                    AlbumId = 4
                },
                new Song()
                {
                    Id = 54,
                    Title = "Copernicus Landing",
                    Duration = "4:34",
                    AlbumId = 4
                },
                new Song()
                {
                    Id = 55,
                    Title = "Balmain Jeans",
                    Duration = "5:27",
                    AlbumId = 4
                },
                new Song()
                {
                    Id = 56,
                    Title = "Too Bad I Have To Destroy You Now",
                    Duration = "6:18",
                    AlbumId = 4
                },
                new Song()
                {
                    Id = 57,
                    Title = "Internal Bleeding",
                    Duration = "4:16",
                    AlbumId = 4
                },
                new Song()
                {
                    Id = 58,
                    Title = "In My Dreams 2015",
                    Duration = "1:46",
                    AlbumId = 4
                },
                new Song()
                {
                    Id = 59,
                    Title = "Return Of The Moon Man",
                    Duration = "5:15",
                    AlbumId = 4
                },
                new Song()
                {
                    Id = 60,
                    Title = "Troubled Boy",
                    Duration = "3:21",
                    AlbumId = 5
                },
                new Song()
                {
                    Id = 61,
                    Title = "Edge Of The Earth/Post Mortem Boredom",
                    Duration = "4:43",
                    AlbumId = 5
                },
                new Song()
                {
                    Id = 62,
                    Title = "CONFUSED!",
                    Duration = "3:56",
                    AlbumId = 5
                },
                new Song()
                {
                    Id = 63,
                    Title = "Man In The Night",
                    Duration = "3:50",
                    AlbumId = 5
                },
                new Song()
                {
                    Id = 64,
                    Title = "Screwed",
                    Duration = "2:28",
                    AlbumId = 5
                },
                new Song()
                {
                    Id = 65,
                    Title = "Fade 2 Red",
                    Duration = "2:58",
                    AlbumId = 5
                },
                new Song()
                {
                    Id = 66,
                    Title = "Adventures",
                    Duration = "6:10",
                    AlbumId = 5
                },
                new Song()
                {
                    Id = 67,
                    Title = "The Nothing",
                    Duration = "3:31",
                    AlbumId = 5
                },
                new Song()
                {
                    Id = 68,
                    Title = "AMEN",
                    Duration = "3:04",
                    AlbumId = 5
                },
                new Song()
                {
                    Id = 69,
                    Title = "Handle With Care",
                    Duration = "3:45",
                    AlbumId = 5
                },
                new Song()
                {
                    Id = 70,
                    Title = "Judgemental C**t",
                    Duration = "3:05",
                    AlbumId = 5
                },
                new Song()
                {
                    Id = 71,
                    Title = "Seance Chaos",
                    Duration = "1:54",
                    AlbumId = 5
                },
                new Song()
                {
                    Id = 72,
                    Title = "Fairy Tale Remains",
                    Duration = "3:06",
                    AlbumId = 5
                },
                new Song()
                {
                    Id = 73,
                    Title = "Wedding Tux",
                    Duration = "2:32",
                    AlbumId = 5
                },
                new Song()
                {
                    Id = 74,
                    Title = "Angered Kids",
                    Duration = "3:30",
                    AlbumId = 5
                },
                new Song()
                {
                    Id = 75,
                    Title = "Red Sabbath",
                    Duration = "4:38",
                    AlbumId = 5
                },
                new Song()
                {
                    Id = 76,
                    Title = "Fuchsia Butterflies",
                    Duration = "2:45",
                    AlbumId = 5
                },
                new Song()
                {
                    Id = 77,
                    Title = "Speedin Bullet 2 Heaven",
                    Duration = "4:35",
                    AlbumId = 5
                },
                new Song()
                {
                    Id = 78,
                    Title = "Embers",
                    Duration = "3:01",
                    AlbumId = 5
                },
                new Song()
                {
                    Id = 79,
                    Title = "Anomaly",
                    Duration = "4:35",
                    AlbumId = 5
                },
                new Song()
                {
                    Id = 80,
                    Title = "The Return of Chip Douglas",
                    Duration = "4:15",
                    AlbumId = 5
                },
                new Song()
                {
                    Id = 81,
                    Title = "Trauma",
                    Duration = "2:44",
                    AlbumId = 5
                },
                new Song()
                {
                    Id = 82,
                    Title = "WAIT",
                    Duration = "1:58",
                    AlbumId = 5
                },
                new Song()
                {
                    Id = 83,
                    Title = "Insides Out",
                    Duration = "3:07",
                    AlbumId = 5
                },
                new Song()
                {
                    Id = 84,
                    Title = "Speedin’ Bullet 2 Heaven",
                    Duration = "3:24",
                    AlbumId = 5
                },
                new Song()
                {
                    Id = 85,
                    Title = "Worth",
                    Duration = "5:17",
                    AlbumId = 5
                },
                new Song()
                {
                    Id = 86,
                    Title = "Frequency",
                    Duration = "4:58",
                    AlbumId = 5
                },
                new Song()
                {
                    Id = 87,
                    Title = "Swim In The Light",
                    Duration = "4:29",
                    AlbumId = 6
                },
                new Song()
                {
                    Id = 88,
                    Title = "Releaser",
                    Duration = "5:28",
                    AlbumId = 6
                },
                new Song()
                {
                    Id = 89,
                    Title = "By Design",
                    Duration = "4:17",
                    AlbumId = 6
                },
                new Song()
                {
                    Id = 90,
                    Title = "All In",
                    Duration = "4:11",
                    AlbumId = 6
                },
                new Song()
                {
                    Id = 91,
                    Title = "ILLusions",
                    Duration = "4:16",
                    AlbumId = 6
                },
                new Song()
                {
                    Id = 92,
                    Title = "Rose Golden",
                    Duration = "4:38",
                    AlbumId = 6
                },
                new Song()
                {
                    Id = 93,
                    Title = "Baptized In Fire",
                    Duration = "4:45",
                    AlbumId = 6
                },
                new Song()
                {
                    Id = 94,
                    Title = "Flight At First Sight/Advanced",
                    Duration = "3:57",
                    AlbumId = 6
                },
                new Song()
                {
                    Id = 95,
                    Title = "Does It",
                    Duration = "4:23",
                    AlbumId = 6
                },
                new Song()
                {
                    Id = 96,
                    Title = "Dance 4 Eternity",
                    Duration = "4:43",
                    AlbumId = 6
                },
                new Song()
                {
                    Id = 97,
                    Title = "Distant Fantasies",
                    Duration = "4:47",
                    AlbumId = 6
                },
                new Song()
                {
                    Id = 98,
                    Title = "Wounds",
                    Duration = "4:03",
                    AlbumId = 6
                },
                new Song()
                {
                    Id = 99,
                    Title = "Mature Nature",
                    Duration = "3:55",
                    AlbumId = 6
                },
                new Song()
                {
                    Id = 100,
                    Title = "Kitchen",
                    Duration = "4:29",
                    AlbumId = 6
                },
                new Song()
                {
                    Id = 101,
                    Title = "Cosmic Warrior",
                    Duration = "4:01",
                    AlbumId = 6
                },
                new Song()
                {
                    Id = 102,
                    Title = "The Guide",
                    Duration = "5:06",
                    AlbumId = 6
                },
                new Song()
                {
                    Id = 103,
                    Title = "The Commander",
                    Duration = "4:16",
                    AlbumId = 6
                },
                new Song()
                {
                    Id = 104,
                    Title = "Surfin’",
                    Duration = "6:15",
                    AlbumId = 6
                },
                
                new Song()
                {
                    Id = 152,
                    Title = "Cluster One",
                    Duration = "5:56",
                    AlbumId = 11
                },
              new Song()
              {
                    Id = 105,
                    Title = "Radioactive",
                    Duration = "3:07",
                    AlbumId = 7,
                },

                new Song()
                {

                    Id = 153,
                    Title = "What Do You Want From Me",
                    Duration = "4:22",
                    AlbumId = 11
                }
                
                new Song()
                {
                    Id = 106,
                    Title = "Tiptoe",
                    Duration = "3:14",
                    AlbumId = 7,

                },

                new Song()
                {

                    Id = 154,
                    Title = "Poles Apart",
                    Duration = "7:03",
                    AlbumId = 11
                },
                
                new Song()
                    Id = 107,
                    Title = "It's Time",
                    Duration = "4:01",
                    AlbumId = 7,

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
                    Id = 108,
                    Title = "Demons",
                    Duration = "2:58",
                    AlbumId = 7,
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
                    Id = 109,
                    Title = "On Top Of The World",
                    Duration = "3:10",
                    AlbumId = 7,
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
                    Id = 110,
                    Title = "Amsterdam",
                    Duration = "4:02",
                    AlbumId = 7,
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
                    Id = 111,
                    Title = "Hear Me",
                    Duration = "3:53",
                    AlbumId = 7,
                },

                new Song()
                {
                    Id = 159,
                    Title = "Coming Back To Life",
                    Duration = "6:19",
                    AlbumId = 11
                },
                
                new Song ()
                {
                    Id = 112,
                    Title = "Every Night",
                    Duration = "3:36",
                    AlbumId = 7,
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
                    Id = 113,
                    Title = "Bleeding Out",
                    Duration = "3:42",
                    AlbumId = 7,
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
                    Id = 114,
                    Title = "Underdog",
                    Duration = "3:27",
                    AlbumId = 7,
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
                    Id = 115,
                    Title = "Nothing Left To Say/Rocks",
                    Duration = "8:57",
                    AlbumId = 7,
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
                    Id = 116,
                    Title = "Shots",
                    Duration = "3:53",
                    AlbumId = 8,
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
                    Id = 117,
                    Title = "Gold",
                    Duration = "3:37",
                    AlbumId = 8,
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
                    Id = 166,
                    Title = "Fat Old Sun",
                    Duration = "5:24",
                    AlbumId = 12
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
                    Id = 167,
                    Title = "Alan's Psychedelic Breakfast",
                    Duration = "12:59",
                    AlbumId = 12
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
                    Id = 168,
                    Title = "The Post War Dream",
                    Duration = "2:59",
                    AlbumId = 13
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
                    Id = 169,
                    Title = "Your Possible Pasts",
                    Duration = "4:26",
                    AlbumId = 13
                },
                
                new Song()
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
                    Id = 170,
                    Title = "One of the Few",
                    Duration = "1:17",
                    AlbumId = 13
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
                    Id = 171,
                    Title = "When the Tigers Broke Free",
                    Duration = "3:12",
                    AlbumId = 13
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
                    Id = 172,
                    Title = "The Hero's Return",
                    Duration = "2:43",
                    AlbumId = 13
                },
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
                    Id = 173,
                    Title = "The Gunner's Dream",
                    Duration = "5:18",
                    AlbumId = 13
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
                    Id = 174,
                    Title = "Paranoid Eyes",
                    Duration = "3:42",
                    AlbumId = 13
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
                    Id = 175,
                    Title = "Get Your Filthy Hands Off My Desert",
                    Duration = "1:17",
                    AlbumId = 13
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
                    Id = 176,
                    Title = "The Fletcher Memorial Home",
                    Duration = "4:09",
                    AlbumId = 13
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
                    Id = 177,
                    Title = "Southampton Dock",
                    Duration = "2:13",
                    AlbumId = 13
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
                    Id = 178,
                    Title = "The Final Cut",
                    Duration = "4:43",
                    AlbumId = 13
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
                    Id = 179,
                    Title = "Not Now John [Explicit]",
                    Duration = "5:01",
                    AlbumId = 13
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
                    Id = 184,
                    Title = "The Great Gig In The Sky",
                    Duration = "4:44",
                    AlbumId = 14
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
                    Id = 185,
                    Title = "Money",
                    Duration = "6:23",
                    AlbumId = 14
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
                    Id = 186,
                    Title = "Us And Them",
                    Duration = "7:49",
                    AlbumId = 14
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
                    Id = 187,
                    Title = "Any Colour You Like",
                    Duration = "3:26",
                    AlbumId = 14
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
                    Id = 188,
                    Title = "Brain Damage",
                    Duration = "3:47",
                    AlbumId = 14
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
                    Id = 189,
                    Title = "Eclipse",
                    Duration = "2:10",
                    AlbumId = 14
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
