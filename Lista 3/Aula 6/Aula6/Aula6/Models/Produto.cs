using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aula6.Models
{
    public class Produto
    {
        public int IdProduto { get; set; }
        public string Categoria { get; set; }
        public string Fornecedor { get; set; }
        public string Descricao { get; set; }
        public double Peso { get; set; }
        public string Controlado { get; set; }
        public int Qtdemin { get; set; }

    }
}