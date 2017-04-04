using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MobileNic.MVC.Controllers
{
    public class DispositivoController : Controller
    {
        //
        // GET: /Dispositivo/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Dispositivo/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Dispositivo/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Dispositivo/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Dispositivo/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Dispositivo/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Dispositivo/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Dispositivo/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
