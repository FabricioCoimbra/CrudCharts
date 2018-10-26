using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class DocProducao
    {
        public int CdFilial { get; set; }
        public int NrDocumento { get; set; }
        public int? NrOrdemProducao { get; set; }
        public int IdNfec { get; set; }
        public int IdNfsc { get; set; }
        public int CdCancelamento { get; set; }
        public double? QtProduzido { get; set; }
        public DateTime DtProducao { get; set; }
        public DateTime DtEmissao { get; set; }

        public Filial CdFilialNavigation { get; set; }
    }
}
