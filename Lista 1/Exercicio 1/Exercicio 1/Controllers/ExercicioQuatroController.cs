using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exercicio_1.Controllers
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
            string num = Request["Num"];
            int numR;
            numR = int.Parse(num);

            for(int i = 0; i <= 99; i++)
            {
                numR = numR + 1;

                ViewBag.Resultado = numR;
            }

            return View();
        }
    }
}