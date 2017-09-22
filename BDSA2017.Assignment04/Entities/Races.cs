using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BDSA2017.Assignment04.Entities
{
    public class Races
    {
      
        [Key]
        public int Id { get; set; }

        [ForeignKey("Track")]
        [Required]
        public int TrackId { get; set; }

        [Required]
        public int NumberOfLaps { get; set; }

     
        [Required]
        public DateTime PlannedStartTime { get; set; }
        [Required]
        public DateTime PlannedEndTime { get; set; }

        public DateTime? ActualStartTime { get; set; }

        public DateTime? ActualEndTime { get; set; }

        public Tracks Track { get; set; }
    }
}
