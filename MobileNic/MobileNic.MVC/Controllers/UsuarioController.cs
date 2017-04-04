using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MobileNic.MVC.Models;

namespace MobileNic.MVC.Controllers
{
    public class UsuarioController : Controller
    {
        //Objeto db
        MobileModels db;

        //
        // GET: /Usuario/

        public ActionResult Index(string name = "")
        {
            //Inicializar el objeto db
            db = new MobileModels();

            var users = db.Usuarios.Where(c => (c.NombresUsuario + " " + c.ApellidosUsuario).Contains(name)).AsParallel().ToList();

            return View(users);
        }

        //
        // GET: /Usuario/Details/5

        public ActionResult Details(Guid id)
        {
            //Inicializar el objeto db
            db = new MobileModels();

            var user = db.Usuarios.Where(c => c.IdUsuario == id).AsParallel().FirstOrDefault();

            if (user == null)
            {
                //Message
                var msg = "";

                //Not Found - Err 404
                RedirectToAction("Err404", "Err", new { Message = msg });
            }

            return View(user);
        }

        //
        // GET: /Usuario/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Usuario/Create

        [HttpPost]
        public ActionResult Create(Usuario Usuario)
        {
            try
            {
                // TODO: Add insert logic here

                //Inicializar el objeto db
                db = new MobileModels();

                //Se agrega el objeto Usuario a la lista
                db.Usuarios.Add(Usuario);

                //Se guardan los cambios
                db.SaveChanges();

                //Se hace la redirección
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ViewBag["err"] = ex.Message;
                return View();
            }
        }

        //
        // GET: /Usuario/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Usuario/Edit/5

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
        // GET: /Usuario/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Usuario/Delete/5

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
