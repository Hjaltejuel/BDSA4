using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace BDSA2017.Assignment04.Entities
{
    public class Cars
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public String Name { get; set; }
        
        [Required]
        public String DriverName { get; set; }


      
    }
}
