using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class ImpfiscalAliquota
    {
        public int CdImpfiscal { get; set; }
        public double PcImposto { get; set; }
        public string FlImposto { get; set; }
        public int? NrOrdemEcf { get; set; }

        public Impfiscal CdImpfiscalNavigation { get; set; }
    }
}
