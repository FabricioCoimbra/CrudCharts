using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class ProdutoCliente
    {
        public int CdFilial { get; set; }
        public int CdCliente { get; set; }
        public int NrSequencia { get; set; }
        public string CdProduto { get; set; }
        public string NrSerie { get; set; }
        public string Obs { get; set; }
        public int? AnoFabricacao { get; set; }
        public int? AnoModelo { get; set; }
        public DateTime? DataAquisicao { get; set; }
        public string Cor { get; set; }
        public string NumChassi { get; set; }
        public string NumMotor { get; set; }
        public string CdCombustivel { get; set; }
        public string NumTransmissao { get; set; }
        public string SerieTransmissao { get; set; }
        public int? NumDiferencial { get; set; }
        public string Torre { get; set; }
        public DateTime? EntregaTecnica { get; set; }

        public Cliente Cd { get; set; }
        public VeiculoCombustivel CdCombustivelNavigation { get; set; }
        public Produto CdProdutoNavigation { get; set; }
    }
}
