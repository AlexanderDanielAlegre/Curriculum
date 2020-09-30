using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Curriculum.Services;
using System.Web.Mvc;
using Curriculum.Domain;

namespace cv.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        //public ActionResult Action()
        //{
        //    var domain = new Curriculum.Services.DataBaseConnection();
        //    //domain.CrearConexion();
        //   var conexion = domain.CrearConexion();
        //    var metodo = new Curriculum.Services.HomeServices();
        //    //metodo.ExecuteSP(conexion, "sp_CrearTabla");
        //    IList<datos_personales> prueba = metodo.LlenarDataGreed(conexion);
        //    //domain.ExecuteCommand();
        //    ViewBag.prueba = prueba;
        //    return View(/*prueba*/);
        //}

        public ActionResult prueba()
        {
            var domain = new Curriculum.Services.DataBaseConnection();
            //domain.CrearConexion();
            var conexion = domain.CrearConexion();
            var metodo = new Curriculum.Services.HomeServices();
            var prueba = metodo.LlenarDataGreed(conexion);
         
            ViewBag.prueba = prueba;
            return View(prueba);
        }


    }
}