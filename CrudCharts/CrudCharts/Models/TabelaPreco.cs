using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class TabelaPreco
    {
        public TabelaPreco()
        {
            Filial = new HashSet<Filial>();
            FrenteCaixa = new HashSet<FrenteCaixa>();
            Nfsc = new HashSet<Nfsc>();
            OrcamentoC = new HashSet<OrcamentoC>();
            TabelaPrecoProduto = new HashSet<TabelaPrecoProduto>();
        }

        public int CdTabelaPreco { get; set; }
        public string NmTabelaPreco { get; set; }
        public string FlPercentual { get; set; }

        public ICollection<Filial> Filial { get; set; }
        public ICollection<FrenteCaixa> FrenteCaixa { get; set; }
        public ICollection<Nfsc> Nfsc { get; set; }
        public ICollection<OrcamentoC> OrcamentoC { get; set; }
        public ICollection<TabelaPrecoProduto> TabelaPrecoProduto { get; set; }
    }
}
