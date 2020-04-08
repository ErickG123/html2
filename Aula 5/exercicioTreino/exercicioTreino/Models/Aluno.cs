using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace exercicioTreino.Models
{
    public class Aluno
    {
        public int AlunoID { get; set; }
        public string Nome { get; set; }
        public string Enderoco { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }
        public int Rm { get; set; }

        public int CidadeID { get; set; }
        [ForeignKey("CidadeID")]
        public virtual Cidade Cidade { get; set; }
    }
}