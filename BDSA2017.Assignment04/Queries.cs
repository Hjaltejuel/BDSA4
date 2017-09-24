using BDSA2017.Assignment04.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace BDSA2017.Assignment04
{
    public class Queries
    {
        public TrackInfo GetTrackInfo(int trackId)
        {
            using (var contex = new RaceContext())
            {
                Tracks track = contex.Tracks.Find(trackId);
                var races = from a in contex.Races
                            where a.Tracks == track
                            select a;
                
                    var bestLaps = from s in contex.CarInRaces
                                   where s.Races.Tracks == track 
                                   select s.BestLap;

                    var fastestTime = from k in contex.CarInRaces
                                        where k.Races.Tracks == track
                                        select k.TotalRaceTime;
                    var fastest = fastestTime.Min();

                    var fastestCar = from a in contex.CarInRaces
                                     where a.Races.Tracks == track && a.TotalRaceTime == fastest
                                     select a.Cars;
                return new TrackInfo { Name = track.Name, Id = trackId, NumberOfRaces = races.Count(), FastestLap = TimeSpan.FromTicks(bestLaps.Min()),
                    FastestsCar = fastestCar.First().Name, FastestsDriver = fastestCar.First().DriverName };
                    
 
            }
        }

        public RaceInfo GetRaceInfo(int raceId)
        {
            var list = new List<CarInfo>();
            using (var contex = new RaceContext()) {
                Races race = contex.Races.Find(raceId);
                var CarsInDaRace = from a in contex.CarInRaces
                                   where a.Races == race
                                   select a;
                foreach(var carInRace in CarsInDaRace)
                {
                    list.Add(new CarInfo { CarId = carInRace.Cars.Id, CarName = carInRace.Cars.Name,
                        DriverName = carInRace.Cars.DriverName, BestLapInTicks = carInRace.BestLap, EndPosition = carInRace.EndPosition,
                        StartPosition = carInRace.StartPosition, TotalRaceTimeInTicks = carInRace.TotalRaceTime });

                }
                return new RaceInfo { RaceId = race.Id, ActualEnd = race.ActualEndTime,
                    ActualStart = race.ActualStartTime, Cars = list, NumberOfLaps = race.NumberOfLaps,
                    PlannedEnd = race.PlannedEndTime, PlannedStart = race.PlannedStartTime,
                    TrackId = race.Tracks.Id, TrackName = race.Tracks.Name };

     
                    }
        }

    }
}
