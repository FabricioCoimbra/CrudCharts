using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class DocNaoFiscalI
    {
        public long IdGeral { get; set; }
        public long IdDocNaoFiscal { get; set; }
        public string NmPagamento { get; set; }
        public decimal? VlPago { get; set; }

        public DocNaoFiscalC IdDocNaoFiscalNavigation { get; set; }
    }
}
