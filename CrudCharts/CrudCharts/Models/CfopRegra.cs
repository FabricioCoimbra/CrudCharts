using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class CfopRegra
    {
        public CfopRegra()
        {
            OperacaoCfopRegra = new HashSet<OperacaoCfopRegra>();
            Produto = new HashSet<Produto>();
        }

        public int CdCfopRegra { get; set; }
        public string NmCfopRegra { get; set; }

        public ICollection<OperacaoCfopRegra> OperacaoCfopRegra { get; set; }
        public ICollection<Produto> Produto { get; set; }
    }
}
