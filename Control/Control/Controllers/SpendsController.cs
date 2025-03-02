using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Control.Models;
using Control.Services;
using Microsoft.AspNetCore.Mvc;
using Control.Models.ViewModels;

namespace Control.Controllers
{
    public class SpendsController : Controller
    {
        private readonly SpendService _spendService;
        private readonly FuelService _fuelService;

        public SpendsController(SpendService spendService, FuelService fuelService)
        {
            _spendService = spendService;
            _fuelService = fuelService;
        }

        public IActionResult Index()
        {
            return View(_spendService.FindAll());
        }

        public IActionResult Create()
        {
            var fuels = _fuelService.FindAll();
            var viewModel = new CompleteViewModel { Fuels = fuels };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Spend spend)
        {   
            if (!ModelState.IsValid)
            {
                var fuels = _fuelService.FindAll();
                var viewModel = new CompleteViewModel { Spend = spend, Fuels = fuels };
                return View(viewModel);
            }
            _spendService.Insert(spend);
            return RedirectToAction(nameof(Index));

        }

        public IActionResult Edit(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var obj = _spendService.FindById(id.Value);
            if(obj == null)
            {
                return NotFound();
            }
            List<Fuel> fuels = _fuelService.FindAll();
            CompleteViewModel viewModel = new CompleteViewModel { Spend = obj, Fuels = fuels };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Spend spend)
        {
            if (!ModelState.IsValid)
            {
                var fuels = _fuelService.FindAll();
                var viewModel = new CompleteViewModel { Spend = spend, Fuels = fuels };
                return View(viewModel);
            }
            _spendService.Update(spend);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var obj = _spendService.FindById(id.Value);
            if(obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Delete(int id)
        {
            _spendService.Remove(id);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Details(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var obj = _spendService.FindById(id.Value);
            if(obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }
    }
}