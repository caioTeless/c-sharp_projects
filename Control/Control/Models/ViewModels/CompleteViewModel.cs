using System.Collections.Generic;

namespace Control.Models.ViewModels
{
    public class CompleteViewModel
    {
        public Spend Spend { get; set; }
        public ICollection<Fuel> Fuels { get; set; }
       
    }
}
