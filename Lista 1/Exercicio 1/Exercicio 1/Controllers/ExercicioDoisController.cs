using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exercicio_1.Controllers
{
    public class ExercicioDoisController : Controller
    {
        // GET: ExercicioDois
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Resultado()
        {
            string num = Request["numTab"];
            int num1, num2, num3, num4, num5,
                num6, num7, num8, num9, num10;

            num1 = int.Parse(num) * 1;
            num2 = int.Parse(num) * 2;
            num3 = int.Parse(num) * 3;
            num4 = int.Parse(num) * 4;
            num5 = int.Parse(num) * 5;
            num6 = int.Parse(num) * 6;
            num7 = int.Parse(num) * 7;
            num8 = int.Parse(num) * 8;
            num9 = int.Parse(num) * 9;
            num10 = int.Parse(num) * 10;

            ViewBag.Num = num;

            ViewBag.NumUm = num1;
            ViewBag.NumDois = num2;
            ViewBag.NumTres = num3;
            ViewBag.NumQuatro = num4;
            ViewBag.NumCinco = num5;
            ViewBag.NumSeis = num6;
            ViewBag.NumSete = num7;
            ViewBag.NumOito = num8;
            ViewBag.NumNove = num9;
            ViewBag.NumDez = num10;

            return View();
        }
    }
}