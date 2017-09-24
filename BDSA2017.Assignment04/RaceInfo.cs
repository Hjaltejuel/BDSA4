using System;
using System.Collections.Generic;

namespace BDSA2017.Assignment04
{
    public class RaceInfo
    {
        public int RaceId { get; set; }
        public int TrackId { get; set; }
        public string TrackName { get; set; }
        public int NumberOfLaps { get; set; }
        public IEnumerable<CarInfo> Cars { get; set; }
        public DateTime? PlannedStart { get; set; }
        public DateTime? ActualStart { get; set; }
        public DateTime? PlannedEnd { get; set; }
        public DateTime? ActualEnd { get; set; }

        public override string ToString()
        {
            string temp = "";
            foreach (CarInfo info in Cars) {
                temp += " " + info.ToString();
            }
            return "raceId " + RaceId + " trackID " + TrackId + " trackName " + TrackName + " numberOfLaps " + NumberOfLaps + " cars " + temp + " plannedstart " + PlannedStart + " plannedEnd " + PlannedEnd + " actualEnd " + ActualEnd + " actualStart " + ActualStart; 
        }
    }
}