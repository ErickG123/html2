using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace provaWeb.Models
{
    [MetadataType(typeof(ProdutoMetado))]
    public partial class Medico
    {

    }

    public class ProdutoMetado
    {
        [Required(ErrorMessage = "Obrigatório informar o nome do produto")]
        [StringLength(30, ErrorMessage = "O nome de produto deve possuir no máximo 30 caracteres")]
        public string NOMEPRODUTO { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o nome do estoque")]
        [StringLength(30, ErrorMessage = "O nome de estoque deve possuir no máximo 30 caracteres")]
        public string QTDEESTOQUE { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o preço da venda")]
        public string PRECOVENDA { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a data de validade")]
        public string DATAVALIDADE { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a data de validade")]
        public string CATEGORIA { get; set; }
    }
}