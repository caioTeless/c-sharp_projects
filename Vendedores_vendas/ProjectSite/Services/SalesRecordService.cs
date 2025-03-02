﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectSite.Data;
using ProjectSite.Models;
using Microsoft.EntityFrameworkCore;

namespace ProjectSite.Services
{
    public class SalesRecordService
    {
        private readonly ProjectSiteContext _context;

        public SalesRecordService(ProjectSiteContext context)
        {
            _context = context;
        }

        public async Task<List<SalesRecord>> FindByDateAsync(DateTime? min, DateTime? max)
        {
            var result = from obj in _context.SalesRecord select obj; // Pega o SalesRecord e constroi um obj 

            if(min.HasValue)
            {
                result = result.Where(x => x.Date >= min.Value);
            }
            if (max.HasValue)
            {
                result = result.Where(x => x.Date <= max.Value);
            }
            return await result
                .Include(x => x.Seller)
                .Include(x => x.Seller.Department)
                .OrderByDescending(x => x.Date)
                .ToListAsync();
        }
    }
}
