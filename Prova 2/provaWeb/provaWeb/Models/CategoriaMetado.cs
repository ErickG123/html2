using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace provaWeb.Models
{
    public class CategoriaMetado
    {
        [Required(ErrorMessage = "Obrigatório informar o nome da categoria")]
        [StringLength(30, ErrorMessage = "O nome da categoria deve possuir no máximo 20 caracteres")]
        public string CATEGORIA1 { get; set; }

    }
}