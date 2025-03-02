using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;
using System.ComponentModel.DataAnnotations;

namespace Control.Models
{
    public class Fuel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} required")]
        [StringLength(20, MinimumLength = 2, ErrorMessage="{0} size should be between {2} to {1}")]
        public string Name { get; set; }

        public Fuel()
        {
        }
        public Fuel(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
