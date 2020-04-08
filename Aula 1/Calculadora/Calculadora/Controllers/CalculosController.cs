using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Calculadora.Controllers
{
    public class CalculosController : Controller
    {
        // GET: Calculos
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Somar()
        {
            //Obtém os dados do formulário
            int n1 = int.Parse(Request["txtNumero1"]);
            int n2 = int.Parse(Request["txtNumero2"]);
            string botao = Request["Calcular"];

            if(botao == "+"){
                //Realiza a soma
                int soma = n1 + n2;

                //Envia o resultado para a View
                ViewBag.Resultado = soma;
            }

            else if (botao == "-")
            {
                //Realiza a subtrai
                int soma = n1 - n2;

                //Envia o resultado para a View
                ViewBag.Resultado = soma;
            }

            else if (botao == "*")
            {
                //Realiza a multiplica
                int soma = n1 * n2;

                //Envia o resultado para a View
                ViewBag.Resultado = soma;
            }

            else if (botao == "/")
            {
                //Realiza a divide
                int soma = n1 / n2;

                //Envia o resultado para a View
                ViewBag.Resultado = soma;
            }           

            return View();
        }
    }
}