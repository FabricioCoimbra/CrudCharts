using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class PedidoI
    {
        public int NrPedido { get; set; }
        public int NrSequencia { get; set; }
        public string CdProduto { get; set; }
        public double QtProduto { get; set; }
        public decimal? VlUnitario { get; set; }
        public DateTime DtAtz { get; set; }
        public string UnMedida { get; set; }
        public double? QtCompra { get; set; }
        public string UnCompra { get; set; }
        public double? FatorConversao { get; set; }
        public string NmProduto { get; set; }
        public string CdProdutoFornecedor { get; set; }

        public PedidoC NrPedidoNavigation { get; set; }
        public UnMedida UnMedidaNavigation { get; set; }
    }
}
