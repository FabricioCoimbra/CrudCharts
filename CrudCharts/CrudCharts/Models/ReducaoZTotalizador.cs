using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class ReducaoZTotalizador
    {
        public int CdImpfiscal { get; set; }
        public DateTime DtReducao { get; set; }
        public double PcImposto { get; set; }
        public decimal VlVendido { get; set; }
        public string TpImposto { get; set; }
        public int? NrOrdem { get; set; }
        public string HashReducaoZTotalizadorR3 { get; set; }

        public ReducaoZ ReducaoZ { get; set; }
    }
}
