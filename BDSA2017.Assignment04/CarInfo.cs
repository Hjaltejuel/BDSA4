using System;

namespace BDSA2017.Assignment04
{
    public class CarInfo
    {
        public int CarId { get; set; }
        public string CarName { get; set; }
        public string DriverName { get; set; }
        public int StartPosition { get; set; }
        public int? EndPosition { get; set; }
        public long? BestLapInTicks { get; set; }
        public long? TotalRaceTimeInTicks { get; set; }
        public TimeSpan? BestLap => BestLapInTicks.HasValue ? TimeSpan.FromTicks(BestLapInTicks.Value) : default(TimeSpan?);
        public TimeSpan? TotalRaceTime => TotalRaceTimeInTicks.HasValue ? TimeSpan.FromTicks(TotalRaceTimeInTicks.Value) : default(TimeSpan?);

        public override string ToString()
        {
            return "CarID " + CarId + " CarName " + CarName + " startPosition " + StartPosition + " endPosition " + EndPosition + " BestLap " + BestLapInTicks + " totalRaceTime " + TotalRaceTime;
        }
    }
}