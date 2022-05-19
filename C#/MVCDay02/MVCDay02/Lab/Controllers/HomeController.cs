using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Lab.Models;

namespace Lab.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Register()
        {
            return View();
        }
        [HttpGet]
        public ViewResult Welcome(Employee e)
        {
            ViewBag.e = e;
            return View();
        }
    }
}