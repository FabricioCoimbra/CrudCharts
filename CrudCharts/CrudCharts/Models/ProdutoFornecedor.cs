using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class ProdutoFornecedor
    {
        public int CdFilial { get; set; }
        public int CdFornecedor { get; set; }
        public string CdProduto { get; set; }
        public string CdProdForn { get; set; }
        public DateTime? DtAtz { get; set; }
        public int? IdUnimportacao { get; set; }
        public int IdProdutoFornecedor { get; set; }

        public FornecedorUnmedida IdUnimportacaoNavigation { get; set; }
    }
}
