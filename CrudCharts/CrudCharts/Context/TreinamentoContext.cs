using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CrudCharts.Models
{
    public partial class TreinamentoContext : DbContext
    {
        public TreinamentoContext()
       {
       }

        public TreinamentoContext(DbContextOptions<TreinamentoContext> options)
            : base(options)
        {
        }

		public virtual DbSet<Login> Login { get; set; }
		public virtual DbSet<PedidoFrete> PedidoFrete { get; set; }
		public virtual DbSet<Rotas> Rotas { get; set; }

		public virtual DbSet<Acesso> Acesso { get; set; }
        public virtual DbSet<AcessoAcao> AcessoAcao { get; set; }
        public virtual DbSet<AcessoAcaoPerfil> AcessoAcaoPerfil { get; set; }
        public virtual DbSet<AcessoAcaoRelatorio> AcessoAcaoRelatorio { get; set; }
        public virtual DbSet<AcessoAcaoRelCampo> AcessoAcaoRelCampo { get; set; }
        public virtual DbSet<AcessoAcaoRelFiltro> AcessoAcaoRelFiltro { get; set; }
        public virtual DbSet<AcessoAcaoUsuario> AcessoAcaoUsuario { get; set; }
        public virtual DbSet<AcessoMenu> AcessoMenu { get; set; }
        public virtual DbSet<Administradora> Administradora { get; set; }
        public virtual DbSet<AdministradoraBandeira> AdministradoraBandeira { get; set; }
        public virtual DbSet<AdministradoraTaxas> AdministradoraTaxas { get; set; }
        public virtual DbSet<Agenda> Agenda { get; set; }
        public virtual DbSet<AgendaSituacao> AgendaSituacao { get; set; }
        public virtual DbSet<Agronomo> Agronomo { get; set; }
        public virtual DbSet<AlteracaoCadItem> AlteracaoCadItem { get; set; }
        public virtual DbSet<AlteracaoCadParticipante> AlteracaoCadParticipante { get; set; }
        public virtual DbSet<Anp> Anp { get; set; }
        public virtual DbSet<Anvisa> Anvisa { get; set; }
        public virtual DbSet<Aplicacao> Aplicacao { get; set; }
        public virtual DbSet<ApontamentoDeServico> ApontamentoDeServico { get; set; }
        public virtual DbSet<AuditorEstoqueC> AuditorEstoqueC { get; set; }
        public virtual DbSet<AuditorEstoqueI> AuditorEstoqueI { get; set; }
        public virtual DbSet<AutorizaXml> AutorizaXml { get; set; }
        public virtual DbSet<Banco> Banco { get; set; }
        public virtual DbSet<BeneficioFiscal> BeneficioFiscal { get; set; }
        public virtual DbSet<Caixa> Caixa { get; set; }
        public virtual DbSet<Cargo> Cargo { get; set; }
        public virtual DbSet<CartaCorrecao> CartaCorrecao { get; set; }
        public virtual DbSet<CartaCorrecaoHist> CartaCorrecaoHist { get; set; }
        public virtual DbSet<Cest> Cest { get; set; }
        public virtual DbSet<Cfop> Cfop { get; set; }
        public virtual DbSet<CfopRegra> CfopRegra { get; set; }
        public virtual DbSet<Cidade> Cidade { get; set; }
        public virtual DbSet<ClassListaServico> ClassListaServico { get; set; }
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<ClienteContato> ClienteContato { get; set; }
        public virtual DbSet<ClienteEntrega> ClienteEntrega { get; set; }
        public virtual DbSet<ClienteGrupo> ClienteGrupo { get; set; }
        public virtual DbSet<ClientePropriedade> ClientePropriedade { get; set; }
        public virtual DbSet<ClienteResumoFinanceiro> ClienteResumoFinanceiro { get; set; }
        public virtual DbSet<ClienteResumoFinanceiroLog> ClienteResumoFinanceiroLog { get; set; }
        public virtual DbSet<Clieveic> Clieveic { get; set; }
        public virtual DbSet<CobBordero> CobBordero { get; set; }
        public virtual DbSet<CobBorderoParcela> CobBorderoParcela { get; set; }
        public virtual DbSet<CobConvenio> CobConvenio { get; set; }
        public virtual DbSet<CobConvenioAtributo> CobConvenioAtributo { get; set; }
        public virtual DbSet<CobConvenioFormaPgto> CobConvenioFormaPgto { get; set; }
        public virtual DbSet<CobMotivoMovimentoRetorno> CobMotivoMovimentoRetorno { get; set; }
        public virtual DbSet<CobMovimentoRetorno> CobMovimentoRetorno { get; set; }
        public virtual DbSet<CobParcela> CobParcela { get; set; }
        public virtual DbSet<CobRetorno> CobRetorno { get; set; }
        public virtual DbSet<CobRetornoParcela> CobRetornoParcela { get; set; }
        public virtual DbSet<CodigoTributacaoMunicipio> CodigoTributacaoMunicipio { get; set; }
        public virtual DbSet<Comissao> Comissao { get; set; }
        public virtual DbSet<ComissaoFunc> ComissaoFunc { get; set; }
        public virtual DbSet<ComissaoFuncDev> ComissaoFuncDev { get; set; }
        public virtual DbSet<ConfEstudoLucratividade> ConfEstudoLucratividade { get; set; }
        public virtual DbSet<ConfSpedPisCofins> ConfSpedPisCofins { get; set; }
        public virtual DbSet<Construcao> Construcao { get; set; }
        public virtual DbSet<Consulta> Consulta { get; set; }
        public virtual DbSet<ConsultaCampo> ConsultaCampo { get; set; }
        public virtual DbSet<Contabilista> Contabilista { get; set; }
        public virtual DbSet<ContaContabil> ContaContabil { get; set; }
        public virtual DbSet<Contato> Contato { get; set; }
        public virtual DbSet<Crptitulo> Crptitulo { get; set; }
        public virtual DbSet<CrptituloAgrupado> CrptituloAgrupado { get; set; }
        public virtual DbSet<CrptituloFuncionario> CrptituloFuncionario { get; set; }
        public virtual DbSet<CrptituloMovimentoCxa> CrptituloMovimentoCxa { get; set; }
        public virtual DbSet<Cst> Cst { get; set; }
        public virtual DbSet<CstIpi> CstIpi { get; set; }
        public virtual DbSet<CstPisCofins> CstPisCofins { get; set; }
        public virtual DbSet<Custcomp> Custcomp { get; set; }
        public virtual DbSet<CxaAbertura> CxaAbertura { get; set; }
        public virtual DbSet<CxaAcesso> CxaAcesso { get; set; }
        public virtual DbSet<CxaConta> CxaConta { get; set; }
        public virtual DbSet<DocNaoFiscalC> DocNaoFiscalC { get; set; }
        public virtual DbSet<DocNaoFiscalI> DocNaoFiscalI { get; set; }
        public virtual DbSet<DocProducao> DocProducao { get; set; }
        public virtual DbSet<Estocagem> Estocagem { get; set; }
        public virtual DbSet<Estoque> Estoque { get; set; }
        public virtual DbSet<Filial> Filial { get; set; }
        public virtual DbSet<FilialBd> FilialBd { get; set; }
        public virtual DbSet<FilialConfNfeNfse> FilialConfNfeNfse { get; set; }
        public virtual DbSet<FilialEmail> FilialEmail { get; set; }
        public virtual DbSet<FilialIeSt> FilialIeSt { get; set; }
        public virtual DbSet<Fornecedor> Fornecedor { get; set; }
        public virtual DbSet<FornecedorContato> FornecedorContato { get; set; }
        public virtual DbSet<FornecedorUnmedida> FornecedorUnmedida { get; set; }
        public virtual DbSet<Fornprod> Fornprod { get; set; }
        public virtual DbSet<Fornveic> Fornveic { get; set; }
        public virtual DbSet<FrenteCaixa> FrenteCaixa { get; set; }
        public virtual DbSet<Funcionario> Funcionario { get; set; }
        public virtual DbSet<GrupoComissao> GrupoComissao { get; set; }
        public virtual DbSet<GrupoOperacaoEs> GrupoOperacaoEs { get; set; }
        public virtual DbSet<Gruprod> Gruprod { get; set; }
        public virtual DbSet<Hash> Hash { get; set; }
        public virtual DbSet<HelpAtz> HelpAtz { get; set; }
        public virtual DbSet<HelpAtzAlteracao> HelpAtzAlteracao { get; set; }
        public virtual DbSet<Impfiscal> Impfiscal { get; set; }
        public virtual DbSet<ImpfiscalAliquota> ImpfiscalAliquota { get; set; }
        public virtual DbSet<LctoFlex> LctoFlex { get; set; }
        public virtual DbSet<LogSistema> LogSistema { get; set; }
        public virtual DbSet<Marca> Marca { get; set; }
        public virtual DbSet<Mdfe> Mdfe { get; set; }
        public virtual DbSet<MdfeCondutor> MdfeCondutor { get; set; }
        public virtual DbSet<MdfeDocumento> MdfeDocumento { get; set; }
        public virtual DbSet<MdfeEvento> MdfeEvento { get; set; }
        public virtual DbSet<MdfePercurso> MdfePercurso { get; set; }
        public virtual DbSet<Medida> Medida { get; set; }
        public virtual DbSet<MensagemNota> MensagemNota { get; set; }
        public virtual DbSet<Modelo> Modelo { get; set; }
        public virtual DbSet<ModeloDcto> ModeloDcto { get; set; }
        public virtual DbSet<Montadora> Montadora { get; set; }
        public virtual DbSet<MotivoDevolucao> MotivoDevolucao { get; set; }
        public virtual DbSet<Motorista> Motorista { get; set; }
        public virtual DbSet<MovimentoCxa> MovimentoCxa { get; set; }
        public virtual DbSet<MovimentoCxaVinculo> MovimentoCxaVinculo { get; set; }
        public virtual DbSet<MovimentoSeguradora> MovimentoSeguradora { get; set; }
        public virtual DbSet<Msggrupo> Msggrupo { get; set; }
        public virtual DbSet<NfcFrete> NfcFrete { get; set; }
        public virtual DbSet<NfContabilC> NfContabilC { get; set; }
        public virtual DbSet<NfContabilCfop> NfContabilCfop { get; set; }
        public virtual DbSet<NfContabilI> NfContabilI { get; set; }
        public virtual DbSet<Nfec> Nfec { get; set; }
        public virtual DbSet<NfecConhecimento> NfecConhecimento { get; set; }
        public virtual DbSet<NfecEnergiaEletrica> NfecEnergiaEletrica { get; set; }
        public virtual DbSet<NfecImportacao> NfecImportacao { get; set; }
        public virtual DbSet<NfecMensagem> NfecMensagem { get; set; }
        public virtual DbSet<NfeContingencia> NfeContingencia { get; set; }
        public virtual DbSet<Nfei> Nfei { get; set; }
        public virtual DbSet<Nfeicomplemento> Nfeicomplemento { get; set; }
        public virtual DbSet<NfeiImportacao> NfeiImportacao { get; set; }
        public virtual DbSet<NfeInutilizacao> NfeInutilizacao { get; set; }
        public virtual DbSet<NfReferenciada> NfReferenciada { get; set; }
        public virtual DbSet<Nfsc> Nfsc { get; set; }
        public virtual DbSet<NfscMensagem> NfscMensagem { get; set; }
        public virtual DbSet<NfscServico> NfscServico { get; set; }
        public virtual DbSet<Nfsi> Nfsi { get; set; }
        public virtual DbSet<Nfsicomplemento> Nfsicomplemento { get; set; }
        public virtual DbSet<NfsiCupom> NfsiCupom { get; set; }
        public virtual DbSet<NfXml> NfXml { get; set; }
        public virtual DbSet<NrSerieNfs> NrSerieNfs { get; set; }
        public virtual DbSet<Nsu> Nsu { get; set; }
        public virtual DbSet<NsuProdutoNegativo> NsuProdutoNegativo { get; set; }
        public virtual DbSet<OperacaoCfopRegra> OperacaoCfopRegra { get; set; }
        public virtual DbSet<OperacaoEs> OperacaoEs { get; set; }
        public virtual DbSet<OrcamentoAgrupado> OrcamentoAgrupado { get; set; }
        public virtual DbSet<OrcamentoC> OrcamentoC { get; set; }
        public virtual DbSet<OrcamentoContato> OrcamentoContato { get; set; }
        public virtual DbSet<OrcamentoDav> OrcamentoDav { get; set; }
        public virtual DbSet<OrcamentoFrete> OrcamentoFrete { get; set; }
        public virtual DbSet<OrcamentoI> OrcamentoI { get; set; }
        public virtual DbSet<OrcamentoIAgrupa> OrcamentoIAgrupa { get; set; }
        public virtual DbSet<OrcamentoImagem> OrcamentoImagem { get; set; }
        public virtual DbSet<OrcamentoIReservaEstoque> OrcamentoIReservaEstoque { get; set; }
        public virtual DbSet<OrcamentoNfe> OrcamentoNfe { get; set; }
        public virtual DbSet<OrcamentoSituacao> OrcamentoSituacao { get; set; }
        public virtual DbSet<OrdemProducaoC> OrdemProducaoC { get; set; }
        public virtual DbSet<OrdemProducaoI> OrdemProducaoI { get; set; }
        public virtual DbSet<PafecfE3> PafecfE3 { get; set; }
        public virtual DbSet<PedidoAfvC> PedidoAfvC { get; set; }
        public virtual DbSet<PedidoAfvI> PedidoAfvI { get; set; }
        public virtual DbSet<PedidoC> PedidoC { get; set; }
        public virtual DbSet<PedidoFrete1> PedidoFrete1 { get; set; }
        public virtual DbSet<PedidoI> PedidoI { get; set; }
        public virtual DbSet<PerfilAcesso> PerfilAcesso { get; set; }
        public virtual DbSet<PlHistorico> PlHistorico { get; set; }
        public virtual DbSet<ProdComposto> ProdComposto { get; set; }
        public virtual DbSet<ProdOriginal> ProdOriginal { get; set; }
        public virtual DbSet<ProdRelacionado> ProdRelacionado { get; set; }
        public virtual DbSet<Produto> Produto { get; set; }
        public virtual DbSet<ProdutoAltprec> ProdutoAltprec { get; set; }
        public virtual DbSet<ProdutoClassFiscal> ProdutoClassFiscal { get; set; }
        public virtual DbSet<ProdutoClassFiscalIbpt> ProdutoClassFiscalIbpt { get; set; }
        public virtual DbSet<ProdutoClassFiscalMva> ProdutoClassFiscalMva { get; set; }
        public virtual DbSet<ProdutoCliente> ProdutoCliente { get; set; }
        public virtual DbSet<ProdutoFornecedor> ProdutoFornecedor { get; set; }
        public virtual DbSet<ProdutoLote> ProdutoLote { get; set; }
        public virtual DbSet<ProdutoSerie> ProdutoSerie { get; set; }
        public virtual DbSet<ProdutoTipo> ProdutoTipo { get; set; }
        public virtual DbSet<ProdutoUnidade> ProdutoUnidade { get; set; }
        public virtual DbSet<ProdutoVeiculo> ProdutoVeiculo { get; set; }
        public virtual DbSet<ProdutoVeiculosInjecao> ProdutoVeiculosInjecao { get; set; }
        public virtual DbSet<ProdutoVeiculosTransmissao> ProdutoVeiculosTransmissao { get; set; }
        public virtual DbSet<Propriedade> Propriedade { get; set; }
        public virtual DbSet<ProtocoloIcms> ProtocoloIcms { get; set; }
        public virtual DbSet<ProtocoloIcmsClassFiscal> ProtocoloIcmsClassFiscal { get; set; }
        public virtual DbSet<ReceitaAgro> ReceitaAgro { get; set; }
        public virtual DbSet<Recibo> Recibo { get; set; }
        public virtual DbSet<ReducaoZ> ReducaoZ { get; set; }
        public virtual DbSet<Reducaoz1> Reducaoz1 { get; set; }
        public virtual DbSet<ReducaoZTotalizador> ReducaoZTotalizador { get; set; }
        public virtual DbSet<RefNotaProdutor> RefNotaProdutor { get; set; }
        public virtual DbSet<Regiao> Regiao { get; set; }
        public virtual DbSet<SaldoCxaDia> SaldoCxaDia { get; set; }
        public virtual DbSet<Situacao> Situacao { get; set; }
        public virtual DbSet<Subgruprod> Subgruprod { get; set; }
        public virtual DbSet<Tab436SpedPiscofins> Tab436SpedPiscofins { get; set; }
        public virtual DbSet<Tab437SpedPiscofins> Tab437SpedPiscofins { get; set; }
        public virtual DbSet<TabelaPreco> TabelaPreco { get; set; }
        public virtual DbSet<TabelaPrecoProduto> TabelaPrecoProduto { get; set; }
        public virtual DbSet<Tabvcto> Tabvcto { get; set; }
        public virtual DbSet<Tipocobr> Tipocobr { get; set; }
        public virtual DbSet<Tributacao> Tributacao { get; set; }
        public virtual DbSet<TributacaoAliquota> TributacaoAliquota { get; set; }
        public virtual DbSet<TributacaoGrupo> TributacaoGrupo { get; set; }
        public virtual DbSet<TributacaoGrupoPisCofins> TributacaoGrupoPisCofins { get; set; }
        public virtual DbSet<UnMedida> UnMedida { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
        public virtual DbSet<UsuarioPerfil> UsuarioPerfil { get; set; }
        public virtual DbSet<Veiculo> Veiculo { get; set; }
        public virtual DbSet<VeiculoCombustivel> VeiculoCombustivel { get; set; }
        public virtual DbSet<VeiculoComplemento> VeiculoComplemento { get; set; }
        public virtual DbSet<VeiculoCor> VeiculoCor { get; set; }
        public virtual DbSet<VeiculoDespesas> VeiculoDespesas { get; set; }
        public virtual DbSet<VeiculoEspecie> VeiculoEspecie { get; set; }
        public virtual DbSet<VeiculoInjecao> VeiculoInjecao { get; set; }
        public virtual DbSet<VeiculoModeloComplemento> VeiculoModeloComplemento { get; set; }
        public virtual DbSet<VeiculoModeloInjecao> VeiculoModeloInjecao { get; set; }
        public virtual DbSet<VeiculoModeloMotor> VeiculoModeloMotor { get; set; }
        public virtual DbSet<VeiculoModeloTransmissao> VeiculoModeloTransmissao { get; set; }
        public virtual DbSet<VeiculoMotor> VeiculoMotor { get; set; }
        public virtual DbSet<VeiculoTipo> VeiculoTipo { get; set; }
        public virtual DbSet<VeiculoTransmissao> VeiculoTransmissao { get; set; }
        public virtual DbSet<Veiprod> Veiprod { get; set; }

        // Unable to generate entity type for table 'public.campo_filtro'. Please see the warning messages.
        // Unable to generate entity type for table 'public.licenca'. Please see the warning messages.
        // Unable to generate entity type for table 'public.LOG'. Please see the warning messages.
        // Unable to generate entity type for table 'public.relatorio'. Please see the warning messages.
        // Unable to generate entity type for table 'public.sinc_dav_nfe'. Please see the warning messages.
        // Unable to generate entity type for table 'public.relatorio_filtro'. Please see the warning messages.
        // Unable to generate entity type for table 'public.sinc_clientes'. Please see the warning messages.
        // Unable to generate entity type for table 'public.sinc_produtos'. Please see the warning messages.
        // Unable to generate entity type for table 'public.acesso_menu_acao'. Please see the warning messages.
        // Unable to generate entity type for table 'public.sinc_empresas'. Please see the warning messages.
        // Unable to generate entity type for table 'public.sinc_cidades'. Please see the warning messages.
        // Unable to generate entity type for table 'public.sinc_cancela_dav'. Please see the warning messages.
        // Unable to generate entity type for table 'public.sinc_dav_itens'. Please see the warning messages.
        // Unable to generate entity type for table 'public.versao'. Please see the warning messages.
        // Unable to generate entity type for table 'public.juros_multa_tipocobr_banco'. Please see the warning messages.
        // Unable to generate entity type for table 'public.juros_prazo'. Please see the warning messages.
        // Unable to generate entity type for table 'public.cliente_cobranca'. Please see the warning messages.
        // Unable to generate entity type for table 'public.help_atz_usuario'. Please see the warning messages.
        // Unable to generate entity type for table 'public.exclusao'. Please see the warning messages.
        // Unable to generate entity type for table 'public.sinc_unidade_medida'. Please see the warning messages.
        // Unable to generate entity type for table 'public.sinc_dav'. Please see the warning messages.
        // Unable to generate entity type for table 'public.movimento_morto'. Please see the warning messages.
        // Unable to generate entity type for table 'public.sinc_grupo_produtos'. Please see the warning messages.
        // Unable to generate entity type for table 'public.sinc_estoque'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
				Database.Migrate();
			}
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Acesso>(entity =>
            {
                entity.HasKey(e => new { e.NmPrograma, e.NmLogin, e.CdFilial });

                entity.ToTable("acesso");

                entity.Property(e => e.NmPrograma)
                    .HasColumnName("nm_programa")
                    .HasMaxLength(200);

                entity.Property(e => e.NmLogin)
                    .HasColumnName("nm_login")
                    .HasMaxLength(15);

                entity.Property(e => e.CdFilial).HasColumnName("cd_filial");

                entity.Property(e => e.DtAtz)
                    .HasColumnName("dt_atz")
                    .HasColumnType("date")
                    .HasDefaultValueSql("CURRENT_DATE");
            });

            modelBuilder.Entity<AcessoAcao>(entity =>
            {
                entity.HasKey(e => e.IdGeral);

                entity.ToTable("acesso_acao");

                entity.Property(e => e.IdGeral)
                    .HasColumnName("id_geral")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdAcesso)
                    .HasColumnName("cd_acesso")
                    .HasMaxLength(10);

                entity.Property(e => e.CdConexao).HasColumnName("cd_conexao");

                entity.Property(e => e.FlAlterar)
                    .HasColumnName("fl_alterar")
                    .HasMaxLength(1);

                entity.Property(e => e.FlClassificacao)
                    .IsRequired()
                    .HasColumnName("fl_classificacao")
                    .HasMaxLength(1);

                entity.Property(e => e.FlExcluir)
                    .HasColumnName("fl_excluir")
                    .HasMaxLength(1);

                entity.Property(e => e.FlInserir)
                    .HasColumnName("fl_inserir")
                    .HasMaxLength(1);

                entity.Property(e => e.FlPermitirFilial)
                    .HasColumnName("fl_permitir_filial")
                    .HasMaxLength(1);

                entity.Property(e => e.NmAcao)
                    .IsRequired()
                    .HasColumnName("nm_acao")
                    .HasMaxLength(200);

                entity.Property(e => e.NmProcedimento)
                    .IsRequired()
                    .HasColumnName("nm_procedimento")
                    .HasMaxLength(200);

                entity.Property(e => e.Obs).HasColumnName("obs");

                entity.Property(e => e.TpEmpresa).HasColumnName("tp_empresa");
            });

            modelBuilder.Entity<AcessoAcaoPerfil>(entity =>
            {
                entity.HasKey(e => new { e.CdPerfilAcesso, e.IdAcessoAcao });

                entity.ToTable("acesso_acao_perfil");

                entity.Property(e => e.CdPerfilAcesso).HasColumnName("cd_perfil_acesso");

                entity.Property(e => e.IdAcessoAcao).HasColumnName("id_acesso_acao");

                entity.Property(e => e.FlAcesso)
                    .IsRequired()
                    .HasColumnName("fl_acesso")
                    .HasMaxLength(1);

                entity.Property(e => e.FlEditar)
                    .IsRequired()
                    .HasColumnName("fl_editar")
                    .HasMaxLength(1);

                entity.Property(e => e.FlExcluir)
                    .IsRequired()
                    .HasColumnName("fl_excluir")
                    .HasMaxLength(1);

                entity.Property(e => e.FlInserir)
                    .IsRequired()
                    .HasColumnName("fl_inserir")
                    .HasMaxLength(1);

                entity.HasOne(d => d.CdPerfilAcessoNavigation)
                    .WithMany(p => p.AcessoAcaoPerfil)
                    .HasForeignKey(d => d.CdPerfilAcesso)
                    .HasConstraintName("fk_acesso_acao_perfil_per");

                entity.HasOne(d => d.IdAcessoAcaoNavigation)
                    .WithMany(p => p.AcessoAcaoPerfil)
                    .HasForeignKey(d => d.IdAcessoAcao)
                    .HasConstraintName("fk_acesso_acao_perfil_aca");
            });

            modelBuilder.Entity<AcessoAcaoRelatorio>(entity =>
            {
                entity.HasKey(e => e.IdAcao);

                entity.ToTable("acesso_acao_relatorio");

                entity.Property(e => e.IdAcao)
                    .HasColumnName("id_acao")
                    .ValueGeneratedNever();

                entity.Property(e => e.PathModelo)
                    .HasColumnName("path_modelo")
                    .HasMaxLength(100);

                entity.Property(e => e.SqlRel).HasColumnName("sql_rel");

                entity.Property(e => e.Tipo).HasColumnName("tipo");

                entity.HasOne(d => d.IdAcaoNavigation)
                    .WithOne(p => p.AcessoAcaoRelatorio)
                    .HasForeignKey<AcessoAcaoRelatorio>(d => d.IdAcao)
                    .HasConstraintName("fk_acesso_acao_relatorio_1");
            });

            modelBuilder.Entity<AcessoAcaoRelCampo>(entity =>
            {
                entity.HasKey(e => e.IdGeral);

                entity.ToTable("acesso_acao_rel_campo");

                entity.Property(e => e.IdGeral)
                    .HasColumnName("id_geral")
                    .ValueGeneratedNever();

                entity.Property(e => e.Esquerda).HasColumnName("esquerda");

                entity.Property(e => e.FlGrafico).HasColumnName("fl_grafico");

                entity.Property(e => e.FlGrid).HasColumnName("fl_grid");

                entity.Property(e => e.FlTipoSumarizacao).HasColumnName("fl_tipo_sumarizacao");

                entity.Property(e => e.IdAcao).HasColumnName("id_acao");

                entity.Property(e => e.NmCampo)
                    .IsRequired()
                    .HasColumnName("nm_campo")
                    .HasMaxLength(30);

                entity.Property(e => e.NmTituloCampo)
                    .IsRequired()
                    .HasColumnName("nm_titulo_campo")
                    .HasMaxLength(30);

                entity.Property(e => e.NrOrdem).HasColumnName("nr_ordem");

                entity.Property(e => e.TipoCampo)
                    .HasColumnName("tipo_campo")
                    .HasMaxLength(20);

                entity.Property(e => e.Topo).HasColumnName("topo");

                entity.HasOne(d => d.IdAcaoNavigation)
                    .WithMany(p => p.AcessoAcaoRelCampo)
                    .HasForeignKey(d => d.IdAcao)
                    .HasConstraintName("fk_acesso_acao_rel_campo_idacao");
            });

            modelBuilder.Entity<AcessoAcaoRelFiltro>(entity =>
            {
                entity.ToTable("acesso_acao_rel_filtro");

                entity.HasIndex(e => new { e.IdAcao, e.NrOrdem })
                    .HasName("unq_acesso_acao_rel_filtro_orde")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdConsulta).HasColumnName("cd_consulta");

                entity.Property(e => e.Comentario)
                    .HasColumnName("comentario")
                    .HasMaxLength(40);

                entity.Property(e => e.FlSelecaoMultipla)
                    .HasColumnName("fl_selecao_multipla")
                    .HasMaxLength(1);

                entity.Property(e => e.IdAcao).HasColumnName("id_acao");

                entity.Property(e => e.Multivalor).HasColumnName("multivalor");

                entity.Property(e => e.NmCampo)
                    .HasColumnName("nm_campo")
                    .HasMaxLength(40);

                entity.Property(e => e.NmCampoRetorno)
                    .HasColumnName("nm_campo_retorno")
                    .HasMaxLength(40);

                entity.Property(e => e.NmFiltro)
                    .IsRequired()
                    .HasColumnName("nm_filtro")
                    .HasMaxLength(40);

                entity.Property(e => e.NmParametroSql)
                    .HasColumnName("nm_parametro_sql")
                    .HasMaxLength(40);

                entity.Property(e => e.NrOrdem).HasColumnName("nr_ordem");

                entity.Property(e => e.RotuloFiltro)
                    .HasColumnName("rotulo_filtro")
                    .HasMaxLength(40);

                entity.Property(e => e.TipoDado)
                    .HasColumnName("tipo_dado")
                    .HasMaxLength(40);

                entity.Property(e => e.TipoDadoParametro)
                    .HasColumnName("tipo_dado_parametro")
                    .HasMaxLength(40);

                entity.Property(e => e.ValorPadrao)
                    .HasColumnName("valor_padrao")
                    .HasMaxLength(40);

                entity.HasOne(d => d.IdAcaoNavigation)
                    .WithMany(p => p.AcessoAcaoRelFiltro)
                    .HasForeignKey(d => d.IdAcao)
                    .HasConstraintName("acesso_acao_rel_filtro_fk");
            });

            modelBuilder.Entity<AcessoAcaoUsuario>(entity =>
            {
                entity.HasKey(e => new { e.CdUsuario, e.IdAcessoAcao });

                entity.ToTable("acesso_acao_usuario");

                entity.Property(e => e.CdUsuario).HasColumnName("cd_usuario");

                entity.Property(e => e.IdAcessoAcao).HasColumnName("id_acesso_acao");

                entity.Property(e => e.FlAcesso)
                    .IsRequired()
                    .HasColumnName("fl_acesso")
                    .HasMaxLength(1);

                entity.Property(e => e.FlEditar)
                    .IsRequired()
                    .HasColumnName("fl_editar")
                    .HasMaxLength(1);

                entity.Property(e => e.FlExcluir)
                    .IsRequired()
                    .HasColumnName("fl_excluir")
                    .HasMaxLength(1);

                entity.Property(e => e.FlInserir)
                    .IsRequired()
                    .HasColumnName("fl_inserir")
                    .HasMaxLength(1);

                entity.HasOne(d => d.CdUsuarioNavigation)
                    .WithMany(p => p.AcessoAcaoUsuario)
                    .HasForeignKey(d => d.CdUsuario)
                    .HasConstraintName("fk_acesso_acao_usuario_u");

                entity.HasOne(d => d.IdAcessoAcaoNavigation)
                    .WithMany(p => p.AcessoAcaoUsuario)
                    .HasForeignKey(d => d.IdAcessoAcao)
                    .HasConstraintName("fk_acesso_acao_usuario_a");
            });

            modelBuilder.Entity<AcessoMenu>(entity =>
            {
                entity.HasKey(e => e.IdGeral);

                entity.ToTable("acesso_menu");

                entity.Property(e => e.IdGeral)
                    .HasColumnName("id_geral")
                    .ValueGeneratedNever();

                entity.Property(e => e.IdMenuPai).HasColumnName("id_menu_pai");

                entity.Property(e => e.NmTeclaAtalho)
                    .HasColumnName("nm_tecla_atalho")
                    .HasMaxLength(30);

                entity.Property(e => e.NmTitulo)
                    .IsRequired()
                    .HasColumnName("nm_titulo")
                    .HasMaxLength(200);

                entity.Property(e => e.NrOrdem).HasColumnName("nr_ordem");

                entity.HasOne(d => d.IdMenuPaiNavigation)
                    .WithMany(p => p.InverseIdMenuPaiNavigation)
                    .HasForeignKey(d => d.IdMenuPai)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_acesso_menu_acesso_menu");
            });

            modelBuilder.Entity<Administradora>(entity =>
            {
                entity.HasKey(e => e.CdAdministradora);

                entity.ToTable("administradora");

                entity.Property(e => e.CdAdministradora)
                    .HasColumnName("cd_administradora")
                    .ValueGeneratedNever();

                entity.Property(e => e.Bairro)
                    .HasColumnName("bairro")
                    .HasMaxLength(30);

                entity.Property(e => e.CdCaixa).HasColumnName("cd_caixa");

                entity.Property(e => e.CdCidade).HasColumnName("cd_cidade");

                entity.Property(e => e.CdFilial).HasColumnName("cd_filial");

                entity.Property(e => e.Cnpj)
                    .HasColumnName("cnpj")
                    .HasMaxLength(18);

                entity.Property(e => e.Complemento)
                    .HasColumnName("complemento")
                    .HasMaxLength(20);

                entity.Property(e => e.ContaCaixa).HasColumnName("conta_caixa");

                entity.Property(e => e.DiasPagamentoAdm).HasColumnName("dias_pagamento_adm");

                entity.Property(e => e.DiasPagamentoLoja).HasColumnName("dias_pagamento_loja");

                entity.Property(e => e.DtAtz)
                    .HasColumnName("dt_atz")
                    .HasColumnType("date")
                    .HasDefaultValueSql("CURRENT_DATE");

                entity.Property(e => e.Endereco)
                    .HasColumnName("endereco")
                    .HasMaxLength(80);

                entity.Property(e => e.IdBandeira).HasColumnName("id_bandeira");

                entity.Property(e => e.Inscricao)
                    .HasColumnName("inscricao")
                    .HasMaxLength(18);

                entity.Property(e => e.NmAdministradora)
                    .IsRequired()
                    .HasColumnName("nm_administradora")
                    .HasMaxLength(80);

                entity.Property(e => e.Numero)
                    .HasColumnName("numero")
                    .HasMaxLength(50);

                entity.Property(e => e.PcCobrancaAdm)
                    .HasColumnName("pc_cobranca_adm")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.PcCobrancaDebito)
                    .HasColumnName("pc_cobranca_debito")
                    .HasColumnType("numeric(18,4)");

                entity.HasOne(d => d.ContaCaixaNavigation)
                    .WithMany(p => p.Administradora)
                    .HasForeignKey(d => d.ContaCaixa)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_administradora_conta_caixa");

                entity.HasOne(d => d.IdBandeiraNavigation)
                    .WithMany(p => p.Administradora)
                    .HasForeignKey(d => d.IdBandeira)
                    .HasConstraintName("fk_administradora_bandeira");
            });

            modelBuilder.Entity<AdministradoraBandeira>(entity =>
            {
                entity.HasKey(e => e.IdGeral);

                entity.ToTable("administradora_bandeira");

                entity.Property(e => e.IdGeral)
                    .HasColumnName("id_geral")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdBandeira)
                    .HasColumnName("cd_bandeira")
                    .HasMaxLength(3);

                entity.Property(e => e.Descricao)
                    .HasColumnName("descricao")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<AdministradoraTaxas>(entity =>
            {
                entity.HasKey(e => new { e.CdAdministradora, e.QtParcelas });

                entity.ToTable("administradora_taxas");

                entity.Property(e => e.CdAdministradora).HasColumnName("cd_administradora");

                entity.Property(e => e.QtParcelas).HasColumnName("qt_parcelas");

                entity.Property(e => e.PcCobrancaLoja)
                    .HasColumnName("pc_cobranca_loja")
                    .HasColumnType("numeric(9,3)");

                entity.HasOne(d => d.CdAdministradoraNavigation)
                    .WithMany(p => p.AdministradoraTaxas)
                    .HasForeignKey(d => d.CdAdministradora)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_administradora_taxas_cd_adm");
            });

            modelBuilder.Entity<Agenda>(entity =>
            {
                entity.HasKey(e => e.CdEvento);

                entity.ToTable("agenda");

                entity.HasIndex(e => e.DtHrEvento)
                    .HasName("idx_agenda_data");

                entity.Property(e => e.CdEvento)
                    .HasColumnName("cd_evento")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdSituacao).HasColumnName("cd_situacao");

                entity.Property(e => e.DtHrEvento).HasColumnName("dt_hr_evento");

                entity.Property(e => e.NmEvento)
                    .IsRequired()
                    .HasColumnName("nm_evento");

                entity.HasOne(d => d.CdSituacaoNavigation)
                    .WithMany(p => p.Agenda)
                    .HasForeignKey(d => d.CdSituacao)
                    .HasConstraintName("fk_agenda_situacao");
            });

            modelBuilder.Entity<AgendaSituacao>(entity =>
            {
                entity.HasKey(e => e.CdSituacao);

                entity.ToTable("agenda_situacao");

                entity.HasIndex(e => e.NmSituacao)
                    .HasName("idx_agenda_situacao_nome");

                entity.Property(e => e.CdSituacao)
                    .HasColumnName("cd_situacao")
                    .ValueGeneratedNever();

                entity.Property(e => e.DtAtz)
                    .HasColumnName("dt_atz")
                    .HasColumnType("date")
                    .HasDefaultValueSql("CURRENT_DATE");

                entity.Property(e => e.NmSituacao)
                    .IsRequired()
                    .HasColumnName("nm_situacao")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<Agronomo>(entity =>
            {
                entity.HasKey(e => new { e.CdAgronomo, e.Cpf, e.CdFilial });

                entity.ToTable("agronomo");

                entity.Property(e => e.CdAgronomo).HasColumnName("cd_agronomo");

                entity.Property(e => e.Cpf)
                    .HasColumnName("cpf")
                    .HasMaxLength(18);

                entity.Property(e => e.CdFilial).HasColumnName("cd_filial");

                entity.Property(e => e.Bairro)
                    .HasColumnName("bairro")
                    .HasMaxLength(25);

                entity.Property(e => e.CdCidade).HasColumnName("cd_cidade");

                entity.Property(e => e.CdCrea).HasColumnName("cd_crea");

                entity.Property(e => e.Celular)
                    .HasColumnName("celular")
                    .HasMaxLength(20);

                entity.Property(e => e.Cep)
                    .HasColumnName("cep")
                    .HasMaxLength(10);

                entity.Property(e => e.Complemento)
                    .HasColumnName("complemento")
                    .HasMaxLength(10);

                entity.Property(e => e.CreaRegistro)
                    .HasColumnName("crea_registro")
                    .HasMaxLength(20);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(40);

                entity.Property(e => e.Endereco)
                    .HasColumnName("endereco")
                    .HasMaxLength(40);

                entity.Property(e => e.NmAgronomo)
                    .HasColumnName("nm_agronomo")
                    .HasMaxLength(34);

                entity.Property(e => e.Numero).HasColumnName("numero");

                entity.Property(e => e.Obs).HasColumnName("obs");

                entity.Property(e => e.Rg)
                    .HasColumnName("rg")
                    .HasMaxLength(20);

                entity.Property(e => e.Telefone)
                    .HasColumnName("telefone")
                    .HasMaxLength(20);

                entity.HasOne(d => d.CdCidadeNavigation)
                    .WithMany(p => p.Agronomo)
                    .HasForeignKey(d => d.CdCidade)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_agronomo_cidade");
            });

            modelBuilder.Entity<AlteracaoCadItem>(entity =>
            {
                entity.HasKey(e => e.IdGeral);

                entity.ToTable("alteracao_cad_item");

                entity.HasIndex(e => e.CdItem)
                    .HasName("alteracao_cad_item_idx1");

                entity.Property(e => e.IdGeral)
                    .HasColumnName("id_geral")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdItem)
                    .IsRequired()
                    .HasColumnName("cd_item")
                    .HasMaxLength(15);

                entity.Property(e => e.ContAnt)
                    .HasColumnName("cont_ant")
                    .HasMaxLength(120);

                entity.Property(e => e.DtAlt)
                    .HasColumnName("dt_alt")
                    .HasColumnType("date");

                entity.Property(e => e.NrCampo).HasColumnName("nr_campo");
            });

            modelBuilder.Entity<AlteracaoCadParticipante>(entity =>
            {
                entity.HasKey(e => e.IdGeral);

                entity.ToTable("alteracao_cad_participante");

                entity.Property(e => e.IdGeral)
                    .HasColumnName("id_geral")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdParticipante).HasColumnName("cd_participante");

                entity.Property(e => e.ContAnt)
                    .HasColumnName("cont_ant")
                    .HasMaxLength(100);

                entity.Property(e => e.DtAlt)
                    .HasColumnName("dt_alt")
                    .HasColumnType("date");

                entity.Property(e => e.NrCampo).HasColumnName("nr_campo");

                entity.Property(e => e.TpParticipante)
                    .HasColumnName("tp_participante")
                    .HasMaxLength(1);
            });

            modelBuilder.Entity<Anp>(entity =>
            {
                entity.HasKey(e => e.Codigo);

                entity.ToTable("anp");

                entity.Property(e => e.Codigo)
                    .HasColumnName("codigo")
                    .HasMaxLength(5)
                    .ValueGeneratedNever();

                entity.Property(e => e.CdAnp)
                    .IsRequired()
                    .HasColumnName("cd_anp")
                    .HasMaxLength(9);

                entity.Property(e => e.Codif)
                    .HasColumnName("codif")
                    .HasMaxLength(21);

                entity.Property(e => e.DescricaoAnp)
                    .HasColumnName("descricao_anp")
                    .HasMaxLength(95);

                entity.Property(e => e.PcGasImportado)
                    .HasColumnName("pc_gas_importado")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.PcGasNacional)
                    .HasColumnName("pc_gas_nacional")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.PcGlp)
                    .HasColumnName("pc_glp")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlPartida)
                    .HasColumnName("vl_partida")
                    .HasColumnType("numeric(15,4)");
            });

            modelBuilder.Entity<Anvisa>(entity =>
            {
                entity.HasKey(e => e.Codigo);

                entity.ToTable("anvisa");

                entity.Property(e => e.Codigo)
                    .HasColumnName("codigo")
                    .HasMaxLength(5)
                    .ValueGeneratedNever();

                entity.Property(e => e.CdAnvisa)
                    .IsRequired()
                    .HasColumnName("cd_anvisa")
                    .HasMaxLength(9);

                entity.Property(e => e.DescricaoAnvisa).HasColumnName("descricao_anvisa");

                entity.Property(e => e.Preco)
                    .HasColumnName("preco")
                    .HasColumnType("numeric(15,2)");
            });

            modelBuilder.Entity<Aplicacao>(entity =>
            {
                entity.HasKey(e => e.CdAplicacao);

                entity.ToTable("aplicacao");

                entity.Property(e => e.CdAplicacao)
                    .HasColumnName("cd_aplicacao")
                    .ValueGeneratedNever();

                entity.Property(e => e.DtAtz)
                    .HasColumnName("dt_atz")
                    .HasColumnType("date");

                entity.Property(e => e.NmAplicacao)
                    .IsRequired()
                    .HasColumnName("nm_aplicacao")
                    .HasMaxLength(80);
            });

            modelBuilder.Entity<ApontamentoDeServico>(entity =>
            {
                entity.HasKey(e => new { e.CdFilial, e.Id });

                entity.ToTable("apontamento_de_servico");

                entity.Property(e => e.CdFilial).HasColumnName("cd_filial");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CdFuncionario).HasColumnName("cd_funcionario");

                entity.Property(e => e.Data)
                    .HasColumnName("data")
                    .HasColumnType("date");

                entity.Property(e => e.Descricao)
                    .HasColumnName("descricao")
                    .HasMaxLength(500);

                entity.Property(e => e.DtAtz)
                    .HasColumnName("dt_atz")
                    .HasColumnType("date")
                    .HasDefaultValueSql("CURRENT_DATE");

                entity.Property(e => e.HoraFinal)
                    .HasColumnName("hora_final")
                    .HasColumnType("time without time zone");

                entity.Property(e => e.HoraInicial)
                    .HasColumnName("hora_inicial")
                    .HasColumnType("time without time zone");

                entity.Property(e => e.NrOs).HasColumnName("nr_os");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.HasOne(d => d.CdF)
                    .WithMany(p => p.ApontamentoDeServico)
                    .HasForeignKey(d => new { d.CdFilial, d.CdFuncionario })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_apontamento_de_servico_2");

                entity.HasOne(d => d.OrcamentoC)
                    .WithMany(p => p.ApontamentoDeServico)
                    .HasForeignKey(d => new { d.CdFilial, d.NrOs })
                    .HasConstraintName("fk_apontamento_de_servico_1");
            });

            modelBuilder.Entity<AuditorEstoqueC>(entity =>
            {
                entity.HasKey(e => new { e.CdFilial, e.IdGeral });

                entity.ToTable("auditor_estoque_c");

                entity.Property(e => e.CdFilial).HasColumnName("cd_filial");

                entity.Property(e => e.IdGeral).HasColumnName("id_geral");

                entity.Property(e => e.CdUsuario).HasColumnName("cd_usuario");

                entity.Property(e => e.DtHrFinalizacao).HasColumnName("dt_hr_finalizacao");

                entity.Property(e => e.DtHrInicio).HasColumnName("dt_hr_inicio");

                entity.Property(e => e.NrOs).HasColumnName("nr_os");

                entity.Property(e => e.NrPedidoCompra).HasColumnName("nr_pedido_compra");

                entity.HasOne(d => d.NrPedidoCompraNavigation)
                    .WithMany(p => p.AuditorEstoqueC)
                    .HasForeignKey(d => d.NrPedidoCompra)
                    .HasConstraintName("fk_auditorc_pedidoc");

                entity.HasOne(d => d.OrcamentoC)
                    .WithMany(p => p.AuditorEstoqueC)
                    .HasForeignKey(d => new { d.CdFilial, d.NrOs })
                    .HasConstraintName("fk_auditorc_orcamentoc");
            });

            modelBuilder.Entity<AuditorEstoqueI>(entity =>
            {
                entity.HasKey(e => new { e.CdFilial, e.IdAuditorC, e.NrSequencial });

                entity.ToTable("auditor_estoque_i");

                entity.Property(e => e.CdFilial).HasColumnName("cd_filial");

                entity.Property(e => e.IdAuditorC).HasColumnName("id_auditor_c");

                entity.Property(e => e.NrSequencial).HasColumnName("nr_sequencial");

                entity.Property(e => e.CdProduto)
                    .HasColumnName("cd_produto")
                    .HasMaxLength(15);

                entity.Property(e => e.CdUsuario).HasColumnName("cd_usuario");

                entity.Property(e => e.QtAtual)
                    .HasColumnName("qt_atual")
                    .HasColumnType("numeric(15,4)");

                entity.Property(e => e.QtDif)
                    .HasColumnName("qt_dif")
                    .HasColumnType("numeric(15,4)");

                entity.HasOne(d => d.AuditorEstoqueC)
                    .WithMany(p => p.AuditorEstoqueI)
                    .HasForeignKey(d => new { d.CdFilial, d.IdAuditorC })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_auditori_auditorc");
            });

            modelBuilder.Entity<AutorizaXml>(entity =>
            {
                entity.HasKey(e => e.Cnpj);

                entity.ToTable("autoriza_xml");

                entity.Property(e => e.Cnpj)
                    .HasColumnName("cnpj")
                    .HasMaxLength(18)
                    .ValueGeneratedNever();

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasColumnName("descricao")
                    .HasMaxLength(120);
            });

            modelBuilder.Entity<Banco>(entity =>
            {
                entity.HasKey(e => e.CdBanco);

                entity.ToTable("banco");

                entity.Property(e => e.CdBanco)
                    .HasColumnName("cd_banco")
                    .ValueGeneratedNever();

                entity.Property(e => e.DtAtz)
                    .HasColumnName("dt_atz")
                    .HasColumnType("date")
                    .HasDefaultValueSql("CURRENT_DATE");

                entity.Property(e => e.NmArqBoleto)
                    .HasColumnName("nm_arq_boleto")
                    .HasMaxLength(20);

                entity.Property(e => e.NmBanco)
                    .IsRequired()
                    .HasColumnName("nm_banco")
                    .HasMaxLength(80);
            });

            modelBuilder.Entity<BeneficioFiscal>(entity =>
            {
                entity.ToTable("beneficio_fiscal");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CodAjur)
                    .HasColumnName("cod_ajur")
                    .HasMaxLength(10);

                entity.Property(e => e.DescAjur)
                    .HasColumnName("desc_ajur")
                    .HasMaxLength(500);

                entity.Property(e => e.DtFim)
                    .HasColumnName("dt_fim")
                    .HasColumnType("date");

                entity.Property(e => e.DtIni)
                    .HasColumnName("dt_ini")
                    .HasColumnType("date");
            });

            modelBuilder.Entity<Caixa>(entity =>
            {
                entity.HasKey(e => new { e.CdFilial, e.CdCaixa });

                entity.ToTable("caixa");

                entity.Property(e => e.CdFilial).HasColumnName("cd_filial");

                entity.Property(e => e.CdCaixa).HasColumnName("cd_caixa");

                entity.Property(e => e.Agencia)
                    .HasColumnName("agencia")
                    .HasMaxLength(10);

                entity.Property(e => e.CdContaContabil).HasColumnName("cd_conta_contabil");

                entity.Property(e => e.CdUsr).HasColumnName("cd_usr");

                entity.Property(e => e.Cidade)
                    .HasColumnName("cidade")
                    .HasMaxLength(30);

                entity.Property(e => e.Conta)
                    .HasColumnName("conta")
                    .HasMaxLength(15);

                entity.Property(e => e.DtAtz)
                    .HasColumnName("dt_atz")
                    .HasColumnType("date")
                    .HasDefaultValueSql("CURRENT_DATE");

                entity.Property(e => e.EMail)
                    .HasColumnName("e_mail")
                    .HasMaxLength(80);

                entity.Property(e => e.Endereco)
                    .HasColumnName("endereco")
                    .HasMaxLength(40);

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasMaxLength(2);

                entity.Property(e => e.Fax)
                    .HasColumnName("fax")
                    .HasMaxLength(15);

                entity.Property(e => e.FlTipo)
                    .IsRequired()
                    .HasColumnName("fl_tipo")
                    .HasMaxLength(1);

                entity.Property(e => e.Fone)
                    .HasColumnName("fone")
                    .HasMaxLength(15);

                entity.Property(e => e.Gerente)
                    .HasColumnName("gerente")
                    .HasMaxLength(40);

                entity.Property(e => e.Http)
                    .HasColumnName("http")
                    .HasMaxLength(80);

                entity.Property(e => e.Limite)
                    .HasColumnName("limite")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.NmCaixa)
                    .IsRequired()
                    .HasColumnName("nm_caixa")
                    .HasMaxLength(50);

                entity.Property(e => e.SaldoAnterior)
                    .HasColumnName("saldo_anterior")
                    .HasColumnType("numeric(18,4)");

                entity.HasOne(d => d.CdContaContabilNavigation)
                    .WithMany(p => p.Caixa)
                    .HasForeignKey(d => d.CdContaContabil)
                    .HasConstraintName("fk_caixa_conta_contabil");
            });

            modelBuilder.Entity<Cargo>(entity =>
            {
                entity.HasKey(e => new { e.CdCargo, e.CdFilial });

                entity.ToTable("cargo");

                entity.Property(e => e.CdCargo).HasColumnName("cd_cargo");

                entity.Property(e => e.CdFilial).HasColumnName("cd_filial");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasColumnName("descricao")
                    .HasMaxLength(40);

                entity.Property(e => e.DtAtz)
                    .HasColumnName("dt_atz")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-10-26'::date");

                entity.Property(e => e.FlComissaoTotal)
                    .HasColumnName("fl_comissao_total")
                    .HasMaxLength(1);

                entity.Property(e => e.FlLiberaLimite).HasColumnName("fl_libera_limite");

                entity.HasOne(d => d.CdFilialNavigation)
                    .WithMany(p => p.Cargo)
                    .HasForeignKey(d => d.CdFilial)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("filial_cargo_fk");
            });

            modelBuilder.Entity<CartaCorrecao>(entity =>
            {
                entity.HasKey(e => e.IdGeral);

                entity.ToTable("carta_correcao");

                entity.HasIndex(e => new { e.IdNf, e.FlEntSai, e.Sequencia })
                    .HasName("unq1_carta_correcao")
                    .IsUnique();

                entity.Property(e => e.IdGeral)
                    .HasColumnName("id_geral")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdFilial).HasColumnName("cd_filial");

                entity.Property(e => e.ChaveAcessoNfe)
                    .HasColumnName("chave_acesso_nfe")
                    .HasMaxLength(44);

                entity.Property(e => e.Correcao).HasColumnName("correcao");

                entity.Property(e => e.DtAutorizacao)
                    .HasColumnName("dt_autorizacao")
                    .HasColumnType("date");

                entity.Property(e => e.FlEntSai)
                    .IsRequired()
                    .HasColumnName("fl_ent_sai")
                    .HasMaxLength(1);

                entity.Property(e => e.HrAutorizacao)
                    .HasColumnName("hr_autorizacao")
                    .HasColumnType("time without time zone");

                entity.Property(e => e.IdNf).HasColumnName("id_nf");

                entity.Property(e => e.Protocolo)
                    .HasColumnName("protocolo")
                    .HasMaxLength(20);

                entity.Property(e => e.Sequencia).HasColumnName("sequencia");

                entity.Property(e => e.Xml).HasColumnName("xml");
            });

            modelBuilder.Entity<CartaCorrecaoHist>(entity =>
            {
                entity.HasKey(e => e.IdGeral);

                entity.ToTable("carta_correcao_hist");

                entity.HasIndex(e => new { e.IdCartaCorrecao, e.NmTabela, e.NmCampo, e.CdMensagem, e.NrSequenciaItem })
                    .HasName("unq1_carta_correcao_hist")
                    .IsUnique();

                entity.Property(e => e.IdGeral)
                    .HasColumnName("id_geral")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdMensagem)
                    .HasColumnName("cd_mensagem")
                    .HasMaxLength(4);

                entity.Property(e => e.ContAnt).HasColumnName("cont_ant");

                entity.Property(e => e.ContAtu).HasColumnName("cont_atu");

                entity.Property(e => e.IdCartaCorrecao).HasColumnName("id_carta_correcao");

                entity.Property(e => e.NmCampo)
                    .HasColumnName("nm_campo")
                    .HasMaxLength(20);

                entity.Property(e => e.NmTabela)
                    .HasColumnName("nm_tabela")
                    .HasMaxLength(20);

                entity.Property(e => e.NrSequenciaItem)
                    .HasColumnName("nr_sequencia_item")
                    .HasMaxLength(4);

                entity.HasOne(d => d.IdCartaCorrecaoNavigation)
                    .WithMany(p => p.CartaCorrecaoHist)
                    .HasForeignKey(d => d.IdCartaCorrecao)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_carta_correcao");
            });

            modelBuilder.Entity<Cest>(entity =>
            {
                entity.HasKey(e => e.CdCest);

                entity.ToTable("cest");

                entity.Property(e => e.CdCest)
                    .HasColumnName("cd_cest")
                    .ValueGeneratedNever();

                entity.Property(e => e.Cest1)
                    .IsRequired()
                    .HasColumnName("cest")
                    .HasMaxLength(7);

                entity.Property(e => e.DescricaoCest)
                    .IsRequired()
                    .HasColumnName("descricao_cest")
                    .HasMaxLength(999);
            });

            modelBuilder.Entity<Cfop>(entity =>
            {
                entity.HasKey(e => e.Cfop1);

                entity.ToTable("cfop");

                entity.Property(e => e.Cfop1)
                    .HasColumnName("cfop")
                    .HasMaxLength(5)
                    .ValueGeneratedNever();

                entity.Property(e => e.Aplicacao).HasColumnName("aplicacao");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasColumnName("descricao")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<CfopRegra>(entity =>
            {
                entity.HasKey(e => e.CdCfopRegra);

                entity.ToTable("cfop_regra");

                entity.Property(e => e.CdCfopRegra)
                    .HasColumnName("cd_cfop_regra")
                    .ValueGeneratedNever();

                entity.Property(e => e.NmCfopRegra)
                    .IsRequired()
                    .HasColumnName("nm_cfop_regra")
                    .HasMaxLength(80);
            });

            modelBuilder.Entity<Cidade>(entity =>
            {
                entity.HasKey(e => e.CdCidade);

                entity.ToTable("cidade");

                entity.HasIndex(e => e.CdCidade)
                    .HasName("ind_cd_cidade");

                entity.HasIndex(e => e.NmCidade)
                    .HasName("ind_nm_cidade");

                entity.Property(e => e.CdCidade)
                    .HasColumnName("cd_cidade")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdFilial).HasColumnName("cd_filial");

                entity.Property(e => e.CdIbge).HasColumnName("cd_ibge");

                entity.Property(e => e.CdPais).HasColumnName("cd_pais");

                entity.Property(e => e.CdRegiao).HasColumnName("cd_regiao");

                entity.Property(e => e.DtAtz)
                    .HasColumnName("dt_atz")
                    .HasColumnType("date")
                    .HasDefaultValueSql("CURRENT_DATE");

                entity.Property(e => e.NmCidade)
                    .IsRequired()
                    .HasColumnName("nm_cidade")
                    .HasMaxLength(40);

                entity.Property(e => e.Uf)
                    .IsRequired()
                    .HasColumnName("uf")
                    .HasMaxLength(3);

                entity.HasOne(d => d.CdRegiaoNavigation)
                    .WithMany(p => p.Cidade)
                    .HasForeignKey(d => d.CdRegiao)
                    .HasConstraintName("cidade_cd_regiao_fkey");
            });

            modelBuilder.Entity<ClassListaServico>(entity =>
            {
                entity.HasKey(e => e.CdListaServico);

                entity.ToTable("class_lista_servico");

                entity.Property(e => e.CdListaServico)
                    .HasColumnName("cd_lista_servico")
                    .HasMaxLength(4)
                    .ValueGeneratedNever();

                entity.Property(e => e.NmListaServico)
                    .HasColumnName("nm_lista_servico")
                    .HasMaxLength(1000);
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => new { e.CdFilial, e.CdCliente });

                entity.ToTable("cliente");

                entity.HasIndex(e => e.CdCidade)
                    .HasName("ind_cliecidade");

                entity.HasIndex(e => e.CdCliente)
                    .HasName("unq_cliente_codigo")
                    .IsUnique();

                entity.HasIndex(e => e.CgcCpf)
                    .HasName("ind_cliente_cgc_cpf");

                entity.HasIndex(e => e.NmClifor)
                    .HasName("ind_nm_cliente");

                entity.Property(e => e.CdFilial).HasColumnName("cd_filial");

                entity.Property(e => e.CdCliente).HasColumnName("cd_cliente");

                entity.Property(e => e.Bairro)
                    .HasColumnName("bairro")
                    .HasMaxLength(30);

                entity.Property(e => e.Cargo)
                    .HasColumnName("cargo")
                    .HasMaxLength(15);

                entity.Property(e => e.CargoConjuge)
                    .HasColumnName("cargo_conjuge")
                    .HasMaxLength(15);

                entity.Property(e => e.CdCidade).HasColumnName("cd_cidade");

                entity.Property(e => e.CdContaContabil).HasColumnName("cd_conta_contabil");

                entity.Property(e => e.CdFornecedor).HasColumnName("cd_fornecedor");

                entity.Property(e => e.CdFuncProtestou).HasColumnName("cd_func_protestou");

                entity.Property(e => e.CdGrupoCliente).HasColumnName("cd_grupo_cliente");

                entity.Property(e => e.CdVendedor).HasColumnName("cd_vendedor");

                entity.Property(e => e.Celular)
                    .HasColumnName("celular")
                    .HasMaxLength(20);

                entity.Property(e => e.Cep)
                    .HasColumnName("cep")
                    .HasMaxLength(10);

                entity.Property(e => e.CgcCpf)
                    .HasColumnName("cgc_cpf")
                    .HasMaxLength(18);

                entity.Property(e => e.CodFuncBloqueou).HasColumnName("cod_func_bloqueou");

                entity.Property(e => e.Complemento)
                    .HasColumnName("complemento")
                    .HasMaxLength(20);

                entity.Property(e => e.CpfConjuge)
                    .HasColumnName("cpf_conjuge")
                    .HasMaxLength(18);

                entity.Property(e => e.DtAdmissao)
                    .HasColumnName("dt_admissao")
                    .HasColumnType("date");

                entity.Property(e => e.DtAdmissaoConjuge)
                    .HasColumnName("dt_admissao_conjuge")
                    .HasColumnType("date");

                entity.Property(e => e.DtAniversario)
                    .HasColumnName("dt_aniversario")
                    .HasColumnType("date");

                entity.Property(e => e.DtAtz)
                    .HasColumnName("dt_atz")
                    .HasColumnType("date")
                    .HasDefaultValueSql("CURRENT_DATE");

                entity.Property(e => e.DtCadastro)
                    .HasColumnName("dt_cadastro")
                    .HasColumnType("date")
                    .HasDefaultValueSql("CURRENT_DATE");

                entity.Property(e => e.DtNascConj)
                    .HasColumnName("dt_nasc_conj")
                    .HasColumnType("date");

                entity.Property(e => e.DtSpc)
                    .HasColumnName("dt_spc")
                    .HasColumnType("date");

                entity.Property(e => e.EMail)
                    .HasColumnName("e_mail")
                    .HasMaxLength(200);

                entity.Property(e => e.Endereco)
                    .HasColumnName("endereco")
                    .HasMaxLength(80);

                entity.Property(e => e.Fax)
                    .HasColumnName("fax")
                    .HasMaxLength(20);

                entity.Property(e => e.FlAgricultor)
                    .HasColumnName("fl_agricultor")
                    .HasMaxLength(1);

                entity.Property(e => e.FlAtivo)
                    .HasColumnName("fl_ativo")
                    .HasMaxLength(1);

                entity.Property(e => e.FlBloqueado).HasColumnName("fl_bloqueado");

                entity.Property(e => e.FlClienteRedeUniagro)
                    .HasColumnName("fl_cliente_rede_uniagro")
                    .HasMaxLength(1);

                entity.Property(e => e.FlClifor)
                    .HasColumnName("fl_clifor")
                    .HasMaxLength(1);

                entity.Property(e => e.FlContNcont).HasColumnName("fl_cont_ncont");

                entity.Property(e => e.FlEsLcilindrico)
                    .HasColumnName("fl_es_lcilindrico")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.FlEsLeixo)
                    .HasColumnName("fl_es_leixo")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.FlEsLesferico)
                    .HasColumnName("fl_es_lesferico")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.FlEsPcilindrico)
                    .HasColumnName("fl_es_pcilindrico")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.FlEsPeixo)
                    .HasColumnName("fl_es_peixo")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.FlEsPesferico)
                    .HasColumnName("fl_es_pesferico")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.FlExibeObs).HasColumnName("fl_exibe_obs");

                entity.Property(e => e.FlImprimirFatura)
                    .HasColumnName("fl_imprimir_fatura")
                    .HasMaxLength(1);

                entity.Property(e => e.FlOdLcilindrico)
                    .HasColumnName("fl_od_lcilindrico")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.FlOdLeixo)
                    .HasColumnName("fl_od_leixo")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.FlOdLesferico)
                    .HasColumnName("fl_od_lesferico")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.FlOdPcilindrico)
                    .HasColumnName("fl_od_pcilindrico")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.FlOdPeixo)
                    .HasColumnName("fl_od_peixo")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.FlOdPesferico)
                    .HasColumnName("fl_od_pesferico")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.FlProtestado).HasColumnName("fl_protestado");

                entity.Property(e => e.FlSimples).HasColumnName("fl_simples");

                entity.Property(e => e.FlSpc).HasColumnName("fl_spc");

                entity.Property(e => e.Fone)
                    .HasColumnName("fone")
                    .HasMaxLength(20);

                entity.Property(e => e.FoneCom)
                    .HasColumnName("fone_com")
                    .HasMaxLength(20);

                entity.Property(e => e.FoneTrabalho)
                    .HasColumnName("fone_trabalho")
                    .HasMaxLength(20);

                entity.Property(e => e.FoneTrabalhoConjuge)
                    .HasColumnName("fone_trabalho_conjuge")
                    .HasMaxLength(15);

                entity.Property(e => e.HashClienteD2)
                    .HasColumnName("hash_cliente_d2")
                    .HasMaxLength(70);

                entity.Property(e => e.Im)
                    .HasColumnName("im")
                    .HasMaxLength(10);

                entity.Property(e => e.Inscricao)
                    .HasColumnName("inscricao")
                    .HasMaxLength(18);

                entity.Property(e => e.InscricaoSuframa)
                    .HasColumnName("inscricao_suframa")
                    .HasMaxLength(9);

                entity.Property(e => e.LimiteCredito)
                    .HasColumnName("limite_credito")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.LocalNasc)
                    .HasColumnName("local_nasc")
                    .HasMaxLength(30);

                entity.Property(e => e.LocalTrabalho)
                    .HasColumnName("local_trabalho")
                    .HasMaxLength(40);

                entity.Property(e => e.LocalTrabalhoConjuge)
                    .HasColumnName("local_trabalho_conjuge")
                    .HasMaxLength(20);

                entity.Property(e => e.MotivoBloqueio).HasColumnName("motivo_bloqueio");

                entity.Property(e => e.MotivoProtesto).HasColumnName("motivo_protesto");

                entity.Property(e => e.NmClifor)
                    .IsRequired()
                    .HasColumnName("nm_clifor")
                    .HasMaxLength(80);

                entity.Property(e => e.NmConjuge)
                    .HasColumnName("nm_conjuge")
                    .HasMaxLength(75);

                entity.Property(e => e.NmFantasia)
                    .HasColumnName("nm_fantasia")
                    .HasMaxLength(80);

                entity.Property(e => e.NmMae)
                    .HasColumnName("nm_mae")
                    .HasMaxLength(80);

                entity.Property(e => e.NmPai)
                    .HasColumnName("nm_pai")
                    .HasMaxLength(80);

                entity.Property(e => e.Numero)
                    .HasColumnName("numero")
                    .HasMaxLength(50);

                entity.Property(e => e.ObsConj).HasColumnName("obs_conj");

                entity.Property(e => e.ObservacaoClifor).HasColumnName("observacao_clifor");

                entity.Property(e => e.PessoaContato)
                    .HasColumnName("pessoa_contato")
                    .HasMaxLength(40);

                entity.Property(e => e.Ref1)
                    .HasColumnName("ref_1")
                    .HasMaxLength(20);

                entity.Property(e => e.Ref2)
                    .HasColumnName("ref_2")
                    .HasMaxLength(20);

                entity.Property(e => e.Ref3)
                    .HasColumnName("ref_3")
                    .HasMaxLength(20);

                entity.Property(e => e.Ref4)
                    .HasColumnName("ref_4")
                    .HasMaxLength(20);

                entity.Property(e => e.RendaConjuge)
                    .HasColumnName("renda_conjuge")
                    .HasColumnType("numeric(15,2)");

                entity.Property(e => e.RgConjuge)
                    .HasColumnName("rg_conjuge")
                    .HasMaxLength(18);

                entity.Property(e => e.Salario)
                    .HasColumnName("salario")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.TelRef1)
                    .HasColumnName("tel_ref_1")
                    .HasMaxLength(15);

                entity.Property(e => e.TelRef2)
                    .HasColumnName("tel_ref_2")
                    .HasMaxLength(15);

                entity.Property(e => e.TelRef3)
                    .HasColumnName("tel_ref_3")
                    .HasMaxLength(20);

                entity.Property(e => e.TelRef4)
                    .HasColumnName("tel_ref_4")
                    .HasMaxLength(20);

                entity.Property(e => e.Tipo)
                    .HasColumnName("tipo")
                    .HasMaxLength(48);

                entity.Property(e => e.TpPessoa)
                    .HasColumnName("tp_pessoa")
                    .HasMaxLength(1);

                entity.Property(e => e.TrabConj)
                    .HasColumnName("trab_conj")
                    .HasMaxLength(40);

                entity.HasOne(d => d.CdContaContabilNavigation)
                    .WithMany(p => p.Cliente)
                    .HasForeignKey(d => d.CdContaContabil)
                    .HasConstraintName("fk_cliente_conta_contabil");

                entity.HasOne(d => d.CdFilialNavigation)
                    .WithMany(p => p.Cliente)
                    .HasForeignKey(d => d.CdFilial)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_cliefilial");

                entity.HasOne(d => d.Cd)
                    .WithMany(p => p.Cliente)
                    .HasForeignKey(d => new { d.CdFilial, d.CdVendedor })
                    .HasConstraintName("fk_cliefuncionario");
            });

            modelBuilder.Entity<ClienteContato>(entity =>
            {
                entity.HasKey(e => new { e.CdCliente, e.CdContato });

                entity.ToTable("cliente_contato");

                entity.Property(e => e.CdCliente).HasColumnName("cd_cliente");

                entity.Property(e => e.CdContato).HasColumnName("cd_contato");

                entity.Property(e => e.CdFilial).HasColumnName("cd_filial");

                entity.HasOne(d => d.CdContatoNavigation)
                    .WithMany(p => p.ClienteContato)
                    .HasForeignKey(d => d.CdContato)
                    .HasConstraintName("fk_cliente_contato_contato");

                entity.HasOne(d => d.Cd)
                    .WithMany(p => p.ClienteContato)
                    .HasForeignKey(d => new { d.CdFilial, d.CdCliente })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_cliente_contato");
            });

            modelBuilder.Entity<ClienteEntrega>(entity =>
            {
                entity.HasKey(e => e.IdGeral);

                entity.ToTable("cliente_entrega");

                entity.HasIndex(e => new { e.CdCliente, e.NrSequencia })
                    .HasName("unq1_cliente_entrega")
                    .IsUnique();

                entity.Property(e => e.IdGeral)
                    .HasColumnName("id_geral")
                    .ValueGeneratedNever();

                entity.Property(e => e.Bairro)
                    .HasColumnName("bairro")
                    .HasMaxLength(80);

                entity.Property(e => e.CdCidade).HasColumnName("cd_cidade");

                entity.Property(e => e.CdCliente).HasColumnName("cd_cliente");

                entity.Property(e => e.Celular)
                    .HasColumnName("celular")
                    .HasMaxLength(20);

                entity.Property(e => e.Cep)
                    .HasColumnName("cep")
                    .HasMaxLength(10);

                entity.Property(e => e.EMail)
                    .HasColumnName("e_mail")
                    .HasMaxLength(80);

                entity.Property(e => e.EnderecoComplemento)
                    .HasColumnName("endereco_complemento")
                    .HasMaxLength(20);

                entity.Property(e => e.EnderecoLogradouro)
                    .HasColumnName("endereco_logradouro")
                    .HasMaxLength(80);

                entity.Property(e => e.EnderecoNumero)
                    .HasColumnName("endereco_numero")
                    .HasMaxLength(80);

                entity.Property(e => e.Fax)
                    .HasColumnName("fax")
                    .HasMaxLength(20);

                entity.Property(e => e.NmLocal)
                    .IsRequired()
                    .HasColumnName("nm_local")
                    .HasMaxLength(80);

                entity.Property(e => e.NrAutorizacao)
                    .HasColumnName("nr_autorizacao")
                    .HasMaxLength(50);

                entity.Property(e => e.NrSequencia).HasColumnName("nr_sequencia");

                entity.Property(e => e.Obs).HasColumnName("obs");

                entity.Property(e => e.Telefone)
                    .HasColumnName("telefone")
                    .HasMaxLength(20);

                entity.HasOne(d => d.CdCidadeNavigation)
                    .WithMany(p => p.ClienteEntrega)
                    .HasForeignKey(d => d.CdCidade)
                    .HasConstraintName("fk_cliente_entrega_cidade");

                entity.HasOne(d => d.CdClienteNavigation)
                    .WithMany(p => p.ClienteEntrega)
                    .HasPrincipalKey(p => p.CdCliente)
                    .HasForeignKey(d => d.CdCliente)
                    .HasConstraintName("fk_cliente_entrega_cliente");
            });

            modelBuilder.Entity<ClienteGrupo>(entity =>
            {
                entity.HasKey(e => e.CdGrupoCliente);

                entity.ToTable("cliente_grupo");

                entity.HasIndex(e => e.NmGrupoCliente)
                    .HasName("idx_nm_grupo_cliente")
                    .IsUnique();

                entity.Property(e => e.CdGrupoCliente)
                    .HasColumnName("cd_grupo_cliente")
                    .ValueGeneratedNever();

                entity.Property(e => e.NmGrupoCliente)
                    .IsRequired()
                    .HasColumnName("nm_grupo_cliente")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<ClientePropriedade>(entity =>
            {
                entity.HasKey(e => new { e.CdFilial, e.CdCliente, e.CdPropriedade });

                entity.ToTable("cliente_propriedade");

                entity.Property(e => e.CdFilial).HasColumnName("cd_filial");

                entity.Property(e => e.CdCliente).HasColumnName("cd_cliente");

                entity.Property(e => e.CdPropriedade).HasColumnName("cd_propriedade");

                entity.HasOne(d => d.CdPropriedadeNavigation)
                    .WithMany(p => p.ClientePropriedade)
                    .HasForeignKey(d => d.CdPropriedade)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_cliente_propriedade_propried");

                entity.HasOne(d => d.Cd)
                    .WithMany(p => p.ClientePropriedade)
                    .HasForeignKey(d => new { d.CdFilial, d.CdCliente })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_cliente_propriedade_cliente");
            });

            modelBuilder.Entity<ClienteResumoFinanceiro>(entity =>
            {
                entity.HasKey(e => new { e.CdCliente, e.CdFilial });

                entity.ToTable("cliente_resumo_financeiro");

                entity.Property(e => e.CdCliente).HasColumnName("cd_cliente");

                entity.Property(e => e.CdFilial).HasColumnName("cd_filial");

                entity.Property(e => e.DtAtz)
                    .HasColumnName("dt_atz")
                    .HasColumnType("date");

                entity.Property(e => e.DtUltimaCompra)
                    .HasColumnName("dt_ultima_compra")
                    .HasColumnType("date");

                entity.Property(e => e.VlAVencer)
                    .HasColumnName("vl_a_vencer")
                    .HasColumnType("numeric(15,2)");

                entity.Property(e => e.VlAtrasado)
                    .HasColumnName("vl_atrasado")
                    .HasColumnType("numeric(15,2)");

                entity.Property(e => e.VlChequePre)
                    .HasColumnName("vl_cheque_pre")
                    .HasColumnType("numeric(15,2)");

                entity.Property(e => e.VlLimite)
                    .HasColumnName("vl_limite")
                    .HasColumnType("numeric(15,2)");

                entity.HasOne(d => d.CdClienteNavigation)
                    .WithMany(p => p.ClienteResumoFinanceiro)
                    .HasPrincipalKey(p => p.CdCliente)
                    .HasForeignKey(d => d.CdCliente)
                    .HasConstraintName("fk_cliente_resumo_financeiro_cl");

                entity.HasOne(d => d.CdFilialNavigation)
                    .WithMany(p => p.ClienteResumoFinanceiro)
                    .HasForeignKey(d => d.CdFilial)
                    .HasConstraintName("fk_cliente_resumo_financeiro_fi");
            });

            modelBuilder.Entity<ClienteResumoFinanceiroLog>(entity =>
            {
                entity.HasKey(e => e.CdFilial);

                entity.ToTable("cliente_resumo_financeiro_log");

                entity.Property(e => e.CdFilial)
                    .HasColumnName("cd_filial")
                    .ValueGeneratedNever();

                entity.Property(e => e.DtAtz).HasColumnName("dt_atz");

                entity.Property(e => e.FlStatus).HasColumnName("fl_status");

                entity.HasOne(d => d.CdFilialNavigation)
                    .WithOne(p => p.ClienteResumoFinanceiroLog)
                    .HasForeignKey<ClienteResumoFinanceiroLog>(d => d.CdFilial)
                    .HasConstraintName("fk_cliente_resumo_log_filial");
            });

            modelBuilder.Entity<Clieveic>(entity =>
            {
                entity.HasKey(e => new { e.CdFilial, e.CdCliente, e.PlacaVeiculo });

                entity.ToTable("clieveic");

                entity.HasIndex(e => e.PlacaVeiculo)
                    .HasName("idx_placa");

                entity.Property(e => e.CdFilial).HasColumnName("cd_filial");

                entity.Property(e => e.CdCliente).HasColumnName("cd_cliente");

                entity.Property(e => e.PlacaVeiculo)
                    .HasColumnName("placa_veiculo")
                    .HasMaxLength(8);

                entity.Property(e => e.AnoFabricacao).HasColumnName("ano_fabricacao");

                entity.Property(e => e.CdMontadora).HasColumnName("cd_montadora");

                entity.Property(e => e.CdVeiculo).HasColumnName("cd_veiculo");

                entity.Property(e => e.Cor)
                    .HasColumnName("cor")
                    .HasMaxLength(50);

                entity.Property(e => e.DtAtz)
                    .HasColumnName("dt_atz")
                    .HasColumnType("date")
                    .HasDefaultValueSql("CURRENT_DATE");

                entity.Property(e => e.FlProprietario).HasColumnName("fl_proprietario");

                entity.Property(e => e.Motor)
                    .HasColumnName("motor")
                    .HasMaxLength(20);

                entity.Property(e => e.NmVeiculo)
                    .IsRequired()
                    .HasColumnName("nm_veiculo")
                    .HasMaxLength(40);

                entity.Property(e => e.NrChassi)
                    .HasColumnName("nr_chassi")
                    .HasMaxLength(30);

                entity.Property(e => e.NrFrota)
                    .HasColumnName("nr_frota")
                    .HasMaxLength(11);

                entity.Property(e => e.Obs).HasColumnName("obs");

                entity.Property(e => e.Renavan)
                    .HasColumnName("renavan")
                    .HasMaxLength(11);

                entity.HasOne(d => d.Cd)
                    .WithMany(p => p.Clieveic)
                    .HasForeignKey(d => new { d.CdFilial, d.CdCliente })
                    .HasConstraintName("fk_delcliente");

                entity.HasOne(d => d.CdNavigation)
                    .WithMany(p => p.Clieveic)
                    .HasForeignKey(d => new { d.CdFilial, d.CdMontadora })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_veiccliente");
            });

            modelBuilder.Entity<CobBordero>(entity =>
            {
                entity.HasKey(e => e.CdBordero);

                entity.ToTable("cob_bordero");

                entity.HasIndex(e => e.DtCadastro)
                    .HasName("cob_bordero_idx");

                entity.Property(e => e.CdBordero)
                    .HasColumnName("cd_bordero")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdConvenio).HasColumnName("cd_convenio");

                entity.Property(e => e.DtCadastro)
                    .HasColumnName("dt_cadastro")
                    .HasColumnType("date");

                entity.Property(e => e.DtEnvioRemessa)
                    .HasColumnName("dt_envio_remessa")
                    .HasColumnType("date");

                entity.HasOne(d => d.CdConvenioNavigation)
                    .WithMany(p => p.CobBordero)
                    .HasForeignKey(d => d.CdConvenio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_cob_bordero_convenio");
            });

            modelBuilder.Entity<CobBorderoParcela>(entity =>
            {
                entity.HasKey(e => new { e.IdParcela, e.CdBordero });

                entity.ToTable("cob_bordero_parcela");

                entity.Property(e => e.IdParcela).HasColumnName("id_parcela");

                entity.Property(e => e.CdBordero).HasColumnName("cd_bordero");

                entity.HasOne(d => d.CdBorderoNavigation)
                    .WithMany(p => p.CobBorderoParcela)
                    .HasForeignKey(d => d.CdBordero)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_cob_bordero_parcela");

                entity.HasOne(d => d.IdParcelaNavigation)
                    .WithMany(p => p.CobBorderoParcela)
                    .HasForeignKey(d => d.IdParcela)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_cob_bordero_parcela_bor");
            });

            modelBuilder.Entity<CobConvenio>(entity =>
            {
                entity.HasKey(e => e.CdConvenio);

                entity.ToTable("cob_convenio");

                entity.Property(e => e.CdConvenio)
                    .HasColumnName("cd_convenio")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdCaixa).HasColumnName("cd_caixa");

                entity.Property(e => e.CdInstrucao1)
                    .HasColumnName("cd_instrucao1")
                    .HasMaxLength(2);

                entity.Property(e => e.CdInstrucao2)
                    .HasColumnName("cd_instrucao2")
                    .HasMaxLength(2);

                entity.Property(e => e.Diretorio)
                    .HasColumnName("diretorio")
                    .HasMaxLength(150);

                entity.Property(e => e.DiretorioRemessa)
                    .HasColumnName("diretorio_remessa")
                    .HasMaxLength(200);

                entity.Property(e => e.DiretorioRetorno)
                    .HasColumnName("diretorio_retorno")
                    .HasMaxLength(200);

                entity.Property(e => e.FlAceite)
                    .IsRequired()
                    .HasColumnName("fl_aceite")
                    .HasMaxLength(1);

                entity.Property(e => e.FlDebAutomatico)
                    .HasColumnName("fl_deb_automatico")
                    .HasMaxLength(1);

                entity.Property(e => e.FlEmissor)
                    .IsRequired()
                    .HasColumnName("fl_emissor")
                    .HasMaxLength(1);

                entity.Property(e => e.FlNrNfs)
                    .HasColumnName("fl_nr_nfs")
                    .HasMaxLength(1);

                entity.Property(e => e.FlPadraoRemessa)
                    .HasColumnName("fl_padrao_remessa")
                    .HasMaxLength(1);

                entity.Property(e => e.FlProtesto)
                    .IsRequired()
                    .HasColumnName("fl_protesto")
                    .HasMaxLength(1);

                entity.Property(e => e.FlRemessa)
                    .IsRequired()
                    .HasColumnName("fl_remessa")
                    .HasMaxLength(1);

                entity.Property(e => e.FlRetornoRemessa)
                    .IsRequired()
                    .HasColumnName("fl_retorno_remessa")
                    .HasMaxLength(1);

                entity.Property(e => e.FlSincNrSeq).HasColumnName("fl_sinc_nr_seq");

                entity.Property(e => e.LayoutBoleto)
                    .HasColumnName("layout_boleto")
                    .HasMaxLength(200);

                entity.Property(e => e.LocalPagamento)
                    .IsRequired()
                    .HasColumnName("local_pagamento")
                    .HasMaxLength(300);

                entity.Property(e => e.Mensagem).HasColumnName("mensagem");

                entity.Property(e => e.MensagemProtesto).HasColumnName("mensagem_protesto");

                entity.Property(e => e.NmAgencia)
                    .HasColumnName("nm_agencia")
                    .HasMaxLength(80);

                entity.Property(e => e.NmBanco)
                    .HasColumnName("nm_banco")
                    .HasMaxLength(80);

                entity.Property(e => e.NmConvenio)
                    .IsRequired()
                    .HasColumnName("nm_convenio")
                    .HasMaxLength(40);

                entity.Property(e => e.NrAgencia)
                    .HasColumnName("nr_agencia")
                    .HasMaxLength(10);

                entity.Property(e => e.NrBanco).HasColumnName("nr_banco");

                entity.Property(e => e.NrConta)
                    .HasColumnName("nr_conta")
                    .HasMaxLength(10);

                entity.Property(e => e.NrConvenio)
                    .IsRequired()
                    .HasColumnName("nr_convenio")
                    .HasMaxLength(15);

                entity.Property(e => e.NrDiasBaixa).HasColumnName("nr_dias_baixa");

                entity.Property(e => e.NrDiasProtesto).HasColumnName("nr_dias_protesto");

                entity.Property(e => e.NrDvAgencia)
                    .HasColumnName("nr_dv_agencia")
                    .HasMaxLength(2);

                entity.Property(e => e.NrDvBanco)
                    .HasColumnName("nr_dv_banco")
                    .HasMaxLength(2);

                entity.Property(e => e.NrDvConta)
                    .HasColumnName("nr_dv_conta")
                    .HasMaxLength(2);

                entity.Property(e => e.NrSequencial).HasColumnName("nr_sequencial");

                entity.Property(e => e.NrUltimaRemessa).HasColumnName("nr_ultima_remessa");

                entity.Property(e => e.OpConta)
                    .HasColumnName("op_conta")
                    .HasColumnType("numeric(3,0)");

                entity.Property(e => e.SgEspecie)
                    .HasColumnName("sg_especie")
                    .HasMaxLength(3);

                entity.Property(e => e.TpCobranca)
                    .HasColumnName("tp_cobranca")
                    .HasMaxLength(3);

                entity.Property(e => e.UnidadeCedente)
                    .HasColumnName("unidade_cedente")
                    .HasMaxLength(80);
            });

            modelBuilder.Entity<CobConvenioAtributo>(entity =>
            {
                entity.HasKey(e => e.CdAtributo);

                entity.ToTable("cob_convenio_atributo");

                entity.HasIndex(e => new { e.CdConvenio, e.NmCampo })
                    .HasName("unq_cob_convenio_atributo")
                    .IsUnique();

                entity.Property(e => e.CdAtributo)
                    .HasColumnName("cd_atributo")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdConvenio).HasColumnName("cd_convenio");

                entity.Property(e => e.CdFormaPgto).HasColumnName("cd_forma_pgto");

                entity.Property(e => e.NmCampo)
                    .IsRequired()
                    .HasColumnName("nm_campo")
                    .HasMaxLength(30);

                entity.Property(e => e.NmTituloCampo)
                    .IsRequired()
                    .HasColumnName("nm_titulo_campo")
                    .HasMaxLength(30);

                entity.Property(e => e.NrOrdem).HasColumnName("nr_ordem");

                entity.Property(e => e.TipoCampo)
                    .HasColumnName("tipo_campo")
                    .HasMaxLength(20);

                entity.Property(e => e.VlAtributo)
                    .HasColumnName("vl_atributo")
                    .HasMaxLength(1000);

                entity.HasOne(d => d.CdConvenioNavigation)
                    .WithMany(p => p.CobConvenioAtributo)
                    .HasForeignKey(d => d.CdConvenio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_cob_convenio_atributo_conv");
            });

            modelBuilder.Entity<CobConvenioFormaPgto>(entity =>
            {
                entity.HasKey(e => e.IdGeral);

                entity.ToTable("cob_convenio_forma_pgto");

                entity.HasIndex(e => new { e.CdConvenio, e.CdFormaPgto, e.CdFilial, e.NrCarteira })
                    .HasName("cob_convenio_forma_pgto_idx")
                    .IsUnique();

                entity.Property(e => e.IdGeral)
                    .HasColumnName("id_geral")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdConvenio).HasColumnName("cd_convenio");

                entity.Property(e => e.CdFilial).HasColumnName("cd_filial");

                entity.Property(e => e.CdFormaPgto).HasColumnName("cd_forma_pgto");

                entity.Property(e => e.FlRegistrada)
                    .IsRequired()
                    .HasColumnName("fl_registrada")
                    .HasMaxLength(1);

                entity.Property(e => e.NrCarteira)
                    .IsRequired()
                    .HasColumnName("nr_carteira")
                    .HasMaxLength(15);

                entity.Property(e => e.SgCarteira)
                    .HasColumnName("sg_carteira")
                    .HasMaxLength(8);

                entity.Property(e => e.VariacaoCarteira)
                    .HasColumnName("variacao_carteira")
                    .HasMaxLength(3);

                entity.HasOne(d => d.CdConvenioNavigation)
                    .WithMany(p => p.CobConvenioFormaPgto)
                    .HasForeignKey(d => d.CdConvenio)
                    .HasConstraintName("fk_cob_convenio_forma_pgto");
            });

            modelBuilder.Entity<CobMotivoMovimentoRetorno>(entity =>
            {
                entity.HasKey(e => e.IdGeral);

                entity.ToTable("cob_motivo_movimento_retorno");

                entity.HasIndex(e => new { e.CdMotivo, e.CdConvenio })
                    .HasName("cob_motivo_mvto_retorno_idx")
                    .IsUnique();

                entity.Property(e => e.IdGeral)
                    .HasColumnName("id_geral")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdConvenio).HasColumnName("cd_convenio");

                entity.Property(e => e.CdMotivo)
                    .IsRequired()
                    .HasColumnName("cd_motivo")
                    .HasMaxLength(10);

                entity.Property(e => e.Descricao)
                    .HasColumnName("descricao")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<CobMovimentoRetorno>(entity =>
            {
                entity.HasKey(e => e.IdGeral);

                entity.ToTable("cob_movimento_retorno");

                entity.HasIndex(e => new { e.CdMovimento, e.CdConvenio })
                    .HasName("unq_cob_movimento_retorno")
                    .IsUnique();

                entity.Property(e => e.IdGeral)
                    .HasColumnName("id_geral")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdConvenio).HasColumnName("cd_convenio");

                entity.Property(e => e.CdMovimento)
                    .IsRequired()
                    .HasColumnName("cd_movimento")
                    .HasMaxLength(10);

                entity.Property(e => e.Descricao)
                    .HasColumnName("descricao")
                    .HasMaxLength(255);

                entity.Property(e => e.FlTipo)
                    .HasColumnName("fl_tipo")
                    .HasMaxLength(1);
            });

            modelBuilder.Entity<CobParcela>(entity =>
            {
                entity.HasKey(e => e.IdGeral);

                entity.ToTable("cob_parcela");

                entity.HasIndex(e => e.IdSistemaOrigem)
                    .HasName("unq_cob_parcela_id_origem")
                    .IsUnique();

                entity.Property(e => e.IdGeral)
                    .HasColumnName("id_geral")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdConvenio).HasColumnName("cd_convenio");

                entity.Property(e => e.DtEmissao)
                    .HasColumnName("dt_emissao")
                    .HasColumnType("date");

                entity.Property(e => e.DtVcto)
                    .HasColumnName("dt_vcto")
                    .HasColumnType("date");

                entity.Property(e => e.IdSistemaOrigem)
                    .IsRequired()
                    .HasColumnName("id_sistema_origem")
                    .HasMaxLength(100);

                entity.Property(e => e.Instrucoes).HasColumnName("instrucoes");

                entity.Property(e => e.NmCedente)
                    .IsRequired()
                    .HasColumnName("nm_cedente")
                    .HasMaxLength(1000);

                entity.Property(e => e.NmEspecie)
                    .HasColumnName("nm_especie")
                    .HasMaxLength(10);

                entity.Property(e => e.NrCarteira)
                    .HasColumnName("nr_carteira")
                    .HasMaxLength(10);

                entity.Property(e => e.NrDocumento)
                    .HasColumnName("nr_documento")
                    .HasMaxLength(15);

                entity.Property(e => e.NrNossoNumero)
                    .HasColumnName("nr_nosso_numero")
                    .HasMaxLength(50);

                entity.Property(e => e.NrSequencialRemessa).HasColumnName("nr_sequencial_remessa");

                entity.Property(e => e.Observacoes).HasColumnName("observacoes");

                entity.Property(e => e.VlAbatimento)
                    .HasColumnName("vl_abatimento")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.VlDesconto)
                    .HasColumnName("vl_desconto")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.VlJuros)
                    .HasColumnName("vl_juros")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.VlMora)
                    .HasColumnName("vl_mora")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.VlOutrasDeducoes)
                    .HasColumnName("vl_outras_deducoes")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.VlOutrosAcrescimos)
                    .HasColumnName("vl_outros_acrescimos")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.VlParcela)
                    .HasColumnName("vl_parcela")
                    .HasColumnType("numeric(10,2)");

                entity.HasOne(d => d.CdConvenioNavigation)
                    .WithMany(p => p.CobParcela)
                    .HasForeignKey(d => d.CdConvenio)
                    .HasConstraintName("cob_parcela_fk");
            });

            modelBuilder.Entity<CobRetorno>(entity =>
            {
                entity.HasKey(e => e.CdRetorno);

                entity.ToTable("cob_retorno");

                entity.HasIndex(e => e.NrRetorno)
                    .HasName("cob_retorno_nr_retorno_idx")
                    .IsUnique();

                entity.Property(e => e.CdRetorno)
                    .HasColumnName("cd_retorno")
                    .ValueGeneratedNever();

                entity.Property(e => e.Arquivo).HasColumnName("arquivo");

                entity.Property(e => e.CdConvenio).HasColumnName("cd_convenio");

                entity.Property(e => e.CdFilial).HasColumnName("cd_filial");

                entity.Property(e => e.FlProcessado)
                    .HasColumnName("fl_processado")
                    .HasMaxLength(1);

                entity.Property(e => e.NrRetorno)
                    .IsRequired()
                    .HasColumnName("nr_retorno")
                    .HasMaxLength(20);

                entity.HasOne(d => d.CdFilialNavigation)
                    .WithMany(p => p.CobRetorno)
                    .HasForeignKey(d => d.CdFilial)
                    .HasConstraintName("fk_cob_retorno_filial");
            });

            modelBuilder.Entity<CobRetornoParcela>(entity =>
            {
                entity.HasKey(e => e.IdGeral);

                entity.ToTable("cob_retorno_parcela");

                entity.HasIndex(e => new { e.NrNossoNumero, e.CdRetorno, e.CdMovimentoRetorno })
                    .HasName("cob_retorno_parcela_idx")
                    .IsUnique();

                entity.Property(e => e.IdGeral)
                    .HasColumnName("id_geral")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdMotivoMovimentoRetorno1)
                    .HasColumnName("cd_motivo_movimento_retorno1")
                    .HasMaxLength(10);

                entity.Property(e => e.CdMotivoMovimentoRetorno2)
                    .HasColumnName("cd_motivo_movimento_retorno2")
                    .HasMaxLength(10);

                entity.Property(e => e.CdMotivoMovimentoRetorno3)
                    .HasColumnName("cd_motivo_movimento_retorno3")
                    .HasMaxLength(10);

                entity.Property(e => e.CdMotivoMovimentoRetorno4)
                    .HasColumnName("cd_motivo_movimento_retorno4")
                    .HasMaxLength(10);

                entity.Property(e => e.CdMotivoMovimentoRetorno5)
                    .HasColumnName("cd_motivo_movimento_retorno5")
                    .HasMaxLength(10);

                entity.Property(e => e.CdMovimentoRetorno)
                    .IsRequired()
                    .HasColumnName("cd_movimento_retorno")
                    .HasMaxLength(10);

                entity.Property(e => e.CdRetorno).HasColumnName("cd_retorno");

                entity.Property(e => e.DtCredito)
                    .HasColumnName("dt_credito")
                    .HasColumnType("date");

                entity.Property(e => e.DtDebitoTarifa)
                    .HasColumnName("dt_debito_tarifa")
                    .HasColumnType("date");

                entity.Property(e => e.DtOcorrencia)
                    .HasColumnName("dt_ocorrencia")
                    .HasColumnType("date");

                entity.Property(e => e.FlProcessado)
                    .HasColumnName("fl_processado")
                    .HasMaxLength(1);

                entity.Property(e => e.IdParcela)
                    .HasColumnName("id_parcela")
                    .HasMaxLength(100);

                entity.Property(e => e.NrNossoNumero)
                    .IsRequired()
                    .HasColumnName("nr_nosso_numero")
                    .HasMaxLength(50);

                entity.Property(e => e.VlAbatimento)
                    .HasColumnName("vl_abatimento")
                    .HasColumnType("numeric(14,2)");

                entity.Property(e => e.VlAcrescimo)
                    .HasColumnName("vl_acrescimo")
                    .HasColumnType("numeric(14,2)");

                entity.Property(e => e.VlDesconto)
                    .HasColumnName("vl_desconto")
                    .HasColumnType("numeric(14,2)");

                entity.Property(e => e.VlDespesaCobranca)
                    .HasColumnName("vl_despesa_cobranca")
                    .HasColumnType("numeric(14,2)");

                entity.Property(e => e.VlIof)
                    .HasColumnName("vl_iof")
                    .HasColumnType("numeric(14,2)");

                entity.Property(e => e.VlLiquido)
                    .HasColumnName("vl_liquido")
                    .HasColumnType("numeric(14,2)");

                entity.Property(e => e.VlOutrasDespesas)
                    .HasColumnName("vl_outras_despesas")
                    .HasColumnType("numeric(14,2)");

                entity.Property(e => e.VlOutrosCreditos)
                    .HasColumnName("vl_outros_creditos")
                    .HasColumnType("numeric(14,2)");

                entity.Property(e => e.VlPago)
                    .HasColumnName("vl_pago")
                    .HasColumnType("numeric(14,2)");

                entity.Property(e => e.VlTarifa)
                    .HasColumnName("vl_tarifa")
                    .HasColumnType("numeric(14,2)");

                entity.HasOne(d => d.CdRetornoNavigation)
                    .WithMany(p => p.CobRetornoParcela)
                    .HasForeignKey(d => d.CdRetorno)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_cob_retorno_cd_retorno");
            });

            modelBuilder.Entity<CodigoTributacaoMunicipio>(entity =>
            {
                entity.HasKey(e => e.CdTributacaoMunicipio);

                entity.ToTable("codigo_tributacao_municipio");

                entity.Property(e => e.CdTributacaoMunicipio)
                    .HasColumnName("cd_tributacao_municipio")
                    .ValueGeneratedNever();

                entity.Property(e => e.NmTributacaoMunicipio)
                    .IsRequired()
                    .HasColumnName("nm_tributacao_municipio")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Comissao>(entity =>
            {
                entity.HasKey(e => new { e.CdFuncionario, e.CdGrupoComissao, e.CdFilial });

                entity.ToTable("comissao");

                entity.Property(e => e.CdFuncionario).HasColumnName("cd_funcionario");

                entity.Property(e => e.CdGrupoComissao).HasColumnName("cd_grupo_comissao");

                entity.Property(e => e.CdFilial).HasColumnName("cd_filial");

                entity.Property(e => e.DtAtz)
                    .HasColumnName("dt_atz")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2018-10-26'::date");

                entity.Property(e => e.FlComissaoAbaixoMin).HasColumnName("fl_comissao_abaixo_min");

                entity.Property(e => e.PcMinimo)
                    .HasColumnName("pc_minimo")
                    .HasColumnType("numeric(9,2)");

                entity.Property(e => e.PcSobreComissao)
                    .HasColumnName("pc_sobre_comissao")
                    .HasColumnType("numeric(9,2)")
                    .HasDefaultValueSql("100");

                entity.HasOne(d => d.CdFilialNavigation)
                    .WithMany(p => p.Comissao)
                    .HasForeignKey(d => d.CdFilial)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("filial_comissao_fk");

                entity.HasOne(d => d.CdGrupoComissaoNavigation)
                    .WithMany(p => p.Comissao)
                    .HasForeignKey(d => d.CdGrupoComissao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("grupo_comissao_comissao_fk");

                entity.HasOne(d => d.CdF)
                    .WithMany(p => p.Comissao)
                    .HasForeignKey(d => new { d.CdFilial, d.CdFuncionario })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("funcionario_comissao_fk");
            });

            modelBuilder.Entity<ComissaoFunc>(entity =>
            {
                entity.HasKey(e => new { e.CdFilial, e.NrDocumento, e.NrSequencia, e.CdFuncionario, e.NrParcela });

                entity.ToTable("comissao_func");

                entity.HasIndex(e => e.NrDocumento)
                    .HasName("ind_comissao_func_doc");

                entity.Property(e => e.CdFilial).HasColumnName("cd_filial");

                entity.Property(e => e.NrDocumento).HasColumnName("nr_documento");

                entity.Property(e => e.NrSequencia).HasColumnName("nr_sequencia");

                entity.Property(e => e.CdFuncionario).HasColumnName("cd_funcionario");

                entity.Property(e => e.NrParcela).HasColumnName("nr_parcela");

                entity.Property(e => e.DtEmissao).HasColumnName("dt_emissao");

                entity.Property(e => e.DtUltPgto).HasColumnName("dt_ult_pgto");

                entity.Property(e => e.DtVcto).HasColumnName("dt_vcto");

                entity.Property(e => e.NrCupom).HasColumnName("nr_cupom");

                entity.Property(e => e.NrNf).HasColumnName("nr_nf");

                entity.Property(e => e.NrSr).HasColumnName("nr_sr");

                entity.Property(e => e.PcComissao)
                    .HasColumnName("pc_comissao")
                    .HasColumnType("numeric(9,2)");

                entity.Property(e => e.PcComissaoGrupo)
                    .HasColumnName("pc_comissao_grupo")
                    .HasColumnType("numeric(9,2)");

                entity.Property(e => e.PcMinimo)
                    .HasColumnName("pc_minimo")
                    .HasColumnType("numeric(9,2)");

                entity.Property(e => e.PcMinimoComissao)
                    .HasColumnName("pc_minimo_comissao")
                    .HasColumnType("numeric(9,2)");

                entity.Property(e => e.PcParcela).HasColumnName("pc_parcela");

                entity.Property(e => e.PcSobreComissao)
                    .HasColumnName("pc_sobre_comissao")
                    .HasColumnType("numeric(9,2)");

                entity.Property(e => e.VlBase)
                    .HasColumnName("vl_base")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlComissao)
                    .HasColumnName("vl_comissao")
                    .HasColumnType("numeric(9,4)");

                entity.Property(e => e.VlPago)
                    .HasColumnName("vl_pago")
                    .HasColumnType("numeric(9,2)");

                entity.Property(e => e.VlTotal)
                    .HasColumnName("vl_total")
                    .HasColumnType("numeric(9,2)");
            });

            modelBuilder.Entity<ComissaoFuncDev>(entity =>
            {
                entity.HasKey(e => new { e.CdFilial, e.NrDocumento, e.NrSequencia, e.CdFuncionario, e.NrParcela, e.NrSequenciaDev });

                entity.ToTable("comissao_func_dev");

                entity.Property(e => e.CdFilial).HasColumnName("cd_filial");

                entity.Property(e => e.NrDocumento).HasColumnName("nr_documento");

                entity.Property(e => e.NrSequencia).HasColumnName("nr_sequencia");

                entity.Property(e => e.CdFuncionario).HasColumnName("cd_funcionario");

                entity.Property(e => e.NrParcela).HasColumnName("nr_parcela");

                entity.Property(e => e.NrSequenciaDev).HasColumnName("nr_sequencia_dev");

                entity.Property(e => e.IdNfecDev).HasColumnName("id_nfec_dev");

                entity.Property(e => e.PcComissao).HasColumnName("pc_comissao");

                entity.Property(e => e.VlBase).HasColumnName("vl_base");

                entity.Property(e => e.VlComissao).HasColumnName("vl_comissao");

                entity.HasOne(d => d.IdNfecDevNavigation)
                    .WithMany(p => p.ComissaoFuncDev)
                    .HasForeignKey(d => d.IdNfecDev)
                    .HasConstraintName("fk_comissao_func_dev_nfec");
            });

            modelBuilder.Entity<ConfEstudoLucratividade>(entity =>
            {
                entity.HasKey(e => e.CdProduto);

                entity.ToTable("conf_estudo_lucratividade");

                entity.Property(e => e.CdProduto)
                    .HasColumnName("cd_produto")
                    .HasMaxLength(15)
                    .ValueGeneratedNever();

                entity.Property(e => e.PcAliqSimplesNacional).HasColumnName("pc_aliq_simples_nacional");

                entity.Property(e => e.PcCsll).HasColumnName("pc_csll");

                entity.Property(e => e.PcCustoFixo).HasColumnName("pc_custo_fixo");

                entity.Property(e => e.PcDeQuebra).HasColumnName("pc_de_quebra");

                entity.Property(e => e.PcDespesasOperacionais).HasColumnName("pc_despesas_operacionais");

                entity.Property(e => e.PcIrrj).HasColumnName("pc_irrj");

                entity.Property(e => e.PcOutrasDespesas).HasColumnName("pc_outras_despesas");
            });

            modelBuilder.Entity<ConfSpedPisCofins>(entity =>
            {
                entity.HasKey(e => e.IdGeral);

                entity.ToTable("conf_sped_pis_cofins");

                entity.Property(e => e.IdGeral)
                    .HasColumnName("id_geral")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdFilial).HasColumnName("cd_filial");

                entity.Property(e => e.CodIncTrib).HasColumnName("cod_inc_trib");

                entity.Property(e => e.CodTipoCont).HasColumnName("cod_tipo_cont");

                entity.Property(e => e.CodVer)
                    .HasColumnName("cod_ver")
                    .HasMaxLength(10);

                entity.Property(e => e.FlBasePisLucroVeic)
                    .HasColumnName("fl_base_pis_lucro_veic")
                    .HasMaxLength(1);

                entity.Property(e => e.IndAproCred).HasColumnName("ind_apro_cred");

                entity.Property(e => e.IndAtiv)
                    .IsRequired()
                    .HasColumnName("ind_ativ")
                    .HasMaxLength(1);

                entity.Property(e => e.IndEscri).HasColumnName("ind_escri");

                entity.Property(e => e.IndNatPj)
                    .HasColumnName("ind_nat_pj")
                    .HasMaxLength(2);

                entity.Property(e => e.IndRegCu).HasColumnName("ind_reg_cu");

                entity.Property(e => e.IndSitEsp)
                    .HasColumnName("ind_sit_esp")
                    .HasMaxLength(1);

                entity.Property(e => e.TipoEscrit)
                    .IsRequired()
                    .HasColumnName("tipo_escrit")
                    .HasMaxLength(1);

                entity.HasOne(d => d.CdFilialNavigation)
                    .WithMany(p => p.ConfSpedPisCofins)
                    .HasForeignKey(d => d.CdFilial)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_conf_sped_pis_cofins_filial");
            });

            modelBuilder.Entity<Construcao>(entity =>
            {
                entity.HasKey(e => e.CdConstrucao);

                entity.ToTable("construcao");

                entity.Property(e => e.CdConstrucao)
                    .HasColumnName("cd_construcao")
                    .ValueGeneratedNever();

                entity.Property(e => e.DtAtz)
                    .HasColumnName("dt_atz")
                    .HasColumnType("date");

                entity.Property(e => e.NmConstrucao)
                    .IsRequired()
                    .HasColumnName("nm_construcao")
                    .HasMaxLength(80);
            });

            modelBuilder.Entity<Consulta>(entity =>
            {
                entity.HasKey(e => e.IdConsulta);

                entity.ToTable("consulta");

                entity.HasIndex(e => e.Identificador)
                    .HasName("unq_consulta_id")
                    .IsUnique();

                entity.Property(e => e.IdConsulta)
                    .HasColumnName("id_consulta")
                    .ValueGeneratedNever();

                entity.Property(e => e.CampoInicial)
                    .HasColumnName("campo_inicial")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CdConexao).HasColumnName("cd_conexao");

                entity.Property(e => e.ComandoSql)
                    .IsRequired()
                    .HasColumnName("comando_sql");

                entity.Property(e => e.IdAcaoCadastro).HasColumnName("id_acao_cadastro");

                entity.Property(e => e.Identificador)
                    .IsRequired()
                    .HasColumnName("identificador")
                    .HasMaxLength(18);

                entity.Property(e => e.SqlAgrupamento).HasColumnName("sql_agrupamento");

                entity.Property(e => e.TabelaCadastro)
                    .HasColumnName("tabela_cadastro")
                    .HasMaxLength(50);

                entity.Property(e => e.Titulo)
                    .IsRequired()
                    .HasColumnName("titulo")
                    .HasMaxLength(100);

                entity.HasOne(d => d.IdAcaoCadastroNavigation)
                    .WithMany(p => p.Consulta)
                    .HasForeignKey(d => d.IdAcaoCadastro)
                    .HasConstraintName("fk_consulta_acao");
            });

            modelBuilder.Entity<ConsultaCampo>(entity =>
            {
                entity.HasKey(e => e.IdGeral);

                entity.ToTable("consulta_campo");

                entity.HasIndex(e => new { e.IdConsulta, e.NmCampo })
                    .HasName("unq_consulta_campo")
                    .IsUnique();

                entity.Property(e => e.IdGeral)
                    .HasColumnName("id_geral")
                    .ValueGeneratedNever();

                entity.Property(e => e.IdConsulta).HasColumnName("id_consulta");

                entity.Property(e => e.NmCampo)
                    .IsRequired()
                    .HasColumnName("nm_campo")
                    .HasMaxLength(30);

                entity.Property(e => e.NmTitulo)
                    .HasColumnName("nm_titulo")
                    .HasMaxLength(100);

                entity.Property(e => e.NrPosicao).HasColumnName("nr_posicao");

                entity.Property(e => e.TamanhoCampo).HasColumnName("tamanho_campo");

                entity.Property(e => e.TipoCampo)
                    .HasColumnName("tipo_campo")
                    .HasMaxLength(20);

                entity.HasOne(d => d.IdConsultaNavigation)
                    .WithMany(p => p.ConsultaCampo)
                    .HasForeignKey(d => d.IdConsulta)
                    .HasConstraintName("fk_id_consulta");
            });

            modelBuilder.Entity<Contabilista>(entity =>
            {
                entity.HasKey(e => new { e.CdFilial, e.CdContabilista });

                entity.ToTable("contabilista");

                entity.Property(e => e.CdFilial).HasColumnName("cd_filial");

                entity.Property(e => e.CdContabilista).HasColumnName("cd_contabilista");

                entity.Property(e => e.Bairro)
                    .HasColumnName("bairro")
                    .HasMaxLength(30);

                entity.Property(e => e.CdCidade).HasColumnName("cd_cidade");

                entity.Property(e => e.Cep)
                    .HasColumnName("cep")
                    .HasMaxLength(10);

                entity.Property(e => e.CnpjEscritorioCont)
                    .HasColumnName("cnpj_escritorio_cont")
                    .HasMaxLength(18);

                entity.Property(e => e.Complemento)
                    .HasColumnName("complemento")
                    .HasMaxLength(20);

                entity.Property(e => e.Cpf)
                    .IsRequired()
                    .HasColumnName("cpf")
                    .HasMaxLength(14);

                entity.Property(e => e.Crc)
                    .IsRequired()
                    .HasColumnName("crc")
                    .HasMaxLength(15);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(100);

                entity.Property(e => e.Endereco)
                    .HasColumnName("endereco")
                    .HasMaxLength(60);

                entity.Property(e => e.Fax)
                    .HasColumnName("fax")
                    .HasMaxLength(16);

                entity.Property(e => e.Fone)
                    .HasColumnName("fone")
                    .HasMaxLength(16);

                entity.Property(e => e.NmContabilista)
                    .IsRequired()
                    .HasColumnName("nm_contabilista")
                    .HasMaxLength(100);

                entity.Property(e => e.Numero).HasColumnName("numero");
            });

            modelBuilder.Entity<ContaContabil>(entity =>
            {
                entity.HasKey(e => e.CdConta);

                entity.ToTable("conta_contabil");

                entity.Property(e => e.CdConta)
                    .HasColumnName("cd_conta")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdHistorico).HasColumnName("cd_historico");

                entity.Property(e => e.DtAtz)
                    .HasColumnName("dt_atz")
                    .HasColumnType("date");

                entity.Property(e => e.NmConta)
                    .IsRequired()
                    .HasColumnName("nm_conta")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Contato>(entity =>
            {
                entity.HasKey(e => e.IdContato);

                entity.ToTable("contato");

                entity.Property(e => e.IdContato)
                    .HasColumnName("id_contato")
                    .ValueGeneratedNever();

                entity.Property(e => e.Bairro)
                    .HasColumnName("bairro")
                    .HasMaxLength(80);

                entity.Property(e => e.CdCidade).HasColumnName("cd_cidade");

                entity.Property(e => e.Celular)
                    .HasColumnName("celular")
                    .HasMaxLength(20);

                entity.Property(e => e.Cep)
                    .HasColumnName("cep")
                    .HasMaxLength(10);

                entity.Property(e => e.Departamento)
                    .HasColumnName("departamento")
                    .HasMaxLength(30);

                entity.Property(e => e.DtNascimento)
                    .HasColumnName("dt_nascimento")
                    .HasColumnType("date");

                entity.Property(e => e.EMail)
                    .HasColumnName("e_mail")
                    .HasMaxLength(70);

                entity.Property(e => e.EnderecoComplemento)
                    .HasColumnName("endereco_complemento")
                    .HasMaxLength(20);

                entity.Property(e => e.EnderecoLogradouro)
                    .HasColumnName("endereco_logradouro")
                    .HasMaxLength(80);

                entity.Property(e => e.EnderecoNumero).HasColumnName("endereco_numero");

                entity.Property(e => e.Fax)
                    .HasColumnName("fax")
                    .HasMaxLength(20);

                entity.Property(e => e.FoneComercial)
                    .HasColumnName("fone_comercial")
                    .HasMaxLength(20);

                entity.Property(e => e.NmContato)
                    .HasColumnName("nm_contato")
                    .HasMaxLength(60);

                entity.Property(e => e.Obs)
                    .HasColumnName("obs")
                    .HasMaxLength(255);

                entity.Property(e => e.Telefone)
                    .HasColumnName("telefone")
                    .HasMaxLength(20);

                entity.Property(e => e.TpContato).HasColumnName("tp_contato");

                entity.HasOne(d => d.CdCidadeNavigation)
                    .WithMany(p => p.Contato)
                    .HasForeignKey(d => d.CdCidade)
                    .HasConstraintName("fk_contato_cidade");
            });

            modelBuilder.Entity<Crptitulo>(entity =>
            {
                entity.HasKey(e => new { e.CdFilial, e.CdTipoConta, e.CdClifor, e.NrTitulo, e.Parcela });

                entity.ToTable("crptitulo");

                entity.HasIndex(e => e.CdClifor)
                    .HasName("idx_crptitulo_cliente");

                entity.HasIndex(e => e.NrDocumento)
                    .HasName("crptitulo_idx_nr_documento");

                entity.HasIndex(e => e.NrTitulo)
                    .HasName("ind_crptitulo_numero");

                entity.HasIndex(e => e.NrTituloReparcelado)
                    .HasName("crptitulo_idx_nr_reparcelado");

                entity.HasIndex(e => new { e.CdTipoConta, e.NrDocumento, e.NrNfEcf, e.NrSequencial })
                    .HasName("idx_crptitulo_nr_nf");

                entity.Property(e => e.CdFilial).HasColumnName("cd_filial");

                entity.Property(e => e.CdTipoConta).HasColumnName("cd_tipo_conta");

                entity.Property(e => e.CdClifor).HasColumnName("cd_clifor");

                entity.Property(e => e.NrTitulo)
                    .HasColumnName("nr_titulo")
                    .HasMaxLength(15);

                entity.Property(e => e.Parcela).HasColumnName("parcela");

                entity.Property(e => e.CdBanco).HasColumnName("cd_banco");

                entity.Property(e => e.CdBancoOri).HasColumnName("cd_banco_ori");

                entity.Property(e => e.CdCaixa).HasColumnName("cd_caixa");

                entity.Property(e => e.CdConta).HasColumnName("cd_conta");

                entity.Property(e => e.CdFrenteCaixaCarne).HasColumnName("cd_frente_caixa_carne");

                entity.Property(e => e.CdFuncionario).HasColumnName("cd_funcionario");

                entity.Property(e => e.CdTipocobr).HasColumnName("cd_tipocobr");

                entity.Property(e => e.CdTipocobrOri).HasColumnName("cd_tipocobr_ori");

                entity.Property(e => e.CdVendedor).HasColumnName("cd_vendedor");

                entity.Property(e => e.DtAtz)
                    .HasColumnName("dt_atz")
                    .HasColumnType("date")
                    .HasDefaultValueSql("CURRENT_DATE");

                entity.Property(e => e.DtEmissao)
                    .HasColumnName("dt_emissao")
                    .HasColumnType("date")
                    .HasDefaultValueSql("CURRENT_DATE");

                entity.Property(e => e.DtInclusao)
                    .HasColumnName("dt_inclusao")
                    .HasColumnType("date")
                    .HasDefaultValueSql("CURRENT_DATE");

                entity.Property(e => e.DtUltPgto)
                    .HasColumnName("dt_ult_pgto")
                    .HasColumnType("date");

                entity.Property(e => e.DtVcto)
                    .HasColumnName("dt_vcto")
                    .HasColumnType("date")
                    .HasDefaultValueSql("CURRENT_DATE");

                entity.Property(e => e.DtVctoOri)
                    .HasColumnName("dt_vcto_ori")
                    .HasColumnType("date")
                    .HasDefaultValueSql("CURRENT_DATE");

                entity.Property(e => e.FlImprimeCarne)
                    .HasColumnName("fl_imprime_carne")
                    .HasMaxLength(1);

                entity.Property(e => e.FlImprimeComprovante)
                    .HasColumnName("fl_imprime_comprovante")
                    .HasMaxLength(1);

                entity.Property(e => e.FlPrevRealizado)
                    .HasColumnName("fl_prev_realizado")
                    .HasMaxLength(1);

                entity.Property(e => e.FlReparcelado)
                    .HasColumnName("fl_reparcelado")
                    .HasMaxLength(1);

                entity.Property(e => e.MotivoAlteracao)
                    .HasColumnName("motivo_alteracao")
                    .HasMaxLength(120);

                entity.Property(e => e.MotivoAlteracaoValor).HasColumnName("motivo_alteracao_valor");

                entity.Property(e => e.NrDocumento).HasColumnName("nr_documento");

                entity.Property(e => e.NrNfEcf).HasColumnName("nr_nf_ecf");

                entity.Property(e => e.NrSe)
                    .HasColumnName("nr_se")
                    .HasMaxLength(3);

                entity.Property(e => e.NrSequencial).HasColumnName("nr_sequencial");

                entity.Property(e => e.NrTituloReparcelado)
                    .HasColumnName("nr_titulo_reparcelado")
                    .HasMaxLength(15);

                entity.Property(e => e.Obs).HasColumnName("obs");

                entity.Property(e => e.PcParcela)
                    .HasColumnName("pc_parcela")
                    .HasColumnType("numeric(5,2)");

                entity.Property(e => e.PcParcelaTotal).HasColumnName("pc_parcela_total");

                entity.Property(e => e.PrazoParcela).HasColumnName("prazo_parcela");

                entity.Property(e => e.VlAcrescimo)
                    .HasColumnName("vl_acrescimo")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlBaixasNominal)
                    .HasColumnName("vl_baixas_nominal")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlComissao)
                    .HasColumnName("vl_comissao")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlDescontos)
                    .HasColumnName("vl_descontos")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlDevolucoes)
                    .HasColumnName("vl_devolucoes")
                    .HasColumnType("numeric(9,2)");

                entity.Property(e => e.VlJuros)
                    .HasColumnName("vl_juros")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlMulta)
                    .HasColumnName("vl_multa")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlNominal)
                    .HasColumnName("vl_nominal")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlSaldo)
                    .HasColumnName("vl_saldo")
                    .HasColumnType("numeric(18,4)");

                entity.HasOne(d => d.CdContaNavigation)
                    .WithMany(p => p.Crptitulo)
                    .HasForeignKey(d => d.CdConta)
                    .HasConstraintName("fk_crptitulo_cxa_conta");
            });

            modelBuilder.Entity<CrptituloAgrupado>(entity =>
            {
                entity.HasKey(e => new { e.CdFilialO, e.CdTipoContaO, e.NrTituloO, e.ParcelaO, e.CdCliforO });

                entity.ToTable("crptitulo_agrupado");

                entity.Property(e => e.CdFilialO).HasColumnName("cd_filial_o");

                entity.Property(e => e.CdTipoContaO).HasColumnName("cd_tipo_conta_o");

                entity.Property(e => e.NrTituloO)
                    .HasColumnName("nr_titulo_o")
                    .HasMaxLength(15);

                entity.Property(e => e.ParcelaO).HasColumnName("parcela_o");

                entity.Property(e => e.CdCliforO).HasColumnName("cd_clifor_o");

                entity.Property(e => e.CdCliforD).HasColumnName("cd_clifor_d");

                entity.Property(e => e.CdFilialD).HasColumnName("cd_filial_d");

                entity.Property(e => e.CdTipoContaD).HasColumnName("cd_tipo_conta_d");

                entity.Property(e => e.DtAgrupamento)
                    .HasColumnName("dt_agrupamento")
                    .HasColumnType("date");

                entity.Property(e => e.NrTituloD)
                    .HasColumnName("nr_titulo_d")
                    .HasMaxLength(15);

                entity.Property(e => e.ParcelaD).HasColumnName("parcela_d");
            });

            modelBuilder.Entity<CrptituloFuncionario>(entity =>
            {
                entity.HasKey(e => new { e.CdFilial, e.CdTipoConta, e.CdClifor, e.NrTitulo, e.CdFuncionario });

                entity.ToTable("crptitulo_funcionario");

                entity.Property(e => e.CdFilial).HasColumnName("cd_filial");

                entity.Property(e => e.CdTipoConta).HasColumnName("cd_tipo_conta");

                entity.Property(e => e.CdClifor).HasColumnName("cd_clifor");

                entity.Property(e => e.NrTitulo)
                    .HasColumnName("nr_titulo")
                    .HasMaxLength(15);

                entity.Property(e => e.CdFuncionario).HasColumnName("cd_funcionario");

                entity.Property(e => e.Obs).HasColumnName("obs");

                entity.HasOne(d => d.CdF)
                    .WithMany(p => p.CrptituloFuncionario)
                    .HasForeignKey(d => new { d.CdFilial, d.CdFuncionario })
                    .HasConstraintName("fk_crptitulo_funcionario_func");
            });

            modelBuilder.Entity<CrptituloMovimentoCxa>(entity =>
            {
                entity.HasKey(e => new { e.CdFilial, e.CdTipoConta, e.CdClifor, e.NrTitulo, e.Parcela, e.NrLcto, e.CdCaixa });

                entity.ToTable("crptitulo_movimento_cxa");

                entity.HasIndex(e => new { e.CdFilial, e.NrLcto, e.CdCaixa })
                    .HasName("crptitulo_movimento_cxa_cnc");

                entity.HasIndex(e => new { e.CdFilial, e.CdTipoConta, e.CdClifor, e.NrTitulo, e.Parcela })
                    .HasName("crptitulo_movimento_cxa_cccnp");

                entity.Property(e => e.CdFilial).HasColumnName("cd_filial");

                entity.Property(e => e.CdTipoConta).HasColumnName("cd_tipo_conta");

                entity.Property(e => e.CdClifor).HasColumnName("cd_clifor");

                entity.Property(e => e.NrTitulo)
                    .HasColumnName("nr_titulo")
                    .HasMaxLength(15);

                entity.Property(e => e.Parcela).HasColumnName("parcela");

                entity.Property(e => e.NrLcto).HasColumnName("nr_lcto");

                entity.Property(e => e.CdCaixa).HasColumnName("cd_caixa");

                entity.Property(e => e.DtAtz)
                    .HasColumnName("dt_atz")
                    .HasColumnType("date");

                entity.HasOne(d => d.MovimentoCxa)
                    .WithMany(p => p.CrptituloMovimentoCxa)
                    .HasForeignKey(d => new { d.CdFilial, d.CdCaixa, d.NrLcto })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_crptitulo_movimento_cxa");

                entity.HasOne(d => d.Crptitulo)
                    .WithMany(p => p.CrptituloMovimentoCxa)
                    .HasForeignKey(d => new { d.CdFilial, d.CdTipoConta, d.CdClifor, d.NrTitulo, d.Parcela })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_crptitulo_movimento_cxa_1");
            });

            modelBuilder.Entity<Cst>(entity =>
            {
                entity.HasKey(e => e.CdCst);

                entity.ToTable("cst");

                entity.Property(e => e.CdCst)
                    .HasColumnName("cd_cst")
                    .HasMaxLength(4)
                    .ValueGeneratedNever();

                entity.Property(e => e.CdMensagem).HasColumnName("cd_mensagem");

                entity.Property(e => e.FlCalcPartilha)
                    .HasColumnName("fl_calc_partilha")
                    .HasMaxLength(1);

                entity.Property(e => e.FlDiferencaBaseTotal)
                    .HasColumnName("fl_diferenca_base_total")
                    .HasMaxLength(1);

                entity.Property(e => e.FlIcm)
                    .HasColumnName("fl_icm")
                    .HasMaxLength(1);

                entity.Property(e => e.FlIcmSubst)
                    .HasColumnName("fl_icm_subst")
                    .HasMaxLength(1);

                entity.Property(e => e.FlPermiteCredito)
                    .HasColumnName("fl_permite_credito")
                    .HasMaxLength(1);

                entity.Property(e => e.FlReducao)
                    .HasColumnName("fl_reducao")
                    .HasMaxLength(1);

                entity.Property(e => e.FlSimples)
                    .HasColumnName("fl_simples")
                    .HasMaxLength(1);

                entity.Property(e => e.HashCstD3)
                    .HasColumnName("hash_cst_d3")
                    .HasMaxLength(70);

                entity.Property(e => e.HashCstP2)
                    .HasColumnName("hash_cst_p2")
                    .HasMaxLength(70);

                entity.Property(e => e.NmCst)
                    .IsRequired()
                    .HasColumnName("nm_cst")
                    .HasMaxLength(100);

                entity.HasOne(d => d.CdMensagemNavigation)
                    .WithMany(p => p.Cst)
                    .HasForeignKey(d => d.CdMensagem)
                    .HasConstraintName("fk_cst_mensagem");
            });

            modelBuilder.Entity<CstIpi>(entity =>
            {
                entity.HasKey(e => e.CdCstIpi);

                entity.ToTable("cst_ipi");

                entity.Property(e => e.CdCstIpi)
                    .HasColumnName("cd_cst_ipi")
                    .HasMaxLength(10)
                    .ValueGeneratedNever();

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasColumnName("descricao")
                    .HasMaxLength(100);

                entity.Property(e => e.FlEntSai).HasColumnName("fl_ent_sai");

                entity.Property(e => e.FlTributada)
                    .HasColumnName("fl_tributada")
                    .HasDefaultValueSql("'N'::bpchar");
            });

            modelBuilder.Entity<CstPisCofins>(entity =>
            {
                entity.HasKey(e => e.CdCstPisCofins);

                entity.ToTable("cst_pis_cofins");

                entity.Property(e => e.CdCstPisCofins)
                    .HasColumnName("cd_cst_pis_cofins")
                    .HasMaxLength(10)
                    .ValueGeneratedNever();

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasColumnName("descricao")
                    .HasMaxLength(200);

                entity.Property(e => e.FlEntSai).HasColumnName("fl_ent_sai");

                entity.Property(e => e.FlTributada)
                    .HasColumnName("fl_tributada")
                    .HasDefaultValueSql("'N'::bpchar");
            });

            modelBuilder.Entity<Custcomp>(entity =>
            {
                entity.HasKey(e => new { e.CdFilial, e.CdProduto, e.IdNfei });

                entity.ToTable("custcomp");

                entity.HasIndex(e => e.CdProduto)
                    .HasName("idx_custcomp_produto");

                entity.Property(e => e.CdFilial).HasColumnName("cd_filial");

                entity.Property(e => e.CdProduto)
                    .HasColumnName("cd_produto")
                    .HasMaxLength(15);

                entity.Property(e => e.IdNfei).HasColumnName("id_nfei");

                entity.Property(e => e.CustoCompraNomi)
                    .HasColumnName("custo_compra_nomi")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.CustoCompraSimples)
                    .HasColumnName("custo_compra_simples")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.CustoMedioNomi)
                    .HasColumnName("custo_medio_nomi")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.DtAtz)
                    .HasColumnName("dt_atz")
                    .HasColumnType("date")
                    .HasDefaultValueSql("CURRENT_DATE");

                entity.Property(e => e.DtLancamento)
                    .HasColumnName("dt_lancamento")
                    .HasColumnType("date")
                    .HasDefaultValueSql("CURRENT_DATE");

                entity.Property(e => e.FlCustoAlterado)
                    .HasColumnName("fl_custo_alterado")
                    .HasMaxLength(1);

                entity.Property(e => e.QtdeNomi).HasColumnName("qtde_nomi");

                entity.HasOne(d => d.CdProdutoNavigation)
                    .WithMany(p => p.Custcomp)
                    .HasForeignKey(d => d.CdProduto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_cusproduto");

                entity.HasOne(d => d.IdNfeiNavigation)
                    .WithMany(p => p.Custcomp)
                    .HasForeignKey(d => d.IdNfei)
                    .HasConstraintName("fk_custcomp_nfei");
            });

            modelBuilder.Entity<CxaAbertura>(entity =>
            {
                entity.HasKey(e => new { e.CdFilial, e.CdCaixa, e.CdFuncionario, e.NrSequencial });

                entity.ToTable("cxa_abertura");

                entity.Property(e => e.CdFilial).HasColumnName("cd_filial");

                entity.Property(e => e.CdCaixa).HasColumnName("cd_caixa");

                entity.Property(e => e.CdFuncionario).HasColumnName("cd_funcionario");

                entity.Property(e => e.NrSequencial).HasColumnName("nr_sequencial");

                entity.Property(e => e.CdCaixaOrigem).HasColumnName("cd_caixa_origem");

                entity.Property(e => e.DtAbertura)
                    .HasColumnName("dt_abertura")
                    .HasColumnType("date");

                entity.Property(e => e.DtAtz)
                    .HasColumnName("dt_atz")
                    .HasColumnType("date")
                    .HasDefaultValueSql("CURRENT_DATE");

                entity.Property(e => e.DtFechamento)
                    .HasColumnName("dt_fechamento")
                    .HasColumnType("date");

                entity.Property(e => e.FlFechado)
                    .IsRequired()
                    .HasColumnName("fl_fechado")
                    .HasMaxLength(1);

                entity.Property(e => e.HoraAbertura)
                    .HasColumnName("hora_abertura")
                    .HasColumnType("time without time zone");

                entity.Property(e => e.HoraFechamento)
                    .HasColumnName("hora_fechamento")
                    .HasColumnType("time without time zone");

                entity.Property(e => e.VlFimCartao)
                    .HasColumnName("vl_fim_cartao")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlFimCheque)
                    .HasColumnName("vl_fim_cheque")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlFimDinheiro)
                    .HasColumnName("vl_fim_dinheiro")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlFimOutros)
                    .HasColumnName("vl_fim_outros")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlIniCartao)
                    .HasColumnName("vl_ini_cartao")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlIniCheque)
                    .HasColumnName("vl_ini_cheque")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlIniDinheiro)
                    .HasColumnName("vl_ini_dinheiro")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlIniOutros)
                    .HasColumnName("vl_ini_outros")
                    .HasColumnType("numeric(18,4)");
            });

            modelBuilder.Entity<CxaAcesso>(entity =>
            {
                entity.HasKey(e => new { e.CdFilial, e.CdFuncionario, e.CdCaixa });

                entity.ToTable("cxa_acesso");

                entity.Property(e => e.CdFilial).HasColumnName("cd_filial");

                entity.Property(e => e.CdFuncionario).HasColumnName("cd_funcionario");

                entity.Property(e => e.CdCaixa).HasColumnName("cd_caixa");

                entity.Property(e => e.DtAtz)
                    .HasColumnName("dt_atz")
                    .HasColumnType("date")
                    .HasDefaultValueSql("CURRENT_DATE");

                entity.Property(e => e.Exclusao).HasColumnName("exclusao");

                entity.Property(e => e.Gravacao).HasColumnName("gravacao");

                entity.Property(e => e.Leitura).HasColumnName("leitura");

                entity.Property(e => e.Obs)
                    .HasColumnName("obs")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<CxaConta>(entity =>
            {
                entity.HasKey(e => e.CdConta);

                entity.ToTable("cxa_conta");

                entity.Property(e => e.CdConta)
                    .HasColumnName("cd_conta")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdCompleto)
                    .IsRequired()
                    .HasColumnName("cd_completo")
                    .HasMaxLength(30);

                entity.Property(e => e.CdContaContabil).HasColumnName("cd_conta_contabil");

                entity.Property(e => e.CdFilial).HasColumnName("cd_filial");

                entity.Property(e => e.CdHistorico).HasColumnName("cd_historico");

                entity.Property(e => e.DtAtz).HasColumnName("dt_atz");

                entity.Property(e => e.FlAtivo).HasColumnName("fl_ativo");

                entity.Property(e => e.FlFixvar)
                    .IsRequired()
                    .HasColumnName("fl_fixvar")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("'N'::character varying");

                entity.Property(e => e.FlFranquia)
                    .HasColumnName("fl_franquia")
                    .HasMaxLength(1);

                entity.Property(e => e.GrauSuperior).HasColumnName("grau_superior");

                entity.Property(e => e.NmConta)
                    .IsRequired()
                    .HasColumnName("nm_conta")
                    .HasMaxLength(50);

                entity.Property(e => e.TpConta).HasColumnName("tp_conta");

                entity.HasOne(d => d.CdContaContabilNavigation)
                    .WithMany(p => p.CxaConta)
                    .HasForeignKey(d => d.CdContaContabil)
                    .HasConstraintName("fk_cxa_conta_conta_contabil");
            });

            modelBuilder.Entity<DocNaoFiscalC>(entity =>
            {
                entity.HasKey(e => e.IdGeral);

                entity.ToTable("doc_nao_fiscal_c");

                entity.Property(e => e.IdGeral)
                    .HasColumnName("id_geral")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdEcf).HasColumnName("cd_ecf");

                entity.Property(e => e.Coo).HasColumnName("coo");

                entity.Property(e => e.DtEmissao)
                    .HasColumnName("dt_emissao")
                    .HasColumnType("date");

                entity.Property(e => e.FlMfAdicional)
                    .IsRequired()
                    .HasColumnName("fl_mf_adicional")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("'N'::character varying");

                entity.Property(e => e.Gnf).HasColumnName("gnf");

                entity.Property(e => e.HashDocNaoFiscalCR6)
                    .HasColumnName("hash_doc_nao_fiscal_c_r6")
                    .HasMaxLength(70);

                entity.Property(e => e.HashDocNaoFiscalCR7)
                    .HasColumnName("hash_doc_nao_fiscal_c_r7")
                    .HasMaxLength(70);

                entity.Property(e => e.HrEmissao)
                    .HasColumnName("hr_emissao")
                    .HasColumnType("time without time zone");

                entity.Property(e => e.NrDctoNfsc).HasColumnName("nr_dcto_nfsc");

                entity.Property(e => e.NrDoc).HasColumnName("nr_doc");

                entity.Property(e => e.TipoDoc)
                    .IsRequired()
                    .HasColumnName("tipo_doc")
                    .HasMaxLength(2);

                entity.HasOne(d => d.CdEcfNavigation)
                    .WithMany(p => p.DocNaoFiscalC)
                    .HasForeignKey(d => d.CdEcf)
                    .HasConstraintName("fk_doc_nao_fiscal_c_impfiscal");
            });

            modelBuilder.Entity<DocNaoFiscalI>(entity =>
            {
                entity.HasKey(e => e.IdGeral);

                entity.ToTable("doc_nao_fiscal_i");

                entity.Property(e => e.IdGeral)
                    .HasColumnName("id_geral")
                    .ValueGeneratedNever();

                entity.Property(e => e.IdDocNaoFiscal).HasColumnName("id_doc_nao_fiscal");

                entity.Property(e => e.NmPagamento)
                    .IsRequired()
                    .HasColumnName("nm_pagamento")
                    .HasMaxLength(25);

                entity.Property(e => e.VlPago)
                    .HasColumnName("vl_pago")
                    .HasColumnType("numeric(9,2)");

                entity.HasOne(d => d.IdDocNaoFiscalNavigation)
                    .WithMany(p => p.DocNaoFiscalI)
                    .HasForeignKey(d => d.IdDocNaoFiscal)
                    .HasConstraintName("fk_doc_n_fiscal_i_doc_n_fisc_c");
            });

            modelBuilder.Entity<DocProducao>(entity =>
            {
                entity.HasKey(e => e.NrDocumento);

                entity.ToTable("doc_producao");

                entity.Property(e => e.NrDocumento)
                    .HasColumnName("nr_documento")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdCancelamento).HasColumnName("cd_cancelamento");

                entity.Property(e => e.CdFilial).HasColumnName("cd_filial");

                entity.Property(e => e.DtEmissao)
                    .HasColumnName("dt_emissao")
                    .HasColumnType("date");

                entity.Property(e => e.DtProducao)
                    .HasColumnName("dt_producao")
                    .HasColumnType("date");

                entity.Property(e => e.IdNfec).HasColumnName("id_nfec");

                entity.Property(e => e.IdNfsc).HasColumnName("id_nfsc");

                entity.Property(e => e.NrOrdemProducao).HasColumnName("nr_ordem_producao");

                entity.Property(e => e.QtProduzido).HasColumnName("qt_produzido");

                entity.HasOne(d => d.CdFilialNavigation)
                    .WithMany(p => p.DocProducao)
                    .HasForeignKey(d => d.CdFilial)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_doc_producao_filial");
            });

            modelBuilder.Entity<Estocagem>(entity =>
            {
                entity.HasKey(e => new { e.CdFilial, e.LocalEstocagem });

                entity.ToTable("estocagem");

                entity.HasIndex(e => e.LocalEstocagem)
                    .HasName("ind_local_estocagem");

                entity.Property(e => e.CdFilial).HasColumnName("cd_filial");

                entity.Property(e => e.LocalEstocagem)
                    .HasColumnName("local_estocagem")
                    .HasMaxLength(10);

                entity.Property(e => e.DtAtz)
                    .HasColumnName("dt_atz")
                    .HasColumnType("date")
                    .HasDefaultValueSql("CURRENT_DATE");

                entity.Property(e => e.NmLocal)
                    .IsRequired()
                    .HasColumnName("nm_local")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<Estoque>(entity =>
            {
                entity.HasKey(e => new { e.CdFilial, e.CdProduto, e.Mes, e.Ano });

                entity.ToTable("estoque");

                entity.HasIndex(e => e.Ano)
                    .HasName("idx_estoque_ano");

                entity.HasIndex(e => e.Mes)
                    .HasName("idx_estoque_mes");

                entity.HasIndex(e => new { e.Ano, e.CdFilial, e.CdProduto, e.Mes })
                    .HasName("ind_estoque_chave");

                entity.Property(e => e.CdFilial).HasColumnName("cd_filial");

                entity.Property(e => e.CdProduto)
                    .HasColumnName("cd_produto")
                    .HasMaxLength(15);

                entity.Property(e => e.Mes).HasColumnName("mes");

                entity.Property(e => e.Ano).HasColumnName("ano");

                entity.Property(e => e.DtAtz)
                    .HasColumnName("dt_atz")
                    .HasColumnType("date")
                    .HasDefaultValueSql("CURRENT_DATE");

                entity.Property(e => e.QtEntradas).HasColumnName("qt_entradas");

                entity.Property(e => e.QtEntradas2).HasColumnName("qt_entradas2");

                entity.Property(e => e.QtSaidas).HasColumnName("qt_saidas");

                entity.Property(e => e.QtSaidas2).HasColumnName("qt_saidas2");

                entity.Property(e => e.Qtde).HasColumnName("qtde");

                entity.Property(e => e.Qtde2).HasColumnName("qtde2");

                entity.HasOne(d => d.CdProdutoNavigation)
                    .WithMany(p => p.Estoque)
                    .HasForeignKey(d => d.CdProduto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_estproduto");
            });

            modelBuilder.Entity<Filial>(entity =>
            {
                entity.HasKey(e => e.CdFilial);

                entity.ToTable("filial");

                entity.Property(e => e.CdFilial)
                    .HasColumnName("cd_filial")
                    .ValueGeneratedNever();

                entity.Property(e => e.AliqIcmsSimples)
                    .HasColumnName("aliq_icms_simples")
                    .HasColumnType("numeric(5,2)");

                entity.Property(e => e.Bairro)
                    .HasColumnName("bairro")
                    .HasMaxLength(30);

                entity.Property(e => e.BloquearEdicaoJurosMulta).HasColumnName("bloquear_edicao_juros_multa");

                entity.Property(e => e.Calculoconveniost).HasColumnName("calculoconveniost");

                entity.Property(e => e.CdCidade).HasColumnName("cd_cidade");

                entity.Property(e => e.CdClienteConsumidor).HasColumnName("cd_cliente_consumidor");

                entity.Property(e => e.CdClienteEmpresa).HasColumnName("cd_cliente_empresa");

                entity.Property(e => e.CdConta).HasColumnName("cd_conta");

                entity.Property(e => e.CdCrt).HasColumnName("cd_crt");

                entity.Property(e => e.CdCtblExporta).HasColumnName("cd_ctbl_exporta");

                entity.Property(e => e.CdFilialFornecedor).HasColumnName("cd_filial_fornecedor");

                entity.Property(e => e.CdFornecedorImpostoSt).HasColumnName("cd_fornecedor_imposto_st");

                entity.Property(e => e.CdImpfiscalAtzEstoque).HasColumnName("cd_impfiscal_atz_estoque");

                entity.Property(e => e.CdMensagemCupom).HasColumnName("cd_mensagem_cupom");

                entity.Property(e => e.CdMensagemDav).HasColumnName("cd_mensagem_dav");

                entity.Property(e => e.CdMensagemDescontoRo).HasColumnName("cd_mensagem_desconto_ro");

                entity.Property(e => e.CdMensagemDifal).HasColumnName("cd_mensagem_difal");

                entity.Property(e => e.CdMensagemFcp).HasColumnName("cd_mensagem_fcp");

                entity.Property(e => e.CdMensagemIcmRetAnt).HasColumnName("cd_mensagem_icm_ret_ant");

                entity.Property(e => e.CdMensagemIcmStNotaDev).HasColumnName("cd_mensagem_icm_st_nota_dev");

                entity.Property(e => e.CdMensagemIpiNotaDev).HasColumnName("cd_mensagem_ipi_nota_dev");

                entity.Property(e => e.CdMensagemPreVenda).HasColumnName("cd_mensagem_pre_venda");

                entity.Property(e => e.CdMensagemReducao).HasColumnName("cd_mensagem_reducao");

                entity.Property(e => e.CdMensagemSimples).HasColumnName("cd_mensagem_simples");

                entity.Property(e => e.CdMensagemTotTrib).HasColumnName("cd_mensagem_tot_trib");

                entity.Property(e => e.CdOpEntradaProducao).HasColumnName("cd_op_entrada_producao");

                entity.Property(e => e.CdOpSaidaProducao).HasColumnName("cd_op_saida_producao");

                entity.Property(e => e.CdProdfreteCompra)
                    .HasColumnName("cd_prodfrete_compra")
                    .HasMaxLength(15);

                entity.Property(e => e.CdProdfreteComprasC)
                    .HasColumnName("cd_prodfrete_compras_c")
                    .HasMaxLength(15);

                entity.Property(e => e.CdProdfreteEntrada)
                    .HasColumnName("cd_prodfrete_entrada")
                    .HasMaxLength(15);

                entity.Property(e => e.CdProdfreteEntradasC)
                    .HasColumnName("cd_prodfrete_entradas_c")
                    .HasMaxLength(15);

                entity.Property(e => e.CdProdfreteSaida)
                    .HasColumnName("cd_prodfrete_saida")
                    .HasMaxLength(15);

                entity.Property(e => e.CdProdfreteSaidasC)
                    .HasColumnName("cd_prodfrete_saidas_c")
                    .HasMaxLength(15);

                entity.Property(e => e.CdProdfreteTrans)
                    .HasColumnName("cd_prodfrete_trans")
                    .HasMaxLength(15);

                entity.Property(e => e.CdProdfreteVenda)
                    .HasColumnName("cd_prodfrete_venda")
                    .HasMaxLength(15);

                entity.Property(e => e.CdProdfreteVendasC)
                    .HasColumnName("cd_prodfrete_vendas_c")
                    .HasMaxLength(15);

                entity.Property(e => e.CdTabelaPrecoPadrao).HasColumnName("cd_tabela_preco_padrao");

                entity.Property(e => e.CdTransportadora).HasColumnName("cd_transportadora");

                entity.Property(e => e.CdUsrPadrao).HasColumnName("cd_usr_padrao");

                entity.Property(e => e.Cep)
                    .HasColumnName("cep")
                    .HasMaxLength(10);

                entity.Property(e => e.CfInformaDocumento).HasColumnName("cf_informa_documento");

                entity.Property(e => e.Cgc)
                    .HasColumnName("cgc")
                    .HasMaxLength(18);

                entity.Property(e => e.Cidade)
                    .IsRequired()
                    .HasColumnName("cidade")
                    .HasMaxLength(50);

                entity.Property(e => e.CnaeFiscal)
                    .HasColumnName("cnae_fiscal")
                    .HasMaxLength(7);

                entity.Property(e => e.CodVersaoEfd)
                    .HasColumnName("cod_versao_efd")
                    .HasMaxLength(3);

                entity.Property(e => e.Complemento)
                    .HasColumnName("complemento")
                    .HasMaxLength(20);

                entity.Property(e => e.CstFreteIcmsNcred)
                    .HasColumnName("cst_frete_icms_ncred")
                    .HasMaxLength(4);

                entity.Property(e => e.CstFreteIcmscred)
                    .HasColumnName("cst_frete_icmscred")
                    .HasMaxLength(4);

                entity.Property(e => e.CustoEmOrcamento)
                    .HasColumnName("custo_em_orcamento")
                    .HasMaxLength(1);

                entity.Property(e => e.DatabaseAuditor).HasColumnName("database_auditor");

                entity.Property(e => e.DiasJuro).HasColumnName("dias_juro");

                entity.Property(e => e.DiasMulta).HasColumnName("dias_multa");

                entity.Property(e => e.DiasVcto)
                    .HasColumnName("dias_vcto")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DirArqCarneEcf)
                    .HasColumnName("dir_arq_carne_ecf")
                    .HasMaxLength(150);

                entity.Property(e => e.DirArqComprovanteEcf)
                    .HasColumnName("dir_arq_comprovante_ecf")
                    .HasMaxLength(150);

                entity.Property(e => e.DtAtz).HasColumnName("dt_atz");

                entity.Property(e => e.DtAtzEstoque)
                    .HasColumnName("dt_atz_estoque")
                    .HasColumnType("date");

                entity.Property(e => e.DtUltimaIntegracao)
                    .HasColumnName("dt_ultima_integracao")
                    .HasColumnType("date");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(75);

                entity.Property(e => e.EmpresaSimples)
                    .HasColumnName("empresa_simples")
                    .HasMaxLength(1);

                entity.Property(e => e.Endereco)
                    .HasColumnName("endereco")
                    .HasMaxLength(50);

                entity.Property(e => e.Fax)
                    .HasColumnName("fax")
                    .HasMaxLength(16);

                entity.Property(e => e.FlAdicionaStCustoProduto).HasColumnName("fl_adiciona_st_custo_produto");

                entity.Property(e => e.FlAlteraVendOrc)
                    .HasColumnName("fl_altera_vend_orc")
                    .HasMaxLength(1);

                entity.Property(e => e.FlAlterarMarkupCadastro).HasColumnName("fl_alterar_markup_cadastro");

                entity.Property(e => e.FlApenasVendedorDoc)
                    .HasColumnName("fl_apenas_vendedor_doc")
                    .HasDefaultValueSql("'N'::bpchar");

                entity.Property(e => e.FlArmazInterfoc).HasColumnName("fl_armaz_interfoc");

                entity.Property(e => e.FlBloqCancelamentoEcf)
                    .HasColumnName("fl_bloq_cancelamento_ecf")
                    .HasMaxLength(1);

                entity.Property(e => e.FlCalculaComissao).HasColumnName("fl_calcula_comissao");

                entity.Property(e => e.FlCalculaDiferencaIcms)
                    .HasColumnName("fl_calcula_diferenca_icms")
                    .HasMaxLength(1);

                entity.Property(e => e.FlCalculaPrazoDataSaida).HasColumnName("fl_calcula_prazo_data_saida");

                entity.Property(e => e.FlClienteCnpjDupl)
                    .HasColumnName("fl_cliente_cnpj_dupl")
                    .HasMaxLength(1);

                entity.Property(e => e.FlCodCliforDanfe)
                    .HasColumnName("fl_cod_clifor_danfe")
                    .HasMaxLength(1);

                entity.Property(e => e.FlComissaoVendabaixa)
                    .HasColumnName("fl_comissao_vendabaixa")
                    .HasMaxLength(1);

                entity.Property(e => e.FlConheFreteSt)
                    .HasColumnName("fl_conhe_frete_st")
                    .HasMaxLength(1);

                entity.Property(e => e.FlConsProd)
                    .HasColumnName("fl_cons_prod")
                    .HasMaxLength(1);

                entity.Property(e => e.FlContigenciaMunicipal).HasColumnName("fl_contigencia_municipal");

                entity.Property(e => e.FlContribuinte)
                    .HasColumnName("fl_contribuinte")
                    .HasMaxLength(1);

                entity.Property(e => e.FlControlarEstoq).HasColumnName("fl_controlar_estoq");

                entity.Property(e => e.FlControleContas)
                    .HasColumnName("fl_controle_contas")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("'N'::character varying");

                entity.Property(e => e.FlControleCredito).HasColumnName("fl_controle_credito");

                entity.Property(e => e.FlCustoFreteSt)
                    .HasColumnName("fl_custo_frete_st")
                    .HasMaxLength(1);

                entity.Property(e => e.FlDeducaoIcms).HasColumnName("fl_deducao_icms");

                entity.Property(e => e.FlDeducaoPiscofins)
                    .HasColumnName("fl_deducao_piscofins")
                    .HasMaxLength(1);

                entity.Property(e => e.FlDescontoIncondicionado).HasColumnName("fl_desconto_incondicionado");

                entity.Property(e => e.FlEnviaBlocox)
                    .HasColumnName("fl_envia_blocox")
                    .HasMaxLength(1);

                entity.Property(e => e.FlFilialTitCartao)
                    .HasColumnName("fl_filial_tit_cartao")
                    .HasMaxLength(1);

                entity.Property(e => e.FlFitossanitarioSira)
                    .HasColumnName("fl_fitossanitario_sira")
                    .HasMaxLength(1);

                entity.Property(e => e.FlFlex)
                    .HasColumnName("fl_flex")
                    .HasMaxLength(1);

                entity.Property(e => e.FlImpVendedorClienteNfsc)
                    .HasColumnName("fl_imp_vendedor_cliente_nfsc")
                    .HasMaxLength(1);

                entity.Property(e => e.FlImportarVendedorPrimeiro).HasColumnName("fl_importar_vendedor_primeiro");

                entity.Property(e => e.FlImportarVendedorSegundo).HasColumnName("fl_importar_vendedor_segundo");

                entity.Property(e => e.FlImportarVendedorTerceiro).HasColumnName("fl_importar_vendedor_terceiro");

                entity.Property(e => e.FlImprimeCarneEcf).HasColumnName("fl_imprime_carne_ecf");

                entity.Property(e => e.FlImprimeNf).HasColumnName("fl_imprime_nf");

                entity.Property(e => e.FlImprimeOrdemEntrega).HasColumnName("fl_imprime_ordem_entrega");

                entity.Property(e => e.FlImprimirNfs).HasColumnName("fl_imprimir_nfs");

                entity.Property(e => e.FlImprimirOrcEcf).HasColumnName("fl_imprimir_orc_ecf");

                entity.Property(e => e.FlIndustria).HasColumnName("fl_industria");

                entity.Property(e => e.FlInformarNrNf).HasColumnName("fl_informar_nr_nf");

                entity.Property(e => e.FlItemDuplNfe)
                    .HasColumnName("fl_item_dupl_nfe")
                    .HasMaxLength(1);

                entity.Property(e => e.FlItemDuplNfs)
                    .HasColumnName("fl_item_dupl_nfs")
                    .HasMaxLength(1);

                entity.Property(e => e.FlManifestoEletronico)
                    .HasColumnName("fl_manifesto_eletronico")
                    .HasMaxLength(1);

                entity.Property(e => e.FlMultaPorcentagem)
                    .HasColumnName("fl_multa_porcentagem")
                    .HasMaxLength(1);

                entity.Property(e => e.FlNotaEletronicaMunicipal).HasColumnName("fl_nota_eletronica_municipal");

                entity.Property(e => e.FlOculista)
                    .HasColumnName("fl_oculista")
                    .HasMaxLength(1);

                entity.Property(e => e.FlOrcExibirUltVenda)
                    .HasColumnName("fl_orc_exibir_ult_venda")
                    .HasMaxLength(1);

                entity.Property(e => e.FlOrcExibirVlCompra)
                    .HasColumnName("fl_orc_exibir_vl_compra")
                    .HasMaxLength(1);

                entity.Property(e => e.FlOrcImpVendCliente)
                    .HasColumnName("fl_orc_imp_vend_cliente")
                    .HasMaxLength(1);

                entity.Property(e => e.FlOrcProdSemVendedor)
                    .HasColumnName("fl_orc_prod_sem_vendedor")
                    .HasMaxLength(1);

                entity.Property(e => e.FlOrcServSemVendedor)
                    .HasColumnName("fl_orc_serv_sem_vendedor")
                    .HasMaxLength(1);

                entity.Property(e => e.FlPosVenda)
                    .HasColumnName("fl_pos_venda")
                    .HasMaxLength(1);

                entity.Property(e => e.FlRealPresumido).HasColumnName("fl_real_presumido");

                entity.Property(e => e.FlRedeUniagro)
                    .HasColumnName("fl_rede_uniagro")
                    .HasMaxLength(1);

                entity.Property(e => e.FlSeguradora)
                    .HasColumnName("fl_seguradora")
                    .HasMaxLength(1);

                entity.Property(e => e.FlSenhaSupervisorDav)
                    .HasColumnName("fl_senha_supervisor_dav")
                    .HasMaxLength(1);

                entity.Property(e => e.FlSimplesExcessoReceita)
                    .HasColumnName("fl_simples_excesso_receita")
                    .HasMaxLength(1);

                entity.Property(e => e.FlStNotaEsta)
                    .HasColumnName("fl_st_nota_esta")
                    .HasMaxLength(1);

                entity.Property(e => e.FlUtilizaContaContabil).HasColumnName("fl_utiliza_conta_contabil");

                entity.Property(e => e.FlUtilizaIntegracao).HasColumnName("fl_utiliza_integracao");

                entity.Property(e => e.FlUtilizaNfce)
                    .HasColumnName("fl_utiliza_nfce")
                    .HasMaxLength(1);

                entity.Property(e => e.FlUtilizaPaf).HasColumnName("fl_utiliza_paf");

                entity.Property(e => e.FlValorDesconto).HasColumnName("fl_valor_desconto");

                entity.Property(e => e.FlValorFrete).HasColumnName("fl_valor_frete");

                entity.Property(e => e.FlValorSeguro).HasColumnName("fl_valor_seguro");

                entity.Property(e => e.FlVendaOutrosUf)
                    .HasColumnName("fl_venda_outros_uf")
                    .HasMaxLength(1);

                entity.Property(e => e.FlVendaPrazoClienteBloq)
                    .HasColumnName("fl_venda_prazo_cliente_bloq")
                    .HasMaxLength(1);

                entity.Property(e => e.FlVendaVistaClienteBloq)
                    .HasColumnName("fl_venda_vista_cliente_bloq")
                    .HasMaxLength(1);

                entity.Property(e => e.Fone)
                    .HasColumnName("fone")
                    .HasMaxLength(16);

                entity.Property(e => e.FusoHorario)
                    .HasColumnName("fuso_horario")
                    .HasMaxLength(6);

                entity.Property(e => e.HashFilialE1)
                    .HasColumnName("hash_filial_e1")
                    .HasMaxLength(70);

                entity.Property(e => e.HashFilialR1)
                    .HasColumnName("hash_filial_r1")
                    .HasMaxLength(70);

                entity.Property(e => e.HrAtzEstoque)
                    .HasColumnName("hr_atz_estoque")
                    .HasColumnType("time without time zone");

                entity.Property(e => e.Ie)
                    .HasColumnName("ie")
                    .HasMaxLength(18);

                entity.Property(e => e.Im)
                    .HasColumnName("im")
                    .HasMaxLength(10);

                entity.Property(e => e.IndApurIpi).HasColumnName("ind_apur_ipi");

                entity.Property(e => e.IndPerfilSped)
                    .HasColumnName("ind_perfil_sped")
                    .HasMaxLength(1);

                entity.Property(e => e.Modulo).HasColumnName("modulo");

                entity.Property(e => e.NfeConjugada)
                    .HasColumnName("nfe_conjugada")
                    .HasMaxLength(1);

                entity.Property(e => e.NmFantasia)
                    .HasColumnName("nm_fantasia")
                    .HasMaxLength(50);

                entity.Property(e => e.NmFilial)
                    .IsRequired()
                    .HasColumnName("nm_filial")
                    .HasMaxLength(50);

                entity.Property(e => e.NotaEletronica)
                    .HasColumnName("nota_eletronica")
                    .HasMaxLength(1);

                entity.Property(e => e.NrLoteNfe).HasColumnName("nr_lote_nfe");

                entity.Property(e => e.NrSerieProducao)
                    .HasColumnName("nr_serie_producao")
                    .HasMaxLength(3);

                entity.Property(e => e.NrUltNfs).HasColumnName("nr_ult_nfs");

                entity.Property(e => e.Numero).HasColumnName("numero");

                entity.Property(e => e.PcCofins)
                    .HasColumnName("pc_cofins")
                    .HasColumnType("numeric(15,2)");

                entity.Property(e => e.PcPis)
                    .HasColumnName("pc_pis")
                    .HasColumnType("numeric(15,2)");

                entity.Property(e => e.Suframa)
                    .HasColumnName("suframa")
                    .HasMaxLength(9);

                entity.Property(e => e.TaxaJuros)
                    .HasColumnName("taxa_juros")
                    .HasColumnType("numeric(10,3)");

                entity.Property(e => e.TpAmbienteNfe).HasColumnName("tp_ambiente_nfe");

                entity.Property(e => e.TpAmbienteNfeMunicipal).HasColumnName("tp_ambiente_nfe_municipal");

                entity.Property(e => e.TpCliPadraoVenda)
                    .HasColumnName("tp_cli_padrao_venda")
                    .HasMaxLength(1);

                entity.Property(e => e.TpComissao)
                    .IsRequired()
                    .HasColumnName("tp_comissao")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("'I'::character varying");

                entity.Property(e => e.TpIcmsEntradaFrete)
                    .HasColumnName("tp_icms_entrada_frete")
                    .HasMaxLength(1);

                entity.Property(e => e.TpIcmsSaidaFrete)
                    .HasColumnName("tp_icms_saida_frete")
                    .HasMaxLength(1);

                entity.Property(e => e.TpPiscofinsEntradaFrete)
                    .HasColumnName("tp_piscofins_entrada_frete")
                    .HasMaxLength(1);

                entity.Property(e => e.TpPiscofinsSaidaFrete)
                    .HasColumnName("tp_piscofins_saida_frete")
                    .HasMaxLength(1);

                entity.Property(e => e.TpSistema).HasColumnName("tp_sistema");

                entity.Property(e => e.TpStatusNfe).HasColumnName("tp_status_nfe");

                entity.Property(e => e.Uf)
                    .IsRequired()
                    .HasColumnName("uf")
                    .HasMaxLength(2);

                entity.Property(e => e.VlIdGeral).HasColumnName("vl_id_geral");

                entity.Property(e => e.VlMinCsll)
                    .HasColumnName("vl_min_csll")
                    .HasColumnType("numeric(10,3)");

                entity.Property(e => e.VlMinInss)
                    .HasColumnName("vl_min_inss")
                    .HasColumnType("numeric(10,3)");

                entity.Property(e => e.VlMultaContas)
                    .HasColumnName("vl_multa_contas")
                    .HasColumnType("numeric(6,3)");

                entity.HasOne(d => d.CdContaNavigation)
                    .WithMany(p => p.Filial)
                    .HasForeignKey(d => d.CdConta)
                    .HasConstraintName("fk_filial_cxa_conta");

                entity.HasOne(d => d.CdMensagemCupomNavigation)
                    .WithMany(p => p.FilialCdMensagemCupomNavigation)
                    .HasForeignKey(d => d.CdMensagemCupom)
                    .HasConstraintName("fk_filial_msg_cupom");

                entity.HasOne(d => d.CdMensagemDavNavigation)
                    .WithMany(p => p.FilialCdMensagemDavNavigation)
                    .HasForeignKey(d => d.CdMensagemDav)
                    .HasConstraintName("fk_filial_msg_dav");

                entity.HasOne(d => d.CdMensagemIcmStNotaDevNavigation)
                    .WithMany(p => p.FilialCdMensagemIcmStNotaDevNavigation)
                    .HasForeignKey(d => d.CdMensagemIcmStNotaDev)
                    .HasConstraintName("fk_filial_msg_icm_st");

                entity.HasOne(d => d.CdMensagemPreVendaNavigation)
                    .WithMany(p => p.FilialCdMensagemPreVendaNavigation)
                    .HasForeignKey(d => d.CdMensagemPreVenda)
                    .HasConstraintName("fk_filial_msg_pre_venda");

                entity.HasOne(d => d.CdTabelaPrecoPadraoNavigation)
                    .WithMany(p => p.Filial)
                    .HasForeignKey(d => d.CdTabelaPrecoPadrao)
                    .HasConstraintName("fk_filial_preco");
            });

            modelBuilder.Entity<FilialBd>(entity =>
            {
                entity.HasKey(e => e.CdFilial);

                entity.ToTable("filial_bd");

                entity.Property(e => e.CdFilial)
                    .HasColumnName("cd_filial")
                    .ValueGeneratedNever();

                entity.Property(e => e.FlDadosContasDesatualizados)
                    .HasColumnName("fl_dados_contas_desatualizados")
                    .HasDefaultValueSql("'I'::bpchar");

                entity.Property(e => e.FlSincronizarContas).HasColumnName("fl_sincronizar_contas");

                entity.Property(e => e.NmBd)
                    .IsRequired()
                    .HasColumnName("nm_bd")
                    .HasMaxLength(200);

                entity.Property(e => e.NmFilial)
                    .IsRequired()
                    .HasColumnName("nm_filial")
                    .HasMaxLength(50);

                entity.Property(e => e.NmServidorBd)
                    .IsRequired()
                    .HasColumnName("nm_servidor_bd")
                    .HasMaxLength(100);

                entity.Property(e => e.NmUsuario)
                    .IsRequired()
                    .HasColumnName("nm_usuario")
                    .HasMaxLength(50);

                entity.Property(e => e.NrMinutosContasDesatualizado)
                    .HasColumnName("nr_minutos_contas_desatualizado")
                    .HasDefaultValueSql("10");

                entity.Property(e => e.Senha)
                    .IsRequired()
                    .HasColumnName("senha")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<FilialConfNfeNfse>(entity =>
            {
                entity.HasKey(e => e.CdFilial);

                entity.ToTable("filial_conf_nfe_nfse");

                entity.Property(e => e.CdFilial)
                    .HasColumnName("cd_filial")
                    .ValueGeneratedNever();

                entity.Property(e => e.CertificadoCaminho)
                    .HasColumnName("certificado_caminho")
                    .HasMaxLength(100);

                entity.Property(e => e.CertificadoNumeroSerie)
                    .HasColumnName("certificado_numero_serie")
                    .HasMaxLength(60);

                entity.Property(e => e.CertificadoSenha)
                    .HasColumnName("certificado_senha")
                    .HasMaxLength(20);

                entity.Property(e => e.Csc)
                    .HasColumnName("csc")
                    .HasMaxLength(36);

                entity.Property(e => e.EmailNfe)
                    .HasColumnName("email_nfe")
                    .HasMaxLength(100);

                entity.Property(e => e.FlEnviaEmail)
                    .HasColumnName("fl_envia_email")
                    .HasMaxLength(1);

                entity.Property(e => e.IdCsc)
                    .HasColumnName("id_csc")
                    .HasMaxLength(6);

                entity.Property(e => e.Logonfe)
                    .HasColumnName("logonfe")
                    .HasMaxLength(100);

                entity.Property(e => e.Logoprefeitura)
                    .HasColumnName("logoprefeitura")
                    .HasMaxLength(100);

                entity.Property(e => e.PathSchemaMdfe)
                    .HasColumnName("path_schema_mdfe")
                    .HasMaxLength(100);

                entity.Property(e => e.PathSchemaNfe)
                    .HasColumnName("path_schema_nfe")
                    .HasMaxLength(100);

                entity.Property(e => e.PathSchemaNfse)
                    .HasColumnName("path_schema_nfse")
                    .HasMaxLength(100);

                entity.Property(e => e.PathXmlMdfe)
                    .HasColumnName("path_xml_mdfe")
                    .HasMaxLength(100);

                entity.Property(e => e.PathXmlNfe)
                    .HasColumnName("path_xml_nfe")
                    .HasMaxLength(100);

                entity.Property(e => e.PathXmlNfse)
                    .HasColumnName("path_xml_nfse")
                    .HasMaxLength(100);

                entity.Property(e => e.RegimeEspecialTribNfse).HasColumnName("regime_especial_trib_nfse");

                entity.Property(e => e.SenhaWebserv)
                    .HasColumnName("senha_webserv")
                    .HasMaxLength(100);

                entity.Property(e => e.TempoEsperaConsulta).HasColumnName("tempo_espera_consulta");

                entity.Property(e => e.Tentativas).HasColumnName("tentativas");

                entity.Property(e => e.TpAmbienteMdfe)
                    .HasColumnName("tp_ambiente_mdfe")
                    .HasMaxLength(1);

                entity.Property(e => e.TpAmbienteNfe)
                    .HasColumnName("tp_ambiente_nfe")
                    .HasMaxLength(1);

                entity.Property(e => e.TpAmbienteNfse)
                    .HasColumnName("tp_ambiente_nfse")
                    .HasMaxLength(1);

                entity.Property(e => e.UsuarioWebserv)
                    .HasColumnName("usuario_webserv")
                    .HasMaxLength(100);

                entity.Property(e => e.VersaoNfe)
                    .HasColumnName("versao_nfe")
                    .HasMaxLength(1);

                entity.Property(e => e.Visualizar).HasColumnName("visualizar");
            });

            modelBuilder.Entity<FilialEmail>(entity =>
            {
                entity.HasKey(e => e.IdGeral);

                entity.ToTable("filial_email");

                entity.HasIndex(e => new { e.CdFilial, e.TpEmail })
                    .HasName("unq1_filial_email")
                    .IsUnique();

                entity.Property(e => e.IdGeral)
                    .HasColumnName("id_geral")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdFilial).HasColumnName("cd_filial");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(100);

                entity.Property(e => e.NmOrigem)
                    .HasColumnName("nm_origem")
                    .HasMaxLength(50);

                entity.Property(e => e.Porta).HasColumnName("porta");

                entity.Property(e => e.Senha)
                    .HasColumnName("senha")
                    .HasMaxLength(50);

                entity.Property(e => e.ServidorSmtp)
                    .HasColumnName("servidor_smtp")
                    .HasMaxLength(50);

                entity.Property(e => e.Ssl)
                    .HasColumnName("ssl")
                    .HasMaxLength(1);

                entity.Property(e => e.TpEmail).HasColumnName("tp_email");

                entity.Property(e => e.Usuario)
                    .HasColumnName("usuario")
                    .HasMaxLength(100);

                entity.HasOne(d => d.CdFilialNavigation)
                    .WithMany(p => p.FilialEmail)
                    .HasForeignKey(d => d.CdFilial)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_filial_email_filial");
            });

            modelBuilder.Entity<FilialIeSt>(entity =>
            {
                entity.HasKey(e => new { e.CdFilial, e.Uf });

                entity.ToTable("filial_ie_st");

                entity.Property(e => e.CdFilial).HasColumnName("cd_filial");

                entity.Property(e => e.Uf)
                    .HasColumnName("uf")
                    .HasMaxLength(2);

                entity.Property(e => e.IeSt)
                    .IsRequired()
                    .HasColumnName("ie_st")
                    .HasMaxLength(18);

                entity.HasOne(d => d.CdFilialNavigation)
                    .WithMany(p => p.FilialIeSt)
                    .HasForeignKey(d => d.CdFilial)
                    .HasConstraintName("fk_filial_ie_st_filial");
            });

            modelBuilder.Entity<Fornecedor>(entity =>
            {
                entity.HasKey(e => new { e.CdFilial, e.CdFornecedor });

                entity.ToTable("fornecedor");

                entity.Property(e => e.CdFilial).HasColumnName("cd_filial");

                entity.Property(e => e.CdFornecedor).HasColumnName("cd_fornecedor");

                entity.Property(e => e.Bairro)
                    .HasColumnName("bairro")
                    .HasMaxLength(30);

                entity.Property(e => e.CdCidade).HasColumnName("cd_cidade");

                entity.Property(e => e.CdCliente).HasColumnName("cd_cliente");

                entity.Property(e => e.CdContaContabil).HasColumnName("cd_conta_contabil");

                entity.Property(e => e.Celular)
                    .HasColumnName("celular")
                    .HasMaxLength(20);

                entity.Property(e => e.Cep)
                    .HasColumnName("cep")
                    .HasMaxLength(10);

                entity.Property(e => e.Cnpj)
                    .HasColumnName("cnpj")
                    .HasMaxLength(18);

                entity.Property(e => e.Complemento)
                    .HasColumnName("complemento")
                    .HasMaxLength(20);

                entity.Property(e => e.DtAtz)
                    .HasColumnName("dt_atz")
                    .HasColumnType("date")
                    .HasDefaultValueSql("CURRENT_DATE");

                entity.Property(e => e.DtCadastro)
                    .HasColumnName("dt_cadastro")
                    .HasColumnType("date")
                    .HasDefaultValueSql("CURRENT_DATE");

                entity.Property(e => e.EMail)
                    .HasColumnName("e_mail")
                    .HasMaxLength(70);

                entity.Property(e => e.Endereco)
                    .HasColumnName("endereco")
                    .HasMaxLength(80);

                entity.Property(e => e.Fax)
                    .HasColumnName("fax")
                    .HasMaxLength(20);

                entity.Property(e => e.FlAgricultor).HasColumnName("fl_agricultor");

                entity.Property(e => e.FlAtivo).HasColumnName("fl_ativo");

                entity.Property(e => e.FlContNcont).HasColumnName("fl_cont_ncont");

                entity.Property(e => e.FlFornecedor)
                    .HasColumnName("fl_fornecedor")
                    .HasMaxLength(1);

                entity.Property(e => e.FlSeguradora)
                    .HasColumnName("fl_seguradora")
                    .HasMaxLength(1);

                entity.Property(e => e.FlSimples)
                    .HasColumnName("fl_simples")
                    .HasMaxLength(1);

                entity.Property(e => e.FlTransportador)
                    .HasColumnName("fl_transportador")
                    .HasMaxLength(1);

                entity.Property(e => e.Fone)
                    .HasColumnName("fone")
                    .HasMaxLength(20);

                entity.Property(e => e.Inscricao)
                    .HasColumnName("inscricao")
                    .HasMaxLength(18);

                entity.Property(e => e.InscricaoSuframa)
                    .HasColumnName("inscricao_suframa")
                    .HasMaxLength(9);

                entity.Property(e => e.NmFantasia)
                    .HasColumnName("nm_fantasia")
                    .HasMaxLength(80);

                entity.Property(e => e.NmFornecedor)
                    .IsRequired()
                    .HasColumnName("nm_fornecedor")
                    .HasMaxLength(80);

                entity.Property(e => e.Numero)
                    .HasColumnName("numero")
                    .HasMaxLength(50);

                entity.Property(e => e.ObservacaoFornecedor).HasColumnName("observacao_fornecedor");

                entity.Property(e => e.PessoaContato)
                    .HasColumnName("pessoa_contato")
                    .HasMaxLength(40);

                entity.Property(e => e.Rntrc)
                    .HasColumnName("rntrc")
                    .HasMaxLength(8);

                entity.HasOne(d => d.CdContaContabilNavigation)
                    .WithMany(p => p.Fornecedor)
                    .HasForeignKey(d => d.CdContaContabil)
                    .HasConstraintName("fk_fornecedor_conta_contabil");
            });

            modelBuilder.Entity<FornecedorContato>(entity =>
            {
                entity.HasKey(e => new { e.CdFornecedor, e.CdContato });

                entity.ToTable("fornecedor_contato");

                entity.Property(e => e.CdFornecedor).HasColumnName("cd_fornecedor");

                entity.Property(e => e.CdContato).HasColumnName("cd_contato");

                entity.Property(e => e.CdFilial).HasColumnName("cd_filial");

                entity.HasOne(d => d.CdContatoNavigation)
                    .WithMany(p => p.FornecedorContato)
                    .HasForeignKey(d => d.CdContato)
                    .HasConstraintName("fk_fornecedor_contato_contato");

                entity.HasOne(d => d.CdF)
                    .WithMany(p => p.FornecedorContato)
                    .HasForeignKey(d => new { d.CdFilial, d.CdFornecedor })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_fornecedor_contato");
            });

            modelBuilder.Entity<FornecedorUnmedida>(entity =>
            {
                entity.HasKey(e => e.IdGeral);

                entity.ToTable("fornecedor_unmedida");

                entity.Property(e => e.IdGeral)
                    .HasColumnName("id_geral")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdFornecedor).HasColumnName("cd_fornecedor");

                entity.Property(e => e.DtAtz)
                    .HasColumnName("dt_atz")
                    .HasColumnType("date");

                entity.Property(e => e.UnMedida)
                    .HasColumnName("un_medida")
                    .HasMaxLength(6);

                entity.Property(e => e.UnMedidaForn)
                    .HasColumnName("un_medida_forn")
                    .HasMaxLength(6);
            });

            modelBuilder.Entity<Fornprod>(entity =>
            {
                entity.HasKey(e => new { e.CdFilial, e.CdFornecedor, e.CdProduto });

                entity.ToTable("fornprod");

                entity.Property(e => e.CdFilial).HasColumnName("cd_filial");

                entity.Property(e => e.CdFornecedor).HasColumnName("cd_fornecedor");

                entity.Property(e => e.CdProduto).HasColumnName("cd_produto");

                entity.Property(e => e.DtAtz)
                    .HasColumnName("dt_atz")
                    .HasColumnType("date")
                    .HasDefaultValueSql("CURRENT_DATE");
            });

            modelBuilder.Entity<Fornveic>(entity =>
            {
                entity.HasKey(e => new { e.CdFilial, e.IdGeral });

                entity.ToTable("fornveic");

                entity.HasIndex(e => new { e.CdFornecedor, e.CdVeiculo, e.PlacaVeiculo })
                    .HasName("unq_fornveic")
                    .IsUnique();

                entity.Property(e => e.CdFilial).HasColumnName("cd_filial");

                entity.Property(e => e.IdGeral).HasColumnName("id_geral");

                entity.Property(e => e.Capacidade)
                    .HasColumnName("capacidade")
                    .HasColumnType("numeric(9,2)");

                entity.Property(e => e.CdFornecedor).HasColumnName("cd_fornecedor");

                entity.Property(e => e.CdVeiculo).HasColumnName("cd_veiculo");

                entity.Property(e => e.DtAtz).HasColumnName("dt_atz");

                entity.Property(e => e.Observacoes)
                    .HasColumnName("observacoes")
                    .HasMaxLength(2000);

                entity.Property(e => e.PlacaVeiculo)
                    .HasColumnName("placa_veiculo")
                    .HasMaxLength(8);

                entity.Property(e => e.Tara)
                    .HasColumnName("tara")
                    .HasColumnType("numeric(9,2)");

                entity.Property(e => e.TpCarroceria).HasColumnName("tp_carroceria");

                entity.Property(e => e.TpRodado).HasColumnName("tp_rodado");

                entity.Property(e => e.Uf)
                    .HasColumnName("uf")
                    .HasMaxLength(2);

                entity.HasOne(d => d.CdFilialNavigation)
                    .WithMany(p => p.Fornveic)
                    .HasForeignKey(d => d.CdFilial)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_fornveic_filial");

                entity.HasOne(d => d.CdF)
                    .WithMany(p => p.Fornveic)
                    .HasForeignKey(d => new { d.CdFilial, d.CdFornecedor })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_fornveic_fornecedor");

                entity.HasOne(d => d.Cd)
                    .WithMany(p => p.Fornveic)
                    .HasForeignKey(d => new { d.CdFilial, d.CdVeiculo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_fornveic_veiculo");
            });

            modelBuilder.Entity<FrenteCaixa>(entity =>
            {
                entity.HasKey(e => e.CdFrenteCaixa);

                entity.ToTable("frente_caixa");

                entity.Property(e => e.CdFrenteCaixa)
                    .HasColumnName("cd_frente_caixa")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdOperacao).HasColumnName("cd_operacao");

                entity.Property(e => e.CdTabelaPreco).HasColumnName("cd_tabela_preco");

                entity.Property(e => e.Exporta)
                    .IsRequired()
                    .HasColumnName("exporta")
                    .HasMaxLength(200);

                entity.Property(e => e.FlUtilizado)
                    .IsRequired()
                    .HasColumnName("fl_utilizado")
                    .HasMaxLength(1);

                entity.Property(e => e.Importa)
                    .IsRequired()
                    .HasColumnName("importa")
                    .HasMaxLength(200);

                entity.Property(e => e.NmFrenteCaixa)
                    .IsRequired()
                    .HasColumnName("nm_frente_caixa")
                    .HasMaxLength(60);

                entity.Property(e => e.NomeArquivo)
                    .IsRequired()
                    .HasColumnName("nome_arquivo")
                    .HasMaxLength(20);

                entity.HasOne(d => d.CdOperacaoNavigation)
                    .WithMany(p => p.FrenteCaixa)
                    .HasForeignKey(d => d.CdOperacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_frente_caixa_1");

                entity.HasOne(d => d.CdTabelaPrecoNavigation)
                    .WithMany(p => p.FrenteCaixa)
                    .HasForeignKey(d => d.CdTabelaPreco)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_frente_caixa_2");
            });

            modelBuilder.Entity<Funcionario>(entity =>
            {
                entity.HasKey(e => new { e.CdFilial, e.CdFuncionario });

                entity.ToTable("funcionario");

                entity.Property(e => e.CdFilial).HasColumnName("cd_filial");

                entity.Property(e => e.CdFuncionario).HasColumnName("cd_funcionario");

                entity.Property(e => e.Bairro)
                    .HasColumnName("bairro")
                    .HasMaxLength(30);

                entity.Property(e => e.CdCaixa).HasColumnName("cd_caixa");

                entity.Property(e => e.CdCargo).HasColumnName("cd_cargo");

                entity.Property(e => e.CdCidade).HasColumnName("cd_cidade");

                entity.Property(e => e.CdFilialPadrao).HasColumnName("cd_filial_padrao");

                entity.Property(e => e.CdUsr).HasColumnName("cd_usr");

                entity.Property(e => e.CdUsuario).HasColumnName("cd_usuario");

                entity.Property(e => e.Cep)
                    .HasColumnName("cep")
                    .HasMaxLength(10);

                entity.Property(e => e.Cnh)
                    .HasColumnName("cnh")
                    .HasMaxLength(18);

                entity.Property(e => e.CotaMensal)
                    .HasColumnName("cota_mensal")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.Cpf)
                    .HasColumnName("cpf")
                    .HasMaxLength(18);

                entity.Property(e => e.CustoHora)
                    .HasColumnName("custo_hora")
                    .HasColumnType("numeric(9,2)");

                entity.Property(e => e.DtAdmissao)
                    .HasColumnName("dt_admissao")
                    .HasColumnType("date")
                    .HasDefaultValueSql("CURRENT_DATE");

                entity.Property(e => e.DtAniversario)
                    .HasColumnName("dt_aniversario")
                    .HasColumnType("date");

                entity.Property(e => e.DtAtz)
                    .HasColumnName("dt_atz")
                    .HasColumnType("date")
                    .HasDefaultValueSql("CURRENT_DATE");

                entity.Property(e => e.EMail)
                    .HasColumnName("e_mail")
                    .HasMaxLength(80);

                entity.Property(e => e.Endereco)
                    .HasColumnName("endereco")
                    .HasMaxLength(80);

                entity.Property(e => e.Fax)
                    .HasColumnName("fax")
                    .HasMaxLength(20);

                entity.Property(e => e.FlAlterarFilial).HasColumnName("fl_alterar_filial");

                entity.Property(e => e.FlAtivo)
                    .HasColumnName("fl_ativo")
                    .HasDefaultValueSql("'S'::bpchar");

                entity.Property(e => e.FlControlarAcesso).HasColumnName("fl_controlar_acesso");

                entity.Property(e => e.FlExibeCustos)
                    .HasColumnName("fl_exibe_custos")
                    .HasMaxLength(1);

                entity.Property(e => e.FlMecanico).HasColumnName("fl_mecanico");

                entity.Property(e => e.FlNaoAcessaValores).HasColumnName("fl_nao_acessa_valores");

                entity.Property(e => e.FlUsuario).HasColumnName("fl_usuario");

                entity.Property(e => e.FlVeSaldoCxaEmpFechamento)
                    .HasColumnName("fl_ve_saldo_cxa_emp_fechamento")
                    .HasMaxLength(1);

                entity.Property(e => e.FlVendedor).HasColumnName("fl_vendedor");

                entity.Property(e => e.Fone)
                    .HasColumnName("fone")
                    .HasMaxLength(20);

                entity.Property(e => e.Login)
                    .HasColumnName("login")
                    .HasMaxLength(15);

                entity.Property(e => e.MsgPadraoNfe).HasColumnName("msg_padrao_nfe");

                entity.Property(e => e.NmFuncionario)
                    .IsRequired()
                    .HasColumnName("nm_funcionario")
                    .HasMaxLength(80);

                entity.Property(e => e.NmUsuarioSmtp)
                    .HasColumnName("nm_usuario_smtp")
                    .HasMaxLength(50);

                entity.Property(e => e.Pis)
                    .HasColumnName("pis")
                    .HasMaxLength(18);

                entity.Property(e => e.PortaSmtp).HasColumnName("porta_smtp");

                entity.Property(e => e.Rg)
                    .HasColumnName("rg")
                    .HasMaxLength(18);

                entity.Property(e => e.Senha)
                    .HasColumnName("senha")
                    .HasMaxLength(10);

                entity.Property(e => e.SenhaSmtp)
                    .HasColumnName("senha_smtp")
                    .HasMaxLength(50);

                entity.Property(e => e.SmtpEmail)
                    .HasColumnName("smtp_email")
                    .HasMaxLength(100);

                entity.Property(e => e.SslSmtp)
                    .HasColumnName("ssl_smtp")
                    .HasMaxLength(1);

                entity.Property(e => e.ValorVenda)
                    .HasColumnName("valor_venda")
                    .HasColumnType("numeric(9,2)");

                entity.HasOne(d => d.Cd)
                    .WithMany(p => p.Funcionario)
                    .HasForeignKey(d => new { d.CdCargo, d.CdFilial })
                    .HasConstraintName("cargo_funcionario_fk");
            });

            modelBuilder.Entity<GrupoComissao>(entity =>
            {
                entity.HasKey(e => e.CdGrupoComissao);

                entity.ToTable("grupo_comissao");

                entity.Property(e => e.CdGrupoComissao)
                    .HasColumnName("cd_grupo_comissao")
                    .ValueGeneratedNever();

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasColumnName("descricao")
                    .HasMaxLength(40);

                entity.Property(e => e.PcComissao)
                    .HasColumnName("pc_comissao")
                    .HasColumnType("numeric(9,2)");
            });

            modelBuilder.Entity<GrupoOperacaoEs>(entity =>
            {
                entity.HasKey(e => e.CdGrupo);

                entity.ToTable("grupo_operacao_es");

                entity.Property(e => e.CdGrupo)
                    .HasColumnName("cd_grupo")
                    .HasMaxLength(2)
                    .ValueGeneratedNever();

                entity.Property(e => e.NmGrupo)
                    .HasColumnName("nm_grupo")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Gruprod>(entity =>
            {
                entity.HasKey(e => e.CdGruprod);

                entity.ToTable("gruprod");

                entity.Property(e => e.CdGruprod)
                    .HasColumnName("cd_gruprod")
                    .ValueGeneratedNever();

                entity.Property(e => e.DtAtz)
                    .HasColumnName("dt_atz")
                    .HasColumnType("date")
                    .HasDefaultValueSql("CURRENT_DATE");

                entity.Property(e => e.NmGruprod)
                    .IsRequired()
                    .HasColumnName("nm_gruprod")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<Hash>(entity =>
            {
                entity.HasKey(e => e.IdGeral);

                entity.ToTable("HASH");

                entity.Property(e => e.IdGeral)
                    .HasColumnName("id_geral")
                    .ValueGeneratedNever();

                entity.Property(e => e.FlValido)
                    .HasColumnName("fl_valido")
                    .HasMaxLength(1);

                entity.Property(e => e.Hash1)
                    .IsRequired()
                    .HasColumnName("HASH")
                    .HasMaxLength(70);

                entity.Property(e => e.NmTabela)
                    .IsRequired()
                    .HasColumnName("nm_tabela")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<HelpAtz>(entity =>
            {
                entity.HasKey(e => e.IdGeral);

                entity.ToTable("help_atz");

                entity.Property(e => e.IdGeral)
                    .HasColumnName("id_geral")
                    .ValueGeneratedNever();

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasColumnName("descricao");

                entity.Property(e => e.VersaoBd).HasColumnName("versao_bd");

                entity.Property(e => e.VersaoSistema)
                    .IsRequired()
                    .HasColumnName("versao_sistema")
                    .HasMaxLength(12);
            });

            modelBuilder.Entity<HelpAtzAlteracao>(entity =>
            {
                entity.HasKey(e => e.IdGeral);

                entity.ToTable("help_atz_alteracao");

                entity.Property(e => e.IdGeral)
                    .HasColumnName("id_geral")
                    .ValueGeneratedNever();

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasColumnName("descricao");

                entity.Property(e => e.IdHelpAtz).HasColumnName("id_help_atz");

                entity.Property(e => e.IdImagem).HasColumnName("id_imagem");

                entity.Property(e => e.Titulo)
                    .IsRequired()
                    .HasColumnName("titulo");

                entity.HasOne(d => d.IdHelpAtzNavigation)
                    .WithMany(p => p.HelpAtzAlteracao)
                    .HasForeignKey(d => d.IdHelpAtz)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_help_atz_alteracao_help_atz");
            });

            modelBuilder.Entity<Impfiscal>(entity =>
            {
                entity.HasKey(e => e.CdImpfiscal);

                entity.ToTable("impfiscal");

                entity.Property(e => e.CdImpfiscal)
                    .HasColumnName("cd_impfiscal")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdModelo).HasColumnName("cd_modelo");

                entity.Property(e => e.CdUsuarioEcf).HasColumnName("cd_usuario_ecf");

                entity.Property(e => e.Cniee)
                    .IsRequired()
                    .HasColumnName("cniee")
                    .HasMaxLength(6);

                entity.Property(e => e.DtAtz)
                    .HasColumnName("dt_atz")
                    .HasColumnType("date")
                    .HasDefaultValueSql("CURRENT_DATE");

                entity.Property(e => e.DtInstalacaoSb)
                    .HasColumnName("dt_instalacao_sb")
                    .HasColumnType("date");

                entity.Property(e => e.FlIntervencao).HasColumnName("fl_intervencao");

                entity.Property(e => e.FlLmfAutomatica)
                    .HasColumnName("fl_lmf_automatica")
                    .HasMaxLength(1);

                entity.Property(e => e.FlMfAdicional)
                    .IsRequired()
                    .HasColumnName("fl_mf_adicional")
                    .HasMaxLength(1);

                entity.Property(e => e.HashImpfiscalE1)
                    .HasColumnName("hash_impfiscal_e1")
                    .HasMaxLength(70);

                entity.Property(e => e.HashImpfiscalR1)
                    .HasColumnName("hash_impfiscal_r1")
                    .HasMaxLength(70);

                entity.Property(e => e.HashImpfiscalR2)
                    .HasColumnName("hash_impfiscal_r2")
                    .HasMaxLength(70);

                entity.Property(e => e.HashImpfiscalR3)
                    .HasColumnName("hash_impfiscal_r3")
                    .HasMaxLength(70);

                entity.Property(e => e.HashImpfiscalR4)
                    .HasColumnName("hash_impfiscal_r4")
                    .HasMaxLength(70);

                entity.Property(e => e.HashImpfiscalR5)
                    .HasColumnName("hash_impfiscal_r5")
                    .HasMaxLength(70);

                entity.Property(e => e.HashImpfiscalR6)
                    .HasColumnName("hash_impfiscal_r6")
                    .HasMaxLength(70);

                entity.Property(e => e.HashImpfiscalR7)
                    .HasColumnName("hash_impfiscal_r7")
                    .HasMaxLength(70);

                entity.Property(e => e.HrInstalacaoSb)
                    .HasColumnName("hr_instalacao_sb")
                    .HasColumnType("time without time zone");

                entity.Property(e => e.NmAPrazo)
                    .HasColumnName("nm_a_prazo")
                    .HasMaxLength(25);

                entity.Property(e => e.NmCartao)
                    .HasColumnName("nm_cartao")
                    .HasMaxLength(25);

                entity.Property(e => e.NmCheque)
                    .HasColumnName("nm_cheque")
                    .HasMaxLength(25);

                entity.Property(e => e.NmConsultaCheque)
                    .HasColumnName("nm_consulta_cheque")
                    .HasMaxLength(25);

                entity.Property(e => e.NmDinheiro)
                    .HasColumnName("nm_dinheiro")
                    .HasMaxLength(25);

                entity.Property(e => e.NmImpfiscal)
                    .IsRequired()
                    .HasColumnName("nm_impfiscal")
                    .HasMaxLength(40);

                entity.Property(e => e.NmMarca)
                    .IsRequired()
                    .HasColumnName("nm_marca")
                    .HasMaxLength(20);

                entity.Property(e => e.NmModelo)
                    .IsRequired()
                    .HasColumnName("nm_modelo")
                    .HasMaxLength(20);

                entity.Property(e => e.NmOutros)
                    .HasColumnName("nm_outros")
                    .HasMaxLength(25);

                entity.Property(e => e.NrPdv).HasColumnName("nr_pdv");

                entity.Property(e => e.NrSerie)
                    .IsRequired()
                    .HasColumnName("nr_serie")
                    .HasMaxLength(80);

                entity.Property(e => e.PortaComunicacao)
                    .IsRequired()
                    .HasColumnName("porta_comunicacao")
                    .HasMaxLength(10);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasColumnName("tipo")
                    .HasMaxLength(10);

                entity.Property(e => e.VersaoSb)
                    .IsRequired()
                    .HasColumnName("versao_sb")
                    .HasMaxLength(11);
            });

            modelBuilder.Entity<ImpfiscalAliquota>(entity =>
            {
                entity.HasKey(e => new { e.CdImpfiscal, e.PcImposto, e.FlImposto });

                entity.ToTable("impfiscal_aliquota");

                entity.Property(e => e.CdImpfiscal).HasColumnName("cd_impfiscal");

                entity.Property(e => e.PcImposto).HasColumnName("pc_imposto");

                entity.Property(e => e.FlImposto)
                    .HasColumnName("fl_imposto")
                    .HasMaxLength(1);

                entity.Property(e => e.NrOrdemEcf).HasColumnName("nr_ordem_ecf");

                entity.HasOne(d => d.CdImpfiscalNavigation)
                    .WithMany(p => p.ImpfiscalAliquota)
                    .HasForeignKey(d => d.CdImpfiscal)
                    .HasConstraintName("fk_impfiscal_aliquota_impfiscal");
            });

            modelBuilder.Entity<LctoFlex>(entity =>
            {
                entity.HasKey(e => e.IdGeral);

                entity.ToTable("lcto_flex");

                entity.Property(e => e.IdGeral)
                    .HasColumnName("id_geral")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdFilial).HasColumnName("cd_filial");

                entity.Property(e => e.CdVendedor).HasColumnName("cd_vendedor");

                entity.Property(e => e.DtLcto)
                    .HasColumnName("dt_lcto")
                    .HasColumnType("date")
                    .HasDefaultValueSql("CURRENT_DATE");

                entity.Property(e => e.FlDebCred)
                    .IsRequired()
                    .HasColumnName("fl_deb_cred")
                    .HasMaxLength(1);

                entity.Property(e => e.NrDocumento).HasColumnName("nr_documento");

                entity.Property(e => e.NrSequencia).HasColumnName("nr_sequencia");

                entity.Property(e => e.Obs).HasColumnName("obs");

                entity.Property(e => e.Valor)
                    .HasColumnName("valor")
                    .HasColumnType("numeric(15,2)");

                entity.HasOne(d => d.CdFilialNavigation)
                    .WithMany(p => p.LctoFlex)
                    .HasForeignKey(d => d.CdFilial)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_lcto_flex_filial");

                entity.HasOne(d => d.Cd)
                    .WithMany(p => p.LctoFlex)
                    .HasForeignKey(d => new { d.CdFilial, d.CdVendedor })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_lcto_flex_funcionario");

                entity.HasOne(d => d.Nfsi)
                    .WithMany(p => p.LctoFlex)
                    .HasForeignKey(d => new { d.CdFilial, d.NrDocumento, d.NrSequencia })
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_lcto_flex_nfsi");
            });

            modelBuilder.Entity<Login>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Usuario).IsRequired();
            });

            modelBuilder.Entity<LogSistema>(entity =>
            {
                entity.HasKey(e => e.IdGeral);

                entity.ToTable("log_sistema");

                entity.Property(e => e.IdGeral)
                    .HasColumnName("id_geral")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdUsuario).HasColumnName("cd_usuario");

                entity.Property(e => e.DtHrExclusao)
                    .HasColumnName("dt_hr_exclusao")
                    .HasColumnType("date");

                entity.Property(e => e.Observacao).HasColumnName("observacao");

                entity.Property(e => e.Tabela)
                    .HasColumnName("tabela")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<Marca>(entity =>
            {
                entity.HasKey(e => e.CdMarca);

                entity.ToTable("marca");

                entity.Property(e => e.CdMarca)
                    .HasColumnName("cd_marca")
                    .ValueGeneratedNever();

                entity.Property(e => e.DtAtz)
                    .HasColumnName("dt_atz")
                    .HasColumnType("date")
                    .HasDefaultValueSql("CURRENT_DATE");

                entity.Property(e => e.NmMarca)
                    .IsRequired()
                    .HasColumnName("nm_marca")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<Mdfe>(entity =>
            {
                entity.HasKey(e => e.IdGeral);

                entity.ToTable("mdfe");

                entity.HasIndex(e => new { e.CdFilial, e.CdModelo, e.NrSerie, e.NrMdf })
                    .HasName("unq_mdfe")
                    .IsUnique();

                entity.Property(e => e.IdGeral)
                    .HasColumnName("id_geral")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArqXml).HasColumnName("arq_xml");

                entity.Property(e => e.CdCidadeCarregamento).HasColumnName("cd_cidade_carregamento");

                entity.Property(e => e.CdFilial).HasColumnName("cd_filial");

                entity.Property(e => e.CdModalidade).HasColumnName("cd_modalidade");

                entity.Property(e => e.CdModelo)
                    .IsRequired()
                    .HasColumnName("cd_modelo")
                    .HasMaxLength(3);

                entity.Property(e => e.CdProprietarioVeiculo).HasColumnName("cd_proprietario_veiculo");

                entity.Property(e => e.CdStatusMdfe).HasColumnName("cd_status_mdfe");

                entity.Property(e => e.ChaveAcessoMdfe)
                    .HasColumnName("chave_acesso_mdfe")
                    .HasMaxLength(44);

                entity.Property(e => e.DtAtz).HasColumnName("dt_atz");

                entity.Property(e => e.DtEmissao).HasColumnName("dt_emissao");

                entity.Property(e => e.IdFornveic).HasColumnName("id_fornveic");

                entity.Property(e => e.NrMdf).HasColumnName("nr_mdf");

                entity.Property(e => e.NrProtocoloMdfe)
                    .HasColumnName("nr_protocolo_mdfe")
                    .HasMaxLength(15);

                entity.Property(e => e.NrReciboMdfe)
                    .HasColumnName("nr_recibo_mdfe")
                    .HasMaxLength(15);

                entity.Property(e => e.NrSerie)
                    .IsRequired()
                    .HasColumnName("nr_serie")
                    .HasMaxLength(3);

                entity.Property(e => e.PesoBrutoCarga)
                    .HasColumnName("peso_bruto_carga")
                    .HasColumnType("numeric(15,4)");

                entity.Property(e => e.QtCt).HasColumnName("qt_ct");

                entity.Property(e => e.QtCte).HasColumnName("qt_cte");

                entity.Property(e => e.QtNf).HasColumnName("qt_nf");

                entity.Property(e => e.QtNfe).HasColumnName("qt_nfe");

                entity.Property(e => e.TpEmissao).HasColumnName("tp_emissao");

                entity.Property(e => e.TpEmitente).HasColumnName("tp_emitente");

                entity.Property(e => e.UfDescarregamento)
                    .IsRequired()
                    .HasColumnName("uf_descarregamento")
                    .HasMaxLength(2);

                entity.Property(e => e.VlCarga)
                    .HasColumnName("vl_carga")
                    .HasColumnType("numeric(15,2)");

                entity.HasOne(d => d.CdCidadeCarregamentoNavigation)
                    .WithMany(p => p.Mdfe)
                    .HasForeignKey(d => d.CdCidadeCarregamento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_mdfe_cidade");

                entity.HasOne(d => d.CdFilialNavigation)
                    .WithMany(p => p.Mdfe)
                    .HasForeignKey(d => d.CdFilial)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_mdfe_filial");

                entity.HasOne(d => d.CdModeloNavigation)
                    .WithMany(p => p.Mdfe)
                    .HasForeignKey(d => d.CdModelo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_mdfe_modelo_dcto");

                entity.HasOne(d => d.NrSerieNavigation)
                    .WithMany(p => p.Mdfe)
                    .HasForeignKey(d => d.NrSerie)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_mdfe_serie");

                entity.HasOne(d => d.Cd)
                    .WithMany(p => p.Mdfe)
                    .HasForeignKey(d => new { d.CdFilial, d.CdProprietarioVeiculo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_mdfe_proprietario");

                entity.HasOne(d => d.Fornveic)
                    .WithMany(p => p.Mdfe)
                    .HasForeignKey(d => new { d.CdFilial, d.IdFornveic })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_mdfe_fornveic");
            });

            modelBuilder.Entity<MdfeCondutor>(entity =>
            {
                entity.HasKey(e => e.IdGeral);

                entity.ToTable("mdfe_condutor");

                entity.Property(e => e.IdGeral)
                    .HasColumnName("id_geral")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdFilial).HasColumnName("cd_filial");

                entity.Property(e => e.CdFornecedor).HasColumnName("cd_fornecedor");

                entity.Property(e => e.CdMotorista).HasColumnName("cd_motorista");

                entity.Property(e => e.DtAtz).HasColumnName("dt_atz");

                entity.Property(e => e.IdMdfe).HasColumnName("id_mdfe");

                entity.HasOne(d => d.CdFilialNavigation)
                    .WithMany(p => p.MdfeCondutor)
                    .HasForeignKey(d => d.CdFilial)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_mdfe_condutor_filial");

                entity.HasOne(d => d.CdMotoristaNavigation)
                    .WithMany(p => p.MdfeCondutor)
                    .HasForeignKey(d => d.CdMotorista)
                    .HasConstraintName("fk_mdfe_condutor_motorista");

                entity.HasOne(d => d.IdMdfeNavigation)
                    .WithMany(p => p.MdfeCondutor)
                    .HasForeignKey(d => d.IdMdfe)
                    .HasConstraintName("fk_mdfe_condutor_mdfe");

                entity.HasOne(d => d.CdF)
                    .WithMany(p => p.MdfeCondutor)
                    .HasForeignKey(d => new { d.CdFilial, d.CdFornecedor })
                    .HasConstraintName("fk_mdfe_condutor_fornecedor");
            });

            modelBuilder.Entity<MdfeDocumento>(entity =>
            {
                entity.HasKey(e => e.IdGeral);

                entity.ToTable("mdfe_documento");

                entity.Property(e => e.IdGeral)
                    .HasColumnName("id_geral")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdFilial).HasColumnName("cd_filial");

                entity.Property(e => e.DtAtz).HasColumnName("dt_atz");

                entity.Property(e => e.IdMdfe).HasColumnName("id_mdfe");

                entity.Property(e => e.IdNf).HasColumnName("id_nf");

                entity.HasOne(d => d.CdFilialNavigation)
                    .WithMany(p => p.MdfeDocumento)
                    .HasForeignKey(d => d.CdFilial)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_mdfe_documento_filial");

                entity.HasOne(d => d.IdMdfeNavigation)
                    .WithMany(p => p.MdfeDocumento)
                    .HasForeignKey(d => d.IdMdfe)
                    .HasConstraintName("fk_mdfe_documento_mdfe");
            });

            modelBuilder.Entity<MdfeEvento>(entity =>
            {
                entity.HasKey(e => e.IdGeral);

                entity.ToTable("mdfe_evento");

                entity.Property(e => e.IdGeral)
                    .HasColumnName("id_geral")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArqXml).HasColumnName("arq_xml");

                entity.Property(e => e.CdFilial).HasColumnName("cd_filial");

                entity.Property(e => e.DtAtz).HasColumnName("dt_atz");

                entity.Property(e => e.IdMdfe).HasColumnName("id_mdfe");

                entity.Property(e => e.NmEvento)
                    .IsRequired()
                    .HasColumnName("nm_evento")
                    .HasMaxLength(40);

                entity.Property(e => e.NrProtocolo)
                    .HasColumnName("nr_protocolo")
                    .HasMaxLength(15);

                entity.Property(e => e.NrSequencia).HasColumnName("nr_sequencia");

                entity.Property(e => e.TpEvento).HasColumnName("tp_evento");

                entity.HasOne(d => d.CdFilialNavigation)
                    .WithMany(p => p.MdfeEvento)
                    .HasForeignKey(d => d.CdFilial)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_mdfe_evento_filial");

                entity.HasOne(d => d.IdMdfeNavigation)
                    .WithMany(p => p.MdfeEvento)
                    .HasForeignKey(d => d.IdMdfe)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_mdfe_evento_mdfe");
            });

            modelBuilder.Entity<MdfePercurso>(entity =>
            {
                entity.HasKey(e => e.IdGeral);

                entity.ToTable("mdfe_percurso");

                entity.HasIndex(e => new { e.IdMdfe, e.NrSequencia })
                    .HasName("unq_mdfe_percurso")
                    .IsUnique();

                entity.Property(e => e.IdGeral)
                    .HasColumnName("id_geral")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdFilial).HasColumnName("cd_filial");

                entity.Property(e => e.DtAtz).HasColumnName("dt_atz");

                entity.Property(e => e.IdMdfe).HasColumnName("id_mdfe");

                entity.Property(e => e.NrSequencia).HasColumnName("nr_sequencia");

                entity.Property(e => e.Uf)
                    .HasColumnName("uf")
                    .HasMaxLength(2);

                entity.HasOne(d => d.CdFilialNavigation)
                    .WithMany(p => p.MdfePercurso)
                    .HasForeignKey(d => d.CdFilial)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_mdfe_percurso_filial");

                entity.HasOne(d => d.IdMdfeNavigation)
                    .WithMany(p => p.MdfePercurso)
                    .HasForeignKey(d => d.IdMdfe)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_mdfe_percurso_mdfe");
            });

            modelBuilder.Entity<Medida>(entity =>
            {
                entity.HasKey(e => e.CdMedida);

                entity.ToTable("medida");

                entity.Property(e => e.CdMedida)
                    .HasColumnName("cd_medida")
                    .ValueGeneratedNever();

                entity.Property(e => e.DtAtz)
                    .HasColumnName("dt_atz")
                    .HasColumnType("date");

                entity.Property(e => e.NmMedida)
                    .IsRequired()
                    .HasColumnName("nm_medida")
                    .HasMaxLength(80);
            });

            modelBuilder.Entity<MensagemNota>(entity =>
            {
                entity.HasKey(e => e.CdMensagem);

                entity.ToTable("mensagem_nota");

                entity.Property(e => e.CdMensagem)
                    .HasColumnName("cd_mensagem")
                    .ValueGeneratedNever();

                entity.Property(e => e.FlFiscal)
                    .IsRequired()
                    .HasColumnName("fl_fiscal")
                    .HasMaxLength(1);

                entity.Property(e => e.FlInformacoesFisco).HasColumnName("fl_informacoes_fisco");

                entity.Property(e => e.Mensagem)
                    .IsRequired()
                    .HasColumnName("mensagem");

                entity.Property(e => e.NmMensagem)
                    .HasColumnName("nm_mensagem")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<Modelo>(entity =>
            {
                entity.HasKey(e => e.CdModelo);

                entity.ToTable("modelo");

                entity.Property(e => e.CdModelo)
                    .HasColumnName("cd_modelo")
                    .ValueGeneratedNever();

                entity.Property(e => e.DtAtz)
                    .HasColumnName("dt_atz")
                    .HasColumnType("date");

                entity.Property(e => e.NmModelo)
                    .IsRequired()
                    .HasColumnName("nm_modelo")
                    .HasMaxLength(80);
            });

            modelBuilder.Entity<ModeloDcto>(entity =>
            {
                entity.HasKey(e => e.CdModelo);

                entity.ToTable("modelo_dcto");

                entity.Property(e => e.CdModelo)
                    .HasColumnName("cd_modelo")
                    .HasMaxLength(3)
                    .ValueGeneratedNever();

                entity.Property(e => e.NmModelo)
                    .HasColumnName("nm_modelo")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Montadora>(entity =>
            {
                entity.HasKey(e => new { e.CdFilial, e.CdMontadora });

                entity.ToTable("montadora");

                entity.Property(e => e.CdFilial).HasColumnName("cd_filial");

                entity.Property(e => e.CdMontadora).HasColumnName("cd_montadora");

                entity.Property(e => e.DtAtz)
                    .HasColumnName("dt_atz")
                    .HasColumnType("date")
                    .HasDefaultValueSql("CURRENT_DATE");

                entity.Property(e => e.NmMontadora)
                    .IsRequired()
                    .HasColumnName("nm_montadora")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<MotivoDevolucao>(entity =>
            {
                entity.HasKey(e => e.CdMotivoDevolucao);

                entity.ToTable("motivo_devolucao");

                entity.Property(e => e.CdMotivoDevolucao)
                    .HasColumnName("cd_motivo_devolucao")
                    .ValueGeneratedNever();

                entity.Property(e => e.DtAtz).HasColumnName("dt_atz");

                entity.Property(e => e.NmMotivoDevolucao)
                    .IsRequired()
                    .HasColumnName("nm_motivo_devolucao")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Motorista>(entity =>
            {
                entity.HasKey(e => e.CdMotorista);

                entity.ToTable("motorista");

                entity.Property(e => e.CdMotorista)
                    .HasColumnName("cd_motorista")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdCidade).HasColumnName("cd_cidade");

                entity.Property(e => e.CdFilial).HasColumnName("cd_filial");

                entity.Property(e => e.CdTransportador).HasColumnName("cd_transportador");

                entity.Property(e => e.Celular)
                    .HasColumnName("celular")
                    .HasMaxLength(15);

                entity.Property(e => e.Cnh)
                    .HasColumnName("cnh")
                    .HasMaxLength(11);

                entity.Property(e => e.Cpf)
                    .HasColumnName("cpf")
                    .HasMaxLength(11);

                entity.Property(e => e.Nome)
                    .HasColumnName("nome")
                    .HasMaxLength(80);

                entity.Property(e => e.Telefone)
                    .HasColumnName("telefone")
                    .HasMaxLength(15);

                entity.HasOne(d => d.CdCidadeNavigation)
                    .WithMany(p => p.Motorista)
                    .HasForeignKey(d => d.CdCidade)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_motorista_cidade");

                entity.HasOne(d => d.Cd)
                    .WithMany(p => p.Motorista)
                    .HasForeignKey(d => new { d.CdFilial, d.CdTransportador })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_motorista_transportador");
            });

            modelBuilder.Entity<MovimentoCxa>(entity =>
            {
                entity.HasKey(e => new { e.CdFilial, e.CdCaixa, e.NrLcto });

                entity.ToTable("movimento_cxa");

                entity.HasIndex(e => e.CdCaixa)
                    .HasName("idx_movimento_cd_caixa");

                entity.HasIndex(e => e.CdClifor)
                    .HasName("idx_mvto_cxa_cliente");

                entity.HasIndex(e => e.CdHistorico)
                    .HasName("idx_movimento_cd_historico");

                entity.HasIndex(e => e.DctoOrigem)
                    .HasName("idx_movimento_cxa_ori");

                entity.HasIndex(e => e.NrDocumento)
                    .HasName("ind_movimento_cxa_nr_documento");

                entity.HasIndex(e => e.NrLcto)
                    .HasName("ind_movimento_cxa_max");

                entity.HasIndex(e => new { e.CdCaixa, e.CdFilial, e.NrLcto })
                    .HasName("ind_movimento_cxa_chave");

                entity.Property(e => e.CdFilial).HasColumnName("cd_filial");

                entity.Property(e => e.CdCaixa).HasColumnName("cd_caixa");

                entity.Property(e => e.NrLcto).HasColumnName("nr_lcto");

                entity.Property(e => e.CdAgencia)
                    .HasColumnName("cd_agencia")
                    .HasMaxLength(10);

                entity.Property(e => e.CdBanco).HasColumnName("cd_banco");

                entity.Property(e => e.CdClifor).HasColumnName("cd_clifor");

                entity.Property(e => e.CdConta).HasColumnName("cd_conta");

                entity.Property(e => e.CdFuncionario).HasColumnName("cd_funcionario");

                entity.Property(e => e.CdHistorico).HasColumnName("cd_historico");

                entity.Property(e => e.Complemento)
                    .HasColumnName("complemento")
                    .HasMaxLength(1000);

                entity.Property(e => e.DctoOrigem)
                    .HasColumnName("dcto_origem")
                    .HasMaxLength(25);

                entity.Property(e => e.Destinatario)
                    .HasColumnName("destinatario")
                    .HasMaxLength(80);

                entity.Property(e => e.DtAtz)
                    .HasColumnName("dt_atz")
                    .HasColumnType("date")
                    .HasDefaultValueSql("CURRENT_DATE");

                entity.Property(e => e.DtBomPara)
                    .HasColumnName("dt_bom_para")
                    .HasColumnType("date");

                entity.Property(e => e.DtCompensacao)
                    .HasColumnName("dt_compensacao")
                    .HasColumnType("date");

                entity.Property(e => e.DtInclusao)
                    .HasColumnName("dt_inclusao")
                    .HasColumnType("date");

                entity.Property(e => e.DtMvto)
                    .HasColumnName("dt_mvto")
                    .HasColumnType("date");

                entity.Property(e => e.FlCancelado).HasColumnName("fl_cancelado");

                entity.Property(e => e.FlCheque)
                    .IsRequired()
                    .HasColumnName("fl_cheque")
                    .HasMaxLength(1);

                entity.Property(e => e.FlCompensado)
                    .HasColumnName("fl_compensado")
                    .HasMaxLength(1);

                entity.Property(e => e.FlDestino)
                    .HasColumnName("fl_destino")
                    .HasMaxLength(1);

                entity.Property(e => e.FlOrigem)
                    .HasColumnName("fl_origem")
                    .HasMaxLength(1);

                entity.Property(e => e.HashA2)
                    .HasColumnName("hash_a2")
                    .HasMaxLength(70);

                entity.Property(e => e.HashH2)
                    .HasColumnName("hash_h2")
                    .HasMaxLength(70);

                entity.Property(e => e.MotivoDevolucao)
                    .HasColumnName("motivo_devolucao")
                    .HasMaxLength(80);

                entity.Property(e => e.NmTitular)
                    .HasColumnName("nm_titular")
                    .HasMaxLength(80);

                entity.Property(e => e.NrCc)
                    .HasColumnName("nr_cc")
                    .HasMaxLength(15);

                entity.Property(e => e.NrCheque)
                    .HasColumnName("nr_cheque")
                    .HasMaxLength(15);

                entity.Property(e => e.NrDocumento).HasColumnName("nr_documento");

                entity.Property(e => e.NrSequencial).HasColumnName("nr_sequencial");

                entity.Property(e => e.NrSerie)
                    .HasColumnName("nr_serie")
                    .HasMaxLength(3);

                entity.Property(e => e.TpCartao)
                    .HasColumnName("tp_cartao")
                    .HasMaxLength(1);

                entity.Property(e => e.TpIntegracao).HasColumnName("tp_integracao");

                entity.Property(e => e.VlEntrada)
                    .HasColumnName("vl_entrada")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlSaida)
                    .HasColumnName("vl_saida")
                    .HasColumnType("numeric(18,4)");

                entity.HasOne(d => d.CdContaNavigation)
                    .WithMany(p => p.MovimentoCxa)
                    .HasForeignKey(d => d.CdConta)
                    .HasConstraintName("fk_movimento_cxa_cxa_conta");

                entity.HasOne(d => d.Cd)
                    .WithMany(p => p.MovimentoCxa)
                    .HasForeignKey(d => new { d.CdFilial, d.CdCaixa })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_movimento_cxa_caixa");
            });

            modelBuilder.Entity<MovimentoCxaVinculo>(entity =>
            {
                entity.HasKey(e => e.IdGeral);

                entity.ToTable("movimento_cxa_vinculo");

                entity.Property(e => e.IdGeral)
                    .HasColumnName("id_geral")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdCaixaD).HasColumnName("cd_caixa_d");

                entity.Property(e => e.CdCaixaO).HasColumnName("cd_caixa_o");

                entity.Property(e => e.CdFilialD).HasColumnName("cd_filial_d");

                entity.Property(e => e.CdFilialO).HasColumnName("cd_filial_o");

                entity.Property(e => e.NrLctoD).HasColumnName("nr_lcto_d");

                entity.Property(e => e.NrLctoO).HasColumnName("nr_lcto_o");
            });

            modelBuilder.Entity<MovimentoSeguradora>(entity =>
            {
                entity.HasKey(e => e.NrDocumento);

                entity.ToTable("movimento_seguradora");

                entity.Property(e => e.NrDocumento)
                    .HasColumnName("nr_documento")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdCaixa).HasColumnName("cd_caixa");

                entity.Property(e => e.CdCliente).HasColumnName("cd_cliente");

                entity.Property(e => e.CdFilial).HasColumnName("cd_filial");

                entity.Property(e => e.CdSeguradora).HasColumnName("cd_seguradora");

                entity.Property(e => e.DtAtz)
                    .HasColumnName("dt_atz")
                    .HasColumnType("date")
                    .HasDefaultValueSql("CURRENT_DATE");

                entity.Property(e => e.NrDocumentoOrigem).HasColumnName("nr_documento_origem");

                entity.Property(e => e.NrLcto).HasColumnName("nr_lcto");

                entity.Property(e => e.VlAbatido)
                    .HasColumnName("vl_abatido")
                    .HasColumnType("numeric(9,2)");

                entity.Property(e => e.VlFranquia)
                    .HasColumnName("vl_franquia")
                    .HasColumnType("numeric(9,2)");

                entity.HasOne(d => d.Cd)
                    .WithMany(p => p.MovimentoSeguradora)
                    .HasForeignKey(d => new { d.CdFilial, d.CdCliente })
                    .HasConstraintName("fk_movimento_seg_cliente");

                entity.HasOne(d => d.CdNavigation)
                    .WithMany(p => p.MovimentoSeguradora)
                    .HasForeignKey(d => new { d.CdFilial, d.CdSeguradora })
                    .HasConstraintName("fk_movimento_seg_seguradora");

                entity.HasOne(d => d.MovimentoCxa)
                    .WithMany(p => p.MovimentoSeguradora)
                    .HasForeignKey(d => new { d.CdFilial, d.CdCaixa, d.NrLcto })
                    .HasConstraintName("fk_movimento_seg_lcto");
            });

            modelBuilder.Entity<Msggrupo>(entity =>
            {
                entity.HasKey(e => new { e.CdGruprod, e.UfOrigem, e.UfDestino });

                entity.ToTable("msggrupo");

                entity.Property(e => e.CdGruprod).HasColumnName("cd_gruprod");

                entity.Property(e => e.UfOrigem)
                    .HasColumnName("uf_origem")
                    .HasMaxLength(2);

                entity.Property(e => e.UfDestino)
                    .HasColumnName("uf_destino")
                    .HasMaxLength(2);

                entity.Property(e => e.CdMensagem).HasColumnName("cd_mensagem");

                entity.Property(e => e.DtAtz)
                    .HasColumnName("dt_atz")
                    .HasColumnType("date")
                    .HasDefaultValueSql("CURRENT_DATE");

                entity.HasOne(d => d.CdGruprodNavigation)
                    .WithMany(p => p.Msggrupo)
                    .HasForeignKey(d => d.CdGruprod)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("gruprod_msggrupo_fk");

                entity.HasOne(d => d.CdMensagemNavigation)
                    .WithMany(p => p.Msggrupo)
                    .HasForeignKey(d => d.CdMensagem)
                    .HasConstraintName("fk_msggrupo_cd_mensagem");
            });

            modelBuilder.Entity<NfcFrete>(entity =>
            {
                entity.HasKey(e => e.IdGeral);

                entity.ToTable("nfc_frete");

                entity.Property(e => e.IdGeral)
                    .HasColumnName("id_geral")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdFilialNfsc).HasColumnName("cd_filial_nfsc");

                entity.Property(e => e.IdFrete).HasColumnName("id_frete");

                entity.Property(e => e.IdNfec).HasColumnName("id_nfec");

                entity.Property(e => e.NrDocumentoNfsc).HasColumnName("nr_documento_nfsc");

                entity.Property(e => e.PcRateio).HasColumnName("pc_rateio");

                entity.HasOne(d => d.IdFreteNavigation)
                    .WithMany(p => p.NfcFreteIdFreteNavigation)
                    .HasForeignKey(d => d.IdFrete)
                    .HasConstraintName("fk_nfc_frete_frete");

                entity.HasOne(d => d.IdNfecNavigation)
                    .WithMany(p => p.NfcFreteIdNfecNavigation)
                    .HasForeignKey(d => d.IdNfec)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_nfc_frete_nfec");

                entity.HasOne(d => d.Nfsc)
                    .WithMany(p => p.NfcFrete)
                    .HasForeignKey(d => new { d.CdFilialNfsc, d.NrDocumentoNfsc })
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_nfc_frete_nfsc");
            });

            modelBuilder.Entity<NfContabilC>(entity =>
            {
                entity.HasKey(e => e.IdGeral);

                entity.ToTable("nf_contabil_c");

                entity.HasIndex(e => new { e.IdNfc, e.FlEntradaSaida })
                    .HasName("nf_contabil_c_idx_nfsc");

                entity.HasIndex(e => new { e.CdFilial, e.NrNf, e.NrCupom, e.CdClifor, e.SerieNf, e.FlEntradaSaida, e.EcfCd })
                    .HasName("unq_nf_contabil_c")
                    .IsUnique();

                entity.Property(e => e.IdGeral)
                    .HasColumnName("id_geral")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdClifor).HasColumnName("cd_clifor");

                entity.Property(e => e.CdFilial).HasColumnName("cd_filial");

                entity.Property(e => e.CdModelo)
                    .HasColumnName("cd_modelo")
                    .HasMaxLength(3);

                entity.Property(e => e.CdTransportadora).HasColumnName("cd_transportadora");

                entity.Property(e => e.CliforCnpjCpf)
                    .HasColumnName("clifor_cnpj_cpf")
                    .HasMaxLength(18);

                entity.Property(e => e.CliforIeRg)
                    .HasColumnName("clifor_ie_rg")
                    .HasMaxLength(18);

                entity.Property(e => e.CofinsVl)
                    .HasColumnName("cofins_vl")
                    .HasColumnType("numeric(14,2)");

                entity.Property(e => e.CofinsVlBase)
                    .HasColumnName("cofins_vl_base")
                    .HasColumnType("numeric(14,2)");

                entity.Property(e => e.CondPgto).HasColumnName("cond_pgto");

                entity.Property(e => e.DtEmissao)
                    .HasColumnName("dt_emissao")
                    .HasColumnType("date");

                entity.Property(e => e.DtEntradaSaida)
                    .HasColumnName("dt_entrada_saida")
                    .HasColumnType("date");

                entity.Property(e => e.EcfCd).HasColumnName("ecf_cd");

                entity.Property(e => e.EcfNrCooCupom).HasColumnName("ecf_nr_coo_cupom");

                entity.Property(e => e.EcfNrFabricacao)
                    .HasColumnName("ecf_nr_fabricacao")
                    .HasMaxLength(40);

                entity.Property(e => e.EcfNrPdv).HasColumnName("ecf_nr_pdv");

                entity.Property(e => e.FlCancelado)
                    .HasColumnName("fl_cancelado")
                    .HasMaxLength(1);

                entity.Property(e => e.FlEntradaSaida)
                    .HasColumnName("fl_entrada_saida")
                    .HasMaxLength(1);

                entity.Property(e => e.FlImpresso)
                    .HasColumnName("fl_impresso")
                    .HasMaxLength(1);

                entity.Property(e => e.FlSimples)
                    .HasColumnName("fl_simples")
                    .HasMaxLength(1);

                entity.Property(e => e.FreteCfop)
                    .HasColumnName("frete_cfop")
                    .HasMaxLength(10);

                entity.Property(e => e.FreteVlIcm)
                    .HasColumnName("frete_vl_icm")
                    .HasColumnType("numeric(14,2)");

                entity.Property(e => e.HrEmissao)
                    .HasColumnName("hr_emissao")
                    .HasColumnType("time without time zone");

                entity.Property(e => e.IcmsNormalBase)
                    .HasColumnName("icms_normal_base")
                    .HasColumnType("numeric(14,2)");

                entity.Property(e => e.IcmsNormalVl)
                    .HasColumnName("icms_normal_vl")
                    .HasColumnType("numeric(14,2)");

                entity.Property(e => e.IcmsProprioBase)
                    .HasColumnName("icms_proprio_base")
                    .HasColumnType("numeric(14,2)");

                entity.Property(e => e.IcmsProprioVl)
                    .HasColumnName("icms_proprio_vl")
                    .HasColumnType("numeric(14,2)");

                entity.Property(e => e.IcmsStAntBase)
                    .HasColumnName("icms_st_ant_base")
                    .HasColumnType("numeric(14,2)");

                entity.Property(e => e.IcmsStAntVl)
                    .HasColumnName("icms_st_ant_vl")
                    .HasColumnType("numeric(14,2)");

                entity.Property(e => e.IcmsStBase)
                    .HasColumnName("icms_st_base")
                    .HasColumnType("numeric(14,2)");

                entity.Property(e => e.IcmsStVl)
                    .HasColumnName("icms_st_vl")
                    .HasColumnType("numeric(14,2)");

                entity.Property(e => e.IdNfc).HasColumnName("id_nfc");

                entity.Property(e => e.IpiBase)
                    .HasColumnName("ipi_base")
                    .HasColumnType("numeric(14,2)");

                entity.Property(e => e.IpiVl)
                    .HasColumnName("ipi_vl")
                    .HasColumnType("numeric(14,2)");

                entity.Property(e => e.IssBase)
                    .HasColumnName("iss_base")
                    .HasColumnType("numeric(14,2)");

                entity.Property(e => e.IssVl)
                    .HasColumnName("iss_vl")
                    .HasColumnType("numeric(14,2)");

                entity.Property(e => e.NfeChaveAcesso)
                    .HasColumnName("nfe_chave_acesso")
                    .HasMaxLength(44);

                entity.Property(e => e.NfeDtProcessamento)
                    .HasColumnName("nfe_dt_processamento")
                    .HasColumnType("date");

                entity.Property(e => e.NfeNrLote)
                    .HasColumnName("nfe_nr_lote")
                    .HasMaxLength(15);

                entity.Property(e => e.NfeNrProtocolo)
                    .HasColumnName("nfe_nr_protocolo")
                    .HasMaxLength(50);

                entity.Property(e => e.NfeNrRecibo)
                    .HasColumnName("nfe_nr_recibo")
                    .HasMaxLength(15);

                entity.Property(e => e.NfeTpEmissao).HasColumnName("nfe_tp_emissao");

                entity.Property(e => e.NmOperacao)
                    .HasColumnName("nm_operacao")
                    .HasMaxLength(40);

                entity.Property(e => e.NrCupom).HasColumnName("nr_cupom");

                entity.Property(e => e.NrNf).HasColumnName("nr_nf");

                entity.Property(e => e.Obs).HasColumnName("obs");

                entity.Property(e => e.PisVl)
                    .HasColumnName("pis_vl")
                    .HasColumnType("numeric(14,2)");

                entity.Property(e => e.PisVlBase)
                    .HasColumnName("pis_vl_base")
                    .HasColumnType("numeric(14,2)");

                entity.Property(e => e.SerieNf)
                    .HasColumnName("serie_nf")
                    .HasMaxLength(3);

                entity.Property(e => e.SubSerie)
                    .HasColumnName("sub_serie")
                    .HasMaxLength(3);

                entity.Property(e => e.UfDestino)
                    .HasColumnName("uf_destino")
                    .HasMaxLength(2);

                entity.Property(e => e.UfOrigem)
                    .HasColumnName("uf_origem")
                    .HasMaxLength(2);

                entity.Property(e => e.VlAcrescimo)
                    .HasColumnName("vl_acrescimo")
                    .HasColumnType("numeric(14,2)");

                entity.Property(e => e.VlDesconto)
                    .HasColumnName("vl_desconto")
                    .HasColumnType("numeric(14,2)");

                entity.Property(e => e.VlDescontoItem)
                    .HasColumnName("vl_desconto_item")
                    .HasColumnType("numeric(14,2)");

                entity.Property(e => e.VlFcp)
                    .HasColumnName("vl_fcp")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.VlFcpSt)
                    .HasColumnName("vl_fcp_st")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.VlFcpStRetido)
                    .HasColumnName("vl_fcp_st_retido")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.VlFcpUfDest)
                    .HasColumnName("vl_fcp_uf_dest")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.VlFrete)
                    .HasColumnName("vl_frete")
                    .HasColumnType("numeric(14,2)");

                entity.Property(e => e.VlIcmsUfDest)
                    .HasColumnName("vl_icms_uf_dest")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.VlIcmsUfRemet)
                    .HasColumnName("vl_icms_uf_remet")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.VlIsentoItens)
                    .HasColumnName("vl_isento_itens")
                    .HasColumnType("numeric(14,2)");

                entity.Property(e => e.VlMercadorias)
                    .HasColumnName("vl_mercadorias")
                    .HasColumnType("numeric(14,2)");

                entity.Property(e => e.VlOutrosItens)
                    .HasColumnName("vl_outros_itens")
                    .HasColumnType("numeric(14,2)");

                entity.Property(e => e.VlSeguro)
                    .HasColumnName("vl_seguro")
                    .HasColumnType("numeric(14,2)");

                entity.Property(e => e.VlServicos)
                    .HasColumnName("vl_servicos")
                    .HasColumnType("numeric(14,2)");

                entity.Property(e => e.VlTotal)
                    .HasColumnName("vl_total")
                    .HasColumnType("numeric(14,2)");
            });

            modelBuilder.Entity<NfContabilCfop>(entity =>
            {
                entity.HasKey(e => e.IdGeral);

                entity.ToTable("nf_contabil_cfop");

                entity.HasIndex(e => new { e.IdNfContabilC, e.Cst, e.Cfop, e.ImpostoAliq, e.ImpostoTipo })
                    .HasName("unq_nf_contabil_cfop")
                    .IsUnique();

                entity.Property(e => e.IdGeral)
                    .HasColumnName("id_geral")
                    .ValueGeneratedNever();

                entity.Property(e => e.Cfop)
                    .IsRequired()
                    .HasColumnName("cfop")
                    .HasMaxLength(10);

                entity.Property(e => e.Cst)
                    .HasColumnName("cst")
                    .HasMaxLength(4);

                entity.Property(e => e.IcmsStVl)
                    .HasColumnName("icms_st_vl")
                    .HasColumnType("numeric(14,2)");

                entity.Property(e => e.IcmsStVlBase)
                    .HasColumnName("icms_st_vl_base")
                    .HasColumnType("numeric(14,2)");

                entity.Property(e => e.IdNfContabilC).HasColumnName("id_nf_contabil_c");

                entity.Property(e => e.ImpostoAliq)
                    .HasColumnName("imposto_aliq")
                    .HasColumnType("numeric(14,2)");

                entity.Property(e => e.ImpostoTipo)
                    .IsRequired()
                    .HasColumnName("imposto_tipo")
                    .HasMaxLength(1);

                entity.Property(e => e.ImpostoVl)
                    .HasColumnName("imposto_vl")
                    .HasColumnType("numeric(14,2)");

                entity.Property(e => e.ImpostoVlBase)
                    .HasColumnName("imposto_vl_base")
                    .HasColumnType("numeric(14,2)");

                entity.Property(e => e.ImpostoVlRedBase)
                    .HasColumnName("imposto_vl_red_base")
                    .HasColumnType("numeric(14,2)");

                entity.Property(e => e.VlIsento)
                    .HasColumnName("vl_isento")
                    .HasColumnType("numeric(14,2)");

                entity.Property(e => e.VlOutros)
                    .HasColumnName("vl_outros")
                    .HasColumnType("numeric(14,2)");

                entity.Property(e => e.VlTotal)
                    .HasColumnName("vl_total")
                    .HasColumnType("numeric(14,2)");

                entity.HasOne(d => d.IdNfContabilCNavigation)
                    .WithMany(p => p.NfContabilCfop)
                    .HasForeignKey(d => d.IdNfContabilC)
                    .HasConstraintName("fk_nf_contabil_cfop_nf_cont_c");
            });

            modelBuilder.Entity<NfContabilI>(entity =>
            {
                entity.HasKey(e => e.IdGeral);

                entity.ToTable("nf_contabil_i");

                entity.HasIndex(e => e.IdNfContabilC)
                    .HasName("nf_contabil_i_id_nf_contabil_c");

                entity.HasIndex(e => new { e.IdNfContabilC, e.NrSequencia })
                    .HasName("unq_nf_contabil_i")
                    .IsUnique();

                entity.Property(e => e.IdGeral)
                    .HasColumnName("id_geral")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdItem)
                    .IsRequired()
                    .HasColumnName("cd_item")
                    .HasMaxLength(15);

                entity.Property(e => e.Cfop)
                    .HasColumnName("cfop")
                    .HasMaxLength(10);

                entity.Property(e => e.CofinsAliq)
                    .HasColumnName("cofins_aliq")
                    .HasColumnType("numeric(6,2)");

                entity.Property(e => e.CofinsCst)
                    .HasColumnName("cofins_cst")
                    .HasMaxLength(2);

                entity.Property(e => e.CofinsVl)
                    .HasColumnName("cofins_vl")
                    .HasColumnType("numeric(14,2)");

                entity.Property(e => e.CofinsVlBase)
                    .HasColumnName("cofins_vl_base")
                    .HasColumnType("numeric(14,2)");

                entity.Property(e => e.Cst)
                    .HasColumnName("cst")
                    .HasMaxLength(4);

                entity.Property(e => e.FlCancelado)
                    .HasColumnName("fl_cancelado")
                    .HasMaxLength(1);

                entity.Property(e => e.FlProduto)
                    .HasColumnName("fl_produto")
                    .HasMaxLength(1);

                entity.Property(e => e.FlSomaTotal)
                    .HasColumnName("fl_soma_total")
                    .HasMaxLength(1);

                entity.Property(e => e.IcmsFreteVl)
                    .HasColumnName("icms_frete_vl")
                    .HasColumnType("numeric(14,2)");

                entity.Property(e => e.IcmsNormalAliq)
                    .HasColumnName("icms_normal_aliq")
                    .HasColumnType("numeric(6,2)");

                entity.Property(e => e.IcmsNormalPcRed)
                    .HasColumnName("icms_normal_pc_red")
                    .HasColumnType("numeric(6,2)");

                entity.Property(e => e.IcmsNormalVl)
                    .HasColumnName("icms_normal_vl")
                    .HasColumnType("numeric(14,2)");

                entity.Property(e => e.IcmsNormalVlBase)
                    .HasColumnName("icms_normal_vl_base")
                    .HasColumnType("numeric(14,2)");

                entity.Property(e => e.IcmsProprioAliq)
                    .HasColumnName("icms_proprio_aliq")
                    .HasColumnType("numeric(6,2)");

                entity.Property(e => e.IcmsProprioPcRed)
                    .HasColumnName("icms_proprio_pc_red")
                    .HasColumnType("numeric(6,2)");

                entity.Property(e => e.IcmsProprioVl)
                    .HasColumnName("icms_proprio_vl")
                    .HasColumnType("numeric(14,2)");

                entity.Property(e => e.IcmsProprioVlBase)
                    .HasColumnName("icms_proprio_vl_base")
                    .HasColumnType("numeric(14,2)");

                entity.Property(e => e.IcmsStAliqDestino)
                    .HasColumnName("icms_st_aliq_destino")
                    .HasColumnType("numeric(6,2)");

                entity.Property(e => e.IcmsStAntVl)
                    .HasColumnName("icms_st_ant_vl")
                    .HasColumnType("numeric(14,2)");

                entity.Property(e => e.IcmsStAntVlBase)
                    .HasColumnName("icms_st_ant_vl_base")
                    .HasColumnType("numeric(14,2)");

                entity.Property(e => e.IcmsStMva)
                    .HasColumnName("icms_st_mva")
                    .HasColumnType("numeric(6,2)");

                entity.Property(e => e.IcmsStPcRed)
                    .HasColumnName("icms_st_pc_red")
                    .HasColumnType("numeric(6,2)");

                entity.Property(e => e.IcmsStVl)
                    .HasColumnName("icms_st_vl")
                    .HasColumnType("numeric(14,2)");

                entity.Property(e => e.IcmsStVlBase)
                    .HasColumnName("icms_st_vl_base")
                    .HasColumnType("numeric(14,2)");

                entity.Property(e => e.IdNfContabilC).HasColumnName("id_nf_contabil_c");

                entity.Property(e => e.IpiAliq)
                    .HasColumnName("ipi_aliq")
                    .HasColumnType("numeric(6,2)");

                entity.Property(e => e.IpiCst)
                    .HasColumnName("ipi_cst")
                    .HasMaxLength(2);

                entity.Property(e => e.IpiVl)
                    .HasColumnName("ipi_vl")
                    .HasColumnType("numeric(14,2)");

                entity.Property(e => e.IpiVlBase)
                    .HasColumnName("ipi_vl_base")
                    .HasColumnType("numeric(14,2)");

                entity.Property(e => e.IssAliq)
                    .HasColumnName("iss_aliq")
                    .HasColumnType("numeric(6,2)");

                entity.Property(e => e.IssVl)
                    .HasColumnName("iss_vl")
                    .HasColumnType("numeric(14,2)");

                entity.Property(e => e.IssVlBase)
                    .HasColumnName("iss_vl_base")
                    .HasColumnType("numeric(14,2)");

                entity.Property(e => e.NrSequencia).HasColumnName("nr_sequencia");

                entity.Property(e => e.PcFcp)
                    .HasColumnName("pc_fcp")
                    .HasColumnType("numeric(4,4)");

                entity.Property(e => e.PcFcpSt)
                    .HasColumnName("pc_fcp_st")
                    .HasColumnType("numeric(4,4)");

                entity.Property(e => e.PcFcpStRetido)
                    .HasColumnName("pc_fcp_st_retido")
                    .HasColumnType("numeric(4,4)");

                entity.Property(e => e.PcFcpUfDestino)
                    .HasColumnName("pc_fcp_uf_destino")
                    .HasColumnType("numeric(4,4)");

                entity.Property(e => e.PcIcmsInterno)
                    .HasColumnName("pc_icms_interno")
                    .HasColumnType("numeric(2,2)");

                entity.Property(e => e.PcIcmsInternoPartilha)
                    .HasColumnName("pc_icms_interno_partilha")
                    .HasColumnType("numeric(4,4)");

                entity.Property(e => e.PcIcmsUfDestino)
                    .HasColumnName("pc_icms_uf_destino")
                    .HasColumnType("numeric(4,4)");

                entity.Property(e => e.PcReducao)
                    .HasColumnName("pc_reducao")
                    .HasColumnType("numeric(6,2)");

                entity.Property(e => e.PisAliq)
                    .HasColumnName("pis_aliq")
                    .HasColumnType("numeric(6,2)");

                entity.Property(e => e.PisCst)
                    .HasColumnName("pis_cst")
                    .HasMaxLength(2);

                entity.Property(e => e.PisVl)
                    .HasColumnName("pis_vl")
                    .HasColumnType("numeric(14,2)");

                entity.Property(e => e.PisVlBase)
                    .HasColumnName("pis_vl_base")
                    .HasColumnType("numeric(14,2)");

                entity.Property(e => e.QtCompraVenda).HasColumnName("qt_compra_venda");

                entity.Property(e => e.QtItem).HasColumnName("qt_item");

                entity.Property(e => e.UnCompraVenda)
                    .HasColumnName("un_compra_venda")
                    .HasMaxLength(6);

                entity.Property(e => e.UnMedida)
                    .HasColumnName("un_medida")
                    .HasMaxLength(6);

                entity.Property(e => e.VlAcrescimo)
                    .HasColumnName("vl_acrescimo")
                    .HasColumnType("numeric(14,2)");

                entity.Property(e => e.VlAcrescimoRateado)
                    .HasColumnName("vl_acrescimo_rateado")
                    .HasColumnType("numeric(14,2)");

                entity.Property(e => e.VlBaseFcp)
                    .HasColumnName("vl_base_fcp")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.VlBaseFcpSt)
                    .HasColumnName("vl_base_fcp_st")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.VlBaseFcpStRetido)
                    .HasColumnName("vl_base_fcp_st_retido")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.VlBaseFcpUfDestino)
                    .HasColumnName("vl_base_fcp_uf_destino")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.VlBaseUfDestino)
                    .HasColumnName("vl_base_uf_destino")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.VlBruto)
                    .HasColumnName("vl_bruto")
                    .HasColumnType("numeric(18,8)");

                entity.Property(e => e.VlContabil)
                    .HasColumnName("vl_contabil")
                    .HasColumnType("numeric(14,2)");

                entity.Property(e => e.VlDesconto)
                    .HasColumnName("vl_desconto")
                    .HasColumnType("numeric(14,2)");

                entity.Property(e => e.VlDescontoRateado)
                    .HasColumnName("vl_desconto_rateado")
                    .HasColumnType("numeric(14,2)");

                entity.Property(e => e.VlFcp)
                    .HasColumnName("vl_fcp")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.VlFcpSt)
                    .HasColumnName("vl_fcp_st")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.VlFcpStRetido)
                    .HasColumnName("vl_fcp_st_retido")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.VlFcpUfDestino)
                    .HasColumnName("vl_fcp_uf_destino")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.VlFreteRateado)
                    .HasColumnName("vl_frete_rateado")
                    .HasColumnType("numeric(14,2)");

                entity.Property(e => e.VlIcmsUfDestino)
                    .HasColumnName("vl_icms_uf_destino")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.VlIcmsUfRemetente)
                    .HasColumnName("vl_icms_uf_remetente")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.VlIsento)
                    .HasColumnName("vl_isento")
                    .HasColumnType("numeric(14,2)");

                entity.Property(e => e.VlOutros)
                    .HasColumnName("vl_outros")
                    .HasColumnType("numeric(14,2)");

                entity.Property(e => e.VlSeguroRateado)
                    .HasColumnName("vl_seguro_rateado")
                    .HasColumnType("numeric(14,2)");

                entity.Property(e => e.VlTotal)
                    .HasColumnName("vl_total")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlUnitario)
                    .HasColumnName("vl_unitario")
                    .HasColumnType("numeric(18,8)");

                entity.Property(e => e.VlUnitarioCompraVenda)
                    .HasColumnName("vl_unitario_compra_venda")
                    .HasColumnType("numeric(18,8)");

                entity.HasOne(d => d.IdNfContabilCNavigation)
                    .WithMany(p => p.NfContabilI)
                    .HasForeignKey(d => d.IdNfContabilC)
                    .HasConstraintName("fk_nf_contabil_i_nf_contabil_c");
            });

            modelBuilder.Entity<Nfec>(entity =>
            {
                entity.HasKey(e => e.IdGeral);

                entity.ToTable("nfec");

                entity.HasIndex(e => e.CdClifor)
                    .HasName("idx_nfec_clifor");

                entity.HasIndex(e => e.NrDctoDevolucao)
                    .HasName("idx_nfec_nr_dcto_devolucao");

                entity.HasIndex(e => new { e.CdFilial, e.NrDcto, e.CdClifor, e.FlImpresso, e.SerieNf })
                    .HasName("unq1_nfec")
                    .IsUnique();

                entity.Property(e => e.IdGeral)
                    .HasColumnName("id_geral")
                    .ValueGeneratedNever();

                entity.Property(e => e.BaseIcmProprioSt)
                    .HasColumnName("base_icm_proprio_st")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.CdBanco).HasColumnName("cd_banco");

                entity.Property(e => e.CdBarrasAdicionalNfe)
                    .HasColumnName("cd_barras_adicional_nfe")
                    .HasMaxLength(36);

                entity.Property(e => e.CdClifor).HasColumnName("cd_clifor");

                entity.Property(e => e.CdCondpgto).HasColumnName("cd_condpgto");

                entity.Property(e => e.CdConta).HasColumnName("cd_conta");

                entity.Property(e => e.CdFilial).HasColumnName("cd_filial");

                entity.Property(e => e.CdFuncionario).HasColumnName("cd_funcionario");

                entity.Property(e => e.CdModelo)
                    .HasColumnName("cd_modelo")
                    .HasMaxLength(3);

                entity.Property(e => e.CdNatoper)
                    .IsRequired()
                    .HasColumnName("cd_natoper")
                    .HasMaxLength(40);

                entity.Property(e => e.CdOperacao).HasColumnName("cd_operacao");

                entity.Property(e => e.CdTipocobr).HasColumnName("cd_tipocobr");

                entity.Property(e => e.CdTransportadora).HasColumnName("cd_transportadora");

                entity.Property(e => e.CfopFrete)
                    .HasColumnName("cfop_frete")
                    .HasMaxLength(10);

                entity.Property(e => e.ChaveAcessoNfe)
                    .HasColumnName("chave_acesso_nfe")
                    .HasMaxLength(44);

                entity.Property(e => e.ConhecimentoBaseIcm)
                    .HasColumnName("conhecimento_base_icm")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.ConhecimentoBaseSt)
                    .HasColumnName("conhecimento_base_st")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.ConhecimentoVlFrete)
                    .HasColumnName("conhecimento_vl_frete")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.ConhecimentoVlIcm)
                    .HasColumnName("conhecimento_vl_icm")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.ConhecimentoVlSt)
                    .HasColumnName("conhecimento_vl_st")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.CupomNrCoo).HasColumnName("cupom_nr_coo");

                entity.Property(e => e.CupomNrPdv).HasColumnName("cupom_nr_pdv");

                entity.Property(e => e.DpecDtRegistro)
                    .HasColumnName("dpec_dt_registro")
                    .HasColumnType("date");

                entity.Property(e => e.DpecHrRegistro)
                    .HasColumnName("dpec_hr_registro")
                    .HasColumnType("time without time zone");

                entity.Property(e => e.DpecId)
                    .HasColumnName("dpec_id")
                    .HasMaxLength(10);

                entity.Property(e => e.DpecNrRegistro)
                    .HasColumnName("dpec_nr_registro")
                    .HasMaxLength(14);

                entity.Property(e => e.DtAtz)
                    .HasColumnName("dt_atz")
                    .HasColumnType("date")
                    .HasDefaultValueSql("CURRENT_DATE");

                entity.Property(e => e.DtEmissao)
                    .HasColumnName("dt_emissao")
                    .HasColumnType("date")
                    .HasDefaultValueSql("CURRENT_DATE");

                entity.Property(e => e.DtLancamento)
                    .HasColumnName("dt_lancamento")
                    .HasColumnType("date")
                    .HasDefaultValueSql("CURRENT_DATE");

                entity.Property(e => e.DtProcessamentoNfe)
                    .HasColumnName("dt_processamento_nfe")
                    .HasColumnType("date");

                entity.Property(e => e.EspecieVolumes)
                    .HasColumnName("especie_volumes")
                    .HasMaxLength(15);

                entity.Property(e => e.FlCalcularCusto)
                    .HasColumnName("fl_calcular_custo")
                    .HasMaxLength(1);

                entity.Property(e => e.FlCdConta)
                    .HasColumnName("fl_cd_conta")
                    .HasMaxLength(1);

                entity.Property(e => e.FlConhecFrete).HasColumnName("fl_conhec_frete");

                entity.Property(e => e.FlConsumo)
                    .HasColumnName("fl_consumo")
                    .HasMaxLength(1);

                entity.Property(e => e.FlContNcont)
                    .HasColumnName("fl_cont_ncont")
                    .HasMaxLength(1);

                entity.Property(e => e.FlControlarEstoque)
                    .HasColumnName("fl_controlar_estoque")
                    .HasMaxLength(1);

                entity.Property(e => e.FlIgnorarCxaCta)
                    .IsRequired()
                    .HasColumnName("fl_ignorar_cxa_cta")
                    .HasMaxLength(1);

                entity.Property(e => e.FlImpresso).HasColumnName("fl_impresso");

                entity.Property(e => e.FlSimples)
                    .HasColumnName("fl_simples")
                    .HasMaxLength(1);

                entity.Property(e => e.FlTransferencia).HasColumnName("fl_transferencia");

                entity.Property(e => e.HrEmissao)
                    .HasColumnName("hr_emissao")
                    .HasColumnType("time without time zone");

                entity.Property(e => e.HrProcessamentoNfe)
                    .HasColumnName("hr_processamento_nfe")
                    .HasColumnType("time without time zone");

                entity.Property(e => e.MarcaVolumes)
                    .HasColumnName("marca_volumes")
                    .HasMaxLength(15);

                entity.Property(e => e.NrAidf)
                    .HasColumnName("nr_aidf")
                    .HasMaxLength(20);

                entity.Property(e => e.NrDcto).HasColumnName("nr_dcto");

                entity.Property(e => e.NrDctoDevolucao).HasColumnName("nr_dcto_devolucao");

                entity.Property(e => e.NrLoteNfe)
                    .HasColumnName("nr_lote_nfe")
                    .HasMaxLength(15);

                entity.Property(e => e.NrPedido).HasColumnName("nr_pedido");

                entity.Property(e => e.NrProtocoloCancNfe)
                    .HasColumnName("nr_protocolo_canc_nfe")
                    .HasMaxLength(15);

                entity.Property(e => e.NrProtocoloNfe)
                    .HasColumnName("nr_protocolo_nfe")
                    .HasMaxLength(15);

                entity.Property(e => e.NrReciboNfe)
                    .HasColumnName("nr_recibo_nfe")
                    .HasMaxLength(15);

                entity.Property(e => e.NrVolumes).HasColumnName("nr_volumes");

                entity.Property(e => e.Nsu)
                    .HasColumnName("nsu")
                    .HasMaxLength(10);

                entity.Property(e => e.Obs).HasColumnName("obs");

                entity.Property(e => e.Obs2).HasColumnName("obs2");

                entity.Property(e => e.PesoLiquido).HasColumnName("peso_liquido");

                entity.Property(e => e.PesoTotal).HasColumnName("peso_total");

                entity.Property(e => e.PlacaTransp)
                    .HasColumnName("placa_transp")
                    .HasMaxLength(8);

                entity.Property(e => e.QtPecas).HasColumnName("qt_pecas");

                entity.Property(e => e.QtVolumes).HasColumnName("qt_volumes");

                entity.Property(e => e.SerieNf)
                    .IsRequired()
                    .HasColumnName("serie_nf")
                    .HasMaxLength(3);

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.SubSerie)
                    .HasColumnName("sub_serie")
                    .HasMaxLength(3);

                entity.Property(e => e.TpEmissaoNfe).HasColumnName("tp_emissao_nfe");

                entity.Property(e => e.TpFrete)
                    .HasColumnName("tp_frete")
                    .HasMaxLength(1);

                entity.Property(e => e.UfDestino)
                    .IsRequired()
                    .HasColumnName("uf_destino")
                    .HasMaxLength(2);

                entity.Property(e => e.UfOrigem)
                    .IsRequired()
                    .HasColumnName("uf_origem")
                    .HasMaxLength(2);

                entity.Property(e => e.UfPlacaTransp)
                    .HasColumnName("uf_placa_transp")
                    .HasMaxLength(2);

                entity.Property(e => e.VlAcresFinanceiro)
                    .HasColumnName("vl_acres_financeiro")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlAcrescimos)
                    .HasColumnName("vl_acrescimos")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlBaseCofins)
                    .HasColumnName("vl_base_cofins")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlBaseIcm)
                    .HasColumnName("vl_base_icm")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlBaseIcmSubst)
                    .HasColumnName("vl_base_icm_subst")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlBaseIcmSubstAnt)
                    .HasColumnName("vl_base_icm_subst_ant")
                    .HasColumnType("numeric(9,2)");

                entity.Property(e => e.VlBaseIcmSubstDev)
                    .HasColumnName("vl_base_icm_subst_dev")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlBaseIcmSubstReal)
                    .HasColumnName("vl_base_icm_subst_real")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlBaseIpi)
                    .HasColumnName("vl_base_ipi")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlBaseIpiDev)
                    .HasColumnName("vl_base_ipi_dev")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlBaseIss)
                    .HasColumnName("vl_base_iss")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlBasePis)
                    .HasColumnName("vl_base_pis")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlCofins)
                    .HasColumnName("vl_cofins")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlDescontoItem)
                    .HasColumnName("vl_desconto_item")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlDescontos)
                    .HasColumnName("vl_descontos")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlEntrada)
                    .HasColumnName("vl_entrada")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlFcp)
                    .HasColumnName("vl_fcp")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.VlFcpSt)
                    .HasColumnName("vl_fcp_st")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.VlFcpStRetido)
                    .HasColumnName("vl_fcp_st_retido")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.VlFcpUfDest)
                    .HasColumnName("vl_fcp_uf_dest")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.VlFinanciado)
                    .HasColumnName("vl_financiado")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlFrete)
                    .HasColumnName("vl_frete")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlIcm)
                    .HasColumnName("vl_icm")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlIcmFrete)
                    .HasColumnName("vl_icm_frete")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlIcmProprioSt)
                    .HasColumnName("vl_icm_proprio_st")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlIcmSubst)
                    .HasColumnName("vl_icm_subst")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlIcmSubstAnt)
                    .HasColumnName("vl_icm_subst_ant")
                    .HasColumnType("numeric(9,2)");

                entity.Property(e => e.VlIcmSubstDev)
                    .HasColumnName("vl_icm_subst_dev")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlIcmSubstReal)
                    .HasColumnName("vl_icm_subst_real")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlIcmsUfDest)
                    .HasColumnName("vl_icms_uf_dest")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.VlIcmsUfRemet)
                    .HasColumnName("vl_icms_uf_remet")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.VlIpi)
                    .HasColumnName("vl_ipi")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlIpiDev)
                    .HasColumnName("vl_ipi_dev")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlIsentoItens)
                    .HasColumnName("vl_isento_itens")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlIss)
                    .HasColumnName("vl_iss")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlMercadorias)
                    .HasColumnName("vl_mercadorias")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlOutros)
                    .HasColumnName("vl_outros")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlOutrosItens)
                    .HasColumnName("vl_outros_itens")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlPis)
                    .HasColumnName("vl_pis")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlSeguro)
                    .HasColumnName("vl_seguro")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlServicos)
                    .HasColumnName("vl_servicos")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlTotal)
                    .HasColumnName("vl_total")
                    .HasColumnType("numeric(18,4)");

                entity.HasOne(d => d.CdContaNavigation)
                    .WithMany(p => p.Nfec)
                    .HasForeignKey(d => d.CdConta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_nfec_cxa_conta");

                entity.HasOne(d => d.NrPedidoNavigation)
                    .WithMany(p => p.Nfec)
                    .HasForeignKey(d => d.NrPedido)
                    .HasConstraintName("fk_nfec_pedido");
            });

            modelBuilder.Entity<NfecConhecimento>(entity =>
            {
                entity.HasKey(e => e.IdNfec);

                entity.ToTable("nfec_conhecimento");

                entity.Property(e => e.IdNfec)
                    .HasColumnName("id_nfec")
                    .ValueGeneratedNever();

                entity.Property(e => e.TpCte).HasColumnName("tp_cte");

                entity.Property(e => e.VlFrete)
                    .HasColumnName("vl_frete")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlFreteVolume)
                    .HasColumnName("vl_frete_volume")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlOutros)
                    .HasColumnName("vl_outros")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlPedagio)
                    .HasColumnName("vl_pedagio")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlSecCat)
                    .HasColumnName("vl_sec_cat")
                    .HasColumnType("numeric(18,4)");

                entity.HasOne(d => d.IdNfecNavigation)
                    .WithOne(p => p.NfecConhecimento)
                    .HasForeignKey<NfecConhecimento>(d => d.IdNfec)
                    .HasConstraintName("fk_nfec_conhecimento_nfec");
            });

            modelBuilder.Entity<NfecEnergiaEletrica>(entity =>
            {
                entity.HasKey(e => e.IdNfec);

                entity.ToTable("nfec_energia_eletrica");

                entity.Property(e => e.IdNfec)
                    .HasColumnName("id_nfec")
                    .ValueGeneratedNever();

                entity.Property(e => e.CodCons)
                    .HasColumnName("cod_cons")
                    .HasMaxLength(2);

                entity.Property(e => e.CodGrupoTensao)
                    .HasColumnName("cod_grupo_tensao")
                    .HasMaxLength(2);

                entity.Property(e => e.TpLigacao).HasColumnName("tp_ligacao");

                entity.HasOne(d => d.IdNfecNavigation)
                    .WithOne(p => p.NfecEnergiaEletrica)
                    .HasForeignKey<NfecEnergiaEletrica>(d => d.IdNfec)
                    .HasConstraintName("fk_nfec_energia_eletrica_1");
            });

            modelBuilder.Entity<NfecImportacao>(entity =>
            {
                entity.HasKey(e => e.IdGeral);

                entity.ToTable("nfec_importacao");

                entity.Property(e => e.IdGeral)
                    .HasColumnName("id_geral")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdCidadeDesembaraco).HasColumnName("cd_cidade_desembaraco");

                entity.Property(e => e.CgcCpfAdquirente)
                    .HasColumnName("cgc_cpf_adquirente")
                    .HasMaxLength(18);

                entity.Property(e => e.DtDesembaraco)
                    .HasColumnName("dt_desembaraco")
                    .HasColumnType("date");

                entity.Property(e => e.DtDi)
                    .HasColumnName("dt_di")
                    .HasColumnType("date");

                entity.Property(e => e.FlCustoIcm)
                    .HasColumnName("fl_custo_icm")
                    .HasMaxLength(1);

                entity.Property(e => e.FlCustoIi)
                    .HasColumnName("fl_custo_ii")
                    .HasMaxLength(1);

                entity.Property(e => e.FlCustoIpi)
                    .HasColumnName("fl_custo_ipi")
                    .HasMaxLength(1);

                entity.Property(e => e.FlCustoPisCofins)
                    .HasColumnName("fl_custo_pis_cofins")
                    .HasMaxLength(1);

                entity.Property(e => e.IdNfec).HasColumnName("id_nfec");

                entity.Property(e => e.NrDi)
                    .IsRequired()
                    .HasColumnName("nr_di")
                    .HasMaxLength(10);

                entity.Property(e => e.TaxaDolar)
                    .HasColumnName("taxa_dolar")
                    .HasColumnType("numeric(9,2)");

                entity.Property(e => e.TpIntermedio).HasColumnName("tp_intermedio");

                entity.Property(e => e.TpViatransp).HasColumnName("tp_viatransp");

                entity.Property(e => e.UfTerceiro)
                    .HasColumnName("uf_terceiro")
                    .HasMaxLength(3);

                entity.Property(e => e.VlAfrmm)
                    .HasColumnName("vl_afrmm")
                    .HasColumnType("numeric(14,2)");

                entity.Property(e => e.VlBaseIi)
                    .HasColumnName("vl_base_ii")
                    .HasColumnType("numeric(14,2)");

                entity.Property(e => e.VlDespAduaneira)
                    .HasColumnName("vl_desp_aduaneira")
                    .HasColumnType("numeric(14,2)");

                entity.Property(e => e.VlIi)
                    .HasColumnName("vl_ii")
                    .HasColumnType("numeric(14,2)");

                entity.Property(e => e.VlIof)
                    .HasColumnName("vl_iof")
                    .HasColumnType("numeric(14,2)");

                entity.Property(e => e.VlSiscomex)
                    .HasColumnName("vl_siscomex")
                    .HasColumnType("numeric(14,2)");

                entity.HasOne(d => d.IdNfecNavigation)
                    .WithMany(p => p.NfecImportacao)
                    .HasForeignKey(d => d.IdNfec)
                    .HasConstraintName("fk_nfec_importacao_nfec");
            });

            modelBuilder.Entity<NfecMensagem>(entity =>
            {
                entity.HasKey(e => e.IdGeral);

                entity.ToTable("nfec_mensagem");

                entity.Property(e => e.IdGeral)
                    .HasColumnName("id_geral")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdMensagem).HasColumnName("cd_mensagem");

                entity.Property(e => e.IdNfec).HasColumnName("id_nfec");

                entity.Property(e => e.Mensagem)
                    .IsRequired()
                    .HasColumnName("mensagem");

                entity.HasOne(d => d.CdMensagemNavigation)
                    .WithMany(p => p.NfecMensagem)
                    .HasForeignKey(d => d.CdMensagem)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_nfec_mensagem_nota");

                entity.HasOne(d => d.IdNfecNavigation)
                    .WithMany(p => p.NfecMensagem)
                    .HasForeignKey(d => d.IdNfec)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_nfec_mensagem_nfec");
            });

            modelBuilder.Entity<NfeContingencia>(entity =>
            {
                entity.HasKey(e => e.IdGeral);

                entity.ToTable("nfe_contingencia");

                entity.Property(e => e.IdGeral)
                    .HasColumnName("id_geral")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdFilial).HasColumnName("cd_filial");

                entity.Property(e => e.CdStatus).HasColumnName("cd_status");

                entity.Property(e => e.DtFim)
                    .HasColumnName("dt_fim")
                    .HasColumnType("date");

                entity.Property(e => e.DtInicio)
                    .HasColumnName("dt_inicio")
                    .HasColumnType("date");

                entity.Property(e => e.HrFim)
                    .HasColumnName("hr_fim")
                    .HasColumnType("time without time zone");

                entity.Property(e => e.HrInicio)
                    .HasColumnName("hr_inicio")
                    .HasColumnType("time without time zone");

                entity.Property(e => e.Motivo)
                    .HasColumnName("motivo")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Nfei>(entity =>
            {
                entity.HasKey(e => e.IdGeral);

                entity.ToTable("nfei");

                entity.Property(e => e.IdGeral)
                    .HasColumnName("id_geral")
                    .ValueGeneratedNever();

                entity.Property(e => e.AlicIcmSubstDev)
                    .HasColumnName("alic_icm_subst_dev")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.AlicIpiDev)
                    .HasColumnName("alic_ipi_dev")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.AliqCofins)
                    .HasColumnName("aliq_cofins")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.AliqIcm)
                    .HasColumnName("aliq_icm")
                    .HasColumnType("numeric(9,2)");

                entity.Property(e => e.AliqIcmOri).HasColumnName("aliq_icm_ori");

                entity.Property(e => e.AliqIcmProprioSt)
                    .HasColumnName("aliq_icm_proprio_st")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.AliqIcmProprioStOri).HasColumnName("aliq_icm_proprio_st_ori");

                entity.Property(e => e.AliqIcmSubst)
                    .HasColumnName("aliq_icm_subst")
                    .HasColumnType("numeric(9,2)");

                entity.Property(e => e.AliqIcmSubstOri).HasColumnName("aliq_icm_subst_ori");

                entity.Property(e => e.AliqIcmSubstReal)
                    .HasColumnName("aliq_icm_subst_real")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.AliqIpi)
                    .HasColumnName("aliq_ipi")
                    .HasColumnType("numeric(9,2)");

                entity.Property(e => e.AliqIss)
                    .HasColumnName("aliq_iss")
                    .HasColumnType("numeric(9,2)");

                entity.Property(e => e.AliqPis)
                    .HasColumnName("aliq_pis")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.AliqUfDestino)
                    .HasColumnName("aliq_uf_destino")
                    .HasColumnType("numeric(6,2)");

                entity.Property(e => e.CdAtualizacao).HasColumnName("cd_atualizacao");

                entity.Property(e => e.CdConta).HasColumnName("cd_conta");

                entity.Property(e => e.CdProdserv)
                    .IsRequired()
                    .HasColumnName("cd_prodserv")
                    .HasMaxLength(15);

                entity.Property(e => e.Cfop)
                    .HasColumnName("cfop")
                    .HasMaxLength(10);

                entity.Property(e => e.CfopOri)
                    .HasColumnName("cfop_ori")
                    .HasMaxLength(10);

                entity.Property(e => e.ClassificacaoCtbl)
                    .HasColumnName("classificacao_ctbl")
                    .HasMaxLength(3);

                entity.Property(e => e.Compl).HasColumnName("compl");

                entity.Property(e => e.ConhecimentoBaseIcm)
                    .HasColumnName("conhecimento_base_icm")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.ConhecimentoBaseSt)
                    .HasColumnName("conhecimento_base_st")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.ConhecimentoVlFrete)
                    .HasColumnName("conhecimento_vl_frete")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.ConhecimentoVlIcm)
                    .HasColumnName("conhecimento_vl_icm")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.ConhecimentoVlSt)
                    .HasColumnName("conhecimento_vl_st")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.Cst)
                    .HasColumnName("cst")
                    .HasMaxLength(4);

                entity.Property(e => e.CstCofins)
                    .HasColumnName("cst_cofins")
                    .HasMaxLength(2);

                entity.Property(e => e.CstIpi)
                    .HasColumnName("cst_ipi")
                    .HasMaxLength(2);

                entity.Property(e => e.CstOri)
                    .HasColumnName("cst_ori")
                    .HasMaxLength(4);

                entity.Property(e => e.CstPis)
                    .HasColumnName("cst_pis")
                    .HasMaxLength(2);

                entity.Property(e => e.DtAtz)
                    .HasColumnName("dt_atz")
                    .HasColumnType("date")
                    .HasDefaultValueSql("CURRENT_DATE");

                entity.Property(e => e.DtLancamento)
                    .HasColumnName("dt_lancamento")
                    .HasColumnType("date")
                    .HasDefaultValueSql("CURRENT_DATE");

                entity.Property(e => e.FatorConversao).HasColumnName("fator_conversao");

                entity.Property(e => e.FlControlarEstoque)
                    .HasColumnName("fl_controlar_estoque")
                    .HasMaxLength(1);

                entity.Property(e => e.FlServico)
                    .HasColumnName("fl_servico")
                    .HasMaxLength(1);

                entity.Property(e => e.FlSomaTotal)
                    .HasColumnName("fl_soma_total")
                    .HasMaxLength(1);

                entity.Property(e => e.FlValidado).HasColumnName("fl_validado");

                entity.Property(e => e.IcmsNormalDifPcAliq)
                    .HasColumnName("icms_normal_dif_pc_aliq")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.IcmsNormalDifValor)
                    .HasColumnName("icms_normal_dif_valor")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.IcmsNormalDifVlBase)
                    .HasColumnName("icms_normal_dif_vl_base")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.IdNfec).HasColumnName("id_nfec");

                entity.Property(e => e.MvaDev)
                    .HasColumnName("mva_dev")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.MvaOri).HasColumnName("mva_ori");

                entity.Property(e => e.NaturezaFrete).HasColumnName("natureza_frete");

                entity.Property(e => e.NmProduto)
                    .HasColumnName("nm_produto")
                    .HasMaxLength(50);

                entity.Property(e => e.NrSequencia).HasColumnName("nr_sequencia");

                entity.Property(e => e.NrSequenciaDev).HasColumnName("nr_sequencia_dev");

                entity.Property(e => e.PcDesconto)
                    .HasColumnName("pc_desconto")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.PcFcp)
                    .HasColumnName("pc_fcp")
                    .HasColumnType("numeric(4,4)");

                entity.Property(e => e.PcFcpSt)
                    .HasColumnName("pc_fcp_st")
                    .HasColumnType("numeric(4,4)");

                entity.Property(e => e.PcFcpStRetido)
                    .HasColumnName("pc_fcp_st_retido")
                    .HasColumnType("numeric(4,4)");

                entity.Property(e => e.PcFcpUfDestino)
                    .HasColumnName("pc_fcp_uf_destino")
                    .HasColumnType("numeric(4,4)");

                entity.Property(e => e.PcIcmsInterno)
                    .HasColumnName("pc_icms_interno")
                    .HasColumnType("numeric(2,2)");

                entity.Property(e => e.PcIcmsInternoPartilha)
                    .HasColumnName("pc_icms_interno_partilha")
                    .HasColumnType("numeric(4,4)");

                entity.Property(e => e.PcIcmsUfDestino)
                    .HasColumnName("pc_icms_uf_destino")
                    .HasColumnType("numeric(4,4)");

                entity.Property(e => e.PcMarkup)
                    .HasColumnName("pc_markup")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.PcRedBaseIcm)
                    .HasColumnName("pc_red_base_icm")
                    .HasColumnType("numeric(9,2)");

                entity.Property(e => e.PcRedBaseIcmOri).HasColumnName("pc_red_base_icm_ori");

                entity.Property(e => e.PcRedBaseIcmProprioSt)
                    .HasColumnName("pc_red_base_icm_proprio_st")
                    .HasColumnType("numeric(6,2)");

                entity.Property(e => e.PcRedBaseIcmProprioStOri).HasColumnName("pc_red_base_icm_proprio_st_ori");

                entity.Property(e => e.PcRedBaseIcmSubst)
                    .HasColumnName("pc_red_base_icm_subst")
                    .HasColumnType("numeric(6,2)");

                entity.Property(e => e.PcRedBaseIcmSubstDev)
                    .HasColumnName("pc_red_base_icm_subst_dev")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.PcRedBaseIcmSubstOri).HasColumnName("pc_red_base_icm_subst_ori");

                entity.Property(e => e.PesoLiquido).HasColumnName("peso_liquido");

                entity.Property(e => e.QtCompra).HasColumnName("qt_compra");

                entity.Property(e => e.QtProduto).HasColumnName("qt_produto");

                entity.Property(e => e.UnCompra)
                    .HasColumnName("un_compra")
                    .HasMaxLength(6);

                entity.Property(e => e.UnMedida)
                    .HasColumnName("un_medida")
                    .HasMaxLength(6);

                entity.Property(e => e.VlAcrescimoRateado)
                    .HasColumnName("vl_acrescimo_rateado")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlBaseCofins)
                    .HasColumnName("vl_base_cofins")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlBaseFcp)
                    .HasColumnName("vl_base_fcp")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.VlBaseFcpSt)
                    .HasColumnName("vl_base_fcp_st")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.VlBaseFcpStRetido)
                    .HasColumnName("vl_base_fcp_st_retido")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.VlBaseFcpUfDestino)
                    .HasColumnName("vl_base_fcp_uf_destino")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.VlBaseIcm)
                    .HasColumnName("vl_base_icm")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlBaseIcmOri)
                    .HasColumnName("vl_base_icm_ori")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlBaseIcmProprioSt)
                    .HasColumnName("vl_base_icm_proprio_st")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlBaseIcmProprioStOri)
                    .HasColumnName("vl_base_icm_proprio_st_ori")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlBaseIcmSubst)
                    .HasColumnName("vl_base_icm_subst")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlBaseIcmSubstAnt)
                    .HasColumnName("vl_base_icm_subst_ant")
                    .HasColumnType("numeric(9,2)");

                entity.Property(e => e.VlBaseIcmSubstDev)
                    .HasColumnName("vl_base_icm_subst_dev")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlBaseIcmSubstOri)
                    .HasColumnName("vl_base_icm_subst_ori")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlBaseIcmSubstReal)
                    .HasColumnName("vl_base_icm_subst_real")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlBaseIpi)
                    .HasColumnName("vl_base_ipi")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlBaseIpiDev)
                    .HasColumnName("vl_base_ipi_dev")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlBaseIss)
                    .HasColumnName("vl_base_iss")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlBasePis)
                    .HasColumnName("vl_base_pis")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlBaseUfDestino)
                    .HasColumnName("vl_base_uf_destino")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.VlBruto)
                    .HasColumnName("vl_bruto")
                    .HasColumnType("numeric(18,8)");

                entity.Property(e => e.VlCofins)
                    .HasColumnName("vl_cofins")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlContabil)
                    .HasColumnName("vl_contabil")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlDesconto)
                    .HasColumnName("vl_desconto")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlDescontoRateado)
                    .HasColumnName("vl_desconto_rateado")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlFcp)
                    .HasColumnName("vl_fcp")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.VlFcpSt)
                    .HasColumnName("vl_fcp_st")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.VlFcpStRetido)
                    .HasColumnName("vl_fcp_st_retido")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.VlFcpUfDestino)
                    .HasColumnName("vl_fcp_uf_destino")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.VlFreteRateado)
                    .HasColumnName("vl_frete_rateado")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlIcm)
                    .HasColumnName("vl_icm")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlIcmFrete)
                    .HasColumnName("vl_icm_frete")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlIcmOri)
                    .HasColumnName("vl_icm_ori")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlIcmProprioSt)
                    .HasColumnName("vl_icm_proprio_st")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlIcmProprioStOri)
                    .HasColumnName("vl_icm_proprio_st_ori")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlIcmSubst)
                    .HasColumnName("vl_icm_subst")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlIcmSubstAnt)
                    .HasColumnName("vl_icm_subst_ant")
                    .HasColumnType("numeric(9,2)");

                entity.Property(e => e.VlIcmSubstDev)
                    .HasColumnName("vl_icm_subst_dev")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlIcmSubstOri)
                    .HasColumnName("vl_icm_subst_ori")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlIcmSubstReal)
                    .HasColumnName("vl_icm_subst_real")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlIcmsUfDestino)
                    .HasColumnName("vl_icms_uf_destino")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.VlIcmsUfRemetente)
                    .HasColumnName("vl_icms_uf_remetente")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.VlIpi)
                    .HasColumnName("vl_ipi")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlIpiDev)
                    .HasColumnName("vl_ipi_dev")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlIsento)
                    .HasColumnName("vl_isento")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlIss)
                    .HasColumnName("vl_iss")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlOutrasDespesas)
                    .HasColumnName("vl_outras_despesas")
                    .HasColumnType("numeric(14,4)");

                entity.Property(e => e.VlOutros)
                    .HasColumnName("vl_outros")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlPis)
                    .HasColumnName("vl_pis")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlSeguroRateado)
                    .HasColumnName("vl_seguro_rateado")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlTotal)
                    .HasColumnName("vl_total")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlUnitario)
                    .HasColumnName("vl_unitario")
                    .HasColumnType("numeric(18,8)");

                entity.Property(e => e.VlUnitarioCompra)
                    .HasColumnName("vl_unitario_compra")
                    .HasColumnType("numeric(18,8)");

                entity.HasOne(d => d.CdContaNavigation)
                    .WithMany(p => p.Nfei)
                    .HasForeignKey(d => d.CdConta)
                    .HasConstraintName("fk_nfei_cxa_conta");

                entity.HasOne(d => d.CdProdservNavigation)
                    .WithMany(p => p.Nfei)
                    .HasForeignKey(d => d.CdProdserv)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_nfeproduto");

                entity.HasOne(d => d.IdNfecNavigation)
                    .WithMany(p => p.Nfei)
                    .HasForeignKey(d => d.IdNfec)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_nfei_nfec");
            });

            modelBuilder.Entity<Nfeicomplemento>(entity =>
            {
                entity.HasKey(e => e.IdNfei);

                entity.ToTable("nfeicomplemento");

                entity.Property(e => e.IdNfei)
                    .HasColumnName("id_nfei")
                    .ValueGeneratedNever();

                entity.Property(e => e.Complemento).HasColumnName("complemento");

                entity.Property(e => e.DtAtz)
                    .HasColumnName("dt_atz")
                    .HasColumnType("date")
                    .HasDefaultValueSql("CURRENT_DATE");

                entity.HasOne(d => d.IdNfeiNavigation)
                    .WithOne(p => p.Nfeicomplemento)
                    .HasForeignKey<Nfeicomplemento>(d => d.IdNfei)
                    .HasConstraintName("fk_nfeicomplemento_nfei");
            });

            modelBuilder.Entity<NfeiImportacao>(entity =>
            {
                entity.HasKey(e => e.IdGeral);

                entity.ToTable("nfei_importacao");

                entity.Property(e => e.IdGeral)
                    .HasColumnName("id_geral")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdFabricante).HasColumnName("cd_fabricante");

                entity.Property(e => e.IdNfei).HasColumnName("id_nfei");

                entity.Property(e => e.NrAdicao).HasColumnName("nr_adicao");

                entity.Property(e => e.NrSeqAdicao).HasColumnName("nr_seq_adicao");

                entity.Property(e => e.VlBaseIi)
                    .HasColumnName("vl_base_ii")
                    .HasColumnType("numeric(14,2)");

                entity.Property(e => e.VlDescontoDi)
                    .HasColumnName("vl_desconto_di")
                    .HasColumnType("numeric(14,2)");

                entity.Property(e => e.VlDespAduaneira)
                    .HasColumnName("vl_desp_aduaneira")
                    .HasColumnType("numeric(14,2)");

                entity.Property(e => e.VlIi)
                    .HasColumnName("vl_ii")
                    .HasColumnType("numeric(14,2)");

                entity.Property(e => e.VlIof)
                    .HasColumnName("vl_iof")
                    .HasColumnType("numeric(14,2)");

                entity.Property(e => e.VlSiscomex)
                    .HasColumnName("vl_siscomex")
                    .HasColumnType("numeric(14,2)");

                entity.HasOne(d => d.IdNfeiNavigation)
                    .WithMany(p => p.NfeiImportacao)
                    .HasForeignKey(d => d.IdNfei)
                    .HasConstraintName("fk_nfei_importacao_nfei");
            });

            modelBuilder.Entity<NfeInutilizacao>(entity =>
            {
                entity.HasKey(e => e.IdGeral);

                entity.ToTable("nfe_inutilizacao");

                entity.Property(e => e.IdGeral)
                    .HasColumnName("id_geral")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdUsuario).HasColumnName("cd_usuario");

                entity.Property(e => e.DtProcessamentoInut)
                    .HasColumnName("dt_processamento_inut")
                    .HasColumnType("date");

                entity.Property(e => e.Motivo)
                    .IsRequired()
                    .HasColumnName("motivo")
                    .HasMaxLength(80);

                entity.Property(e => e.NrNf).HasColumnName("nr_nf");

                entity.Property(e => e.NrProtocoloInut)
                    .IsRequired()
                    .HasColumnName("nr_protocolo_inut")
                    .HasMaxLength(15);

                entity.Property(e => e.SerieNf)
                    .IsRequired()
                    .HasColumnName("serie_nf")
                    .HasMaxLength(3);
            });

            modelBuilder.Entity<NfReferenciada>(entity =>
            {
                entity.HasKey(e => e.IdGeral);

                entity.ToTable("nf_referenciada");

                entity.HasIndex(e => new { e.FlEntradaSaida, e.NrDocumento, e.FlEntradaSaidaRef, e.NrDocumentoRef })
                    .HasName("unq1_nf_referenciada")
                    .IsUnique();

                entity.Property(e => e.IdGeral)
                    .HasColumnName("id_geral")
                    .ValueGeneratedNever();

                entity.Property(e => e.FlEntradaSaida)
                    .HasColumnName("fl_entrada_saida")
                    .HasMaxLength(1);

                entity.Property(e => e.FlEntradaSaidaRef)
                    .HasColumnName("fl_entrada_saida_ref")
                    .HasMaxLength(1);

                entity.Property(e => e.NrDocumento).HasColumnName("nr_documento");

                entity.Property(e => e.NrDocumentoRef).HasColumnName("nr_documento_ref");
            });

            modelBuilder.Entity<Nfsc>(entity =>
            {
                entity.HasKey(e => new { e.CdFilial, e.NrDocumento });

                entity.ToTable("nfsc");

                entity.HasIndex(e => e.CdCancelamento)
                    .HasName("idx_nfsc_cancelamento");

                entity.HasIndex(e => e.CdClifor)
                    .HasName("idx_nfsc_cliente");

                entity.HasIndex(e => e.CdFilial)
                    .HasName("ind_nfsc_filial");

                entity.HasIndex(e => e.DtEmissao)
                    .HasName("idx_nfsc_data");

                entity.HasIndex(e => e.NrDocumento)
                    .HasName("ind_nfsc_doc");

                entity.HasIndex(e => e.NrSequencial)
                    .HasName("idx_nfsc_nr_sequencial");

                entity.HasIndex(e => new { e.CdFilial, e.NrDocumento })
                    .HasName("nfsc_chave");

                entity.HasIndex(e => new { e.CdFilial, e.NrNf })
                    .HasName("idx_nr_nf");

                entity.HasIndex(e => new { e.CdFilial, e.NrOsOri })
                    .HasName("idx_nfsc_os");

                entity.HasIndex(e => new { e.NrDocumento, e.CdFilial })
                    .HasName("nfsc_idx_documento_filial")
                    .IsUnique();

                entity.Property(e => e.CdFilial).HasColumnName("cd_filial");

                entity.Property(e => e.NrDocumento).HasColumnName("nr_documento");

                entity.Property(e => e.AlicIcmSimples)
                    .HasColumnName("alic_icm_simples")
                    .HasColumnType("numeric(5,2)");

                entity.Property(e => e.AliqIcmFrete).HasColumnName("aliq_icm_frete");

                entity.Property(e => e.BaseIcmProprioSt)
                    .HasColumnName("base_icm_proprio_st")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.CdBarrasAdicionalNfe)
                    .HasColumnName("cd_barras_adicional_nfe")
                    .HasMaxLength(36);

                entity.Property(e => e.CdCancelamento).HasColumnName("cd_cancelamento");

                entity.Property(e => e.CdCidadeEmbarque).HasColumnName("cd_cidade_embarque");

                entity.Property(e => e.CdClifor).HasColumnName("cd_clifor");

                entity.Property(e => e.CdCondpgto).HasColumnName("cd_condpgto");

                entity.Property(e => e.CdImpfiscal).HasColumnName("cd_impfiscal");

                entity.Property(e => e.CdModelo)
                    .HasColumnName("cd_modelo")
                    .HasMaxLength(3);

                entity.Property(e => e.CdNatoper)
                    .HasColumnName("cd_natoper")
                    .HasMaxLength(40);

                entity.Property(e => e.CdOperacao).HasColumnName("cd_operacao");

                entity.Property(e => e.CdTabelaPreco).HasColumnName("cd_tabela_preco");

                entity.Property(e => e.CdTransportadora).HasColumnName("cd_transportadora");

                entity.Property(e => e.CdUsuario).HasColumnName("cd_usuario");

                entity.Property(e => e.CfopFrete)
                    .HasColumnName("cfop_frete")
                    .HasMaxLength(10);

                entity.Property(e => e.ChaveAcessoNfe)
                    .HasColumnName("chave_acesso_nfe")
                    .HasMaxLength(44);

                entity.Property(e => e.ConhecimentoVlFrete)
                    .HasColumnName("conhecimento_vl_frete")
                    .HasColumnType("numeric(9,2)");

                entity.Property(e => e.DpecDtRegistro)
                    .HasColumnName("dpec_dt_registro")
                    .HasColumnType("date");

                entity.Property(e => e.DpecHrRegistro)
                    .HasColumnName("dpec_hr_registro")
                    .HasColumnType("time without time zone");

                entity.Property(e => e.DpecId)
                    .HasColumnName("dpec_id")
                    .HasMaxLength(10);

                entity.Property(e => e.DpecNrRegistro)
                    .HasColumnName("dpec_nr_registro")
                    .HasMaxLength(14);

                entity.Property(e => e.DtAtz)
                    .HasColumnName("dt_atz")
                    .HasColumnType("date")
                    .HasDefaultValueSql("CURRENT_DATE");

                entity.Property(e => e.DtEmissao)
                    .HasColumnName("dt_emissao")
                    .HasColumnType("date")
                    .HasDefaultValueSql("CURRENT_DATE");

                entity.Property(e => e.DtLancamento)
                    .HasColumnName("dt_lancamento")
                    .HasColumnType("date")
                    .HasDefaultValueSql("CURRENT_DATE");

                entity.Property(e => e.DtProcessamentoNfe)
                    .HasColumnName("dt_processamento_nfe")
                    .HasColumnType("date");

                entity.Property(e => e.DtSaida)
                    .HasColumnName("dt_saida")
                    .HasColumnType("date")
                    .HasDefaultValueSql("CURRENT_DATE");

                entity.Property(e => e.EcfCoo).HasColumnName("ecf_coo");

                entity.Property(e => e.EcfMfAdicional)
                    .HasColumnName("ecf_mf_adicional")
                    .HasMaxLength(1);

                entity.Property(e => e.EspecieVolumes)
                    .HasColumnName("especie_volumes")
                    .HasMaxLength(15);

                entity.Property(e => e.FlCdConta)
                    .HasColumnName("fl_cd_conta")
                    .HasMaxLength(1);

                entity.Property(e => e.FlClisimples)
                    .HasColumnName("fl_clisimples")
                    .HasMaxLength(1);

                entity.Property(e => e.FlComplementoIcms)
                    .HasColumnName("fl_complemento_icms")
                    .HasMaxLength(1);

                entity.Property(e => e.FlConsumo)
                    .HasColumnName("fl_consumo")
                    .HasMaxLength(1);

                entity.Property(e => e.FlContNcont)
                    .HasColumnName("fl_cont_ncont")
                    .HasMaxLength(1);

                entity.Property(e => e.FlControlarEstoque)
                    .HasColumnName("fl_controlar_estoque")
                    .HasMaxLength(1);

                entity.Property(e => e.FlEmprsimples)
                    .HasColumnName("fl_emprsimples")
                    .HasMaxLength(1);

                entity.Property(e => e.FlIgnorarCxaCta)
                    .IsRequired()
                    .HasColumnName("fl_ignorar_cxa_cta")
                    .HasMaxLength(1);

                entity.Property(e => e.FlIssRetido)
                    .HasColumnName("fl_iss_retido")
                    .HasMaxLength(1);

                entity.Property(e => e.FlPagoFrete)
                    .HasColumnName("fl_pago_frete")
                    .HasMaxLength(1);

                entity.Property(e => e.FlTransferencia).HasColumnName("fl_transferencia");

                entity.Property(e => e.HashNfscR4)
                    .HasColumnName("hash_nfsc_r4")
                    .HasMaxLength(70);

                entity.Property(e => e.HashNfscR5)
                    .HasColumnName("hash_nfsc_r5")
                    .HasMaxLength(70);

                entity.Property(e => e.HashNfscR7)
                    .HasColumnName("hash_nfsc_r7")
                    .HasMaxLength(70);

                entity.Property(e => e.HrEmissao)
                    .HasColumnName("hr_emissao")
                    .HasColumnType("time without time zone");

                entity.Property(e => e.HrProcessamentoNfe)
                    .HasColumnName("hr_processamento_nfe")
                    .HasColumnType("time without time zone");

                entity.Property(e => e.IdEndEntrega).HasColumnName("id_end_entrega");

                entity.Property(e => e.IdNfecDevolucao).HasColumnName("id_nfec_devolucao");

                entity.Property(e => e.Kilometragem).HasColumnName("kilometragem");

                entity.Property(e => e.MarcaVolumes)
                    .HasColumnName("marca_volumes")
                    .HasMaxLength(15);

                entity.Property(e => e.NrAidf)
                    .HasColumnName("nr_aidf")
                    .HasMaxLength(20);

                entity.Property(e => e.NrCupom).HasColumnName("nr_cupom");

                entity.Property(e => e.NrEcf).HasColumnName("nr_ecf");

                entity.Property(e => e.NrLoteNfe)
                    .HasColumnName("nr_lote_nfe")
                    .HasMaxLength(15);

                entity.Property(e => e.NrNf).HasColumnName("nr_nf");

                entity.Property(e => e.NrOsOri).HasColumnName("nr_os_ori");

                entity.Property(e => e.NrProtocoloCancNfe)
                    .HasColumnName("nr_protocolo_canc_nfe")
                    .HasMaxLength(15);

                entity.Property(e => e.NrProtocoloNfe)
                    .HasColumnName("nr_protocolo_nfe")
                    .HasMaxLength(50);

                entity.Property(e => e.NrReciboNfe)
                    .HasColumnName("nr_recibo_nfe")
                    .HasMaxLength(15);

                entity.Property(e => e.NrRps).HasColumnName("nr_rps");

                entity.Property(e => e.NrSequencial).HasColumnName("nr_sequencial");

                entity.Property(e => e.NrSr).HasColumnName("nr_sr");

                entity.Property(e => e.NrVolumes).HasColumnName("nr_volumes");

                entity.Property(e => e.Nsu)
                    .HasColumnName("nsu")
                    .HasMaxLength(10);

                entity.Property(e => e.Obs).HasColumnName("obs");

                entity.Property(e => e.Obs2).HasColumnName("obs2");

                entity.Property(e => e.PesoLiquido).HasColumnName("peso_liquido");

                entity.Property(e => e.PesoTotal).HasColumnName("peso_total");

                entity.Property(e => e.PlacaTransp)
                    .HasColumnName("placa_transp")
                    .HasMaxLength(8);

                entity.Property(e => e.PlacaVeiculo)
                    .HasColumnName("placa_veiculo")
                    .HasMaxLength(8);

                entity.Property(e => e.QtPecas).HasColumnName("qt_pecas");

                entity.Property(e => e.QtVolumes).HasColumnName("qt_volumes");

                entity.Property(e => e.RecintoAlfandegado)
                    .HasColumnName("recinto_alfandegado")
                    .HasMaxLength(60);

                entity.Property(e => e.SerieNfs)
                    .HasColumnName("serie_nfs")
                    .HasMaxLength(3);

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.TotalCst).HasColumnName("total_cst");

                entity.Property(e => e.TpEmissaoNfe).HasColumnName("tp_emissao_nfe");

                entity.Property(e => e.TpFrete)
                    .HasColumnName("tp_frete")
                    .HasMaxLength(1);

                entity.Property(e => e.UfDestino)
                    .IsRequired()
                    .HasColumnName("uf_destino")
                    .HasMaxLength(2);

                entity.Property(e => e.UfOrigem)
                    .IsRequired()
                    .HasColumnName("uf_origem")
                    .HasMaxLength(2);

                entity.Property(e => e.UfPlacaTansp)
                    .HasColumnName("uf_placa_tansp")
                    .HasMaxLength(2);

                entity.Property(e => e.UrlServico)
                    .HasColumnName("url_servico")
                    .HasMaxLength(250);

                entity.Property(e => e.VlAcresFinanceiro)
                    .HasColumnName("vl_acres_financeiro")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlAcrescimos)
                    .HasColumnName("vl_acrescimos")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlBaseCofins)
                    .HasColumnName("vl_base_cofins")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlBaseComissao)
                    .HasColumnName("vl_base_comissao")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlBaseCsll)
                    .HasColumnName("vl_base_csll")
                    .HasColumnType("numeric(9,2)");

                entity.Property(e => e.VlBaseIcm)
                    .HasColumnName("vl_base_icm")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlBaseIcmSimples)
                    .HasColumnName("vl_base_icm_simples")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlBaseIcmSubst)
                    .HasColumnName("vl_base_icm_subst")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlBaseIcmSubstAnt)
                    .HasColumnName("vl_base_icm_subst_ant")
                    .HasColumnType("numeric(9,2)");

                entity.Property(e => e.VlBaseIcmSubstDev)
                    .HasColumnName("vl_base_icm_subst_dev")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlBaseInss)
                    .HasColumnName("vl_base_inss")
                    .HasColumnType("numeric(9,2)");

                entity.Property(e => e.VlBaseIpi)
                    .HasColumnName("vl_base_ipi")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlBaseIpiDev)
                    .HasColumnName("vl_base_ipi_dev")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlBaseIr)
                    .HasColumnName("vl_base_ir")
                    .HasColumnType("numeric(9,2)");

                entity.Property(e => e.VlBaseIss)
                    .HasColumnName("vl_base_iss")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlBasePis)
                    .HasColumnName("vl_base_pis")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlCofins)
                    .HasColumnName("vl_cofins")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlComissao)
                    .HasColumnName("vl_comissao")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlCsll)
                    .HasColumnName("vl_csll")
                    .HasColumnType("numeric(9,2)");

                entity.Property(e => e.VlDescontoItem)
                    .HasColumnName("vl_desconto_item")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlDescontos)
                    .HasColumnName("vl_descontos")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlEntrada)
                    .HasColumnName("vl_entrada")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlFcp)
                    .HasColumnName("vl_fcp")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.VlFcpSt)
                    .HasColumnName("vl_fcp_st")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.VlFcpStRetido)
                    .HasColumnName("vl_fcp_st_retido")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.VlFcpUfDest)
                    .HasColumnName("vl_fcp_uf_dest")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.VlFinanciado)
                    .HasColumnName("vl_financiado")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlFrete)
                    .HasColumnName("vl_frete")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlIcm)
                    .HasColumnName("vl_icm")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlIcmFrete)
                    .HasColumnName("vl_icm_frete")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlIcmProprioSt)
                    .HasColumnName("vl_icm_proprio_st")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlIcmSimples)
                    .HasColumnName("vl_icm_simples")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlIcmSubst)
                    .HasColumnName("vl_icm_subst")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlIcmSubstAnt)
                    .HasColumnName("vl_icm_subst_ant")
                    .HasColumnType("numeric(9,2)");

                entity.Property(e => e.VlIcmSubstDev)
                    .HasColumnName("vl_icm_subst_dev")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlIcmsUfDest)
                    .HasColumnName("vl_icms_uf_dest")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.VlIcmsUfRemet)
                    .HasColumnName("vl_icms_uf_remet")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.VlInss)
                    .HasColumnName("vl_inss")
                    .HasColumnType("numeric(9,2)");

                entity.Property(e => e.VlIpi)
                    .HasColumnName("vl_ipi")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlIpiDev)
                    .HasColumnName("vl_ipi_dev")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlIr)
                    .HasColumnName("vl_ir")
                    .HasColumnType("numeric(9,2)");

                entity.Property(e => e.VlIsentoItens)
                    .HasColumnName("vl_isento_itens")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlIss)
                    .HasColumnName("vl_iss")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlIssSubst)
                    .HasColumnName("vl_iss_subst")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlMercadorias)
                    .HasColumnName("vl_mercadorias")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlOutros)
                    .HasColumnName("vl_outros")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlOutrosItens)
                    .HasColumnName("vl_outros_itens")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlPis)
                    .HasColumnName("vl_pis")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlSeguro)
                    .HasColumnName("vl_seguro")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlServicos)
                    .HasColumnName("vl_servicos")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlTotal)
                    .HasColumnName("vl_total")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlTribEstadual)
                    .HasColumnName("vl_trib_estadual")
                    .HasColumnType("numeric(9,2)");

                entity.Property(e => e.VlTribImportado)
                    .HasColumnName("vl_trib_importado")
                    .HasColumnType("numeric(9,2)");

                entity.Property(e => e.VlTribMunicipal)
                    .HasColumnName("vl_trib_municipal")
                    .HasColumnType("numeric(9,2)");

                entity.Property(e => e.VlTribNacional)
                    .HasColumnName("vl_trib_nacional")
                    .HasColumnType("numeric(9,2)");

                entity.HasOne(d => d.CdImpfiscalNavigation)
                    .WithMany(p => p.Nfsc)
                    .HasForeignKey(d => d.CdImpfiscal)
                    .HasConstraintName("fk_nfsc_impfiscal");

                entity.HasOne(d => d.CdModeloNavigation)
                    .WithMany(p => p.Nfsc)
                    .HasForeignKey(d => d.CdModelo)
                    .HasConstraintName("fk_nfsc_cd_modelo");

                entity.HasOne(d => d.CdTabelaPrecoNavigation)
                    .WithMany(p => p.Nfsc)
                    .HasForeignKey(d => d.CdTabelaPreco)
                    .HasConstraintName("fk_nfsc_tabela_preco");

                entity.HasOne(d => d.IdNfecDevolucaoNavigation)
                    .WithMany(p => p.Nfsc)
                    .HasForeignKey(d => d.IdNfecDevolucao)
                    .HasConstraintName("fk_nfsc_id_nfec_devolucao");

                entity.HasOne(d => d.Cd)
                    .WithMany(p => p.Nfsc)
                    .HasForeignKey(d => new { d.CdFilial, d.CdClifor })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_nfscliente");
            });

            modelBuilder.Entity<NfscMensagem>(entity =>
            {
                entity.HasKey(e => e.IdGeral);

                entity.ToTable("nfsc_mensagem");

                entity.Property(e => e.IdGeral)
                    .HasColumnName("id_geral")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdFilial).HasColumnName("cd_filial");

                entity.Property(e => e.CdMensagem).HasColumnName("cd_mensagem");

                entity.Property(e => e.Mensagem)
                    .IsRequired()
                    .HasColumnName("mensagem");

                entity.Property(e => e.NrDocumento).HasColumnName("nr_documento");

                entity.HasOne(d => d.CdMensagemNavigation)
                    .WithMany(p => p.NfscMensagem)
                    .HasForeignKey(d => d.CdMensagem)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_nfsc_mensagem_nota");

                entity.HasOne(d => d.Nfsc)
                    .WithMany(p => p.NfscMensagem)
                    .HasForeignKey(d => new { d.CdFilial, d.NrDocumento })
                    .HasConstraintName("fk_nfsc_mensagem_nfsc");
            });

            modelBuilder.Entity<NfscServico>(entity =>
            {
                entity.HasKey(e => e.NrDocumento);

                entity.ToTable("nfsc_servico");

                entity.Property(e => e.NrDocumento)
                    .HasColumnName("nr_documento")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdCidadePrestacao).HasColumnName("cd_cidade_prestacao");

                entity.Property(e => e.CdNatOperacao).HasColumnName("cd_nat_operacao");

                entity.Property(e => e.IncentivoCultural).HasColumnName("incentivo_cultural");
            });

            modelBuilder.Entity<Nfsi>(entity =>
            {
                entity.HasKey(e => new { e.CdFilial, e.NrDocumento, e.NrSequencia });

                entity.ToTable("nfsi");

                entity.HasIndex(e => e.CdFilial)
                    .HasName("ind_cd_filial");

                entity.HasIndex(e => e.CdProdserv)
                    .HasName("idx_cd_prodserv");

                entity.HasIndex(e => e.NrDocumento)
                    .HasName("ind_nfsi_doc");

                entity.HasIndex(e => new { e.CdFilial, e.NrDocumento, e.NrSequencia })
                    .HasName("ind_nfsi_chave");

                entity.Property(e => e.CdFilial).HasColumnName("cd_filial");

                entity.Property(e => e.NrDocumento).HasColumnName("nr_documento");

                entity.Property(e => e.NrSequencia).HasColumnName("nr_sequencia");

                entity.Property(e => e.AlicCofins)
                    .HasColumnName("alic_cofins")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.AlicCsll)
                    .HasColumnName("alic_csll")
                    .HasColumnType("numeric(9,2)");

                entity.Property(e => e.AlicIcm)
                    .HasColumnName("alic_icm")
                    .HasColumnType("numeric(9,2)");

                entity.Property(e => e.AlicIcmProprioSt)
                    .HasColumnName("alic_icm_proprio_st")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.AlicIcmSubst)
                    .HasColumnName("alic_icm_subst")
                    .HasColumnType("numeric(9,2)");

                entity.Property(e => e.AlicIcmSubstDev)
                    .HasColumnName("alic_icm_subst_dev")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.AlicIpi)
                    .HasColumnName("alic_ipi")
                    .HasColumnType("numeric(9,2)");

                entity.Property(e => e.AlicIpiDev)
                    .HasColumnName("alic_ipi_dev")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.AlicIrrf)
                    .HasColumnName("alic_irrf")
                    .HasColumnType("numeric(9,2)");

                entity.Property(e => e.AlicIss)
                    .HasColumnName("alic_iss")
                    .HasColumnType("numeric(9,2)");

                entity.Property(e => e.AlicPis)
                    .HasColumnName("alic_pis")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.AlicUfDestino)
                    .HasColumnName("alic_uf_destino")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.CdCancelamento).HasColumnName("cd_cancelamento");

                entity.Property(e => e.CdConta).HasColumnName("cd_conta");

                entity.Property(e => e.CdFci)
                    .HasColumnName("cd_fci")
                    .HasMaxLength(36);

                entity.Property(e => e.CdFuncionario).HasColumnName("cd_funcionario");

                entity.Property(e => e.CdPedComp)
                    .HasColumnName("cd_ped_comp")
                    .HasMaxLength(15);

                entity.Property(e => e.CdProdserv)
                    .IsRequired()
                    .HasColumnName("cd_prodserv")
                    .HasMaxLength(15);

                entity.Property(e => e.Cfop)
                    .HasColumnName("cfop")
                    .HasMaxLength(10);

                entity.Property(e => e.Compl).HasColumnName("compl");

                entity.Property(e => e.Composicao).HasColumnName("composicao");

                entity.Property(e => e.ConhecimentoVlFrete)
                    .HasColumnName("conhecimento_vl_frete")
                    .HasColumnType("numeric(9,2)");

                entity.Property(e => e.Cst)
                    .HasColumnName("cst")
                    .HasMaxLength(4);

                entity.Property(e => e.CstCofins)
                    .HasColumnName("cst_cofins")
                    .HasMaxLength(2);

                entity.Property(e => e.CstIpi)
                    .HasColumnName("cst_ipi")
                    .HasMaxLength(2);

                entity.Property(e => e.CstPis)
                    .HasColumnName("cst_pis")
                    .HasMaxLength(2);

                entity.Property(e => e.DtAtz)
                    .HasColumnName("dt_atz")
                    .HasColumnType("date")
                    .HasDefaultValueSql("CURRENT_DATE");

                entity.Property(e => e.DtEmissao)
                    .HasColumnName("dt_emissao")
                    .HasColumnType("date")
                    .HasDefaultValueSql("CURRENT_DATE");

                entity.Property(e => e.FatorConversao).HasColumnName("fator_conversao");

                entity.Property(e => e.FlClassfiscal)
                    .HasColumnName("fl_classfiscal")
                    .HasMaxLength(5);

                entity.Property(e => e.FlComissaoInf)
                    .HasColumnName("fl_comissao_inf")
                    .HasMaxLength(1);

                entity.Property(e => e.FlComposto)
                    .HasColumnName("fl_composto")
                    .HasMaxLength(1);

                entity.Property(e => e.FlControlarEstoque)
                    .HasColumnName("fl_controlar_estoque")
                    .HasMaxLength(1);

                entity.Property(e => e.FlServico)
                    .HasColumnName("fl_servico")
                    .HasMaxLength(1);

                entity.Property(e => e.FlSomaTotal)
                    .HasColumnName("fl_soma_total")
                    .HasMaxLength(1);

                entity.Property(e => e.FlTributacaoInf)
                    .HasColumnName("fl_tributacao_inf")
                    .HasMaxLength(1);

                entity.Property(e => e.HashNfsiR5)
                    .HasColumnName("hash_nfsi_r5")
                    .HasMaxLength(70);

                entity.Property(e => e.Iat)
                    .HasColumnName("iat")
                    .HasMaxLength(1);

                entity.Property(e => e.Kilometragem).HasColumnName("kilometragem");

                entity.Property(e => e.MvaDev)
                    .HasColumnName("mva_dev")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.NmCest)
                    .HasColumnName("nm_cest")
                    .HasMaxLength(7);

                entity.Property(e => e.NmClassFiscal)
                    .HasColumnName("nm_class_fiscal")
                    .HasMaxLength(10);

                entity.Property(e => e.NmProdserv)
                    .HasColumnName("nm_prodserv")
                    .HasMaxLength(60);

                entity.Property(e => e.NrItemPedComp).HasColumnName("nr_item_ped_comp");

                entity.Property(e => e.NrSequenciaDev).HasColumnName("nr_sequencia_dev");

                entity.Property(e => e.NrSequenciaOsOri).HasColumnName("nr_sequencia_os_ori");

                entity.Property(e => e.PcAcrescimo)
                    .HasColumnName("pc_acrescimo")
                    .HasColumnType("numeric(9,2)");

                entity.Property(e => e.PcComissao)
                    .HasColumnName("pc_comissao")
                    .HasColumnType("numeric(9,2)");

                entity.Property(e => e.PcDesconto)
                    .HasColumnName("pc_desconto")
                    .HasColumnType("numeric(9,2)");

                entity.Property(e => e.PcFcp)
                    .HasColumnName("pc_fcp")
                    .HasColumnType("numeric(4,4)");

                entity.Property(e => e.PcFcpSt)
                    .HasColumnName("pc_fcp_st")
                    .HasColumnType("numeric(4,4)");

                entity.Property(e => e.PcFcpStRetido)
                    .HasColumnName("pc_fcp_st_retido")
                    .HasColumnType("numeric(4,4)");

                entity.Property(e => e.PcFcpUfDestino)
                    .HasColumnName("pc_fcp_uf_destino")
                    .HasColumnType("numeric(4,4)");

                entity.Property(e => e.PcIcmsInterno)
                    .HasColumnName("pc_icms_interno")
                    .HasColumnType("numeric(2,2)");

                entity.Property(e => e.PcIcmsInternoPartilha)
                    .HasColumnName("pc_icms_interno_partilha")
                    .HasColumnType("numeric(4,4)");

                entity.Property(e => e.PcIcmsUfDestino)
                    .HasColumnName("pc_icms_uf_destino")
                    .HasColumnType("numeric(4,4)");

                entity.Property(e => e.PcRedBaseIcm)
                    .HasColumnName("pc_red_base_icm")
                    .HasColumnType("numeric(9,2)");

                entity.Property(e => e.PcRedBaseIcmProprioSt)
                    .HasColumnName("pc_red_base_icm_proprio_st")
                    .HasColumnType("numeric(6,2)");

                entity.Property(e => e.PcRedBaseIcmSubst)
                    .HasColumnName("pc_red_base_icm_subst")
                    .HasColumnType("numeric(6,2)");

                entity.Property(e => e.PcRedBaseIcmSubstDev)
                    .HasColumnName("pc_red_base_icm_subst_dev")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.PesoLiquido).HasColumnName("peso_liquido");

                entity.Property(e => e.PlacaVeiculo)
                    .HasColumnName("placa_veiculo")
                    .HasMaxLength(8);

                entity.Property(e => e.PrecoMinimo)
                    .HasColumnName("preco_minimo")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.QtProduto).HasColumnName("qt_produto");

                entity.Property(e => e.QtTrib).HasColumnName("qt_trib");

                entity.Property(e => e.QtVenda).HasColumnName("qt_venda");

                entity.Property(e => e.TpOperacaoVeicNovo).HasColumnName("tp_operacao_veic_novo");

                entity.Property(e => e.Un)
                    .HasColumnName("un")
                    .HasMaxLength(6);

                entity.Property(e => e.UnTrib)
                    .HasColumnName("un_trib")
                    .HasMaxLength(6);

                entity.Property(e => e.UnVenda)
                    .HasColumnName("un_venda")
                    .HasMaxLength(6);

                entity.Property(e => e.VlAcrescimo)
                    .HasColumnName("vl_acrescimo")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlAcrescimoRateado)
                    .HasColumnName("vl_acrescimo_rateado")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlBaseCofins)
                    .HasColumnName("vl_base_cofins")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlBaseComissao)
                    .HasColumnName("vl_base_comissao")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlBaseCsll)
                    .HasColumnName("vl_base_csll")
                    .HasColumnType("numeric(9,2)");

                entity.Property(e => e.VlBaseFcp)
                    .HasColumnName("vl_base_fcp")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.VlBaseFcpSt)
                    .HasColumnName("vl_base_fcp_st")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.VlBaseFcpStRetido)
                    .HasColumnName("vl_base_fcp_st_retido")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.VlBaseFcpUfDestino)
                    .HasColumnName("vl_base_fcp_uf_destino")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.VlBaseIcm)
                    .HasColumnName("vl_base_icm")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlBaseIcmProprioSt)
                    .HasColumnName("vl_base_icm_proprio_st")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlBaseIcmSubst)
                    .HasColumnName("vl_base_icm_subst")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlBaseIcmSubstAnt)
                    .HasColumnName("vl_base_icm_subst_ant")
                    .HasColumnType("numeric(9,2)");

                entity.Property(e => e.VlBaseIcmSubstDev)
                    .HasColumnName("vl_base_icm_subst_dev")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlBaseInss)
                    .HasColumnName("vl_base_inss")
                    .HasColumnType("numeric(9,2)");

                entity.Property(e => e.VlBaseIpi)
                    .HasColumnName("vl_base_ipi")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlBaseIpiDev)
                    .HasColumnName("vl_base_ipi_dev")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlBaseIr)
                    .HasColumnName("vl_base_ir")
                    .HasColumnType("numeric(9,2)");

                entity.Property(e => e.VlBaseIss)
                    .HasColumnName("vl_base_iss")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlBasePis)
                    .HasColumnName("vl_base_pis")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlBaseUfDestino)
                    .HasColumnName("vl_base_uf_destino")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.VlBruto)
                    .HasColumnName("vl_bruto")
                    .HasColumnType("numeric(18,8)");

                entity.Property(e => e.VlCofins)
                    .HasColumnName("vl_cofins")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlComissao)
                    .HasColumnName("vl_comissao")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlContabil)
                    .HasColumnName("vl_contabil")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlCsll)
                    .HasColumnName("vl_csll")
                    .HasColumnType("numeric(9,2)");

                entity.Property(e => e.VlDesconto)
                    .HasColumnName("vl_desconto")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlDescontoRateado)
                    .HasColumnName("vl_desconto_rateado")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlFcp)
                    .HasColumnName("vl_fcp")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.VlFcpSt)
                    .HasColumnName("vl_fcp_st")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.VlFcpStRetido)
                    .HasColumnName("vl_fcp_st_retido")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.VlFcpUfDestino)
                    .HasColumnName("vl_fcp_uf_destino")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.VlFreteRateado)
                    .HasColumnName("vl_frete_rateado")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlIcm)
                    .HasColumnName("vl_icm")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlIcmFrete)
                    .HasColumnName("vl_icm_frete")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlIcmProprioSt)
                    .HasColumnName("vl_icm_proprio_st")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlIcmSubst)
                    .HasColumnName("vl_icm_subst")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlIcmSubstAnt)
                    .HasColumnName("vl_icm_subst_ant")
                    .HasColumnType("numeric(9,2)");

                entity.Property(e => e.VlIcmSubstDev)
                    .HasColumnName("vl_icm_subst_dev")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlIcmsUfDestino)
                    .HasColumnName("vl_icms_uf_destino")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.VlIcmsUfRemetente)
                    .HasColumnName("vl_icms_uf_remetente")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.VlInss)
                    .HasColumnName("vl_inss")
                    .HasColumnType("numeric(9,2)");

                entity.Property(e => e.VlIpi)
                    .HasColumnName("vl_ipi")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlIpiDev)
                    .HasColumnName("vl_ipi_dev")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlIr)
                    .HasColumnName("vl_ir")
                    .HasColumnType("numeric(9,2)");

                entity.Property(e => e.VlIsento)
                    .HasColumnName("vl_isento")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlIss)
                    .HasColumnName("vl_iss")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlIssSubst)
                    .HasColumnName("vl_iss_subst")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlLiquido)
                    .HasColumnName("vl_liquido")
                    .HasColumnType("numeric(18,8)");

                entity.Property(e => e.VlLiquidoVenda)
                    .HasColumnName("vl_liquido_venda")
                    .HasColumnType("numeric(18,8)");

                entity.Property(e => e.VlOutros)
                    .HasColumnName("vl_outros")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlPis)
                    .HasColumnName("vl_pis")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlSeguroRateado)
                    .HasColumnName("vl_seguro_rateado")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlTotal)
                    .HasColumnName("vl_total")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlTrib)
                    .HasColumnName("vl_trib")
                    .HasColumnType("numeric(18,8)");

                entity.Property(e => e.VlTribEstadual)
                    .HasColumnName("vl_trib_estadual")
                    .HasColumnType("numeric(9,2)");

                entity.Property(e => e.VlTribImportado)
                    .HasColumnName("vl_trib_importado")
                    .HasColumnType("numeric(9,2)");

                entity.Property(e => e.VlTribMunicipal)
                    .HasColumnName("vl_trib_municipal")
                    .HasColumnType("numeric(9,2)");

                entity.Property(e => e.VlTribNacional)
                    .HasColumnName("vl_trib_nacional")
                    .HasColumnType("numeric(9,2)");

                entity.HasOne(d => d.CdContaNavigation)
                    .WithMany(p => p.Nfsi)
                    .HasForeignKey(d => d.CdConta)
                    .HasConstraintName("fk_nfsi_cxa_conta");

                entity.HasOne(d => d.Nfsc)
                    .WithMany(p => p.Nfsi)
                    .HasForeignKey(d => new { d.CdFilial, d.NrDocumento })
                    .HasConstraintName("fk_nfsi_nfsc");
            });

            modelBuilder.Entity<Nfsicomplemento>(entity =>
            {
                entity.HasKey(e => new { e.CdFilial, e.NrOs, e.NrSequencia });

                entity.ToTable("nfsicomplemento");

                entity.Property(e => e.CdFilial).HasColumnName("cd_filial");

                entity.Property(e => e.NrOs).HasColumnName("nr_os");

                entity.Property(e => e.NrSequencia).HasColumnName("nr_sequencia");

                entity.Property(e => e.Complemento).HasColumnName("complemento");

                entity.Property(e => e.DtAtz)
                    .HasColumnName("dt_atz")
                    .HasColumnType("date")
                    .HasDefaultValueSql("CURRENT_DATE");
            });

            modelBuilder.Entity<NfsiCupom>(entity =>
            {
                entity.HasKey(e => new { e.CdFilial, e.NrDocumento, e.NrSequencia });

                entity.ToTable("nfsi_cupom");

                entity.Property(e => e.CdFilial).HasColumnName("cd_filial");

                entity.Property(e => e.NrDocumento).HasColumnName("nr_documento");

                entity.Property(e => e.NrSequencia).HasColumnName("nr_sequencia");

                entity.Property(e => e.AlicIcm).HasColumnName("alic_icm");

                entity.Property(e => e.AlicIcmProprioSt).HasColumnName("alic_icm_proprio_st");

                entity.Property(e => e.AlicIcmSubst).HasColumnName("alic_icm_subst");

                entity.Property(e => e.Cfop)
                    .HasColumnName("cfop")
                    .HasMaxLength(10);

                entity.Property(e => e.Cst)
                    .HasColumnName("cst")
                    .HasMaxLength(4);

                entity.Property(e => e.HashNfsiCupomR5)
                    .HasColumnName("hash_nfsi_cupom_r5")
                    .HasMaxLength(70);

                entity.Property(e => e.Mva).HasColumnName("mva");

                entity.Property(e => e.PcRedBaseIcm).HasColumnName("pc_red_base_icm");

                entity.Property(e => e.PcRedBaseIcmProprioSt).HasColumnName("pc_red_base_icm_proprio_st");

                entity.Property(e => e.PcRedBaseIcmSubst).HasColumnName("pc_red_base_icm_subst");

                entity.Property(e => e.TpImpostoEcf).HasColumnName("tp_imposto_ecf");

                entity.Property(e => e.VlBaseIcm)
                    .HasColumnName("vl_base_icm")
                    .HasColumnType("numeric(14,2)");

                entity.Property(e => e.VlBaseIcmProprioSt)
                    .HasColumnName("vl_base_icm_proprio_st")
                    .HasColumnType("numeric(14,2)");

                entity.Property(e => e.VlBaseIcmSubst)
                    .HasColumnName("vl_base_icm_subst")
                    .HasColumnType("numeric(14,2)");

                entity.Property(e => e.VlIcm)
                    .HasColumnName("vl_icm")
                    .HasColumnType("numeric(14,2)");

                entity.Property(e => e.VlIcmProprioSt)
                    .HasColumnName("vl_icm_proprio_st")
                    .HasColumnType("numeric(14,2)");

                entity.Property(e => e.VlIcmSubst)
                    .HasColumnName("vl_icm_subst")
                    .HasColumnType("numeric(14,2)");

                entity.HasOne(d => d.Nfsi)
                    .WithOne(p => p.NfsiCupom)
                    .HasForeignKey<NfsiCupom>(d => new { d.CdFilial, d.NrDocumento, d.NrSequencia })
                    .HasConstraintName("fk_nfsi_cupom_nfsi");
            });

            modelBuilder.Entity<NfXml>(entity =>
            {
                entity.HasKey(e => new { e.IdNf, e.FlEntSai });

                entity.ToTable("nf_xml");

                entity.Property(e => e.IdNf).HasColumnName("id_nf");

                entity.Property(e => e.FlEntSai).HasColumnName("fl_ent_sai");

                entity.Property(e => e.DtAtz)
                    .HasColumnName("dt_atz")
                    .HasColumnType("date")
                    .HasDefaultValueSql("CURRENT_DATE");

                entity.Property(e => e.Xml).HasColumnName("xml");

                entity.Property(e => e.XmlCanc).HasColumnName("xml_canc");
            });

            modelBuilder.Entity<NrSerieNfs>(entity =>
            {
                entity.HasKey(e => e.NrSerie);

                entity.ToTable("nr_serie_nfs");

                entity.Property(e => e.NrSerie)
                    .HasColumnName("nr_serie")
                    .HasMaxLength(3)
                    .ValueGeneratedNever();

                entity.Property(e => e.EndArquivoFsda).HasColumnName("end_arquivo_fsda");

                entity.Property(e => e.EndArquivoModelo).HasColumnName("end_arquivo_modelo");

                entity.Property(e => e.FlBlocoManual)
                    .HasColumnName("fl_bloco_manual")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("'N'::character varying");

                entity.Property(e => e.NrAidf)
                    .HasColumnName("nr_aidf")
                    .HasMaxLength(20);

                entity.Property(e => e.NrUltNfsaida).HasColumnName("nr_ult_nfsaida");

                entity.Property(e => e.NrUltNfservico).HasColumnName("nr_ult_nfservico");
            });

            modelBuilder.Entity<Nsu>(entity =>
            {
                entity.HasKey(e => e.IdGeral);

                entity.ToTable("nsu");

                entity.Property(e => e.IdGeral)
                    .HasColumnName("id_geral")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdClifor).HasColumnName("cd_clifor");

                entity.Property(e => e.DtEmissao)
                    .HasColumnName("dt_emissao")
                    .HasColumnType("date");

                entity.Property(e => e.FlTipo)
                    .IsRequired()
                    .HasColumnName("fl_tipo")
                    .HasMaxLength(1);

                entity.Property(e => e.HrEmissao)
                    .HasColumnName("hr_emissao")
                    .HasColumnType("time without time zone");

                entity.Property(e => e.NrDocumento).HasColumnName("nr_documento");

                entity.Property(e => e.Nsu1)
                    .IsRequired()
                    .HasColumnName("nsu")
                    .HasMaxLength(10);

                entity.Property(e => e.Serie)
                    .IsRequired()
                    .HasColumnName("serie")
                    .HasMaxLength(3);
            });

            modelBuilder.Entity<NsuProdutoNegativo>(entity =>
            {
                entity.HasKey(e => e.IdGeral);

                entity.ToTable("nsu_produto_negativo");

                entity.Property(e => e.IdGeral)
                    .HasColumnName("id_geral")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdProduto)
                    .IsRequired()
                    .HasColumnName("cd_produto")
                    .HasMaxLength(15);

                entity.Property(e => e.IdNsu).HasColumnName("id_nsu");

                entity.Property(e => e.QtProduto).HasColumnName("qt_produto");

                entity.HasOne(d => d.IdNsuNavigation)
                    .WithMany(p => p.NsuProdutoNegativo)
                    .HasForeignKey(d => d.IdNsu)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_nsu_produto_nsu");
            });

            modelBuilder.Entity<OperacaoCfopRegra>(entity =>
            {
                entity.HasKey(e => e.IdGeral);

                entity.ToTable("operacao_cfop_regra");

                entity.HasIndex(e => new { e.CdOperacao, e.CdCfopRegra })
                    .HasName("unq1_operacao_cfop_regra")
                    .IsUnique();

                entity.Property(e => e.IdGeral)
                    .HasColumnName("id_geral")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdCfopRegra).HasColumnName("cd_cfop_regra");

                entity.Property(e => e.CdOperacao).HasColumnName("cd_operacao");

                entity.Property(e => e.CfopExtCont)
                    .IsRequired()
                    .HasColumnName("cfop_ext_cont")
                    .HasMaxLength(20);

                entity.Property(e => e.CfopExtNcont)
                    .IsRequired()
                    .HasColumnName("cfop_ext_ncont")
                    .HasMaxLength(20);

                entity.Property(e => e.CfopIntCont)
                    .IsRequired()
                    .HasColumnName("cfop_int_cont")
                    .HasMaxLength(20);

                entity.Property(e => e.CfopIntNcont)
                    .IsRequired()
                    .HasColumnName("cfop_int_ncont")
                    .HasMaxLength(20);

                entity.Property(e => e.CfopSubstExtCont)
                    .HasColumnName("cfop_subst_ext_cont")
                    .HasMaxLength(10);

                entity.Property(e => e.CfopSubstExtContRet)
                    .HasColumnName("cfop_subst_ext_cont_ret")
                    .HasMaxLength(10);

                entity.Property(e => e.CfopSubstExtNcont)
                    .HasColumnName("cfop_subst_ext_ncont")
                    .HasMaxLength(10);

                entity.Property(e => e.CfopSubstExtNcontRet)
                    .HasColumnName("cfop_subst_ext_ncont_ret")
                    .HasMaxLength(10);

                entity.Property(e => e.CfopSubstIntCont)
                    .HasColumnName("cfop_subst_int_cont")
                    .HasMaxLength(10);

                entity.Property(e => e.CfopSubstIntContRet)
                    .HasColumnName("cfop_subst_int_cont_ret")
                    .HasMaxLength(10);

                entity.Property(e => e.CfopSubstIntNcont)
                    .HasColumnName("cfop_subst_int_ncont")
                    .HasMaxLength(10);

                entity.Property(e => e.CfopSubstIntNcontRet)
                    .HasColumnName("cfop_subst_int_ncont_ret")
                    .HasMaxLength(10);

                entity.HasOne(d => d.CdCfopRegraNavigation)
                    .WithMany(p => p.OperacaoCfopRegra)
                    .HasForeignKey(d => d.CdCfopRegra)
                    .HasConstraintName("fk_operacao_cfop_regra_1");

                entity.HasOne(d => d.CdOperacaoNavigation)
                    .WithMany(p => p.OperacaoCfopRegra)
                    .HasForeignKey(d => d.CdOperacao)
                    .HasConstraintName("fk_operacao_cfop_regra_2");
            });

            modelBuilder.Entity<OperacaoEs>(entity =>
            {
                entity.HasKey(e => e.CdOperacao);

                entity.ToTable("operacao_es");

                entity.Property(e => e.CdOperacao)
                    .HasColumnName("cd_operacao")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdBcCredPiscofins)
                    .HasColumnName("cd_bc_cred_piscofins")
                    .HasMaxLength(2);

                entity.Property(e => e.CdContaMovimento).HasColumnName("cd_conta_movimento");

                entity.Property(e => e.CdGrupoOp)
                    .HasColumnName("cd_grupo_op")
                    .HasMaxLength(2);

                entity.Property(e => e.CdMensagem).HasColumnName("cd_mensagem");

                entity.Property(e => e.CdModelo)
                    .IsRequired()
                    .HasColumnName("cd_modelo")
                    .HasMaxLength(3);

                entity.Property(e => e.CdTpCredPiscofins)
                    .HasColumnName("cd_tp_cred_piscofins")
                    .HasMaxLength(3);

                entity.Property(e => e.CstCofinsDif)
                    .HasColumnName("cst_cofins_dif")
                    .HasMaxLength(5);

                entity.Property(e => e.CstPisDif)
                    .HasColumnName("cst_pis_dif")
                    .HasMaxLength(5);

                entity.Property(e => e.DtAtz)
                    .HasColumnName("dt_atz")
                    .HasColumnType("date")
                    .HasDefaultValueSql("CURRENT_DATE");

                entity.Property(e => e.Finalidade)
                    .HasColumnName("finalidade")
                    .HasMaxLength(1);

                entity.Property(e => e.FlAtivo)
                    .HasColumnName("fl_ativo")
                    .HasMaxLength(1);

                entity.Property(e => e.FlCalcularComissao).HasColumnName("fl_calcular_comissao");

                entity.Property(e => e.FlCalcularCusto).HasColumnName("fl_calcular_custo");

                entity.Property(e => e.FlCalcularIcms)
                    .HasColumnName("fl_calcular_icms")
                    .HasMaxLength(1);

                entity.Property(e => e.FlCalcularIpi).HasColumnName("fl_calcular_ipi");

                entity.Property(e => e.FlCalcularIss)
                    .IsRequired()
                    .HasColumnName("fl_calcular_iss")
                    .HasMaxLength(1);

                entity.Property(e => e.FlCdConta)
                    .HasColumnName("fl_cd_conta")
                    .HasMaxLength(1);

                entity.Property(e => e.FlControlarEstoq).HasColumnName("fl_controlar_estoq");

                entity.Property(e => e.FlCreditaIcmProprioSt)
                    .HasColumnName("fl_credita_icm_proprio_st")
                    .HasMaxLength(1);

                entity.Property(e => e.FlCreditoIcmsSt).HasColumnName("fl_credito_icms_st");

                entity.Property(e => e.FlCreditoIpi).HasColumnName("fl_credito_ipi");

                entity.Property(e => e.FlCxaFranquia)
                    .HasColumnName("fl_cxa_franquia")
                    .HasMaxLength(1);

                entity.Property(e => e.FlEntSai)
                    .IsRequired()
                    .HasColumnName("fl_ent_sai")
                    .HasMaxLength(1);

                entity.Property(e => e.FlIgnoraCaixaContas).HasColumnName("fl_ignora_caixa_contas");

                entity.Property(e => e.FlImportacao)
                    .HasColumnName("fl_importacao")
                    .HasMaxLength(1);

                entity.Property(e => e.FlIncluiIcmsStBasePis)
                    .HasColumnName("fl_inclui_icms_st_base_pis")
                    .HasMaxLength(1);

                entity.Property(e => e.FlIncluiIpiBasePis)
                    .HasColumnName("fl_inclui_ipi_base_pis")
                    .HasMaxLength(1);

                entity.Property(e => e.FlInfoXml).HasColumnName("fl_info_xml");

                entity.Property(e => e.FlReducaoJuridica).HasColumnName("fl_reducao_juridica");

                entity.Property(e => e.FlReferenciarNota).HasColumnName("fl_referenciar_nota");

                entity.Property(e => e.FlSugerirPreco)
                    .HasColumnName("fl_sugerir_preco")
                    .HasMaxLength(1);

                entity.Property(e => e.FlTributarFrete).HasColumnName("fl_tributar_frete");

                entity.Property(e => e.IdTributacaoGrupo).HasColumnName("id_tributacao_grupo");

                entity.Property(e => e.IdTributacaoGrupoPisCofins).HasColumnName("id_tributacao_grupo_pis_cofins");

                entity.Property(e => e.IndPresencial)
                    .HasColumnName("ind_presencial")
                    .HasMaxLength(1);

                entity.Property(e => e.NatOperacao)
                    .IsRequired()
                    .HasColumnName("nat_operacao")
                    .HasMaxLength(40);

                entity.Property(e => e.NmOperacao)
                    .HasColumnName("nm_operacao")
                    .HasMaxLength(40);

                entity.HasOne(d => d.CdBcCredPiscofinsNavigation)
                    .WithMany(p => p.OperacaoEs)
                    .HasForeignKey(d => d.CdBcCredPiscofins)
                    .HasConstraintName("fk_operacao_es_cd_bc_cred_pisco");

                entity.HasOne(d => d.CdContaMovimentoNavigation)
                    .WithMany(p => p.OperacaoEs)
                    .HasForeignKey(d => d.CdContaMovimento)
                    .HasConstraintName("fk_operacao_es_cxa_conta");

                entity.HasOne(d => d.CdGrupoOpNavigation)
                    .WithMany(p => p.OperacaoEs)
                    .HasForeignKey(d => d.CdGrupoOp)
                    .HasConstraintName("fk_operacao_es_grupo_op");

                entity.HasOne(d => d.CdMensagemNavigation)
                    .WithMany(p => p.OperacaoEs)
                    .HasForeignKey(d => d.CdMensagem)
                    .HasConstraintName("fk_operacao_es_cd_mensagem");

                entity.HasOne(d => d.CdModeloNavigation)
                    .WithMany(p => p.OperacaoEs)
                    .HasForeignKey(d => d.CdModelo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_operacao_es_cd_modelo");

                entity.HasOne(d => d.CdTpCredPiscofinsNavigation)
                    .WithMany(p => p.OperacaoEs)
                    .HasForeignKey(d => d.CdTpCredPiscofins)
                    .HasConstraintName("fk_operacao_es_cd_tp_cred_pisco");

                entity.HasOne(d => d.IdTributacaoGrupoNavigation)
                    .WithMany(p => p.OperacaoEs)
                    .HasForeignKey(d => d.IdTributacaoGrupo)
                    .HasConstraintName("fk_operacao_es_id_trib_grupo");

                entity.HasOne(d => d.IdTributacaoGrupoPisCofinsNavigation)
                    .WithMany(p => p.OperacaoEs)
                    .HasForeignKey(d => d.IdTributacaoGrupoPisCofins)
                    .HasConstraintName("fk_operacao_es_id_trib_pis_cofi");
            });

            modelBuilder.Entity<OrcamentoAgrupado>(entity =>
            {
                entity.HasKey(e => new { e.NrOs, e.NrOsAgrupada });

                entity.ToTable("orcamento_agrupado");

                entity.Property(e => e.NrOs).HasColumnName("nr_os");

                entity.Property(e => e.NrOsAgrupada).HasColumnName("nr_os_agrupada");
            });

            modelBuilder.Entity<OrcamentoC>(entity =>
            {
                entity.HasKey(e => new { e.CdFilial, e.NrOs });

                entity.ToTable("orcamento_c");

                entity.HasIndex(e => e.FlAgrupado)
                    .HasName("ind_orcamento_c_agrupado");

                entity.HasIndex(e => e.FlCancelado)
                    .HasName("ind_orcamento_c_cancelado");

                entity.HasIndex(e => e.FlFinalizado)
                    .HasName("ind_orcamento_c_finalizado");

                entity.HasIndex(e => e.NrOs)
                    .HasName("idx_orcamento_c_nr_os");

                entity.HasIndex(e => new { e.CdFrenteCaixa, e.FlDavImpresso })
                    .HasName("idx_orcamento_c_frente_caixa");

                entity.Property(e => e.CdFilial).HasColumnName("cd_filial");

                entity.Property(e => e.NrOs).HasColumnName("nr_os");

                entity.Property(e => e.CdClifor).HasColumnName("cd_clifor");

                entity.Property(e => e.CdCondpgto).HasColumnName("cd_condpgto");

                entity.Property(e => e.CdFrenteCaixa).HasColumnName("cd_frente_caixa");

                entity.Property(e => e.CdSituacao).HasColumnName("cd_situacao");

                entity.Property(e => e.CdTabelaPreco).HasColumnName("cd_tabela_preco");

                entity.Property(e => e.CdUsuario).HasColumnName("cd_usuario");

                entity.Property(e => e.DatahoraCancelamento).HasColumnName("datahora_cancelamento");

                entity.Property(e => e.DtAtz)
                    .HasColumnName("dt_atz")
                    .HasColumnType("date")
                    .HasDefaultValueSql("CURRENT_DATE");

                entity.Property(e => e.DtEmissao)
                    .HasColumnName("dt_emissao")
                    .HasColumnType("date");

                entity.Property(e => e.DtEntrega)
                    .HasColumnName("dt_entrega")
                    .HasColumnType("date");

                entity.Property(e => e.DtValidade)
                    .HasColumnName("dt_validade")
                    .HasColumnType("date");

                entity.Property(e => e.FlAgrupado).HasColumnName("fl_agrupado");

                entity.Property(e => e.FlCancelado).HasColumnName("fl_cancelado");

                entity.Property(e => e.FlDavImpresso)
                    .HasColumnName("fl_dav_impresso")
                    .HasMaxLength(1);

                entity.Property(e => e.FlEnviaPaf)
                    .HasColumnName("fl_envia_paf")
                    .HasMaxLength(1);

                entity.Property(e => e.FlExportaDavPdf).HasColumnName("fl_exporta_dav_pdf");

                entity.Property(e => e.FlFinalizado).HasColumnName("fl_finalizado");

                entity.Property(e => e.HashOrcamentoCD2)
                    .HasColumnName("hash_orcamento_c_d2")
                    .HasMaxLength(70);

                entity.Property(e => e.HashOrcamentoCD3)
                    .HasColumnName("hash_orcamento_c_d3")
                    .HasMaxLength(70);

                entity.Property(e => e.IdEndEntrega).HasColumnName("id_end_entrega");

                entity.Property(e => e.Kilometragem).HasColumnName("kilometragem");

                entity.Property(e => e.MotivoCancelamento)
                    .HasColumnName("motivo_cancelamento")
                    .HasMaxLength(80);

                entity.Property(e => e.NmCidade)
                    .HasColumnName("nm_cidade")
                    .HasMaxLength(40);

                entity.Property(e => e.NmClifor)
                    .HasColumnName("nm_clifor")
                    .HasMaxLength(80);

                entity.Property(e => e.NmMontadora)
                    .HasColumnName("nm_montadora")
                    .HasMaxLength(40);

                entity.Property(e => e.NmVeiculo)
                    .HasColumnName("nm_veiculo")
                    .HasMaxLength(70);

                entity.Property(e => e.NrPreVenda).HasColumnName("nr_pre_venda");

                entity.Property(e => e.Obs).HasColumnName("obs");

                entity.Property(e => e.PlacaVeiculo)
                    .IsRequired()
                    .HasColumnName("placa_veiculo")
                    .HasMaxLength(8);

                entity.Property(e => e.Problema).HasColumnName("problema");

                entity.Property(e => e.TelMail)
                    .HasColumnName("tel_mail")
                    .HasMaxLength(50);

                entity.Property(e => e.Uf)
                    .HasColumnName("uf")
                    .HasMaxLength(2);

                entity.Property(e => e.UsuarioCancelamento).HasColumnName("usuario_cancelamento");

                entity.Property(e => e.VlAcrescimos)
                    .HasColumnName("vl_acrescimos")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlDescontos)
                    .HasColumnName("vl_descontos")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlEntrada)
                    .HasColumnName("vl_entrada")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlIcmsst)
                    .HasColumnName("vl_icmsst")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlIpi)
                    .HasColumnName("vl_ipi")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlMercadorias)
                    .HasColumnName("vl_mercadorias")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlServicos)
                    .HasColumnName("vl_servicos")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlTotal)
                    .HasColumnName("vl_total")
                    .HasColumnType("numeric(18,4)");

                entity.HasOne(d => d.CdFrenteCaixaNavigation)
                    .WithMany(p => p.OrcamentoC)
                    .HasForeignKey(d => d.CdFrenteCaixa)
                    .HasConstraintName("fk_orcamento_c_frente_caixa");

                entity.HasOne(d => d.CdSituacaoNavigation)
                    .WithMany(p => p.OrcamentoC)
                    .HasForeignKey(d => d.CdSituacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_orcamento_c_situacao");

                entity.HasOne(d => d.CdTabelaPrecoNavigation)
                    .WithMany(p => p.OrcamentoC)
                    .HasForeignKey(d => d.CdTabelaPreco)
                    .HasConstraintName("fk_orcamento_c_tabela_preco");

                entity.HasOne(d => d.UsuarioCancelamentoNavigation)
                    .WithMany(p => p.OrcamentoC)
                    .HasForeignKey(d => d.UsuarioCancelamento)
                    .HasConstraintName("fk_orcamento_c_usuario");
            });

            modelBuilder.Entity<OrcamentoContato>(entity =>
            {
                entity.HasKey(e => new { e.NrOs, e.CdContato });

                entity.ToTable("orcamento_contato");

                entity.Property(e => e.NrOs).HasColumnName("nr_os");

                entity.Property(e => e.CdContato).HasColumnName("cd_contato");

                entity.Property(e => e.CdFilial).HasColumnName("cd_filial");

                entity.HasOne(d => d.CdContatoNavigation)
                    .WithMany(p => p.OrcamentoContato)
                    .HasForeignKey(d => d.CdContato)
                    .HasConstraintName("fk_orcamento_contato_contato");

                entity.HasOne(d => d.OrcamentoC)
                    .WithMany(p => p.OrcamentoContato)
                    .HasForeignKey(d => new { d.CdFilial, d.NrOs })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_orcamento_contato_orc");
            });

            modelBuilder.Entity<OrcamentoDav>(entity =>
            {
                entity.HasKey(e => new { e.NrOs, e.NrSequencia });

                entity.ToTable("orcamento_dav");

                entity.Property(e => e.NrOs).HasColumnName("nr_os");

                entity.Property(e => e.NrSequencia).HasColumnName("nr_sequencia");

                entity.Property(e => e.CdImpfiscal).HasColumnName("cd_impfiscal");

                entity.Property(e => e.CdUsuario).HasColumnName("cd_usuario");

                entity.Property(e => e.DtAtz)
                    .HasColumnName("dt_atz")
                    .HasColumnType("date");

                entity.Property(e => e.FlCancelado)
                    .HasColumnName("fl_cancelado")
                    .HasMaxLength(1);

                entity.Property(e => e.HashOrcamentoDavD2)
                    .HasColumnName("hash_orcamento_dav_d2")
                    .HasMaxLength(70);

                entity.Property(e => e.HashOrcamentoDavD3)
                    .HasColumnName("hash_orcamento_dav_d3")
                    .HasMaxLength(70);

                entity.Property(e => e.MfAdicional)
                    .HasColumnName("mf_adicional")
                    .HasMaxLength(1);

                entity.Property(e => e.NrCcfCupom).HasColumnName("nr_ccf_cupom");

                entity.Property(e => e.NrCooCupom).HasColumnName("nr_coo_cupom");

                entity.Property(e => e.NrCooDav).HasColumnName("nr_coo_dav");

                entity.Property(e => e.NrDav).HasColumnName("nr_dav");

                entity.Property(e => e.VlTotalDav)
                    .HasColumnName("vl_total_dav")
                    .HasColumnType("numeric(18,4)");
            });

            modelBuilder.Entity<OrcamentoFrete>(entity =>
            {
                entity.HasKey(e => new { e.CdFilial, e.NrOs });

                entity.ToTable("orcamento_frete");

                entity.Property(e => e.CdFilial).HasColumnName("cd_filial");

                entity.Property(e => e.NrOs).HasColumnName("nr_os");

                entity.Property(e => e.CdTransportadora).HasColumnName("cd_transportadora");

                entity.Property(e => e.EspecieVolumes)
                    .HasColumnName("especie_volumes")
                    .HasMaxLength(15);

                entity.Property(e => e.MarcaVolumes)
                    .HasColumnName("marca_volumes")
                    .HasMaxLength(15);

                entity.Property(e => e.NrVolumes).HasColumnName("nr_volumes");

                entity.Property(e => e.PesoLiquido).HasColumnName("peso_liquido");

                entity.Property(e => e.PesoTotal).HasColumnName("peso_total");

                entity.Property(e => e.PlacaTransp)
                    .HasColumnName("placa_transp")
                    .HasMaxLength(8);

                entity.Property(e => e.QtVolumes).HasColumnName("qt_volumes");

                entity.Property(e => e.TpFrete)
                    .IsRequired()
                    .HasColumnName("tp_frete")
                    .HasMaxLength(1);

                entity.Property(e => e.UfPlacaTransp)
                    .HasColumnName("uf_placa_transp")
                    .HasMaxLength(2);
            });

            modelBuilder.Entity<OrcamentoI>(entity =>
            {
                entity.HasKey(e => new { e.CdFilial, e.NrOs, e.NrSequencia });

                entity.ToTable("orcamento_i");

                entity.HasIndex(e => e.NrOs)
                    .HasName("idx_orcamento_i_nr_os");

                entity.HasIndex(e => new { e.CdFilial, e.NrOs })
                    .HasName("orcamento_i_idxcd_filial_nr_os");

                entity.Property(e => e.CdFilial).HasColumnName("cd_filial");

                entity.Property(e => e.NrOs).HasColumnName("nr_os");

                entity.Property(e => e.NrSequencia).HasColumnName("nr_sequencia");

                entity.Property(e => e.Box)
                    .HasColumnName("box")
                    .HasMaxLength(10);

                entity.Property(e => e.CdBarras)
                    .HasColumnName("cd_barras")
                    .HasMaxLength(20);

                entity.Property(e => e.CdFuncionario).HasColumnName("cd_funcionario");

                entity.Property(e => e.CdOriginal)
                    .HasColumnName("cd_original")
                    .HasMaxLength(20);

                entity.Property(e => e.CdPedComp)
                    .HasColumnName("cd_ped_comp")
                    .HasMaxLength(15);

                entity.Property(e => e.CdProduto)
                    .IsRequired()
                    .HasColumnName("cd_produto")
                    .HasMaxLength(15);

                entity.Property(e => e.Complemento).HasColumnName("complemento");

                entity.Property(e => e.DtAtz)
                    .HasColumnName("dt_atz")
                    .HasColumnType("date")
                    .HasDefaultValueSql("CURRENT_DATE");

                entity.Property(e => e.DtEmissao)
                    .HasColumnName("dt_emissao")
                    .HasColumnType("date")
                    .HasDefaultValueSql("CURRENT_DATE");

                entity.Property(e => e.FatorConversao).HasColumnName("fator_conversao");

                entity.Property(e => e.FlAlteracao)
                    .HasColumnName("fl_alteracao")
                    .HasMaxLength(1);

                entity.Property(e => e.FlItemCancelado).HasColumnName("fl_item_cancelado");

                entity.Property(e => e.FlReservandoEstoque).HasColumnName("fl_reservando_estoque");

                entity.Property(e => e.FlServico)
                    .HasColumnName("fl_servico")
                    .HasMaxLength(1);

                entity.Property(e => e.HashOrcamentoID3)
                    .HasColumnName("hash_orcamento_i_d3")
                    .HasMaxLength(70);

                entity.Property(e => e.HrAlteracao)
                    .HasColumnName("hr_alteracao")
                    .HasMaxLength(6);

                entity.Property(e => e.Kilometragem).HasColumnName("kilometragem");

                entity.Property(e => e.LocalEstocagem)
                    .HasColumnName("local_estocagem")
                    .HasMaxLength(40);

                entity.Property(e => e.NmProduto)
                    .HasColumnName("nm_produto")
                    .HasMaxLength(60);

                entity.Property(e => e.NrItemPedComp).HasColumnName("nr_item_ped_comp");

                entity.Property(e => e.NrSerieEquip)
                    .HasColumnName("nr_serie_equip")
                    .HasMaxLength(32);

                entity.Property(e => e.PcAcrescimo)
                    .HasColumnName("pc_acrescimo")
                    .HasColumnType("numeric(9,2)");

                entity.Property(e => e.PcDesconto)
                    .HasColumnName("pc_desconto")
                    .HasColumnType("numeric(9,2)");

                entity.Property(e => e.PlacaVeiculo)
                    .HasColumnName("placa_veiculo")
                    .HasMaxLength(8);

                entity.Property(e => e.QtProduto).HasColumnName("qt_produto");

                entity.Property(e => e.QtVenda).HasColumnName("qt_venda");

                entity.Property(e => e.UnMedida)
                    .HasColumnName("un_medida")
                    .HasMaxLength(6);

                entity.Property(e => e.UnVenda)
                    .HasColumnName("un_venda")
                    .HasMaxLength(6);

                entity.Property(e => e.VlAcrescimo)
                    .HasColumnName("vl_acrescimo")
                    .HasColumnType("numeric(9,2)");

                entity.Property(e => e.VlBruto)
                    .HasColumnName("vl_bruto")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlCusto)
                    .HasColumnName("vl_custo")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlDesconto)
                    .HasColumnName("vl_desconto")
                    .HasColumnType("numeric(9,2)");

                entity.Property(e => e.VlIpi)
                    .HasColumnName("vl_ipi")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlLiquido)
                    .HasColumnName("vl_liquido")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlTotal)
                    .HasColumnName("vl_total")
                    .HasColumnType("numeric(18,4)");

                entity.HasOne(d => d.CdProdutoNavigation)
                    .WithMany(p => p.OrcamentoI)
                    .HasForeignKey(d => d.CdProduto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_orcproduto");
            });

            modelBuilder.Entity<OrcamentoIAgrupa>(entity =>
            {
                entity.HasKey(e => new { e.CdFilial, e.NrOs, e.NrSequenciaEquip, e.NrSequenciaServico });

                entity.ToTable("orcamento_i_agrupa");

                entity.Property(e => e.CdFilial).HasColumnName("cd_filial");

                entity.Property(e => e.NrOs).HasColumnName("nr_os");

                entity.Property(e => e.NrSequenciaEquip).HasColumnName("nr_sequencia_equip");

                entity.Property(e => e.NrSequenciaServico).HasColumnName("nr_sequencia_servico");

                entity.HasOne(d => d.OrcamentoI)
                    .WithMany(p => p.OrcamentoIAgrupaOrcamentoI)
                    .HasForeignKey(d => new { d.CdFilial, d.NrOs, d.NrSequenciaEquip })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_orcamento_i_agrupa_equip");

                entity.HasOne(d => d.OrcamentoINavigation)
                    .WithMany(p => p.OrcamentoIAgrupaOrcamentoINavigation)
                    .HasForeignKey(d => new { d.CdFilial, d.NrOs, d.NrSequenciaServico })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_orcamento_i_agrupa_servico");
            });

            modelBuilder.Entity<OrcamentoImagem>(entity =>
            {
                entity.HasKey(e => new { e.IdGeral, e.NrOs });

                entity.ToTable("orcamento_imagem");

                entity.Property(e => e.IdGeral).HasColumnName("id_geral");

                entity.Property(e => e.NrOs).HasColumnName("nr_os");

                entity.Property(e => e.DtAtz)
                    .HasColumnName("dt_atz")
                    .HasColumnType("date")
                    .HasDefaultValueSql("CURRENT_DATE");

                entity.Property(e => e.Imagem)
                    .IsRequired()
                    .HasColumnName("imagem");

                entity.Property(e => e.Obs)
                    .HasColumnName("obs")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<OrcamentoIReservaEstoque>(entity =>
            {
                entity.HasKey(e => new { e.CdFilial, e.NrOs, e.NrSequencia });

                entity.ToTable("orcamento_i_reserva_estoque");

                entity.HasIndex(e => e.CdProduto)
                    .HasName("reserva_estoque_idx_cd_produto");

                entity.HasIndex(e => e.NrOs)
                    .HasName("reserva_estoque_idx_nr_os");

                entity.Property(e => e.CdFilial).HasColumnName("cd_filial");

                entity.Property(e => e.NrOs).HasColumnName("nr_os");

                entity.Property(e => e.NrSequencia).HasColumnName("nr_sequencia");

                entity.Property(e => e.CdProduto)
                    .HasColumnName("cd_produto")
                    .HasMaxLength(15);

                entity.Property(e => e.QtReservado)
                    .HasColumnName("qt_reservado")
                    .HasColumnType("numeric(18,4)");

                entity.HasOne(d => d.OrcamentoI)
                    .WithOne(p => p.OrcamentoIReservaEstoque)
                    .HasForeignKey<OrcamentoIReservaEstoque>(d => new { d.CdFilial, d.NrOs, d.NrSequencia })
                    .HasConstraintName("fk_orcamento_i_reserva_estoque_");
            });

            modelBuilder.Entity<OrcamentoNfe>(entity =>
            {
                entity.HasKey(e => new { e.NrOs, e.IdNfec });

                entity.ToTable("orcamento_nfe");

                entity.Property(e => e.NrOs).HasColumnName("nr_os");

                entity.Property(e => e.IdNfec).HasColumnName("id_nfec");

                entity.HasOne(d => d.IdNfecNavigation)
                    .WithMany(p => p.OrcamentoNfe)
                    .HasForeignKey(d => d.IdNfec)
                    .HasConstraintName("fk_orcamento_nfe_nfec");
            });

            modelBuilder.Entity<OrcamentoSituacao>(entity =>
            {
                entity.HasKey(e => new { e.CdFilial, e.NrOs, e.DtModificacao });

                entity.ToTable("orcamento_situacao");

                entity.HasIndex(e => e.DtModificacao)
                    .HasName("idx_orcamento_situacao_data");

                entity.Property(e => e.CdFilial).HasColumnName("cd_filial");

                entity.Property(e => e.NrOs).HasColumnName("nr_os");

                entity.Property(e => e.DtModificacao).HasColumnName("dt_modificacao");

                entity.Property(e => e.CdFuncionario).HasColumnName("cd_funcionario");

                entity.Property(e => e.CdSituacao).HasColumnName("cd_situacao");
            });

            modelBuilder.Entity<OrdemProducaoC>(entity =>
            {
                entity.HasKey(e => e.IdGeral);

                entity.ToTable("ordem_producao_c");

                entity.HasIndex(e => new { e.CdFilial, e.NrOrdemProducao })
                    .HasName("unq1_ordem_producao_c")
                    .IsUnique();

                entity.Property(e => e.IdGeral)
                    .HasColumnName("id_geral")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdFilial).HasColumnName("cd_filial");

                entity.Property(e => e.CdFuncionario).HasColumnName("cd_funcionario");

                entity.Property(e => e.CdSituacao)
                    .HasColumnName("cd_situacao")
                    .HasMaxLength(1);

                entity.Property(e => e.DtEmissao)
                    .HasColumnName("dt_emissao")
                    .HasColumnType("date");

                entity.Property(e => e.DtPrevisao)
                    .HasColumnName("dt_previsao")
                    .HasColumnType("date");

                entity.Property(e => e.NrMaquina)
                    .HasColumnName("nr_maquina")
                    .HasMaxLength(100);

                entity.Property(e => e.NrOrdemProducao).HasColumnName("nr_ordem_producao");

                entity.Property(e => e.Turno)
                    .HasColumnName("turno")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<OrdemProducaoI>(entity =>
            {
                entity.HasKey(e => e.IdGeral);

                entity.ToTable("ordem_producao_i");

                entity.HasIndex(e => new { e.IdOrdemProducaoC, e.CdItem })
                    .HasName("unq_ordem_producao_i")
                    .IsUnique();

                entity.Property(e => e.IdGeral)
                    .HasColumnName("id_geral")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdItem)
                    .IsRequired()
                    .HasColumnName("cd_item")
                    .HasMaxLength(15);

                entity.Property(e => e.IdOrdemProducaoC).HasColumnName("id_ordem_producao_c");

                entity.Property(e => e.QtProducao).HasColumnName("qt_producao");

                entity.Property(e => e.QtProduzido).HasColumnName("qt_produzido");

                entity.HasOne(d => d.CdItemNavigation)
                    .WithMany(p => p.OrdemProducaoI)
                    .HasForeignKey(d => d.CdItem)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ordem_producao_i_cd_produto");

                entity.HasOne(d => d.IdOrdemProducaoCNavigation)
                    .WithMany(p => p.OrdemProducaoI)
                    .HasForeignKey(d => d.IdOrdemProducaoC)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ordem_producao_i_id_ordem_c");
            });

            modelBuilder.Entity<PafecfE3>(entity =>
            {
                entity.HasKey(e => e.IdGeral);

                entity.ToTable("pafecf_e3");

                entity.Property(e => e.IdGeral)
                    .HasColumnName("id_geral")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdImpfiscal).HasColumnName("cd_impfiscal");

                entity.Property(e => e.Data)
                    .HasColumnName("data")
                    .HasColumnType("date");

                entity.Property(e => e.HashE3)
                    .HasColumnName("hash_e3")
                    .HasMaxLength(70);

                entity.Property(e => e.Hora)
                    .HasColumnName("hora")
                    .HasColumnType("time without time zone");

                entity.HasOne(d => d.CdImpfiscalNavigation)
                    .WithMany(p => p.PafecfE3)
                    .HasForeignKey(d => d.CdImpfiscal)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_pafecf_e3");
            });

            modelBuilder.Entity<PedidoAfvC>(entity =>
            {
                entity.HasKey(e => new { e.CdFilial, e.NrPedido });

                entity.ToTable("pedido_afv_c");

                entity.Property(e => e.CdFilial).HasColumnName("cd_filial");

                entity.Property(e => e.NrPedido).HasColumnName("nr_pedido");

                entity.Property(e => e.CdClifor).HasColumnName("cd_clifor");

                entity.Property(e => e.CdCondpgto).HasColumnName("cd_condpgto");

                entity.Property(e => e.CdSituacao).HasColumnName("cd_situacao");

                entity.Property(e => e.CdUsuario).HasColumnName("cd_usuario");

                entity.Property(e => e.DtAtz)
                    .HasColumnName("dt_atz")
                    .HasColumnType("date")
                    .HasDefaultValueSql("CURRENT_DATE");

                entity.Property(e => e.DtEmissao)
                    .HasColumnName("dt_emissao")
                    .HasColumnType("date");

                entity.Property(e => e.DtEntrega)
                    .HasColumnName("dt_entrega")
                    .HasColumnType("date");

                entity.Property(e => e.DtValidade)
                    .HasColumnName("dt_validade")
                    .HasColumnType("date");

                entity.Property(e => e.FlAgrupado).HasColumnName("fl_agrupado");

                entity.Property(e => e.FlCancelado).HasColumnName("fl_cancelado");

                entity.Property(e => e.FlFinalizado).HasColumnName("fl_finalizado");

                entity.Property(e => e.FlGerado).HasColumnName("fl_gerado");

                entity.Property(e => e.FlTransmitido)
                    .HasColumnName("fl_transmitido")
                    .HasDefaultValueSql("'N'::bpchar");

                entity.Property(e => e.IndicePreco).HasColumnName("indice_preco");

                entity.Property(e => e.MotivoCancelamento)
                    .HasColumnName("motivo_cancelamento")
                    .HasMaxLength(80);

                entity.Property(e => e.NrDavGerada).HasColumnName("nr_dav_gerada");

                entity.Property(e => e.NrOsGerada).HasColumnName("nr_os_gerada");

                entity.Property(e => e.Obs).HasColumnName("obs");

                entity.Property(e => e.VlAcrescimos)
                    .HasColumnName("vl_acrescimos")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlDescontos)
                    .HasColumnName("vl_descontos")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlEntrada)
                    .HasColumnName("vl_entrada")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlIpi)
                    .HasColumnName("vl_ipi")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlMercadorias)
                    .HasColumnName("vl_mercadorias")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlServicos)
                    .HasColumnName("vl_servicos")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlTotal)
                    .HasColumnName("vl_total")
                    .HasColumnType("numeric(18,4)");
            });

            modelBuilder.Entity<PedidoAfvI>(entity =>
            {
                entity.HasKey(e => new { e.CdFilial, e.NrPedido, e.NrSequencia });

                entity.ToTable("pedido_afv_i");

                entity.Property(e => e.CdFilial).HasColumnName("cd_filial");

                entity.Property(e => e.NrPedido).HasColumnName("nr_pedido");

                entity.Property(e => e.NrSequencia).HasColumnName("nr_sequencia");

                entity.Property(e => e.CdBarras)
                    .HasColumnName("cd_barras")
                    .HasMaxLength(20);

                entity.Property(e => e.CdFuncionario).HasColumnName("cd_funcionario");

                entity.Property(e => e.CdOriginal)
                    .HasColumnName("cd_original")
                    .HasMaxLength(20);

                entity.Property(e => e.CdProduto)
                    .IsRequired()
                    .HasColumnName("cd_produto")
                    .HasMaxLength(15);

                entity.Property(e => e.Complemento).HasColumnName("complemento");

                entity.Property(e => e.DtAtz)
                    .HasColumnName("dt_atz")
                    .HasColumnType("date")
                    .HasDefaultValueSql("CURRENT_DATE");

                entity.Property(e => e.DtEmissao)
                    .HasColumnName("dt_emissao")
                    .HasColumnType("date")
                    .HasDefaultValueSql("CURRENT_DATE");

                entity.Property(e => e.FlServico)
                    .HasColumnName("fl_servico")
                    .HasMaxLength(1);

                entity.Property(e => e.Kilometragem).HasColumnName("kilometragem");

                entity.Property(e => e.NmProduto)
                    .HasColumnName("nm_produto")
                    .HasMaxLength(60);

                entity.Property(e => e.PcDesconto)
                    .HasColumnName("pc_desconto")
                    .HasColumnType("numeric(9,2)");

                entity.Property(e => e.PlacaVeiculo)
                    .HasColumnName("placa_veiculo")
                    .HasMaxLength(8);

                entity.Property(e => e.QtProduto).HasColumnName("qt_produto");

                entity.Property(e => e.UnMedida)
                    .HasColumnName("un_medida")
                    .HasMaxLength(3);

                entity.Property(e => e.VlBruto)
                    .HasColumnName("vl_bruto")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlCusto)
                    .HasColumnName("vl_custo")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlIpi)
                    .HasColumnName("vl_ipi")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlLiquido)
                    .HasColumnName("vl_liquido")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlTotal)
                    .HasColumnName("vl_total")
                    .HasColumnType("numeric(18,4)");
            });

            modelBuilder.Entity<PedidoC>(entity =>
            {
                entity.HasKey(e => e.NrPedido);

                entity.ToTable("pedido_c");

                entity.HasIndex(e => e.CdFuncionario)
                    .HasName("ind_pedido_func");

                entity.HasIndex(e => e.DtEmissao)
                    .HasName("ind_pedido_data");

                entity.HasIndex(e => e.FlSituacao)
                    .HasName("ind_pedido_situacao");

                entity.Property(e => e.NrPedido)
                    .HasColumnName("nr_pedido")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdCondpgto).HasColumnName("cd_condpgto");

                entity.Property(e => e.CdFornecedor).HasColumnName("cd_fornecedor");

                entity.Property(e => e.CdFuncionario).HasColumnName("cd_funcionario");

                entity.Property(e => e.DtAtz)
                    .HasColumnName("dt_atz")
                    .HasColumnType("date")
                    .HasDefaultValueSql("CURRENT_DATE");

                entity.Property(e => e.DtEmissao)
                    .HasColumnName("dt_emissao")
                    .HasColumnType("date");

                entity.Property(e => e.DtValidade)
                    .HasColumnName("dt_validade")
                    .HasColumnType("date");

                entity.Property(e => e.FlSituacao).HasColumnName("fl_situacao");

                entity.Property(e => e.MotivoCancelamento).HasColumnName("motivo_cancelamento");

                entity.Property(e => e.Obs).HasColumnName("obs");

                entity.Property(e => e.VlTotal)
                    .HasColumnName("vl_total")
                    .HasColumnType("numeric(18,4)");
            });

            modelBuilder.Entity<PedidoFrete>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<PedidoFrete1>(entity =>
            {
                entity.HasKey(e => new { e.CdFilial, e.NrPedido });

                entity.ToTable("pedido_frete");

                entity.Property(e => e.CdFilial).HasColumnName("cd_filial");

                entity.Property(e => e.NrPedido).HasColumnName("nr_pedido");

                entity.Property(e => e.CdTransportadora).HasColumnName("cd_transportadora");

                entity.Property(e => e.EspecieVolumes)
                    .HasColumnName("especie_volumes")
                    .HasMaxLength(15);

                entity.Property(e => e.MarcaVolumes)
                    .HasColumnName("marca_volumes")
                    .HasMaxLength(15);

                entity.Property(e => e.NrVolumes).HasColumnName("nr_volumes");

                entity.Property(e => e.PesoLiquido).HasColumnName("peso_liquido");

                entity.Property(e => e.PesoTotal).HasColumnName("peso_total");

                entity.Property(e => e.PlacaTransp)
                    .HasColumnName("placa_transp")
                    .HasMaxLength(8);

                entity.Property(e => e.QtVolumes).HasColumnName("qt_volumes");

                entity.Property(e => e.TpFrete)
                    .IsRequired()
                    .HasColumnName("tp_frete")
                    .HasMaxLength(1);

                entity.Property(e => e.UfPlacaTransp)
                    .HasColumnName("uf_placa_transp")
                    .HasMaxLength(2);
            });

            modelBuilder.Entity<PedidoI>(entity =>
            {
                entity.HasKey(e => new { e.NrPedido, e.NrSequencia });

                entity.ToTable("pedido_i");

                entity.HasIndex(e => e.CdProduto)
                    .HasName("ind_pedido_i_produto");

                entity.HasIndex(e => new { e.NrPedido, e.CdProduto })
                    .HasName("unq_pedido_produto")
                    .IsUnique();

                entity.Property(e => e.NrPedido).HasColumnName("nr_pedido");

                entity.Property(e => e.NrSequencia).HasColumnName("nr_sequencia");

                entity.Property(e => e.CdProduto)
                    .IsRequired()
                    .HasColumnName("cd_produto")
                    .HasMaxLength(15);

                entity.Property(e => e.CdProdutoFornecedor)
                    .HasColumnName("cd_produto_fornecedor")
                    .HasMaxLength(25);

                entity.Property(e => e.DtAtz)
                    .HasColumnName("dt_atz")
                    .HasColumnType("date")
                    .HasDefaultValueSql("CURRENT_DATE");

                entity.Property(e => e.FatorConversao).HasColumnName("fator_conversao");

                entity.Property(e => e.NmProduto)
                    .HasColumnName("nm_produto")
                    .HasMaxLength(80);

                entity.Property(e => e.QtCompra).HasColumnName("qt_compra");

                entity.Property(e => e.QtProduto).HasColumnName("qt_produto");

                entity.Property(e => e.UnCompra)
                    .HasColumnName("un_compra")
                    .HasMaxLength(6);

                entity.Property(e => e.UnMedida)
                    .HasColumnName("un_medida")
                    .HasMaxLength(6);

                entity.Property(e => e.VlUnitario)
                    .HasColumnName("vl_unitario")
                    .HasColumnType("numeric(18,4)");

                entity.HasOne(d => d.NrPedidoNavigation)
                    .WithMany(p => p.PedidoI)
                    .HasForeignKey(d => d.NrPedido)
                    .HasConstraintName("fk_pedido");

                entity.HasOne(d => d.UnMedidaNavigation)
                    .WithMany(p => p.PedidoI)
                    .HasForeignKey(d => d.UnMedida)
                    .HasConstraintName("fk_pedido_i_un_medida");
            });

            modelBuilder.Entity<PerfilAcesso>(entity =>
            {
                entity.HasKey(e => e.CdPerfil);

                entity.ToTable("perfil_acesso");

                entity.Property(e => e.CdPerfil)
                    .HasColumnName("cd_perfil")
                    .ValueGeneratedNever();

                entity.Property(e => e.FlAcessoIrrestrito)
                    .HasColumnName("fl_acesso_irrestrito")
                    .HasMaxLength(1);

                entity.Property(e => e.FlAtivo)
                    .IsRequired()
                    .HasColumnName("fl_ativo")
                    .HasMaxLength(1);

                entity.Property(e => e.NmPerfil)
                    .IsRequired()
                    .HasColumnName("nm_perfil")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<PlHistorico>(entity =>
            {
                entity.HasKey(e => new { e.CdFilial, e.CdHistorico });

                entity.ToTable("pl_historico");

                entity.Property(e => e.CdFilial).HasColumnName("cd_filial");

                entity.Property(e => e.CdHistorico).HasColumnName("cd_historico");

                entity.Property(e => e.Complemento).HasColumnName("complemento");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasColumnName("descricao")
                    .HasMaxLength(40);

                entity.Property(e => e.DtAtz)
                    .HasColumnName("dt_atz")
                    .HasColumnType("date")
                    .HasDefaultValueSql("CURRENT_DATE");
            });

            modelBuilder.Entity<ProdComposto>(entity =>
            {
                entity.HasKey(e => new { e.CdProduto, e.CdComposto });

                entity.ToTable("prod_composto");

                entity.Property(e => e.CdProduto)
                    .HasColumnName("cd_produto")
                    .HasMaxLength(15);

                entity.Property(e => e.CdComposto)
                    .HasColumnName("cd_composto")
                    .HasMaxLength(15);

                entity.Property(e => e.DtAtz)
                    .HasColumnName("dt_atz")
                    .HasColumnType("date")
                    .HasDefaultValueSql("CURRENT_DATE");

                entity.Property(e => e.NmProdcomposto)
                    .IsRequired()
                    .HasColumnName("nm_prodcomposto")
                    .HasMaxLength(62);

                entity.Property(e => e.QtComposto).HasColumnName("qt_composto");

                entity.Property(e => e.QtLiquido).HasColumnName("qt_liquido");

                entity.HasOne(d => d.CdProdutoNavigation)
                    .WithMany(p => p.ProdComposto)
                    .HasForeignKey(d => d.CdProduto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_updtpproduto");
            });

            modelBuilder.Entity<ProdOriginal>(entity =>
            {
                entity.HasKey(e => new { e.CdProdutoAlt, e.CdProdutoOri });

                entity.ToTable("prod_original");

                entity.Property(e => e.CdProdutoAlt)
                    .HasColumnName("cd_produto_alt")
                    .HasMaxLength(20);

                entity.Property(e => e.CdProdutoOri)
                    .HasColumnName("cd_produto_ori")
                    .HasMaxLength(20);

                entity.Property(e => e.DtAtz)
                    .HasColumnName("dt_atz")
                    .HasColumnType("date")
                    .HasDefaultValueSql("CURRENT_DATE");
            });

            modelBuilder.Entity<ProdRelacionado>(entity =>
            {
                entity.HasKey(e => new { e.CdProduto, e.CdRelacionado });

                entity.ToTable("prod_relacionado");

                entity.Property(e => e.CdProduto)
                    .HasColumnName("cd_produto")
                    .HasMaxLength(15);

                entity.Property(e => e.CdRelacionado)
                    .HasColumnName("cd_relacionado")
                    .HasMaxLength(15);

                entity.Property(e => e.DtAtz)
                    .HasColumnName("dt_atz")
                    .HasColumnType("date")
                    .HasDefaultValueSql("CURRENT_DATE");

                entity.Property(e => e.QtRelacionado).HasColumnName("qt_relacionado");
            });

            modelBuilder.Entity<Produto>(entity =>
            {
                entity.HasKey(e => e.CdProduto);

                entity.ToTable("produto");

                entity.HasIndex(e => e.CdProduto)
                    .HasName("ind_cd_produto");

                entity.HasIndex(e => e.FlComposto)
                    .HasName("ind_produto_composto");

                entity.HasIndex(e => e.LocalEstocagem)
                    .HasName("ind_produto_local");

                entity.HasIndex(e => e.NmProduto)
                    .HasName("ind_nm_produto");

                entity.Property(e => e.CdProduto)
                    .HasColumnName("cd_produto")
                    .HasMaxLength(15)
                    .ValueGeneratedNever();

                entity.Property(e => e.AliqCsll)
                    .HasColumnName("aliq_csll")
                    .HasColumnType("numeric(9,2)");

                entity.Property(e => e.AliqInss)
                    .HasColumnName("aliq_inss")
                    .HasColumnType("numeric(9,2)");

                entity.Property(e => e.AliqIpi)
                    .HasColumnName("aliq_ipi")
                    .HasColumnType("numeric(9,2)");

                entity.Property(e => e.AliqIrrf)
                    .HasColumnName("aliq_irrf")
                    .HasColumnType("numeric(9,2)");

                entity.Property(e => e.AliqIss)
                    .HasColumnName("aliq_iss")
                    .HasColumnType("numeric(9,2)");

                entity.Property(e => e.Box)
                    .HasColumnName("box")
                    .HasMaxLength(10);

                entity.Property(e => e.CdAplicacao).HasColumnName("cd_aplicacao");

                entity.Property(e => e.CdCfopRegra).HasColumnName("cd_cfop_regra");

                entity.Property(e => e.CdClassFiscal)
                    .HasColumnName("cd_class_fiscal")
                    .HasMaxLength(5);

                entity.Property(e => e.CdConstrucao).HasColumnName("cd_construcao");

                entity.Property(e => e.CdContaContabil).HasColumnName("cd_conta_contabil");

                entity.Property(e => e.CdFabricante)
                    .HasColumnName("cd_fabricante")
                    .HasMaxLength(200);

                entity.Property(e => e.CdFci)
                    .HasColumnName("cd_fci")
                    .HasMaxLength(36);

                entity.Property(e => e.CdGrupoComissao).HasColumnName("cd_grupo_comissao");

                entity.Property(e => e.CdGruprod).HasColumnName("cd_gruprod");

                entity.Property(e => e.CdMarca).HasColumnName("cd_marca");

                entity.Property(e => e.CdMedida).HasColumnName("cd_medida");

                entity.Property(e => e.CdModelo).HasColumnName("cd_modelo");

                entity.Property(e => e.CdOriginal)
                    .HasColumnName("cd_original")
                    .HasMaxLength(200);

                entity.Property(e => e.CdProdutoAnp)
                    .HasColumnName("cd_produto_anp")
                    .HasMaxLength(9);

                entity.Property(e => e.CdProdutoAnvisa)
                    .HasColumnName("cd_produto_anvisa")
                    .HasMaxLength(5);

                entity.Property(e => e.CdSubgruprod).HasColumnName("cd_subgruprod");

                entity.Property(e => e.CdTributacaoIss)
                    .HasColumnName("cd_tributacao_iss")
                    .HasMaxLength(1);

                entity.Property(e => e.ClassListaServico)
                    .HasColumnName("class_lista_servico")
                    .HasMaxLength(10);

                entity.Property(e => e.ClassToxicoFito).HasColumnName("class_toxico_fito");

                entity.Property(e => e.CnpjFabricante)
                    .HasColumnName("cnpj_fabricante")
                    .HasMaxLength(20);

                entity.Property(e => e.CodAjur)
                    .HasColumnName("cod_ajur")
                    .HasMaxLength(10);

                entity.Property(e => e.CodigoTributacaoMunicipio).HasColumnName("codigo_tributacao_municipio");

                entity.Property(e => e.CstExt)
                    .HasColumnName("cst_ext")
                    .HasMaxLength(3);

                entity.Property(e => e.CstInt)
                    .HasColumnName("cst_int")
                    .HasMaxLength(3);

                entity.Property(e => e.DescAjur)
                    .HasColumnName("desc_ajur")
                    .HasMaxLength(500);

                entity.Property(e => e.DiasManPrev).HasColumnName("dias_man_prev");

                entity.Property(e => e.DtAtz)
                    .HasColumnName("dt_atz")
                    .HasColumnType("date");

                entity.Property(e => e.DtCadastro)
                    .HasColumnName("dt_cadastro")
                    .HasColumnType("date");

                entity.Property(e => e.EpiFito).HasColumnName("epi_fito");

                entity.Property(e => e.EpocaFito)
                    .HasColumnName("epoca_fito")
                    .HasMaxLength(20);

                entity.Property(e => e.EspecificacoesFito).HasColumnName("especificacoes_fito");

                entity.Property(e => e.FlAtivo).HasColumnName("fl_ativo");

                entity.Property(e => e.FlCestaBasica)
                    .HasColumnName("fl_cesta_basica")
                    .HasMaxLength(1);

                entity.Property(e => e.FlClassfiscal)
                    .HasColumnName("fl_classfiscal")
                    .HasMaxLength(5);

                entity.Property(e => e.FlComposto)
                    .HasColumnName("fl_composto")
                    .HasMaxLength(1);

                entity.Property(e => e.FlCompostoSomaItens)
                    .HasColumnName("fl_composto_soma_itens")
                    .HasMaxLength(1);

                entity.Property(e => e.FlConsumo).HasColumnName("fl_consumo");

                entity.Property(e => e.FlContrato).HasColumnName("fl_contrato");

                entity.Property(e => e.FlControlaLote).HasColumnName("fl_controla_lote");

                entity.Property(e => e.FlControlaSerie).HasColumnName("fl_controla_serie");

                entity.Property(e => e.FlControlarEstoq).HasColumnName("fl_controlar_estoq");

                entity.Property(e => e.FlEscalaRelevante)
                    .HasColumnName("fl_escala_relevante")
                    .HasDefaultValueSql("'S'::bpchar");

                entity.Property(e => e.FlFitossanitarioSira)
                    .HasColumnName("fl_fitossanitario_sira")
                    .HasMaxLength(1);

                entity.Property(e => e.FlFracionar).HasColumnName("fl_fracionar");

                entity.Property(e => e.FlInfComplemento).HasColumnName("fl_inf_complemento");

                entity.Property(e => e.FlOriginal).HasColumnName("fl_original");

                entity.Property(e => e.FlPesavel).HasColumnName("fl_pesavel");

                entity.Property(e => e.FlRetem).HasColumnName("fl_retem");

                entity.Property(e => e.FlServico)
                    .HasColumnName("fl_servico")
                    .HasMaxLength(1);

                entity.Property(e => e.FlValidade).HasColumnName("fl_validade");

                entity.Property(e => e.GarantiaKm).HasColumnName("garantia_km");

                entity.Property(e => e.GiroMedioEmDias).HasColumnName("giro_medio_em_dias");

                entity.Property(e => e.HashProdutoE2)
                    .HasColumnName("hash_produto_e2")
                    .HasMaxLength(70);

                entity.Property(e => e.HashProdutoP2)
                    .HasColumnName("hash_produto_p2")
                    .HasMaxLength(70);

                entity.Property(e => e.IdTribGrupoPiscofins).HasColumnName("id_trib_grupo_piscofins");

                entity.Property(e => e.IdTributacaoGrupo).HasColumnName("id_tributacao_grupo");

                entity.Property(e => e.IntervaloFito).HasColumnName("intervalo_fito");

                entity.Property(e => e.LocalEstocagem)
                    .HasColumnName("local_estocagem")
                    .HasMaxLength(10);

                entity.Property(e => e.MesesGarantia).HasColumnName("meses_garantia");

                entity.Property(e => e.MesesVidaUtil).HasColumnName("meses_vida_util");

                entity.Property(e => e.MetodoFito).HasColumnName("metodo_fito");

                entity.Property(e => e.NmComercialFito)
                    .HasColumnName("nm_comercial_fito")
                    .HasMaxLength(60);

                entity.Property(e => e.NmProduto)
                    .IsRequired()
                    .HasColumnName("nm_produto")
                    .HasMaxLength(120);

                entity.Property(e => e.NmReduzido)
                    .HasColumnName("nm_reduzido")
                    .HasMaxLength(60);

                entity.Property(e => e.NomeFabricante)
                    .HasColumnName("nome_fabricante")
                    .HasMaxLength(70);

                entity.Property(e => e.Obs).HasColumnName("obs");

                entity.Property(e => e.PcComissao)
                    .HasColumnName("pc_comissao")
                    .HasColumnType("numeric(5,2)");

                entity.Property(e => e.PcLucroLiquido)
                    .HasColumnName("pc_lucro_liquido")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.PcPrecoVenda)
                    .HasColumnName("pc_preco_venda")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.PcSubstTrib)
                    .HasColumnName("pc_subst_trib")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.PesoLiquido).HasColumnName("peso_liquido");

                entity.Property(e => e.PrecaucoesFito).HasColumnName("precaucoes_fito");

                entity.Property(e => e.QtCompraMediaMes).HasColumnName("qt_compra_media_mes");

                entity.Property(e => e.QtDiasValidade).HasColumnName("qt_dias_validade");

                entity.Property(e => e.QtEstoque).HasColumnName("qt_estoque");

                entity.Property(e => e.QtEstoqueAnterior).HasColumnName("qt_estoque_anterior");

                entity.Property(e => e.QtEstoqueMax).HasColumnName("qt_estoque_max");

                entity.Property(e => e.QtEstoqueMedioMes).HasColumnName("qt_estoque_medio_mes");

                entity.Property(e => e.QtEstoqueMin).HasColumnName("qt_estoque_min");

                entity.Property(e => e.QtVendaMediaMes).HasColumnName("qt_venda_media_mes");

                entity.Property(e => e.Tipo)
                    .HasColumnName("tipo")
                    .HasMaxLength(10);

                entity.Property(e => e.TpIntervaloFito).HasColumnName("tp_intervalo_fito");

                entity.Property(e => e.TpModalidadeFito).HasColumnName("tp_modalidade_fito");

                entity.Property(e => e.TpProduto)
                    .HasColumnName("tp_produto")
                    .HasMaxLength(2);

                entity.Property(e => e.UnArmazenagem)
                    .IsRequired()
                    .HasColumnName("un_armazenagem")
                    .HasMaxLength(6);

                entity.Property(e => e.UnCompra)
                    .IsRequired()
                    .HasColumnName("un_compra")
                    .HasMaxLength(6);

                entity.Property(e => e.UnMedida)
                    .IsRequired()
                    .HasColumnName("un_medida")
                    .HasMaxLength(6);

                entity.HasOne(d => d.CdCfopRegraNavigation)
                    .WithMany(p => p.Produto)
                    .HasForeignKey(d => d.CdCfopRegra)
                    .HasConstraintName("fk_produto_cfop_regra");

                entity.HasOne(d => d.CdClassFiscalNavigation)
                    .WithMany(p => p.Produto)
                    .HasForeignKey(d => d.CdClassFiscal)
                    .HasConstraintName("fk_produto_class_fiscal");

                entity.HasOne(d => d.CdGrupoComissaoNavigation)
                    .WithMany(p => p.Produto)
                    .HasForeignKey(d => d.CdGrupoComissao)
                    .HasConstraintName("grupo_comissao_produto_fk");

                entity.HasOne(d => d.CdGruprodNavigation)
                    .WithMany(p => p.Produto)
                    .HasForeignKey(d => d.CdGruprod)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("produto_cd_gruprod_fkey");

                entity.HasOne(d => d.CdMarcaNavigation)
                    .WithMany(p => p.Produto)
                    .HasForeignKey(d => d.CdMarca)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("produto_cd_marca_fkey");

                entity.HasOne(d => d.CdSubgruprodNavigation)
                    .WithMany(p => p.Produto)
                    .HasForeignKey(d => d.CdSubgruprod)
                    .HasConstraintName("fk_subproduto");

                entity.HasOne(d => d.CodigoTributacaoMunicipioNavigation)
                    .WithMany(p => p.Produto)
                    .HasForeignKey(d => d.CodigoTributacaoMunicipio)
                    .HasConstraintName("fk_produto_tribmuni");

                entity.HasOne(d => d.IdTribGrupoPiscofinsNavigation)
                    .WithMany(p => p.Produto)
                    .HasForeignKey(d => d.IdTribGrupoPiscofins)
                    .HasConstraintName("fk_produto_grupo_trib_piscofins");

                entity.HasOne(d => d.IdTributacaoGrupoNavigation)
                    .WithMany(p => p.Produto)
                    .HasForeignKey(d => d.IdTributacaoGrupo)
                    .HasConstraintName("fk_produto_tributacao_grupo");

                entity.HasOne(d => d.TpProdutoNavigation)
                    .WithMany(p => p.Produto)
                    .HasForeignKey(d => d.TpProduto)
                    .HasConstraintName("fk_produto_tp_produto");

                entity.HasOne(d => d.UnArmazenagemNavigation)
                    .WithMany(p => p.ProdutoUnArmazenagemNavigation)
                    .HasForeignKey(d => d.UnArmazenagem)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_produto_un_armazenagem");

                entity.HasOne(d => d.UnCompraNavigation)
                    .WithMany(p => p.ProdutoUnCompraNavigation)
                    .HasForeignKey(d => d.UnCompra)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_produto_un_compra");

                entity.HasOne(d => d.UnMedidaNavigation)
                    .WithMany(p => p.ProdutoUnMedidaNavigation)
                    .HasForeignKey(d => d.UnMedida)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_produto_un_medida");
            });

            modelBuilder.Entity<ProdutoAltprec>(entity =>
            {
                entity.HasKey(e => e.IdGeral);

                entity.ToTable("produto_altprec");

                entity.Property(e => e.IdGeral)
                    .HasColumnName("id_geral")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdFuncionario).HasColumnName("cd_funcionario");

                entity.Property(e => e.CdProduto)
                    .IsRequired()
                    .HasColumnName("cd_produto")
                    .HasMaxLength(15);

                entity.Property(e => e.CdTabelaPreco).HasColumnName("cd_tabela_preco");

                entity.Property(e => e.DescForm)
                    .IsRequired()
                    .HasColumnName("desc_form")
                    .HasMaxLength(60);

                entity.Property(e => e.DtAlteracao)
                    .HasColumnName("dt_alteracao")
                    .HasColumnType("date");

                entity.Property(e => e.HrAlteracao)
                    .HasColumnName("hr_alteracao")
                    .HasColumnType("time without time zone");

                entity.Property(e => e.IdNfec).HasColumnName("id_nfec");

                entity.Property(e => e.NmForm)
                    .IsRequired()
                    .HasColumnName("nm_form")
                    .HasMaxLength(40);

                entity.Property(e => e.PrecoVendaAnt)
                    .HasColumnName("preco_venda_ant")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.PrecoVendaFlexMaxAnt)
                    .HasColumnName("preco_venda_flex_max_ant")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.PrecoVendaFlexMaxNovo)
                    .HasColumnName("preco_venda_flex_max_novo")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.PrecoVendaFlexMinAnt)
                    .HasColumnName("preco_venda_flex_min_ant")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.PrecoVendaFlexMinNovo)
                    .HasColumnName("preco_venda_flex_min_novo")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.PrecoVendaMinAnt)
                    .HasColumnName("preco_venda_min_ant")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.PrecoVendaMinNovo)
                    .HasColumnName("preco_venda_min_novo")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.PrecoVendaNovo)
                    .HasColumnName("preco_venda_novo")
                    .HasColumnType("numeric(18,4)");
            });

            modelBuilder.Entity<ProdutoClassFiscal>(entity =>
            {
                entity.HasKey(e => e.CdClassFiscal);

                entity.ToTable("produto_class_fiscal");

                entity.Property(e => e.CdClassFiscal)
                    .HasColumnName("cd_class_fiscal")
                    .HasMaxLength(5)
                    .ValueGeneratedNever();

                entity.Property(e => e.AliqIpi).HasColumnName("aliq_ipi");

                entity.Property(e => e.CdCest).HasColumnName("cd_cest");

                entity.Property(e => e.CdEnquadramentoCompra)
                    .HasColumnName("cd_enquadramento_compra")
                    .HasMaxLength(3);

                entity.Property(e => e.CdEnquadramentoVenda)
                    .HasColumnName("cd_enquadramento_venda")
                    .HasMaxLength(3);

                entity.Property(e => e.CstCofinsCompra)
                    .HasColumnName("cst_cofins_compra")
                    .HasMaxLength(2);

                entity.Property(e => e.CstCofinsVenda)
                    .HasColumnName("cst_cofins_venda")
                    .HasMaxLength(2);

                entity.Property(e => e.CstIpiCompra)
                    .HasColumnName("cst_ipi_compra")
                    .HasMaxLength(2);

                entity.Property(e => e.CstIpiVenda)
                    .HasColumnName("cst_ipi_venda")
                    .HasMaxLength(2);

                entity.Property(e => e.CstPisCompra)
                    .HasColumnName("cst_pis_compra")
                    .HasMaxLength(2);

                entity.Property(e => e.CstPisVenda)
                    .HasColumnName("cst_pis_venda")
                    .HasMaxLength(2);

                entity.Property(e => e.Descricao)
                    .HasColumnName("descricao")
                    .HasColumnType("character(200)");

                entity.Property(e => e.DtAtz)
                    .HasColumnName("dt_atz")
                    .HasColumnType("date");

                entity.Property(e => e.FlCalcularPisCofins)
                    .HasColumnName("fl_calcular_pis_cofins")
                    .HasMaxLength(1);

                entity.Property(e => e.FlReducaoMvaSimples)
                    .HasColumnName("fl_reducao_mva_simples")
                    .HasMaxLength(1);

                entity.Property(e => e.NmClassFiscal)
                    .IsRequired()
                    .HasColumnName("nm_class_fiscal")
                    .HasMaxLength(10);

                entity.Property(e => e.UnTrib)
                    .HasColumnName("un_trib")
                    .HasMaxLength(6);
            });

            modelBuilder.Entity<ProdutoClassFiscalIbpt>(entity =>
            {
                entity.HasKey(e => e.IdGeral);

                entity.ToTable("produto_class_fiscal_ibpt");

                entity.Property(e => e.IdGeral)
                    .HasColumnName("id_geral")
                    .ValueGeneratedNever();

                entity.Property(e => e.AliqEst)
                    .HasColumnName("aliq_est")
                    .HasColumnType("numeric(5,2)");

                entity.Property(e => e.AliqImpFed)
                    .HasColumnName("aliq_imp_fed")
                    .HasColumnType("numeric(5,2)");

                entity.Property(e => e.AliqMun)
                    .HasColumnName("aliq_mun")
                    .HasColumnType("numeric(5,2)");

                entity.Property(e => e.AliqNacFed)
                    .HasColumnName("aliq_nac_fed")
                    .HasColumnType("numeric(5,2)");

                entity.Property(e => e.Codigo)
                    .HasColumnName("codigo")
                    .HasMaxLength(10);

                entity.Property(e => e.DtFinal).HasColumnName("dt_final");

                entity.Property(e => e.DtInicio).HasColumnName("dt_inicio");

                entity.Property(e => e.Fonte)
                    .HasColumnName("fonte")
                    .HasMaxLength(30);

                entity.Property(e => e.Tabela).HasColumnName("tabela");

                entity.Property(e => e.Uf)
                    .HasColumnName("uf")
                    .HasMaxLength(3);

                entity.Property(e => e.VersaoIbpt)
                    .HasColumnName("versao_ibpt")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<ProdutoClassFiscalMva>(entity =>
            {
                entity.HasKey(e => e.IdGeral);

                entity.ToTable("produto_class_fiscal_mva");

                entity.HasIndex(e => new { e.CdClassFiscal, e.UfOrigem, e.UfDestino })
                    .HasName("unq1_produto_class_fiscal_mva")
                    .IsUnique();

                entity.Property(e => e.IdGeral)
                    .HasColumnName("id_geral")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdClassFiscal)
                    .IsRequired()
                    .HasColumnName("cd_class_fiscal")
                    .HasMaxLength(5);

                entity.Property(e => e.DtAtz)
                    .HasColumnName("dt_atz")
                    .HasColumnType("date");

                entity.Property(e => e.Mva).HasColumnName("mva");

                entity.Property(e => e.UfDestino)
                    .IsRequired()
                    .HasColumnName("uf_destino")
                    .HasMaxLength(2);

                entity.Property(e => e.UfOrigem)
                    .IsRequired()
                    .HasColumnName("uf_origem")
                    .HasMaxLength(2);

                entity.HasOne(d => d.CdClassFiscalNavigation)
                    .WithMany(p => p.ProdutoClassFiscalMva)
                    .HasForeignKey(d => d.CdClassFiscal)
                    .HasConstraintName("fk_produto_class_fiscal_mva_ncm");
            });

            modelBuilder.Entity<ProdutoCliente>(entity =>
            {
                entity.HasKey(e => new { e.CdFilial, e.CdCliente, e.NrSequencia });

                entity.ToTable("produto_cliente");

                entity.HasIndex(e => new { e.CdProduto, e.NrSerie })
                    .HasName("unq_produto_cliente")
                    .IsUnique();

                entity.Property(e => e.CdFilial).HasColumnName("cd_filial");

                entity.Property(e => e.CdCliente).HasColumnName("cd_cliente");

                entity.Property(e => e.NrSequencia).HasColumnName("nr_sequencia");

                entity.Property(e => e.AnoFabricacao).HasColumnName("ano_fabricacao");

                entity.Property(e => e.AnoModelo).HasColumnName("ano_modelo");

                entity.Property(e => e.CdCombustivel)
                    .HasColumnName("cd_combustivel")
                    .HasMaxLength(2);

                entity.Property(e => e.CdProduto)
                    .IsRequired()
                    .HasColumnName("cd_produto")
                    .HasMaxLength(15);

                entity.Property(e => e.Cor)
                    .HasColumnName("cor")
                    .HasMaxLength(250);

                entity.Property(e => e.DataAquisicao)
                    .HasColumnName("data_aquisicao")
                    .HasColumnType("date");

                entity.Property(e => e.EntregaTecnica)
                    .HasColumnName("entrega_tecnica")
                    .HasColumnType("date");

                entity.Property(e => e.NrSerie)
                    .IsRequired()
                    .HasColumnName("nr_serie")
                    .HasMaxLength(32);

                entity.Property(e => e.NumChassi)
                    .HasColumnName("num_chassi")
                    .HasMaxLength(250);

                entity.Property(e => e.NumDiferencial).HasColumnName("num_diferencial");

                entity.Property(e => e.NumMotor)
                    .HasColumnName("num_motor")
                    .HasMaxLength(250);

                entity.Property(e => e.NumTransmissao)
                    .HasColumnName("num_transmissao")
                    .HasMaxLength(100);

                entity.Property(e => e.Obs).HasColumnName("obs");

                entity.Property(e => e.SerieTransmissao)
                    .HasColumnName("serie_transmissao")
                    .HasMaxLength(100);

                entity.Property(e => e.Torre)
                    .HasColumnName("torre")
                    .HasMaxLength(100);

                entity.HasOne(d => d.CdCombustivelNavigation)
                    .WithMany(p => p.ProdutoCliente)
                    .HasForeignKey(d => d.CdCombustivel)
                    .HasConstraintName("fk_produto_cliente_combustivel");

                entity.HasOne(d => d.CdProdutoNavigation)
                    .WithMany(p => p.ProdutoCliente)
                    .HasForeignKey(d => d.CdProduto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_produto_cliente_produto");

                entity.HasOne(d => d.Cd)
                    .WithMany(p => p.ProdutoCliente)
                    .HasForeignKey(d => new { d.CdFilial, d.CdCliente })
                    .HasConstraintName("fk_produto_cliente_cliente");
            });

            modelBuilder.Entity<ProdutoFornecedor>(entity =>
            {
                entity.HasKey(e => e.IdProdutoFornecedor);

                entity.ToTable("produto_fornecedor");

                entity.Property(e => e.IdProdutoFornecedor)
                    .HasColumnName("id_produto_fornecedor")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdFilial).HasColumnName("cd_filial");

                entity.Property(e => e.CdFornecedor).HasColumnName("cd_fornecedor");

                entity.Property(e => e.CdProdForn)
                    .IsRequired()
                    .HasColumnName("cd_prod_forn")
                    .HasMaxLength(61);

                entity.Property(e => e.CdProduto)
                    .IsRequired()
                    .HasColumnName("cd_produto")
                    .HasMaxLength(15);

                entity.Property(e => e.DtAtz)
                    .HasColumnName("dt_atz")
                    .HasColumnType("date");

                entity.Property(e => e.IdUnimportacao).HasColumnName("id_unimportacao");

                entity.HasOne(d => d.IdUnimportacaoNavigation)
                    .WithMany(p => p.ProdutoFornecedor)
                    .HasForeignKey(d => d.IdUnimportacao)
                    .HasConstraintName("fk_proforn_fornun");
            });

            modelBuilder.Entity<ProdutoLote>(entity =>
            {
                entity.HasKey(e => e.IdGeral);

                entity.ToTable("produto_lote");

                entity.HasIndex(e => new { e.IdNfec, e.CdProduto, e.NrLote, e.NrSequencial, e.IdNfsc })
                    .HasName("unq1_produto_lote")
                    .IsUnique();

                entity.Property(e => e.IdGeral)
                    .HasColumnName("id_geral")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdProduto)
                    .IsRequired()
                    .HasColumnName("cd_produto")
                    .HasMaxLength(14);

                entity.Property(e => e.DtFabricacao)
                    .HasColumnName("dt_fabricacao")
                    .HasColumnType("date");

                entity.Property(e => e.DtLancamentoLote)
                    .HasColumnName("dt_lancamento_lote")
                    .HasColumnType("date");

                entity.Property(e => e.DtValidade)
                    .HasColumnName("dt_validade")
                    .HasColumnType("date");

                entity.Property(e => e.IdNfec).HasColumnName("id_nfec");

                entity.Property(e => e.IdNfsc).HasColumnName("id_nfsc");

                entity.Property(e => e.NrLote)
                    .IsRequired()
                    .HasColumnName("nr_lote")
                    .HasMaxLength(10);

                entity.Property(e => e.NrSequencial).HasColumnName("nr_sequencial");

                entity.Property(e => e.QtEntrada).HasColumnName("qt_entrada");

                entity.Property(e => e.QtSaida).HasColumnName("qt_saida");

                entity.HasOne(d => d.CdProdutoNavigation)
                    .WithMany(p => p.ProdutoLote)
                    .HasForeignKey(d => d.CdProduto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_produto_lote_produto");

                entity.HasOne(d => d.IdNfecNavigation)
                    .WithMany(p => p.ProdutoLote)
                    .HasForeignKey(d => d.IdNfec)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_produto_lote_nfec");
            });

            modelBuilder.Entity<ProdutoSerie>(entity =>
            {
                entity.HasKey(e => e.IdGeral);

                entity.ToTable("produto_serie");

                entity.HasIndex(e => new { e.CdFilial, e.CdProduto, e.NrSerie, e.IdNfei })
                    .HasName("unq_produto_serie")
                    .IsUnique();

                entity.Property(e => e.IdGeral)
                    .HasColumnName("id_geral")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdFilial).HasColumnName("cd_filial");

                entity.Property(e => e.CdProduto)
                    .IsRequired()
                    .HasColumnName("cd_produto")
                    .HasMaxLength(15);

                entity.Property(e => e.IdNfei).HasColumnName("id_nfei");

                entity.Property(e => e.NrNfs).HasColumnName("nr_nfs");

                entity.Property(e => e.NrOs).HasColumnName("nr_os");

                entity.Property(e => e.NrSequenciaNfs).HasColumnName("nr_sequencia_nfs");

                entity.Property(e => e.NrSequenciaOs).HasColumnName("nr_sequencia_os");

                entity.Property(e => e.NrSerie)
                    .IsRequired()
                    .HasColumnName("nr_serie")
                    .HasMaxLength(32);

                entity.HasOne(d => d.CdProdutoNavigation)
                    .WithMany(p => p.ProdutoSerie)
                    .HasForeignKey(d => d.CdProduto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_produto_serie_produto");

                entity.HasOne(d => d.IdNfeiNavigation)
                    .WithMany(p => p.ProdutoSerie)
                    .HasForeignKey(d => d.IdNfei)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_produto_serie_nfei");
            });

            modelBuilder.Entity<ProdutoTipo>(entity =>
            {
                entity.HasKey(e => e.CdTipo);

                entity.ToTable("produto_tipo");

                entity.Property(e => e.CdTipo)
                    .HasColumnName("cd_tipo")
                    .HasMaxLength(2)
                    .ValueGeneratedNever();

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasColumnName("descricao")
                    .HasMaxLength(50);

                entity.Property(e => e.FlControlarEstoq).HasColumnName("fl_controlar_estoq");

                entity.Property(e => e.FlInventario).HasColumnName("fl_inventario");

                entity.Property(e => e.FlPermiteComposicao).HasColumnName("fl_permite_composicao");

                entity.Property(e => e.FlPermitevenda)
                    .HasColumnName("fl_permitevenda")
                    .HasMaxLength(1);
            });

            modelBuilder.Entity<ProdutoUnidade>(entity =>
            {
                entity.HasKey(e => new { e.CdProduto, e.UnMedida });

                entity.ToTable("produto_unidade");

                entity.HasIndex(e => e.CdBarras)
                    .HasName("idx_cd_barras");

                entity.Property(e => e.CdProduto)
                    .HasColumnName("cd_produto")
                    .HasMaxLength(15);

                entity.Property(e => e.UnMedida)
                    .HasColumnName("un_medida")
                    .HasMaxLength(6);

                entity.Property(e => e.CdBarras)
                    .HasColumnName("cd_barras")
                    .HasMaxLength(20);

                entity.Property(e => e.DtAtz)
                    .HasColumnName("dt_atz")
                    .HasColumnType("date");

                entity.Property(e => e.FatorConversao).HasColumnName("fator_conversao");

                entity.Property(e => e.FlTipo)
                    .HasColumnName("fl_tipo")
                    .HasMaxLength(1);
            });

            modelBuilder.Entity<ProdutoVeiculo>(entity =>
            {
                entity.HasKey(e => new { e.CdFilial, e.CdProduto });

                entity.ToTable("produto_veiculo");

                entity.HasIndex(e => e.Placa)
                    .HasName("unq_produto_veiculo_placa")
                    .IsUnique();

                entity.Property(e => e.CdFilial).HasColumnName("cd_filial");

                entity.Property(e => e.CdProduto)
                    .HasColumnName("cd_produto")
                    .HasMaxLength(15);

                entity.Property(e => e.AnoFab).HasColumnName("ano_fab");

                entity.Property(e => e.AnoMod).HasColumnName("ano_mod");

                entity.Property(e => e.Categoria)
                    .HasColumnName("categoria")
                    .HasMaxLength(20);

                entity.Property(e => e.CdCombustivel)
                    .HasColumnName("cd_combustivel")
                    .HasMaxLength(2);

                entity.Property(e => e.CdCor)
                    .HasColumnName("cd_cor")
                    .HasMaxLength(2);

                entity.Property(e => e.CdCorMontadora)
                    .HasColumnName("cd_cor_montadora")
                    .HasMaxLength(4);

                entity.Property(e => e.CdEspecie)
                    .HasColumnName("cd_especie")
                    .HasMaxLength(2);

                entity.Property(e => e.CdModeloRenavan)
                    .HasColumnName("cd_modelo_renavan")
                    .HasMaxLength(6);

                entity.Property(e => e.CdMontadora).HasColumnName("cd_montadora");

                entity.Property(e => e.CdRestricao).HasColumnName("cd_restricao");

                entity.Property(e => e.CdTipo)
                    .HasColumnName("cd_tipo")
                    .HasMaxLength(2);

                entity.Property(e => e.CdVeiculo).HasColumnName("cd_veiculo");

                entity.Property(e => e.CdVin)
                    .HasColumnName("cd_vin")
                    .HasMaxLength(1);

                entity.Property(e => e.Chassi)
                    .HasColumnName("chassi")
                    .HasMaxLength(17);

                entity.Property(e => e.Cilindradas).HasColumnName("cilindradas");

                entity.Property(e => e.Cmkg)
                    .HasColumnName("cmkg")
                    .HasMaxLength(9);

                entity.Property(e => e.CondVeiculo).HasColumnName("cond_veiculo");

                entity.Property(e => e.DistEntreEixos)
                    .HasColumnName("dist_entre_eixos")
                    .HasMaxLength(10);

                entity.Property(e => e.FlNovo)
                    .IsRequired()
                    .HasColumnName("fl_novo")
                    .HasMaxLength(1);

                entity.Property(e => e.Km).HasColumnName("km");

                entity.Property(e => e.Motor)
                    .HasColumnName("motor")
                    .HasMaxLength(17);

                entity.Property(e => e.NmCorMontadora)
                    .HasColumnName("nm_cor_montadora")
                    .HasMaxLength(40);

                entity.Property(e => e.NrDocumentoNfs).HasColumnName("nr_documento_nfs");

                entity.Property(e => e.NrSerie)
                    .HasColumnName("nr_serie")
                    .HasMaxLength(9);

                entity.Property(e => e.Obs).HasColumnName("obs");

                entity.Property(e => e.Passageiros).HasColumnName("passageiros");

                entity.Property(e => e.PesoBrt)
                    .HasColumnName("peso_brt")
                    .HasColumnType("numeric(15,4)");

                entity.Property(e => e.PesoLiq)
                    .HasColumnName("peso_liq")
                    .HasColumnType("numeric(15,4)");

                entity.Property(e => e.Placa)
                    .IsRequired()
                    .HasColumnName("placa")
                    .HasMaxLength(8);

                entity.Property(e => e.Potencia)
                    .HasColumnName("potencia")
                    .HasMaxLength(10);

                entity.Property(e => e.Renavan)
                    .HasColumnName("renavan")
                    .HasMaxLength(11);

                entity.Property(e => e.TpPintura)
                    .HasColumnName("tp_pintura")
                    .HasMaxLength(1);

                entity.HasOne(d => d.CdCombustivelNavigation)
                    .WithMany(p => p.ProdutoVeiculo)
                    .HasForeignKey(d => d.CdCombustivel)
                    .HasConstraintName("fk_produto_veiculo_combustivel");

                entity.HasOne(d => d.CdCorNavigation)
                    .WithMany(p => p.ProdutoVeiculo)
                    .HasForeignKey(d => d.CdCor)
                    .HasConstraintName("fk_produto_veiculo_cor");

                entity.HasOne(d => d.CdEspecieNavigation)
                    .WithMany(p => p.ProdutoVeiculo)
                    .HasForeignKey(d => d.CdEspecie)
                    .HasConstraintName("fk_produto_veiculo_especie");

                entity.HasOne(d => d.CdProdutoNavigation)
                    .WithMany(p => p.ProdutoVeiculo)
                    .HasForeignKey(d => d.CdProduto)
                    .HasConstraintName("fk_veiculo_despesas_produto");

                entity.HasOne(d => d.CdTipoNavigation)
                    .WithMany(p => p.ProdutoVeiculo)
                    .HasForeignKey(d => d.CdTipo)
                    .HasConstraintName("fk_produto_veiculo_tipo");

                entity.HasOne(d => d.Cd)
                    .WithMany(p => p.ProdutoVeiculo)
                    .HasForeignKey(d => new { d.CdFilial, d.CdMontadora })
                    .HasConstraintName("fk_veiculo_cd_montadora");

                entity.HasOne(d => d.CdNavigation)
                    .WithMany(p => p.ProdutoVeiculo)
                    .HasForeignKey(d => new { d.CdFilial, d.CdVeiculo })
                    .HasConstraintName("fk_veiculo_cd_veiculo");
            });

            modelBuilder.Entity<ProdutoVeiculosInjecao>(entity =>
            {
                entity.HasKey(e => e.IdGeral);

                entity.ToTable("produto_veiculos_injecao");

                entity.HasIndex(e => new { e.IdProdutoVeiculos, e.CdInjecao })
                    .HasName("unq_produto_veiculos_injecao")
                    .IsUnique();

                entity.Property(e => e.IdGeral)
                    .HasColumnName("id_geral")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdInjecao).HasColumnName("cd_injecao");

                entity.Property(e => e.DtAtz).HasColumnName("dt_atz");

                entity.Property(e => e.IdProdutoVeiculos).HasColumnName("id_produto_veiculos");

                entity.HasOne(d => d.CdInjecaoNavigation)
                    .WithMany(p => p.ProdutoVeiculosInjecao)
                    .HasForeignKey(d => d.CdInjecao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_prodinje_prodinje");

                entity.HasOne(d => d.IdProdutoVeiculosNavigation)
                    .WithMany(p => p.ProdutoVeiculosInjecao)
                    .HasForeignKey(d => d.IdProdutoVeiculos)
                    .HasConstraintName("fk_prodinje_prodveic");
            });

            modelBuilder.Entity<ProdutoVeiculosTransmissao>(entity =>
            {
                entity.HasKey(e => e.IdGeral);

                entity.ToTable("produto_veiculos_transmissao");

                entity.HasIndex(e => new { e.IdProdutoVeiculos, e.CdTransmissao })
                    .HasName("unq_produto_veiculos_transmiss")
                    .IsUnique();

                entity.Property(e => e.IdGeral)
                    .HasColumnName("id_geral")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdTransmissao).HasColumnName("cd_transmissao");

                entity.Property(e => e.DtAtz).HasColumnName("dt_atz");

                entity.Property(e => e.IdProdutoVeiculos).HasColumnName("id_produto_veiculos");

                entity.HasOne(d => d.CdTransmissaoNavigation)
                    .WithMany(p => p.ProdutoVeiculosTransmissao)
                    .HasForeignKey(d => d.CdTransmissao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_veictrans_prodtrans");

                entity.HasOne(d => d.IdProdutoVeiculosNavigation)
                    .WithMany(p => p.ProdutoVeiculosTransmissao)
                    .HasForeignKey(d => d.IdProdutoVeiculos)
                    .HasConstraintName("fk_veictrans_prodveic");
            });

            modelBuilder.Entity<Propriedade>(entity =>
            {
                entity.HasKey(e => e.CdPropriedade);

                entity.ToTable("propriedade");

                entity.Property(e => e.CdPropriedade)
                    .HasColumnName("cd_propriedade")
                    .ValueGeneratedNever();

                entity.Property(e => e.Area).HasColumnName("area");

                entity.Property(e => e.CaixaPostal)
                    .HasColumnName("caixa_postal")
                    .HasMaxLength(10);

                entity.Property(e => e.CdCidade).HasColumnName("cd_cidade");

                entity.Property(e => e.CdCliente).HasColumnName("cd_cliente");

                entity.Property(e => e.CdContato).HasColumnName("cd_contato");

                entity.Property(e => e.CdFilial).HasColumnName("cd_filial");

                entity.Property(e => e.Cep)
                    .HasColumnName("cep")
                    .HasMaxLength(10);

                entity.Property(e => e.Cnpj)
                    .HasColumnName("cnpj")
                    .HasMaxLength(18);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(70);

                entity.Property(e => e.Endereco)
                    .HasColumnName("endereco")
                    .HasMaxLength(60);

                entity.Property(e => e.Fax)
                    .HasColumnName("fax")
                    .HasMaxLength(20);

                entity.Property(e => e.Ie)
                    .HasColumnName("ie")
                    .HasMaxLength(18);

                entity.Property(e => e.Incra)
                    .HasColumnName("incra")
                    .HasMaxLength(10);

                entity.Property(e => e.NmPropriedade)
                    .HasColumnName("nm_propriedade")
                    .HasMaxLength(60);

                entity.Property(e => e.Telefone)
                    .HasColumnName("telefone")
                    .HasMaxLength(20);

                entity.HasOne(d => d.CdCidadeNavigation)
                    .WithMany(p => p.Propriedade)
                    .HasForeignKey(d => d.CdCidade)
                    .HasConstraintName("fk_propriedade_cidade");

                entity.HasOne(d => d.CdContatoNavigation)
                    .WithMany(p => p.Propriedade)
                    .HasForeignKey(d => d.CdContato)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_propriedade_contato");

                entity.HasOne(d => d.Cd)
                    .WithMany(p => p.Propriedade)
                    .HasForeignKey(d => new { d.CdFilial, d.CdCliente })
                    .HasConstraintName("fk_propriedade_cliente");
            });

            modelBuilder.Entity<ProtocoloIcms>(entity =>
            {
                entity.HasKey(e => e.IdGeral);

                entity.ToTable("protocolo_icms");

                entity.HasIndex(e => e.NrProtocolo)
                    .HasName("unq1_protocolo_icms")
                    .IsUnique();

                entity.Property(e => e.IdGeral)
                    .HasColumnName("id_geral")
                    .ValueGeneratedNever();

                entity.Property(e => e.Descricao)
                    .HasColumnName("descricao")
                    .HasMaxLength(50);

                entity.Property(e => e.DtProtocolo)
                    .HasColumnName("dt_protocolo")
                    .HasColumnType("date");

                entity.Property(e => e.NrProtocolo)
                    .IsRequired()
                    .HasColumnName("nr_protocolo")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<ProtocoloIcmsClassFiscal>(entity =>
            {
                entity.HasKey(e => e.IdGeral);

                entity.ToTable("protocolo_icms_class_fiscal");

                entity.HasIndex(e => new { e.IdProtocolo, e.CdClassFiscal })
                    .HasName("unq1_protocolo_icms_class_fisca")
                    .IsUnique();

                entity.Property(e => e.IdGeral)
                    .HasColumnName("id_geral")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdClassFiscal)
                    .IsRequired()
                    .HasColumnName("cd_class_fiscal")
                    .HasMaxLength(5);

                entity.Property(e => e.IdProtocolo).HasColumnName("id_protocolo");

                entity.Property(e => e.MvaEspecifica).HasColumnName("mva_especifica");

                entity.HasOne(d => d.CdClassFiscalNavigation)
                    .WithMany(p => p.ProtocoloIcmsClassFiscal)
                    .HasForeignKey(d => d.CdClassFiscal)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_protocolo_icms_class_fiscal");

                entity.HasOne(d => d.IdProtocoloNavigation)
                    .WithMany(p => p.ProtocoloIcmsClassFiscal)
                    .HasForeignKey(d => d.IdProtocolo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_protocolo_icms_protocolo");
            });

            modelBuilder.Entity<ReceitaAgro>(entity =>
            {
                entity.HasKey(e => new { e.CdFilial, e.NrNf, e.NrSequencia, e.NrReceita });

                entity.ToTable("receita_agro");

                entity.Property(e => e.CdFilial).HasColumnName("cd_filial");

                entity.Property(e => e.NrNf).HasColumnName("nr_nf");

                entity.Property(e => e.NrSequencia).HasColumnName("nr_sequencia");

                entity.Property(e => e.NrReceita).HasColumnName("nr_receita");

                entity.Property(e => e.Area)
                    .HasColumnName("area")
                    .HasColumnType("numeric(15,3)");

                entity.Property(e => e.CdAgronomo).HasColumnName("cd_agronomo");

                entity.Property(e => e.CdCliente).HasColumnName("cd_cliente");

                entity.Property(e => e.CdProdserv).HasColumnName("cd_prodserv");

                entity.Property(e => e.CdPropriedade).HasColumnName("cd_propriedade");

                entity.Property(e => e.Cultura)
                    .HasColumnName("cultura")
                    .HasMaxLength(100);

                entity.Property(e => e.Diagnostico).HasColumnName("diagnostico");

                entity.Property(e => e.Dosagem)
                    .HasColumnName("dosagem")
                    .HasMaxLength(15);

                entity.Property(e => e.DtEmissao)
                    .HasColumnName("dt_emissao")
                    .HasColumnType("date");

                entity.Property(e => e.Epis).HasColumnName("epis");

                entity.Property(e => e.EpocaAplicacao)
                    .HasColumnName("epoca_aplicacao")
                    .HasMaxLength(80);

                entity.Property(e => e.IntervaloSeg)
                    .HasColumnName("intervalo_seg")
                    .HasMaxLength(80);

                entity.Property(e => e.ModalidadeAplicacao).HasColumnName("modalidade_aplicacao");

                entity.Property(e => e.NrArt).HasColumnName("nr_art");

                entity.Property(e => e.Orientacao).HasColumnName("orientacao");

                entity.Property(e => e.Precaucao).HasColumnName("precaucao");

                entity.Property(e => e.QtAplicacao)
                    .HasColumnName("qt_aplicacao")
                    .HasMaxLength(20);

                entity.Property(e => e.QtTotal)
                    .HasColumnName("qt_total")
                    .HasColumnType("numeric(15,2)");

                entity.Property(e => e.SerieNf)
                    .HasColumnName("serie_nf")
                    .HasMaxLength(3);

                entity.Property(e => e.VolumeCalda)
                    .HasColumnName("volume_calda")
                    .HasMaxLength(21);

                entity.HasOne(d => d.CdPropriedadeNavigation)
                    .WithMany(p => p.ReceitaAgro)
                    .HasForeignKey(d => d.CdPropriedade)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_receita_agro_propriedade");

                entity.HasOne(d => d.Cd)
                    .WithMany(p => p.ReceitaAgro)
                    .HasForeignKey(d => new { d.CdFilial, d.CdCliente })
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_receita_agro_cliente");
            });

            modelBuilder.Entity<Recibo>(entity =>
            {
                entity.HasKey(e => e.NrRecibo);

                entity.ToTable("recibo");

                entity.Property(e => e.NrRecibo)
                    .HasColumnName("nr_recibo")
                    .ValueGeneratedNever();

                entity.Property(e => e.Assinatura)
                    .HasColumnName("assinatura")
                    .HasMaxLength(80);

                entity.Property(e => e.CdFilial).HasColumnName("cd_filial");

                entity.Property(e => e.DtAtz)
                    .HasColumnName("dt_atz")
                    .HasColumnType("date")
                    .HasDefaultValueSql("CURRENT_DATE");

                entity.Property(e => e.DtPgto)
                    .HasColumnName("dt_pgto")
                    .HasColumnType("date")
                    .HasDefaultValueSql("CURRENT_DATE");

                entity.Property(e => e.NmPago)
                    .IsRequired()
                    .HasColumnName("nm_pago")
                    .HasMaxLength(100);

                entity.Property(e => e.Proveniente)
                    .HasColumnName("proveniente")
                    .HasMaxLength(1023);

                entity.Property(e => e.VlPago)
                    .HasColumnName("vl_pago")
                    .HasColumnType("numeric(18,4)");
            });

            modelBuilder.Entity<ReducaoZ>(entity =>
            {
                entity.HasKey(e => new { e.CdImpfiscal, e.DtReducao });

                entity.ToTable("reducao_z");

                entity.Property(e => e.CdImpfiscal).HasColumnName("cd_impfiscal");

                entity.Property(e => e.DtReducao)
                    .HasColumnName("dt_reducao")
                    .HasColumnType("date");

                entity.Property(e => e.CamArqEstoque)
                    .HasColumnName("cam_arq_estoque")
                    .HasMaxLength(999);

                entity.Property(e => e.CamArqReducao)
                    .HasColumnName("cam_arq_reducao")
                    .HasMaxLength(999);

                entity.Property(e => e.ContadorZ).HasColumnName("contador_z");

                entity.Property(e => e.Coo).HasColumnName("coo");

                entity.Property(e => e.Cro).HasColumnName("cro");

                entity.Property(e => e.DtEmissao)
                    .HasColumnName("dt_emissao")
                    .HasColumnType("date");

                entity.Property(e => e.FlEstoqueEnviado)
                    .HasColumnName("fl_estoque_enviado")
                    .HasMaxLength(1);

                entity.Property(e => e.FlIncidenciaDescIss)
                    .HasColumnName("fl_incidencia_desc_iss")
                    .HasMaxLength(1);

                entity.Property(e => e.FlReducaoEnviada)
                    .HasColumnName("fl_reducao_enviada")
                    .HasMaxLength(1);

                entity.Property(e => e.HashReducaoZR2)
                    .HasColumnName("hash_reducao_z_r2")
                    .HasMaxLength(70);

                entity.Property(e => e.HashReducaoZR3)
                    .HasColumnName("hash_reducao_z_r3")
                    .HasMaxLength(70);

                entity.Property(e => e.HrEmissao)
                    .HasColumnName("hr_emissao")
                    .HasColumnType("time without time zone");

                entity.Property(e => e.IcmVlAcrescimo)
                    .HasColumnName("icm_vl_acrescimo")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.IcmVlCancelamento)
                    .HasColumnName("icm_vl_cancelamento")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.IcmVlDesconto)
                    .HasColumnName("icm_vl_desconto")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.IssVlAcrescimo)
                    .HasColumnName("iss_vl_acrescimo")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.IssVlCancelamento)
                    .HasColumnName("iss_vl_cancelamento")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.IssVlDesconto)
                    .HasColumnName("iss_vl_desconto")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.MfAdicional)
                    .HasColumnName("mf_adicional")
                    .HasMaxLength(1);

                entity.Property(e => e.NrCupomFinal).HasColumnName("nr_cupom_final");

                entity.Property(e => e.NrCupomInicial).HasColumnName("nr_cupom_inicial");

                entity.Property(e => e.VlAcrescimo)
                    .HasColumnName("vl_acrescimo")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.VlBruto)
                    .HasColumnName("vl_bruto")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.VlCancelamento)
                    .HasColumnName("vl_cancelamento")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.VlDesconto)
                    .HasColumnName("vl_desconto")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.VlGt)
                    .HasColumnName("vl_gt")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.VlIsento)
                    .HasColumnName("vl_isento")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.VlNaoIncidente)
                    .HasColumnName("vl_nao_incidente")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.VlOpnf)
                    .HasColumnName("vl_opnf")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.VlSubstituicao)
                    .HasColumnName("vl_substituicao")
                    .HasColumnType("numeric(13,2)");

                entity.HasOne(d => d.CdImpfiscalNavigation)
                    .WithMany(p => p.ReducaoZ)
                    .HasForeignKey(d => d.CdImpfiscal)
                    .HasConstraintName("fk_rez");
            });

            modelBuilder.Entity<Reducaoz1>(entity =>
            {
                entity.HasKey(e => new { e.NrSerieEcf, e.NrPdv, e.DtReducao });

                entity.ToTable("reducaoz");

                entity.Property(e => e.NrSerieEcf)
                    .HasColumnName("nr_serie_ecf")
                    .HasMaxLength(20);

                entity.Property(e => e.NrPdv).HasColumnName("nr_pdv");

                entity.Property(e => e.DtReducao)
                    .HasColumnName("dt_reducao")
                    .HasColumnType("date");

                entity.Property(e => e.Al01)
                    .HasColumnName("al_01")
                    .HasColumnType("numeric(4,2)");

                entity.Property(e => e.Al02)
                    .HasColumnName("al_02")
                    .HasColumnType("numeric(4,2)");

                entity.Property(e => e.Al03)
                    .HasColumnName("al_03")
                    .HasColumnType("numeric(4,2)");

                entity.Property(e => e.Al04)
                    .HasColumnName("al_04")
                    .HasColumnType("numeric(4,2)");

                entity.Property(e => e.Al05)
                    .HasColumnName("al_05")
                    .HasColumnType("numeric(4,2)");

                entity.Property(e => e.Al06)
                    .HasColumnName("al_06")
                    .HasColumnType("numeric(4,2)");

                entity.Property(e => e.ContadorFinal).HasColumnName("contador_final");

                entity.Property(e => e.ContadorInicial).HasColumnName("contador_inicial");

                entity.Property(e => e.ContadorRo).HasColumnName("contador_ro");

                entity.Property(e => e.ContadorZ).HasColumnName("contador_z");

                entity.Property(e => e.Vl01)
                    .HasColumnName("vl_01")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.Vl02)
                    .HasColumnName("vl_02")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.Vl03)
                    .HasColumnName("vl_03")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.Vl04)
                    .HasColumnName("vl_04")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.Vl05)
                    .HasColumnName("vl_05")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.Vl06)
                    .HasColumnName("vl_06")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlBrutoDia)
                    .HasColumnName("vl_bruto_dia")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlCancelamento)
                    .HasColumnName("vl_cancelamento")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlDesconto)
                    .HasColumnName("vl_desconto")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlIsento)
                    .HasColumnName("vl_isento")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlIssqn)
                    .HasColumnName("vl_issqn")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlNaoInc)
                    .HasColumnName("vl_nao_inc")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlSubstituicao)
                    .HasColumnName("vl_substituicao")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlTotalGeral)
                    .HasColumnName("vl_total_geral")
                    .HasColumnType("numeric(18,4)");
            });

            modelBuilder.Entity<ReducaoZTotalizador>(entity =>
            {
                entity.HasKey(e => new { e.CdImpfiscal, e.DtReducao, e.PcImposto, e.TpImposto });

                entity.ToTable("reducao_z_totalizador");

                entity.Property(e => e.CdImpfiscal).HasColumnName("cd_impfiscal");

                entity.Property(e => e.DtReducao)
                    .HasColumnName("dt_reducao")
                    .HasColumnType("date");

                entity.Property(e => e.PcImposto).HasColumnName("pc_imposto");

                entity.Property(e => e.TpImposto)
                    .HasColumnName("tp_imposto")
                    .HasMaxLength(1);

                entity.Property(e => e.HashReducaoZTotalizadorR3)
                    .HasColumnName("hash_reducao_z_totalizador_r3")
                    .HasMaxLength(70);

                entity.Property(e => e.NrOrdem).HasColumnName("nr_ordem");

                entity.Property(e => e.VlVendido)
                    .HasColumnName("vl_vendido")
                    .HasColumnType("numeric(18,4)");

                entity.HasOne(d => d.ReducaoZ)
                    .WithMany(p => p.ReducaoZTotalizador)
                    .HasForeignKey(d => new { d.CdImpfiscal, d.DtReducao })
                    .HasConstraintName("fk_rzt_rz");
            });

            modelBuilder.Entity<RefNotaProdutor>(entity =>
            {
                entity.HasKey(e => e.CodReferencia);

                entity.ToTable("ref_nota_produtor");

                entity.Property(e => e.CodReferencia)
                    .HasColumnName("cod_referencia")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdFilial).HasColumnName("cd_filial");

                entity.Property(e => e.DataNfProdutor)
                    .IsRequired()
                    .HasColumnName("data_nf_produtor")
                    .HasMaxLength(4);

                entity.Property(e => e.IdNfec).HasColumnName("id_nfec");

                entity.Property(e => e.ModeloNfProdutor)
                    .IsRequired()
                    .HasColumnName("modelo_nf_produtor")
                    .HasMaxLength(4);

                entity.Property(e => e.NrNfProdutor)
                    .IsRequired()
                    .HasColumnName("nr_nf_produtor")
                    .HasMaxLength(18);

                entity.Property(e => e.SerieNfProdutor)
                    .IsRequired()
                    .HasColumnName("serie_nf_produtor")
                    .HasMaxLength(4);
            });

            modelBuilder.Entity<Regiao>(entity =>
            {
                entity.HasKey(e => e.CdRegiao);

                entity.ToTable("regiao");

                entity.Property(e => e.CdRegiao)
                    .HasColumnName("cd_regiao")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdFilial).HasColumnName("cd_filial");

                entity.Property(e => e.DtAtz)
                    .HasColumnName("dt_atz")
                    .HasColumnType("date")
                    .HasDefaultValueSql("CURRENT_DATE");

                entity.Property(e => e.NmRegiao)
                    .IsRequired()
                    .HasColumnName("nm_regiao")
                    .HasMaxLength(60);
            });

            modelBuilder.Entity<Rotas>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.UfDestino).IsRequired();

                entity.Property(e => e.UfOrigem).IsRequired();
            });

            modelBuilder.Entity<SaldoCxaDia>(entity =>
            {
                entity.HasKey(e => new { e.CdFilial, e.CdCaixa, e.DtCaixa });

                entity.ToTable("saldo_cxa_dia");

                entity.Property(e => e.CdFilial).HasColumnName("cd_filial");

                entity.Property(e => e.CdCaixa).HasColumnName("cd_caixa");

                entity.Property(e => e.DtCaixa)
                    .HasColumnName("dt_caixa")
                    .HasColumnType("date");

                entity.Property(e => e.VlSaldo)
                    .HasColumnName("vl_saldo")
                    .HasColumnType("numeric(18,4)");
            });

            modelBuilder.Entity<Situacao>(entity =>
            {
                entity.HasKey(e => e.CdSituacao);

                entity.ToTable("situacao");

                entity.HasIndex(e => e.FlReservaEstoque)
                    .HasName("idx_situacao_reserva");

                entity.HasIndex(e => e.NmSituacao)
                    .HasName("idx_situacao_nome");

                entity.Property(e => e.CdSituacao)
                    .HasColumnName("cd_situacao")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdPrecedente).HasColumnName("cd_precedente");

                entity.Property(e => e.Cor)
                    .HasColumnName("cor")
                    .HasMaxLength(30);

                entity.Property(e => e.EndArqModelo).HasColumnName("end_arq_modelo");

                entity.Property(e => e.EndArqModeloPdf)
                    .HasColumnName("end_arq_modelo_pdf")
                    .HasMaxLength(1000);

                entity.Property(e => e.FlBloqueiaEstoque).HasColumnName("fl_bloqueia_estoque");

                entity.Property(e => e.FlDescricaoServico).HasColumnName("fl_descricao_servico");

                entity.Property(e => e.FlEnviaEmail)
                    .HasColumnName("fl_envia_email")
                    .HasMaxLength(1);

                entity.Property(e => e.FlExportaDavPdf).HasColumnName("fl_exporta_dav_pdf");

                entity.Property(e => e.FlFinal).HasColumnName("fl_final");

                entity.Property(e => e.FlIcmsst)
                    .HasColumnName("fl_icmsst")
                    .HasMaxLength(1);

                entity.Property(e => e.FlInicial).HasColumnName("fl_inicial");

                entity.Property(e => e.FlIpi)
                    .HasColumnName("fl_ipi")
                    .HasMaxLength(1);

                entity.Property(e => e.FlOrdemServico).HasColumnName("fl_ordem_servico");

                entity.Property(e => e.FlPedComp).HasColumnName("fl_ped_comp");

                entity.Property(e => e.FlPreVenda).HasColumnName("fl_pre_venda");

                entity.Property(e => e.FlPrecoCusto).HasColumnName("fl_preco_custo");

                entity.Property(e => e.FlProdutoSerie).HasColumnName("fl_produto_serie");

                entity.Property(e => e.FlReservaEstoque).HasColumnName("fl_reserva_estoque");

                entity.Property(e => e.NmSituacao)
                    .IsRequired()
                    .HasColumnName("nm_situacao")
                    .HasMaxLength(50);

                entity.HasOne(d => d.CdPrecedenteNavigation)
                    .WithMany(p => p.InverseCdPrecedenteNavigation)
                    .HasForeignKey(d => d.CdPrecedente)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_situacao_precedencia");
            });

            modelBuilder.Entity<Subgruprod>(entity =>
            {
                entity.HasKey(e => e.CdSubgruprod);

                entity.ToTable("subgruprod");

                entity.Property(e => e.CdSubgruprod)
                    .HasColumnName("cd_subgruprod")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdGruprod).HasColumnName("cd_gruprod");

                entity.Property(e => e.DtAtz)
                    .HasColumnName("dt_atz")
                    .HasColumnType("date")
                    .HasDefaultValueSql("CURRENT_DATE");

                entity.Property(e => e.NmSubgruprod)
                    .IsRequired()
                    .HasColumnName("nm_subgruprod")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<Tab436SpedPiscofins>(entity =>
            {
                entity.HasKey(e => e.CdTpCredito);

                entity.ToTable("tab_436_sped_piscofins");

                entity.Property(e => e.CdTpCredito)
                    .HasColumnName("cd_tp_credito")
                    .HasMaxLength(3)
                    .ValueGeneratedNever();

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasColumnName("descricao")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Tab437SpedPiscofins>(entity =>
            {
                entity.HasKey(e => e.CdBcCredito);

                entity.ToTable("tab_437_sped_piscofins");

                entity.Property(e => e.CdBcCredito)
                    .HasColumnName("cd_bc_credito")
                    .HasMaxLength(2)
                    .ValueGeneratedNever();

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasColumnName("descricao")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<TabelaPreco>(entity =>
            {
                entity.HasKey(e => e.CdTabelaPreco);

                entity.ToTable("tabela_preco");

                entity.Property(e => e.CdTabelaPreco)
                    .HasColumnName("cd_tabela_preco")
                    .ValueGeneratedNever();

                entity.Property(e => e.FlPercentual)
                    .HasColumnName("fl_percentual")
                    .HasMaxLength(1);

                entity.Property(e => e.NmTabelaPreco)
                    .HasColumnName("nm_tabela_preco")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<TabelaPrecoProduto>(entity =>
            {
                entity.HasKey(e => e.IdGeral);

                entity.ToTable("tabela_preco_produto");

                entity.HasIndex(e => new { e.CdTabelaPreco, e.CdProduto })
                    .HasName("unq1_tabela_preco_produto")
                    .IsUnique();

                entity.Property(e => e.IdGeral)
                    .HasColumnName("id_geral")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdProduto)
                    .IsRequired()
                    .HasColumnName("cd_produto")
                    .HasMaxLength(15);

                entity.Property(e => e.CdTabelaPreco).HasColumnName("cd_tabela_preco");

                entity.Property(e => e.DtAtz)
                    .HasColumnName("dt_atz")
                    .HasColumnType("date")
                    .HasDefaultValueSql("CURRENT_DATE");

                entity.Property(e => e.FlUtilizaMarkup)
                    .IsRequired()
                    .HasColumnName("fl_utiliza_markup")
                    .HasMaxLength(1);

                entity.Property(e => e.FlUtilizaMarkupFlex)
                    .HasColumnName("fl_utiliza_markup_flex")
                    .HasMaxLength(1);

                entity.Property(e => e.HashTabelaPrecoProdutoP2)
                    .HasColumnName("hash_tabela_preco_produto_p2")
                    .HasMaxLength(70);

                entity.Property(e => e.PcMarkup)
                    .HasColumnName("pc_markup")
                    .HasColumnType("numeric(5,2)");

                entity.Property(e => e.PcMarkupFlexMax)
                    .HasColumnName("pc_markup_flex_max")
                    .HasColumnType("numeric(15,2)");

                entity.Property(e => e.PcMarkupFlexMin)
                    .HasColumnName("pc_markup_flex_min")
                    .HasColumnType("numeric(15,2)");

                entity.Property(e => e.PcMarkupMin)
                    .HasColumnName("pc_markup_min")
                    .HasColumnType("numeric(5,2)");

                entity.Property(e => e.PrecoVenda)
                    .HasColumnName("preco_venda")
                    .HasColumnType("numeric(15,2)");

                entity.Property(e => e.PrecoVendaFlexMax)
                    .HasColumnName("preco_venda_flex_max")
                    .HasColumnType("numeric(15,2)");

                entity.Property(e => e.PrecoVendaFlexMin)
                    .HasColumnName("preco_venda_flex_min")
                    .HasColumnType("numeric(15,2)");

                entity.Property(e => e.PrecoVendaMin)
                    .HasColumnName("preco_venda_min")
                    .HasColumnType("numeric(15,2)");

                entity.HasOne(d => d.CdTabelaPrecoNavigation)
                    .WithMany(p => p.TabelaPrecoProduto)
                    .HasForeignKey(d => d.CdTabelaPreco)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tabela_preco_produto_tabela");
            });

            modelBuilder.Entity<Tabvcto>(entity =>
            {
                entity.HasKey(e => new { e.CdFilial, e.NrOs, e.Parcela });

                entity.ToTable("tabvcto");

                entity.Property(e => e.CdFilial).HasColumnName("cd_filial");

                entity.Property(e => e.NrOs).HasColumnName("nr_os");

                entity.Property(e => e.Parcela).HasColumnName("parcela");

                entity.Property(e => e.DtAtz)
                    .HasColumnName("dt_atz")
                    .HasColumnType("date")
                    .HasDefaultValueSql("CURRENT_DATE");

                entity.Property(e => e.DtVcto)
                    .HasColumnName("dt_vcto")
                    .HasColumnType("date")
                    .HasDefaultValueSql("CURRENT_DATE");

                entity.Property(e => e.PcParcela)
                    .HasColumnName("pc_parcela")
                    .HasColumnType("numeric(9,2)");

                entity.Property(e => e.PrazoParcela).HasColumnName("prazo_parcela");

                entity.Property(e => e.VlVcto)
                    .HasColumnName("vl_vcto")
                    .HasColumnType("numeric(18,4)");
            });

            modelBuilder.Entity<Tipocobr>(entity =>
            {
                entity.HasKey(e => e.CdTipocobr);

                entity.ToTable("tipocobr");

                entity.Property(e => e.CdTipocobr)
                    .HasColumnName("cd_tipocobr")
                    .ValueGeneratedNever();

                entity.Property(e => e.DescricaoTpCobranca)
                    .HasColumnName("descricao_tp_cobranca")
                    .HasMaxLength(40);

                entity.Property(e => e.DtAtz).HasColumnName("dt_atz");

                entity.Property(e => e.FlEmitirBloqueto).HasColumnName("fl_emitir_bloqueto");

                entity.Property(e => e.FlImprimeCarneEcf).HasColumnName("fl_imprime_carne_ecf");

                entity.Property(e => e.FlImprimeComprovanteEcf).HasColumnName("fl_imprime_comprovante_ecf");

                entity.Property(e => e.FlImprimeParcela).HasColumnName("fl_imprime_parcela");

                entity.Property(e => e.FlPorcentagem).HasColumnName("fl_porcentagem");

                entity.Property(e => e.NmTipocobr)
                    .IsRequired()
                    .HasColumnName("nm_tipocobr")
                    .HasMaxLength(80);

                entity.Property(e => e.TaxaDesc)
                    .HasColumnName("taxa_desc")
                    .HasColumnType("numeric(9,2)");

                entity.Property(e => e.TpCobranca)
                    .HasColumnName("tp_cobranca")
                    .HasMaxLength(2);

                entity.Property(e => e.VlAcrescimo)
                    .HasColumnName("vl_acrescimo")
                    .HasColumnType("numeric(18,4)");
            });

            modelBuilder.Entity<Tributacao>(entity =>
            {
                entity.HasKey(e => e.IdGeral);

                entity.ToTable("tributacao");

                entity.HasIndex(e => new { e.IdTributacaoGrupo, e.UfOrigem, e.UfDestino })
                    .HasName("unq1_tributacao")
                    .IsUnique();

                entity.Property(e => e.IdGeral)
                    .HasColumnName("id_geral")
                    .ValueGeneratedNever();

                entity.Property(e => e.DtAtz)
                    .HasColumnName("dt_atz")
                    .HasColumnType("date");

                entity.Property(e => e.IdTributacaoGrupo).HasColumnName("id_tributacao_grupo");

                entity.Property(e => e.UfDestino)
                    .IsRequired()
                    .HasColumnName("uf_destino")
                    .HasMaxLength(2);

                entity.Property(e => e.UfOrigem)
                    .IsRequired()
                    .HasColumnName("uf_origem")
                    .HasMaxLength(2);

                entity.HasOne(d => d.IdTributacaoGrupoNavigation)
                    .WithMany(p => p.Tributacao)
                    .HasForeignKey(d => d.IdTributacaoGrupo)
                    .HasConstraintName("fk_tributacao_tributacao_grupo");
            });

            modelBuilder.Entity<TributacaoAliquota>(entity =>
            {
                entity.HasKey(e => e.IdGeral);

                entity.ToTable("tributacao_aliquota");

                entity.HasIndex(e => new { e.IdTributacao, e.TpTributacao })
                    .HasName("unq1_tributacao_aliquota")
                    .IsUnique();

                entity.Property(e => e.IdGeral)
                    .HasColumnName("id_geral")
                    .ValueGeneratedNever();

                entity.Property(e => e.AliqFcp).HasColumnName("aliq_fcp");

                entity.Property(e => e.CdMensagem).HasColumnName("cd_mensagem");

                entity.Property(e => e.Cst)
                    .IsRequired()
                    .HasColumnName("cst")
                    .HasMaxLength(4);

                entity.Property(e => e.DtAtz)
                    .HasColumnName("dt_atz")
                    .HasColumnType("date");

                entity.Property(e => e.FlReducaoAliqNormal)
                    .HasColumnName("fl_reducao_aliq_normal")
                    .HasMaxLength(1);

                entity.Property(e => e.FlReducaoAliqProprio)
                    .HasColumnName("fl_reducao_aliq_proprio")
                    .HasMaxLength(1);

                entity.Property(e => e.FlReducaoAliqSubst)
                    .HasColumnName("fl_reducao_aliq_subst")
                    .HasMaxLength(1);

                entity.Property(e => e.HashTributacaoAliquotaD3)
                    .HasColumnName("hash_tributacao_aliquota_d3")
                    .HasMaxLength(70);

                entity.Property(e => e.HashTributacaoAliquotaP2)
                    .HasColumnName("hash_tributacao_aliquota_p2")
                    .HasMaxLength(70);

                entity.Property(e => e.IcmAliqNormal).HasColumnName("icm_aliq_normal");

                entity.Property(e => e.IcmAliqProprio).HasColumnName("icm_aliq_proprio");

                entity.Property(e => e.IcmAliqSubst).HasColumnName("icm_aliq_subst");

                entity.Property(e => e.IcmRedNormal).HasColumnName("icm_red_normal");

                entity.Property(e => e.IcmRedProprio).HasColumnName("icm_red_proprio");

                entity.Property(e => e.IcmRedSubst).HasColumnName("icm_red_subst");

                entity.Property(e => e.IdTributacao).HasColumnName("id_tributacao");

                entity.Property(e => e.TpTributacao)
                    .IsRequired()
                    .HasColumnName("tp_tributacao")
                    .HasMaxLength(1);

                entity.HasOne(d => d.CdMensagemNavigation)
                    .WithMany(p => p.TributacaoAliquota)
                    .HasForeignKey(d => d.CdMensagem)
                    .HasConstraintName("fk_tributacao_aliquota_mensagem");

                entity.HasOne(d => d.CstNavigation)
                    .WithMany(p => p.TributacaoAliquota)
                    .HasForeignKey(d => d.Cst)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tributacao_aliquota_1");

                entity.HasOne(d => d.IdTributacaoNavigation)
                    .WithMany(p => p.TributacaoAliquota)
                    .HasForeignKey(d => d.IdTributacao)
                    .HasConstraintName("fk_tributacao_aliquota_tributac");
            });

            modelBuilder.Entity<TributacaoGrupo>(entity =>
            {
                entity.HasKey(e => e.IdTributacaoGrupo);

                entity.ToTable("tributacao_grupo");

                entity.Property(e => e.IdTributacaoGrupo)
                    .HasColumnName("id_tributacao_grupo")
                    .ValueGeneratedNever();

                entity.Property(e => e.DtAtz)
                    .HasColumnName("dt_atz")
                    .HasColumnType("date");

                entity.Property(e => e.NmTributacaoGrupo)
                    .HasColumnName("nm_tributacao_grupo")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<TributacaoGrupoPisCofins>(entity =>
            {
                entity.HasKey(e => e.CdTributacao);

                entity.ToTable("tributacao_grupo_pis_cofins");

                entity.Property(e => e.CdTributacao)
                    .HasColumnName("cd_tributacao")
                    .ValueGeneratedNever();

                entity.Property(e => e.CofinsCompraCst)
                    .HasColumnName("cofins_compra_cst")
                    .HasMaxLength(2);

                entity.Property(e => e.CofinsCompraPcAliq)
                    .HasColumnName("cofins_compra_pc_aliq")
                    .HasColumnType("numeric(8,4)");

                entity.Property(e => e.CofinsDevCompraCst)
                    .HasColumnName("cofins_dev_compra_cst")
                    .HasMaxLength(2);

                entity.Property(e => e.CofinsDevCompraPcAliq)
                    .HasColumnName("cofins_dev_compra_pc_aliq")
                    .HasColumnType("numeric(8,4)");

                entity.Property(e => e.CofinsDevVendaCst)
                    .HasColumnName("cofins_dev_venda_cst")
                    .HasMaxLength(2);

                entity.Property(e => e.CofinsDevVendaPcAliq)
                    .HasColumnName("cofins_dev_venda_pc_aliq")
                    .HasColumnType("numeric(8,4)");

                entity.Property(e => e.CofinsVendaCst)
                    .HasColumnName("cofins_venda_cst")
                    .HasMaxLength(2);

                entity.Property(e => e.CofinsVendaPcAliq)
                    .HasColumnName("cofins_venda_pc_aliq")
                    .HasColumnType("numeric(8,4)");

                entity.Property(e => e.DtAtz)
                    .HasColumnName("dt_atz")
                    .HasColumnType("date");

                entity.Property(e => e.NmTributacao)
                    .HasColumnName("nm_tributacao")
                    .HasMaxLength(40);

                entity.Property(e => e.PisCompraCst)
                    .HasColumnName("pis_compra_cst")
                    .HasMaxLength(2);

                entity.Property(e => e.PisCompraPcAliq)
                    .HasColumnName("pis_compra_pc_aliq")
                    .HasColumnType("numeric(8,4)");

                entity.Property(e => e.PisDevCompraCst)
                    .HasColumnName("pis_dev_compra_cst")
                    .HasMaxLength(2);

                entity.Property(e => e.PisDevCompraPcAliq)
                    .HasColumnName("pis_dev_compra_pc_aliq")
                    .HasColumnType("numeric(8,4)");

                entity.Property(e => e.PisDevVendaCst)
                    .HasColumnName("pis_dev_venda_cst")
                    .HasMaxLength(2);

                entity.Property(e => e.PisDevVendaPcAliq)
                    .HasColumnName("pis_dev_venda_pc_aliq")
                    .HasColumnType("numeric(8,4)");

                entity.Property(e => e.PisVendaCst)
                    .HasColumnName("pis_venda_cst")
                    .HasMaxLength(2);

                entity.Property(e => e.PisVendaPcAliq)
                    .HasColumnName("pis_venda_pc_aliq")
                    .HasColumnType("numeric(8,4)");

                entity.HasOne(d => d.CofinsCompraCstNavigation)
                    .WithMany(p => p.TributacaoGrupoPisCofinsCofinsCompraCstNavigation)
                    .HasForeignKey(d => d.CofinsCompraCst)
                    .HasConstraintName("fk_trib_compra_cst");

                entity.HasOne(d => d.CofinsVendaCstNavigation)
                    .WithMany(p => p.TributacaoGrupoPisCofinsCofinsVendaCstNavigation)
                    .HasForeignKey(d => d.CofinsVendaCst)
                    .HasConstraintName("fk_trib_venda_cst");

                entity.HasOne(d => d.PisCompraCstNavigation)
                    .WithMany(p => p.TributacaoGrupoPisCofinsPisCompraCstNavigation)
                    .HasForeignKey(d => d.PisCompraCst)
                    .HasConstraintName("fk_trib_pis_compra_cst");

                entity.HasOne(d => d.PisVendaCstNavigation)
                    .WithMany(p => p.TributacaoGrupoPisCofinsPisVendaCstNavigation)
                    .HasForeignKey(d => d.PisVendaCst)
                    .HasConstraintName("fk_trib_cofins_venda_cst");
            });

            modelBuilder.Entity<UnMedida>(entity =>
            {
                entity.HasKey(e => e.UnMedida1);

                entity.ToTable("un_medida");

                entity.Property(e => e.UnMedida1)
                    .HasColumnName("un_medida")
                    .HasMaxLength(6)
                    .ValueGeneratedNever();

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasColumnName("descricao")
                    .HasMaxLength(60);
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.CdUsuario);

                entity.ToTable("usuario");

                entity.Property(e => e.CdUsuario)
                    .HasColumnName("cd_usuario")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdFuncionario).HasColumnName("cd_funcionario");

                entity.Property(e => e.FlAcessoIrrestrito)
                    .HasColumnName("fl_acesso_irrestrito")
                    .HasMaxLength(1);

                entity.Property(e => e.FlAtivo)
                    .HasColumnName("fl_ativo")
                    .HasMaxLength(1);

                entity.Property(e => e.FlCtrlCxaRetaguarda)
                    .IsRequired()
                    .HasColumnName("fl_ctrl_cxa_retaguarda")
                    .HasMaxLength(1);

                entity.Property(e => e.FlCtrlFilial)
                    .HasColumnName("fl_ctrl_filial")
                    .HasMaxLength(1);

                entity.Property(e => e.FlSessaoDifInstalacao)
                    .HasColumnName("fl_sessao_dif_instalacao")
                    .HasMaxLength(20);

                entity.Property(e => e.Login)
                    .IsRequired()
                    .HasColumnName("login")
                    .HasMaxLength(15);

                entity.Property(e => e.Senha)
                    .HasColumnName("senha")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<UsuarioPerfil>(entity =>
            {
                entity.HasKey(e => new { e.CdUsuario, e.CdPerfil });

                entity.ToTable("usuario_perfil");

                entity.Property(e => e.CdUsuario).HasColumnName("cd_usuario");

                entity.Property(e => e.CdPerfil).HasColumnName("cd_perfil");

                entity.HasOne(d => d.CdPerfilNavigation)
                    .WithMany(p => p.UsuarioPerfil)
                    .HasForeignKey(d => d.CdPerfil)
                    .HasConstraintName("fk_usuario_perfil_perfil");

                entity.HasOne(d => d.CdUsuarioNavigation)
                    .WithMany(p => p.UsuarioPerfil)
                    .HasForeignKey(d => d.CdUsuario)
                    .HasConstraintName("fk_usuario_perfil_usuario");
            });

            modelBuilder.Entity<Veiculo>(entity =>
            {
                entity.HasKey(e => new { e.CdFilial, e.CdVeiculo });

                entity.ToTable("veiculo");

                entity.HasIndex(e => e.NmVeiculo)
                    .HasName("ind_veiculo_nome");

                entity.Property(e => e.CdFilial).HasColumnName("cd_filial");

                entity.Property(e => e.CdVeiculo).HasColumnName("cd_veiculo");

                entity.Property(e => e.CdMontadora).HasColumnName("cd_montadora");

                entity.Property(e => e.DtAtz)
                    .HasColumnName("dt_atz")
                    .HasColumnType("date")
                    .HasDefaultValueSql("CURRENT_DATE");

                entity.Property(e => e.NmVeiculo)
                    .IsRequired()
                    .HasColumnName("nm_veiculo")
                    .HasMaxLength(70);

                entity.HasOne(d => d.Cd)
                    .WithMany(p => p.Veiculo)
                    .HasForeignKey(d => new { d.CdFilial, d.CdMontadora })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_veimontadora");
            });

            modelBuilder.Entity<VeiculoCombustivel>(entity =>
            {
                entity.HasKey(e => e.CdCombustivel);

                entity.ToTable("veiculo_combustivel");

                entity.Property(e => e.CdCombustivel)
                    .HasColumnName("cd_combustivel")
                    .HasMaxLength(2)
                    .ValueGeneratedNever();

                entity.Property(e => e.Descricao)
                    .HasColumnName("descricao")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<VeiculoComplemento>(entity =>
            {
                entity.HasKey(e => e.CdComplemento);

                entity.ToTable("veiculo_complemento");

                entity.Property(e => e.CdComplemento)
                    .HasColumnName("cd_complemento")
                    .ValueGeneratedNever();

                entity.Property(e => e.Descricao)
                    .HasColumnName("descricao")
                    .HasMaxLength(100);

                entity.Property(e => e.DtAtz)
                    .HasColumnName("dt_atz")
                    .HasColumnType("date");
            });

            modelBuilder.Entity<VeiculoCor>(entity =>
            {
                entity.HasKey(e => e.CdCor);

                entity.ToTable("veiculo_cor");

                entity.Property(e => e.CdCor)
                    .HasColumnName("cd_cor")
                    .HasMaxLength(2)
                    .ValueGeneratedNever();

                entity.Property(e => e.Descricao)
                    .HasColumnName("descricao")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<VeiculoDespesas>(entity =>
            {
                entity.HasKey(e => new { e.CdFilial, e.CdProduto, e.NrSequencial });

                entity.ToTable("veiculo_despesas");

                entity.HasIndex(e => e.CdProduto)
                    .HasName("ind_veiculo_despesas_cd_produto");

                entity.Property(e => e.CdFilial).HasColumnName("cd_filial");

                entity.Property(e => e.CdProduto)
                    .HasColumnName("cd_produto")
                    .HasMaxLength(15);

                entity.Property(e => e.NrSequencial).HasColumnName("nr_sequencial");

                entity.Property(e => e.CustoTotal)
                    .HasColumnName("custo_total")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.DctoVenda).HasColumnName("dcto_venda");

                entity.Property(e => e.DtCompra)
                    .HasColumnName("dt_compra")
                    .HasColumnType("date");

                entity.Property(e => e.IdNfei).HasColumnName("id_nfei");

                entity.Property(e => e.Observacao).HasColumnName("observacao");

                entity.Property(e => e.VlComissao)
                    .HasColumnName("vl_comissao")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlCompra)
                    .HasColumnName("vl_compra")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlCompraReal)
                    .HasColumnName("vl_compra_real")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlDespachante)
                    .HasColumnName("vl_despachante")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlFrete)
                    .HasColumnName("vl_frete")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlIpva)
                    .HasColumnName("vl_ipva")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlPecas)
                    .HasColumnName("vl_pecas")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlServTerceiros)
                    .HasColumnName("vl_serv_terceiros")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlServicos)
                    .HasColumnName("vl_servicos")
                    .HasColumnType("numeric(18,4)");

                entity.Property(e => e.VlVendaReal)
                    .HasColumnName("vl_venda_real")
                    .HasColumnType("numeric(18,4)");

                entity.HasOne(d => d.IdNfeiNavigation)
                    .WithMany(p => p.VeiculoDespesas)
                    .HasForeignKey(d => d.IdNfei)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_veiculo_despesas_nfei");

                entity.HasOne(d => d.Nfsc)
                    .WithMany(p => p.VeiculoDespesas)
                    .HasForeignKey(d => new { d.CdFilial, d.DctoVenda })
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_veiculo_despesas_nfs");
            });

            modelBuilder.Entity<VeiculoEspecie>(entity =>
            {
                entity.HasKey(e => e.CdEspecie);

                entity.ToTable("veiculo_especie");

                entity.Property(e => e.CdEspecie)
                    .HasColumnName("cd_especie")
                    .HasMaxLength(2)
                    .ValueGeneratedNever();

                entity.Property(e => e.Descricao)
                    .HasColumnName("descricao")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<VeiculoInjecao>(entity =>
            {
                entity.HasKey(e => e.CdInjecao);

                entity.ToTable("veiculo_injecao");

                entity.Property(e => e.CdInjecao)
                    .HasColumnName("cd_injecao")
                    .ValueGeneratedNever();

                entity.Property(e => e.Descricao)
                    .HasColumnName("descricao")
                    .HasMaxLength(100);

                entity.Property(e => e.DtAtz)
                    .HasColumnName("dt_atz")
                    .HasColumnType("date");
            });

            modelBuilder.Entity<VeiculoModeloComplemento>(entity =>
            {
                entity.HasKey(e => new { e.CdFilial, e.IdGeral });

                entity.ToTable("veiculo_modelo_complemento");

                entity.HasIndex(e => new { e.CdFilial, e.CdModelo, e.CdComplemento })
                    .HasName("unq_veiculo_modelo_complemento")
                    .IsUnique();

                entity.Property(e => e.CdFilial).HasColumnName("cd_filial");

                entity.Property(e => e.IdGeral).HasColumnName("id_geral");

                entity.Property(e => e.CdComplemento).HasColumnName("cd_complemento");

                entity.Property(e => e.CdModelo).HasColumnName("cd_modelo");

                entity.Property(e => e.DtAtz).HasColumnName("dt_atz");

                entity.HasOne(d => d.CdComplementoNavigation)
                    .WithMany(p => p.VeiculoModeloComplemento)
                    .HasForeignKey(d => d.CdComplemento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_veic_compl_mod_complemento");

                entity.HasOne(d => d.Cd)
                    .WithMany(p => p.VeiculoModeloComplemento)
                    .HasForeignKey(d => new { d.CdFilial, d.CdModelo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_veic_compl_mod_veiculo");
            });

            modelBuilder.Entity<VeiculoModeloInjecao>(entity =>
            {
                entity.HasKey(e => new { e.CdFilial, e.IdGeral });

                entity.ToTable("veiculo_modelo_injecao");

                entity.HasIndex(e => new { e.CdFilial, e.CdModelo, e.CdInjecao })
                    .HasName("unq_veiculo_modelo_injecao")
                    .IsUnique();

                entity.Property(e => e.CdFilial).HasColumnName("cd_filial");

                entity.Property(e => e.IdGeral).HasColumnName("id_geral");

                entity.Property(e => e.CdInjecao).HasColumnName("cd_injecao");

                entity.Property(e => e.CdModelo).HasColumnName("cd_modelo");

                entity.Property(e => e.DtAtz).HasColumnName("dt_atz");

                entity.HasOne(d => d.CdInjecaoNavigation)
                    .WithMany(p => p.VeiculoModeloInjecao)
                    .HasForeignKey(d => d.CdInjecao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_veic_inj_mod_injecao");

                entity.HasOne(d => d.Cd)
                    .WithMany(p => p.VeiculoModeloInjecao)
                    .HasForeignKey(d => new { d.CdFilial, d.CdModelo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_veic_inj_mod_veiculo");
            });

            modelBuilder.Entity<VeiculoModeloMotor>(entity =>
            {
                entity.HasKey(e => new { e.CdFilial, e.IdGeral });

                entity.ToTable("veiculo_modelo_motor");

                entity.HasIndex(e => new { e.CdFilial, e.CdModelo, e.CdMotor })
                    .HasName("unq_veiculo_modelo_motor")
                    .IsUnique();

                entity.Property(e => e.CdFilial).HasColumnName("cd_filial");

                entity.Property(e => e.IdGeral).HasColumnName("id_geral");

                entity.Property(e => e.CdModelo).HasColumnName("cd_modelo");

                entity.Property(e => e.CdMotor).HasColumnName("cd_motor");

                entity.Property(e => e.DtAtz).HasColumnName("dt_atz");

                entity.HasOne(d => d.CdMotorNavigation)
                    .WithMany(p => p.VeiculoModeloMotor)
                    .HasForeignKey(d => d.CdMotor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_veic_mot_mod_injecao");

                entity.HasOne(d => d.Cd)
                    .WithMany(p => p.VeiculoModeloMotor)
                    .HasForeignKey(d => new { d.CdFilial, d.CdModelo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_veic_mot_mod_veiculo");
            });

            modelBuilder.Entity<VeiculoModeloTransmissao>(entity =>
            {
                entity.HasKey(e => new { e.CdFilial, e.IdGeral });

                entity.ToTable("veiculo_modelo_transmissao");

                entity.HasIndex(e => new { e.CdFilial, e.CdModelo, e.CdTransmissao })
                    .HasName("unq_veiculo_modelo_transmissao")
                    .IsUnique();

                entity.Property(e => e.CdFilial).HasColumnName("cd_filial");

                entity.Property(e => e.IdGeral).HasColumnName("id_geral");

                entity.Property(e => e.CdModelo).HasColumnName("cd_modelo");

                entity.Property(e => e.CdTransmissao).HasColumnName("cd_transmissao");

                entity.Property(e => e.DtAtz).HasColumnName("dt_atz");

                entity.HasOne(d => d.CdTransmissaoNavigation)
                    .WithMany(p => p.VeiculoModeloTransmissao)
                    .HasForeignKey(d => d.CdTransmissao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_veic_trans_mod_injecao");

                entity.HasOne(d => d.Cd)
                    .WithMany(p => p.VeiculoModeloTransmissao)
                    .HasForeignKey(d => new { d.CdFilial, d.CdModelo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_veic_trans_mod_veiculo");
            });

            modelBuilder.Entity<VeiculoMotor>(entity =>
            {
                entity.HasKey(e => e.CdMotor);

                entity.ToTable("veiculo_motor");

                entity.Property(e => e.CdMotor)
                    .HasColumnName("cd_motor")
                    .ValueGeneratedNever();

                entity.Property(e => e.Descricao)
                    .HasColumnName("descricao")
                    .HasMaxLength(100);

                entity.Property(e => e.DtAtz)
                    .HasColumnName("dt_atz")
                    .HasColumnType("date");
            });

            modelBuilder.Entity<VeiculoTipo>(entity =>
            {
                entity.HasKey(e => e.CdTipo);

                entity.ToTable("veiculo_tipo");

                entity.Property(e => e.CdTipo)
                    .HasColumnName("cd_tipo")
                    .HasMaxLength(2)
                    .ValueGeneratedNever();

                entity.Property(e => e.Descricao)
                    .HasColumnName("descricao")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<VeiculoTransmissao>(entity =>
            {
                entity.HasKey(e => e.CdTransmissao);

                entity.ToTable("veiculo_transmissao");

                entity.Property(e => e.CdTransmissao)
                    .HasColumnName("cd_transmissao")
                    .ValueGeneratedNever();

                entity.Property(e => e.Descricao)
                    .HasColumnName("descricao")
                    .HasMaxLength(100);

                entity.Property(e => e.DtAtz)
                    .HasColumnName("dt_atz")
                    .HasColumnType("date");
            });

            modelBuilder.Entity<Veiprod>(entity =>
            {
                entity.HasKey(e => e.IdGeral);

                entity.ToTable("veiprod");

                entity.HasIndex(e => new { e.CdVeiculo, e.CdProduto, e.CdMotor, e.CdComplemento, e.CdMontadora })
                    .HasName("unq_veiprod")
                    .IsUnique();

                entity.Property(e => e.IdGeral)
                    .HasColumnName("id_geral")
                    .ValueGeneratedNever();

                entity.Property(e => e.AnoFinal).HasColumnName("ano_final");

                entity.Property(e => e.AnoInicial).HasColumnName("ano_inicial");

                entity.Property(e => e.CdComplemento).HasColumnName("cd_complemento");

                entity.Property(e => e.CdFilial).HasColumnName("cd_filial");

                entity.Property(e => e.CdMontadora).HasColumnName("cd_montadora");

                entity.Property(e => e.CdMotor).HasColumnName("cd_motor");

                entity.Property(e => e.CdProduto)
                    .IsRequired()
                    .HasColumnName("cd_produto")
                    .HasMaxLength(15);

                entity.Property(e => e.CdVeiculo).HasColumnName("cd_veiculo");

                entity.Property(e => e.DtAtz)
                    .HasColumnName("dt_atz")
                    .HasColumnType("date")
                    .HasDefaultValueSql("CURRENT_DATE");

                entity.HasOne(d => d.CdComplementoNavigation)
                    .WithMany(p => p.Veiprod)
                    .HasForeignKey(d => d.CdComplemento)
                    .HasConstraintName("fk_veiprod_complemento");

                entity.HasOne(d => d.CdMotorNavigation)
                    .WithMany(p => p.Veiprod)
                    .HasForeignKey(d => d.CdMotor)
                    .HasConstraintName("fk_veiprod_motor");

                entity.HasOne(d => d.CdProdutoNavigation)
                    .WithMany(p => p.Veiprod)
                    .HasForeignKey(d => d.CdProduto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_veiproduto");

                entity.HasOne(d => d.Cd)
                    .WithMany(p => p.Veiprod)
                    .HasForeignKey(d => new { d.CdFilial, d.CdMontadora })
                    .HasConstraintName("fk_veiprod_montadora");

                entity.HasOne(d => d.CdNavigation)
                    .WithMany(p => p.Veiprod)
                    .HasForeignKey(d => new { d.CdFilial, d.CdVeiculo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_veicproduto");
            });
        }
    }
}
