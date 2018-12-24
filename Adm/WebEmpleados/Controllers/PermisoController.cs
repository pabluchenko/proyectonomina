using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using WebEmpleados.Models;

namespace WebEmpleados.Controllers
{
    public class PermisoController : Controller
    {
        private NominaEntities db = new NominaEntities();

        // GET: Permiso
        [Authorize]
        public ActionResult Index()
        {
            var permisos = db.Permisos.Include(p => p.Empleado);
            return View(permisos.ToList());
        }

        // GET: Permiso/Details/5
        [Authorize]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Permisos permisos = db.Permisos.Find(id);
            if (permisos == null)
            {
                return HttpNotFound();
            }
            return View(permisos);
        }

        // GET: Permiso/Create
        [Authorize]
        public ActionResult Create()
        {
            ViewBag.Empleado_Id = new SelectList(db.Empleado, "Id_Empleado", "Nombres");
            try
            {
                string userID = User.Identity.GetUserId();
                var empleadoId = db.Empleado_AspUser.Where(e => e.Asp_User_Id == userID).FirstOrDefault().Empleado_Id;
                ViewBag.Empleado_Id=empleadoId;
            }
            catch (Exception ex)
            {
                string mensaje = "No se pudo obtener el empleado: " + ex.Message;

            }

            ViewBag.EstadoDefault = "Pendiente";
            return View();
        }

        // POST: Permiso/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult Create([Bind(Include = "Id_Permiso,Empleado_Id,Fecha_Desde,Fecha_Hasta,Motivo,Cantidad_Horas,Fecha_Solicitud,Estado,Observaciones")] Permisos permisos)
        {
            if (ModelState.IsValid)
            {
                db.Permisos.Add(permisos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Empleado_Id = new SelectList(db.Empleado, "Id_Empleado", "Nombres", permisos.Empleado_Id);
            return View(permisos);
        }

        // GET: Permiso/Edit/5
        /*
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Permisos permisos = db.Permisos.Find(id);
            if (permisos == null)
            {
                return HttpNotFound();
            }
            ViewBag.Empleado_Id = new SelectList(db.Empleado, "Id_Empleado", "Nombres", permisos.Empleado_Id);
            return View(permisos);
        }
        */
        // POST: Permiso/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        /*
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id_Permiso,Empleado_Id,Fecha_Desde,Fecha_Hasta,Motivo,Cantidad_Horas,Fecha_Solicitud,Estado,Observaciones")] Permisos permisos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(permisos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Empleado_Id = new SelectList(db.Empleado, "Id_Empleado", "Nombres", permisos.Empleado_Id);
            return View(permisos);
        }

        // GET: Permiso/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Permisos permisos = db.Permisos.Find(id);
            if (permisos == null)
            {
                return HttpNotFound();
            }
            return View(permisos);
        }

        // POST: Permiso/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Permisos permisos = db.Permisos.Find(id);
            db.Permisos.Remove(permisos);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        */
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
