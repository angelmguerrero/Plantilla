using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Plantilla.Controllers
{
    public class InicioController : Controller
    {
        #region Constructor

        public InicioController()
        {
        }

        #endregion

        #region Métodos Públicos

        [HttpGet]

        public ActionResult Index()
        {

            return this.View();
        }

        #endregion
    }
}