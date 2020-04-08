using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exercicio_1.Controllers
{
    public class ExercicioCincoController : Controller
    {
        // GET: ExercicioCinco
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Resultado()
        {
            string nomeUm = Request["nomeUm"];
            string nomeDois = Request["nomeDois"];
            string nomeTres = Request["nomeTres"];

            string pesoUm = Request["pesoUm"];
            string pesoDois = Request["pesoDois"];
            string pesoTres = Request["pesoTres"];

            string alturaUm = Request["alturaUm"];
            string alturaDois = Request["alturaDois"];
            string alturaTres = Request["alturaTres"];

            double maiorPeso;
            string pessoaMaiorPeso;

            double maiorAltura;
            string pessoaMaisAlta;

            //Nome e peso da mais gorda
            if ((double.Parse(pesoUm) > double.Parse(pesoDois)) && (double.Parse(pesoUm) > double.Parse(pesoTres)))
            {
                maiorPeso = double.Parse(pesoUm);
                pessoaMaiorPeso = nomeUm;

                ViewBag.maiorPeso = maiorPeso;
                ViewBag.pessoaMaiorPeso = pessoaMaiorPeso;
            }

            else if ((double.Parse(pesoDois) > double.Parse(pesoUm)) && (double.Parse(pesoDois) > double.Parse(pesoTres)))
            {
                maiorPeso = double.Parse(pesoDois);
                pessoaMaiorPeso = nomeDois;

                ViewBag.maiorPeso = maiorPeso;
                ViewBag.pessoaMaiorPeso = pessoaMaiorPeso;
            }

            else
            {
                maiorPeso = double.Parse(pesoTres);
                pessoaMaiorPeso = nomeTres;

                ViewBag.maiorPeso = maiorPeso;
                ViewBag.pessoaMaiorPeso = pessoaMaiorPeso;
            }


            //Nome e peso da mais alta
            if ((double.Parse(alturaUm) > double.Parse(alturaDois)) && (double.Parse(alturaUm) > double.Parse(alturaTres)))
            {
                maiorAltura = double.Parse(alturaUm);
                pessoaMaisAlta = nomeUm;

                ViewBag.maiorAltura = maiorAltura;
                ViewBag.pessoaMaisAlta = pessoaMaisAlta;
            }

            else if ((double.Parse(alturaDois) > double.Parse(alturaUm)) && (double.Parse(alturaDois) > double.Parse(alturaTres)))
            {
                maiorAltura = double.Parse(alturaDois);
                pessoaMaisAlta = nomeDois;

                ViewBag.maiorAltura = maiorAltura;
                ViewBag.pessoaMaisAlta = pessoaMaisAlta;
            }

            else
            {
                maiorAltura = double.Parse(alturaTres);
                pessoaMaisAlta = nomeTres;

                ViewBag.maiorAltura = maiorAltura;
                ViewBag.pessoaMaisAlta = pessoaMaisAlta;
            }


            return View();
        }
    }
}