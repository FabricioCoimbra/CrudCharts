using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class OrcamentoC
    {
        public OrcamentoC()
        {
            ApontamentoDeServico = new HashSet<ApontamentoDeServico>();
            AuditorEstoqueC = new HashSet<AuditorEstoqueC>();
            OrcamentoContato = new HashSet<OrcamentoContato>();
        }

        public int CdFilial { get; set; }
        public int NrOs { get; set; }
        public string PlacaVeiculo { get; set; }
        public int? Kilometragem { get; set; }
        public int? CdClifor { get; set; }
        public string NmClifor { get; set; }
        public string TelMail { get; set; }
        public decimal? VlAcrescimos { get; set; }
        public decimal? VlDescontos { get; set; }
        public decimal? VlMercadorias { get; set; }
        public decimal? VlServicos { get; set; }
        public decimal? VlTotal { get; set; }
        public int CdCondpgto { get; set; }
        public decimal? VlEntrada { get; set; }
        public DateTime? DtEmissao { get; set; }
        public DateTime? DtValidade { get; set; }
        public string Problema { get; set; }
        public int? CdUsuario { get; set; }
        public DateTime? DtAtz { get; set; }
        public string NmCidade { get; set; }
        public string Uf { get; set; }
        public string NmMontadora { get; set; }
        public string NmVeiculo { get; set; }
        public string MotivoCancelamento { get; set; }
        public string Obs { get; set; }
        public decimal? VlIpi { get; set; }
        public int CdSituacao { get; set; }
        public bool FlAgrupado { get; set; }
        public bool FlCancelado { get; set; }
        public bool FlFinalizado { get; set; }
        public DateTime? DtEntrega { get; set; }
        public int? NrPreVenda { get; set; }
        public int? CdFrenteCaixa { get; set; }
        public string FlDavImpresso { get; set; }
        public int? IdEndEntrega { get; set; }
        public string HashOrcamentoCD2 { get; set; }
        public string HashOrcamentoCD3 { get; set; }
        public int? CdTabelaPreco { get; set; }
        public bool? FlExportaDavPdf { get; set; }
        public DateTime? DatahoraCancelamento { get; set; }
        public int? UsuarioCancelamento { get; set; }
        public decimal? VlIcmsst { get; set; }
        public string FlEnviaPaf { get; set; }

        public FrenteCaixa CdFrenteCaixaNavigation { get; set; }
        public Situacao CdSituacaoNavigation { get; set; }
        public TabelaPreco CdTabelaPrecoNavigation { get; set; }
        public Usuario UsuarioCancelamentoNavigation { get; set; }
        public ICollection<ApontamentoDeServico> ApontamentoDeServico { get; set; }
        public ICollection<AuditorEstoqueC> AuditorEstoqueC { get; set; }
        public ICollection<OrcamentoContato> OrcamentoContato { get; set; }
    }
}
