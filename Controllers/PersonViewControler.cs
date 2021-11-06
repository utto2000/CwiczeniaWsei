using Microsoft.AspNetCore.Mvc;
using System;
using Zad1.Models;

namespace Zad1.Controllers
{
    public class PersonViewControler : Controller
    {


        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

      [HttpPost]
      public IActionResult Sended(Person person)
        {
            return View();
        }

    }
}