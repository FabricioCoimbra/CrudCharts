using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class NfsiCupom
    {
        public int CdFilial { get; set; }
        public int NrDocumento { get; set; }
        public int NrSequencia { get; set; }
        public decimal? VlBaseIcm { get; set; }
        public double? AlicIcm { get; set; }
        public double? PcRedBaseIcm { get; set; }
        public decimal? VlIcm { get; set; }
        public decimal? VlBaseIcmProprioSt { get; set; }
        public double? AlicIcmProprioSt { get; set; }
        public double? PcRedBaseIcmProprioSt { get; set; }
        public decimal? VlIcmProprioSt { get; set; }
        public decimal? VlBaseIcmSubst { get; set; }
        public double? AlicIcmSubst { get; set; }
        public double? PcRedBaseIcmSubst { get; set; }
        public double? Mva { get; set; }
        public decimal? VlIcmSubst { get; set; }
        public string Cst { get; set; }
        public int? TpImpostoEcf { get; set; }
        public string Cfop { get; set; }
        public string HashNfsiCupomR5 { get; set; }

        public Nfsi Nfsi { get; set; }
    }
}
