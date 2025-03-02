using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectSite.Data;
using ProjectSite.Models;
using Microsoft.EntityFrameworkCore;
using ProjectSite.Services.Excepetions;

namespace ProjectSite.Services
{
    public class SellerService
    {
        private readonly ProjectSiteContext _context;

        public SellerService(ProjectSiteContext context)
        {
            _context = context;
        }

        public async Task<List<Seller>> FindAllAsync()
        {
            return await _context.Seller.ToListAsync(); // Irá acessar os dados e converter para uma lista.
        }

        public async Task InsertAsync(Seller obj)
        {
            _context.Add(obj);              // Adicionando no banco de dados
            await _context.SaveChangesAsync();         // Confirmando alteração..
        }
        public async Task<Seller> FindByIdAsync(int id)
        {
            return await _context.Seller.Include(obj => obj.Department).FirstOrDefaultAsync(obj => obj.Id == id);
        }
        public async Task RemoveAsync(int id)
        {
            try
            {
                var obj = await _context.Seller.FindAsync(id);
                _context.Seller.Remove(obj);
                await _context.SaveChangesAsync();
            }
            catch(DbUpdateException e)
            {
                throw new IntegrityException(e.Message);
            }
        }

        public async Task UpdateAsync(Seller obj)
        {
            bool hasAny = await _context.Seller.AnyAsync(x => x.Id == obj.Id);
            if (!hasAny)
            {
                throw new NotFoundException("Id not found");
            }
            try
            {
                _context.Update(obj);
                await _context.SaveChangesAsync();
            }
            catch(DbUpdateConcurrencyException e)
            {
                throw new DbConcurrencyExcepetion(e.Message);
            }
        }
    }
}
