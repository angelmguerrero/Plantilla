using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Plantilla.Controllers
{
    public class AccesoController : Controller
    {
        // GET: Acceso
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(string test)
        {
            return RedirectToAction("Index", "Inicio");

        }



    }
}