using BDSA2017.Assignment04.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using ExtensionMethods;
namespace BDSA2017.Assignment04
{
    public class Program
    {
        static void Main(string[] args)
        {
            var contex = new RaceContext();
            Seed(contex);
           

        }

            public static void Seed(RaceContext context)
            {
            var rangeCars = new List<Cars> { new Cars() {  DriverName = "Hans", Name ="WW"},
                                         new Cars() {  DriverName = "Lars", Name ="WP"},
                                         new Cars() {  DriverName = "Karl", Name ="PW"},
                                         new Cars() {  DriverName = "Mans", Name ="PP"}
            };
            var rangeTracks = new List<Tracks> { new Tracks() {  BestTime = 2200000000, Length = 5.5, MaxCars  = 76, Name = "LongTrack"},
                                         new Tracks() {  BestTime = 1000000001, Length = 2, MaxCars  = 50, Name = "ShortTrack"},
                                         new Tracks() {  BestTime = 100000004, Length = 2.3, MaxCars  = 254, Name = "MediumTrack"},
                                         new Tracks() { BestTime = 100000000002, Length = 4.4, MaxCars  = 1, Name = "DosntCountTrack"}
            };
            var rangeRaces = new List<Races> { new Races() { Tracks = rangeTracks[0], ActualEndTime = new DateTime(1999,5,3), ActualStartTime = new DateTime(1999,3,4),
                PlannedEndTime = new DateTime(2000,11,4),PlannedStartTime = new DateTime(2001,1,3),NumberOfLaps = 10},
                                         new Races() {Tracks = rangeTracks[0],  ActualEndTime = new DateTime(1999,6,3), ActualStartTime = new DateTime(1999,4,4),
                PlannedEndTime = new DateTime(2000,11,4),PlannedStartTime = new DateTime(2001,2,3),NumberOfLaps = 15 },
                                         new Races() {Tracks = rangeTracks[0],  ActualEndTime = new DateTime(1999,1,3), ActualStartTime = new DateTime(1999,3,1),
                PlannedEndTime = new DateTime(2000,11,1),PlannedStartTime = new DateTime(2011,1,3),NumberOfLaps = 20 },
                                         new Races() {Tracks = rangeTracks[3], ActualEndTime = new DateTime(1997,5,3), ActualStartTime = new DateTime(1959,3,4),
                PlannedEndTime = new DateTime(2001,2,4),PlannedStartTime = new DateTime(2001,1,3),NumberOfLaps = 10}
            };
            var rangeCarInRaces = new List<CarInRaces> { new CarInRaces() { Cars = rangeCars[0],Races = rangeRaces[0], BestLap = 10000000, EndPosition =5, StartPosition = 1,TotalRaceTime = 20020},
                                         new CarInRaces() { Cars = rangeCars[1], Races = rangeRaces[1],  BestLap = 100003000, EndPosition =1, StartPosition = 4,TotalRaceTime = 2000001210},
                                         new CarInRaces() {Cars = rangeCars[2],Races = rangeRaces[2],  BestLap = 100002000, EndPosition =2, StartPosition = 3,TotalRaceTime = 200300},
                                         new CarInRaces() { Cars = rangeCars[3],Races = rangeRaces[3], BestLap = 100000010, EndPosition =3, StartPosition = 2,TotalRaceTime = 2000000}
            };
            using (context)
            {
                context.Cars.AddRange(rangeCars);
                context.Tracks.AddRange(rangeTracks);
                context.Races.AddRange(rangeRaces);
                context.CarInRaces.AddRange(rangeCarInRaces);
                context.SaveChanges();
            }

        }

    
        public static void Clear(RaceContext context)
            {
            using (context)
            {
                context.Races.Clear();
                context.Cars.Clear();
                context.Tracks.Clear();
                context.CarInRaces.Clear();
                context.SaveChanges();
            }

            }
        }
    }

