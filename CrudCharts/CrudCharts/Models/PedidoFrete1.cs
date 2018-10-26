using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class PedidoFrete1
    {
        public int CdFilial { get; set; }
        public int NrPedido { get; set; }
        public int CdTransportadora { get; set; }
        public string TpFrete { get; set; }
        public string MarcaVolumes { get; set; }
        public string EspecieVolumes { get; set; }
        public double? QtVolumes { get; set; }
        public double? NrVolumes { get; set; }
        public double? PesoLiquido { get; set; }
        public double? PesoTotal { get; set; }
        public string PlacaTransp { get; set; }
        public string UfPlacaTransp { get; set; }
    }
}
