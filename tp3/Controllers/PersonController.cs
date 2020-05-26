using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using tp3.Models;

namespace tp3.Controllers
{
    public class PersonController : Controller
    {
        public static List<Person> People { get; set; } = new List<Person>();
        public static int id = 0;
        public IActionResult Index()
        {
            return View(People);
        }

        public IActionResult New()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Save(Person model)
        {
            model.Id = id;
            People.Add(model);
            id++;
            return RedirectToAction("Index", "Person");
        }

        [HttpPut]
        public IActionResult Update(Person model)
        {

            return View();
        }
    }
}