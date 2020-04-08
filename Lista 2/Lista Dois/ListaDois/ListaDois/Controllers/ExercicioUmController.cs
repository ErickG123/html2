using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ListaDois.Controllers
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
            string anoUm = Request["pessoaUm"];
            string anoDois = Request["pessoaDois"];
            string anoTres = Request["pessoaTres"];
            string anoQuatro = Request["pessoaQuatro"];

            int idadeUm;
            int idadeDois;
            int idadeTres;
            int idadeQuatro;

            idadeUm = 2019 - int.Parse(anoUm);
            idadeDois = 2019 - int.Parse(anoDois);
            idadeTres = 2019 - int.Parse(anoTres);
            idadeQuatro = 2019 - int.Parse(anoQuatro);

            double mediaIdade;

            //Média de idade
            mediaIdade = (idadeUm + idadeDois + idadeTres + idadeQuatro) / 4;

            int qtdeMaior = 0;
            int qtdeMenor = 0;

            //Menor de idade
            if(idadeUm < 18)
            {
                qtdeMenor++;
            }

            if (idadeDois < 18)
            {
                qtdeMenor++;
            }

            if (idadeTres < 18)
            {
                qtdeMenor++;
            }

            if (idadeQuatro < 18)
            {
                qtdeMenor++;
            }


            //Maior de idade
            if (idadeUm >= 18)
            {
                qtdeMaior++;
            }

            if (idadeDois >= 18)
            {
                qtdeMaior++;
            }

            if (idadeTres >= 18)
            {
                qtdeMaior++;
            }

            if (idadeQuatro >= 18)
            {
                qtdeMaior++;
            }

            ViewBag.MaiorIdade = qtdeMaior;
            ViewBag.MenorIdade = qtdeMenor;
            ViewBag.MediaIdade = mediaIdade;

            return View();
        }
    }
}