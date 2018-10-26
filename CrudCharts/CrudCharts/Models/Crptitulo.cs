using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class Crptitulo
    {
        public Crptitulo()
        {
            CrptituloMovimentoCxa = new HashSet<CrptituloMovimentoCxa>();
        }

        public int CdFilial { get; set; }
        public int CdTipoConta { get; set; }
        public int CdClifor { get; set; }
        public string NrTitulo { get; set; }
        public int Parcela { get; set; }
        public DateTime DtEmissao { get; set; }
        public DateTime DtInclusao { get; set; }
        public DateTime DtVctoOri { get; set; }
        public DateTime DtVcto { get; set; }
        public DateTime? DtUltPgto { get; set; }
        public int CdBancoOri { get; set; }
        public int CdBanco { get; set; }
        public int CdTipocobrOri { get; set; }
        public int CdTipocobr { get; set; }
        public int CdVendedor { get; set; }
        public string FlPrevRealizado { get; set; }
        public decimal? VlComissao { get; set; }
        public decimal? VlNominal { get; set; }
        public decimal? VlJuros { get; set; }
        public decimal? VlBaixasNominal { get; set; }
        public decimal? VlDescontos { get; set; }
        public decimal? VlSaldo { get; set; }
        public int CdCaixa { get; set; }
        public DateTime? DtAtz { get; set; }
        public long? NrNfEcf { get; set; }
        public int PrazoParcela { get; set; }
        public decimal? PcParcela { get; set; }
        public int? CdConta { get; set; }
        public decimal? VlAcrescimo { get; set; }
        public string FlReparcelado { get; set; }
        public int? NrDocumento { get; set; }
        public string Obs { get; set; }
        public int? NrSequencial { get; set; }
        public double? PcParcelaTotal { get; set; }
        public string MotivoAlteracao { get; set; }
        public string NrTituloReparcelado { get; set; }
        public string NrSe { get; set; }
        public decimal? VlMulta { get; set; }
        public string FlImprimeCarne { get; set; }
        public string FlImprimeComprovante { get; set; }
        public int? CdFrenteCaixaCarne { get; set; }
        public decimal? VlDevolucoes { get; set; }
        public string MotivoAlteracaoValor { get; set; }
        public int? CdFuncionario { get; set; }

        public CxaConta CdContaNavigation { get; set; }
        public ICollection<CrptituloMovimentoCxa> CrptituloMovimentoCxa { get; set; }
    }
}
