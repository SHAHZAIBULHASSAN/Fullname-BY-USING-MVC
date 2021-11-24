using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Fullname.Models;

namespace Fullname.Controllers
{
    public class HomeController : Controller
    { [HttpPost]
        public ActionResult Index(Name N)
        {
           TempData["F"] = N.FirstName;
            TempData["L"] = N.LastName;
            return new RedirectResult(@"~\Fullname\");
        }
      
        public ActionResult Index()
        {
           
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}