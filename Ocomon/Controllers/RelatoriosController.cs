using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ocomon.Controllers
{
    public class RelatoriosController : Controller
    {
        //
        // GET: /Relatorios/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Slas()
        {
            return View();
        }

    }
}
