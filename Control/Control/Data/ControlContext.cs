using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Control.Models;

namespace Control.Data
{
    public class ControlContext : DbContext
    {
        public ControlContext(DbContextOptions<ControlContext> options) : base(options)
        {
        }

        public DbSet<Fuel> Fuel { get; set; }
        public DbSet<Spend> Spend { get; set; }
    }
}
