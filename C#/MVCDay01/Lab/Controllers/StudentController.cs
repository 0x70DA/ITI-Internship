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
        CollegeContext db = new CollegeContext();

        [HttpGet]
        public JsonResult GetAll()
        {
            return Json(db.Students.ToList(), JsonRequestBehavior.AllowGet);
        }


        [HttpGet]
        public JsonResult GetByID(int id)
        {
            return Json(db.Students.FirstOrDefault(s => s.ID == id), JsonRequestBehavior.AllowGet);
        }
        
        
    }
}