using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class FornecedorUnmedida
    {
        public FornecedorUnmedida()
        {
            ProdutoFornecedor = new HashSet<ProdutoFornecedor>();
        }

        public int IdGeral { get; set; }
        public int? CdFornecedor { get; set; }
        public string UnMedida { get; set; }
        public string UnMedidaForn { get; set; }
        public DateTime? DtAtz { get; set; }

        public ICollection<ProdutoFornecedor> ProdutoFornecedor { get; set; }
    }
}
