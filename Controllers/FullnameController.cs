using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fullname.Controllers
{
    public class FullnameController : Controller
    {
        // GET: Fullname
        public ActionResult Index()
        {
            return View();
        }
    }
}