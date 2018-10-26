using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class Tabvcto
    {
        public int CdFilial { get; set; }
        public int NrOs { get; set; }
        public int Parcela { get; set; }
        public int PrazoParcela { get; set; }
        public DateTime DtVcto { get; set; }
        public decimal? PcParcela { get; set; }
        public decimal VlVcto { get; set; }
        public DateTime? DtAtz { get; set; }
    }
}
