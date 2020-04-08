using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace exercicioTreino.Models
{
    public class EscolaContext
    {
        public virtual ICollection<Aluno> Aluno { get; set; }
        public virtual ICollection<Cidade> Cidade { get; set; }
        public virtual ICollection<Estado> Estado { get; set; }
    }
}