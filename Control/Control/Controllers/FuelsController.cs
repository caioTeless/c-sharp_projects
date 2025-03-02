using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Control.Data;
using Control.Models;
using Control.Services;
using Microsoft.AspNetCore.Mvc;
using Control.Models.ViewModels;

namespace Control.Controllers
{
    public class FuelsController : Controller
    {
        private readonly ControlContext _context;
        private readonly FuelService _fuelService;

        public FuelsController(ControlContext context, FuelService fuelService)
        {
            _context = context;
            _fuelService = fuelService;
        }

        public IActionResult Index()
        {
            return View(_fuelService.FindAll());
        }


        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Fuel fuel)
        {
            _fuelService.Insert(fuel);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var obj = _fuelService.FindById(id.Value);
            if(obj == null)
            {
                return NotFound();
            }
            return View(obj);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            _fuelService.Remove(id);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var obj = _fuelService.FindById(id.Value);
            if(obj == null)
            {
                return NotFound();
            }
            //List<Fuel> fuels = _fuelService.FindAll();
            //CompleteViewModel viewModel = new CompleteViewModel { Fuels = fuels };

            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Fuel fuel)
        {
            _fuelService.Update(fuel);
            return RedirectToAction(nameof(Index));
        }

    }
}