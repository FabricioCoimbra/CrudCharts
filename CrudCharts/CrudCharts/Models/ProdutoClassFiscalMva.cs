using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class ProdutoClassFiscalMva
    {
        public int IdGeral { get; set; }
        public string CdClassFiscal { get; set; }
        public string UfOrigem { get; set; }
        public string UfDestino { get; set; }
        public double Mva { get; set; }
        public DateTime? DtAtz { get; set; }

        public ProdutoClassFiscal CdClassFiscalNavigation { get; set; }
    }
}
