using Control.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Control.Models;

namespace Control.Services
{
    public class SpendService
    {
        private readonly ControlContext _context;

        public SpendService(ControlContext context)
        {
            _context = context;
        }

        public List<Spend> FindAll()
        {
            return _context.Spend.OrderByDescending(x => x.Date).ToList();
        }

        public void Insert(Spend spend)
        {

            _context.Add(spend);
            _context.SaveChanges();
        }

        public Spend FindById(int id)
        {
            return _context.Spend.FirstOrDefault(x => x.Id == id);

        }

        public void Update(Spend spend)
        {
            if (!_context.Spend.Any(x => x.Id == spend.Id))
            {
                return;
            }
            try
            {
                _context.Update(spend);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Remove(int id)
        {
            var obj = _context.Spend.Find(id);
            _context.Remove(obj);
            _context.SaveChanges();
        }

    }
}
