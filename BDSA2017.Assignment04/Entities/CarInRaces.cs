using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BDSA2017.Assignment04.Entities
{
    public class CarInRaces
    {

        [ForeignKey("Race")]
        [Key]
        public int RaceId { get; set; }

        [ForeignKey("Car")]
        [Key]
        public int CarId { get; set; }

        
        public int? StartPosition { get; set; }

        public int? EndPosition { get; set; }

        public long? BestLap { get; set; }

        public long ? TotalRaceTime { get; set; }
    }
}
