using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ListaDois.Controllers
{
    public class ExercicioQuatroController : Controller
    {
        // GET: ExercicioQuatro
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Resultado()
        {
            int inicial = int.Parse(Request["numInicial"]);
            int final = int.Parse(Request["numFinal"]);
            int numMultTres = 0;

            for (int i = inicial; i <= final; i++)
            {
                if (i % 3 == 0)
                {
                    numMultTres++;
                }
            }

            ViewBag.qtdeMultTres = numMultTres;
            ViewBag.numInicial = inicial;
            ViewBag.numFinal = final;

            return View();
        }
    }
}