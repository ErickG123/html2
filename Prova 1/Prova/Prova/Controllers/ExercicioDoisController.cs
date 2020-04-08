using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Prova.Controllers
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
            double sal1 = double.Parse(Request["txtS1"]);
            double sal2 = double.Parse(Request["txtS2"]);
            double sal3 = double.Parse(Request["txtS3"]);
            double sal4 = double.Parse(Request["txtS4"]);
            double sal5 = double.Parse(Request["txtS5"]);
            double sal6 = double.Parse(Request["txtS6"]);
            double sal7 = double.Parse(Request["txtS7"]);

            double fil1 = double.Parse(Request["txtF1"]);
            double fil2 = double.Parse(Request["txtF2"]);
            double fil3 = double.Parse(Request["txtF3"]);
            double fil4 = double.Parse(Request["txtF4"]);
            double fil5 = double.Parse(Request["txtF5"]);
            double fil6 = double.Parse(Request["txtF6"]);
            double fil7 = double.Parse(Request["txtF7"]);

            double mediaSal, mediaFil;
            double maiorSal;
            double qtdePer = 0;
            double percentualSal;

            mediaSal = (sal1 + sal2 + sal3 + sal4 + sal5 + sal6 + sal7) / 7;
            ViewBag.Salario = mediaSal;

            mediaFil = (fil1 + fil2 + fil3 + fil4 + fil5 + fil6 + fil7) / 7;
            ViewBag.Filho = mediaFil;

            if(sal1 > sal2 && sal1 > sal3 && sal1 > sal4 && sal1 > sal5 && sal1 > sal6 && sal1 > sal7)
            {
                maiorSal = sal1;
                ViewBag.MaiorSal = maiorSal;
            }

            if(sal2 > sal1 && sal2 > sal3 && sal2 > sal4 && sal2 > sal5 && sal2 > sal6 && sal2 > sal7)
            {
                maiorSal = sal2;
                ViewBag.MaiorSal = maiorSal;
            }

            if(sal3 > sal1 && sal3 > sal2 && sal3 > sal4 && sal3 > sal5 && sal3 > sal6 && sal3 > sal7)
            {
                maiorSal = sal3;
                ViewBag.MaiorSal = maiorSal;
            }

            if(sal4 > sal1 && sal4 > sal2 && sal4 > sal3 && sal4 > sal5 && sal4 > sal6 && sal4 > sal7)
            {
                maiorSal = sal4;
                ViewBag.MaiorSal = maiorSal;
            }

            if (sal5 > sal1 && sal5 > sal2 && sal5 > sal3 && sal5 > sal4 && sal5 > sal6 && sal5 > sal7)
            {
                maiorSal = sal5;
                ViewBag.MaiorSal = maiorSal;
            }

            if (sal6 > sal1 && sal6 > sal2 && sal6 > sal3 && sal6 > sal4 && sal6 > sal5 && sal6 > sal7)
            {
                maiorSal = sal6;
                ViewBag.MaiorSal = maiorSal;
            }

            if (sal7 > sal1 && sal7 > sal2 && sal7 > sal3 && sal7 > sal4 && sal7 > sal5 && sal7 > sal6)
            {
                maiorSal = sal7;
                ViewBag.MaiorSal = maiorSal;
            }

            if(sal1 < 1500)
            {
                qtdePer++;
            }

            if (sal2 < 1500)
            {
                qtdePer++;
            }

            if (sal3 < 1500)
            {
                qtdePer++;
            }

            if (sal4 < 1500)
            {
                qtdePer++;
            }

            if (sal5 < 1500)
            {
                qtdePer++;
            }

            if (sal6 < 1500)
            {
                qtdePer++;
            }

            if (sal7 < 1500)
            {
                qtdePer++;
            }

            percentualSal = (qtdePer * 100) / 7;
            ViewBag.Percentual = percentualSal;

            return View();
        }
    }
}