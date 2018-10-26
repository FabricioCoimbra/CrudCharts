using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class Custcomp
    {
        public int CdFilial { get; set; }
        public string CdProduto { get; set; }
        public DateTime DtLancamento { get; set; }
        public decimal? CustoCompraNomi { get; set; }
        public decimal? CustoMedioNomi { get; set; }
        public double QtdeNomi { get; set; }
        public DateTime? DtAtz { get; set; }
        public string FlCustoAlterado { get; set; }
        public decimal? CustoCompraSimples { get; set; }
        public int IdNfei { get; set; }

        public Produto CdProdutoNavigation { get; set; }
        public Nfei IdNfeiNavigation { get; set; }
    }
}
