using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Plantilla.Controllers
{
    public class LegalController : Controller
    {
        #region Métodos Públicos

        [HttpGet]
        public ActionResult TerminosCondicionesUso()
        {
            return PartialView();
        }

        [HttpGet]
        public ActionResult AvisoPrivacidad()
        {
            return PartialView();
        }

        #endregion
    }
}