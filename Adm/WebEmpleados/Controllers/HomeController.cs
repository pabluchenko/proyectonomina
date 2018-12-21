using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//Incluir este using para obtener el Id del usuario actual logueado
using Microsoft.AspNet.Identity;
using WebEmpleados.Models;

namespace WebEmpleados.Controllers
{
    public class HomeController : Controller
    {
        private NominaEntities db = new NominaEntities();

        public ActionResult Index()
        {
                 
            return View();
            
        }

        public ActionResult About()
        {
            try
            {
                string userID = User.Identity.GetUserId();
                var empleadoId = db.Empleado_AspUser.Where(e => e.Asp_User_Id == userID).FirstOrDefault().Empleado_Id;
                var empleadoObj = db.Empleado.Where(e => e.Id_Empleado == empleadoId).FirstOrDefault();
            }
            catch (Exception ex)
            {
                string mensaje = "No se pudo obtener el empleado: " + ex.Message;

            }

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