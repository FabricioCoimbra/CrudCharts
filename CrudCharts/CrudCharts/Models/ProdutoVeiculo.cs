using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class ProdutoVeiculo
    {
        public int CdFilial { get; set; }
        public string CdProduto { get; set; }
        public string Placa { get; set; }
        public int CdMontadora { get; set; }
        public int CdVeiculo { get; set; }
        public string Chassi { get; set; }
        public string Renavan { get; set; }
        public string NmCorMontadora { get; set; }
        public int? AnoMod { get; set; }
        public int? AnoFab { get; set; }
        public string Motor { get; set; }
        public string Potencia { get; set; }
        public int? Passageiros { get; set; }
        public string Categoria { get; set; }
        public int? Cilindradas { get; set; }
        public string Obs { get; set; }
        public int? NrDocumentoNfs { get; set; }
        public string FlNovo { get; set; }
        public double? Km { get; set; }
        public string CdCor { get; set; }
        public string CdCombustivel { get; set; }
        public string CdEspecie { get; set; }
        public string CdTipo { get; set; }
        public int? CdRestricao { get; set; }
        public string CdCorMontadora { get; set; }
        public decimal? PesoLiq { get; set; }
        public decimal? PesoBrt { get; set; }
        public string NrSerie { get; set; }
        public string Cmkg { get; set; }
        public string DistEntreEixos { get; set; }
        public string TpPintura { get; set; }
        public string CdVin { get; set; }
        public int? CondVeiculo { get; set; }
        public string CdModeloRenavan { get; set; }

        public Montadora Cd { get; set; }
        public VeiculoCombustivel CdCombustivelNavigation { get; set; }
        public VeiculoCor CdCorNavigation { get; set; }
        public VeiculoEspecie CdEspecieNavigation { get; set; }
        public Veiculo CdNavigation { get; set; }
        public Produto CdProdutoNavigation { get; set; }
        public VeiculoTipo CdTipoNavigation { get; set; }
    }
}
