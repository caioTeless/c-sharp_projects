using Control.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Control.Models;

namespace Control.Services
{
    public class FuelService
    {
        private readonly ControlContext _context;

        public FuelService(ControlContext context)
        {
            _context = context;
        }

        public List<Fuel> FindAll()
        {
            return _context.Fuel.ToList();
        }

        public void Insert(Fuel fuel)
        {
            _context.Add(fuel);
            _context.SaveChanges();
        }

        public Fuel FindById(int id)
        {
            return _context.Fuel.FirstOrDefault(x => x.Id == id);
        }

        public void Remove(int id)
        {
            var obj = _context.Fuel.Find(id);
            _context.Fuel.Remove(obj);
            _context.SaveChanges();
        }
        public void Update(Fuel obj)
        {
            if(!_context.Fuel.Any(x => x.Id == obj.Id))
            {
                return;
            }
            try
            {
                _context.Update(obj);
                _context.SaveChanges();
            }
            catch(Exception e)
            {
                throw e;
            }
        }
    }
}
