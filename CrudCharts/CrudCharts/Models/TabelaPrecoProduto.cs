using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class TabelaPrecoProduto
    {
        public int IdGeral { get; set; }
        public int CdTabelaPreco { get; set; }
        public string CdProduto { get; set; }
        public decimal PrecoVenda { get; set; }
        public decimal PrecoVendaMin { get; set; }
        public decimal? PrecoVendaFlexMax { get; set; }
        public decimal? PrecoVendaFlexMin { get; set; }
        public decimal? PcMarkupMin { get; set; }
        public decimal? PcMarkup { get; set; }
        public string FlUtilizaMarkup { get; set; }
        public string HashTabelaPrecoProdutoP2 { get; set; }
        public decimal? PcMarkupFlexMin { get; set; }
        public decimal? PcMarkupFlexMax { get; set; }
        public string FlUtilizaMarkupFlex { get; set; }
        public DateTime? DtAtz { get; set; }

        public TabelaPreco CdTabelaPrecoNavigation { get; set; }
    }
}
