using DistantPointTest.Entities;
using DistantPointTest.Models;
using DistantPointTest.Service;
using DistantPointTest.Service.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DistantPointTest.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly ICourierService _courierService;
        private readonly IPackageService _packageService;
        private readonly ICargo _cargo;
        private readonly IPricePerCourierService _pricePerCourierService;
        private readonly IEmailService _emailService;

        public HomeController(
            ILogger<HomeController> logger,
            IPackageService packageService,
            ICourierService courierService,
            ICargo cargo,
            IPricePerCourierService pricePerCourierService,
            IEmailService emailService,
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager)
        {
            _logger = logger;
            _courierService = courierService;
            _packageService = packageService;
            _cargo = cargo;
            _pricePerCourierService = pricePerCourierService;
            _userManager = userManager;
            _signInManager = signInManager;
            _emailService = emailService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var dropDown = DropDown();
            ViewBag.Cargo = dropDown;
            return View();
        }

        [HttpPost]
        public IActionResult Index(Package package)
        {
            var dropDown = DropDown();
            ViewBag.Cargo = dropDown;

            var courier = _courierService.GetCourierById(package.CourierId);
            var pricer = _pricePerCourierService.GetPricerByCourierId(package.CourierId);
            var check = _cargo.Validation(courier, package); 
            if(check == false)
            {
                ViewBag.Message = "This Courier Doesn't allow this size package";
                return View();
            }
            else
            {
                var pricePerWeight = _cargo.PricePerWeight(package, pricer);
                var pricePerDimension = _cargo.PricePerDimension(package, pricer);
                var price = _cargo.FinalPrice(pricePerWeight, pricePerDimension);
                package.Cost = price;

                return View(package);
            }
        }

        private async Task<string> GetEmail()
        {
            var user = await _userManager.GetUserAsync(User);
            var email = user.Email;

            return email;
        }

        [HttpPost]
        public async void Order(Package package)
        {
            var courier = _courierService.GetCourierById(package.CourierId);
            package.CourierName = courier.CourierName;
            courier.OrdersMade += 1;

            _courierService.EditCourier(courier);
            _packageService.AddPackage(package);

            var email = await GetEmail();
            _emailService.SendEmail(email);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private List<SelectListItem> DropDown()
        {
            var Couriers = _courierService.GetAllCouriers();
            List<SelectListItem> selectList = new List<SelectListItem>
            {
                new SelectListItem
                {
                    Text = "Select Cargo",
                    Value = "No Selected"
                }
            };

            if(Couriers.Count() > 0)
            {
                foreach (var courier in Couriers)
                {
                    selectList.Add(new SelectListItem { Value = courier.CourierId.ToString(), Text = courier.CourierName });
                }
            }

            return selectList;
        }
    }
}
