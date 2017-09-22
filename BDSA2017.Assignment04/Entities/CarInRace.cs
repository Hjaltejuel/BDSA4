using System;
using System.Collections.Generic;
using System.Text;

namespace BDSA2017.Assignment04
{
    public class CarInRace
    {
        public Race race { get; set; }
        public Car car { get; set; }
        public int startPos { get; set; }
        public int endPos { get; set; }
        public int bestLap { get; set; }
        public long totalTime { get; set; }
    }
}
