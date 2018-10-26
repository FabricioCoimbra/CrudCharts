using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class ProdutoClassFiscalIbpt
    {
        public int IdGeral { get; set; }
        public string Codigo { get; set; }
        public int? Tabela { get; set; }
        public decimal? AliqNacFed { get; set; }
        public decimal? AliqImpFed { get; set; }
        public decimal? AliqEst { get; set; }
        public decimal? AliqMun { get; set; }
        public DateTime? DtInicio { get; set; }
        public DateTime? DtFinal { get; set; }
        public string VersaoIbpt { get; set; }
        public string Uf { get; set; }
        public string Fonte { get; set; }
    }
}
