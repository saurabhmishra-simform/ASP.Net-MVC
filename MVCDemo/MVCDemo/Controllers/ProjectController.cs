using MVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class ProjectController : Controller
    {
        // GET: Project
        public ActionResult Index()
        {
            EmployeeContext employeeContext = new EmployeeContext();
            List<ProjectModel> project = employeeContext.Projects.ToList();
            return View(project);
        }
    }
}