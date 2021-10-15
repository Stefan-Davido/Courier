using DistantPointTest.Entities;
using DistantPointTest.Models;
using DistantPointTest.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DistantPointTest.Controllers
{
    public class CourierController : Controller
    {
        private readonly ICourierService _courerService;
        private readonly IPricePerCourierService _pricePerCourierService;

        public CourierController(
            ICourierService courerService,
            IPricePerCourierService pricePerCourierService)
        {
            _courerService = courerService;
            _pricePerCourierService = pricePerCourierService;
        }

        public IActionResult Index()
        {
            var allCouriers = _courerService.GetAllCouriers();
            return View(allCouriers);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Create(FullCourierViewModel viewModel)
        {
            Courier courier = new Courier();
            courier = viewModel.Courier;
            courier.OrdersMade = 0;

            PricePerCourier pricer = new PricePerCourier();
            pricer = viewModel.Pricer;

            _pricePerCourierService.AddPricer(pricer);
            _courerService.AddCourier(courier);

            pricer.CourierId = courier.CourierId;
            courier.PricerId = pricer.PricePerCourierId;

            _pricePerCourierService.EditPricer(pricer);
            _courerService.EditCourier(courier);


            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int id)
        {
            var courier = _courerService.GetCourierById(id);
            var pricer = _pricePerCourierService.GetPricerByCourierId(id);

            FullCourierViewModel viewModel = new FullCourierViewModel();
            viewModel.Courier = courier;
            viewModel.Pricer = pricer;

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Edit(FullCourierViewModel viewModel)
        {
            Courier courier = new Courier();
            courier = viewModel.Courier;
            courier.PricerId = viewModel.Pricer.PricePerCourierId;
            courier.OrdersMade = 0;

            PricePerCourier pricer = new PricePerCourier();
            pricer = viewModel.Pricer;
            pricer.CourierId = viewModel.Courier.CourierId;
            pricer.CourierName = viewModel.Courier.CourierName;

            _pricePerCourierService.EditPricer(pricer);
            _courerService.EditCourier(courier);

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var courier = _courerService.GetCourierById(id);
            var pricer = _pricePerCourierService.GetPricerByCourierId(id);

            FullCourierViewModel viewModel = new FullCourierViewModel();
            viewModel.Courier = courier;
            viewModel.Pricer = pricer;

            return View(viewModel);
        }

        [HttpGet]

        public IActionResult Delete(int id)
        {
            var courier = _courerService.GetCourierById(id);
            var pricer = _pricePerCourierService.GetPricerByCourierId(id);

            FullCourierViewModel viewModel = new FullCourierViewModel();
            viewModel.Courier = courier;
            viewModel.Pricer = pricer;

            return View(viewModel);
        }
        
        [HttpPost,ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var courier = _courerService.GetCourierById(id);
            var pricer = _pricePerCourierService.GetPricerByCourierId(id);

            _courerService.DeleteCourier(id);
            _pricePerCourierService.DeletePricer(pricer.PricePerCourierId);


            return RedirectToAction(nameof(Index));
        }
    }
}
