using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace exercicioTreino.Models
{
    public class Estado
    {
        public int EstadoID { get; set; }
        public int Nome { get; set; }

        public virtual ICollection<Cidade> Cidade { get; set; }
    }
}