using MVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using System.Xml.Linq;

namespace MVCDemo.Controllers
{
    public class EmployeeController : Controller
    {
        public readonly EmployeeContext _context;
        public EmployeeController()
        {
            _context = new EmployeeContext();
        }
        // GET: Employee
        public ActionResult Index()
        {
            List<EmployeeModel> employee = _context.Employees.ToList();
            return View(employee);
        }
        public ActionResult Details(int id)
        {
           EmployeeModel employee = _context.Employees.FirstOrDefault(emp => emp.Id == id);
           return View(employee);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(FormCollection formCollection)
        {
            using (_context)
            {
                EmployeeModel employeeModel = new EmployeeModel()
                {
                    Id = Convert.ToInt32(formCollection["Id"]),
                    Name = formCollection["Name"],
                    Department = formCollection["Department"],
                    Salary = Convert.ToDouble(formCollection["Salary"]),
                    Gender = formCollection["Gender"],
                    Age = Convert.ToInt32(formCollection["Age"]),
                    City = formCollection["City"],
                    DateOfJoining = Convert.ToDateTime(formCollection["DateOfJoining"]),
                };
                if (ModelState.IsValid)
                {
                    _context.Employees.Add(employeeModel);
                    _context.SaveChanges();
                }
            }
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int id)
        {
            var employee = _context.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }
        [HttpPost]
        public ActionResult Edit(int id,FormCollection formCollection)
        {
            using (_context)
            {
                var employee = _context.Employees.FirstOrDefault(emp=> emp.Id == id);
                employee.Name = formCollection["Name"];
                employee.Department = formCollection["Department"];
                employee.Salary = Convert.ToDouble(formCollection["Salary"]);
                employee.Gender = formCollection["Gender"];
                employee.Age = Convert.ToInt32(formCollection["Age"]);
                employee.City = formCollection["City"];
                employee.DateOfJoining = Convert.ToDateTime(formCollection["DateOfJoining"]);
                if (ModelState.IsValid)
                {
                    _context.SaveChanges();
                }
            }
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            EmployeeModel employee = _context.Employees.FirstOrDefault(emp => emp.Id == id);
            return View(employee);
        }

        [HttpPost,ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            var employee = _context.Employees.FirstOrDefault(emp => emp.Id == id);
            _context.Employees.Remove(employee);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}