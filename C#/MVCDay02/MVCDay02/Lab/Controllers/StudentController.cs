using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Lab.Models;

namespace Lab.Controllers
{
    public class StudentController : Controller
    {
        public ViewResult Register()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Welcome(Student s)
        {
            return View(s);
        }
        public ViewResult GetAll()
        {
            List<Student> students = new List<Student>()
            {
                new Student{ID = 1, Name = "Mahmoud", Age = 21},
                new Student{ID = 2, Name = "Ahmed", Age = 21},
                new Student{ID = 3, Name = "Omar", Age = 20}
            };
            ViewData["students"] = students;
            return View();
        }
    }
}