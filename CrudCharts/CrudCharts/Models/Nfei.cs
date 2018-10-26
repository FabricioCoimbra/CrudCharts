using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class Nfei
    {
        public Nfei()
        {
            Custcomp = new HashSet<Custcomp>();
            NfeiImportacao = new HashSet<NfeiImportacao>();
            ProdutoSerie = new HashSet<ProdutoSerie>();
            VeiculoDespesas = new HashSet<VeiculoDespesas>();
        }

        public int NrSequencia { get; set; }
        public string CdProdserv { get; set; }
        public string FlServico { get; set; }
        public double? QtProduto { get; set; }
        public decimal? VlBruto { get; set; }
        public decimal? VlTotal { get; set; }
        public DateTime DtLancamento { get; set; }
        public double? PesoLiquido { get; set; }
        public int? CdAtualizacao { get; set; }
        public string Cst { get; set; }
        public decimal? PcRedBaseIcm { get; set; }
        public decimal? AliqIcm { get; set; }
        public decimal? AliqIcmSubst { get; set; }
        public decimal? AliqIpi { get; set; }
        public decimal? AliqIss { get; set; }
        public decimal? VlBaseIcm { get; set; }
        public decimal? VlIcm { get; set; }
        public decimal? VlIcmSubst { get; set; }
        public decimal? VlIpi { get; set; }
        public decimal? VlIss { get; set; }
        public string Compl { get; set; }
        public string NmProduto { get; set; }
        public DateTime? DtAtz { get; set; }
        public string UnMedida { get; set; }
        public decimal? PcDesconto { get; set; }
        public decimal? VlBaseIcmSubst { get; set; }
        public int? CdConta { get; set; }
        public double? FatorConversao { get; set; }
        public string FlControlarEstoque { get; set; }
        public decimal? PcMarkup { get; set; }
        public string Cfop { get; set; }
        public decimal? VlDesconto { get; set; }
        public decimal? VlDescontoRateado { get; set; }
        public decimal? VlAcrescimoRateado { get; set; }
        public decimal? VlFreteRateado { get; set; }
        public decimal? VlSeguroRateado { get; set; }
        public decimal? VlContabil { get; set; }
        public decimal? VlOutros { get; set; }
        public decimal? VlIsento { get; set; }
        public decimal? AliqPis { get; set; }
        public decimal? VlBasePis { get; set; }
        public decimal? VlPis { get; set; }
        public decimal? AliqCofins { get; set; }
        public decimal? VlBaseCofins { get; set; }
        public decimal? VlCofins { get; set; }
        public decimal? VlBaseIss { get; set; }
        public decimal? VlBaseIpi { get; set; }
        public decimal? AliqIcmProprioSt { get; set; }
        public decimal? VlBaseIcmProprioSt { get; set; }
        public decimal? VlIcmProprioSt { get; set; }
        public decimal? AliqIcmSubstReal { get; set; }
        public decimal? VlBaseIcmSubstReal { get; set; }
        public decimal? VlIcmSubstReal { get; set; }
        public decimal? AliqUfDestino { get; set; }
        public decimal? PcRedBaseIcmSubst { get; set; }
        public decimal? PcRedBaseIcmProprioSt { get; set; }
        public double? QtCompra { get; set; }
        public string UnCompra { get; set; }
        public decimal? VlUnitario { get; set; }
        public decimal? VlUnitarioCompra { get; set; }
        public string CstIpi { get; set; }
        public string CstPis { get; set; }
        public string CstCofins { get; set; }
        public int IdGeral { get; set; }
        public int? IdNfec { get; set; }
        public decimal? ConhecimentoVlFrete { get; set; }
        public decimal? ConhecimentoBaseIcm { get; set; }
        public decimal? ConhecimentoVlIcm { get; set; }
        public decimal? ConhecimentoBaseSt { get; set; }
        public decimal? ConhecimentoVlSt { get; set; }
        public decimal? VlIcmFrete { get; set; }
        public string CstOri { get; set; }
        public double? AliqIcmOri { get; set; }
        public double? PcRedBaseIcmOri { get; set; }
        public decimal? VlBaseIcmOri { get; set; }
        public decimal? VlIcmOri { get; set; }
        public double? AliqIcmProprioStOri { get; set; }
        public double? PcRedBaseIcmProprioStOri { get; set; }
        public decimal? VlBaseIcmProprioStOri { get; set; }
        public decimal? VlIcmProprioStOri { get; set; }
        public double? MvaOri { get; set; }
        public double? AliqIcmSubstOri { get; set; }
        public double? PcRedBaseIcmSubstOri { get; set; }
        public decimal? VlBaseIcmSubstOri { get; set; }
        public decimal? VlIcmSubstOri { get; set; }
        public string CfopOri { get; set; }
        public decimal? VlBaseIcmSubstAnt { get; set; }
        public decimal? VlIcmSubstAnt { get; set; }
        public string FlSomaTotal { get; set; }
        public char? FlValidado { get; set; }
        public string ClassificacaoCtbl { get; set; }
        public decimal? VlOutrasDespesas { get; set; }
        public decimal? VlIcmSubstDev { get; set; }
        public decimal? VlBaseIcmSubstDev { get; set; }
        public decimal? AlicIcmSubstDev { get; set; }
        public decimal? PcRedBaseIcmSubstDev { get; set; }
        public decimal? VlBaseIpiDev { get; set; }
        public decimal? VlIpiDev { get; set; }
        public decimal? AlicIpiDev { get; set; }
        public decimal? MvaDev { get; set; }
        public decimal? IcmsNormalDifPcAliq { get; set; }
        public decimal? IcmsNormalDifVlBase { get; set; }
        public decimal? IcmsNormalDifValor { get; set; }
        public int? NaturezaFrete { get; set; }
        public int? NrSequenciaDev { get; set; }
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
        public Produto CdProdservNavigation { get; set; }
        public Nfec IdNfecNavigation { get; set; }
        public Nfeicomplemento Nfeicomplemento { get; set; }
        public ICollection<Custcomp> Custcomp { get; set; }
        public ICollection<NfeiImportacao> NfeiImportacao { get; set; }
        public ICollection<ProdutoSerie> ProdutoSerie { get; set; }
        public ICollection<VeiculoDespesas> VeiculoDespesas { get; set; }
    }
}
