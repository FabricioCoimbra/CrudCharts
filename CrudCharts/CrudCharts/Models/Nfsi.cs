using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class Nfsi
    {
        public Nfsi()
        {
            LctoFlex = new HashSet<LctoFlex>();
        }

        public int CdFilial { get; set; }
        public int NrDocumento { get; set; }
        public int NrSequencia { get; set; }
        public string CdProdserv { get; set; }
        public string NmProdserv { get; set; }
        public string FlServico { get; set; }
        public double? QtProduto { get; set; }
        public decimal? VlBruto { get; set; }
        public decimal? PcDesconto { get; set; }
        public decimal? VlLiquido { get; set; }
        public decimal? VlTotal { get; set; }
        public decimal? PrecoMinimo { get; set; }
        public int CdFuncionario { get; set; }
        public DateTime DtEmissao { get; set; }
        public double? PesoLiquido { get; set; }
        public int? CdCancelamento { get; set; }
        public string Cst { get; set; }
        public decimal? PcRedBaseIcm { get; set; }
        public decimal? AlicIcm { get; set; }
        public decimal? AlicIcmSubst { get; set; }
        public decimal? AlicIpi { get; set; }
        public decimal? AlicIss { get; set; }
        public decimal? VlBaseIcm { get; set; }
        public decimal? VlIcm { get; set; }
        public decimal? VlIcmSubst { get; set; }
        public decimal? VlIpi { get; set; }
        public decimal? VlIss { get; set; }
        public string FlTributacaoInf { get; set; }
        public decimal? VlBaseComissao { get; set; }
        public decimal? VlComissao { get; set; }
        public decimal? PcComissao { get; set; }
        public string FlComissaoInf { get; set; }
        public string Compl { get; set; }
        public DateTime? DtAtz { get; set; }
        public string Un { get; set; }
        public string FlControlarEstoque { get; set; }
        public string PlacaVeiculo { get; set; }
        public int? Kilometragem { get; set; }
        public string FlClassfiscal { get; set; }
        public int? CdConta { get; set; }
        public decimal? VlIssSubst { get; set; }
        public string FlComposto { get; set; }
        public string Composicao { get; set; }
        public decimal? VlBaseIcmSubst { get; set; }
        public decimal? VlFreteRateado { get; set; }
        public decimal? AlicUfDestino { get; set; }
        public string Cfop { get; set; }
        public decimal? VlDesconto { get; set; }
        public decimal? VlDescontoRateado { get; set; }
        public decimal? VlAcrescimoRateado { get; set; }
        public decimal? VlSeguroRateado { get; set; }
        public decimal? VlContabil { get; set; }
        public decimal? VlOutros { get; set; }
        public decimal? VlIsento { get; set; }
        public decimal? AlicPis { get; set; }
        public decimal? VlBasePis { get; set; }
        public decimal? VlPis { get; set; }
        public decimal? AlicCofins { get; set; }
        public decimal? VlBaseCofins { get; set; }
        public decimal? VlCofins { get; set; }
        public decimal? VlBaseIss { get; set; }
        public decimal? VlBaseIpi { get; set; }
        public string Iat { get; set; }
        public decimal? PcAcrescimo { get; set; }
        public decimal? PcRedBaseIcmProprioSt { get; set; }
        public decimal? PcRedBaseIcmSubst { get; set; }
        public decimal? AlicIcmProprioSt { get; set; }
        public decimal? VlBaseIcmProprioSt { get; set; }
        public decimal? VlIcmProprioSt { get; set; }
        public decimal? VlAcrescimo { get; set; }
        public double? FatorConversao { get; set; }
        public double? QtVenda { get; set; }
        public string UnVenda { get; set; }
        public decimal? VlLiquidoVenda { get; set; }
        public string CstIpi { get; set; }
        public string CstPis { get; set; }
        public string CstCofins { get; set; }
        public int? TpOperacaoVeicNovo { get; set; }
        public decimal? VlIcmFrete { get; set; }
        public decimal? ConhecimentoVlFrete { get; set; }
        public decimal? VlBaseIcmSubstAnt { get; set; }
        public decimal? VlIcmSubstAnt { get; set; }
        public int? NrSequenciaOsOri { get; set; }
        public string FlSomaTotal { get; set; }
        public string HashNfsiR5 { get; set; }
        public decimal? VlIcmSubstDev { get; set; }
        public decimal? VlBaseIcmSubstDev { get; set; }
        public decimal? AlicIcmSubstDev { get; set; }
        public decimal? PcRedBaseIcmSubstDev { get; set; }
        public decimal? VlBaseIpiDev { get; set; }
        public decimal? VlIpiDev { get; set; }
        public decimal? AlicIpiDev { get; set; }
        public decimal? MvaDev { get; set; }
        public string CdFci { get; set; }
        public decimal? AlicCsll { get; set; }
        public decimal? AlicIrrf { get; set; }
        public decimal? VlBaseCsll { get; set; }
        public decimal? VlCsll { get; set; }
        public decimal? VlBaseIr { get; set; }
        public decimal? VlIr { get; set; }
        public decimal? VlTribNacional { get; set; }
        public decimal? VlTribImportado { get; set; }
        public decimal? VlTribEstadual { get; set; }
        public decimal? VlTribMunicipal { get; set; }
        public decimal? VlBaseInss { get; set; }
        public decimal? VlInss { get; set; }
        public int? NrSequenciaDev { get; set; }
        public string NmCest { get; set; }
        public string NmClassFiscal { get; set; }
        public string CdPedComp { get; set; }
        public int? NrItemPedComp { get; set; }
        public string UnTrib { get; set; }
        public decimal? VlTrib { get; set; }
        public double? QtTrib { get; set; }
        public decimal? PcFcp { get; set; }
        public decimal? VlFcp { get; set; }
        public decimal? VlBaseFcp { get; set; }
        public decimal? VlBaseFcpSt { get; set; }
        public decimal? PcFcpSt { get; set; }
        public decimal? VlFcpSt { get; set; }
        public decimal? VlFcpStRetido { get; set; }
        public decimal? PcFcpStRetido { get; set; }
        public decimal? VlBaseFcpStRetido { get; set; }
        public decimal? VlBaseFcpUfDestino { get; set; }
        public decimal? PcFcpUfDestino { get; set; }
        public decimal? VlFcpUfDestino { get; set; }
        public decimal? VlBaseUfDestino { get; set; }
        public decimal? PcIcmsUfDestino { get; set; }
        public decimal? PcIcmsInterno { get; set; }
        public decimal? PcIcmsInternoPartilha { get; set; }
        public decimal? VlIcmsUfDestino { get; set; }
        public decimal? VlIcmsUfRemetente { get; set; }

        public CxaConta CdContaNavigation { get; set; }
        public Nfsc Nfsc { get; set; }
        public NfsiCupom NfsiCupom { get; set; }
        public ICollection<LctoFlex> LctoFlex { get; set; }
    }
}
