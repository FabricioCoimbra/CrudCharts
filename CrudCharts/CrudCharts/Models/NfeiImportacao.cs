using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class NfeiImportacao
    {
        public int IdGeral { get; set; }
        public int IdNfei { get; set; }
        public int NrAdicao { get; set; }
        public int NrSeqAdicao { get; set; }
        public int CdFabricante { get; set; }
        public decimal? VlDescontoDi { get; set; }
        public decimal? VlBaseIi { get; set; }
        public decimal? VlIi { get; set; }
        public decimal? VlSiscomex { get; set; }
        public decimal? VlDespAduaneira { get; set; }
        public decimal? VlIof { get; set; }

        public Nfei IdNfeiNavigation { get; set; }
    }
}
