using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Prova.Controllers
{
    public class ExercicioUmController : Controller
    {
        // GET: ExercicioUm
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Resultado()
        {
            double notaUm = double.Parse(Request["txtN1"]);
            double notaDois = double.Parse(Request["txtN2"]);
            double notaTres = double.Parse(Request["txtN3"]);
            double notaQuatro = double.Parse(Request["txtN4"]);
            double notaCinco = double.Parse(Request["txtN5"]);
            double notaSeis = double.Parse(Request["txtN6"]);

            double media;
            int qtdeAlunos = 0;

            media = (notaUm + notaDois + notaTres + notaQuatro + notaCinco + notaSeis) / 6;
            ViewBag.Media = media;

            if(notaUm >= media)
            {
                qtdeAlunos++;
            }

            if (notaDois >= media)
            {
                qtdeAlunos++;
            }

            if (notaTres >= media)
            {
                qtdeAlunos++;
            }

            if (notaQuatro >= media)
            {
                qtdeAlunos++;
            }

            if (notaCinco >= media)
            {
                qtdeAlunos++;
            }

            if (notaSeis >= media)
            {
                qtdeAlunos++;
            }

            ViewBag.Alunos = qtdeAlunos;
            return View();
        }
    }
}