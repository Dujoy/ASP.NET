using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mycv.Controllers
{
    public class MycvController : Controller
    {
        // GET: Mycv
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult NE()
        {
            return View();
        }
        public ActionResult Personal()
        {
            return View();
        }
        public ActionResult Education()
        {
            return View();
        }
        public ActionResult Project()
        {
            return View();
        }
    }
}