using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exercicio_1.Controllers
{
    public class ExercicioTresController : Controller
    {
        // GET: ExercicioTres
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Resultado()
        {
            string inicial = Request["numInicial"];
            string final = Request["numFinal"];
            int numImp = 0;

            for(int i = int.Parse(inicial); i <= int.Parse(final); i++)
            {
                if(i % 2 == 1)
                {
                    numImp++;
                }
            }

            ViewBag.qtdeImp = numImp;
            ViewBag.numInicial = inicial;
            ViewBag.numFinal = final;
   
            return View();
        }
    }
}