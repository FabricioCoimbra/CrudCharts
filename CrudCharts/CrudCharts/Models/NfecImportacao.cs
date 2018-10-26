using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class NfecImportacao
    {
        public int IdGeral { get; set; }
        public int IdNfec { get; set; }
        public string NrDi { get; set; }
        public DateTime DtDi { get; set; }
        public int CdCidadeDesembaraco { get; set; }
        public DateTime DtDesembaraco { get; set; }
        public decimal? VlBaseIi { get; set; }
        public decimal? VlIi { get; set; }
        public decimal? VlSiscomex { get; set; }
        public decimal? VlDespAduaneira { get; set; }
        public decimal? VlIof { get; set; }
        public decimal? TaxaDolar { get; set; }
        public string FlCustoIi { get; set; }
        public string FlCustoIpi { get; set; }
        public string FlCustoIcm { get; set; }
        public string FlCustoPisCofins { get; set; }
        public int? TpViatransp { get; set; }
        public decimal? VlAfrmm { get; set; }
        public int? TpIntermedio { get; set; }
        public string CgcCpfAdquirente { get; set; }
        public string UfTerceiro { get; set; }

        public Nfec IdNfecNavigation { get; set; }
    }
}
