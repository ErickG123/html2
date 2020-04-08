using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace exercicioTreino.Models
{
    public class Cidade
    {
        public int CidadeID { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<Aluno> Aluno { get; set; }

        public int EstadoID { get; set; }
        [ForeignKey("EstadoID")]
        public virtual Estado Estado { get; set; }
    }
}