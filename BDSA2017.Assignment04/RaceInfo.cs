using System;
using System.Collections.Generic;

namespace BDSA2017.Assignment04
{
    public class RaceInfo
    {
        public int RaceId { get; set; }
        public int TrackId { get; set; }
        public int TrackName { get; set; }
        public int NumberOfLaps { get; set; }
        public IEnumerable<CarInfo> Cars { get; set; }
        public DateTime? PlannedStart { get; set; }
        public DateTime? ActualStart { get; set; }
        public DateTime? PlannedEnd { get; set; }
        public DateTime? ActualEnd { get; set; }
    }
}