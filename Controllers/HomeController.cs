using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using validatingForm.Models;

namespace validatingForm.Controllers
{
    public class HomeController : Controller
    {
        // GET: /Home/

        [HttpGet]
        [RouteAttribute("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("")]
        public IActionResult Index(User user)
        {
            if(ModelState.IsValid) {
                System.Console.WriteLine("Data was valid");
                TempData["firstName"] = user.FirstName;
                TempData["lastName"] = user.LastName;
                TempData["email"] = user.Email;
                TempData["age"] = user.Age;
                TempData["password"] = user.Password;
                return RedirectToAction("Success");
            }
            System.Console.WriteLine("Validation failed");
            return View(user);
        }
        [HttpGetAttribute("success")]
        public IActionResult Success()
        {
            System.Console.WriteLine("Made it to this point");
            ViewBag.name = TempData["firstName"] + " " + TempData["lastName"];
            ViewBag.email = TempData["email"];
            ViewBag.age = TempData["age"];
            ViewBag.password = TempData["password"];
            return View();
        }
    }
}
