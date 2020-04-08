using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using introModel.Models;

namespace introModel.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult cadastrarAluno(Aluno alu)
        {
            //Exemplo de manipulação 
            string z = Request["txtNome"];
            string x = alu.Nome;
            int y = alu.IdAluno;

            ViewBag.ObjetoAluno = alu;

            return View();
        }
    }
}