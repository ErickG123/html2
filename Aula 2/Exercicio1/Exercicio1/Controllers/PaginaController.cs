using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exercicio1.Controllers
{
    public class PaginaController : Controller
    {
        // GET: Pagina
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Home()
        {
            return View();
        }

        public ActionResult Sobre()
        {
            return View();
        }

        public ActionResult Produtos()
        {
            return View();
        }

        public ActionResult Contato()
        {
            return View();
        }
    }
}