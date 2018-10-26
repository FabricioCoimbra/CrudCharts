using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class Nfec
    {
        public Nfec()
        {
            ComissaoFuncDev = new HashSet<ComissaoFuncDev>();
            NfcFreteIdFreteNavigation = new HashSet<NfcFrete>();
            NfcFreteIdNfecNavigation = new HashSet<NfcFrete>();
            NfecImportacao = new HashSet<NfecImportacao>();
            NfecMensagem = new HashSet<NfecMensagem>();
            Nfei = new HashSet<Nfei>();
            Nfsc = new HashSet<Nfsc>();
            OrcamentoNfe = new HashSet<OrcamentoNfe>();
            ProdutoLote = new HashSet<ProdutoLote>();
        }

        public int CdFilial { get; set; }
        public long NrDcto { get; set; }
        public int CdClifor { get; set; }
        public bool? FlImpresso { get; set; }
        public string SerieNf { get; set; }
        public int? CdOperacao { get; set; }
        public DateTime DtEmissao { get; set; }
        public DateTime DtLancamento { get; set; }
        public decimal? VlAcrescimos { get; set; }
        public decimal? VlDescontos { get; set; }
        public decimal? VlMercadorias { get; set; }
        public decimal? VlServicos { get; set; }
        public decimal? VlTotal { get; set; }
        public int? CdCondpgto { get; set; }
        public decimal? VlEntrada { get; set; }
        public decimal? VlAcresFinanceiro { get; set; }
        public decimal? VlFinanciado { get; set; }
        public double? PesoTotal { get; set; }
        public double? QtPecas { get; set; }
        public string Obs { get; set; }
        public string CdNatoper { get; set; }
        public string FlContNcont { get; set; }
        public int? CdTransportadora { get; set; }
        public string UfOrigem { get; set; }
        public string UfDestino { get; set; }
        public double? PesoLiquido { get; set; }
        public decimal? VlFrete { get; set; }
        public decimal? VlSeguro { get; set; }
        public decimal? VlBaseIcm { get; set; }
        public decimal? VlIcm { get; set; }
        public decimal? VlBaseIcmSubst { get; set; }
        public decimal? VlIcmSubst { get; set; }
        public decimal? VlIpi { get; set; }
        public decimal? VlIss { get; set; }
        public string TpFrete { get; set; }
        public double? QtVolumes { get; set; }
        public string EspecieVolumes { get; set; }
        public string MarcaVolumes { get; set; }
        public double? NrVolumes { get; set; }
        public int CdBanco { get; set; }
        public int CdTipocobr { get; set; }
        public int CdConta { get; set; }
        public int CdFuncionario { get; set; }
        public DateTime? DtAtz { get; set; }
        public string PlacaTransp { get; set; }
        public string UfPlacaTransp { get; set; }
        public decimal? VlOutros { get; set; }
        public string FlCdConta { get; set; }
        public string FlIgnorarCxaCta { get; set; }
        public bool FlTransferencia { get; set; }
        public int? NrPedido { get; set; }
        public string FlControlarEstoque { get; set; }
        public string Nsu { get; set; }
        public int? NrDctoDevolucao { get; set; }
        public decimal? VlBasePis { get; set; }
        public decimal? VlPis { get; set; }
        public decimal? VlBaseCofins { get; set; }
        public decimal? VlCofins { get; set; }
        public decimal? VlBaseIpi { get; set; }
        public decimal? VlBaseIss { get; set; }
        public decimal? VlDescontoItem { get; set; }
        public decimal? VlIsentoItens { get; set; }
        public decimal? VlOutrosItens { get; set; }
        public string NrProtocoloNfe { get; set; }
        public DateTime? DtProcessamentoNfe { get; set; }
        public int? Status { get; set; }
        public string NrLoteNfe { get; set; }
        public string NrReciboNfe { get; set; }
        public string NrProtocoloCancNfe { get; set; }
        public string ChaveAcessoNfe { get; set; }
        public string Obs2 { get; set; }
        public decimal? ConhecimentoVlFrete { get; set; }
        public decimal? ConhecimentoVlSt { get; set; }
        public decimal? ConhecimentoVlIcm { get; set; }
        public decimal? BaseIcmProprioSt { get; set; }
        public decimal? VlIcmProprioSt { get; set; }
        public decimal? VlBaseIcmSubstReal { get; set; }
        public decimal? VlIcmSubstReal { get; set; }
        public string FlCalcularCusto { get; set; }
        public string CdModelo { get; set; }
        public int IdGeral { get; set; }
        public decimal? ConhecimentoBaseIcm { get; set; }
        public decimal? ConhecimentoBaseSt { get; set; }
        public string FlConsumo { get; set; }
        public decimal? VlIcmFrete { get; set; }
        public string CfopFrete { get; set; }
        public string SubSerie { get; set; }
        public string NrAidf { get; set; }
        public bool? FlConhecFrete { get; set; }
        public decimal? VlBaseIcmSubstAnt { get; set; }
        public decimal? VlIcmSubstAnt { get; set; }
        public TimeSpan? HrEmissao { get; set; }
        public int? CupomNrPdv { get; set; }
        public int? CupomNrCoo { get; set; }
        public string FlSimples { get; set; }
        public TimeSpan? HrProcessamentoNfe { get; set; }
        public string DpecId { get; set; }
        public string DpecNrRegistro { get; set; }
        public DateTime? DpecDtRegistro { get; set; }
        public TimeSpan? DpecHrRegistro { get; set; }
        public string CdBarrasAdicionalNfe { get; set; }
        public int? TpEmissaoNfe { get; set; }
        public decimal? VlIcmSubstDev { get; set; }
        public decimal? VlBaseIcmSubstDev { get; set; }
        public decimal? VlBaseIpiDev { get; set; }
        public decimal? VlIpiDev { get; set; }
        public decimal? VlFcp { get; set; }
        public decimal? VlFcpSt { get; set; }
        public decimal? VlFcpStRetido { get; set; }
        public decimal? VlIcmsUfDest { get; set; }
        public decimal? VlIcmsUfRemet { get; set; }
        public decimal? VlFcpUfDest { get; set; }

        public CxaConta CdContaNavigation { get; set; }
        public PedidoC NrPedidoNavigation { get; set; }
        public NfecConhecimento NfecConhecimento { get; set; }
        public NfecEnergiaEletrica NfecEnergiaEletrica { get; set; }
        public ICollection<ComissaoFuncDev> ComissaoFuncDev { get; set; }
        public ICollection<NfcFrete> NfcFreteIdFreteNavigation { get; set; }
        public ICollection<NfcFrete> NfcFreteIdNfecNavigation { get; set; }
        public ICollection<NfecImportacao> NfecImportacao { get; set; }
        public ICollection<NfecMensagem> NfecMensagem { get; set; }
        public ICollection<Nfei> Nfei { get; set; }
        public ICollection<Nfsc> Nfsc { get; set; }
        public ICollection<OrcamentoNfe> OrcamentoNfe { get; set; }
        public ICollection<ProdutoLote> ProdutoLote { get; set; }
    }
}
