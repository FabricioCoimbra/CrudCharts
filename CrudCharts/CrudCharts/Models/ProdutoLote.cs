using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class ProdutoLote
    {
        public int IdGeral { get; set; }
        public int? IdNfec { get; set; }
        public string CdProduto { get; set; }
        public string NrLote { get; set; }
        public DateTime? DtFabricacao { get; set; }
        public DateTime? DtValidade { get; set; }
        public double? QtEntrada { get; set; }
        public double? QtSaida { get; set; }
        public int? IdNfsc { get; set; }
        public DateTime? DtLancamentoLote { get; set; }
        public int NrSequencial { get; set; }

        public Produto CdProdutoNavigation { get; set; }
        public Nfec IdNfecNavigation { get; set; }
    }
}
