using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Login.Controllers
{
    public class VerificarController : Controller
    {
        // GET: Verificar
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Logar()
        {
            return View();
        }

        public ActionResult Confirmar()
        {
            string email = Request["txtEmail"];
            string senha = Request["txtSenha"];

            if (email == "admin@etec.com" && senha == "admin123")
            {
                string certo = "Login Confirmado";
                ViewBag.Confirmacao = certo;
            }
            else
            {
                string falso = "Login Não Identificado";
                ViewBag.Confirmacao = falso;
            }

            return View();
        }
    }
}