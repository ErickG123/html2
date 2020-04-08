using Aula6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aula6.Controllers
{
    public class ProdutoController : Controller
    {
        // GET: Produto
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Resultado(Produto Pro)
        {
            ViewBag.Produto = Pro;
            return View();
        }
    }
}