using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _10june_2019.Models
{
    public class Car
    {
        public int CarId { get; set; }
        [Required]
        public String Modle { get; set; }
        [Required]
        public String Brand { get; set; }
        [Required]
        public String Type { get; set; }
        [Required]
        public int Year { get; set; }
    }
}