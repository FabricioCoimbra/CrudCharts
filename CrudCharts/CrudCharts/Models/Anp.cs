using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class Anp
    {
        public string Codigo { get; set; }
        public string CdAnp { get; set; }
        public string DescricaoAnp { get; set; }
        public decimal? PcGlp { get; set; }
        public decimal? PcGasNacional { get; set; }
        public decimal? PcGasImportado { get; set; }
        public string Codif { get; set; }
        public decimal? VlPartida { get; set; }
    }
}
