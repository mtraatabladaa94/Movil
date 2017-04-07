using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MobileNic.MVC.Models;
using System.Linq.Expressions;

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
            try
            {
                //Inicializar el objeto db
                db = new MobileModels();

                var users = db.Usuarios.AsParallel().Where(c => (c.NombresUsuario + " " + c.ApellidosUsuario).Contains(name)).ToList();

                return View(users);
            }
            catch (Exception ex)
            {
                ViewBag["Err"] = ex.Message;

                return View();
            }
        }

        //
        // GET: /Usuario/Details/5

        public ActionResult Details(Guid id)
        {
            try
            {
                //Inicializar el objeto db
                db = new MobileModels();

                var user = db.Usuarios.AsParallel().Where(c => c.IdUsuario == id).FirstOrDefault();

                if (user == null)
                {
                    //Message
                    var msg = "";

                    //Not Found - Err 404
                    return RedirectToAction("Err404", "Err", new { Message = msg });
                }

                return View(user);
            }
            catch (Exception ex)
            {
                ViewBag["Err"] = ex.Message;

                return View();
            }
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
        [ValidateAntiForgeryToken]
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

        public ActionResult Edit(Guid id)
        {
            try
            {
                //TODO: Add insert logic here

                //Inicializar el objeto db
                db = new MobileModels();

                //Verificar si existe el usuario
                var user = db.Usuarios.AsParallel().Where(c => c.IdUsuario == id).FirstOrDefault();

                //Se evalua si existe
                if (user == null)
                {
                    //Message
                    var msg = "";

                    //Not Found - Err 404
                    return RedirectToAction("Err404", "Err", new { Message = msg });
                }

                //Se hace la redirección
                return View(user);

            }
            catch (Exception ex)
            {
                ViewBag["err"] = ex.Message;
                return View();
            }
        }

        //
        // POST: /Usuario/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Guid id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                //Inicializar el objeto db
                db = new MobileModels();

                //Verificar si existe el usuario
                var user = db.Usuarios.AsParallel().Where(c => c.IdUsuario == id).FirstOrDefault();

                //Se evalua si existe
                if (user == null)
                {
                    //Message
                    var msg = "";

                    //Not Found - Err 404
                    return RedirectToAction("Err404", "Err", new { Message = msg });
                }

                //Se guardan los cambios
                db.Entry(user).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

                //Se hace la redirección
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Usuario/Delete/5

        public ActionResult Delete(Guid id)
        {
            try
            {
                // TODO: Add update logic here

                //Inicializar el objeto db
                db = new MobileModels();

                //Verificar si existe el usuario
                var user = db.Usuarios.AsParallel().Where(c => c.IdUsuario == id).FirstOrDefault();

                //Se evalua si existe
                if (user == null)
                {
                    //Message
                    var msg = "";

                    //Not Found - Err 404
                    return RedirectToAction("Err404", "Err", new { Message = msg });
                }

                return View(user);
            }
            catch (Exception ex)
            {
                ViewBag["err"] = ex.Message;

                return RedirectToAction("", "", null);
            }
        }

        //
        // POST: /Usuario/Delete/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Guid id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                //Inicializar el objeto db
                db = new MobileModels();

                //Verificar si existe el usuario
                var user = db.Usuarios.AsParallel().Where(c => c.IdUsuario == id).FirstOrDefault();

                //Se evalua si existe
                if (user == null)
                {
                    //Message
                    var msg = "";

                    //Not Found - Err 404
                    return RedirectToAction("Err404", "Err", new { Message = msg });
                }

                //Desactivar usuario
                user.ActivoUsuario = false;

                //Se guardan los cambios
                db.Entry(user).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

                //redireccionar al index
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                ViewBag.Err = ex.Message;

                return View();
            }
        }

        //public Func<int, string, Controller> Metodo(Func<int, int> par)
        //{
        //    return null;
        //}


        //public Func<string, string> Metodo2()
        //{
            
        //    ParameterExpression num1 = Expression.Parameter(typeof(int), "num1");
        //    ParameterExpression num2 = Expression.Parameter(typeof(int), "num2");
 
            
        //    ParameterExpression[] parameters = new ParameterExpression[] { num1, num2 };
 
            
        //    BinaryExpression body = Expression.Add(num1, num2);
 
            
        //    Expression<Func<int, int, int>> expression =
        //    Expression.Lambda<Func<int, int, int>>(body, parameters);
 
            
        //    Func<int, int, int> compiledExpression = expression.Compile();
 
            
        //    int result = compiledExpression(3, 4); //return 7

        //    return result;
        //}
    }
}