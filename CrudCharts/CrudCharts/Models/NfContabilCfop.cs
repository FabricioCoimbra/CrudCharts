using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class NfContabilCfop
    {
        public int IdGeral { get; set; }
        public int IdNfContabilC { get; set; }
        public string Cfop { get; set; }
        public decimal ImpostoAliq { get; set; }
        public string ImpostoTipo { get; set; }
        public decimal? ImpostoVlBase { get; set; }
        public decimal? ImpostoVl { get; set; }
        public decimal? IcmsStVlBase { get; set; }
        public decimal? IcmsStVl { get; set; }
        public decimal? VlIsento { get; set; }
        public decimal? VlOutros { get; set; }
        public decimal? VlTotal { get; set; }
        public string Cst { get; set; }
        public decimal? ImpostoVlRedBase { get; set; }

        public NfContabilC IdNfContabilCNavigation { get; set; }
    }
}
