using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class PedidoAfvI
    {
        public int CdFilial { get; set; }
        public int NrPedido { get; set; }
        public int NrSequencia { get; set; }
        public string CdProduto { get; set; }
        public string NmProduto { get; set; }
        public string UnMedida { get; set; }
        public string FlServico { get; set; }
        public double? QtProduto { get; set; }
        public decimal? VlBruto { get; set; }
        public decimal? PcDesconto { get; set; }
        public decimal? VlLiquido { get; set; }
        public decimal? VlTotal { get; set; }
        public DateTime DtEmissao { get; set; }
        public string Complemento { get; set; }
        public int? CdFuncionario { get; set; }
        public decimal? VlCusto { get; set; }
        public DateTime? DtAtz { get; set; }
        public string CdOriginal { get; set; }
        public string CdBarras { get; set; }
        public string PlacaVeiculo { get; set; }
        public int? Kilometragem { get; set; }
        public decimal? VlIpi { get; set; }
    }
}
