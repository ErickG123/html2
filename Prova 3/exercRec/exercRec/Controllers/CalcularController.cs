using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace exercRec.Controllers
{
    public class CalcularController : Controller
    {
        // GET: Calcular
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Resultado()
        {
            double mes1 = double.Parse(Request["mes1"]);
            double mes2 = double.Parse(Request["mes2"]);
            double mes3 = double.Parse(Request["mes3"]);
            double mes4 = double.Parse(Request["mes4"]);
            double mes5 = double.Parse(Request["mes5"]);
            double mes6 = double.Parse(Request["mes6"]);
            double mes7 = double.Parse(Request["mes7"]);
            double mes8 = double.Parse(Request["mes8"]);
            double mes9 = double.Parse(Request["mes9"]);
            double mes10 = double.Parse(Request["mes10"]);
            double mes11 = double.Parse(Request["mes11"]);
            double mes12 = double.Parse(Request["mes12"]);

            string jan = "Janeiro";
            string fev = "Fevereiro";
            string mar = "Março";
            string abr = "Abril";
            string mai = "Maio";
            string jun = "Junho";
            string jul = "Julho";
            string ago = "Agosto";
            string set = "Setembro";
            string outu = "Outubro";
            string nov = "Novembro";
            string dez = "Dezembro";

            double media, primeiroSemestre, segundoSemestre;
            double mesQuente, mesFrio;
            string[] meuVetor = new string[12];

            //Média do ano
            media = (mes1 + mes2 + mes3 + mes4 + mes5 + mes6 + mes7 + mes8 + mes9 + mes10 + mes11 + mes12) / 12;
            ViewBag.Media = media;

            //Semestre mais quente
            primeiroSemestre = mes1 + mes2 + mes3 + mes4 + mes5 + mes6;
            segundoSemestre = mes7 + mes8 + mes9 + mes10 + mes11 + mes12;

            if (primeiroSemestre > segundoSemestre)
            {
                ViewBag.Semestre = primeiroSemestre;
                ViewBag.PrimSem = "Primeiro Semestre";
            }
            else
            {
                ViewBag.Semestre = segundoSemestre;
                ViewBag.SegunSem = "Segundo Semestre";
            }

            //Temperatura inferior a média
            //Não conseguimos fazer essa parte 

            //Mês mais quente
            if (mes1 >= mes2 && mes1 >= mes3 && mes1 >= mes4 && mes1 >= mes5 && mes1 >= mes6 && 
                mes1 >= mes7 && mes1 >= mes8 && mes1 >= mes9 && mes1 >= mes10 && mes1 >= mes11 && 
                mes1 >= mes12)
            {
                mesQuente = mes1;
                ViewBag.Quente = mes1;
                ViewBag.Nome = "Janeiro";
            }
            if (mes2 >= mes1 && mes2 >= mes3 && mes2 >= mes4 && mes2 >= mes5 && mes2 >= mes6 &&
                mes2 >= mes7 && mes2 >= mes8 && mes2 >= mes9 && mes2 >= mes10 && mes2 >= mes11 &&
                mes2 >= mes12)
            {
                mesQuente = mes2;
                ViewBag.Quente = mes2;
                ViewBag.Nome = "Fevereiro";
            }
            if (mes3 >= mes1 && mes3 >= mes2 && mes3 >= mes4 && mes3 >= mes5 && mes3 >= mes6 &&
                mes3 >= mes7 && mes3 >= mes8 && mes3 >= mes9 && mes3 >= mes10 && mes3 >= mes11 &&
                mes3 >= mes12)
            {
                mesQuente = mes3;
                ViewBag.Quente = mes3;
                ViewBag.Nome = "Março";
            }
            if (mes4 >= mes1 && mes4 >= mes2 && mes4 >= mes3 && mes4 >= mes5 && mes4 >= mes6 &&
                mes4 >= mes7 && mes4 >= mes8 && mes4 >= mes9 && mes4 >= mes10 && mes4 >= mes11 &&
                mes4 >= mes12)
            {
                mesQuente = mes4;
                ViewBag.Quente = mes4;
                ViewBag.Nome = "Abril";
            }
            if (mes5 >= mes1 && mes5 >= mes2 && mes5 >= mes3 && mes5 >= mes4 && mes5 >= mes6 &&
                mes5 >= mes7 && mes5 >= mes8 && mes5 >= mes9 && mes5 >= mes10 && mes5 >= mes11 &&
                mes5 >= mes12)
            {
                mesQuente = mes5;
                ViewBag.Quente = mes5;
                ViewBag.Nome = "Maio";
            }
            if (mes6 >= mes1 && mes6 >= mes2 && mes6 >= mes3 && mes6 >= mes4 && mes6 >= mes5 &&
                mes6 >= mes7 && mes6 >= mes8 && mes6 >= mes9 && mes6 >= mes10 && mes6 >= mes11 &&
                mes6 >= mes12)
            {
                mesQuente = mes6;
                ViewBag.Quente = mes6;
                ViewBag.Nome = "Junho";
            }
            if (mes7 >= mes1 && mes7 >= mes2 && mes7 >= mes3 && mes7 >= mes4 && mes7 >= mes5 &&
                mes7 >= mes6 && mes7 >= mes8 && mes7 >= mes9 && mes7 >= mes10 && mes7 >= mes11 &&
                mes7 >= mes12)
            {
                mesQuente = mes7;
                ViewBag.Quente = mes7;
                ViewBag.Nome = "Julho";
            }
            if (mes8 >= mes1 && mes8 >= mes2 && mes8 >= mes3 && mes8 >= mes4 && mes8 >= mes5 &&
                mes8 >= mes6 && mes8 >= mes7 && mes8 >= mes9 && mes8 >= mes10 && mes8 >= mes11 &&
                mes8 >= mes12)
            {
                mesQuente = mes5;
                ViewBag.Quente = mes5;
                ViewBag.Nome = "Agosto";
            }
            if (mes9 >= mes1 && mes9 >= mes2 && mes9 >= mes3 && mes9 >= mes4 && mes9 >= mes5 &&
                mes9 >= mes6 && mes9 >= mes7 && mes9 >= mes8 && mes9 >= mes10 && mes9 >= mes11 &&
                mes9 >= mes12)
            {
                mesQuente = mes9;
                ViewBag.Quente = mes9;
                ViewBag.Nome = "Setembro";
            }
            if (mes10 >= mes1 && mes10 >= mes2 && mes10 >= mes3 && mes10 >= mes4 && mes10 >= mes5 &&
                mes10 >= mes6 && mes10 >= mes7 && mes10 >= mes8 && mes10 >= mes9 && mes10 >= mes11 &&
                mes10 >= mes12)
            {
                mesQuente = mes10;
                ViewBag.Quente = mes10;
                ViewBag.Nome = "Outubro";
            }
            if (mes11 >= mes1 && mes11 >= mes2 && mes11 >= mes3 && mes11 >= mes4 && mes11 >= mes6 &&
                mes11 >= mes7 && mes11 >= mes8 && mes11 >= mes9 && mes11 >= mes10 && mes11 >= mes5 &&
                mes11 >= mes12)
            {
                mesQuente = mes11;
                ViewBag.Quente = mes11;
                ViewBag.Nome = "Novembro";
            }
            if (mes12 >= mes1 && mes12 >= mes2 && mes12 >= mes3 && mes12 >= mes4 && mes12 >= mes6 &&
                mes12 >= mes7 && mes12 >= mes8 && mes12 >= mes9 && mes12 >= mes10 && mes12 >= mes11 &&
                mes12 >= mes5)
            {
                mesQuente = mes12;
                ViewBag.Quente = mes12;
                ViewBag.Nome = "Dezembro";
            }

            //Mês mais frio
            if (mes1 <= mes2 && mes1 <= mes3 && mes1 <= mes4 && mes1 <= mes5 && mes1 <= mes6 &&
                mes1 <= mes7 && mes1 <= mes8 && mes1 <= mes9 && mes1 <= mes10 && mes1 <= mes11 &&
                mes1 <= mes12)
            {
                mesFrio = mes1;
                ViewBag.Frio = mes1;
                ViewBag.NomeF = "Janeiro";
            }
            if (mes2 <= mes1 && mes2 <= mes3 && mes2 <= mes4 && mes2 <= mes5 && mes2 <= mes6 &&
                mes2 <= mes7 && mes2 <= mes8 && mes2 <= mes9 && mes2 <= mes10 && mes2 <= mes11 &&
                mes2 <= mes12)
            {
                mesFrio = mes2;
                ViewBag.Frio = mes2;
                ViewBag.NomeF = "Fevereiro";
            }
            if (mes3 <= mes1 && mes3 <= mes2 && mes3 <= mes4 && mes3 <= mes5 && mes3 <= mes6 &&
                mes3 <= mes7 && mes3 <= mes8 && mes3 <= mes9 && mes3 <= mes10 && mes3 <= mes11 &&
                mes3 <= mes12)
            {
                mesFrio = mes3;
                ViewBag.Frio = mes3;
                ViewBag.NomeF = "Março";
            }
            if (mes4 <= mes1 && mes4 <= mes2 && mes4 <= mes3 && mes4 <= mes5 && mes4 <= mes6 &&
                mes4 <= mes7 && mes4 <= mes8 && mes4 <= mes9 && mes4 <= mes10 && mes4 <= mes11 &&
                mes4 <= mes12)
            {
                mesFrio = mes4;
                ViewBag.Frio = mes4;
                ViewBag.NomeF = "Abril";
            }
            if (mes5 <= mes1 && mes5 <= mes2 && mes5 <= mes3 && mes5 <= mes4 && mes5 <= mes6 &&
                mes5 <= mes7 && mes5 <= mes8 && mes5 <= mes9 && mes5 <= mes10 && mes5 <= mes11 &&
                mes5 <= mes12)
            {
                mesFrio = mes5;
                ViewBag.Frio = mes5;
                ViewBag.NomeF = "Maio";
            }
            if (mes6 <= mes1 && mes6 <= mes2 && mes6 <= mes3 && mes6 <= mes4 && mes6 <= mes5 &&
                mes6 <= mes7 && mes6 <= mes8 && mes6 <= mes9 && mes6 <= mes10 && mes6 <= mes11 &&
                mes6 <= mes12)
            {
                mesFrio = mes6;
                ViewBag.Frio = mes6;
                ViewBag.NomeF = "Junho";
            }
            if (mes7 <= mes1 && mes7 <= mes2 && mes7 <= mes3 && mes7 <= mes4 && mes7 <= mes5 &&
                mes7 <= mes6 && mes7 <= mes8 && mes7 <= mes9 && mes7 <= mes10 && mes7 <= mes11 &&
                mes7 <= mes12)
            {
                mesFrio = mes7;
                ViewBag.Frio = mes7;
                ViewBag.NomeF = "Julho";
            }
            if (mes8 <= mes1 && mes8 <= mes2 && mes8 <= mes3 && mes8 <= mes4 && mes8 <= mes5 &&
                mes8 <= mes6 && mes8 <= mes7 && mes8 <= mes9 && mes8 <= mes10 && mes8 <= mes11 &&
                mes8 <= mes12)
            {
                mesFrio = mes5;
                ViewBag.Frio = mes5;
                ViewBag.NomeF = "Agosto";
            }
            if (mes9 <= mes1 && mes9 <= mes2 && mes9 <= mes3 && mes9 <= mes4 && mes9 <= mes5 &&
                mes9 <= mes6 && mes9 <= mes7 && mes9 <= mes8 && mes9 <= mes10 && mes9 <= mes11 &&
                mes9 <= mes12)
            {
                mesFrio = mes9;
                ViewBag.Frio = mes9;
                ViewBag.NomeF = "Setembro";
            }
            if (mes10 <= mes1 && mes10 <= mes2 && mes10 <= mes3 && mes10 <= mes4 && mes10 <= mes5 &&
                mes10 <= mes6 && mes10 <= mes7 && mes10 <= mes8 && mes10 <= mes9 && mes10 <= mes11 &&
                mes10 <= mes12)
            {
                mesQuente = mes10;
                ViewBag.Frio = mes10;
                ViewBag.NomeF = "Outubro";
            }
            if (mes11 <= mes1 && mes11 <= mes2 && mes11 <= mes3 && mes11 <= mes4 && mes11 <= mes6 &&
                mes11 <= mes7 && mes11 <= mes8 && mes11 <= mes9 && mes11 <= mes10 && mes11 <= mes5 &&
                mes11 <= mes12)
            {
                mesFrio = mes11;
                ViewBag.Frio = mes11;
                ViewBag.NomeF = "Novembro";
            }
            if (mes12 <= mes1 && mes12 <= mes2 && mes12 <= mes3 && mes12 <= mes4 && mes12 <= mes6 &&
                mes12 <= mes7 && mes12 <= mes8 && mes12 <= mes9 && mes12 <= mes10 && mes12 <= mes11 &&
                mes12 <= mes5)
            {
                mesFrio = mes12;
                ViewBag.Frio = mes12;
                ViewBag.NomeF = "Dezembro";
            }
            return View();
        }
    }
}