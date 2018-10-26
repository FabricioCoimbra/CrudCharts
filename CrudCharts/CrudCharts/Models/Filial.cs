using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class Filial
    {
        public Filial()
        {
            Cargo = new HashSet<Cargo>();
            Cliente = new HashSet<Cliente>();
            CobRetorno = new HashSet<CobRetorno>();
            Comissao = new HashSet<Comissao>();
            ConfSpedPisCofins = new HashSet<ConfSpedPisCofins>();
            DocProducao = new HashSet<DocProducao>();
            FilialEmail = new HashSet<FilialEmail>();
            FilialIeSt = new HashSet<FilialIeSt>();
            Fornveic = new HashSet<Fornveic>();
            LctoFlex = new HashSet<LctoFlex>();
            Mdfe = new HashSet<Mdfe>();
            MdfeCondutor = new HashSet<MdfeCondutor>();
            MdfeDocumento = new HashSet<MdfeDocumento>();
            MdfeEvento = new HashSet<MdfeEvento>();
            MdfePercurso = new HashSet<MdfePercurso>();
        }

        public int CdFilial { get; set; }
        public string NmFilial { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public string Cep { get; set; }
        public string Fone { get; set; }
        public string Fax { get; set; }
        public string Cgc { get; set; }
        public string Ie { get; set; }
        public int? NrUltNfs { get; set; }
        public bool? FlInformarNrNf { get; set; }
        public bool? FlValorSeguro { get; set; }
        public bool? FlValorFrete { get; set; }
        public bool? FlValorDesconto { get; set; }
        public bool? FlImprimirNfs { get; set; }
        public bool? FlControlarEstoq { get; set; }
        public bool? FlImprimeNf { get; set; }
        public decimal? PcPis { get; set; }
        public decimal? PcCofins { get; set; }
        public string Email { get; set; }
        public bool? FlCalculaComissao { get; set; }
        public bool? FlControleCredito { get; set; }
        public int? CdConta { get; set; }
        public int? CdClienteConsumidor { get; set; }
        public int? CdFilialFornecedor { get; set; }
        public string FlConsProd { get; set; }
        public string Im { get; set; }
        public string EmpresaSimples { get; set; }
        public string CustoEmOrcamento { get; set; }
        public decimal? TaxaJuros { get; set; }
        public DateTime? DtAtz { get; set; }
        public int? DiasVcto { get; set; }
        public string FlControleContas { get; set; }
        public string TpComissao { get; set; }
        public string FlComissaoVendabaixa { get; set; }
        public int? Modulo { get; set; }
        public int? CdUsrPadrao { get; set; }
        public int? CdClienteEmpresa { get; set; }
        public string FlOrcImpVendCliente { get; set; }
        public string FlAlteraVendOrc { get; set; }
        public string FlClienteCnpjDupl { get; set; }
        public string FlItemDuplNfs { get; set; }
        public string FlItemDuplNfe { get; set; }
        public string FlOrcProdSemVendedor { get; set; }
        public string FlOrcExibirUltVenda { get; set; }
        public int? VlIdGeral { get; set; }
        public string FlDeducaoPiscofins { get; set; }
        public string FlOrcServSemVendedor { get; set; }
        public decimal? AliqIcmsSimples { get; set; }
        public int? CdCidade { get; set; }
        public int? Numero { get; set; }
        public string Complemento { get; set; }
        public int? TpAmbienteNfe { get; set; }
        public string NotaEletronica { get; set; }
        public int? NrLoteNfe { get; set; }
        public string FlVendaVistaClienteBloq { get; set; }
        public string FlVendaPrazoClienteBloq { get; set; }
        public bool? FlDeducaoIcms { get; set; }
        public int? CdFornecedorImpostoSt { get; set; }
        public DateTime? DtUltimaIntegracao { get; set; }
        public bool? FlImprimirOrcEcf { get; set; }
        public bool? FlUtilizaContaContabil { get; set; }
        public int? TpSistema { get; set; }
        public bool? FlIndustria { get; set; }
        public string IndPerfilSped { get; set; }
        public string Suframa { get; set; }
        public string NmFantasia { get; set; }
        public int? IndApurIpi { get; set; }
        public string NrSerieProducao { get; set; }
        public int? CdOpEntradaProducao { get; set; }
        public int? CdOpSaidaProducao { get; set; }
        public string FlFitossanitarioSira { get; set; }
        public bool? FlUtilizaPaf { get; set; }
        public char? FlArmazInterfoc { get; set; }
        public string FlContribuinte { get; set; }
        public int? CdMensagemCupom { get; set; }
        public int? CdMensagemDav { get; set; }
        public int? CdMensagemPreVenda { get; set; }
        public string FlCustoFreteSt { get; set; }
        public string FlOrcExibirVlCompra { get; set; }
        public int? CdTransportadora { get; set; }
        public int? CdMensagemIcmRetAnt { get; set; }
        public int? TpStatusNfe { get; set; }
        public string FlSimplesExcessoReceita { get; set; }
        public int? CdCrt { get; set; }
        public int? CdMensagemSimples { get; set; }
        public string CnaeFiscal { get; set; }
        public string NfeConjugada { get; set; }
        public int? CdMensagemTotTrib { get; set; }
        public char? FlUtilizaIntegracao { get; set; }
        public decimal? VlMultaContas { get; set; }
        public int? CdMensagemIcmStNotaDev { get; set; }
        public short? CdCtblExporta { get; set; }
        public char FlApenasVendedorDoc { get; set; }
        public char? FlRealPresumido { get; set; }
        public DateTime? DtAtzEstoque { get; set; }
        public TimeSpan? HrAtzEstoque { get; set; }
        public int? CdImpfiscalAtzEstoque { get; set; }
        public string HashFilialE1 { get; set; }
        public string HashFilialR1 { get; set; }
        public string FlRedeUniagro { get; set; }
        public string FlVendaOutrosUf { get; set; }
        public string FlFlex { get; set; }
        public string FlPosVenda { get; set; }
        public string TpCliPadraoVenda { get; set; }
        public string FlConheFreteSt { get; set; }
        public string FlStNotaEsta { get; set; }
        public int? CdTabelaPrecoPadrao { get; set; }
        public int? CdMensagemIpiNotaDev { get; set; }
        public char? FlNotaEletronicaMunicipal { get; set; }
        public char? TpAmbienteNfeMunicipal { get; set; }
        public char? FlContigenciaMunicipal { get; set; }
        public bool? FlImprimeOrdemEntrega { get; set; }
        public int? CdMensagemDescontoRo { get; set; }
        public string CodVersaoEfd { get; set; }
        public bool? FlCalculaPrazoDataSaida { get; set; }
        public bool? FlAdicionaStCustoProduto { get; set; }
        public bool? FlImprimeCarneEcf { get; set; }
        public string DirArqCarneEcf { get; set; }
        public string DirArqComprovanteEcf { get; set; }
        public string FlImpVendedorClienteNfsc { get; set; }
        public string FlMultaPorcentagem { get; set; }
        public string FusoHorario { get; set; }
        public string FlBloqCancelamentoEcf { get; set; }
        public string FlCalculaDiferencaIcms { get; set; }
        public string FlFilialTitCartao { get; set; }
        public char? FlImportarVendedorPrimeiro { get; set; }
        public char? FlImportarVendedorSegundo { get; set; }
        public char? FlImportarVendedorTerceiro { get; set; }
        public char? BloquearEdicaoJurosMulta { get; set; }
        public char? DatabaseAuditor { get; set; }
        public string FlUtilizaNfce { get; set; }
        public bool? CfInformaDocumento { get; set; }
        public string TpIcmsEntradaFrete { get; set; }
        public string TpPiscofinsEntradaFrete { get; set; }
        public string TpIcmsSaidaFrete { get; set; }
        public string TpPiscofinsSaidaFrete { get; set; }
        public string CdProdfreteVenda { get; set; }
        public string CdProdfreteVendasC { get; set; }
        public string CdProdfreteSaida { get; set; }
        public string CdProdfreteSaidasC { get; set; }
        public string CdProdfreteCompra { get; set; }
        public string CdProdfreteComprasC { get; set; }
        public string CdProdfreteTrans { get; set; }
        public string CdProdfreteEntrada { get; set; }
        public string CdProdfreteEntradasC { get; set; }
        public string CstFreteIcmscred { get; set; }
        public string CstFreteIcmsNcred { get; set; }
        public string FlManifestoEletronico { get; set; }
        public string FlSenhaSupervisorDav { get; set; }
        public string FlCodCliforDanfe { get; set; }
        public string FlSeguradora { get; set; }
        public decimal? VlMinInss { get; set; }
        public decimal? VlMinCsll { get; set; }
        public int? DiasJuro { get; set; }
        public int? DiasMulta { get; set; }
        public int? CdMensagemReducao { get; set; }
        public int? CdMensagemDifal { get; set; }
        public string FlOculista { get; set; }
        public string FlEnviaBlocox { get; set; }
        public bool? FlAlterarMarkupCadastro { get; set; }
        public bool? FlDescontoIncondicionado { get; set; }
        public bool? Calculoconveniost { get; set; }
        public int? CdMensagemFcp { get; set; }

        public CxaConta CdContaNavigation { get; set; }
        public MensagemNota CdMensagemCupomNavigation { get; set; }
        public MensagemNota CdMensagemDavNavigation { get; set; }
        public MensagemNota CdMensagemIcmStNotaDevNavigation { get; set; }
        public MensagemNota CdMensagemPreVendaNavigation { get; set; }
        public TabelaPreco CdTabelaPrecoPadraoNavigation { get; set; }
        public ICollection<Cargo> Cargo { get; set; }
        public ICollection<Cliente> Cliente { get; set; }
        public ICollection<CobRetorno> CobRetorno { get; set; }
        public ICollection<Comissao> Comissao { get; set; }
        public ICollection<ConfSpedPisCofins> ConfSpedPisCofins { get; set; }
        public ICollection<DocProducao> DocProducao { get; set; }
        public ICollection<FilialEmail> FilialEmail { get; set; }
        public ICollection<FilialIeSt> FilialIeSt { get; set; }
        public ICollection<Fornveic> Fornveic { get; set; }
        public ICollection<LctoFlex> LctoFlex { get; set; }
        public ICollection<Mdfe> Mdfe { get; set; }
        public ICollection<MdfeCondutor> MdfeCondutor { get; set; }
        public ICollection<MdfeDocumento> MdfeDocumento { get; set; }
        public ICollection<MdfeEvento> MdfeEvento { get; set; }
        public ICollection<MdfePercurso> MdfePercurso { get; set; }
    }
}
