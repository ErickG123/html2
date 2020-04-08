using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ListaDois.Controllers
{
    public class ExercicioDoisController : Controller
    {
        // GET: ExercicioUm
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Resultado()
        {
            string notaUm = Request["notaUm"];
            string notaDois = Request["notaDois"];
            string notaTres = Request["notaTres"];

            double mediaNota;

            int maiorNota = 0;
            int menorNota = 0;

            //Média de idade
            mediaNota = (int.Parse(notaUm) + int.Parse(notaDois) + int.Parse(notaTres)) / 3;

            //Maior nota
            if (int.Parse(notaUm) > int.Parse(notaDois) && int.Parse(notaUm) > int.Parse(notaTres))
            {
                maiorNota++;
            }
            else if (int.Parse(notaDois) > int.Parse(notaUm) && int.Parse(notaDois) > int.Parse(notaTres))
            {
                maiorNota++;
            }
            else
            {
                maiorNota++;
            }

            //Menor nota
            if (int.Parse(notaUm) < int.Parse(notaDois) && int.Parse(notaUm) < int.Parse(notaTres))
            {
                menorNota++;
            }
            else if (int.Parse(notaDois) < int.Parse(notaUm) && int.Parse(notaDois) < int.Parse(notaTres))
            {
                menorNota++;
            }
            else
            {
                menorNota++;
            }

            ViewBag.Media = menorNota;
            ViewBag.Maior = maiorNota;
            ViewBag.Menor = menorNota;

            return View();
        }
    }
}