using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class SaldoCxaDia
    {
        public int CdFilial { get; set; }
        public int CdCaixa { get; set; }
        public DateTime DtCaixa { get; set; }
        public decimal? VlSaldo { get; set; }
    }
}
