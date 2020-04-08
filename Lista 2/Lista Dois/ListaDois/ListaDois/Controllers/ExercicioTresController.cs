using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ListaDois.Controllers
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
            string idadeUm = Request["idadeUm"];
            string idadeDois = Request["idadeDois"];
            string idadeTres = Request["idadeTres"];
            string idadeQuatro = Request["idadeQuatro"];
            string idadeCinco = Request["idadeCinco"];
            string idadeSeis = Request["idadeSeis"];
            string idadeSete = Request["idadeSete"];

            //Quantidade de eleitores
            int qtdeNEleitores = 0;
            int qtdeEleitoresObrigatorios = 0;
            int qtdeEleitoresFacultativos = 0;

            //Média das idades
            double mediaIdade = 0;
            double mediaIdadeFinal;
            int num = 0;

            //Percentual de cada categoria
            double percentualNEleitores;
            double percentualEleitores;
            double percentualFacultativos;

            //Quantidade não eleitores
            if(int.Parse(idadeUm) < 16)
            {
                qtdeNEleitores++;
                ViewBag.NEleitores = qtdeNEleitores;
            }

            if (int.Parse(idadeDois) < 16)
            {
                qtdeNEleitores++;
                ViewBag.NEleitores = qtdeNEleitores;
            }

            if (int.Parse(idadeTres) < 16)
            {
                qtdeNEleitores++;
                ViewBag.NEleitores = qtdeNEleitores;
            }

            if (int.Parse(idadeQuatro) < 16)
            {
                qtdeNEleitores++;
                ViewBag.NEleitores = qtdeNEleitores;
            }

            if (int.Parse(idadeCinco) < 16)
            {
                qtdeNEleitores++;
                ViewBag.NEleitores = qtdeNEleitores;
            }

            if (int.Parse(idadeSeis) < 16)
            {
                qtdeNEleitores++;
                ViewBag.NEleitores = qtdeNEleitores;
            }

            if (int.Parse(idadeSete) < 16)
            {
                qtdeNEleitores++;
                ViewBag.NEleitores = qtdeNEleitores;
            }

            percentualNEleitores = qtdeNEleitores / 100.0;
            ViewBag.PercentualNEleitores = percentualNEleitores;

            //Quantidade eleitores obrigatórios
            if (int.Parse(idadeUm) > 18 && int.Parse(idadeUm) < 65)
            {
                qtdeEleitoresObrigatorios++;
                mediaIdade = mediaIdade + int.Parse(idadeDois);
                num++;

                ViewBag.EleitoresObrigatorios = qtdeEleitoresObrigatorios;
            }

            if (int.Parse(idadeDois) > 18 && int.Parse(idadeUm) < 65)
            {
                qtdeEleitoresObrigatorios++;
                mediaIdade = mediaIdade + int.Parse(idadeDois);
                num++;

                ViewBag.EleitoresObrigatorios = qtdeEleitoresObrigatorios;
            }

            if (int.Parse(idadeTres) > 18 && int.Parse(idadeTres) < 65)
            {
                qtdeEleitoresObrigatorios++;
                mediaIdade = mediaIdade + int.Parse(idadeTres);
                num++;

                ViewBag.EleitoresObrigatorios = qtdeEleitoresObrigatorios;
            }

            if (int.Parse(idadeQuatro) > 18 && int.Parse(idadeQuatro) < 65)
            {
                qtdeEleitoresObrigatorios++;
                mediaIdade = mediaIdade + int.Parse(idadeQuatro);
                num++;

                ViewBag.EleitoresObrigatorios = qtdeEleitoresObrigatorios;
            }

            if (int.Parse(idadeCinco) > 18 && int.Parse(idadeCinco) < 65)
            {
                qtdeEleitoresObrigatorios++;
                mediaIdade = mediaIdade + int.Parse(idadeCinco);
                num++;

                ViewBag.EleitoresObrigatorios = qtdeEleitoresObrigatorios;
            }

            if (int.Parse(idadeSeis) > 18 && int.Parse(idadeSeis) < 65)
            {
                qtdeEleitoresObrigatorios++;
                mediaIdade = mediaIdade + int.Parse(idadeSeis);
                num++;

                ViewBag.EleitoresObrigatorios = qtdeEleitoresObrigatorios;
            }

            if (int.Parse(idadeSete) > 18 && int.Parse(idadeSete) < 65)
            {
                qtdeEleitoresObrigatorios++;
                mediaIdade = mediaIdade + int.Parse(idadeSete);
                num++;

                ViewBag.EleitoresObrigatorios = qtdeEleitoresObrigatorios;
            }

            mediaIdadeFinal = mediaIdade / num;
            ViewBag.mediaIdadeFinal = mediaIdadeFinal;
            percentualEleitores = qtdeEleitoresObrigatorios / 100.0;
            ViewBag.PercentualEleitoresObrigatorios = percentualEleitores;

            //Quantidade eleitores facultativos
            if ((int.Parse(idadeUm) >= 16) && (int.Parse(idadeUm) <= 18) && (int.Parse(idadeUm) >=65))
            {
                qtdeEleitoresFacultativos++;
                ViewBag.EleitoresFacultativos = qtdeEleitoresFacultativos;
            }

            if ((int.Parse(idadeDois) >= 16) && (int.Parse(idadeDois) <= 18) && (int.Parse(idadeDois) >= 65))
            {
                qtdeEleitoresFacultativos++;
                ViewBag.EleitoresFacultativos = qtdeEleitoresFacultativos;
            }

            if ((int.Parse(idadeTres) >= 16) && (int.Parse(idadeTres) <= 18) && (int.Parse(idadeTres) >= 65))
            {
                qtdeEleitoresFacultativos++;
                ViewBag.EleitoresFacultativos = qtdeEleitoresFacultativos;
            }

            if ((int.Parse(idadeQuatro) >= 16) && (int.Parse(idadeQuatro) <= 18) && (int.Parse(idadeQuatro) >= 65))
            {
                qtdeEleitoresFacultativos++;
                ViewBag.EleitoresFacultativos = qtdeEleitoresFacultativos;
            }

            if ((int.Parse(idadeCinco) >= 16) && (int.Parse(idadeCinco) <= 18) && (int.Parse(idadeCinco) >= 65))
            {
                qtdeEleitoresFacultativos++;
                ViewBag.EleitoresFacultativos = qtdeEleitoresFacultativos;
            }

            if ((int.Parse(idadeSeis) >= 16) && (int.Parse(idadeSeis) <= 18) && (int.Parse(idadeSeis) >= 65))
            {
                qtdeEleitoresFacultativos++;
                ViewBag.EleitoresFacultativos = qtdeEleitoresFacultativos;
            }

            if ((int.Parse(idadeSete) >= 16) && (int.Parse(idadeSete) <= 18) && (int.Parse(idadeSete) >= 65))
            {
                qtdeEleitoresFacultativos++;
                ViewBag.EleitoresFacultativos = qtdeEleitoresFacultativos;
            }

            percentualFacultativos = qtdeEleitoresFacultativos / 100.0;
            ViewBag.PercentualEleitoresFacultativos = percentualFacultativos;

            return View();
        }
    }
}