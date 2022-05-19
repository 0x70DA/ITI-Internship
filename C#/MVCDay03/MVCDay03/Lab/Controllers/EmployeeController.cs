using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Lab.Models;

namespace Lab.Controllers
{
    public class EmployeeController : Controller
    {
        CompanyContext db = new CompanyContext();
        // GET: Employee
        public ActionResult Index()
        {
            var emps = db.Employees.ToList();
            return View(emps);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Employee emp)
        {
            // add employee to database
            db.Employees.Add(emp);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var emp = db.Employees.Find(id);
            return View(emp);
        }
        [HttpPost]
        public ActionResult Edit(Employee newEmp)
        {
            var oldEmp = db.Employees.Find(newEmp.ID);
            oldEmp.Name = newEmp.Name;
            oldEmp.Age = newEmp.Age;
            oldEmp.Salary = newEmp.Salary;
            oldEmp.DeptID = newEmp.DeptID;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Details(int id)
        {
            var emp = db.Employees.Find(id);
            return View(emp);
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            var emp = db.Employees.Find(id);
            db.Employees.Remove(emp);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}