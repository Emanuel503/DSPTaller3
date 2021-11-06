using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Registro.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PagoSemanal()
        {
            ViewBag.Message = "Pago semanal";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Nosotros";

            return View();
        }
    }
}