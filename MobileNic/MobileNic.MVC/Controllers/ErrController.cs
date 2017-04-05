using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MobileNic.MVC.Controllers
{
    public class ErrController : Controller
    {
        //
        // GET: /Err/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Err404()
        {
            return View();
        }
    }
}
