using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using exercModel.Models;

namespace exercModel.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult resultado(Cliente cli)
        {
            ViewBag.Cliente = cli;
            return View();
        }
    }
}