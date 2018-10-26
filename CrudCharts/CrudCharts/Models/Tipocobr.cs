using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class Tipocobr
    {
        public int CdTipocobr { get; set; }
        public string NmTipocobr { get; set; }
        public bool? FlEmitirBloqueto { get; set; }
        public DateTime? DtAtz { get; set; }
        public decimal? VlAcrescimo { get; set; }
        public bool FlImprimeParcela { get; set; }
        public string TpCobranca { get; set; }
        public string DescricaoTpCobranca { get; set; }
        public bool? FlImprimeCarneEcf { get; set; }
        public bool? FlImprimeComprovanteEcf { get; set; }
        public decimal? TaxaDesc { get; set; }
        public bool? FlPorcentagem { get; set; }
    }
}
