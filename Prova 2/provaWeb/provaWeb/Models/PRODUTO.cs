//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace provaWeb.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PRODUTO
    {
        public int IDPRODUTO { get; set; }
        public string NOMEPRODUTO { get; set; }
        public Nullable<decimal> QTDEESTOQUE { get; set; }
        public Nullable<decimal> PRECOVENDA { get; set; }
        public Nullable<System.DateTime> DATAVALIDADE { get; set; }
        public Nullable<int> CATEGORIA { get; set; }
    
        public virtual CATEGORIA CATEGORIA1 { get; set; }
    }
}
