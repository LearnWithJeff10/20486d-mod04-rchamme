using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ControllersExample.Models;

namespace ControllersExample
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ExampleModel model = new ExampleModel()
            { 
                Sentence = "Welcome to Module 4 - Demo 1" 
            };
            return View(model);
        }

        public IActionResult ParamExamble(string id)
        {
            return Content("My param is: " + id);
        }
    }
}
