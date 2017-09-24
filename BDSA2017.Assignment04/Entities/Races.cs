using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BDSA2017.Assignment04.Entities
{
    public class Races
    {
      
        [Key]
        public int Id { get; set; }

        [Required]
        public Tracks Tracks { get; set; }

        [Required]
        public int NumberOfLaps { get; set; }

     
        [Required]
        public DateTime PlannedStartTime { get; set; }
        [Required]
        public DateTime PlannedEndTime { get; set; }

        public DateTime? ActualStartTime { get; set; }

        public DateTime? ActualEndTime { get; set; }

      

    }
}
