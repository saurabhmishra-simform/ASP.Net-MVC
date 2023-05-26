using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SessionDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.v1 = "Data from viewbag";
            ViewData["v2"] = "Data from viewData";
            TempData["v3"] = "Data from TempData";
            Session["v4"] = "Data from session";
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Contect()
        {
            return View();
        }
    }
}