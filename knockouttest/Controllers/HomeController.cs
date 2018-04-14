using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using knockouttest.Models;

namespace knockouttest.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public ActionResult Names()
        {
            return Json(new { success = true, firstName = "Hello", lastName = "World" });
        }



        public JsonResult Save(string firstName, string lastName)
        {
            return Json(new { success = true, fullName = firstName + " " + lastName + " SAVED" });
        }
    }


}
public class Person 
{
    public string firstName { get; set; }
}
