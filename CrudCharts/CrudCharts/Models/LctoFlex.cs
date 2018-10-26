using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class LctoFlex
    {
        public int IdGeral { get; set; }
        public int CdVendedor { get; set; }
        public DateTime DtLcto { get; set; }
        public decimal Valor { get; set; }
        public string FlDebCred { get; set; }
        public string Obs { get; set; }
        public int? NrDocumento { get; set; }
        public int CdFilial { get; set; }
        public int? NrSequencia { get; set; }

        public Funcionario Cd { get; set; }
        public Filial CdFilialNavigation { get; set; }
        public Nfsi Nfsi { get; set; }
    }
}
