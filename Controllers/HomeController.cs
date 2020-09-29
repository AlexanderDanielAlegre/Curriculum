using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Curriculum.Services;
using System.Web.Mvc;

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

        public ActionResult Action()
        {
            var domain = new Curriculum.Services.DataBaseConnection();
            //domain.CrearConexion();
           var conexion = domain.CrearConexion();
            var metodo = new Curriculum.Services.HomeServices();
            metodo.ExecuteSP(conexion);
            //domain.ExecuteCommand();

            return View();
        }
    }
}