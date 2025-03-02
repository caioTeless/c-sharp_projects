using Control.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Control.Data
{
    public class SeedingService
    {
        private readonly ControlContext _context;

        public SeedingService(ControlContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Fuel.Any() ||
                _context.Spend.Any())
            {
                return;
            }
            //Fuel
            Fuel fuel1 = new Fuel(1, "Etanol");
            Fuel fuel2 = new Fuel(2, "Gasolina");
            Fuel fuel3 = new Fuel(3, "Diesel");
            Fuel fuel4 = new Fuel(4, "GNV");

            //Spends
            Spend spend1 = new Spend(1, DateTime.Parse("08/04/2020"), 24.8, 155.41, fuel2);
            Spend spend2 = new Spend(2, DateTime.Parse("04/04/2020"), 14.8, 120.11, fuel2);
            Spend spend3 = new Spend(3, DateTime.Parse("08/02/2020"), 36.4, 112.13, fuel1);
            Spend spend4 = new Spend(4, DateTime.Parse("01/07/2020"), 12.5, 50.45, fuel3);
            Spend spend5 = new Spend(5, DateTime.Parse("26/09/2020"), 26.1, 12.89, fuel2);
            Spend spend6 = new Spend(6, DateTime.Parse("13/01/2020"), 7.42, 89.50, fuel1);
            Spend spend7 = new Spend(7, DateTime.Parse("14/09/2020"), 45.1, 72.77, fuel4);




            _context.Fuel.AddRange(fuel1, fuel2, fuel3, fuel4);

            _context.Spend.AddRange(spend1, spend2, spend3,
                spend4, spend5, spend6, spend7);

            _context.SaveChanges();
        }
    }
}
