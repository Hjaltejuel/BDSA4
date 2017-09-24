using System;

namespace BDSA2017.Assignment04
{
    public class TrackInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NumberOfRaces { get; set; }
        public string FastestsCar { get; set; }
        public string FastestsDriver { get; set; }
        public TimeSpan FastestLap { get; set; } 
    }
}