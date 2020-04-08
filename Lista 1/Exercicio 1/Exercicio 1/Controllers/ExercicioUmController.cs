using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exercicio_1.Controllers
{
    public class ExercicioUmController : Controller
    {
        // GET: ExercicioUm
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ImpPar()
        {
            string num1 = Request["txtNum1"];
            string num2 = Request["txtNum2"];
            string num3 = Request["txtNum3"];
            string num4 = Request["txtNum4"];

            int numP = 0, numI = 0;

            if (double.Parse(num1) % 2 == 0)
            {
                numP = numP + 1;
                ViewBag.Par = numP;
            }
            else
            {
                numI = numI + 1;
                ViewBag.Impar = numI;
            }


            if (double.Parse(num2) % 2 == 0)
            {
                numP = numP + 1;
                ViewBag.Par = numP;
            }
            else
            {
                numI = numI + 1;
                ViewBag.Impar = numI;
            }


            if (double.Parse(num3) % 2 == 0)
            {
                numP = numP + 1;
                ViewBag.Par = numP;
            }
            else
            {
                numI = numI + 1;
                ViewBag.Impar = numI;
            }


            if (double.Parse(num4) % 2 == 0)
            {
                numP = numP + 1;
                ViewBag.Par = numP;
            }
            else
            {
                numI = numI + 1;
                ViewBag.Impar = numI;
            }
            return View();
        }
    }
}