using System;
using System.Collections.Generic;
using System.Text;

namespace BDSA2017.Assignment04
{
    public class Race
    {
        public Track track { get; set; }
        public int numberOfLaps { get; set; }
        public DateTime? plannedStartTime { get; set; }
        public DateTime? actualStartTime { get; set; }
        public DateTime? plannedEndTime { get; set; }
        public DateTime? actualEndTime { get; set; }
    }
}
