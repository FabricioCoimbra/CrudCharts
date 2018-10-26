using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class OrcamentoI
    {
        public OrcamentoI()
        {
            OrcamentoIAgrupaOrcamentoI = new HashSet<OrcamentoIAgrupa>();
            OrcamentoIAgrupaOrcamentoINavigation = new HashSet<OrcamentoIAgrupa>();
        }

        public int CdFilial { get; set; }
        public int NrOs { get; set; }
        public int NrSequencia { get; set; }
        public string CdProduto { get; set; }
        public string NmProduto { get; set; }
        public string UnMedida { get; set; }
        public string FlServico { get; set; }
        public double? QtProduto { get; set; }
        public string Box { get; set; }
        public string LocalEstocagem { get; set; }
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
        public string NrSerieEquip { get; set; }
        public decimal? PcAcrescimo { get; set; }
        public decimal? VlDesconto { get; set; }
        public decimal? VlAcrescimo { get; set; }
        public double? FatorConversao { get; set; }
        public double? QtVenda { get; set; }
        public string UnVenda { get; set; }
        public bool? FlItemCancelado { get; set; }
        public string HashOrcamentoID3 { get; set; }
        public bool? FlReservandoEstoque { get; set; }
        public string FlAlteracao { get; set; }
        public string HrAlteracao { get; set; }
        public string CdPedComp { get; set; }
        public int? NrItemPedComp { get; set; }

        public Produto CdProdutoNavigation { get; set; }
        public OrcamentoIReservaEstoque OrcamentoIReservaEstoque { get; set; }
        public ICollection<OrcamentoIAgrupa> OrcamentoIAgrupaOrcamentoI { get; set; }
        public ICollection<OrcamentoIAgrupa> OrcamentoIAgrupaOrcamentoINavigation { get; set; }
    }
}
