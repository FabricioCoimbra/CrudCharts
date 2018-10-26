using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class OrcamentoDav
    {
        public int NrOs { get; set; }
        public int NrSequencia { get; set; }
        public int? NrDav { get; set; }
        public int? NrCooDav { get; set; }
        public int? NrCooCupom { get; set; }
        public int? CdUsuario { get; set; }
        public DateTime? DtAtz { get; set; }
        public int? CdImpfiscal { get; set; }
        public string MfAdicional { get; set; }
        public string FlCancelado { get; set; }
        public decimal? VlTotalDav { get; set; }
        public int? NrCcfCupom { get; set; }
        public string HashOrcamentoDavD2 { get; set; }
        public string HashOrcamentoDavD3 { get; set; }
    }
}
