using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ValidationLawler.Models;

namespace ValidationLawler.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Display(RegistrationModel registration)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Name = registration.Name;
                ViewBag.Phone = registration.PhoneNo;
                ViewBag.Address = registration.Address;
                ViewBag.Email = registration.EmailAddress;
                ViewBag.Age = registration.Age;
                return View(registration);
            }
            else
            {
                return View("Index", registration);
            }
        }
    }
}
