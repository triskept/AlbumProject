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
                },
                new Album()
                {
                    Id = 7,
                    Title = "Night Visions",
                    ArtistId = 2,
                    Image = "/images/nightvisions.jpg",
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

                },
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
                },
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
                    AlbumId = 9
                },
                new Song()
                {
                    Id = 133,
                    Title = "Rise Up",
                    Duration = "3:52",
                    AlbumId = 9
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
                },
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
                   AlbumId = 20
               });
        }
    }
}
