using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class ProdComposto
    {
        public string CdProduto { get; set; }
        public string CdComposto { get; set; }
        public double? QtComposto { get; set; }
        public string NmProdcomposto { get; set; }
        public DateTime? DtAtz { get; set; }
        public double? QtLiquido { get; set; }

        public Produto CdProdutoNavigation { get; set; }
    }
}
