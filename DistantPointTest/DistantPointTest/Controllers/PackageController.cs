using DistantPointTest.Service.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DistantPointTest.Controllers
{
    public class PackageController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly IPackageService _packageService;

        public PackageController(
            IPackageService packageService,
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager)
        {
            _packageService = packageService;
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public IActionResult Index(string id)
        {
            var packages = _packageService.GetAllPackageByUserId(id);
            return View(packages);
        }
    }
}
