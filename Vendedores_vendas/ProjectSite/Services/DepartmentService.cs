using System;
using System.Collections.Generic;
using System.Linq;
using ProjectSite.Data;
using ProjectSite.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ProjectSite.Services
{
    public class DepartmentService
    {
        private readonly ProjectSiteContext _context;

        public DepartmentService(ProjectSiteContext context)
        {
            _context = context;
        }
        public async Task<List<Department>> FindAllAsync()
        {
            //return _context.Department.OrderBy(x => x.Name).ToList(); Sincrona
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
