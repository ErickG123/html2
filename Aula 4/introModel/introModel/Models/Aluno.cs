using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace introModel.Models
{
    public class Aluno
    {
        public int IdAluno { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }
    }
}