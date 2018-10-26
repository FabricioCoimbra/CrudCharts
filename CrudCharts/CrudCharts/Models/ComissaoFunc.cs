using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class ComissaoFunc
    {
        public int CdFilial { get; set; }
        public int NrDocumento { get; set; }
        public int NrSequencia { get; set; }
        public int CdFuncionario { get; set; }
        public int NrParcela { get; set; }
        public int? NrNf { get; set; }
        public int? NrCupom { get; set; }
        public int? NrSr { get; set; }
        public decimal VlTotal { get; set; }
        public decimal PcSobreComissao { get; set; }
        public decimal? PcMinimo { get; set; }
        public decimal PcComissao { get; set; }
        public decimal? PcMinimoComissao { get; set; }
        public decimal VlComissao { get; set; }
        public decimal? VlPago { get; set; }
        public DateTime DtEmissao { get; set; }
        public DateTime? DtUltPgto { get; set; }
        public decimal PcComissaoGrupo { get; set; }
        public double? PcParcela { get; set; }
        public DateTime DtVcto { get; set; }
        public decimal VlBase { get; set; }
    }
}
