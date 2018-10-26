using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class Recibo
    {
        public int NrRecibo { get; set; }
        public string NmPago { get; set; }
        public string Proveniente { get; set; }
        public DateTime DtPgto { get; set; }
        public decimal VlPago { get; set; }
        public DateTime? DtAtz { get; set; }
        public int? CdFilial { get; set; }
        public string Assinatura { get; set; }
    }
}
