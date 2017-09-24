using BDSA2017.Assignment04.Entities;
using ExtensionMethods;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using Xunit;

namespace BDSA2017.Assignment04.Tests
{
    public class QueriesTests
    {
        List<Cars> TrackTestCars;
        List<Tracks> TrackTestTracks;
        List<Races> TrackTestRaces;
        List<CarInRaces> TrackTestCarInRaces;

        List<Cars> RaceTestCars;
        List<Tracks> RaceTestTracks;
        List<Races> RaceTestRaces;
        List<CarInRaces> RaceTestCarInRaces;
        public QueriesTests()
        {
            TrackTestCars = new List<Cars> { new Cars() {  DriverName = "Hans", Name ="WW"},
                                         new Cars() {  DriverName = "Lars", Name ="WP"},
                                         new Cars() {  DriverName = "Karl", Name ="PW"},
                                         new Cars() {  DriverName = "Mans", Name ="PP"}
            };
            TrackTestTracks = new List<Tracks> { new Tracks() {  BestTime = 2200000000, Length = 5.5, MaxCars  = 76, Name = "LongTrack"},
                                         new Tracks() {  BestTime = 1000000001, Length = 2, MaxCars  = 50, Name = "ShortTrack"},
                                         new Tracks() {  BestTime = 100000004, Length = 2.3, MaxCars  = 254, Name = "MediumTrack"},
                                         new Tracks() { BestTime = 100000000002, Length = 4.4, MaxCars  = 1, Name = "DosntCountTrack"}
            };
            TrackTestRaces = new List<Races> { new Races() { Tracks = TrackTestTracks[0], ActualEndTime = new DateTime(1999,5,3), ActualStartTime = new DateTime(1999,3,4),
                PlannedEndTime = new DateTime(2000,11,4),PlannedStartTime = new DateTime(2001,1,3),NumberOfLaps = 10},
                                         new Races() {Tracks =TrackTestTracks[0],  ActualEndTime = new DateTime(1999,6,3), ActualStartTime = new DateTime(1999,4,4),
                PlannedEndTime = new DateTime(2000,11,4),PlannedStartTime = new DateTime(2001,2,3),NumberOfLaps = 15 },
                                         new Races() {Tracks = TrackTestTracks[0],  ActualEndTime = new DateTime(1999,1,3), ActualStartTime = new DateTime(1999,3,1),
                PlannedEndTime = new DateTime(2000,11,1),PlannedStartTime = new DateTime(2011,1,3),NumberOfLaps = 20 },
                                         new Races() {Tracks = TrackTestTracks[0], ActualEndTime = new DateTime(1997,5,3), ActualStartTime = new DateTime(1959,3,4),
                PlannedEndTime = new DateTime(2001,2,4),PlannedStartTime = new DateTime(2001,1,3),NumberOfLaps = 10}
            };
            TrackTestCarInRaces = new List<CarInRaces> { new CarInRaces() { Cars = TrackTestCars[0],Races = TrackTestRaces[0], BestLap = 2345524323, EndPosition =5, StartPosition = 1,TotalRaceTime = 200200000},
                                         new CarInRaces() { Cars = TrackTestCars[1], Races = TrackTestRaces[1],  BestLap = 412455235235434, EndPosition =1, StartPosition = 4,TotalRaceTime = 2000001210},
                                         new CarInRaces() {Cars = TrackTestCars[2],Races = TrackTestRaces[2],  BestLap = 5415115422134214, EndPosition =2, StartPosition = 3,TotalRaceTime = 200300},
                                         new CarInRaces() { Cars = TrackTestCars[3],Races = TrackTestRaces[3], BestLap = 42113423141234, EndPosition =3, StartPosition = 2,TotalRaceTime = 2000000}
            };




            RaceTestCars = new List<Cars> { new Cars() {  DriverName = "Hans", Name ="WW"},
                                         new Cars() {  DriverName = "Lars", Name ="WP"},
                                         new Cars() {  DriverName = "Karl", Name ="PW"},
                                         new Cars() {  DriverName = "Mans", Name ="PP"},
                                         new Cars() {  DriverName = "Rasmus", Name ="WW"},
                                         new Cars() {  DriverName = "Harse", Name ="WPGGGG"},
                                         new Cars() {  DriverName = "Rick", Name ="PWCACA"},
                                         new Cars() {  DriverName = "Morty", Name ="PPsAAS"},
                                         new Cars() {  DriverName = "Mikkel", Name ="WWA"},
                                         new Cars() {  DriverName = "Lars", Name ="WPA"},
                                         new Cars() {  DriverName = "Sven", Name ="PWS"},
                                         new Cars() {  DriverName = "August", Name ="PPD"}

             };
           
            RaceTestTracks = new List<Tracks> { new Tracks() {  BestTime = 2200000000, Length = 5.5, MaxCars  = 76, Name = "LongTrack"},
                                         new Tracks() {  BestTime = 1000000001, Length = 2, MaxCars  = 50, Name = "ShortTrack"},
                                         new Tracks() {  BestTime = 100000004, Length = 2.3, MaxCars  = 254, Name = "MediumTrack"},
                                         new Tracks() { BestTime = 100000000002, Length = 4.4, MaxCars  = 1, Name = "DosntCountTrack"}
            };
            RaceTestRaces = new List<Races> { new Races() { Tracks =RaceTestTracks[0], ActualEndTime = new DateTime(1999,5,3), ActualStartTime = new DateTime(1999,3,4),
                PlannedEndTime = new DateTime(2000,11,4),PlannedStartTime = new DateTime(2001,1,3),NumberOfLaps = 10},
                                         new Races() {Tracks =RaceTestTracks[0],  ActualEndTime = new DateTime(1999,6,3), ActualStartTime = new DateTime(1999,4,4),
                PlannedEndTime = new DateTime(2000,11,4),PlannedStartTime = new DateTime(2001,2,3),NumberOfLaps = 15 },
                                         new Races() {Tracks = RaceTestTracks[0],  ActualEndTime = new DateTime(1999,1,3), ActualStartTime = new DateTime(1999,3,1),
                PlannedEndTime = new DateTime(2000,11,1),PlannedStartTime = new DateTime(2011,1,3),NumberOfLaps = 20 },
                                         new Races() {Tracks = RaceTestTracks[0], ActualEndTime = new DateTime(1997,5,3), ActualStartTime = new DateTime(1959,3,4),
                PlannedEndTime = new DateTime(2001,2,4),PlannedStartTime = new DateTime(2001,1,3),NumberOfLaps = 10}
            };
            RaceTestCarInRaces = new List<CarInRaces> { new CarInRaces() { Cars = RaceTestCars[0],Races = RaceTestRaces[0], BestLap = 22131223, EndPosition =5, StartPosition = 1,TotalRaceTime = 20020030},
                                         new CarInRaces() { Cars = RaceTestCars[1], Races =RaceTestRaces[1],  BestLap = 41245523334, EndPosition =1, StartPosition = 4,TotalRaceTime = 24214210},
                                         new CarInRaces() {Cars = RaceTestCars[2],Races = RaceTestRaces[2],  BestLap = 541511542213421124, EndPosition =2, StartPosition = 3,TotalRaceTime = 2041245200},
                                         new CarInRaces() { Cars = RaceTestCars[3],Races = RaceTestRaces[3], BestLap = 4211342321234, EndPosition =3, StartPosition = 2,TotalRaceTime = 2241240},
                                         new CarInRaces() { Cars = RaceTestCars[4],Races = RaceTestRaces[0], BestLap = 2345524212213, EndPosition =5, StartPosition = 1,TotalRaceTime = 201241},
                                         new CarInRaces() { Cars = RaceTestCars[5], Races = RaceTestRaces[1], BestLap = 41245522434, EndPosition = 1, StartPosition = 4, TotalRaceTime = 121412421412 },
                                         new CarInRaces() { Cars = RaceTestCars[6], Races = RaceTestRaces[2], BestLap = 541511521114214, EndPosition = 2, StartPosition = 3, TotalRaceTime = 2042141421 },
                                         new CarInRaces() { Cars = RaceTestCars[7], Races = RaceTestRaces[3], BestLap = 421134, EndPosition = 3, StartPosition = 2, TotalRaceTime = 24211 },
                                         new CarInRaces() { Cars = RaceTestCars[0],Races = RaceTestRaces[0], BestLap = 23452121223, EndPosition = 5, StartPosition = 1,TotalRaceTime = 2004124214},
                                         new CarInRaces() { Cars = RaceTestCars[8], Races = RaceTestRaces[1],  BestLap = 4124552134, EndPosition = 1, StartPosition = 4,TotalRaceTime = 20042140},
                                         new CarInRaces() { Cars = RaceTestCars[9],Races = RaceTestRaces[2],  BestLap = 54151154221121214, EndPosition = 2, StartPosition = 3,TotalRaceTime = 41200},
                                         new CarInRaces() { Cars = RaceTestCars[10],Races = RaceTestRaces[3], BestLap = 421134231412342112, EndPosition = 3, StartPosition = 2,TotalRaceTime = 2041241200}
    };

        }
        

        [Fact]
        public void TestTrackInfo()
        {

            using (RaceContext context = new RaceContext())
            {
                context.Races.Clear();
                context.Cars.Clear();
                context.Tracks.Clear();
                context.CarInRaces.Clear();
                context.Cars.AddRange(TrackTestCars);
                context.Tracks.AddRange(TrackTestTracks);
                context.Races.AddRange(TrackTestRaces);
                context.CarInRaces.AddRange(TrackTestCarInRaces);
                context.SaveChanges();
                Queries querie = new Queries(); 
                var trackInfo = querie.GetTrackInfo(TrackTestTracks[0].Id);
                var expected = new TrackInfo()
                {
                    Id = TrackTestTracks[0].Id,
                    FastestLap = TimeSpan.FromTicks(2345524323),
                    FastestsCar = "PW",
                    FastestsDriver = "Karl",
                    Name = "LongTrack",
                    NumberOfRaces = 4
                };
                
                Assert.Equal(expected.ToString(), trackInfo.ToString());
                
            }


        }
        [Fact]
        public void TestRaceInfo()
        {
            using (RaceContext context = new RaceContext())
            {
                context.Races.Clear();
                context.Cars.Clear();
                context.Tracks.Clear();
                context.CarInRaces.Clear();
                context.Cars.AddRange(RaceTestCars);
                context.Tracks.AddRange(RaceTestTracks);
                context.Races.AddRange(RaceTestRaces);
                context.CarInRaces.AddRange(RaceTestCarInRaces);
                context.SaveChanges();
                Queries queries = new Queries();
                var raceInfo = queries.GetRaceInfo(RaceTestRaces[2].Id);
                var expected = new RaceInfo()
                {
                    RaceId = RaceTestRaces[2].Id,
                    ActualEnd = RaceTestRaces[2].ActualEndTime,
                    ActualStart = RaceTestRaces[2].ActualStartTime,
                    NumberOfLaps = RaceTestRaces[2].NumberOfLaps,
                    PlannedEnd = RaceTestRaces[2].PlannedEndTime,
                    PlannedStart = RaceTestRaces[2].PlannedStartTime,
                    TrackId = RaceTestRaces[2].Tracks.Id,
                    TrackName = RaceTestRaces[2].Tracks.Name,
               
                    Cars = CreateListOfCarInfo(new CarInRaces[3] { RaceTestCarInRaces[2], RaceTestCarInRaces[6], RaceTestCarInRaces[10] })

                };
                
                Assert.Equal(expected.ToString(), raceInfo.ToString());

            }
        }


        public IEnumerable<CarInfo> CreateListOfCarInfo(CarInRaces[] cars)
        {
            CarInfo[] infos = new CarInfo[3];
           
            for(int i = 0; i< 3; i++)
            {
                CarInfo info = new CarInfo()
                {
                    BestLapInTicks = cars[i].BestLap,
                    EndPosition = cars[i].EndPosition,
                    StartPosition = cars[i].StartPosition,
                    TotalRaceTimeInTicks = cars[i].TotalRaceTime,
                    CarId = cars[i].Cars.Id,
                    CarName = cars[i].Cars.Name,
                    DriverName = cars[i].Cars.DriverName
                };
                infos[i] = info;
            }
            return infos;
        }
    
    }
        
}
