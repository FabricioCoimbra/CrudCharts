using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class Produto
    {
        public Produto()
        {
            Custcomp = new HashSet<Custcomp>();
            Estoque = new HashSet<Estoque>();
            Nfei = new HashSet<Nfei>();
            OrcamentoI = new HashSet<OrcamentoI>();
            OrdemProducaoI = new HashSet<OrdemProducaoI>();
            ProdComposto = new HashSet<ProdComposto>();
            ProdutoCliente = new HashSet<ProdutoCliente>();
            ProdutoLote = new HashSet<ProdutoLote>();
            ProdutoSerie = new HashSet<ProdutoSerie>();
            ProdutoVeiculo = new HashSet<ProdutoVeiculo>();
            Veiprod = new HashSet<Veiprod>();
        }

        public string CdProduto { get; set; }
        public string NmProduto { get; set; }
        public bool? FlAtivo { get; set; }
        public int CdGruprod { get; set; }
        public int CdMarca { get; set; }
        public string Box { get; set; }
        public string UnMedida { get; set; }
        public double? PesoLiquido { get; set; }
        public string CdOriginal { get; set; }
        public double? QtEstoqueMin { get; set; }
        public double? QtEstoqueMax { get; set; }
        public decimal? PcLucroLiquido { get; set; }
        public int? MesesGarantia { get; set; }
        public int? MesesVidaUtil { get; set; }
        public double? QtVendaMediaMes { get; set; }
        public double? QtEstoqueMedioMes { get; set; }
        public double? QtCompraMediaMes { get; set; }
        public double? GiroMedioEmDias { get; set; }
        public decimal? AliqIpi { get; set; }
        public string Obs { get; set; }
        public bool? FlOriginal { get; set; }
        public bool? FlInfComplemento { get; set; }
        public bool? FlControlarEstoq { get; set; }
        public string Tipo { get; set; }
        public int? CdSubgruprod { get; set; }
        public decimal? PcPrecoVenda { get; set; }
        public decimal? AliqIss { get; set; }
        public string FlServico { get; set; }
        public string FlComposto { get; set; }
        public string LocalEstocagem { get; set; }
        public double? QtEstoque { get; set; }
        public decimal? PcComissao { get; set; }
        public int? CdAplicacao { get; set; }
        public int? CdConstrucao { get; set; }
        public int? CdModelo { get; set; }
        public int? CdMedida { get; set; }
        public DateTime? DtAtz { get; set; }
        public string FlClassfiscal { get; set; }
        public int? CdGrupoComissao { get; set; }
        public int? GarantiaKm { get; set; }
        public string NmReduzido { get; set; }
        public bool? FlValidade { get; set; }
        public int? QtDiasValidade { get; set; }
        public int? DiasManPrev { get; set; }
        public bool FlContrato { get; set; }
        public string CdFabricante { get; set; }
        public bool? FlControlaSerie { get; set; }
        public string FlCompostoSomaItens { get; set; }
        public string CdClassFiscal { get; set; }
        public string ClassListaServico { get; set; }
        public bool? FlConsumo { get; set; }
        public bool? FlPesavel { get; set; }
        public string UnCompra { get; set; }
        public string UnArmazenagem { get; set; }
        public string TpProduto { get; set; }
        public DateTime? DtCadastro { get; set; }
        public string FlFitossanitarioSira { get; set; }
        public bool? FlControlaLote { get; set; }
        public int? IdTributacaoGrupo { get; set; }
        public int? CdContaContabil { get; set; }
        public char? FlFracionar { get; set; }
        public string CdTributacaoIss { get; set; }
        public string FlCestaBasica { get; set; }
        public int? IdTribGrupoPiscofins { get; set; }
        public double? QtEstoqueAnterior { get; set; }
        public string HashProdutoE2 { get; set; }
        public string HashProdutoP2 { get; set; }
        public int? CdCfopRegra { get; set; }
        public string CdProdutoAnp { get; set; }
        public string CdFci { get; set; }
        public int? CodigoTributacaoMunicipio { get; set; }
        public decimal? AliqIrrf { get; set; }
        public decimal? AliqCsll { get; set; }
        public bool? FlRetem { get; set; }
        public decimal? AliqInss { get; set; }
        public string CstInt { get; set; }
        public string CstExt { get; set; }
        public decimal? PcSubstTrib { get; set; }
        public string NmComercialFito { get; set; }
        public int? TpModalidadeFito { get; set; }
        public int? MetodoFito { get; set; }
        public string EpocaFito { get; set; }
        public int? IntervaloFito { get; set; }
        public int? TpIntervaloFito { get; set; }
        public int? ClassToxicoFito { get; set; }
        public string EpiFito { get; set; }
        public string EspecificacoesFito { get; set; }
        public string PrecaucoesFito { get; set; }
        public string CdProdutoAnvisa { get; set; }
        public char? FlEscalaRelevante { get; set; }
        public string CnpjFabricante { get; set; }
        public string NomeFabricante { get; set; }
        public string CodAjur { get; set; }
        public string DescAjur { get; set; }

        public CfopRegra CdCfopRegraNavigation { get; set; }
        public ProdutoClassFiscal CdClassFiscalNavigation { get; set; }
        public GrupoComissao CdGrupoComissaoNavigation { get; set; }
        public Gruprod CdGruprodNavigation { get; set; }
        public Marca CdMarcaNavigation { get; set; }
        public Subgruprod CdSubgruprodNavigation { get; set; }
        public CodigoTributacaoMunicipio CodigoTributacaoMunicipioNavigation { get; set; }
        public TributacaoGrupoPisCofins IdTribGrupoPiscofinsNavigation { get; set; }
        public TributacaoGrupo IdTributacaoGrupoNavigation { get; set; }
        public ProdutoTipo TpProdutoNavigation { get; set; }
        public UnMedida UnArmazenagemNavigation { get; set; }
        public UnMedida UnCompraNavigation { get; set; }
        public UnMedida UnMedidaNavigation { get; set; }
        public ICollection<Custcomp> Custcomp { get; set; }
        public ICollection<Estoque> Estoque { get; set; }
        public ICollection<Nfei> Nfei { get; set; }
        public ICollection<OrcamentoI> OrcamentoI { get; set; }
        public ICollection<OrdemProducaoI> OrdemProducaoI { get; set; }
        public ICollection<ProdComposto> ProdComposto { get; set; }
        public ICollection<ProdutoCliente> ProdutoCliente { get; set; }
        public ICollection<ProdutoLote> ProdutoLote { get; set; }
        public ICollection<ProdutoSerie> ProdutoSerie { get; set; }
        public ICollection<ProdutoVeiculo> ProdutoVeiculo { get; set; }
        public ICollection<Veiprod> Veiprod { get; set; }
    }
}
