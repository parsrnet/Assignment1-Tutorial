using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(string id)    
        {
            if (id == "sample")
                return File("~/sample.pdf", "application/pdf");
            else if (id == "gotoabout")
                return RedirectToAction("About");
            else if (id == "login")
                return View("login");
            else
                return Content("You entered " + id, "text/plain");
        }
        public ActionResult About()
        {
            return View();
        }   
    }
}