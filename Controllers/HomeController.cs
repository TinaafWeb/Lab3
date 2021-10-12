using Lab3.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab3.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Razor() => View();

        [HttpPost]
        public IActionResult Count()
        {
            // you will complete 
            return View();
        }

        public IActionResult CreatePerson() => View();

        [HttpPost]
        public IActionResult DisplayPerson(Person person)
        {
            // you will complete this
            return View("DisplayPerson",
                new Person
                {
                    fname = Request.Form["fname"],
                    lname = Request.Form["lname"],
                    age = Request.Form["age"],
                    email = Request.Form["email"],
                    date = Request.Form["date"],
                    pwd = Request.Form["pwd"],
                    dis = Request.Form["dis"]
                }); 
           
        }
        public IActionResult Error()
        {
            return View();
        }

    }
}
