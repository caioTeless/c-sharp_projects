using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjectSite.Models;

namespace ProjectSite.Data
{
    public class ProjectSiteContext : DbContext
    {
        public ProjectSiteContext (DbContextOptions<ProjectSiteContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
    }
}
