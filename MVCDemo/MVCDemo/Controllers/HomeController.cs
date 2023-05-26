using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Countries = new List<string>
            {
                "India",
                "uk",
                "USa"
            };
            return View(); 
        }

        public string GetDetails()
        {
            return "get details"; 
        }
    }
}