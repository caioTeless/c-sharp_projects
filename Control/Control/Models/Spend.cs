using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Control.Models
{
    public class Spend
    {
        public int Id { get; set; }
        
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Required(ErrorMessage = "{0} required")]
        public DateTime Date { get; set; }

        [DisplayFormat(DataFormatString = "{0:F2}")]
        [Required(ErrorMessage = "{0} required")]
        [Range(1.0, 100.0, ErrorMessage = "{0} must be from {1} to {2}")]
        public double Liters { get; set; }

        [DisplayFormat(DataFormatString = "{0:F2}")]
        [Required(ErrorMessage = "{0} required")]
        [Range(1.0, 400, ErrorMessage = "{0} must be from {1} to {2}")]
        public double Value { get; set; }
        public Fuel Fuel { get; set; }

        [Display(Name = "Fuels")]
        public int FuelId { get; set; }

        public Spend()
        {
        }

        public Spend(int id, DateTime date, double liters, double value, Fuel fuel)
        {
            Id = id;
            Date = date;
            Liters = liters;
            Value = value;
            Fuel = fuel;
        }
    }
}
