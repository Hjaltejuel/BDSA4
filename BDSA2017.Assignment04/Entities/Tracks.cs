using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BDSA2017.Assignment04.Entities
{
    public class Tracks
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public String Name { get; set; }

        [Required]
        public double Length { get; set; }

        
        public long? BestTime { get; set; }

        [Required]
        public int MaxCars { get; set; }
    }
}
