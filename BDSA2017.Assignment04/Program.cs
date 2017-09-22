using BDSA2017.Assignment04.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
namespace BDSA2017.Assignment04
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new RaceContext())
            {
                var e = from a in context.Races
                        select a.TrackId;
                       
                foreach(var track in e)
                {
                    Console.WriteLine(track);
                    Console.ReadLine();
                }

            }
        }

            public static void Seed(RaceContext context)
            {
            var rangeCars = new List<Cars> { new Cars() { Id = 1, DriverName = "Hans", Name ="WW"},
                                         new Cars() { Id = 2, DriverName = "Lars", Name ="WP"},
                                         new Cars() { Id = 3, DriverName = "Karl", Name ="PW"},
                                         new Cars() { Id = 4, DriverName = "Mans", Name ="PP"}
            };
            var rangeTracks = new List<Tracks> { new Tracks() { Id = 1, BestTime = 100000000, Length = 5.5, MaxCars  = 76, Name = "LongTrack"},
                                         new Tracks() { Id = 2, BestTime = 1000000000, Length = 2, MaxCars  = 50, Name = "ShortTrack"},
                                         new Tracks() { Id = 3, BestTime = 10000000, Length = 2.3, MaxCars  = 254, Name = "MediumTrack"},
                                         new Tracks() {Id = 4, BestTime = 10000000000, Length = 4.4, MaxCars  = 1, Name = "DosntCountTrack"}
            };
            var rangeRaces = new List<Races> { new Races() { Id = 1, TrackId = 1, ActualEndTime = new DateTime(1999,05,03), ActualStartTime = new DateTime(1999,03,04),
                PlannedEndTime = new DateTime(2000,12,04),PlannedStartTime = new DateTime(2001,01,03),NumberOfLaps = 10},
                                         new Races() { Id = 2,TrackId = 2, ActualEndTime = new DateTime(1999,06,03), ActualStartTime = new DateTime(1999,04,04),
                PlannedEndTime = new DateTime(2000,12,04),PlannedStartTime = new DateTime(2001,02,03),NumberOfLaps = 15 },
                                         new Races() { Id = 3,TrackId = 3, ActualEndTime = new DateTime(1999,01,03), ActualStartTime = new DateTime(1999,03,01),
                PlannedEndTime = new DateTime(2000,12,01),PlannedStartTime = new DateTime(2011,01,03),NumberOfLaps = 20 },
                                         new Races() {Id = 4, TrackId = 4, ActualEndTime = new DateTime(1997,05,03), ActualStartTime = new DateTime(1959,03,04),
                PlannedEndTime = new DateTime(20010,12,04),PlannedStartTime = new DateTime(20021,01,03),NumberOfLaps = 10}
            };
            var rangeTracks = new List<Tracks> { new Tracks() { Id = 1, BestTime = 100000000, Length = 5.5, MaxCars  = 76, Name = "LongTrack"},
                                         new Tracks() { Id = 2, BestTime = 1000000000, Length = 2, MaxCars  = 50, Name = "ShortTrack"},
                                         new Tracks() { Id = 3, BestTime = 10000000, Length = 2.3, MaxCars  = 254, Name = "MediumTrack"},
                                         new Tracks() {Id = 4, BestTime = 10000000000, Length = 4.4, MaxCars  = 1, Name = "DosntCountTrack"}
            };


        }

            public static void Clear(RaceContext context)
            {

            }
        }
    }

