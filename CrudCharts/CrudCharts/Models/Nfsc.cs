using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class Nfsc
    {
        public Nfsc()
        {
            NfcFrete = new HashSet<NfcFrete>();
            NfscMensagem = new HashSet<NfscMensagem>();
            Nfsi = new HashSet<Nfsi>();
            VeiculoDespesas = new HashSet<VeiculoDespesas>();
        }

        public int CdFilial { get; set; }
        public int NrDocumento { get; set; }
        public int? NrNf { get; set; }
        public int? NrCupom { get; set; }
        public string PlacaVeiculo { get; set; }
        public int? Kilometragem { get; set; }
        public int CdClifor { get; set; }
        public int? CdOperacao { get; set; }
        public DateTime DtEmissao { get; set; }
        public decimal? VlAcrescimos { get; set; }
        public decimal? VlDescontos { get; set; }
        public decimal? VlMercadorias { get; set; }
        public decimal? VlServicos { get; set; }
        public decimal? VlTotal { get; set; }
        public int? CdCondpgto { get; set; }
        public decimal? VlEntrada { get; set; }
        public decimal? VlAcresFinanceiro { get; set; }
        public decimal? VlFinanciado { get; set; }
        public int CdCancelamento { get; set; }
        public double? PesoTotal { get; set; }
        public double? QtPecas { get; set; }
        public string Obs { get; set; }
        public int? NrEcf { get; set; }
        public string CdNatoper { get; set; }
        public string FlContNcont { get; set; }
        public int? CdTransportadora { get; set; }
        public DateTime DtLancamento { get; set; }
        public DateTime DtSaida { get; set; }
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
        public int CdUsuario { get; set; }
        public decimal? VlBaseComissao { get; set; }
        public decimal? VlComissao { get; set; }
        public string FlPagoFrete { get; set; }
        public string FlEmprsimples { get; set; }
        public string FlClisimples { get; set; }
        public int? NrOsOri { get; set; }
        public DateTime? DtAtz { get; set; }
        public decimal? VlOutros { get; set; }
        public string UfPlacaTansp { get; set; }
        public string PlacaTransp { get; set; }
        public string FlControlarEstoque { get; set; }
        public long? NrSr { get; set; }
        public string FlCdConta { get; set; }
        public string FlIgnorarCxaCta { get; set; }
        public string FlIssRetido { get; set; }
        public decimal? VlIssSubst { get; set; }
        public int? NrSequencial { get; set; }
        public bool FlTransferencia { get; set; }
        public string TotalCst { get; set; }
        public double? AliqIcmFrete { get; set; }
        public int? CdImpfiscal { get; set; }
        public string SerieNfs { get; set; }
        public string Nsu { get; set; }
        public decimal? BaseIcmProprioSt { get; set; }
        public decimal? VlIcmProprioSt { get; set; }
        public decimal? VlBasePis { get; set; }
        public decimal? VlPis { get; set; }
        public decimal? VlBaseCofins { get; set; }
        public decimal? VlCofins { get; set; }
        public decimal? VlBaseIpi { get; set; }
        public decimal? VlBaseIss { get; set; }
        public decimal? VlDescontoItem { get; set; }
        public decimal? VlIsentoItens { get; set; }
        public decimal? VlOutrosItens { get; set; }
        public string Obs2 { get; set; }
        public string FlComplementoIcms { get; set; }
        public decimal? AlicIcmSimples { get; set; }
        public decimal? VlBaseIcmSimples { get; set; }
        public decimal? VlIcmSimples { get; set; }
        public string NrProtocoloNfe { get; set; }
        public DateTime? DtProcessamentoNfe { get; set; }
        public int? Status { get; set; }
        public string NrLoteNfe { get; set; }
        public string NrReciboNfe { get; set; }
        public string NrProtocoloCancNfe { get; set; }
        public string ChaveAcessoNfe { get; set; }
        public int? EcfCoo { get; set; }
        public string EcfMfAdicional { get; set; }
        public TimeSpan? HrEmissao { get; set; }
        public int? IdEndEntrega { get; set; }
        public string CdModelo { get; set; }
        public int? IdNfecDevolucao { get; set; }
        public string FlConsumo { get; set; }
        public decimal? VlIcmFrete { get; set; }
        public string CfopFrete { get; set; }
        public string NrAidf { get; set; }
        public decimal? ConhecimentoVlFrete { get; set; }
        public decimal? VlBaseIcmSubstAnt { get; set; }
        public decimal? VlIcmSubstAnt { get; set; }
        public TimeSpan? HrProcessamentoNfe { get; set; }
        public string DpecId { get; set; }
        public string DpecNrRegistro { get; set; }
        public DateTime? DpecDtRegistro { get; set; }
        public TimeSpan? DpecHrRegistro { get; set; }
        public string CdBarrasAdicionalNfe { get; set; }
        public int? TpEmissaoNfe { get; set; }
        public int? CdCidadeEmbarque { get; set; }
        public string HashNfscR4 { get; set; }
        public string HashNfscR5 { get; set; }
        public string HashNfscR7 { get; set; }
        public int? CdTabelaPreco { get; set; }
        public decimal? VlIcmSubstDev { get; set; }
        public decimal? VlBaseIcmSubstDev { get; set; }
        public decimal? VlBaseIpiDev { get; set; }
        public decimal? VlIpiDev { get; set; }
        public string UrlServico { get; set; }
        public int? NrRps { get; set; }
        public decimal? VlBaseCsll { get; set; }
        public decimal? VlCsll { get; set; }
        public decimal? VlBaseIr { get; set; }
        public decimal? VlIr { get; set; }
        public decimal? VlTribNacional { get; set; }
        public decimal? VlTribImportado { get; set; }
        public decimal? VlTribEstadual { get; set; }
        public decimal? VlTribMunicipal { get; set; }
        public string RecintoAlfandegado { get; set; }
        public decimal? VlBaseInss { get; set; }
        public decimal? VlInss { get; set; }
        public decimal? VlFcp { get; set; }
        public decimal? VlFcpSt { get; set; }
        public decimal? VlFcpStRetido { get; set; }
        public decimal? VlIcmsUfDest { get; set; }
        public decimal? VlIcmsUfRemet { get; set; }
        public decimal? VlFcpUfDest { get; set; }

        public Cliente Cd { get; set; }
        public Impfiscal CdImpfiscalNavigation { get; set; }
        public ModeloDcto CdModeloNavigation { get; set; }
        public TabelaPreco CdTabelaPrecoNavigation { get; set; }
        public Nfec IdNfecDevolucaoNavigation { get; set; }
        public ICollection<NfcFrete> NfcFrete { get; set; }
        public ICollection<NfscMensagem> NfscMensagem { get; set; }
        public ICollection<Nfsi> Nfsi { get; set; }
        public ICollection<VeiculoDespesas> VeiculoDespesas { get; set; }
    }
}
