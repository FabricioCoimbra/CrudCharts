using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CrudCharts.Migrations
{
    public partial class AddTodasTabelasPostgres : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "acesso",
                columns: table => new
                {
                    cd_filial = table.Column<int>(nullable: false),
                    nm_login = table.Column<string>(maxLength: 15, nullable: false),
                    nm_programa = table.Column<string>(maxLength: 200, nullable: false),
                    dt_atz = table.Column<DateTime>(type: "date", nullable: true, defaultValueSql: "CURRENT_DATE")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_acesso", x => new { x.nm_programa, x.nm_login, x.cd_filial });
                });

            migrationBuilder.CreateTable(
                name: "acesso_acao",
                columns: table => new
                {
                    id_geral = table.Column<long>(nullable: false),
                    cd_acesso = table.Column<string>(maxLength: 10, nullable: true),
                    nm_acao = table.Column<string>(maxLength: 200, nullable: false),
                    nm_procedimento = table.Column<string>(maxLength: 200, nullable: false),
                    fl_classificacao = table.Column<string>(maxLength: 1, nullable: false),
                    obs = table.Column<string>(nullable: true),
                    fl_alterar = table.Column<string>(maxLength: 1, nullable: true),
                    fl_inserir = table.Column<string>(maxLength: 1, nullable: true),
                    fl_excluir = table.Column<string>(maxLength: 1, nullable: true),
                    fl_permitir_filial = table.Column<string>(maxLength: 1, nullable: true),
                    cd_conexao = table.Column<int>(nullable: true),
                    tp_empresa = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_acesso_acao", x => x.id_geral);
                });

            migrationBuilder.CreateTable(
                name: "acesso_menu",
                columns: table => new
                {
                    id_geral = table.Column<long>(nullable: false),
                    nm_titulo = table.Column<string>(maxLength: 200, nullable: false),
                    id_menu_pai = table.Column<long>(nullable: true),
                    nr_ordem = table.Column<int>(nullable: false),
                    nm_tecla_atalho = table.Column<string>(maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_acesso_menu", x => x.id_geral);
                    table.ForeignKey(
                        name: "fk_acesso_menu_acesso_menu",
                        column: x => x.id_menu_pai,
                        principalTable: "acesso_menu",
                        principalColumn: "id_geral",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "administradora_bandeira",
                columns: table => new
                {
                    id_geral = table.Column<int>(nullable: false),
                    descricao = table.Column<string>(maxLength: 100, nullable: true),
                    cd_bandeira = table.Column<string>(maxLength: 3, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_administradora_bandeira", x => x.id_geral);
                });

            migrationBuilder.CreateTable(
                name: "agenda_situacao",
                columns: table => new
                {
                    cd_situacao = table.Column<int>(nullable: false),
                    nm_situacao = table.Column<string>(maxLength: 30, nullable: false),
                    dt_atz = table.Column<DateTime>(type: "date", nullable: false, defaultValueSql: "CURRENT_DATE")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_agenda_situacao", x => x.cd_situacao);
                });

            migrationBuilder.CreateTable(
                name: "alteracao_cad_item",
                columns: table => new
                {
                    id_geral = table.Column<int>(nullable: false),
                    cd_item = table.Column<string>(maxLength: 15, nullable: false),
                    nr_campo = table.Column<int>(nullable: false),
                    cont_ant = table.Column<string>(maxLength: 120, nullable: true),
                    dt_alt = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_alteracao_cad_item", x => x.id_geral);
                });

            migrationBuilder.CreateTable(
                name: "alteracao_cad_participante",
                columns: table => new
                {
                    id_geral = table.Column<int>(nullable: false),
                    cd_participante = table.Column<int>(nullable: true),
                    tp_participante = table.Column<string>(maxLength: 1, nullable: true),
                    nr_campo = table.Column<int>(nullable: true),
                    cont_ant = table.Column<string>(maxLength: 100, nullable: true),
                    dt_alt = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_alteracao_cad_participante", x => x.id_geral);
                });

            migrationBuilder.CreateTable(
                name: "anp",
                columns: table => new
                {
                    codigo = table.Column<string>(maxLength: 5, nullable: false),
                    cd_anp = table.Column<string>(maxLength: 9, nullable: false),
                    descricao_anp = table.Column<string>(maxLength: 95, nullable: true),
                    pc_glp = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    pc_gas_nacional = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    pc_gas_importado = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    codif = table.Column<string>(maxLength: 21, nullable: true),
                    vl_partida = table.Column<decimal>(type: "numeric(15,4)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_anp", x => x.codigo);
                });

            migrationBuilder.CreateTable(
                name: "anvisa",
                columns: table => new
                {
                    codigo = table.Column<string>(maxLength: 5, nullable: false),
                    cd_anvisa = table.Column<string>(maxLength: 9, nullable: false),
                    preco = table.Column<decimal>(type: "numeric(15,2)", nullable: true),
                    descricao_anvisa = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_anvisa", x => x.codigo);
                });

            migrationBuilder.CreateTable(
                name: "aplicacao",
                columns: table => new
                {
                    cd_aplicacao = table.Column<int>(nullable: false),
                    nm_aplicacao = table.Column<string>(maxLength: 80, nullable: false),
                    dt_atz = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_aplicacao", x => x.cd_aplicacao);
                });

            migrationBuilder.CreateTable(
                name: "autoriza_xml",
                columns: table => new
                {
                    cnpj = table.Column<string>(maxLength: 18, nullable: false),
                    descricao = table.Column<string>(maxLength: 120, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_autoriza_xml", x => x.cnpj);
                });

            migrationBuilder.CreateTable(
                name: "banco",
                columns: table => new
                {
                    cd_banco = table.Column<int>(nullable: false),
                    nm_banco = table.Column<string>(maxLength: 80, nullable: false),
                    nm_arq_boleto = table.Column<string>(maxLength: 20, nullable: true),
                    dt_atz = table.Column<DateTime>(type: "date", nullable: true, defaultValueSql: "CURRENT_DATE")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_banco", x => x.cd_banco);
                });

            migrationBuilder.CreateTable(
                name: "beneficio_fiscal",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false),
                    cod_ajur = table.Column<string>(maxLength: 10, nullable: true),
                    desc_ajur = table.Column<string>(maxLength: 500, nullable: true),
                    dt_ini = table.Column<DateTime>(type: "date", nullable: true),
                    dt_fim = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_beneficio_fiscal", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "carta_correcao",
                columns: table => new
                {
                    id_geral = table.Column<int>(nullable: false),
                    cd_filial = table.Column<int>(nullable: false),
                    id_nf = table.Column<int>(nullable: false),
                    fl_ent_sai = table.Column<string>(maxLength: 1, nullable: false),
                    sequencia = table.Column<int>(nullable: false),
                    chave_acesso_nfe = table.Column<string>(maxLength: 44, nullable: true),
                    protocolo = table.Column<string>(maxLength: 20, nullable: true),
                    dt_autorizacao = table.Column<DateTime>(type: "date", nullable: true),
                    hr_autorizacao = table.Column<TimeSpan>(type: "time without time zone", nullable: true),
                    correcao = table.Column<string>(nullable: true),
                    xml = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_carta_correcao", x => x.id_geral);
                });

            migrationBuilder.CreateTable(
                name: "cest",
                columns: table => new
                {
                    cd_cest = table.Column<int>(nullable: false),
                    descricao_cest = table.Column<string>(maxLength: 999, nullable: false),
                    cest = table.Column<string>(maxLength: 7, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cest", x => x.cd_cest);
                });

            migrationBuilder.CreateTable(
                name: "cfop",
                columns: table => new
                {
                    cfop = table.Column<string>(maxLength: 5, nullable: false),
                    descricao = table.Column<string>(maxLength: 200, nullable: false),
                    aplicacao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cfop", x => x.cfop);
                });

            migrationBuilder.CreateTable(
                name: "cfop_regra",
                columns: table => new
                {
                    cd_cfop_regra = table.Column<int>(nullable: false),
                    nm_cfop_regra = table.Column<string>(maxLength: 80, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cfop_regra", x => x.cd_cfop_regra);
                });

            migrationBuilder.CreateTable(
                name: "class_lista_servico",
                columns: table => new
                {
                    cd_lista_servico = table.Column<string>(maxLength: 4, nullable: false),
                    nm_lista_servico = table.Column<string>(maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_class_lista_servico", x => x.cd_lista_servico);
                });

            migrationBuilder.CreateTable(
                name: "cliente_grupo",
                columns: table => new
                {
                    cd_grupo_cliente = table.Column<short>(nullable: false),
                    nm_grupo_cliente = table.Column<string>(maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cliente_grupo", x => x.cd_grupo_cliente);
                });

            migrationBuilder.CreateTable(
                name: "cob_convenio",
                columns: table => new
                {
                    cd_convenio = table.Column<int>(nullable: false),
                    nm_convenio = table.Column<string>(maxLength: 40, nullable: false),
                    fl_remessa = table.Column<string>(maxLength: 1, nullable: false),
                    fl_retorno_remessa = table.Column<string>(maxLength: 1, nullable: false),
                    fl_emissor = table.Column<string>(maxLength: 1, nullable: false),
                    fl_aceite = table.Column<string>(maxLength: 1, nullable: false),
                    nr_convenio = table.Column<string>(maxLength: 15, nullable: false),
                    nr_sequencial = table.Column<long>(nullable: false),
                    nr_ultima_remessa = table.Column<long>(nullable: true),
                    mensagem = table.Column<string>(nullable: true),
                    fl_padrao_remessa = table.Column<string>(maxLength: 1, nullable: true),
                    fl_protesto = table.Column<string>(maxLength: 1, nullable: false),
                    nr_dias_protesto = table.Column<short>(nullable: false),
                    mensagem_protesto = table.Column<string>(nullable: true),
                    local_pagamento = table.Column<string>(maxLength: 300, nullable: false),
                    nr_agencia = table.Column<string>(maxLength: 10, nullable: true),
                    nr_dv_agencia = table.Column<string>(maxLength: 2, nullable: true),
                    nr_banco = table.Column<int>(nullable: false),
                    nr_conta = table.Column<string>(maxLength: 10, nullable: true),
                    nr_dv_conta = table.Column<string>(maxLength: 2, nullable: true),
                    nr_dv_banco = table.Column<string>(maxLength: 2, nullable: true),
                    tp_cobranca = table.Column<string>(maxLength: 3, nullable: true),
                    sg_especie = table.Column<string>(maxLength: 3, nullable: true),
                    nm_agencia = table.Column<string>(maxLength: 80, nullable: true),
                    unidade_cedente = table.Column<string>(maxLength: 80, nullable: true),
                    op_conta = table.Column<decimal>(type: "numeric(3,0)", nullable: true),
                    nm_banco = table.Column<string>(maxLength: 80, nullable: true),
                    diretorio = table.Column<string>(maxLength: 150, nullable: true),
                    cd_instrucao1 = table.Column<string>(maxLength: 2, nullable: true),
                    cd_instrucao2 = table.Column<string>(maxLength: 2, nullable: true),
                    nr_dias_baixa = table.Column<int>(nullable: true),
                    cd_caixa = table.Column<int>(nullable: true),
                    diretorio_remessa = table.Column<string>(maxLength: 200, nullable: true),
                    diretorio_retorno = table.Column<string>(maxLength: 200, nullable: true),
                    fl_deb_automatico = table.Column<string>(maxLength: 1, nullable: true),
                    fl_nr_nfs = table.Column<string>(maxLength: 1, nullable: true),
                    layout_boleto = table.Column<string>(maxLength: 200, nullable: true),
                    fl_sinc_nr_seq = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cob_convenio", x => x.cd_convenio);
                });

            migrationBuilder.CreateTable(
                name: "cob_motivo_movimento_retorno",
                columns: table => new
                {
                    id_geral = table.Column<long>(nullable: false),
                    cd_motivo = table.Column<string>(maxLength: 10, nullable: false),
                    descricao = table.Column<string>(maxLength: 255, nullable: true),
                    cd_convenio = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cob_motivo_movimento_retorno", x => x.id_geral);
                });

            migrationBuilder.CreateTable(
                name: "cob_movimento_retorno",
                columns: table => new
                {
                    id_geral = table.Column<long>(nullable: false),
                    cd_movimento = table.Column<string>(maxLength: 10, nullable: false),
                    descricao = table.Column<string>(maxLength: 255, nullable: true),
                    fl_tipo = table.Column<string>(maxLength: 1, nullable: true),
                    cd_convenio = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cob_movimento_retorno", x => x.id_geral);
                });

            migrationBuilder.CreateTable(
                name: "codigo_tributacao_municipio",
                columns: table => new
                {
                    cd_tributacao_municipio = table.Column<int>(nullable: false),
                    nm_tributacao_municipio = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_codigo_tributacao_municipio", x => x.cd_tributacao_municipio);
                });

            migrationBuilder.CreateTable(
                name: "comissao_func",
                columns: table => new
                {
                    cd_filial = table.Column<int>(nullable: false),
                    nr_documento = table.Column<int>(nullable: false),
                    nr_sequencia = table.Column<int>(nullable: false),
                    cd_funcionario = table.Column<int>(nullable: false),
                    nr_parcela = table.Column<int>(nullable: false),
                    nr_nf = table.Column<int>(nullable: true),
                    nr_cupom = table.Column<int>(nullable: true),
                    nr_sr = table.Column<int>(nullable: true),
                    vl_total = table.Column<decimal>(type: "numeric(9,2)", nullable: false),
                    pc_sobre_comissao = table.Column<decimal>(type: "numeric(9,2)", nullable: false),
                    pc_minimo = table.Column<decimal>(type: "numeric(9,2)", nullable: true),
                    pc_comissao = table.Column<decimal>(type: "numeric(9,2)", nullable: false),
                    pc_minimo_comissao = table.Column<decimal>(type: "numeric(9,2)", nullable: true),
                    vl_comissao = table.Column<decimal>(type: "numeric(9,4)", nullable: false),
                    vl_pago = table.Column<decimal>(type: "numeric(9,2)", nullable: true),
                    dt_emissao = table.Column<DateTime>(nullable: false),
                    dt_ult_pgto = table.Column<DateTime>(nullable: true),
                    pc_comissao_grupo = table.Column<decimal>(type: "numeric(9,2)", nullable: false),
                    pc_parcela = table.Column<double>(nullable: true),
                    dt_vcto = table.Column<DateTime>(nullable: false),
                    vl_base = table.Column<decimal>(type: "numeric(18,4)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_comissao_func", x => new { x.cd_filial, x.nr_documento, x.nr_sequencia, x.cd_funcionario, x.nr_parcela });
                });

            migrationBuilder.CreateTable(
                name: "conf_estudo_lucratividade",
                columns: table => new
                {
                    cd_produto = table.Column<string>(maxLength: 15, nullable: false),
                    pc_de_quebra = table.Column<double>(nullable: true),
                    pc_despesas_operacionais = table.Column<double>(nullable: true),
                    pc_csll = table.Column<double>(nullable: true),
                    pc_irrj = table.Column<double>(nullable: true),
                    pc_aliq_simples_nacional = table.Column<double>(nullable: true),
                    pc_custo_fixo = table.Column<double>(nullable: true),
                    pc_outras_despesas = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_conf_estudo_lucratividade", x => x.cd_produto);
                });

            migrationBuilder.CreateTable(
                name: "construcao",
                columns: table => new
                {
                    cd_construcao = table.Column<int>(nullable: false),
                    nm_construcao = table.Column<string>(maxLength: 80, nullable: false),
                    dt_atz = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_construcao", x => x.cd_construcao);
                });

            migrationBuilder.CreateTable(
                name: "conta_contabil",
                columns: table => new
                {
                    cd_conta = table.Column<int>(nullable: false),
                    nm_conta = table.Column<string>(maxLength: 50, nullable: false),
                    cd_historico = table.Column<int>(nullable: true),
                    dt_atz = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_conta_contabil", x => x.cd_conta);
                });

            migrationBuilder.CreateTable(
                name: "contabilista",
                columns: table => new
                {
                    cd_filial = table.Column<int>(nullable: false),
                    cd_contabilista = table.Column<int>(nullable: false),
                    nm_contabilista = table.Column<string>(maxLength: 100, nullable: false),
                    cpf = table.Column<string>(maxLength: 14, nullable: false),
                    crc = table.Column<string>(maxLength: 15, nullable: false),
                    cnpj_escritorio_cont = table.Column<string>(maxLength: 18, nullable: true),
                    cep = table.Column<string>(maxLength: 10, nullable: true),
                    endereco = table.Column<string>(maxLength: 60, nullable: true),
                    numero = table.Column<int>(nullable: true),
                    complemento = table.Column<string>(maxLength: 20, nullable: true),
                    bairro = table.Column<string>(maxLength: 30, nullable: true),
                    fone = table.Column<string>(maxLength: 16, nullable: true),
                    fax = table.Column<string>(maxLength: 16, nullable: true),
                    email = table.Column<string>(maxLength: 100, nullable: true),
                    cd_cidade = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contabilista", x => new { x.cd_filial, x.cd_contabilista });
                });

            migrationBuilder.CreateTable(
                name: "crptitulo_agrupado",
                columns: table => new
                {
                    cd_filial_o = table.Column<int>(nullable: false),
                    cd_tipo_conta_o = table.Column<int>(nullable: false),
                    nr_titulo_o = table.Column<string>(maxLength: 15, nullable: false),
                    parcela_o = table.Column<int>(nullable: false),
                    cd_clifor_o = table.Column<int>(nullable: false),
                    cd_filial_d = table.Column<int>(nullable: true),
                    cd_tipo_conta_d = table.Column<int>(nullable: true),
                    nr_titulo_d = table.Column<string>(maxLength: 15, nullable: true),
                    parcela_d = table.Column<int>(nullable: true),
                    cd_clifor_d = table.Column<int>(nullable: true),
                    dt_agrupamento = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_crptitulo_agrupado", x => new { x.cd_filial_o, x.cd_tipo_conta_o, x.nr_titulo_o, x.parcela_o, x.cd_clifor_o });
                });

            migrationBuilder.CreateTable(
                name: "cst_ipi",
                columns: table => new
                {
                    cd_cst_ipi = table.Column<string>(maxLength: 10, nullable: false),
                    descricao = table.Column<string>(maxLength: 100, nullable: false),
                    fl_tributada = table.Column<char>(nullable: false, defaultValueSql: "'N'::bpchar"),
                    fl_ent_sai = table.Column<char>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cst_ipi", x => x.cd_cst_ipi);
                });

            migrationBuilder.CreateTable(
                name: "cst_pis_cofins",
                columns: table => new
                {
                    cd_cst_pis_cofins = table.Column<string>(maxLength: 10, nullable: false),
                    descricao = table.Column<string>(maxLength: 200, nullable: false),
                    fl_tributada = table.Column<char>(nullable: false, defaultValueSql: "'N'::bpchar"),
                    fl_ent_sai = table.Column<char>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cst_pis_cofins", x => x.cd_cst_pis_cofins);
                });

            migrationBuilder.CreateTable(
                name: "cxa_abertura",
                columns: table => new
                {
                    cd_filial = table.Column<int>(nullable: false),
                    cd_caixa = table.Column<int>(nullable: false),
                    cd_funcionario = table.Column<int>(nullable: false),
                    nr_sequencial = table.Column<int>(nullable: false),
                    cd_caixa_origem = table.Column<int>(nullable: false),
                    dt_abertura = table.Column<DateTime>(type: "date", nullable: false),
                    hora_abertura = table.Column<TimeSpan>(type: "time without time zone", nullable: false),
                    dt_fechamento = table.Column<DateTime>(type: "date", nullable: true),
                    hora_fechamento = table.Column<TimeSpan>(type: "time without time zone", nullable: true),
                    vl_ini_outros = table.Column<decimal>(type: "numeric(18,4)", nullable: false),
                    vl_ini_cheque = table.Column<decimal>(type: "numeric(18,4)", nullable: false),
                    vl_ini_cartao = table.Column<decimal>(type: "numeric(18,4)", nullable: false),
                    vl_ini_dinheiro = table.Column<decimal>(type: "numeric(18,4)", nullable: false),
                    vl_fim_outros = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_fim_cheque = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_fim_cartao = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_fim_dinheiro = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    fl_fechado = table.Column<string>(maxLength: 1, nullable: false),
                    dt_atz = table.Column<DateTime>(type: "date", nullable: false, defaultValueSql: "CURRENT_DATE")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cxa_abertura", x => new { x.cd_filial, x.cd_caixa, x.cd_funcionario, x.nr_sequencial });
                });

            migrationBuilder.CreateTable(
                name: "cxa_acesso",
                columns: table => new
                {
                    cd_filial = table.Column<int>(nullable: false),
                    cd_funcionario = table.Column<int>(nullable: false),
                    cd_caixa = table.Column<int>(nullable: false),
                    leitura = table.Column<char>(nullable: true),
                    gravacao = table.Column<char>(nullable: true),
                    exclusao = table.Column<char>(nullable: true),
                    obs = table.Column<string>(maxLength: 40, nullable: true),
                    dt_atz = table.Column<DateTime>(type: "date", nullable: true, defaultValueSql: "CURRENT_DATE")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cxa_acesso", x => new { x.cd_filial, x.cd_funcionario, x.cd_caixa });
                });

            migrationBuilder.CreateTable(
                name: "estocagem",
                columns: table => new
                {
                    cd_filial = table.Column<int>(nullable: false),
                    local_estocagem = table.Column<string>(maxLength: 10, nullable: false),
                    nm_local = table.Column<string>(maxLength: 40, nullable: false),
                    dt_atz = table.Column<DateTime>(type: "date", nullable: true, defaultValueSql: "CURRENT_DATE")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_estocagem", x => new { x.cd_filial, x.local_estocagem });
                });

            migrationBuilder.CreateTable(
                name: "filial_bd",
                columns: table => new
                {
                    cd_filial = table.Column<int>(nullable: false),
                    nm_filial = table.Column<string>(maxLength: 50, nullable: false),
                    nm_servidor_bd = table.Column<string>(maxLength: 100, nullable: false),
                    nm_bd = table.Column<string>(maxLength: 200, nullable: false),
                    nm_usuario = table.Column<string>(maxLength: 50, nullable: false),
                    senha = table.Column<string>(maxLength: 100, nullable: false),
                    fl_sincronizar_contas = table.Column<bool>(nullable: false),
                    fl_dados_contas_desatualizados = table.Column<char>(nullable: false, defaultValueSql: "'I'::bpchar"),
                    nr_minutos_contas_desatualizado = table.Column<int>(nullable: false, defaultValueSql: "10")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_filial_bd", x => x.cd_filial);
                });

            migrationBuilder.CreateTable(
                name: "filial_conf_nfe_nfse",
                columns: table => new
                {
                    cd_filial = table.Column<int>(nullable: false),
                    certificado_caminho = table.Column<string>(maxLength: 100, nullable: true),
                    certificado_senha = table.Column<string>(maxLength: 20, nullable: true),
                    certificado_numero_serie = table.Column<string>(maxLength: 60, nullable: true),
                    path_schema_nfse = table.Column<string>(maxLength: 100, nullable: true),
                    path_xml_nfse = table.Column<string>(maxLength: 100, nullable: true),
                    tp_ambiente_nfse = table.Column<string>(maxLength: 1, nullable: true),
                    regime_especial_trib_nfse = table.Column<int>(nullable: true),
                    tempo_espera_consulta = table.Column<int>(nullable: true),
                    tentativas = table.Column<int>(nullable: true),
                    path_schema_nfe = table.Column<string>(maxLength: 100, nullable: true),
                    path_xml_nfe = table.Column<string>(maxLength: 100, nullable: true),
                    tp_ambiente_nfe = table.Column<string>(maxLength: 1, nullable: true),
                    visualizar = table.Column<bool>(nullable: true),
                    logoprefeitura = table.Column<string>(maxLength: 100, nullable: true),
                    logonfe = table.Column<string>(maxLength: 100, nullable: true),
                    versao_nfe = table.Column<string>(maxLength: 1, nullable: true),
                    path_xml_mdfe = table.Column<string>(maxLength: 100, nullable: true),
                    path_schema_mdfe = table.Column<string>(maxLength: 100, nullable: true),
                    tp_ambiente_mdfe = table.Column<string>(maxLength: 1, nullable: true),
                    senha_webserv = table.Column<string>(maxLength: 100, nullable: true),
                    usuario_webserv = table.Column<string>(maxLength: 100, nullable: true),
                    fl_envia_email = table.Column<string>(maxLength: 1, nullable: true),
                    email_nfe = table.Column<string>(maxLength: 100, nullable: true),
                    csc = table.Column<string>(maxLength: 36, nullable: true),
                    id_csc = table.Column<string>(maxLength: 6, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_filial_conf_nfe_nfse", x => x.cd_filial);
                });

            migrationBuilder.CreateTable(
                name: "fornecedor_unmedida",
                columns: table => new
                {
                    id_geral = table.Column<int>(nullable: false),
                    cd_fornecedor = table.Column<int>(nullable: true),
                    un_medida = table.Column<string>(maxLength: 6, nullable: true),
                    un_medida_forn = table.Column<string>(maxLength: 6, nullable: true),
                    dt_atz = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_fornecedor_unmedida", x => x.id_geral);
                });

            migrationBuilder.CreateTable(
                name: "fornprod",
                columns: table => new
                {
                    cd_filial = table.Column<int>(nullable: false),
                    cd_fornecedor = table.Column<int>(nullable: false),
                    cd_produto = table.Column<int>(nullable: false),
                    dt_atz = table.Column<DateTime>(type: "date", nullable: true, defaultValueSql: "CURRENT_DATE")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_fornprod", x => new { x.cd_filial, x.cd_fornecedor, x.cd_produto });
                });

            migrationBuilder.CreateTable(
                name: "grupo_comissao",
                columns: table => new
                {
                    cd_grupo_comissao = table.Column<int>(nullable: false),
                    descricao = table.Column<string>(maxLength: 40, nullable: false),
                    pc_comissao = table.Column<decimal>(type: "numeric(9,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_grupo_comissao", x => x.cd_grupo_comissao);
                });

            migrationBuilder.CreateTable(
                name: "grupo_operacao_es",
                columns: table => new
                {
                    cd_grupo = table.Column<string>(maxLength: 2, nullable: false),
                    nm_grupo = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_grupo_operacao_es", x => x.cd_grupo);
                });

            migrationBuilder.CreateTable(
                name: "gruprod",
                columns: table => new
                {
                    cd_gruprod = table.Column<int>(nullable: false),
                    nm_gruprod = table.Column<string>(maxLength: 40, nullable: false),
                    dt_atz = table.Column<DateTime>(type: "date", nullable: true, defaultValueSql: "CURRENT_DATE")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gruprod", x => x.cd_gruprod);
                });

            migrationBuilder.CreateTable(
                name: "HASH",
                columns: table => new
                {
                    id_geral = table.Column<int>(nullable: false),
                    nm_tabela = table.Column<string>(maxLength: 30, nullable: false),
                    HASH = table.Column<string>(maxLength: 70, nullable: false),
                    fl_valido = table.Column<string>(maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HASH", x => x.id_geral);
                });

            migrationBuilder.CreateTable(
                name: "help_atz",
                columns: table => new
                {
                    id_geral = table.Column<int>(nullable: false),
                    descricao = table.Column<string>(nullable: false),
                    versao_bd = table.Column<int>(nullable: false),
                    versao_sistema = table.Column<string>(maxLength: 12, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_help_atz", x => x.id_geral);
                });

            migrationBuilder.CreateTable(
                name: "impfiscal",
                columns: table => new
                {
                    cd_impfiscal = table.Column<int>(nullable: false),
                    nm_impfiscal = table.Column<string>(maxLength: 40, nullable: false),
                    cd_modelo = table.Column<int>(nullable: false),
                    nr_serie = table.Column<string>(maxLength: 80, nullable: false),
                    porta_comunicacao = table.Column<string>(maxLength: 10, nullable: false),
                    dt_atz = table.Column<DateTime>(type: "date", nullable: true, defaultValueSql: "CURRENT_DATE"),
                    nm_dinheiro = table.Column<string>(maxLength: 25, nullable: true),
                    nm_cheque = table.Column<string>(maxLength: 25, nullable: true),
                    nm_cartao = table.Column<string>(maxLength: 25, nullable: true),
                    nm_outros = table.Column<string>(maxLength: 25, nullable: true),
                    nm_a_prazo = table.Column<string>(maxLength: 25, nullable: true),
                    fl_intervencao = table.Column<bool>(nullable: false),
                    nr_pdv = table.Column<int>(nullable: true),
                    nm_modelo = table.Column<string>(maxLength: 20, nullable: false),
                    fl_mf_adicional = table.Column<string>(maxLength: 1, nullable: false),
                    cd_usuario_ecf = table.Column<int>(nullable: false),
                    cniee = table.Column<string>(maxLength: 6, nullable: false),
                    tipo = table.Column<string>(maxLength: 10, nullable: false),
                    nm_marca = table.Column<string>(maxLength: 20, nullable: false),
                    versao_sb = table.Column<string>(maxLength: 11, nullable: false),
                    dt_instalacao_sb = table.Column<DateTime>(type: "date", nullable: true),
                    hr_instalacao_sb = table.Column<TimeSpan>(type: "time without time zone", nullable: true),
                    fl_lmf_automatica = table.Column<string>(maxLength: 1, nullable: true),
                    nm_consulta_cheque = table.Column<string>(maxLength: 25, nullable: true),
                    hash_impfiscal_e1 = table.Column<string>(maxLength: 70, nullable: true),
                    hash_impfiscal_r1 = table.Column<string>(maxLength: 70, nullable: true),
                    hash_impfiscal_r2 = table.Column<string>(maxLength: 70, nullable: true),
                    hash_impfiscal_r3 = table.Column<string>(maxLength: 70, nullable: true),
                    hash_impfiscal_r4 = table.Column<string>(maxLength: 70, nullable: true),
                    hash_impfiscal_r5 = table.Column<string>(maxLength: 70, nullable: true),
                    hash_impfiscal_r6 = table.Column<string>(maxLength: 70, nullable: true),
                    hash_impfiscal_r7 = table.Column<string>(maxLength: 70, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_impfiscal", x => x.cd_impfiscal);
                });

            migrationBuilder.CreateTable(
                name: "log_sistema",
                columns: table => new
                {
                    id_geral = table.Column<long>(nullable: false),
                    dt_hr_exclusao = table.Column<DateTime>(type: "date", nullable: true),
                    cd_usuario = table.Column<int>(nullable: true),
                    tabela = table.Column<string>(maxLength: 40, nullable: true),
                    observacao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_log_sistema", x => x.id_geral);
                });

            migrationBuilder.CreateTable(
                name: "marca",
                columns: table => new
                {
                    cd_marca = table.Column<int>(nullable: false),
                    nm_marca = table.Column<string>(maxLength: 40, nullable: false),
                    dt_atz = table.Column<DateTime>(type: "date", nullable: true, defaultValueSql: "CURRENT_DATE")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_marca", x => x.cd_marca);
                });

            migrationBuilder.CreateTable(
                name: "medida",
                columns: table => new
                {
                    cd_medida = table.Column<int>(nullable: false),
                    nm_medida = table.Column<string>(maxLength: 80, nullable: false),
                    dt_atz = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_medida", x => x.cd_medida);
                });

            migrationBuilder.CreateTable(
                name: "mensagem_nota",
                columns: table => new
                {
                    cd_mensagem = table.Column<int>(nullable: false),
                    nm_mensagem = table.Column<string>(maxLength: 30, nullable: true),
                    fl_fiscal = table.Column<string>(maxLength: 1, nullable: false),
                    mensagem = table.Column<string>(nullable: false),
                    fl_informacoes_fisco = table.Column<char>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mensagem_nota", x => x.cd_mensagem);
                });

            migrationBuilder.CreateTable(
                name: "modelo",
                columns: table => new
                {
                    cd_modelo = table.Column<int>(nullable: false),
                    nm_modelo = table.Column<string>(maxLength: 80, nullable: false),
                    dt_atz = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_modelo", x => x.cd_modelo);
                });

            migrationBuilder.CreateTable(
                name: "modelo_dcto",
                columns: table => new
                {
                    cd_modelo = table.Column<string>(maxLength: 3, nullable: false),
                    nm_modelo = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_modelo_dcto", x => x.cd_modelo);
                });

            migrationBuilder.CreateTable(
                name: "montadora",
                columns: table => new
                {
                    cd_filial = table.Column<int>(nullable: false),
                    cd_montadora = table.Column<int>(nullable: false),
                    nm_montadora = table.Column<string>(maxLength: 40, nullable: false),
                    dt_atz = table.Column<DateTime>(type: "date", nullable: true, defaultValueSql: "CURRENT_DATE")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_montadora", x => new { x.cd_filial, x.cd_montadora });
                });

            migrationBuilder.CreateTable(
                name: "motivo_devolucao",
                columns: table => new
                {
                    cd_motivo_devolucao = table.Column<int>(nullable: false),
                    nm_motivo_devolucao = table.Column<string>(maxLength: 50, nullable: false),
                    dt_atz = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_motivo_devolucao", x => x.cd_motivo_devolucao);
                });

            migrationBuilder.CreateTable(
                name: "movimento_cxa_vinculo",
                columns: table => new
                {
                    id_geral = table.Column<int>(nullable: false),
                    cd_filial_o = table.Column<int>(nullable: false),
                    nr_lcto_o = table.Column<int>(nullable: false),
                    cd_caixa_o = table.Column<int>(nullable: false),
                    cd_filial_d = table.Column<int>(nullable: false),
                    nr_lcto_d = table.Column<int>(nullable: false),
                    cd_caixa_d = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_movimento_cxa_vinculo", x => x.id_geral);
                });

            migrationBuilder.CreateTable(
                name: "nf_contabil_c",
                columns: table => new
                {
                    id_geral = table.Column<int>(nullable: false),
                    cd_filial = table.Column<int>(nullable: true),
                    id_nfc = table.Column<int>(nullable: true),
                    fl_entrada_saida = table.Column<string>(maxLength: 1, nullable: true),
                    nr_nf = table.Column<long>(nullable: true),
                    nr_cupom = table.Column<int>(nullable: true),
                    cd_clifor = table.Column<int>(nullable: true),
                    serie_nf = table.Column<string>(maxLength: 3, nullable: true),
                    clifor_cnpj_cpf = table.Column<string>(maxLength: 18, nullable: true),
                    clifor_ie_rg = table.Column<string>(maxLength: 18, nullable: true),
                    uf_destino = table.Column<string>(maxLength: 2, nullable: true),
                    uf_origem = table.Column<string>(maxLength: 2, nullable: true),
                    dt_emissao = table.Column<DateTime>(type: "date", nullable: true),
                    cd_modelo = table.Column<string>(maxLength: 3, nullable: true),
                    fl_impresso = table.Column<string>(maxLength: 1, nullable: true),
                    icms_normal_base = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    icms_normal_vl = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    icms_proprio_base = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    icms_proprio_vl = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    icms_st_base = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    icms_st_vl = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    iss_base = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    iss_vl = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    ipi_base = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    ipi_vl = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    pis_vl_base = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    pis_vl = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    cofins_vl_base = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    cofins_vl = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    vl_desconto_item = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    vl_desconto = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    vl_acrescimo = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    vl_seguro = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    vl_frete = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    vl_total = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    vl_isento_itens = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    vl_outros_itens = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    ecf_cd = table.Column<int>(nullable: true),
                    ecf_nr_fabricacao = table.Column<string>(maxLength: 40, nullable: true),
                    ecf_nr_pdv = table.Column<int>(nullable: true),
                    fl_cancelado = table.Column<string>(maxLength: 1, nullable: true),
                    obs = table.Column<string>(nullable: true),
                    nm_operacao = table.Column<string>(maxLength: 40, nullable: true),
                    vl_mercadorias = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    vl_servicos = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    cond_pgto = table.Column<int>(nullable: true),
                    cd_transportadora = table.Column<int>(nullable: true),
                    dt_entrada_saida = table.Column<DateTime>(type: "date", nullable: true),
                    frete_vl_icm = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    frete_cfop = table.Column<string>(maxLength: 10, nullable: true),
                    sub_serie = table.Column<string>(maxLength: 3, nullable: true),
                    icms_st_ant_base = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    icms_st_ant_vl = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    hr_emissao = table.Column<TimeSpan>(type: "time without time zone", nullable: true),
                    ecf_nr_coo_cupom = table.Column<int>(nullable: true),
                    fl_simples = table.Column<string>(maxLength: 1, nullable: true),
                    nfe_chave_acesso = table.Column<string>(maxLength: 44, nullable: true),
                    nfe_nr_protocolo = table.Column<string>(maxLength: 50, nullable: true),
                    nfe_dt_processamento = table.Column<DateTime>(type: "date", nullable: true),
                    nfe_tp_emissao = table.Column<int>(nullable: true),
                    nfe_nr_lote = table.Column<string>(maxLength: 15, nullable: true),
                    nfe_nr_recibo = table.Column<string>(maxLength: 15, nullable: true),
                    vl_fcp = table.Column<decimal>(type: "numeric(13,2)", nullable: true),
                    vl_fcp_st = table.Column<decimal>(type: "numeric(13,2)", nullable: true),
                    vl_fcp_st_retido = table.Column<decimal>(type: "numeric(13,2)", nullable: true),
                    vl_icms_uf_dest = table.Column<decimal>(type: "numeric(13,2)", nullable: true),
                    vl_icms_uf_remet = table.Column<decimal>(type: "numeric(13,2)", nullable: true),
                    vl_fcp_uf_dest = table.Column<decimal>(type: "numeric(13,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nf_contabil_c", x => x.id_geral);
                });

            migrationBuilder.CreateTable(
                name: "nf_referenciada",
                columns: table => new
                {
                    id_geral = table.Column<int>(nullable: false),
                    fl_entrada_saida = table.Column<string>(maxLength: 1, nullable: true),
                    nr_documento = table.Column<int>(nullable: true),
                    fl_entrada_saida_ref = table.Column<string>(maxLength: 1, nullable: true),
                    nr_documento_ref = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nf_referenciada", x => x.id_geral);
                });

            migrationBuilder.CreateTable(
                name: "nf_xml",
                columns: table => new
                {
                    id_nf = table.Column<int>(nullable: false),
                    fl_ent_sai = table.Column<char>(nullable: false),
                    xml = table.Column<string>(nullable: true),
                    dt_atz = table.Column<DateTime>(type: "date", nullable: true, defaultValueSql: "CURRENT_DATE"),
                    xml_canc = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nf_xml", x => new { x.id_nf, x.fl_ent_sai });
                });

            migrationBuilder.CreateTable(
                name: "nfe_contingencia",
                columns: table => new
                {
                    id_geral = table.Column<int>(nullable: false),
                    cd_status = table.Column<int>(nullable: true),
                    dt_inicio = table.Column<DateTime>(type: "date", nullable: true),
                    hr_inicio = table.Column<TimeSpan>(type: "time without time zone", nullable: true),
                    dt_fim = table.Column<DateTime>(type: "date", nullable: true),
                    hr_fim = table.Column<TimeSpan>(type: "time without time zone", nullable: true),
                    motivo = table.Column<string>(maxLength: 50, nullable: true),
                    cd_filial = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nfe_contingencia", x => x.id_geral);
                });

            migrationBuilder.CreateTable(
                name: "nfe_inutilizacao",
                columns: table => new
                {
                    id_geral = table.Column<int>(nullable: false),
                    nr_nf = table.Column<int>(nullable: false),
                    serie_nf = table.Column<string>(maxLength: 3, nullable: false),
                    dt_processamento_inut = table.Column<DateTime>(type: "date", nullable: false),
                    nr_protocolo_inut = table.Column<string>(maxLength: 15, nullable: false),
                    cd_usuario = table.Column<int>(nullable: false),
                    motivo = table.Column<string>(maxLength: 80, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nfe_inutilizacao", x => x.id_geral);
                });

            migrationBuilder.CreateTable(
                name: "nfsc_servico",
                columns: table => new
                {
                    nr_documento = table.Column<int>(nullable: false),
                    cd_cidade_prestacao = table.Column<int>(nullable: true),
                    cd_nat_operacao = table.Column<int>(nullable: true),
                    incentivo_cultural = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nfsc_servico", x => x.nr_documento);
                });

            migrationBuilder.CreateTable(
                name: "nfsicomplemento",
                columns: table => new
                {
                    cd_filial = table.Column<int>(nullable: false),
                    nr_os = table.Column<int>(nullable: false),
                    nr_sequencia = table.Column<int>(nullable: false),
                    complemento = table.Column<string>(nullable: true),
                    dt_atz = table.Column<DateTime>(type: "date", nullable: true, defaultValueSql: "CURRENT_DATE")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nfsicomplemento", x => new { x.cd_filial, x.nr_os, x.nr_sequencia });
                });

            migrationBuilder.CreateTable(
                name: "nr_serie_nfs",
                columns: table => new
                {
                    nr_serie = table.Column<string>(maxLength: 3, nullable: false),
                    nr_ult_nfsaida = table.Column<int>(nullable: true),
                    nr_ult_nfservico = table.Column<long>(nullable: true),
                    end_arquivo_modelo = table.Column<string>(nullable: true),
                    fl_bloco_manual = table.Column<string>(maxLength: 1, nullable: true, defaultValueSql: "'N'::character varying"),
                    nr_aidf = table.Column<string>(maxLength: 20, nullable: true),
                    end_arquivo_fsda = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nr_serie_nfs", x => x.nr_serie);
                });

            migrationBuilder.CreateTable(
                name: "nsu",
                columns: table => new
                {
                    id_geral = table.Column<int>(nullable: false),
                    nsu = table.Column<string>(maxLength: 10, nullable: false),
                    nr_documento = table.Column<int>(nullable: false),
                    serie = table.Column<string>(maxLength: 3, nullable: false),
                    cd_clifor = table.Column<int>(nullable: false),
                    fl_tipo = table.Column<string>(maxLength: 1, nullable: false),
                    dt_emissao = table.Column<DateTime>(type: "date", nullable: false),
                    hr_emissao = table.Column<TimeSpan>(type: "time without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nsu", x => x.id_geral);
                });

            migrationBuilder.CreateTable(
                name: "orcamento_agrupado",
                columns: table => new
                {
                    nr_os = table.Column<int>(nullable: false),
                    nr_os_agrupada = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orcamento_agrupado", x => new { x.nr_os, x.nr_os_agrupada });
                });

            migrationBuilder.CreateTable(
                name: "orcamento_dav",
                columns: table => new
                {
                    nr_os = table.Column<int>(nullable: false),
                    nr_sequencia = table.Column<int>(nullable: false),
                    nr_dav = table.Column<int>(nullable: true),
                    nr_coo_dav = table.Column<int>(nullable: true),
                    nr_coo_cupom = table.Column<int>(nullable: true),
                    cd_usuario = table.Column<int>(nullable: true),
                    dt_atz = table.Column<DateTime>(type: "date", nullable: true),
                    cd_impfiscal = table.Column<int>(nullable: true),
                    mf_adicional = table.Column<string>(maxLength: 1, nullable: true),
                    fl_cancelado = table.Column<string>(maxLength: 1, nullable: true),
                    vl_total_dav = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    nr_ccf_cupom = table.Column<int>(nullable: true),
                    hash_orcamento_dav_d2 = table.Column<string>(maxLength: 70, nullable: true),
                    hash_orcamento_dav_d3 = table.Column<string>(maxLength: 70, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orcamento_dav", x => new { x.nr_os, x.nr_sequencia });
                });

            migrationBuilder.CreateTable(
                name: "orcamento_frete",
                columns: table => new
                {
                    cd_filial = table.Column<int>(nullable: false),
                    nr_os = table.Column<int>(nullable: false),
                    cd_transportadora = table.Column<int>(nullable: false),
                    tp_frete = table.Column<string>(maxLength: 1, nullable: false),
                    marca_volumes = table.Column<string>(maxLength: 15, nullable: true),
                    especie_volumes = table.Column<string>(maxLength: 15, nullable: true),
                    qt_volumes = table.Column<double>(nullable: true),
                    nr_volumes = table.Column<double>(nullable: true),
                    peso_liquido = table.Column<double>(nullable: true),
                    peso_total = table.Column<double>(nullable: true),
                    placa_transp = table.Column<string>(maxLength: 8, nullable: true),
                    uf_placa_transp = table.Column<string>(maxLength: 2, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orcamento_frete", x => new { x.cd_filial, x.nr_os });
                });

            migrationBuilder.CreateTable(
                name: "orcamento_imagem",
                columns: table => new
                {
                    id_geral = table.Column<int>(nullable: false),
                    nr_os = table.Column<int>(nullable: false),
                    obs = table.Column<string>(maxLength: 200, nullable: true),
                    imagem = table.Column<string>(nullable: false),
                    dt_atz = table.Column<DateTime>(type: "date", nullable: false, defaultValueSql: "CURRENT_DATE")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orcamento_imagem", x => new { x.id_geral, x.nr_os });
                });

            migrationBuilder.CreateTable(
                name: "orcamento_situacao",
                columns: table => new
                {
                    cd_filial = table.Column<int>(nullable: false),
                    nr_os = table.Column<int>(nullable: false),
                    dt_modificacao = table.Column<DateTime>(nullable: false),
                    cd_funcionario = table.Column<int>(nullable: false),
                    cd_situacao = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orcamento_situacao", x => new { x.cd_filial, x.nr_os, x.dt_modificacao });
                });

            migrationBuilder.CreateTable(
                name: "ordem_producao_c",
                columns: table => new
                {
                    id_geral = table.Column<long>(nullable: false),
                    cd_filial = table.Column<int>(nullable: false),
                    nr_ordem_producao = table.Column<int>(nullable: false),
                    dt_emissao = table.Column<DateTime>(type: "date", nullable: true),
                    dt_previsao = table.Column<DateTime>(type: "date", nullable: true),
                    cd_situacao = table.Column<string>(maxLength: 1, nullable: true),
                    cd_funcionario = table.Column<int>(nullable: true),
                    nr_maquina = table.Column<string>(maxLength: 100, nullable: true),
                    turno = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ordem_producao_c", x => x.id_geral);
                });

            migrationBuilder.CreateTable(
                name: "pedido_afv_c",
                columns: table => new
                {
                    cd_filial = table.Column<int>(nullable: false),
                    nr_pedido = table.Column<int>(nullable: false),
                    cd_clifor = table.Column<int>(nullable: true),
                    vl_acrescimos = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_descontos = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_mercadorias = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_servicos = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_total = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    cd_condpgto = table.Column<int>(nullable: false),
                    vl_entrada = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    dt_emissao = table.Column<DateTime>(type: "date", nullable: true),
                    dt_validade = table.Column<DateTime>(type: "date", nullable: true),
                    cd_usuario = table.Column<int>(nullable: true),
                    dt_atz = table.Column<DateTime>(type: "date", nullable: true, defaultValueSql: "CURRENT_DATE"),
                    motivo_cancelamento = table.Column<string>(maxLength: 80, nullable: true),
                    obs = table.Column<string>(nullable: true),
                    indice_preco = table.Column<short>(nullable: false),
                    vl_ipi = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    cd_situacao = table.Column<int>(nullable: false),
                    fl_agrupado = table.Column<bool>(nullable: false),
                    fl_cancelado = table.Column<bool>(nullable: false),
                    fl_finalizado = table.Column<bool>(nullable: false),
                    dt_entrega = table.Column<DateTime>(type: "date", nullable: true),
                    fl_transmitido = table.Column<char>(nullable: true, defaultValueSql: "'N'::bpchar"),
                    fl_gerado = table.Column<bool>(nullable: true),
                    nr_os_gerada = table.Column<int>(nullable: true),
                    nr_dav_gerada = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pedido_afv_c", x => new { x.cd_filial, x.nr_pedido });
                });

            migrationBuilder.CreateTable(
                name: "pedido_afv_i",
                columns: table => new
                {
                    cd_filial = table.Column<int>(nullable: false),
                    nr_pedido = table.Column<int>(nullable: false),
                    nr_sequencia = table.Column<int>(nullable: false),
                    cd_produto = table.Column<string>(maxLength: 15, nullable: false),
                    nm_produto = table.Column<string>(maxLength: 60, nullable: true),
                    un_medida = table.Column<string>(maxLength: 3, nullable: true),
                    fl_servico = table.Column<string>(maxLength: 1, nullable: true),
                    qt_produto = table.Column<double>(nullable: true),
                    vl_bruto = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    pc_desconto = table.Column<decimal>(type: "numeric(9,2)", nullable: true),
                    vl_liquido = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_total = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    dt_emissao = table.Column<DateTime>(type: "date", nullable: false, defaultValueSql: "CURRENT_DATE"),
                    complemento = table.Column<string>(nullable: true),
                    cd_funcionario = table.Column<int>(nullable: true),
                    vl_custo = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    dt_atz = table.Column<DateTime>(type: "date", nullable: true, defaultValueSql: "CURRENT_DATE"),
                    cd_original = table.Column<string>(maxLength: 20, nullable: true),
                    cd_barras = table.Column<string>(maxLength: 20, nullable: true),
                    placa_veiculo = table.Column<string>(maxLength: 8, nullable: true),
                    kilometragem = table.Column<int>(nullable: true),
                    vl_ipi = table.Column<decimal>(type: "numeric(18,4)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pedido_afv_i", x => new { x.cd_filial, x.nr_pedido, x.nr_sequencia });
                });

            migrationBuilder.CreateTable(
                name: "pedido_c",
                columns: table => new
                {
                    nr_pedido = table.Column<int>(nullable: false),
                    cd_funcionario = table.Column<int>(nullable: true),
                    fl_situacao = table.Column<char>(nullable: false),
                    dt_emissao = table.Column<DateTime>(type: "date", nullable: false),
                    cd_fornecedor = table.Column<int>(nullable: false),
                    dt_validade = table.Column<DateTime>(type: "date", nullable: true),
                    cd_condpgto = table.Column<int>(nullable: false),
                    obs = table.Column<string>(nullable: true),
                    motivo_cancelamento = table.Column<string>(nullable: true),
                    vl_total = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    dt_atz = table.Column<DateTime>(type: "date", nullable: false, defaultValueSql: "CURRENT_DATE")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pedido_c", x => x.nr_pedido);
                });

            migrationBuilder.CreateTable(
                name: "pedido_frete",
                columns: table => new
                {
                    cd_filial = table.Column<int>(nullable: false),
                    nr_pedido = table.Column<int>(nullable: false),
                    cd_transportadora = table.Column<int>(nullable: false),
                    tp_frete = table.Column<string>(maxLength: 1, nullable: false),
                    marca_volumes = table.Column<string>(maxLength: 15, nullable: true),
                    especie_volumes = table.Column<string>(maxLength: 15, nullable: true),
                    qt_volumes = table.Column<double>(nullable: true),
                    nr_volumes = table.Column<double>(nullable: true),
                    peso_liquido = table.Column<double>(nullable: true),
                    peso_total = table.Column<double>(nullable: true),
                    placa_transp = table.Column<string>(maxLength: 8, nullable: true),
                    uf_placa_transp = table.Column<string>(maxLength: 2, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pedido_frete", x => new { x.cd_filial, x.nr_pedido });
                });

            migrationBuilder.CreateTable(
                name: "perfil_acesso",
                columns: table => new
                {
                    cd_perfil = table.Column<int>(nullable: false),
                    nm_perfil = table.Column<string>(maxLength: 40, nullable: false),
                    fl_acesso_irrestrito = table.Column<string>(maxLength: 1, nullable: true),
                    fl_ativo = table.Column<string>(maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_perfil_acesso", x => x.cd_perfil);
                });

            migrationBuilder.CreateTable(
                name: "pl_historico",
                columns: table => new
                {
                    cd_filial = table.Column<int>(nullable: false),
                    cd_historico = table.Column<int>(nullable: false),
                    descricao = table.Column<string>(maxLength: 40, nullable: false),
                    complemento = table.Column<bool>(nullable: true),
                    dt_atz = table.Column<DateTime>(type: "date", nullable: true, defaultValueSql: "CURRENT_DATE")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pl_historico", x => new { x.cd_filial, x.cd_historico });
                });

            migrationBuilder.CreateTable(
                name: "prod_original",
                columns: table => new
                {
                    cd_produto_alt = table.Column<string>(maxLength: 20, nullable: false),
                    cd_produto_ori = table.Column<string>(maxLength: 20, nullable: false),
                    dt_atz = table.Column<DateTime>(type: "date", nullable: true, defaultValueSql: "CURRENT_DATE")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_prod_original", x => new { x.cd_produto_alt, x.cd_produto_ori });
                });

            migrationBuilder.CreateTable(
                name: "prod_relacionado",
                columns: table => new
                {
                    cd_produto = table.Column<string>(maxLength: 15, nullable: false),
                    cd_relacionado = table.Column<string>(maxLength: 15, nullable: false),
                    qt_relacionado = table.Column<double>(nullable: true),
                    dt_atz = table.Column<DateTime>(type: "date", nullable: true, defaultValueSql: "CURRENT_DATE")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_prod_relacionado", x => new { x.cd_produto, x.cd_relacionado });
                });

            migrationBuilder.CreateTable(
                name: "produto_altprec",
                columns: table => new
                {
                    id_geral = table.Column<int>(nullable: false),
                    cd_produto = table.Column<string>(maxLength: 15, nullable: false),
                    cd_funcionario = table.Column<int>(nullable: false),
                    dt_alteracao = table.Column<DateTime>(type: "date", nullable: false),
                    nm_form = table.Column<string>(maxLength: 40, nullable: false),
                    desc_form = table.Column<string>(maxLength: 60, nullable: false),
                    preco_venda_ant = table.Column<decimal>(type: "numeric(18,4)", nullable: false),
                    preco_venda_novo = table.Column<decimal>(type: "numeric(18,4)", nullable: false),
                    preco_venda_min_ant = table.Column<decimal>(type: "numeric(18,4)", nullable: false),
                    preco_venda_min_novo = table.Column<decimal>(type: "numeric(18,4)", nullable: false),
                    preco_venda_flex_max_ant = table.Column<decimal>(type: "numeric(18,4)", nullable: false),
                    preco_venda_flex_max_novo = table.Column<decimal>(type: "numeric(18,4)", nullable: false),
                    preco_venda_flex_min_ant = table.Column<decimal>(type: "numeric(18,4)", nullable: false),
                    preco_venda_flex_min_novo = table.Column<decimal>(type: "numeric(18,4)", nullable: false),
                    cd_tabela_preco = table.Column<int>(nullable: true),
                    hr_alteracao = table.Column<TimeSpan>(type: "time without time zone", nullable: true),
                    id_nfec = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_produto_altprec", x => x.id_geral);
                });

            migrationBuilder.CreateTable(
                name: "produto_class_fiscal",
                columns: table => new
                {
                    cd_class_fiscal = table.Column<string>(maxLength: 5, nullable: false),
                    nm_class_fiscal = table.Column<string>(maxLength: 10, nullable: false),
                    dt_atz = table.Column<DateTime>(type: "date", nullable: true),
                    descricao = table.Column<string>(type: "character(200)", nullable: true),
                    aliq_ipi = table.Column<double>(nullable: true),
                    cst_ipi_compra = table.Column<string>(maxLength: 2, nullable: true),
                    cst_ipi_venda = table.Column<string>(maxLength: 2, nullable: true),
                    cst_pis_compra = table.Column<string>(maxLength: 2, nullable: true),
                    cst_pis_venda = table.Column<string>(maxLength: 2, nullable: true),
                    cst_cofins_compra = table.Column<string>(maxLength: 2, nullable: true),
                    cst_cofins_venda = table.Column<string>(maxLength: 2, nullable: true),
                    fl_calcular_pis_cofins = table.Column<string>(maxLength: 1, nullable: true),
                    fl_reducao_mva_simples = table.Column<string>(maxLength: 1, nullable: true),
                    cd_enquadramento_compra = table.Column<string>(maxLength: 3, nullable: true),
                    cd_enquadramento_venda = table.Column<string>(maxLength: 3, nullable: true),
                    cd_cest = table.Column<int>(nullable: true),
                    un_trib = table.Column<string>(maxLength: 6, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_produto_class_fiscal", x => x.cd_class_fiscal);
                });

            migrationBuilder.CreateTable(
                name: "produto_class_fiscal_ibpt",
                columns: table => new
                {
                    id_geral = table.Column<int>(nullable: false),
                    codigo = table.Column<string>(maxLength: 10, nullable: true),
                    tabela = table.Column<int>(nullable: true),
                    aliq_nac_fed = table.Column<decimal>(type: "numeric(5,2)", nullable: true),
                    aliq_imp_fed = table.Column<decimal>(type: "numeric(5,2)", nullable: true),
                    aliq_est = table.Column<decimal>(type: "numeric(5,2)", nullable: true),
                    aliq_mun = table.Column<decimal>(type: "numeric(5,2)", nullable: true),
                    dt_inicio = table.Column<DateTime>(nullable: true),
                    dt_final = table.Column<DateTime>(nullable: true),
                    versao_ibpt = table.Column<string>(maxLength: 10, nullable: true),
                    uf = table.Column<string>(maxLength: 3, nullable: true),
                    fonte = table.Column<string>(maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_produto_class_fiscal_ibpt", x => x.id_geral);
                });

            migrationBuilder.CreateTable(
                name: "produto_tipo",
                columns: table => new
                {
                    cd_tipo = table.Column<string>(maxLength: 2, nullable: false),
                    descricao = table.Column<string>(maxLength: 50, nullable: false),
                    fl_permite_composicao = table.Column<bool>(nullable: true),
                    fl_controlar_estoq = table.Column<bool>(nullable: true),
                    fl_inventario = table.Column<bool>(nullable: true),
                    fl_permitevenda = table.Column<string>(maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_produto_tipo", x => x.cd_tipo);
                });

            migrationBuilder.CreateTable(
                name: "produto_unidade",
                columns: table => new
                {
                    cd_produto = table.Column<string>(maxLength: 15, nullable: false),
                    un_medida = table.Column<string>(maxLength: 6, nullable: false),
                    fator_conversao = table.Column<double>(nullable: false),
                    cd_barras = table.Column<string>(maxLength: 20, nullable: true),
                    fl_tipo = table.Column<string>(maxLength: 1, nullable: true),
                    dt_atz = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_produto_unidade", x => new { x.cd_produto, x.un_medida });
                });

            migrationBuilder.CreateTable(
                name: "protocolo_icms",
                columns: table => new
                {
                    id_geral = table.Column<int>(nullable: false),
                    nr_protocolo = table.Column<string>(maxLength: 10, nullable: false),
                    descricao = table.Column<string>(maxLength: 50, nullable: true),
                    dt_protocolo = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_protocolo_icms", x => x.id_geral);
                });

            migrationBuilder.CreateTable(
                name: "recibo",
                columns: table => new
                {
                    nr_recibo = table.Column<int>(nullable: false),
                    nm_pago = table.Column<string>(maxLength: 100, nullable: false),
                    proveniente = table.Column<string>(maxLength: 1023, nullable: true),
                    dt_pgto = table.Column<DateTime>(type: "date", nullable: false, defaultValueSql: "CURRENT_DATE"),
                    vl_pago = table.Column<decimal>(type: "numeric(18,4)", nullable: false),
                    dt_atz = table.Column<DateTime>(type: "date", nullable: true, defaultValueSql: "CURRENT_DATE"),
                    cd_filial = table.Column<int>(nullable: true),
                    assinatura = table.Column<string>(maxLength: 80, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_recibo", x => x.nr_recibo);
                });

            migrationBuilder.CreateTable(
                name: "reducaoz",
                columns: table => new
                {
                    nr_serie_ecf = table.Column<string>(maxLength: 20, nullable: false),
                    al_01 = table.Column<decimal>(type: "numeric(4,2)", nullable: true),
                    al_02 = table.Column<decimal>(type: "numeric(4,2)", nullable: true),
                    al_03 = table.Column<decimal>(type: "numeric(4,2)", nullable: true),
                    al_04 = table.Column<decimal>(type: "numeric(4,2)", nullable: true),
                    al_05 = table.Column<decimal>(type: "numeric(4,2)", nullable: true),
                    al_06 = table.Column<decimal>(type: "numeric(4,2)", nullable: true),
                    vl_01 = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_02 = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_03 = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_04 = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_05 = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_06 = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_substituicao = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_isento = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_cancelamento = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_nao_inc = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_desconto = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_issqn = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_total_geral = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_bruto_dia = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    nr_pdv = table.Column<int>(nullable: false),
                    contador_z = table.Column<int>(nullable: true),
                    contador_inicial = table.Column<int>(nullable: true),
                    contador_final = table.Column<int>(nullable: true),
                    contador_ro = table.Column<int>(nullable: true),
                    dt_reducao = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reducaoz", x => new { x.nr_serie_ecf, x.nr_pdv, x.dt_reducao });
                });

            migrationBuilder.CreateTable(
                name: "ref_nota_produtor",
                columns: table => new
                {
                    cd_filial = table.Column<int>(nullable: false),
                    cod_referencia = table.Column<int>(nullable: false),
                    id_nfec = table.Column<int>(nullable: false),
                    data_nf_produtor = table.Column<string>(maxLength: 4, nullable: false),
                    modelo_nf_produtor = table.Column<string>(maxLength: 4, nullable: false),
                    serie_nf_produtor = table.Column<string>(maxLength: 4, nullable: false),
                    nr_nf_produtor = table.Column<string>(maxLength: 18, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ref_nota_produtor", x => x.cod_referencia);
                });

            migrationBuilder.CreateTable(
                name: "regiao",
                columns: table => new
                {
                    cd_regiao = table.Column<int>(nullable: false),
                    nm_regiao = table.Column<string>(maxLength: 60, nullable: false),
                    dt_atz = table.Column<DateTime>(type: "date", nullable: true, defaultValueSql: "CURRENT_DATE"),
                    cd_filial = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_regiao", x => x.cd_regiao);
                });

            migrationBuilder.CreateTable(
                name: "saldo_cxa_dia",
                columns: table => new
                {
                    cd_filial = table.Column<int>(nullable: false),
                    cd_caixa = table.Column<int>(nullable: false),
                    dt_caixa = table.Column<DateTime>(type: "date", nullable: false),
                    vl_saldo = table.Column<decimal>(type: "numeric(18,4)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_saldo_cxa_dia", x => new { x.cd_filial, x.cd_caixa, x.dt_caixa });
                });

            migrationBuilder.CreateTable(
                name: "situacao",
                columns: table => new
                {
                    cd_situacao = table.Column<int>(nullable: false),
                    nm_situacao = table.Column<string>(maxLength: 50, nullable: false),
                    fl_inicial = table.Column<bool>(nullable: false),
                    fl_final = table.Column<bool>(nullable: false),
                    fl_reserva_estoque = table.Column<bool>(nullable: false),
                    fl_descricao_servico = table.Column<bool>(nullable: false),
                    cd_precedente = table.Column<int>(nullable: true),
                    end_arq_modelo = table.Column<string>(nullable: true),
                    cor = table.Column<string>(maxLength: 30, nullable: true),
                    fl_produto_serie = table.Column<bool>(nullable: false),
                    fl_bloqueia_estoque = table.Column<bool>(nullable: false),
                    fl_pre_venda = table.Column<bool>(nullable: true),
                    fl_ordem_servico = table.Column<bool>(nullable: true),
                    fl_preco_custo = table.Column<bool>(nullable: true),
                    fl_exporta_dav_pdf = table.Column<bool>(nullable: true),
                    end_arq_modelo_pdf = table.Column<string>(maxLength: 1000, nullable: true),
                    fl_envia_email = table.Column<string>(maxLength: 1, nullable: true),
                    fl_ipi = table.Column<string>(maxLength: 1, nullable: true),
                    fl_icmsst = table.Column<string>(maxLength: 1, nullable: true),
                    fl_ped_comp = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_situacao", x => x.cd_situacao);
                    table.ForeignKey(
                        name: "fk_situacao_precedencia",
                        column: x => x.cd_precedente,
                        principalTable: "situacao",
                        principalColumn: "cd_situacao",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "subgruprod",
                columns: table => new
                {
                    cd_subgruprod = table.Column<int>(nullable: false),
                    cd_gruprod = table.Column<int>(nullable: false),
                    nm_subgruprod = table.Column<string>(maxLength: 40, nullable: false),
                    dt_atz = table.Column<DateTime>(type: "date", nullable: true, defaultValueSql: "CURRENT_DATE")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_subgruprod", x => x.cd_subgruprod);
                });

            migrationBuilder.CreateTable(
                name: "tab_436_sped_piscofins",
                columns: table => new
                {
                    cd_tp_credito = table.Column<string>(maxLength: 3, nullable: false),
                    descricao = table.Column<string>(maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tab_436_sped_piscofins", x => x.cd_tp_credito);
                });

            migrationBuilder.CreateTable(
                name: "tab_437_sped_piscofins",
                columns: table => new
                {
                    cd_bc_credito = table.Column<string>(maxLength: 2, nullable: false),
                    descricao = table.Column<string>(maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tab_437_sped_piscofins", x => x.cd_bc_credito);
                });

            migrationBuilder.CreateTable(
                name: "tabela_preco",
                columns: table => new
                {
                    cd_tabela_preco = table.Column<int>(nullable: false),
                    nm_tabela_preco = table.Column<string>(maxLength: 40, nullable: true),
                    fl_percentual = table.Column<string>(maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tabela_preco", x => x.cd_tabela_preco);
                });

            migrationBuilder.CreateTable(
                name: "tabvcto",
                columns: table => new
                {
                    cd_filial = table.Column<int>(nullable: false),
                    nr_os = table.Column<int>(nullable: false),
                    parcela = table.Column<int>(nullable: false),
                    prazo_parcela = table.Column<int>(nullable: false),
                    dt_vcto = table.Column<DateTime>(type: "date", nullable: false, defaultValueSql: "CURRENT_DATE"),
                    pc_parcela = table.Column<decimal>(type: "numeric(9,2)", nullable: true),
                    vl_vcto = table.Column<decimal>(type: "numeric(18,4)", nullable: false),
                    dt_atz = table.Column<DateTime>(type: "date", nullable: true, defaultValueSql: "CURRENT_DATE")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tabvcto", x => new { x.cd_filial, x.nr_os, x.parcela });
                });

            migrationBuilder.CreateTable(
                name: "tipocobr",
                columns: table => new
                {
                    cd_tipocobr = table.Column<int>(nullable: false),
                    nm_tipocobr = table.Column<string>(maxLength: 80, nullable: false),
                    fl_emitir_bloqueto = table.Column<bool>(nullable: true),
                    dt_atz = table.Column<DateTime>(nullable: true),
                    vl_acrescimo = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    fl_imprime_parcela = table.Column<bool>(nullable: false),
                    tp_cobranca = table.Column<string>(maxLength: 2, nullable: true),
                    descricao_tp_cobranca = table.Column<string>(maxLength: 40, nullable: true),
                    fl_imprime_carne_ecf = table.Column<bool>(nullable: true),
                    fl_imprime_comprovante_ecf = table.Column<bool>(nullable: true),
                    taxa_desc = table.Column<decimal>(type: "numeric(9,2)", nullable: true),
                    fl_porcentagem = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tipocobr", x => x.cd_tipocobr);
                });

            migrationBuilder.CreateTable(
                name: "tributacao_grupo",
                columns: table => new
                {
                    id_tributacao_grupo = table.Column<int>(nullable: false),
                    nm_tributacao_grupo = table.Column<string>(maxLength: 40, nullable: true),
                    dt_atz = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tributacao_grupo", x => x.id_tributacao_grupo);
                });

            migrationBuilder.CreateTable(
                name: "un_medida",
                columns: table => new
                {
                    un_medida = table.Column<string>(maxLength: 6, nullable: false),
                    descricao = table.Column<string>(maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_un_medida", x => x.un_medida);
                });

            migrationBuilder.CreateTable(
                name: "usuario",
                columns: table => new
                {
                    cd_usuario = table.Column<int>(nullable: false),
                    login = table.Column<string>(maxLength: 15, nullable: false),
                    senha = table.Column<string>(maxLength: 30, nullable: true),
                    fl_acesso_irrestrito = table.Column<string>(maxLength: 1, nullable: true),
                    fl_ativo = table.Column<string>(maxLength: 1, nullable: true),
                    fl_ctrl_cxa_retaguarda = table.Column<string>(maxLength: 1, nullable: false),
                    fl_ctrl_filial = table.Column<string>(maxLength: 1, nullable: true),
                    cd_funcionario = table.Column<int>(nullable: true),
                    fl_sessao_dif_instalacao = table.Column<string>(maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuario", x => x.cd_usuario);
                });

            migrationBuilder.CreateTable(
                name: "veiculo_combustivel",
                columns: table => new
                {
                    cd_combustivel = table.Column<string>(maxLength: 2, nullable: false),
                    descricao = table.Column<string>(maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_veiculo_combustivel", x => x.cd_combustivel);
                });

            migrationBuilder.CreateTable(
                name: "veiculo_complemento",
                columns: table => new
                {
                    cd_complemento = table.Column<int>(nullable: false),
                    descricao = table.Column<string>(maxLength: 100, nullable: true),
                    dt_atz = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_veiculo_complemento", x => x.cd_complemento);
                });

            migrationBuilder.CreateTable(
                name: "veiculo_cor",
                columns: table => new
                {
                    cd_cor = table.Column<string>(maxLength: 2, nullable: false),
                    descricao = table.Column<string>(maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_veiculo_cor", x => x.cd_cor);
                });

            migrationBuilder.CreateTable(
                name: "veiculo_especie",
                columns: table => new
                {
                    cd_especie = table.Column<string>(maxLength: 2, nullable: false),
                    descricao = table.Column<string>(maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_veiculo_especie", x => x.cd_especie);
                });

            migrationBuilder.CreateTable(
                name: "veiculo_injecao",
                columns: table => new
                {
                    cd_injecao = table.Column<int>(nullable: false),
                    descricao = table.Column<string>(maxLength: 100, nullable: true),
                    dt_atz = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_veiculo_injecao", x => x.cd_injecao);
                });

            migrationBuilder.CreateTable(
                name: "veiculo_motor",
                columns: table => new
                {
                    cd_motor = table.Column<int>(nullable: false),
                    descricao = table.Column<string>(maxLength: 100, nullable: true),
                    dt_atz = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_veiculo_motor", x => x.cd_motor);
                });

            migrationBuilder.CreateTable(
                name: "veiculo_tipo",
                columns: table => new
                {
                    cd_tipo = table.Column<string>(maxLength: 2, nullable: false),
                    descricao = table.Column<string>(maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_veiculo_tipo", x => x.cd_tipo);
                });

            migrationBuilder.CreateTable(
                name: "veiculo_transmissao",
                columns: table => new
                {
                    cd_transmissao = table.Column<int>(nullable: false),
                    descricao = table.Column<string>(maxLength: 100, nullable: true),
                    dt_atz = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_veiculo_transmissao", x => x.cd_transmissao);
                });

            migrationBuilder.CreateTable(
                name: "acesso_acao_rel_campo",
                columns: table => new
                {
                    id_geral = table.Column<long>(nullable: false),
                    id_acao = table.Column<long>(nullable: false),
                    nr_ordem = table.Column<long>(nullable: false),
                    nm_campo = table.Column<string>(maxLength: 30, nullable: false),
                    fl_grid = table.Column<char>(nullable: false),
                    fl_tipo_sumarizacao = table.Column<char>(nullable: true),
                    nm_titulo_campo = table.Column<string>(maxLength: 30, nullable: false),
                    fl_grafico = table.Column<char>(nullable: true),
                    tipo_campo = table.Column<string>(maxLength: 20, nullable: true),
                    topo = table.Column<int>(nullable: true),
                    esquerda = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_acesso_acao_rel_campo", x => x.id_geral);
                    table.ForeignKey(
                        name: "fk_acesso_acao_rel_campo_idacao",
                        column: x => x.id_acao,
                        principalTable: "acesso_acao",
                        principalColumn: "id_geral",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "acesso_acao_relatorio",
                columns: table => new
                {
                    id_acao = table.Column<long>(nullable: false),
                    path_modelo = table.Column<string>(maxLength: 100, nullable: true),
                    tipo = table.Column<int>(nullable: false),
                    sql_rel = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_acesso_acao_relatorio", x => x.id_acao);
                    table.ForeignKey(
                        name: "fk_acesso_acao_relatorio_1",
                        column: x => x.id_acao,
                        principalTable: "acesso_acao",
                        principalColumn: "id_geral",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "consulta",
                columns: table => new
                {
                    id_consulta = table.Column<int>(nullable: false),
                    identificador = table.Column<string>(maxLength: 18, nullable: false),
                    titulo = table.Column<string>(maxLength: 100, nullable: false),
                    comando_sql = table.Column<string>(nullable: false),
                    tabela_cadastro = table.Column<string>(maxLength: 50, nullable: true),
                    campo_inicial = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    sql_agrupamento = table.Column<string>(nullable: true),
                    cd_conexao = table.Column<int>(nullable: true),
                    id_acao_cadastro = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_consulta", x => x.id_consulta);
                    table.ForeignKey(
                        name: "fk_consulta_acao",
                        column: x => x.id_acao_cadastro,
                        principalTable: "acesso_acao",
                        principalColumn: "id_geral",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "agenda",
                columns: table => new
                {
                    cd_evento = table.Column<int>(nullable: false),
                    dt_hr_evento = table.Column<DateTime>(nullable: false),
                    nm_evento = table.Column<string>(nullable: false),
                    cd_situacao = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_agenda", x => x.cd_evento);
                    table.ForeignKey(
                        name: "fk_agenda_situacao",
                        column: x => x.cd_situacao,
                        principalTable: "agenda_situacao",
                        principalColumn: "cd_situacao",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "carta_correcao_hist",
                columns: table => new
                {
                    id_geral = table.Column<int>(nullable: false),
                    id_carta_correcao = table.Column<int>(nullable: true),
                    nm_tabela = table.Column<string>(maxLength: 20, nullable: true),
                    nm_campo = table.Column<string>(maxLength: 20, nullable: true),
                    nr_sequencia_item = table.Column<string>(maxLength: 4, nullable: true),
                    cd_mensagem = table.Column<string>(maxLength: 4, nullable: true),
                    cont_ant = table.Column<string>(nullable: true),
                    cont_atu = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_carta_correcao_hist", x => x.id_geral);
                    table.ForeignKey(
                        name: "fk_carta_correcao",
                        column: x => x.id_carta_correcao,
                        principalTable: "carta_correcao",
                        principalColumn: "id_geral",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "cob_bordero",
                columns: table => new
                {
                    cd_bordero = table.Column<int>(nullable: false),
                    cd_convenio = table.Column<int>(nullable: false),
                    dt_cadastro = table.Column<DateTime>(type: "date", nullable: false),
                    dt_envio_remessa = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cob_bordero", x => x.cd_bordero);
                    table.ForeignKey(
                        name: "fk_cob_bordero_convenio",
                        column: x => x.cd_convenio,
                        principalTable: "cob_convenio",
                        principalColumn: "cd_convenio",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "cob_convenio_atributo",
                columns: table => new
                {
                    cd_atributo = table.Column<int>(nullable: false),
                    cd_convenio = table.Column<int>(nullable: false),
                    nr_ordem = table.Column<int>(nullable: false),
                    nm_campo = table.Column<string>(maxLength: 30, nullable: false),
                    nm_titulo_campo = table.Column<string>(maxLength: 30, nullable: false),
                    tipo_campo = table.Column<string>(maxLength: 20, nullable: true),
                    vl_atributo = table.Column<string>(maxLength: 1000, nullable: true),
                    cd_forma_pgto = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cob_convenio_atributo", x => x.cd_atributo);
                    table.ForeignKey(
                        name: "fk_cob_convenio_atributo_conv",
                        column: x => x.cd_convenio,
                        principalTable: "cob_convenio",
                        principalColumn: "cd_convenio",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "cob_convenio_forma_pgto",
                columns: table => new
                {
                    cd_filial = table.Column<int>(nullable: false),
                    cd_forma_pgto = table.Column<int>(nullable: false),
                    cd_convenio = table.Column<int>(nullable: false),
                    nr_carteira = table.Column<string>(maxLength: 15, nullable: false),
                    sg_carteira = table.Column<string>(maxLength: 8, nullable: true),
                    variacao_carteira = table.Column<string>(maxLength: 3, nullable: true),
                    fl_registrada = table.Column<string>(maxLength: 1, nullable: false),
                    id_geral = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cob_convenio_forma_pgto", x => x.id_geral);
                    table.ForeignKey(
                        name: "fk_cob_convenio_forma_pgto",
                        column: x => x.cd_convenio,
                        principalTable: "cob_convenio",
                        principalColumn: "cd_convenio",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "cob_parcela",
                columns: table => new
                {
                    id_geral = table.Column<long>(nullable: false),
                    vl_parcela = table.Column<decimal>(type: "numeric(10,2)", nullable: true),
                    nm_cedente = table.Column<string>(maxLength: 1000, nullable: false),
                    id_sistema_origem = table.Column<string>(maxLength: 100, nullable: false),
                    nm_especie = table.Column<string>(maxLength: 10, nullable: true),
                    nr_documento = table.Column<string>(maxLength: 15, nullable: true),
                    nr_carteira = table.Column<string>(maxLength: 10, nullable: true),
                    dt_emissao = table.Column<DateTime>(type: "date", nullable: false),
                    dt_vcto = table.Column<DateTime>(type: "date", nullable: false),
                    vl_desconto = table.Column<decimal>(type: "numeric(10,2)", nullable: false),
                    vl_outras_deducoes = table.Column<decimal>(type: "numeric(10,2)", nullable: false),
                    vl_abatimento = table.Column<decimal>(type: "numeric(10,2)", nullable: false),
                    vl_mora = table.Column<decimal>(type: "numeric(10,2)", nullable: false),
                    vl_juros = table.Column<decimal>(type: "numeric(10,2)", nullable: false),
                    vl_outros_acrescimos = table.Column<decimal>(type: "numeric(10,2)", nullable: false),
                    instrucoes = table.Column<string>(nullable: true),
                    observacoes = table.Column<string>(nullable: true),
                    nr_nosso_numero = table.Column<string>(maxLength: 50, nullable: true),
                    nr_sequencial_remessa = table.Column<int>(nullable: true),
                    cd_convenio = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cob_parcela", x => x.id_geral);
                    table.ForeignKey(
                        name: "cob_parcela_fk",
                        column: x => x.cd_convenio,
                        principalTable: "cob_convenio",
                        principalColumn: "cd_convenio",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "caixa",
                columns: table => new
                {
                    cd_filial = table.Column<int>(nullable: false),
                    cd_caixa = table.Column<int>(nullable: false),
                    nm_caixa = table.Column<string>(maxLength: 50, nullable: false),
                    fl_tipo = table.Column<string>(maxLength: 1, nullable: false),
                    dt_atz = table.Column<DateTime>(type: "date", nullable: true, defaultValueSql: "CURRENT_DATE"),
                    saldo_anterior = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    agencia = table.Column<string>(maxLength: 10, nullable: true),
                    conta = table.Column<string>(maxLength: 15, nullable: true),
                    gerente = table.Column<string>(maxLength: 40, nullable: true),
                    endereco = table.Column<string>(maxLength: 40, nullable: true),
                    cidade = table.Column<string>(maxLength: 30, nullable: true),
                    estado = table.Column<string>(maxLength: 2, nullable: true),
                    fone = table.Column<string>(maxLength: 15, nullable: true),
                    fax = table.Column<string>(maxLength: 15, nullable: true),
                    http = table.Column<string>(maxLength: 80, nullable: true),
                    e_mail = table.Column<string>(maxLength: 80, nullable: true),
                    cd_usr = table.Column<int>(nullable: true),
                    cd_conta_contabil = table.Column<int>(nullable: true),
                    limite = table.Column<decimal>(type: "numeric(18,4)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_caixa", x => new { x.cd_filial, x.cd_caixa });
                    table.ForeignKey(
                        name: "fk_caixa_conta_contabil",
                        column: x => x.cd_conta_contabil,
                        principalTable: "conta_contabil",
                        principalColumn: "cd_conta",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "cxa_conta",
                columns: table => new
                {
                    cd_conta = table.Column<int>(nullable: false),
                    nm_conta = table.Column<string>(maxLength: 50, nullable: false),
                    cd_completo = table.Column<string>(maxLength: 30, nullable: false),
                    grau_superior = table.Column<int>(nullable: false),
                    tp_conta = table.Column<int>(nullable: false),
                    dt_atz = table.Column<DateTime>(nullable: false),
                    cd_historico = table.Column<int>(nullable: true),
                    cd_filial = table.Column<int>(nullable: true),
                    fl_fixvar = table.Column<string>(maxLength: 1, nullable: false, defaultValueSql: "'N'::character varying"),
                    cd_conta_contabil = table.Column<int>(nullable: true),
                    fl_ativo = table.Column<char>(nullable: true),
                    fl_franquia = table.Column<string>(maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cxa_conta", x => x.cd_conta);
                    table.ForeignKey(
                        name: "fk_cxa_conta_conta_contabil",
                        column: x => x.cd_conta_contabil,
                        principalTable: "conta_contabil",
                        principalColumn: "cd_conta",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "fornecedor",
                columns: table => new
                {
                    cd_filial = table.Column<int>(nullable: false),
                    cd_fornecedor = table.Column<int>(nullable: false),
                    nm_fornecedor = table.Column<string>(maxLength: 80, nullable: false),
                    nm_fantasia = table.Column<string>(maxLength: 80, nullable: true),
                    fl_fornecedor = table.Column<string>(maxLength: 1, nullable: true),
                    endereco = table.Column<string>(maxLength: 80, nullable: true),
                    bairro = table.Column<string>(maxLength: 30, nullable: true),
                    cd_cidade = table.Column<int>(nullable: false),
                    cep = table.Column<string>(maxLength: 10, nullable: true),
                    fone = table.Column<string>(maxLength: 20, nullable: true),
                    fax = table.Column<string>(maxLength: 20, nullable: true),
                    pessoa_contato = table.Column<string>(maxLength: 40, nullable: true),
                    dt_cadastro = table.Column<DateTime>(type: "date", nullable: true, defaultValueSql: "CURRENT_DATE"),
                    cnpj = table.Column<string>(maxLength: 18, nullable: true),
                    inscricao = table.Column<string>(maxLength: 18, nullable: true),
                    observacao_fornecedor = table.Column<string>(nullable: true),
                    e_mail = table.Column<string>(maxLength: 70, nullable: true),
                    celular = table.Column<string>(maxLength: 20, nullable: true),
                    dt_atz = table.Column<DateTime>(type: "date", nullable: true, defaultValueSql: "CURRENT_DATE"),
                    cd_cliente = table.Column<int>(nullable: true),
                    numero = table.Column<string>(maxLength: 50, nullable: true),
                    complemento = table.Column<string>(maxLength: 20, nullable: true),
                    cd_conta_contabil = table.Column<int>(nullable: true),
                    inscricao_suframa = table.Column<string>(maxLength: 9, nullable: true),
                    fl_transportador = table.Column<string>(maxLength: 1, nullable: true),
                    fl_simples = table.Column<string>(maxLength: 1, nullable: true),
                    fl_agricultor = table.Column<char>(nullable: true),
                    fl_ativo = table.Column<char>(nullable: true),
                    rntrc = table.Column<string>(maxLength: 8, nullable: true),
                    fl_seguradora = table.Column<string>(maxLength: 1, nullable: true),
                    fl_cont_ncont = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_fornecedor", x => new { x.cd_filial, x.cd_fornecedor });
                    table.ForeignKey(
                        name: "fk_fornecedor_conta_contabil",
                        column: x => x.cd_conta_contabil,
                        principalTable: "conta_contabil",
                        principalColumn: "cd_conta",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tributacao_grupo_pis_cofins",
                columns: table => new
                {
                    cd_tributacao = table.Column<int>(nullable: false),
                    nm_tributacao = table.Column<string>(maxLength: 40, nullable: true),
                    pis_compra_cst = table.Column<string>(maxLength: 2, nullable: true),
                    pis_compra_pc_aliq = table.Column<decimal>(type: "numeric(8,4)", nullable: true),
                    pis_venda_cst = table.Column<string>(maxLength: 2, nullable: true),
                    pis_venda_pc_aliq = table.Column<decimal>(type: "numeric(8,4)", nullable: true),
                    cofins_compra_cst = table.Column<string>(maxLength: 2, nullable: true),
                    cofins_compra_pc_aliq = table.Column<decimal>(type: "numeric(8,4)", nullable: true),
                    cofins_venda_cst = table.Column<string>(maxLength: 2, nullable: true),
                    cofins_venda_pc_aliq = table.Column<decimal>(type: "numeric(8,4)", nullable: true),
                    dt_atz = table.Column<DateTime>(type: "date", nullable: true),
                    pis_dev_compra_cst = table.Column<string>(maxLength: 2, nullable: true),
                    pis_dev_compra_pc_aliq = table.Column<decimal>(type: "numeric(8,4)", nullable: true),
                    pis_dev_venda_cst = table.Column<string>(maxLength: 2, nullable: true),
                    pis_dev_venda_pc_aliq = table.Column<decimal>(type: "numeric(8,4)", nullable: true),
                    cofins_dev_compra_cst = table.Column<string>(maxLength: 2, nullable: true),
                    cofins_dev_compra_pc_aliq = table.Column<decimal>(type: "numeric(8,4)", nullable: true),
                    cofins_dev_venda_cst = table.Column<string>(maxLength: 2, nullable: true),
                    cofins_dev_venda_pc_aliq = table.Column<decimal>(type: "numeric(8,4)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tributacao_grupo_pis_cofins", x => x.cd_tributacao);
                    table.ForeignKey(
                        name: "fk_trib_compra_cst",
                        column: x => x.cofins_compra_cst,
                        principalTable: "cst_pis_cofins",
                        principalColumn: "cd_cst_pis_cofins",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_trib_venda_cst",
                        column: x => x.cofins_venda_cst,
                        principalTable: "cst_pis_cofins",
                        principalColumn: "cd_cst_pis_cofins",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_trib_pis_compra_cst",
                        column: x => x.pis_compra_cst,
                        principalTable: "cst_pis_cofins",
                        principalColumn: "cd_cst_pis_cofins",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_trib_cofins_venda_cst",
                        column: x => x.pis_venda_cst,
                        principalTable: "cst_pis_cofins",
                        principalColumn: "cd_cst_pis_cofins",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "cliente_resumo_financeiro_log",
                columns: table => new
                {
                    cd_filial = table.Column<int>(nullable: false),
                    dt_atz = table.Column<DateTime>(nullable: false),
                    fl_status = table.Column<char>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cliente_resumo_financeiro_log", x => x.cd_filial);
                    table.ForeignKey(
                        name: "fk_cliente_resumo_log_filial",
                        column: x => x.cd_filial,
                        principalTable: "filial_bd",
                        principalColumn: "cd_filial",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "produto_fornecedor",
                columns: table => new
                {
                    cd_filial = table.Column<int>(nullable: false),
                    cd_fornecedor = table.Column<int>(nullable: false),
                    cd_produto = table.Column<string>(maxLength: 15, nullable: false),
                    cd_prod_forn = table.Column<string>(maxLength: 61, nullable: false),
                    dt_atz = table.Column<DateTime>(type: "date", nullable: true),
                    id_unimportacao = table.Column<int>(nullable: true),
                    id_produto_fornecedor = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_produto_fornecedor", x => x.id_produto_fornecedor);
                    table.ForeignKey(
                        name: "fk_proforn_fornun",
                        column: x => x.id_unimportacao,
                        principalTable: "fornecedor_unmedida",
                        principalColumn: "id_geral",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "help_atz_alteracao",
                columns: table => new
                {
                    id_geral = table.Column<int>(nullable: false),
                    id_help_atz = table.Column<int>(nullable: false),
                    titulo = table.Column<string>(nullable: false),
                    descricao = table.Column<string>(nullable: false),
                    id_imagem = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_help_atz_alteracao", x => x.id_geral);
                    table.ForeignKey(
                        name: "fk_help_atz_alteracao_help_atz",
                        column: x => x.id_help_atz,
                        principalTable: "help_atz",
                        principalColumn: "id_geral",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "doc_nao_fiscal_c",
                columns: table => new
                {
                    id_geral = table.Column<long>(nullable: false),
                    cd_ecf = table.Column<int>(nullable: false),
                    fl_mf_adicional = table.Column<string>(maxLength: 1, nullable: false, defaultValueSql: "'N'::character varying"),
                    coo = table.Column<int>(nullable: true),
                    nr_doc = table.Column<int>(nullable: true),
                    tipo_doc = table.Column<string>(maxLength: 2, nullable: false),
                    dt_emissao = table.Column<DateTime>(type: "date", nullable: false),
                    hr_emissao = table.Column<TimeSpan>(type: "time without time zone", nullable: true),
                    gnf = table.Column<int>(nullable: true),
                    hash_doc_nao_fiscal_c_r6 = table.Column<string>(maxLength: 70, nullable: true),
                    hash_doc_nao_fiscal_c_r7 = table.Column<string>(maxLength: 70, nullable: true),
                    nr_dcto_nfsc = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_doc_nao_fiscal_c", x => x.id_geral);
                    table.ForeignKey(
                        name: "fk_doc_nao_fiscal_c_impfiscal",
                        column: x => x.cd_ecf,
                        principalTable: "impfiscal",
                        principalColumn: "cd_impfiscal",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "impfiscal_aliquota",
                columns: table => new
                {
                    cd_impfiscal = table.Column<int>(nullable: false),
                    pc_imposto = table.Column<double>(nullable: false),
                    fl_imposto = table.Column<string>(maxLength: 1, nullable: false),
                    nr_ordem_ecf = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_impfiscal_aliquota", x => new { x.cd_impfiscal, x.pc_imposto, x.fl_imposto });
                    table.ForeignKey(
                        name: "fk_impfiscal_aliquota_impfiscal",
                        column: x => x.cd_impfiscal,
                        principalTable: "impfiscal",
                        principalColumn: "cd_impfiscal",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "pafecf_e3",
                columns: table => new
                {
                    id_geral = table.Column<int>(nullable: false),
                    cd_impfiscal = table.Column<int>(nullable: false),
                    data = table.Column<DateTime>(type: "date", nullable: false),
                    hora = table.Column<TimeSpan>(type: "time without time zone", nullable: false),
                    hash_e3 = table.Column<string>(maxLength: 70, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pafecf_e3", x => x.id_geral);
                    table.ForeignKey(
                        name: "fk_pafecf_e3",
                        column: x => x.cd_impfiscal,
                        principalTable: "impfiscal",
                        principalColumn: "cd_impfiscal",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "reducao_z",
                columns: table => new
                {
                    cd_impfiscal = table.Column<int>(nullable: false),
                    dt_reducao = table.Column<DateTime>(type: "date", nullable: false),
                    contador_z = table.Column<int>(nullable: false),
                    vl_substituicao = table.Column<decimal>(type: "numeric(13,2)", nullable: true),
                    vl_isento = table.Column<decimal>(type: "numeric(13,2)", nullable: true),
                    vl_cancelamento = table.Column<decimal>(type: "numeric(13,2)", nullable: true),
                    vl_nao_incidente = table.Column<decimal>(type: "numeric(13,2)", nullable: true),
                    vl_desconto = table.Column<decimal>(type: "numeric(13,2)", nullable: true),
                    vl_gt = table.Column<decimal>(type: "numeric(13,2)", nullable: true),
                    vl_bruto = table.Column<decimal>(type: "numeric(13,2)", nullable: true),
                    cro = table.Column<int>(nullable: false),
                    nr_cupom_inicial = table.Column<int>(nullable: false),
                    nr_cupom_final = table.Column<int>(nullable: false),
                    coo = table.Column<int>(nullable: true),
                    hr_emissao = table.Column<TimeSpan>(type: "time without time zone", nullable: true),
                    dt_emissao = table.Column<DateTime>(type: "date", nullable: true),
                    fl_incidencia_desc_iss = table.Column<string>(maxLength: 1, nullable: true),
                    icm_vl_cancelamento = table.Column<decimal>(type: "numeric(13,2)", nullable: true),
                    icm_vl_desconto = table.Column<decimal>(type: "numeric(13,2)", nullable: true),
                    icm_vl_acrescimo = table.Column<decimal>(type: "numeric(13,2)", nullable: true),
                    iss_vl_cancelamento = table.Column<decimal>(type: "numeric(13,2)", nullable: true),
                    iss_vl_desconto = table.Column<decimal>(type: "numeric(13,2)", nullable: true),
                    iss_vl_acrescimo = table.Column<decimal>(type: "numeric(13,2)", nullable: true),
                    vl_opnf = table.Column<decimal>(type: "numeric(13,2)", nullable: true),
                    mf_adicional = table.Column<string>(maxLength: 1, nullable: true),
                    vl_acrescimo = table.Column<decimal>(type: "numeric(13,2)", nullable: true),
                    hash_reducao_z_r2 = table.Column<string>(maxLength: 70, nullable: true),
                    hash_reducao_z_r3 = table.Column<string>(maxLength: 70, nullable: true),
                    fl_reducao_enviada = table.Column<string>(maxLength: 1, nullable: true),
                    fl_estoque_enviado = table.Column<string>(maxLength: 1, nullable: true),
                    cam_arq_reducao = table.Column<string>(maxLength: 999, nullable: true),
                    cam_arq_estoque = table.Column<string>(maxLength: 999, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reducao_z", x => new { x.cd_impfiscal, x.dt_reducao });
                    table.ForeignKey(
                        name: "fk_rez",
                        column: x => x.cd_impfiscal,
                        principalTable: "impfiscal",
                        principalColumn: "cd_impfiscal",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "cst",
                columns: table => new
                {
                    cd_cst = table.Column<string>(maxLength: 4, nullable: false),
                    nm_cst = table.Column<string>(maxLength: 100, nullable: false),
                    fl_diferenca_base_total = table.Column<string>(maxLength: 1, nullable: true),
                    fl_icm = table.Column<string>(maxLength: 1, nullable: true),
                    fl_reducao = table.Column<string>(maxLength: 1, nullable: true),
                    fl_icm_subst = table.Column<string>(maxLength: 1, nullable: true),
                    cd_mensagem = table.Column<int>(nullable: true),
                    fl_simples = table.Column<string>(maxLength: 1, nullable: true),
                    hash_cst_d3 = table.Column<string>(maxLength: 70, nullable: true),
                    hash_cst_p2 = table.Column<string>(maxLength: 70, nullable: true),
                    fl_calc_partilha = table.Column<string>(maxLength: 1, nullable: true),
                    fl_permite_credito = table.Column<string>(maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cst", x => x.cd_cst);
                    table.ForeignKey(
                        name: "fk_cst_mensagem",
                        column: x => x.cd_mensagem,
                        principalTable: "mensagem_nota",
                        principalColumn: "cd_mensagem",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "msggrupo",
                columns: table => new
                {
                    cd_gruprod = table.Column<int>(nullable: false),
                    uf_origem = table.Column<string>(maxLength: 2, nullable: false),
                    uf_destino = table.Column<string>(maxLength: 2, nullable: false),
                    dt_atz = table.Column<DateTime>(type: "date", nullable: true, defaultValueSql: "CURRENT_DATE"),
                    cd_mensagem = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_msggrupo", x => new { x.cd_gruprod, x.uf_origem, x.uf_destino });
                    table.ForeignKey(
                        name: "gruprod_msggrupo_fk",
                        column: x => x.cd_gruprod,
                        principalTable: "gruprod",
                        principalColumn: "cd_gruprod",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_msggrupo_cd_mensagem",
                        column: x => x.cd_mensagem,
                        principalTable: "mensagem_nota",
                        principalColumn: "cd_mensagem",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "veiculo",
                columns: table => new
                {
                    cd_filial = table.Column<int>(nullable: false),
                    cd_veiculo = table.Column<int>(nullable: false),
                    cd_montadora = table.Column<int>(nullable: false),
                    nm_veiculo = table.Column<string>(maxLength: 70, nullable: false),
                    dt_atz = table.Column<DateTime>(type: "date", nullable: true, defaultValueSql: "CURRENT_DATE")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_veiculo", x => new { x.cd_filial, x.cd_veiculo });
                    table.ForeignKey(
                        name: "fk_veimontadora",
                        columns: x => new { x.cd_filial, x.cd_montadora },
                        principalTable: "montadora",
                        principalColumns: new[] { "cd_filial", "cd_montadora" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "nf_contabil_cfop",
                columns: table => new
                {
                    id_geral = table.Column<int>(nullable: false),
                    id_nf_contabil_c = table.Column<int>(nullable: false),
                    cfop = table.Column<string>(maxLength: 10, nullable: false),
                    imposto_aliq = table.Column<decimal>(type: "numeric(14,2)", nullable: false),
                    imposto_tipo = table.Column<string>(maxLength: 1, nullable: false),
                    imposto_vl_base = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    imposto_vl = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    icms_st_vl_base = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    icms_st_vl = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    vl_isento = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    vl_outros = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    vl_total = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    cst = table.Column<string>(maxLength: 4, nullable: true),
                    imposto_vl_red_base = table.Column<decimal>(type: "numeric(14,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nf_contabil_cfop", x => x.id_geral);
                    table.ForeignKey(
                        name: "fk_nf_contabil_cfop_nf_cont_c",
                        column: x => x.id_nf_contabil_c,
                        principalTable: "nf_contabil_c",
                        principalColumn: "id_geral",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "nf_contabil_i",
                columns: table => new
                {
                    id_geral = table.Column<int>(nullable: false),
                    id_nf_contabil_c = table.Column<int>(nullable: false),
                    nr_sequencia = table.Column<int>(nullable: false),
                    cd_item = table.Column<string>(maxLength: 15, nullable: false),
                    qt_item = table.Column<double>(nullable: true),
                    vl_bruto = table.Column<decimal>(type: "numeric(18,8)", nullable: true),
                    vl_desconto = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    vl_unitario = table.Column<decimal>(type: "numeric(18,8)", nullable: true),
                    vl_total = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    cfop = table.Column<string>(maxLength: 10, nullable: true),
                    cst = table.Column<string>(maxLength: 4, nullable: true),
                    pc_reducao = table.Column<decimal>(type: "numeric(6,2)", nullable: true),
                    icms_normal_aliq = table.Column<decimal>(type: "numeric(6,2)", nullable: true),
                    icms_normal_vl_base = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    icms_normal_vl = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    icms_proprio_aliq = table.Column<decimal>(type: "numeric(6,2)", nullable: true),
                    icms_proprio_vl_base = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    icms_proprio_vl = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    icms_st_mva = table.Column<decimal>(type: "numeric(6,2)", nullable: true),
                    icms_st_vl_base = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    icms_st_vl = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    iss_aliq = table.Column<decimal>(type: "numeric(6,2)", nullable: true),
                    iss_vl_base = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    iss_vl = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    ipi_aliq = table.Column<decimal>(type: "numeric(6,2)", nullable: true),
                    ipi_vl_base = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    ipi_vl = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    pis_aliq = table.Column<decimal>(type: "numeric(6,2)", nullable: true),
                    pis_vl_base = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    pis_vl = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    cofins_aliq = table.Column<decimal>(type: "numeric(6,2)", nullable: true),
                    cofins_vl_base = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    cofins_vl = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    vl_outros = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    vl_isento = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    vl_desconto_rateado = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    vl_acrescimo_rateado = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    vl_frete_rateado = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    vl_seguro_rateado = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    vl_contabil = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    fl_cancelado = table.Column<string>(maxLength: 1, nullable: true),
                    un_medida = table.Column<string>(maxLength: 6, nullable: true),
                    fl_produto = table.Column<string>(maxLength: 1, nullable: true),
                    icms_normal_pc_red = table.Column<decimal>(type: "numeric(6,2)", nullable: true),
                    icms_proprio_pc_red = table.Column<decimal>(type: "numeric(6,2)", nullable: true),
                    icms_st_pc_red = table.Column<decimal>(type: "numeric(6,2)", nullable: true),
                    icms_st_aliq_destino = table.Column<decimal>(type: "numeric(6,2)", nullable: true),
                    un_compra_venda = table.Column<string>(maxLength: 6, nullable: true),
                    vl_unitario_compra_venda = table.Column<decimal>(type: "numeric(18,8)", nullable: true),
                    ipi_cst = table.Column<string>(maxLength: 2, nullable: true),
                    pis_cst = table.Column<string>(maxLength: 2, nullable: true),
                    cofins_cst = table.Column<string>(maxLength: 2, nullable: true),
                    vl_acrescimo = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    icms_frete_vl = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    icms_st_ant_vl_base = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    icms_st_ant_vl = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    fl_soma_total = table.Column<string>(maxLength: 1, nullable: true),
                    qt_compra_venda = table.Column<double>(nullable: true),
                    pc_fcp = table.Column<decimal>(type: "numeric(4,4)", nullable: true),
                    vl_fcp = table.Column<decimal>(type: "numeric(13,2)", nullable: true),
                    vl_base_fcp = table.Column<decimal>(type: "numeric(13,2)", nullable: true),
                    vl_base_fcp_st = table.Column<decimal>(type: "numeric(13,2)", nullable: true),
                    pc_fcp_st = table.Column<decimal>(type: "numeric(4,4)", nullable: true),
                    vl_fcp_st = table.Column<decimal>(type: "numeric(13,2)", nullable: true),
                    vl_fcp_st_retido = table.Column<decimal>(type: "numeric(13,2)", nullable: true),
                    pc_fcp_st_retido = table.Column<decimal>(type: "numeric(4,4)", nullable: true),
                    vl_base_fcp_st_retido = table.Column<decimal>(type: "numeric(13,2)", nullable: true),
                    vl_base_fcp_uf_destino = table.Column<decimal>(type: "numeric(13,2)", nullable: true),
                    pc_fcp_uf_destino = table.Column<decimal>(type: "numeric(4,4)", nullable: true),
                    vl_fcp_uf_destino = table.Column<decimal>(type: "numeric(13,2)", nullable: true),
                    vl_base_uf_destino = table.Column<decimal>(type: "numeric(13,2)", nullable: true),
                    pc_icms_uf_destino = table.Column<decimal>(type: "numeric(4,4)", nullable: true),
                    pc_icms_interno = table.Column<decimal>(type: "numeric(2,2)", nullable: true),
                    pc_icms_interno_partilha = table.Column<decimal>(type: "numeric(4,4)", nullable: true),
                    vl_icms_uf_destino = table.Column<decimal>(type: "numeric(13,2)", nullable: true),
                    vl_icms_uf_remetente = table.Column<decimal>(type: "numeric(13,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nf_contabil_i", x => x.id_geral);
                    table.ForeignKey(
                        name: "fk_nf_contabil_i_nf_contabil_c",
                        column: x => x.id_nf_contabil_c,
                        principalTable: "nf_contabil_c",
                        principalColumn: "id_geral",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "nsu_produto_negativo",
                columns: table => new
                {
                    id_geral = table.Column<int>(nullable: false),
                    id_nsu = table.Column<int>(nullable: false),
                    cd_produto = table.Column<string>(maxLength: 15, nullable: false),
                    qt_produto = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nsu_produto_negativo", x => x.id_geral);
                    table.ForeignKey(
                        name: "fk_nsu_produto_nsu",
                        column: x => x.id_nsu,
                        principalTable: "nsu",
                        principalColumn: "id_geral",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "acesso_acao_perfil",
                columns: table => new
                {
                    cd_perfil_acesso = table.Column<int>(nullable: false),
                    id_acesso_acao = table.Column<long>(nullable: false),
                    fl_inserir = table.Column<string>(maxLength: 1, nullable: false),
                    fl_editar = table.Column<string>(maxLength: 1, nullable: false),
                    fl_excluir = table.Column<string>(maxLength: 1, nullable: false),
                    fl_acesso = table.Column<string>(maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_acesso_acao_perfil", x => new { x.cd_perfil_acesso, x.id_acesso_acao });
                    table.ForeignKey(
                        name: "fk_acesso_acao_perfil_per",
                        column: x => x.cd_perfil_acesso,
                        principalTable: "perfil_acesso",
                        principalColumn: "cd_perfil",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_acesso_acao_perfil_aca",
                        column: x => x.id_acesso_acao,
                        principalTable: "acesso_acao",
                        principalColumn: "id_geral",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "produto_class_fiscal_mva",
                columns: table => new
                {
                    id_geral = table.Column<int>(nullable: false),
                    cd_class_fiscal = table.Column<string>(maxLength: 5, nullable: false),
                    uf_origem = table.Column<string>(maxLength: 2, nullable: false),
                    uf_destino = table.Column<string>(maxLength: 2, nullable: false),
                    mva = table.Column<double>(nullable: false),
                    dt_atz = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_produto_class_fiscal_mva", x => x.id_geral);
                    table.ForeignKey(
                        name: "fk_produto_class_fiscal_mva_ncm",
                        column: x => x.cd_class_fiscal,
                        principalTable: "produto_class_fiscal",
                        principalColumn: "cd_class_fiscal",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "protocolo_icms_class_fiscal",
                columns: table => new
                {
                    id_geral = table.Column<int>(nullable: false),
                    id_protocolo = table.Column<int>(nullable: false),
                    cd_class_fiscal = table.Column<string>(maxLength: 5, nullable: false),
                    mva_especifica = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_protocolo_icms_class_fiscal", x => x.id_geral);
                    table.ForeignKey(
                        name: "fk_protocolo_icms_class_fiscal",
                        column: x => x.cd_class_fiscal,
                        principalTable: "produto_class_fiscal",
                        principalColumn: "cd_class_fiscal",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_protocolo_icms_protocolo",
                        column: x => x.id_protocolo,
                        principalTable: "protocolo_icms",
                        principalColumn: "id_geral",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "cidade",
                columns: table => new
                {
                    cd_cidade = table.Column<int>(nullable: false),
                    nm_cidade = table.Column<string>(maxLength: 40, nullable: false),
                    uf = table.Column<string>(maxLength: 3, nullable: false),
                    cd_regiao = table.Column<int>(nullable: true),
                    dt_atz = table.Column<DateTime>(type: "date", nullable: true, defaultValueSql: "CURRENT_DATE"),
                    cd_filial = table.Column<int>(nullable: true),
                    cd_ibge = table.Column<int>(nullable: true),
                    cd_pais = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cidade", x => x.cd_cidade);
                    table.ForeignKey(
                        name: "cidade_cd_regiao_fkey",
                        column: x => x.cd_regiao,
                        principalTable: "regiao",
                        principalColumn: "cd_regiao",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tabela_preco_produto",
                columns: table => new
                {
                    id_geral = table.Column<int>(nullable: false),
                    cd_tabela_preco = table.Column<int>(nullable: false),
                    cd_produto = table.Column<string>(maxLength: 15, nullable: false),
                    preco_venda = table.Column<decimal>(type: "numeric(15,2)", nullable: false),
                    preco_venda_min = table.Column<decimal>(type: "numeric(15,2)", nullable: false),
                    preco_venda_flex_max = table.Column<decimal>(type: "numeric(15,2)", nullable: true),
                    preco_venda_flex_min = table.Column<decimal>(type: "numeric(15,2)", nullable: true),
                    pc_markup_min = table.Column<decimal>(type: "numeric(5,2)", nullable: true),
                    pc_markup = table.Column<decimal>(type: "numeric(5,2)", nullable: true),
                    fl_utiliza_markup = table.Column<string>(maxLength: 1, nullable: false),
                    hash_tabela_preco_produto_p2 = table.Column<string>(maxLength: 70, nullable: true),
                    pc_markup_flex_min = table.Column<decimal>(type: "numeric(15,2)", nullable: true),
                    pc_markup_flex_max = table.Column<decimal>(type: "numeric(15,2)", nullable: true),
                    fl_utiliza_markup_flex = table.Column<string>(maxLength: 1, nullable: true),
                    dt_atz = table.Column<DateTime>(type: "date", nullable: true, defaultValueSql: "CURRENT_DATE")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tabela_preco_produto", x => x.id_geral);
                    table.ForeignKey(
                        name: "fk_tabela_preco_produto_tabela",
                        column: x => x.cd_tabela_preco,
                        principalTable: "tabela_preco",
                        principalColumn: "cd_tabela_preco",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tributacao",
                columns: table => new
                {
                    id_geral = table.Column<int>(nullable: false),
                    id_tributacao_grupo = table.Column<int>(nullable: false),
                    uf_origem = table.Column<string>(maxLength: 2, nullable: false),
                    uf_destino = table.Column<string>(maxLength: 2, nullable: false),
                    dt_atz = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tributacao", x => x.id_geral);
                    table.ForeignKey(
                        name: "fk_tributacao_tributacao_grupo",
                        column: x => x.id_tributacao_grupo,
                        principalTable: "tributacao_grupo",
                        principalColumn: "id_tributacao_grupo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "pedido_i",
                columns: table => new
                {
                    nr_pedido = table.Column<int>(nullable: false),
                    nr_sequencia = table.Column<int>(nullable: false),
                    cd_produto = table.Column<string>(maxLength: 15, nullable: false),
                    qt_produto = table.Column<double>(nullable: false),
                    vl_unitario = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    dt_atz = table.Column<DateTime>(type: "date", nullable: false, defaultValueSql: "CURRENT_DATE"),
                    un_medida = table.Column<string>(maxLength: 6, nullable: true),
                    qt_compra = table.Column<double>(nullable: true),
                    un_compra = table.Column<string>(maxLength: 6, nullable: true),
                    fator_conversao = table.Column<double>(nullable: true),
                    nm_produto = table.Column<string>(maxLength: 80, nullable: true),
                    cd_produto_fornecedor = table.Column<string>(maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pedido_i", x => new { x.nr_pedido, x.nr_sequencia });
                    table.ForeignKey(
                        name: "fk_pedido",
                        column: x => x.nr_pedido,
                        principalTable: "pedido_c",
                        principalColumn: "nr_pedido",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_pedido_i_un_medida",
                        column: x => x.un_medida,
                        principalTable: "un_medida",
                        principalColumn: "un_medida",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "acesso_acao_usuario",
                columns: table => new
                {
                    cd_usuario = table.Column<int>(nullable: false),
                    id_acesso_acao = table.Column<long>(nullable: false),
                    fl_inserir = table.Column<string>(maxLength: 1, nullable: false),
                    fl_editar = table.Column<string>(maxLength: 1, nullable: false),
                    fl_excluir = table.Column<string>(maxLength: 1, nullable: false),
                    fl_acesso = table.Column<string>(maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_acesso_acao_usuario", x => new { x.cd_usuario, x.id_acesso_acao });
                    table.ForeignKey(
                        name: "fk_acesso_acao_usuario_u",
                        column: x => x.cd_usuario,
                        principalTable: "usuario",
                        principalColumn: "cd_usuario",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_acesso_acao_usuario_a",
                        column: x => x.id_acesso_acao,
                        principalTable: "acesso_acao",
                        principalColumn: "id_geral",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "usuario_perfil",
                columns: table => new
                {
                    cd_usuario = table.Column<int>(nullable: false),
                    cd_perfil = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuario_perfil", x => new { x.cd_usuario, x.cd_perfil });
                    table.ForeignKey(
                        name: "fk_usuario_perfil_perfil",
                        column: x => x.cd_perfil,
                        principalTable: "perfil_acesso",
                        principalColumn: "cd_perfil",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_usuario_perfil_usuario",
                        column: x => x.cd_usuario,
                        principalTable: "usuario",
                        principalColumn: "cd_usuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "acesso_acao_rel_filtro",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false),
                    id_acao = table.Column<long>(nullable: false),
                    nm_filtro = table.Column<string>(maxLength: 40, nullable: false),
                    nm_parametro_sql = table.Column<string>(maxLength: 40, nullable: true),
                    nm_campo = table.Column<string>(maxLength: 40, nullable: true),
                    comentario = table.Column<string>(maxLength: 40, nullable: true),
                    rotulo_filtro = table.Column<string>(maxLength: 40, nullable: true),
                    cd_consulta = table.Column<int>(nullable: true),
                    tipo_dado = table.Column<string>(maxLength: 40, nullable: true),
                    nr_ordem = table.Column<int>(nullable: false),
                    valor_padrao = table.Column<string>(maxLength: 40, nullable: true),
                    multivalor = table.Column<string>(nullable: true),
                    nm_campo_retorno = table.Column<string>(maxLength: 40, nullable: true),
                    tipo_dado_parametro = table.Column<string>(maxLength: 40, nullable: true),
                    fl_selecao_multipla = table.Column<string>(maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_acesso_acao_rel_filtro", x => x.id);
                    table.ForeignKey(
                        name: "acesso_acao_rel_filtro_fk",
                        column: x => x.id_acao,
                        principalTable: "acesso_acao_relatorio",
                        principalColumn: "id_acao",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "consulta_campo",
                columns: table => new
                {
                    id_geral = table.Column<int>(nullable: false),
                    id_consulta = table.Column<int>(nullable: false),
                    nm_campo = table.Column<string>(maxLength: 30, nullable: false),
                    nm_titulo = table.Column<string>(maxLength: 100, nullable: true),
                    nr_posicao = table.Column<int>(nullable: true),
                    tamanho_campo = table.Column<int>(nullable: true),
                    tipo_campo = table.Column<string>(maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_consulta_campo", x => x.id_geral);
                    table.ForeignKey(
                        name: "fk_id_consulta",
                        column: x => x.id_consulta,
                        principalTable: "consulta",
                        principalColumn: "id_consulta",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "cob_bordero_parcela",
                columns: table => new
                {
                    id_parcela = table.Column<long>(nullable: false),
                    cd_bordero = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cob_bordero_parcela", x => new { x.id_parcela, x.cd_bordero });
                    table.ForeignKey(
                        name: "fk_cob_bordero_parcela",
                        column: x => x.cd_bordero,
                        principalTable: "cob_bordero",
                        principalColumn: "cd_bordero",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_cob_bordero_parcela_bor",
                        column: x => x.id_parcela,
                        principalTable: "cob_parcela",
                        principalColumn: "id_geral",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "administradora",
                columns: table => new
                {
                    cd_administradora = table.Column<int>(nullable: false),
                    nm_administradora = table.Column<string>(maxLength: 80, nullable: false),
                    dias_pagamento_adm = table.Column<int>(nullable: true),
                    dt_atz = table.Column<DateTime>(type: "date", nullable: true, defaultValueSql: "CURRENT_DATE"),
                    dias_pagamento_loja = table.Column<int>(nullable: true),
                    conta_caixa = table.Column<int>(nullable: true),
                    cd_caixa = table.Column<int>(nullable: true),
                    pc_cobranca_debito = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    pc_cobranca_adm = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    cd_filial = table.Column<int>(nullable: true),
                    cd_cidade = table.Column<int>(nullable: true),
                    cnpj = table.Column<string>(maxLength: 18, nullable: true),
                    inscricao = table.Column<string>(maxLength: 18, nullable: true),
                    endereco = table.Column<string>(maxLength: 80, nullable: true),
                    numero = table.Column<string>(maxLength: 50, nullable: true),
                    complemento = table.Column<string>(maxLength: 20, nullable: true),
                    bairro = table.Column<string>(maxLength: 30, nullable: true),
                    id_bandeira = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_administradora", x => x.cd_administradora);
                    table.ForeignKey(
                        name: "fk_administradora_conta_caixa",
                        column: x => x.conta_caixa,
                        principalTable: "cxa_conta",
                        principalColumn: "cd_conta",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_administradora_bandeira",
                        column: x => x.id_bandeira,
                        principalTable: "administradora_bandeira",
                        principalColumn: "id_geral",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "crptitulo",
                columns: table => new
                {
                    cd_filial = table.Column<int>(nullable: false),
                    cd_tipo_conta = table.Column<int>(nullable: false),
                    cd_clifor = table.Column<int>(nullable: false),
                    nr_titulo = table.Column<string>(maxLength: 15, nullable: false),
                    parcela = table.Column<int>(nullable: false),
                    dt_emissao = table.Column<DateTime>(type: "date", nullable: false, defaultValueSql: "CURRENT_DATE"),
                    dt_inclusao = table.Column<DateTime>(type: "date", nullable: false, defaultValueSql: "CURRENT_DATE"),
                    dt_vcto_ori = table.Column<DateTime>(type: "date", nullable: false, defaultValueSql: "CURRENT_DATE"),
                    dt_vcto = table.Column<DateTime>(type: "date", nullable: false, defaultValueSql: "CURRENT_DATE"),
                    dt_ult_pgto = table.Column<DateTime>(type: "date", nullable: true),
                    cd_banco_ori = table.Column<int>(nullable: false),
                    cd_banco = table.Column<int>(nullable: false),
                    cd_tipocobr_ori = table.Column<int>(nullable: false),
                    cd_tipocobr = table.Column<int>(nullable: false),
                    cd_vendedor = table.Column<int>(nullable: false),
                    fl_prev_realizado = table.Column<string>(maxLength: 1, nullable: true),
                    vl_comissao = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_nominal = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_juros = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_baixas_nominal = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_descontos = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_saldo = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    cd_caixa = table.Column<int>(nullable: false),
                    dt_atz = table.Column<DateTime>(type: "date", nullable: true, defaultValueSql: "CURRENT_DATE"),
                    nr_nf_ecf = table.Column<long>(nullable: true),
                    prazo_parcela = table.Column<int>(nullable: false),
                    pc_parcela = table.Column<decimal>(type: "numeric(5,2)", nullable: true),
                    cd_conta = table.Column<int>(nullable: true),
                    vl_acrescimo = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    fl_reparcelado = table.Column<string>(maxLength: 1, nullable: true),
                    nr_documento = table.Column<int>(nullable: true),
                    obs = table.Column<string>(nullable: true),
                    nr_sequencial = table.Column<int>(nullable: true),
                    pc_parcela_total = table.Column<double>(nullable: true),
                    motivo_alteracao = table.Column<string>(maxLength: 120, nullable: true),
                    nr_titulo_reparcelado = table.Column<string>(maxLength: 15, nullable: true),
                    nr_se = table.Column<string>(maxLength: 3, nullable: true),
                    vl_multa = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    fl_imprime_carne = table.Column<string>(maxLength: 1, nullable: true),
                    fl_imprime_comprovante = table.Column<string>(maxLength: 1, nullable: true),
                    cd_frente_caixa_carne = table.Column<int>(nullable: true),
                    vl_devolucoes = table.Column<decimal>(type: "numeric(9,2)", nullable: true),
                    motivo_alteracao_valor = table.Column<string>(nullable: true),
                    cd_funcionario = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_crptitulo", x => new { x.cd_filial, x.cd_tipo_conta, x.cd_clifor, x.nr_titulo, x.parcela });
                    table.ForeignKey(
                        name: "fk_crptitulo_cxa_conta",
                        column: x => x.cd_conta,
                        principalTable: "cxa_conta",
                        principalColumn: "cd_conta",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "filial",
                columns: table => new
                {
                    cd_filial = table.Column<int>(nullable: false),
                    nm_filial = table.Column<string>(maxLength: 50, nullable: false),
                    endereco = table.Column<string>(maxLength: 50, nullable: true),
                    bairro = table.Column<string>(maxLength: 30, nullable: true),
                    cidade = table.Column<string>(maxLength: 50, nullable: false),
                    uf = table.Column<string>(maxLength: 2, nullable: false),
                    cep = table.Column<string>(maxLength: 10, nullable: true),
                    fone = table.Column<string>(maxLength: 16, nullable: true),
                    fax = table.Column<string>(maxLength: 16, nullable: true),
                    cgc = table.Column<string>(maxLength: 18, nullable: true),
                    ie = table.Column<string>(maxLength: 18, nullable: true),
                    nr_ult_nfs = table.Column<int>(nullable: true),
                    fl_informar_nr_nf = table.Column<bool>(nullable: true),
                    fl_valor_seguro = table.Column<bool>(nullable: true),
                    fl_valor_frete = table.Column<bool>(nullable: true),
                    fl_valor_desconto = table.Column<bool>(nullable: true),
                    fl_imprimir_nfs = table.Column<bool>(nullable: true),
                    fl_controlar_estoq = table.Column<bool>(nullable: true),
                    fl_imprime_nf = table.Column<bool>(nullable: true),
                    pc_pis = table.Column<decimal>(type: "numeric(15,2)", nullable: true),
                    pc_cofins = table.Column<decimal>(type: "numeric(15,2)", nullable: true),
                    email = table.Column<string>(maxLength: 75, nullable: true),
                    fl_calcula_comissao = table.Column<bool>(nullable: true),
                    fl_controle_credito = table.Column<bool>(nullable: true),
                    cd_conta = table.Column<int>(nullable: true),
                    cd_cliente_consumidor = table.Column<int>(nullable: true),
                    cd_filial_fornecedor = table.Column<int>(nullable: true),
                    fl_cons_prod = table.Column<string>(maxLength: 1, nullable: true),
                    im = table.Column<string>(maxLength: 10, nullable: true),
                    empresa_simples = table.Column<string>(maxLength: 1, nullable: true),
                    custo_em_orcamento = table.Column<string>(maxLength: 1, nullable: true),
                    taxa_juros = table.Column<decimal>(type: "numeric(10,3)", nullable: true),
                    dt_atz = table.Column<DateTime>(nullable: true),
                    dias_vcto = table.Column<int>(nullable: true, defaultValueSql: "0"),
                    fl_controle_contas = table.Column<string>(maxLength: 1, nullable: true, defaultValueSql: "'N'::character varying"),
                    tp_comissao = table.Column<string>(maxLength: 1, nullable: false, defaultValueSql: "'I'::character varying"),
                    fl_comissao_vendabaixa = table.Column<string>(maxLength: 1, nullable: true),
                    modulo = table.Column<int>(nullable: true),
                    cd_usr_padrao = table.Column<int>(nullable: true),
                    cd_cliente_empresa = table.Column<int>(nullable: true),
                    fl_orc_imp_vend_cliente = table.Column<string>(maxLength: 1, nullable: true),
                    fl_altera_vend_orc = table.Column<string>(maxLength: 1, nullable: true),
                    fl_cliente_cnpj_dupl = table.Column<string>(maxLength: 1, nullable: true),
                    fl_item_dupl_nfs = table.Column<string>(maxLength: 1, nullable: true),
                    fl_item_dupl_nfe = table.Column<string>(maxLength: 1, nullable: true),
                    fl_orc_prod_sem_vendedor = table.Column<string>(maxLength: 1, nullable: true),
                    fl_orc_exibir_ult_venda = table.Column<string>(maxLength: 1, nullable: true),
                    vl_id_geral = table.Column<int>(nullable: true),
                    fl_deducao_piscofins = table.Column<string>(maxLength: 1, nullable: true),
                    fl_orc_serv_sem_vendedor = table.Column<string>(maxLength: 1, nullable: true),
                    aliq_icms_simples = table.Column<decimal>(type: "numeric(5,2)", nullable: true),
                    cd_cidade = table.Column<int>(nullable: true),
                    numero = table.Column<int>(nullable: true),
                    complemento = table.Column<string>(maxLength: 20, nullable: true),
                    tp_ambiente_nfe = table.Column<int>(nullable: true),
                    nota_eletronica = table.Column<string>(maxLength: 1, nullable: true),
                    nr_lote_nfe = table.Column<int>(nullable: true),
                    fl_venda_vista_cliente_bloq = table.Column<string>(maxLength: 1, nullable: true),
                    fl_venda_prazo_cliente_bloq = table.Column<string>(maxLength: 1, nullable: true),
                    fl_deducao_icms = table.Column<bool>(nullable: true),
                    cd_fornecedor_imposto_st = table.Column<int>(nullable: true),
                    dt_ultima_integracao = table.Column<DateTime>(type: "date", nullable: true),
                    fl_imprimir_orc_ecf = table.Column<bool>(nullable: true),
                    fl_utiliza_conta_contabil = table.Column<bool>(nullable: true),
                    tp_sistema = table.Column<int>(nullable: true),
                    fl_industria = table.Column<bool>(nullable: true),
                    ind_perfil_sped = table.Column<string>(maxLength: 1, nullable: true),
                    suframa = table.Column<string>(maxLength: 9, nullable: true),
                    nm_fantasia = table.Column<string>(maxLength: 50, nullable: true),
                    ind_apur_ipi = table.Column<int>(nullable: true),
                    nr_serie_producao = table.Column<string>(maxLength: 3, nullable: true),
                    cd_op_entrada_producao = table.Column<int>(nullable: true),
                    cd_op_saida_producao = table.Column<int>(nullable: true),
                    fl_fitossanitario_sira = table.Column<string>(maxLength: 1, nullable: true),
                    fl_utiliza_paf = table.Column<bool>(nullable: true),
                    fl_armaz_interfoc = table.Column<char>(nullable: true),
                    fl_contribuinte = table.Column<string>(maxLength: 1, nullable: true),
                    cd_mensagem_cupom = table.Column<int>(nullable: true),
                    cd_mensagem_dav = table.Column<int>(nullable: true),
                    cd_mensagem_pre_venda = table.Column<int>(nullable: true),
                    fl_custo_frete_st = table.Column<string>(maxLength: 1, nullable: true),
                    fl_orc_exibir_vl_compra = table.Column<string>(maxLength: 1, nullable: true),
                    cd_transportadora = table.Column<int>(nullable: true),
                    cd_mensagem_icm_ret_ant = table.Column<int>(nullable: true),
                    tp_status_nfe = table.Column<int>(nullable: true),
                    fl_simples_excesso_receita = table.Column<string>(maxLength: 1, nullable: true),
                    cd_crt = table.Column<int>(nullable: true),
                    cd_mensagem_simples = table.Column<int>(nullable: true),
                    cnae_fiscal = table.Column<string>(maxLength: 7, nullable: true),
                    nfe_conjugada = table.Column<string>(maxLength: 1, nullable: true),
                    cd_mensagem_tot_trib = table.Column<int>(nullable: true),
                    fl_utiliza_integracao = table.Column<char>(nullable: true),
                    vl_multa_contas = table.Column<decimal>(type: "numeric(6,3)", nullable: true),
                    cd_mensagem_icm_st_nota_dev = table.Column<int>(nullable: true),
                    cd_ctbl_exporta = table.Column<short>(nullable: true),
                    fl_apenas_vendedor_doc = table.Column<char>(nullable: false, defaultValueSql: "'N'::bpchar"),
                    fl_real_presumido = table.Column<char>(nullable: true),
                    dt_atz_estoque = table.Column<DateTime>(type: "date", nullable: true),
                    hr_atz_estoque = table.Column<TimeSpan>(type: "time without time zone", nullable: true),
                    cd_impfiscal_atz_estoque = table.Column<int>(nullable: true),
                    hash_filial_e1 = table.Column<string>(maxLength: 70, nullable: true),
                    hash_filial_r1 = table.Column<string>(maxLength: 70, nullable: true),
                    fl_rede_uniagro = table.Column<string>(maxLength: 1, nullable: true),
                    fl_venda_outros_uf = table.Column<string>(maxLength: 1, nullable: true),
                    fl_flex = table.Column<string>(maxLength: 1, nullable: true),
                    fl_pos_venda = table.Column<string>(maxLength: 1, nullable: true),
                    tp_cli_padrao_venda = table.Column<string>(maxLength: 1, nullable: true),
                    fl_conhe_frete_st = table.Column<string>(maxLength: 1, nullable: true),
                    fl_st_nota_esta = table.Column<string>(maxLength: 1, nullable: true),
                    cd_tabela_preco_padrao = table.Column<int>(nullable: true),
                    cd_mensagem_ipi_nota_dev = table.Column<int>(nullable: true),
                    fl_nota_eletronica_municipal = table.Column<char>(nullable: true),
                    tp_ambiente_nfe_municipal = table.Column<char>(nullable: true),
                    fl_contigencia_municipal = table.Column<char>(nullable: true),
                    fl_imprime_ordem_entrega = table.Column<bool>(nullable: true),
                    cd_mensagem_desconto_ro = table.Column<int>(nullable: true),
                    cod_versao_efd = table.Column<string>(maxLength: 3, nullable: true),
                    fl_calcula_prazo_data_saida = table.Column<bool>(nullable: true),
                    fl_adiciona_st_custo_produto = table.Column<bool>(nullable: true),
                    fl_imprime_carne_ecf = table.Column<bool>(nullable: true),
                    dir_arq_carne_ecf = table.Column<string>(maxLength: 150, nullable: true),
                    dir_arq_comprovante_ecf = table.Column<string>(maxLength: 150, nullable: true),
                    fl_imp_vendedor_cliente_nfsc = table.Column<string>(maxLength: 1, nullable: true),
                    fl_multa_porcentagem = table.Column<string>(maxLength: 1, nullable: true),
                    fuso_horario = table.Column<string>(maxLength: 6, nullable: true),
                    fl_bloq_cancelamento_ecf = table.Column<string>(maxLength: 1, nullable: true),
                    fl_calcula_diferenca_icms = table.Column<string>(maxLength: 1, nullable: true),
                    fl_filial_tit_cartao = table.Column<string>(maxLength: 1, nullable: true),
                    fl_importar_vendedor_primeiro = table.Column<char>(nullable: true),
                    fl_importar_vendedor_segundo = table.Column<char>(nullable: true),
                    fl_importar_vendedor_terceiro = table.Column<char>(nullable: true),
                    bloquear_edicao_juros_multa = table.Column<char>(nullable: true),
                    database_auditor = table.Column<char>(nullable: true),
                    fl_utiliza_nfce = table.Column<string>(maxLength: 1, nullable: true),
                    cf_informa_documento = table.Column<bool>(nullable: true),
                    tp_icms_entrada_frete = table.Column<string>(maxLength: 1, nullable: true),
                    tp_piscofins_entrada_frete = table.Column<string>(maxLength: 1, nullable: true),
                    tp_icms_saida_frete = table.Column<string>(maxLength: 1, nullable: true),
                    tp_piscofins_saida_frete = table.Column<string>(maxLength: 1, nullable: true),
                    cd_prodfrete_venda = table.Column<string>(maxLength: 15, nullable: true),
                    cd_prodfrete_vendas_c = table.Column<string>(maxLength: 15, nullable: true),
                    cd_prodfrete_saida = table.Column<string>(maxLength: 15, nullable: true),
                    cd_prodfrete_saidas_c = table.Column<string>(maxLength: 15, nullable: true),
                    cd_prodfrete_compra = table.Column<string>(maxLength: 15, nullable: true),
                    cd_prodfrete_compras_c = table.Column<string>(maxLength: 15, nullable: true),
                    cd_prodfrete_trans = table.Column<string>(maxLength: 15, nullable: true),
                    cd_prodfrete_entrada = table.Column<string>(maxLength: 15, nullable: true),
                    cd_prodfrete_entradas_c = table.Column<string>(maxLength: 15, nullable: true),
                    cst_frete_icmscred = table.Column<string>(maxLength: 4, nullable: true),
                    cst_frete_icms_ncred = table.Column<string>(maxLength: 4, nullable: true),
                    fl_manifesto_eletronico = table.Column<string>(maxLength: 1, nullable: true),
                    fl_senha_supervisor_dav = table.Column<string>(maxLength: 1, nullable: true),
                    fl_cod_clifor_danfe = table.Column<string>(maxLength: 1, nullable: true),
                    fl_seguradora = table.Column<string>(maxLength: 1, nullable: true),
                    vl_min_inss = table.Column<decimal>(type: "numeric(10,3)", nullable: true),
                    vl_min_csll = table.Column<decimal>(type: "numeric(10,3)", nullable: true),
                    dias_juro = table.Column<int>(nullable: true),
                    dias_multa = table.Column<int>(nullable: true),
                    cd_mensagem_reducao = table.Column<int>(nullable: true),
                    cd_mensagem_difal = table.Column<int>(nullable: true),
                    fl_oculista = table.Column<string>(maxLength: 1, nullable: true),
                    fl_envia_blocox = table.Column<string>(maxLength: 1, nullable: true),
                    fl_alterar_markup_cadastro = table.Column<bool>(nullable: true),
                    fl_desconto_incondicionado = table.Column<bool>(nullable: true),
                    calculoconveniost = table.Column<bool>(nullable: true),
                    cd_mensagem_fcp = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_filial", x => x.cd_filial);
                    table.ForeignKey(
                        name: "fk_filial_cxa_conta",
                        column: x => x.cd_conta,
                        principalTable: "cxa_conta",
                        principalColumn: "cd_conta",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_filial_msg_cupom",
                        column: x => x.cd_mensagem_cupom,
                        principalTable: "mensagem_nota",
                        principalColumn: "cd_mensagem",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_filial_msg_dav",
                        column: x => x.cd_mensagem_dav,
                        principalTable: "mensagem_nota",
                        principalColumn: "cd_mensagem",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_filial_msg_icm_st",
                        column: x => x.cd_mensagem_icm_st_nota_dev,
                        principalTable: "mensagem_nota",
                        principalColumn: "cd_mensagem",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_filial_msg_pre_venda",
                        column: x => x.cd_mensagem_pre_venda,
                        principalTable: "mensagem_nota",
                        principalColumn: "cd_mensagem",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_filial_preco",
                        column: x => x.cd_tabela_preco_padrao,
                        principalTable: "tabela_preco",
                        principalColumn: "cd_tabela_preco",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "movimento_cxa",
                columns: table => new
                {
                    cd_filial = table.Column<int>(nullable: false),
                    nr_lcto = table.Column<int>(nullable: false),
                    cd_caixa = table.Column<int>(nullable: false),
                    dt_mvto = table.Column<DateTime>(type: "date", nullable: true),
                    cd_conta = table.Column<int>(nullable: true),
                    complemento = table.Column<string>(maxLength: 1000, nullable: true),
                    vl_entrada = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_saida = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    cd_banco = table.Column<int>(nullable: true),
                    cd_agencia = table.Column<string>(maxLength: 10, nullable: true),
                    nr_cc = table.Column<string>(maxLength: 15, nullable: true),
                    cd_clifor = table.Column<int>(nullable: true),
                    nm_titular = table.Column<string>(maxLength: 80, nullable: true),
                    dt_bom_para = table.Column<DateTime>(type: "date", nullable: true),
                    dt_atz = table.Column<DateTime>(type: "date", nullable: true, defaultValueSql: "CURRENT_DATE"),
                    fl_origem = table.Column<string>(maxLength: 1, nullable: true),
                    cd_historico = table.Column<int>(nullable: true),
                    cd_funcionario = table.Column<int>(nullable: false),
                    fl_cheque = table.Column<string>(maxLength: 1, nullable: false),
                    nr_sequencial = table.Column<int>(nullable: false),
                    fl_cancelado = table.Column<bool>(nullable: true),
                    nr_cheque = table.Column<string>(maxLength: 15, nullable: true),
                    dt_inclusao = table.Column<DateTime>(type: "date", nullable: true),
                    dt_compensacao = table.Column<DateTime>(type: "date", nullable: true),
                    motivo_devolucao = table.Column<string>(maxLength: 80, nullable: true),
                    destinatario = table.Column<string>(maxLength: 80, nullable: true),
                    dcto_origem = table.Column<string>(maxLength: 25, nullable: true),
                    fl_compensado = table.Column<string>(maxLength: 1, nullable: true),
                    fl_destino = table.Column<string>(maxLength: 1, nullable: true),
                    nr_documento = table.Column<int>(nullable: true),
                    nr_serie = table.Column<string>(maxLength: 3, nullable: true),
                    tp_cartao = table.Column<string>(maxLength: 1, nullable: true),
                    tp_integracao = table.Column<short>(nullable: true),
                    hash_a2 = table.Column<string>(maxLength: 70, nullable: true),
                    hash_h2 = table.Column<string>(maxLength: 70, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_movimento_cxa", x => new { x.cd_filial, x.cd_caixa, x.nr_lcto });
                    table.ForeignKey(
                        name: "fk_movimento_cxa_cxa_conta",
                        column: x => x.cd_conta,
                        principalTable: "cxa_conta",
                        principalColumn: "cd_conta",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_movimento_cxa_caixa",
                        columns: x => new { x.cd_filial, x.cd_caixa },
                        principalTable: "caixa",
                        principalColumns: new[] { "cd_filial", "cd_caixa" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "nfec",
                columns: table => new
                {
                    cd_filial = table.Column<int>(nullable: false),
                    nr_dcto = table.Column<long>(nullable: false),
                    cd_clifor = table.Column<int>(nullable: false),
                    fl_impresso = table.Column<bool>(nullable: true),
                    serie_nf = table.Column<string>(maxLength: 3, nullable: false),
                    cd_operacao = table.Column<int>(nullable: true),
                    dt_emissao = table.Column<DateTime>(type: "date", nullable: false, defaultValueSql: "CURRENT_DATE"),
                    dt_lancamento = table.Column<DateTime>(type: "date", nullable: false, defaultValueSql: "CURRENT_DATE"),
                    vl_acrescimos = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_descontos = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_mercadorias = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_servicos = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_total = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    cd_condpgto = table.Column<int>(nullable: true),
                    vl_entrada = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_acres_financeiro = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_financiado = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    peso_total = table.Column<double>(nullable: true),
                    qt_pecas = table.Column<double>(nullable: true),
                    obs = table.Column<string>(nullable: true),
                    cd_natoper = table.Column<string>(maxLength: 40, nullable: false),
                    fl_cont_ncont = table.Column<string>(maxLength: 1, nullable: true),
                    cd_transportadora = table.Column<int>(nullable: true),
                    uf_origem = table.Column<string>(maxLength: 2, nullable: false),
                    uf_destino = table.Column<string>(maxLength: 2, nullable: false),
                    peso_liquido = table.Column<double>(nullable: true),
                    vl_frete = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_seguro = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_base_icm = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_icm = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_base_icm_subst = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_icm_subst = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_ipi = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_iss = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    tp_frete = table.Column<string>(maxLength: 1, nullable: true),
                    qt_volumes = table.Column<double>(nullable: true),
                    especie_volumes = table.Column<string>(maxLength: 15, nullable: true),
                    marca_volumes = table.Column<string>(maxLength: 15, nullable: true),
                    nr_volumes = table.Column<double>(nullable: true),
                    cd_banco = table.Column<int>(nullable: false),
                    cd_tipocobr = table.Column<int>(nullable: false),
                    cd_conta = table.Column<int>(nullable: false),
                    cd_funcionario = table.Column<int>(nullable: false),
                    dt_atz = table.Column<DateTime>(type: "date", nullable: true, defaultValueSql: "CURRENT_DATE"),
                    placa_transp = table.Column<string>(maxLength: 8, nullable: true),
                    uf_placa_transp = table.Column<string>(maxLength: 2, nullable: true),
                    vl_outros = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    fl_cd_conta = table.Column<string>(maxLength: 1, nullable: true),
                    fl_ignorar_cxa_cta = table.Column<string>(maxLength: 1, nullable: false),
                    fl_transferencia = table.Column<bool>(nullable: false),
                    nr_pedido = table.Column<int>(nullable: true),
                    fl_controlar_estoque = table.Column<string>(maxLength: 1, nullable: true),
                    nsu = table.Column<string>(maxLength: 10, nullable: true),
                    nr_dcto_devolucao = table.Column<int>(nullable: true),
                    vl_base_pis = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_pis = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_base_cofins = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_cofins = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_base_ipi = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_base_iss = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_desconto_item = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_isento_itens = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_outros_itens = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    nr_protocolo_nfe = table.Column<string>(maxLength: 15, nullable: true),
                    dt_processamento_nfe = table.Column<DateTime>(type: "date", nullable: true),
                    status = table.Column<int>(nullable: true),
                    nr_lote_nfe = table.Column<string>(maxLength: 15, nullable: true),
                    nr_recibo_nfe = table.Column<string>(maxLength: 15, nullable: true),
                    nr_protocolo_canc_nfe = table.Column<string>(maxLength: 15, nullable: true),
                    chave_acesso_nfe = table.Column<string>(maxLength: 44, nullable: true),
                    obs2 = table.Column<string>(nullable: true),
                    conhecimento_vl_frete = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    conhecimento_vl_st = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    conhecimento_vl_icm = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    base_icm_proprio_st = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_icm_proprio_st = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_base_icm_subst_real = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_icm_subst_real = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    fl_calcular_custo = table.Column<string>(maxLength: 1, nullable: true),
                    cd_modelo = table.Column<string>(maxLength: 3, nullable: true),
                    id_geral = table.Column<int>(nullable: false),
                    conhecimento_base_icm = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    conhecimento_base_st = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    fl_consumo = table.Column<string>(maxLength: 1, nullable: true),
                    vl_icm_frete = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    cfop_frete = table.Column<string>(maxLength: 10, nullable: true),
                    sub_serie = table.Column<string>(maxLength: 3, nullable: true),
                    nr_aidf = table.Column<string>(maxLength: 20, nullable: true),
                    fl_conhec_frete = table.Column<bool>(nullable: true),
                    vl_base_icm_subst_ant = table.Column<decimal>(type: "numeric(9,2)", nullable: true),
                    vl_icm_subst_ant = table.Column<decimal>(type: "numeric(9,2)", nullable: true),
                    hr_emissao = table.Column<TimeSpan>(type: "time without time zone", nullable: true),
                    cupom_nr_pdv = table.Column<int>(nullable: true),
                    cupom_nr_coo = table.Column<int>(nullable: true),
                    fl_simples = table.Column<string>(maxLength: 1, nullable: true),
                    hr_processamento_nfe = table.Column<TimeSpan>(type: "time without time zone", nullable: true),
                    dpec_id = table.Column<string>(maxLength: 10, nullable: true),
                    dpec_nr_registro = table.Column<string>(maxLength: 14, nullable: true),
                    dpec_dt_registro = table.Column<DateTime>(type: "date", nullable: true),
                    dpec_hr_registro = table.Column<TimeSpan>(type: "time without time zone", nullable: true),
                    cd_barras_adicional_nfe = table.Column<string>(maxLength: 36, nullable: true),
                    tp_emissao_nfe = table.Column<int>(nullable: true),
                    vl_icm_subst_dev = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_base_icm_subst_dev = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_base_ipi_dev = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_ipi_dev = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_fcp = table.Column<decimal>(type: "numeric(13,2)", nullable: true),
                    vl_fcp_st = table.Column<decimal>(type: "numeric(13,2)", nullable: true),
                    vl_fcp_st_retido = table.Column<decimal>(type: "numeric(13,2)", nullable: true),
                    vl_icms_uf_dest = table.Column<decimal>(type: "numeric(13,2)", nullable: true),
                    vl_icms_uf_remet = table.Column<decimal>(type: "numeric(13,2)", nullable: true),
                    vl_fcp_uf_dest = table.Column<decimal>(type: "numeric(13,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nfec", x => x.id_geral);
                    table.ForeignKey(
                        name: "fk_nfec_cxa_conta",
                        column: x => x.cd_conta,
                        principalTable: "cxa_conta",
                        principalColumn: "cd_conta",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_nfec_pedido",
                        column: x => x.nr_pedido,
                        principalTable: "pedido_c",
                        principalColumn: "nr_pedido",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "operacao_es",
                columns: table => new
                {
                    cd_operacao = table.Column<int>(nullable: false),
                    nm_operacao = table.Column<string>(maxLength: 40, nullable: true),
                    fl_ent_sai = table.Column<string>(maxLength: 1, nullable: false),
                    fl_calcular_custo = table.Column<bool>(nullable: true),
                    fl_calcular_ipi = table.Column<bool>(nullable: true),
                    fl_controlar_estoq = table.Column<bool>(nullable: true),
                    fl_calcular_comissao = table.Column<bool>(nullable: true),
                    fl_ignora_caixa_contas = table.Column<bool>(nullable: true),
                    fl_cd_conta = table.Column<string>(maxLength: 1, nullable: true),
                    fl_calcular_icms = table.Column<string>(maxLength: 1, nullable: true),
                    dt_atz = table.Column<DateTime>(type: "date", nullable: true, defaultValueSql: "CURRENT_DATE"),
                    fl_tributar_frete = table.Column<bool>(nullable: false),
                    fl_reducao_juridica = table.Column<bool>(nullable: false),
                    fl_calcular_iss = table.Column<string>(maxLength: 1, nullable: false),
                    fl_sugerir_preco = table.Column<string>(maxLength: 1, nullable: true),
                    cd_grupo_op = table.Column<string>(maxLength: 2, nullable: true),
                    fl_ativo = table.Column<string>(maxLength: 1, nullable: true),
                    cd_conta_movimento = table.Column<int>(nullable: true),
                    cd_modelo = table.Column<string>(maxLength: 3, nullable: false),
                    cd_mensagem = table.Column<int>(nullable: true),
                    nat_operacao = table.Column<string>(maxLength: 40, nullable: false),
                    id_tributacao_grupo = table.Column<int>(nullable: true),
                    fl_importacao = table.Column<string>(maxLength: 1, nullable: true),
                    finalidade = table.Column<string>(maxLength: 1, nullable: true),
                    cst_pis_dif = table.Column<string>(maxLength: 5, nullable: true),
                    cst_cofins_dif = table.Column<string>(maxLength: 5, nullable: true),
                    fl_credito_icms_st = table.Column<bool>(nullable: true),
                    fl_credito_ipi = table.Column<bool>(nullable: true),
                    cd_bc_cred_piscofins = table.Column<string>(maxLength: 2, nullable: true),
                    cd_tp_cred_piscofins = table.Column<string>(maxLength: 3, nullable: true),
                    id_tributacao_grupo_pis_cofins = table.Column<int>(nullable: true),
                    fl_credita_icm_proprio_st = table.Column<string>(maxLength: 1, nullable: true),
                    fl_inclui_ipi_base_pis = table.Column<string>(maxLength: 1, nullable: true),
                    fl_inclui_icms_st_base_pis = table.Column<string>(maxLength: 1, nullable: true),
                    ind_presencial = table.Column<string>(maxLength: 1, nullable: true),
                    fl_referenciar_nota = table.Column<char>(nullable: true),
                    fl_info_xml = table.Column<char>(nullable: true),
                    fl_cxa_franquia = table.Column<string>(maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_operacao_es", x => x.cd_operacao);
                    table.ForeignKey(
                        name: "fk_operacao_es_cd_bc_cred_pisco",
                        column: x => x.cd_bc_cred_piscofins,
                        principalTable: "tab_437_sped_piscofins",
                        principalColumn: "cd_bc_credito",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_operacao_es_cxa_conta",
                        column: x => x.cd_conta_movimento,
                        principalTable: "cxa_conta",
                        principalColumn: "cd_conta",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_operacao_es_grupo_op",
                        column: x => x.cd_grupo_op,
                        principalTable: "grupo_operacao_es",
                        principalColumn: "cd_grupo",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_operacao_es_cd_mensagem",
                        column: x => x.cd_mensagem,
                        principalTable: "mensagem_nota",
                        principalColumn: "cd_mensagem",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_operacao_es_cd_modelo",
                        column: x => x.cd_modelo,
                        principalTable: "modelo_dcto",
                        principalColumn: "cd_modelo",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_operacao_es_cd_tp_cred_pisco",
                        column: x => x.cd_tp_cred_piscofins,
                        principalTable: "tab_436_sped_piscofins",
                        principalColumn: "cd_tp_credito",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_operacao_es_id_trib_grupo",
                        column: x => x.id_tributacao_grupo,
                        principalTable: "tributacao_grupo",
                        principalColumn: "id_tributacao_grupo",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_operacao_es_id_trib_pis_cofi",
                        column: x => x.id_tributacao_grupo_pis_cofins,
                        principalTable: "tributacao_grupo_pis_cofins",
                        principalColumn: "cd_tributacao",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "produto",
                columns: table => new
                {
                    cd_produto = table.Column<string>(maxLength: 15, nullable: false),
                    nm_produto = table.Column<string>(maxLength: 120, nullable: false),
                    fl_ativo = table.Column<bool>(nullable: true),
                    cd_gruprod = table.Column<int>(nullable: false),
                    cd_marca = table.Column<int>(nullable: false),
                    box = table.Column<string>(maxLength: 10, nullable: true),
                    un_medida = table.Column<string>(maxLength: 6, nullable: false),
                    peso_liquido = table.Column<double>(nullable: true),
                    cd_original = table.Column<string>(maxLength: 200, nullable: true),
                    qt_estoque_min = table.Column<double>(nullable: true),
                    qt_estoque_max = table.Column<double>(nullable: true),
                    pc_lucro_liquido = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    meses_garantia = table.Column<int>(nullable: true),
                    meses_vida_util = table.Column<int>(nullable: true),
                    qt_venda_media_mes = table.Column<double>(nullable: true),
                    qt_estoque_medio_mes = table.Column<double>(nullable: true),
                    qt_compra_media_mes = table.Column<double>(nullable: true),
                    giro_medio_em_dias = table.Column<double>(nullable: true),
                    aliq_ipi = table.Column<decimal>(type: "numeric(9,2)", nullable: true),
                    obs = table.Column<string>(nullable: true),
                    fl_original = table.Column<bool>(nullable: true),
                    fl_inf_complemento = table.Column<bool>(nullable: true),
                    fl_controlar_estoq = table.Column<bool>(nullable: true),
                    tipo = table.Column<string>(maxLength: 10, nullable: true),
                    cd_subgruprod = table.Column<int>(nullable: true),
                    pc_preco_venda = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    aliq_iss = table.Column<decimal>(type: "numeric(9,2)", nullable: true),
                    fl_servico = table.Column<string>(maxLength: 1, nullable: true),
                    fl_composto = table.Column<string>(maxLength: 1, nullable: true),
                    local_estocagem = table.Column<string>(maxLength: 10, nullable: true),
                    qt_estoque = table.Column<double>(nullable: true),
                    pc_comissao = table.Column<decimal>(type: "numeric(5,2)", nullable: true),
                    cd_aplicacao = table.Column<int>(nullable: true),
                    cd_construcao = table.Column<int>(nullable: true),
                    cd_modelo = table.Column<int>(nullable: true),
                    cd_medida = table.Column<int>(nullable: true),
                    dt_atz = table.Column<DateTime>(type: "date", nullable: true),
                    fl_classfiscal = table.Column<string>(maxLength: 5, nullable: true),
                    cd_grupo_comissao = table.Column<int>(nullable: true),
                    garantia_km = table.Column<int>(nullable: true),
                    nm_reduzido = table.Column<string>(maxLength: 60, nullable: true),
                    fl_validade = table.Column<bool>(nullable: true),
                    qt_dias_validade = table.Column<int>(nullable: true),
                    dias_man_prev = table.Column<int>(nullable: true),
                    fl_contrato = table.Column<bool>(nullable: false),
                    cd_fabricante = table.Column<string>(maxLength: 200, nullable: true),
                    fl_controla_serie = table.Column<bool>(nullable: true),
                    fl_composto_soma_itens = table.Column<string>(maxLength: 1, nullable: true),
                    cd_class_fiscal = table.Column<string>(maxLength: 5, nullable: true),
                    class_lista_servico = table.Column<string>(maxLength: 10, nullable: true),
                    fl_consumo = table.Column<bool>(nullable: true),
                    fl_pesavel = table.Column<bool>(nullable: true),
                    un_compra = table.Column<string>(maxLength: 6, nullable: false),
                    un_armazenagem = table.Column<string>(maxLength: 6, nullable: false),
                    tp_produto = table.Column<string>(maxLength: 2, nullable: true),
                    dt_cadastro = table.Column<DateTime>(type: "date", nullable: true),
                    fl_fitossanitario_sira = table.Column<string>(maxLength: 1, nullable: true),
                    fl_controla_lote = table.Column<bool>(nullable: true),
                    id_tributacao_grupo = table.Column<int>(nullable: true),
                    cd_conta_contabil = table.Column<int>(nullable: true),
                    fl_fracionar = table.Column<char>(nullable: true),
                    cd_tributacao_iss = table.Column<string>(maxLength: 1, nullable: true),
                    fl_cesta_basica = table.Column<string>(maxLength: 1, nullable: true),
                    id_trib_grupo_piscofins = table.Column<int>(nullable: true),
                    qt_estoque_anterior = table.Column<double>(nullable: true),
                    hash_produto_e2 = table.Column<string>(maxLength: 70, nullable: true),
                    hash_produto_p2 = table.Column<string>(maxLength: 70, nullable: true),
                    cd_cfop_regra = table.Column<int>(nullable: true),
                    cd_produto_anp = table.Column<string>(maxLength: 9, nullable: true),
                    cd_fci = table.Column<string>(maxLength: 36, nullable: true),
                    codigo_tributacao_municipio = table.Column<int>(nullable: true),
                    aliq_irrf = table.Column<decimal>(type: "numeric(9,2)", nullable: true),
                    aliq_csll = table.Column<decimal>(type: "numeric(9,2)", nullable: true),
                    fl_retem = table.Column<bool>(nullable: true),
                    aliq_inss = table.Column<decimal>(type: "numeric(9,2)", nullable: true),
                    cst_int = table.Column<string>(maxLength: 3, nullable: true),
                    cst_ext = table.Column<string>(maxLength: 3, nullable: true),
                    pc_subst_trib = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    nm_comercial_fito = table.Column<string>(maxLength: 60, nullable: true),
                    tp_modalidade_fito = table.Column<int>(nullable: true),
                    metodo_fito = table.Column<int>(nullable: true),
                    epoca_fito = table.Column<string>(maxLength: 20, nullable: true),
                    intervalo_fito = table.Column<int>(nullable: true),
                    tp_intervalo_fito = table.Column<int>(nullable: true),
                    class_toxico_fito = table.Column<int>(nullable: true),
                    epi_fito = table.Column<string>(nullable: true),
                    especificacoes_fito = table.Column<string>(nullable: true),
                    precaucoes_fito = table.Column<string>(nullable: true),
                    cd_produto_anvisa = table.Column<string>(maxLength: 5, nullable: true),
                    fl_escala_relevante = table.Column<char>(nullable: true, defaultValueSql: "'S'::bpchar"),
                    cnpj_fabricante = table.Column<string>(maxLength: 20, nullable: true),
                    nome_fabricante = table.Column<string>(maxLength: 70, nullable: true),
                    cod_ajur = table.Column<string>(maxLength: 10, nullable: true),
                    desc_ajur = table.Column<string>(maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_produto", x => x.cd_produto);
                    table.ForeignKey(
                        name: "fk_produto_cfop_regra",
                        column: x => x.cd_cfop_regra,
                        principalTable: "cfop_regra",
                        principalColumn: "cd_cfop_regra",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_produto_class_fiscal",
                        column: x => x.cd_class_fiscal,
                        principalTable: "produto_class_fiscal",
                        principalColumn: "cd_class_fiscal",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "grupo_comissao_produto_fk",
                        column: x => x.cd_grupo_comissao,
                        principalTable: "grupo_comissao",
                        principalColumn: "cd_grupo_comissao",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "produto_cd_gruprod_fkey",
                        column: x => x.cd_gruprod,
                        principalTable: "gruprod",
                        principalColumn: "cd_gruprod",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "produto_cd_marca_fkey",
                        column: x => x.cd_marca,
                        principalTable: "marca",
                        principalColumn: "cd_marca",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_subproduto",
                        column: x => x.cd_subgruprod,
                        principalTable: "subgruprod",
                        principalColumn: "cd_subgruprod",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_produto_tribmuni",
                        column: x => x.codigo_tributacao_municipio,
                        principalTable: "codigo_tributacao_municipio",
                        principalColumn: "cd_tributacao_municipio",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_produto_grupo_trib_piscofins",
                        column: x => x.id_trib_grupo_piscofins,
                        principalTable: "tributacao_grupo_pis_cofins",
                        principalColumn: "cd_tributacao",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_produto_tributacao_grupo",
                        column: x => x.id_tributacao_grupo,
                        principalTable: "tributacao_grupo",
                        principalColumn: "id_tributacao_grupo",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_produto_tp_produto",
                        column: x => x.tp_produto,
                        principalTable: "produto_tipo",
                        principalColumn: "cd_tipo",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_produto_un_armazenagem",
                        column: x => x.un_armazenagem,
                        principalTable: "un_medida",
                        principalColumn: "un_medida",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_produto_un_compra",
                        column: x => x.un_compra,
                        principalTable: "un_medida",
                        principalColumn: "un_medida",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_produto_un_medida",
                        column: x => x.un_medida,
                        principalTable: "un_medida",
                        principalColumn: "un_medida",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "doc_nao_fiscal_i",
                columns: table => new
                {
                    id_geral = table.Column<long>(nullable: false),
                    id_doc_nao_fiscal = table.Column<long>(nullable: false),
                    nm_pagamento = table.Column<string>(maxLength: 25, nullable: false),
                    vl_pago = table.Column<decimal>(type: "numeric(9,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_doc_nao_fiscal_i", x => x.id_geral);
                    table.ForeignKey(
                        name: "fk_doc_n_fiscal_i_doc_n_fisc_c",
                        column: x => x.id_doc_nao_fiscal,
                        principalTable: "doc_nao_fiscal_c",
                        principalColumn: "id_geral",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "reducao_z_totalizador",
                columns: table => new
                {
                    cd_impfiscal = table.Column<int>(nullable: false),
                    dt_reducao = table.Column<DateTime>(type: "date", nullable: false),
                    pc_imposto = table.Column<double>(nullable: false),
                    vl_vendido = table.Column<decimal>(type: "numeric(18,4)", nullable: false),
                    tp_imposto = table.Column<string>(maxLength: 1, nullable: false),
                    nr_ordem = table.Column<int>(nullable: true),
                    hash_reducao_z_totalizador_r3 = table.Column<string>(maxLength: 70, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reducao_z_totalizador", x => new { x.cd_impfiscal, x.dt_reducao, x.pc_imposto, x.tp_imposto });
                    table.ForeignKey(
                        name: "fk_rzt_rz",
                        columns: x => new { x.cd_impfiscal, x.dt_reducao },
                        principalTable: "reducao_z",
                        principalColumns: new[] { "cd_impfiscal", "dt_reducao" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "veiculo_modelo_complemento",
                columns: table => new
                {
                    cd_filial = table.Column<int>(nullable: false),
                    id_geral = table.Column<int>(nullable: false),
                    cd_modelo = table.Column<int>(nullable: false),
                    cd_complemento = table.Column<int>(nullable: false),
                    dt_atz = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_veiculo_modelo_complemento", x => new { x.cd_filial, x.id_geral });
                    table.ForeignKey(
                        name: "fk_veic_compl_mod_complemento",
                        column: x => x.cd_complemento,
                        principalTable: "veiculo_complemento",
                        principalColumn: "cd_complemento",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_veic_compl_mod_veiculo",
                        columns: x => new { x.cd_filial, x.cd_modelo },
                        principalTable: "veiculo",
                        principalColumns: new[] { "cd_filial", "cd_veiculo" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "veiculo_modelo_injecao",
                columns: table => new
                {
                    cd_filial = table.Column<int>(nullable: false),
                    id_geral = table.Column<int>(nullable: false),
                    cd_modelo = table.Column<int>(nullable: false),
                    cd_injecao = table.Column<int>(nullable: false),
                    dt_atz = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_veiculo_modelo_injecao", x => new { x.cd_filial, x.id_geral });
                    table.ForeignKey(
                        name: "fk_veic_inj_mod_injecao",
                        column: x => x.cd_injecao,
                        principalTable: "veiculo_injecao",
                        principalColumn: "cd_injecao",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_veic_inj_mod_veiculo",
                        columns: x => new { x.cd_filial, x.cd_modelo },
                        principalTable: "veiculo",
                        principalColumns: new[] { "cd_filial", "cd_veiculo" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "veiculo_modelo_motor",
                columns: table => new
                {
                    cd_filial = table.Column<int>(nullable: false),
                    id_geral = table.Column<int>(nullable: false),
                    cd_modelo = table.Column<int>(nullable: false),
                    cd_motor = table.Column<int>(nullable: false),
                    dt_atz = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_veiculo_modelo_motor", x => new { x.cd_filial, x.id_geral });
                    table.ForeignKey(
                        name: "fk_veic_mot_mod_injecao",
                        column: x => x.cd_motor,
                        principalTable: "veiculo_motor",
                        principalColumn: "cd_motor",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_veic_mot_mod_veiculo",
                        columns: x => new { x.cd_filial, x.cd_modelo },
                        principalTable: "veiculo",
                        principalColumns: new[] { "cd_filial", "cd_veiculo" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "veiculo_modelo_transmissao",
                columns: table => new
                {
                    cd_filial = table.Column<int>(nullable: false),
                    id_geral = table.Column<int>(nullable: false),
                    cd_modelo = table.Column<int>(nullable: false),
                    cd_transmissao = table.Column<int>(nullable: false),
                    dt_atz = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_veiculo_modelo_transmissao", x => new { x.cd_filial, x.id_geral });
                    table.ForeignKey(
                        name: "fk_veic_trans_mod_injecao",
                        column: x => x.cd_transmissao,
                        principalTable: "veiculo_transmissao",
                        principalColumn: "cd_transmissao",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_veic_trans_mod_veiculo",
                        columns: x => new { x.cd_filial, x.cd_modelo },
                        principalTable: "veiculo",
                        principalColumns: new[] { "cd_filial", "cd_veiculo" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "agronomo",
                columns: table => new
                {
                    cd_agronomo = table.Column<int>(nullable: false),
                    nm_agronomo = table.Column<string>(maxLength: 34, nullable: true),
                    cpf = table.Column<string>(maxLength: 18, nullable: false),
                    rg = table.Column<string>(maxLength: 20, nullable: true),
                    endereco = table.Column<string>(maxLength: 40, nullable: true),
                    bairro = table.Column<string>(maxLength: 25, nullable: true),
                    complemento = table.Column<string>(maxLength: 10, nullable: true),
                    numero = table.Column<int>(nullable: true),
                    cd_crea = table.Column<int>(nullable: true),
                    crea_registro = table.Column<string>(maxLength: 20, nullable: true),
                    telefone = table.Column<string>(maxLength: 20, nullable: true),
                    celular = table.Column<string>(maxLength: 20, nullable: true),
                    email = table.Column<string>(maxLength: 40, nullable: true),
                    obs = table.Column<string>(nullable: true),
                    cd_cidade = table.Column<int>(nullable: true),
                    cd_filial = table.Column<int>(nullable: false),
                    cep = table.Column<string>(maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_agronomo", x => new { x.cd_agronomo, x.cpf, x.cd_filial });
                    table.ForeignKey(
                        name: "fk_agronomo_cidade",
                        column: x => x.cd_cidade,
                        principalTable: "cidade",
                        principalColumn: "cd_cidade",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "contato",
                columns: table => new
                {
                    id_contato = table.Column<int>(nullable: false),
                    nm_contato = table.Column<string>(maxLength: 60, nullable: true),
                    departamento = table.Column<string>(maxLength: 30, nullable: true),
                    telefone = table.Column<string>(maxLength: 20, nullable: true),
                    e_mail = table.Column<string>(maxLength: 70, nullable: true),
                    dt_nascimento = table.Column<DateTime>(type: "date", nullable: true),
                    endereco_logradouro = table.Column<string>(maxLength: 80, nullable: true),
                    endereco_numero = table.Column<short>(nullable: true),
                    endereco_complemento = table.Column<string>(maxLength: 20, nullable: true),
                    bairro = table.Column<string>(maxLength: 80, nullable: true),
                    cd_cidade = table.Column<int>(nullable: true),
                    cep = table.Column<string>(maxLength: 10, nullable: true),
                    fone_comercial = table.Column<string>(maxLength: 20, nullable: true),
                    fax = table.Column<string>(maxLength: 20, nullable: true),
                    celular = table.Column<string>(maxLength: 20, nullable: true),
                    obs = table.Column<string>(maxLength: 255, nullable: true),
                    tp_contato = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contato", x => x.id_contato);
                    table.ForeignKey(
                        name: "fk_contato_cidade",
                        column: x => x.cd_cidade,
                        principalTable: "cidade",
                        principalColumn: "cd_cidade",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "motorista",
                columns: table => new
                {
                    cd_filial = table.Column<int>(nullable: false),
                    cd_motorista = table.Column<int>(nullable: false),
                    cd_cidade = table.Column<int>(nullable: false),
                    cd_transportador = table.Column<int>(nullable: false),
                    nome = table.Column<string>(maxLength: 80, nullable: true),
                    cpf = table.Column<string>(maxLength: 11, nullable: true),
                    cnh = table.Column<string>(maxLength: 11, nullable: true),
                    telefone = table.Column<string>(maxLength: 15, nullable: true),
                    celular = table.Column<string>(maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_motorista", x => x.cd_motorista);
                    table.ForeignKey(
                        name: "fk_motorista_cidade",
                        column: x => x.cd_cidade,
                        principalTable: "cidade",
                        principalColumn: "cd_cidade",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_motorista_transportador",
                        columns: x => new { x.cd_filial, x.cd_transportador },
                        principalTable: "fornecedor",
                        principalColumns: new[] { "cd_filial", "cd_fornecedor" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tributacao_aliquota",
                columns: table => new
                {
                    id_geral = table.Column<int>(nullable: false),
                    id_tributacao = table.Column<int>(nullable: false),
                    cst = table.Column<string>(maxLength: 4, nullable: false),
                    cd_mensagem = table.Column<int>(nullable: true),
                    dt_atz = table.Column<DateTime>(type: "date", nullable: true),
                    hash_tributacao_aliquota_d3 = table.Column<string>(maxLength: 70, nullable: true),
                    hash_tributacao_aliquota_p2 = table.Column<string>(maxLength: 70, nullable: true),
                    tp_tributacao = table.Column<string>(maxLength: 1, nullable: false),
                    icm_aliq_normal = table.Column<double>(nullable: true),
                    icm_aliq_proprio = table.Column<double>(nullable: true),
                    icm_aliq_subst = table.Column<double>(nullable: true),
                    icm_red_normal = table.Column<double>(nullable: true),
                    icm_red_proprio = table.Column<double>(nullable: true),
                    icm_red_subst = table.Column<double>(nullable: true),
                    fl_reducao_aliq_normal = table.Column<string>(maxLength: 1, nullable: true),
                    fl_reducao_aliq_proprio = table.Column<string>(maxLength: 1, nullable: true),
                    fl_reducao_aliq_subst = table.Column<string>(maxLength: 1, nullable: true),
                    aliq_fcp = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tributacao_aliquota", x => x.id_geral);
                    table.ForeignKey(
                        name: "fk_tributacao_aliquota_mensagem",
                        column: x => x.cd_mensagem,
                        principalTable: "mensagem_nota",
                        principalColumn: "cd_mensagem",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_tributacao_aliquota_1",
                        column: x => x.cst,
                        principalTable: "cst",
                        principalColumn: "cd_cst",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_tributacao_aliquota_tributac",
                        column: x => x.id_tributacao,
                        principalTable: "tributacao",
                        principalColumn: "id_geral",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "administradora_taxas",
                columns: table => new
                {
                    cd_administradora = table.Column<int>(nullable: false),
                    qt_parcelas = table.Column<int>(nullable: false),
                    pc_cobranca_loja = table.Column<decimal>(type: "numeric(9,3)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_administradora_taxas", x => new { x.cd_administradora, x.qt_parcelas });
                    table.ForeignKey(
                        name: "fk_administradora_taxas_cd_adm",
                        column: x => x.cd_administradora,
                        principalTable: "administradora",
                        principalColumn: "cd_administradora",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "cargo",
                columns: table => new
                {
                    cd_filial = table.Column<int>(nullable: false),
                    cd_cargo = table.Column<int>(nullable: false),
                    descricao = table.Column<string>(maxLength: 40, nullable: false),
                    fl_libera_limite = table.Column<bool>(nullable: true),
                    dt_atz = table.Column<DateTime>(type: "date", nullable: false, defaultValueSql: "'2018-10-26'::date"),
                    fl_comissao_total = table.Column<string>(maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cargo", x => new { x.cd_cargo, x.cd_filial });
                    table.ForeignKey(
                        name: "filial_cargo_fk",
                        column: x => x.cd_filial,
                        principalTable: "filial",
                        principalColumn: "cd_filial",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "cob_retorno",
                columns: table => new
                {
                    cd_retorno = table.Column<long>(nullable: false),
                    cd_filial = table.Column<int>(nullable: true),
                    nr_retorno = table.Column<string>(maxLength: 20, nullable: false),
                    fl_processado = table.Column<string>(maxLength: 1, nullable: true),
                    arquivo = table.Column<string>(nullable: true),
                    cd_convenio = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cob_retorno", x => x.cd_retorno);
                    table.ForeignKey(
                        name: "fk_cob_retorno_filial",
                        column: x => x.cd_filial,
                        principalTable: "filial",
                        principalColumn: "cd_filial",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "conf_sped_pis_cofins",
                columns: table => new
                {
                    id_geral = table.Column<int>(nullable: false),
                    tipo_escrit = table.Column<string>(maxLength: 1, nullable: false),
                    ind_sit_esp = table.Column<string>(maxLength: 1, nullable: true),
                    ind_nat_pj = table.Column<string>(maxLength: 2, nullable: true),
                    ind_ativ = table.Column<string>(maxLength: 1, nullable: false),
                    cod_inc_trib = table.Column<int>(nullable: false),
                    ind_apro_cred = table.Column<int>(nullable: true),
                    cod_tipo_cont = table.Column<int>(nullable: true),
                    ind_reg_cu = table.Column<int>(nullable: true),
                    cd_filial = table.Column<int>(nullable: false),
                    cod_ver = table.Column<string>(maxLength: 10, nullable: true),
                    fl_base_pis_lucro_veic = table.Column<string>(maxLength: 1, nullable: true),
                    ind_escri = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_conf_sped_pis_cofins", x => x.id_geral);
                    table.ForeignKey(
                        name: "fk_conf_sped_pis_cofins_filial",
                        column: x => x.cd_filial,
                        principalTable: "filial",
                        principalColumn: "cd_filial",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "doc_producao",
                columns: table => new
                {
                    cd_filial = table.Column<int>(nullable: false),
                    nr_documento = table.Column<int>(nullable: false),
                    nr_ordem_producao = table.Column<int>(nullable: true),
                    id_nfec = table.Column<int>(nullable: false),
                    id_nfsc = table.Column<int>(nullable: false),
                    cd_cancelamento = table.Column<int>(nullable: false),
                    qt_produzido = table.Column<double>(nullable: true),
                    dt_producao = table.Column<DateTime>(type: "date", nullable: false),
                    dt_emissao = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_doc_producao", x => x.nr_documento);
                    table.ForeignKey(
                        name: "fk_doc_producao_filial",
                        column: x => x.cd_filial,
                        principalTable: "filial",
                        principalColumn: "cd_filial",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "filial_email",
                columns: table => new
                {
                    id_geral = table.Column<int>(nullable: false),
                    cd_filial = table.Column<int>(nullable: true),
                    tp_email = table.Column<int>(nullable: true),
                    nm_origem = table.Column<string>(maxLength: 50, nullable: true),
                    servidor_smtp = table.Column<string>(maxLength: 50, nullable: true),
                    email = table.Column<string>(maxLength: 100, nullable: true),
                    usuario = table.Column<string>(maxLength: 100, nullable: true),
                    senha = table.Column<string>(maxLength: 50, nullable: true),
                    ssl = table.Column<string>(maxLength: 1, nullable: true),
                    porta = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_filial_email", x => x.id_geral);
                    table.ForeignKey(
                        name: "fk_filial_email_filial",
                        column: x => x.cd_filial,
                        principalTable: "filial",
                        principalColumn: "cd_filial",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "filial_ie_st",
                columns: table => new
                {
                    cd_filial = table.Column<int>(nullable: false),
                    uf = table.Column<string>(maxLength: 2, nullable: false),
                    ie_st = table.Column<string>(maxLength: 18, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_filial_ie_st", x => new { x.cd_filial, x.uf });
                    table.ForeignKey(
                        name: "fk_filial_ie_st_filial",
                        column: x => x.cd_filial,
                        principalTable: "filial",
                        principalColumn: "cd_filial",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "fornveic",
                columns: table => new
                {
                    cd_filial = table.Column<int>(nullable: false),
                    id_geral = table.Column<int>(nullable: false),
                    cd_fornecedor = table.Column<int>(nullable: false),
                    cd_veiculo = table.Column<int>(nullable: false),
                    tp_rodado = table.Column<int>(nullable: false),
                    tp_carroceria = table.Column<int>(nullable: false),
                    tara = table.Column<decimal>(type: "numeric(9,2)", nullable: false),
                    capacidade = table.Column<decimal>(type: "numeric(9,2)", nullable: false),
                    placa_veiculo = table.Column<string>(maxLength: 8, nullable: true),
                    uf = table.Column<string>(maxLength: 2, nullable: true),
                    observacoes = table.Column<string>(maxLength: 2000, nullable: true),
                    dt_atz = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_fornveic", x => new { x.cd_filial, x.id_geral });
                    table.ForeignKey(
                        name: "fk_fornveic_filial",
                        column: x => x.cd_filial,
                        principalTable: "filial",
                        principalColumn: "cd_filial",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_fornveic_fornecedor",
                        columns: x => new { x.cd_filial, x.cd_fornecedor },
                        principalTable: "fornecedor",
                        principalColumns: new[] { "cd_filial", "cd_fornecedor" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_fornveic_veiculo",
                        columns: x => new { x.cd_filial, x.cd_veiculo },
                        principalTable: "veiculo",
                        principalColumns: new[] { "cd_filial", "cd_veiculo" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "crptitulo_movimento_cxa",
                columns: table => new
                {
                    cd_filial = table.Column<int>(nullable: false),
                    cd_tipo_conta = table.Column<int>(nullable: false),
                    cd_clifor = table.Column<int>(nullable: false),
                    nr_titulo = table.Column<string>(maxLength: 15, nullable: false),
                    parcela = table.Column<int>(nullable: false),
                    nr_lcto = table.Column<int>(nullable: false),
                    cd_caixa = table.Column<int>(nullable: false),
                    dt_atz = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_crptitulo_movimento_cxa", x => new { x.cd_filial, x.cd_tipo_conta, x.cd_clifor, x.nr_titulo, x.parcela, x.nr_lcto, x.cd_caixa });
                    table.ForeignKey(
                        name: "fk_crptitulo_movimento_cxa",
                        columns: x => new { x.cd_filial, x.cd_caixa, x.nr_lcto },
                        principalTable: "movimento_cxa",
                        principalColumns: new[] { "cd_filial", "cd_caixa", "nr_lcto" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_crptitulo_movimento_cxa_1",
                        columns: x => new { x.cd_filial, x.cd_tipo_conta, x.cd_clifor, x.nr_titulo, x.parcela },
                        principalTable: "crptitulo",
                        principalColumns: new[] { "cd_filial", "cd_tipo_conta", "cd_clifor", "nr_titulo", "parcela" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "comissao_func_dev",
                columns: table => new
                {
                    cd_filial = table.Column<int>(nullable: false),
                    nr_documento = table.Column<int>(nullable: false),
                    nr_sequencia = table.Column<int>(nullable: false),
                    cd_funcionario = table.Column<int>(nullable: false),
                    nr_parcela = table.Column<int>(nullable: false),
                    nr_sequencia_dev = table.Column<int>(nullable: false),
                    vl_base = table.Column<double>(nullable: false),
                    pc_comissao = table.Column<double>(nullable: false),
                    vl_comissao = table.Column<double>(nullable: false),
                    id_nfec_dev = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_comissao_func_dev", x => new { x.cd_filial, x.nr_documento, x.nr_sequencia, x.cd_funcionario, x.nr_parcela, x.nr_sequencia_dev });
                    table.ForeignKey(
                        name: "fk_comissao_func_dev_nfec",
                        column: x => x.id_nfec_dev,
                        principalTable: "nfec",
                        principalColumn: "id_geral",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "nfec_conhecimento",
                columns: table => new
                {
                    id_nfec = table.Column<int>(nullable: false),
                    vl_frete_volume = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_frete = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_sec_cat = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_pedagio = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_outros = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    tp_cte = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nfec_conhecimento", x => x.id_nfec);
                    table.ForeignKey(
                        name: "fk_nfec_conhecimento_nfec",
                        column: x => x.id_nfec,
                        principalTable: "nfec",
                        principalColumn: "id_geral",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "nfec_energia_eletrica",
                columns: table => new
                {
                    id_nfec = table.Column<int>(nullable: false),
                    cod_cons = table.Column<string>(maxLength: 2, nullable: true),
                    tp_ligacao = table.Column<int>(nullable: true),
                    cod_grupo_tensao = table.Column<string>(maxLength: 2, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nfec_energia_eletrica", x => x.id_nfec);
                    table.ForeignKey(
                        name: "fk_nfec_energia_eletrica_1",
                        column: x => x.id_nfec,
                        principalTable: "nfec",
                        principalColumn: "id_geral",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "nfec_importacao",
                columns: table => new
                {
                    id_geral = table.Column<int>(nullable: false),
                    id_nfec = table.Column<int>(nullable: false),
                    nr_di = table.Column<string>(maxLength: 10, nullable: false),
                    dt_di = table.Column<DateTime>(type: "date", nullable: false),
                    cd_cidade_desembaraco = table.Column<int>(nullable: false),
                    dt_desembaraco = table.Column<DateTime>(type: "date", nullable: false),
                    vl_base_ii = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    vl_ii = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    vl_siscomex = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    vl_desp_aduaneira = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    vl_iof = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    taxa_dolar = table.Column<decimal>(type: "numeric(9,2)", nullable: true),
                    fl_custo_ii = table.Column<string>(maxLength: 1, nullable: true),
                    fl_custo_ipi = table.Column<string>(maxLength: 1, nullable: true),
                    fl_custo_icm = table.Column<string>(maxLength: 1, nullable: true),
                    fl_custo_pis_cofins = table.Column<string>(maxLength: 1, nullable: true),
                    tp_viatransp = table.Column<int>(nullable: true),
                    vl_afrmm = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    tp_intermedio = table.Column<int>(nullable: true),
                    cgc_cpf_adquirente = table.Column<string>(maxLength: 18, nullable: true),
                    uf_terceiro = table.Column<string>(maxLength: 3, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nfec_importacao", x => x.id_geral);
                    table.ForeignKey(
                        name: "fk_nfec_importacao_nfec",
                        column: x => x.id_nfec,
                        principalTable: "nfec",
                        principalColumn: "id_geral",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "nfec_mensagem",
                columns: table => new
                {
                    id_geral = table.Column<int>(nullable: false),
                    cd_mensagem = table.Column<int>(nullable: false),
                    mensagem = table.Column<string>(nullable: false),
                    id_nfec = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nfec_mensagem", x => x.id_geral);
                    table.ForeignKey(
                        name: "fk_nfec_mensagem_nota",
                        column: x => x.cd_mensagem,
                        principalTable: "mensagem_nota",
                        principalColumn: "cd_mensagem",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_nfec_mensagem_nfec",
                        column: x => x.id_nfec,
                        principalTable: "nfec",
                        principalColumn: "id_geral",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "orcamento_nfe",
                columns: table => new
                {
                    nr_os = table.Column<int>(nullable: false),
                    id_nfec = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orcamento_nfe", x => new { x.nr_os, x.id_nfec });
                    table.ForeignKey(
                        name: "fk_orcamento_nfe_nfec",
                        column: x => x.id_nfec,
                        principalTable: "nfec",
                        principalColumn: "id_geral",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "frente_caixa",
                columns: table => new
                {
                    cd_frente_caixa = table.Column<int>(nullable: false),
                    nm_frente_caixa = table.Column<string>(maxLength: 60, nullable: false),
                    fl_utilizado = table.Column<string>(maxLength: 1, nullable: false),
                    cd_operacao = table.Column<int>(nullable: false),
                    cd_tabela_preco = table.Column<int>(nullable: false),
                    importa = table.Column<string>(maxLength: 200, nullable: false),
                    exporta = table.Column<string>(maxLength: 200, nullable: false),
                    nome_arquivo = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_frente_caixa", x => x.cd_frente_caixa);
                    table.ForeignKey(
                        name: "fk_frente_caixa_1",
                        column: x => x.cd_operacao,
                        principalTable: "operacao_es",
                        principalColumn: "cd_operacao",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_frente_caixa_2",
                        column: x => x.cd_tabela_preco,
                        principalTable: "tabela_preco",
                        principalColumn: "cd_tabela_preco",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "operacao_cfop_regra",
                columns: table => new
                {
                    id_geral = table.Column<int>(nullable: false),
                    cd_operacao = table.Column<int>(nullable: false),
                    cd_cfop_regra = table.Column<int>(nullable: false),
                    cfop_int_cont = table.Column<string>(maxLength: 20, nullable: false),
                    cfop_int_ncont = table.Column<string>(maxLength: 20, nullable: false),
                    cfop_ext_cont = table.Column<string>(maxLength: 20, nullable: false),
                    cfop_ext_ncont = table.Column<string>(maxLength: 20, nullable: false),
                    cfop_subst_int_cont = table.Column<string>(maxLength: 10, nullable: true),
                    cfop_subst_int_ncont = table.Column<string>(maxLength: 10, nullable: true),
                    cfop_subst_ext_cont = table.Column<string>(maxLength: 10, nullable: true),
                    cfop_subst_ext_ncont = table.Column<string>(maxLength: 10, nullable: true),
                    cfop_subst_int_ncont_ret = table.Column<string>(maxLength: 10, nullable: true),
                    cfop_subst_int_cont_ret = table.Column<string>(maxLength: 10, nullable: true),
                    cfop_subst_ext_cont_ret = table.Column<string>(maxLength: 10, nullable: true),
                    cfop_subst_ext_ncont_ret = table.Column<string>(maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_operacao_cfop_regra", x => x.id_geral);
                    table.ForeignKey(
                        name: "fk_operacao_cfop_regra_1",
                        column: x => x.cd_cfop_regra,
                        principalTable: "cfop_regra",
                        principalColumn: "cd_cfop_regra",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_operacao_cfop_regra_2",
                        column: x => x.cd_operacao,
                        principalTable: "operacao_es",
                        principalColumn: "cd_operacao",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "estoque",
                columns: table => new
                {
                    cd_filial = table.Column<int>(nullable: false),
                    cd_produto = table.Column<string>(maxLength: 15, nullable: false),
                    ano = table.Column<int>(nullable: false),
                    mes = table.Column<int>(nullable: false),
                    qt_entradas = table.Column<double>(nullable: true),
                    qt_saidas = table.Column<double>(nullable: true),
                    qtde = table.Column<double>(nullable: true),
                    dt_atz = table.Column<DateTime>(type: "date", nullable: true, defaultValueSql: "CURRENT_DATE"),
                    qt_entradas2 = table.Column<double>(nullable: true),
                    qt_saidas2 = table.Column<double>(nullable: true),
                    qtde2 = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_estoque", x => new { x.cd_filial, x.cd_produto, x.mes, x.ano });
                    table.ForeignKey(
                        name: "fk_estproduto",
                        column: x => x.cd_produto,
                        principalTable: "produto",
                        principalColumn: "cd_produto",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "nfei",
                columns: table => new
                {
                    nr_sequencia = table.Column<int>(nullable: false),
                    cd_prodserv = table.Column<string>(maxLength: 15, nullable: false),
                    fl_servico = table.Column<string>(maxLength: 1, nullable: true),
                    qt_produto = table.Column<double>(nullable: true),
                    vl_bruto = table.Column<decimal>(type: "numeric(18,8)", nullable: true),
                    vl_total = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    dt_lancamento = table.Column<DateTime>(type: "date", nullable: false, defaultValueSql: "CURRENT_DATE"),
                    peso_liquido = table.Column<double>(nullable: true),
                    cd_atualizacao = table.Column<int>(nullable: true),
                    cst = table.Column<string>(maxLength: 4, nullable: true),
                    pc_red_base_icm = table.Column<decimal>(type: "numeric(9,2)", nullable: true),
                    aliq_icm = table.Column<decimal>(type: "numeric(9,2)", nullable: true),
                    aliq_icm_subst = table.Column<decimal>(type: "numeric(9,2)", nullable: true),
                    aliq_ipi = table.Column<decimal>(type: "numeric(9,2)", nullable: true),
                    aliq_iss = table.Column<decimal>(type: "numeric(9,2)", nullable: true),
                    vl_base_icm = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_icm = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_icm_subst = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_ipi = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_iss = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    compl = table.Column<string>(nullable: true),
                    nm_produto = table.Column<string>(maxLength: 50, nullable: true),
                    dt_atz = table.Column<DateTime>(type: "date", nullable: true, defaultValueSql: "CURRENT_DATE"),
                    un_medida = table.Column<string>(maxLength: 6, nullable: true),
                    pc_desconto = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_base_icm_subst = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    cd_conta = table.Column<int>(nullable: true),
                    fator_conversao = table.Column<double>(nullable: true),
                    fl_controlar_estoque = table.Column<string>(maxLength: 1, nullable: true),
                    pc_markup = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    cfop = table.Column<string>(maxLength: 10, nullable: true),
                    vl_desconto = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_desconto_rateado = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_acrescimo_rateado = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_frete_rateado = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_seguro_rateado = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_contabil = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_outros = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_isento = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    aliq_pis = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_base_pis = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_pis = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    aliq_cofins = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_base_cofins = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_cofins = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_base_iss = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_base_ipi = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    aliq_icm_proprio_st = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_base_icm_proprio_st = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_icm_proprio_st = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    aliq_icm_subst_real = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_base_icm_subst_real = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_icm_subst_real = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    aliq_uf_destino = table.Column<decimal>(type: "numeric(6,2)", nullable: true),
                    pc_red_base_icm_subst = table.Column<decimal>(type: "numeric(6,2)", nullable: true),
                    pc_red_base_icm_proprio_st = table.Column<decimal>(type: "numeric(6,2)", nullable: true),
                    qt_compra = table.Column<double>(nullable: true),
                    un_compra = table.Column<string>(maxLength: 6, nullable: true),
                    vl_unitario = table.Column<decimal>(type: "numeric(18,8)", nullable: true),
                    vl_unitario_compra = table.Column<decimal>(type: "numeric(18,8)", nullable: true),
                    cst_ipi = table.Column<string>(maxLength: 2, nullable: true),
                    cst_pis = table.Column<string>(maxLength: 2, nullable: true),
                    cst_cofins = table.Column<string>(maxLength: 2, nullable: true),
                    id_geral = table.Column<int>(nullable: false),
                    id_nfec = table.Column<int>(nullable: true),
                    conhecimento_vl_frete = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    conhecimento_base_icm = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    conhecimento_vl_icm = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    conhecimento_base_st = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    conhecimento_vl_st = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_icm_frete = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    cst_ori = table.Column<string>(maxLength: 4, nullable: true),
                    aliq_icm_ori = table.Column<double>(nullable: true),
                    pc_red_base_icm_ori = table.Column<double>(nullable: true),
                    vl_base_icm_ori = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_icm_ori = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    aliq_icm_proprio_st_ori = table.Column<double>(nullable: true),
                    pc_red_base_icm_proprio_st_ori = table.Column<double>(nullable: true),
                    vl_base_icm_proprio_st_ori = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_icm_proprio_st_ori = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    mva_ori = table.Column<double>(nullable: true),
                    aliq_icm_subst_ori = table.Column<double>(nullable: true),
                    pc_red_base_icm_subst_ori = table.Column<double>(nullable: true),
                    vl_base_icm_subst_ori = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_icm_subst_ori = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    cfop_ori = table.Column<string>(maxLength: 10, nullable: true),
                    vl_base_icm_subst_ant = table.Column<decimal>(type: "numeric(9,2)", nullable: true),
                    vl_icm_subst_ant = table.Column<decimal>(type: "numeric(9,2)", nullable: true),
                    fl_soma_total = table.Column<string>(maxLength: 1, nullable: true),
                    fl_validado = table.Column<char>(nullable: true),
                    classificacao_ctbl = table.Column<string>(maxLength: 3, nullable: true),
                    vl_outras_despesas = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    vl_icm_subst_dev = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_base_icm_subst_dev = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    alic_icm_subst_dev = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    pc_red_base_icm_subst_dev = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_base_ipi_dev = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_ipi_dev = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    alic_ipi_dev = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    mva_dev = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    icms_normal_dif_pc_aliq = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    icms_normal_dif_vl_base = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    icms_normal_dif_valor = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    natureza_frete = table.Column<int>(nullable: true),
                    nr_sequencia_dev = table.Column<int>(nullable: true),
                    pc_fcp = table.Column<decimal>(type: "numeric(4,4)", nullable: true),
                    vl_fcp = table.Column<decimal>(type: "numeric(13,2)", nullable: true),
                    vl_base_fcp = table.Column<decimal>(type: "numeric(13,2)", nullable: true),
                    vl_base_fcp_st = table.Column<decimal>(type: "numeric(13,2)", nullable: true),
                    pc_fcp_st = table.Column<decimal>(type: "numeric(4,4)", nullable: true),
                    vl_fcp_st = table.Column<decimal>(type: "numeric(13,2)", nullable: true),
                    vl_fcp_st_retido = table.Column<decimal>(type: "numeric(13,2)", nullable: true),
                    pc_fcp_st_retido = table.Column<decimal>(type: "numeric(4,4)", nullable: true),
                    vl_base_fcp_st_retido = table.Column<decimal>(type: "numeric(13,2)", nullable: true),
                    vl_base_fcp_uf_destino = table.Column<decimal>(type: "numeric(13,2)", nullable: true),
                    pc_fcp_uf_destino = table.Column<decimal>(type: "numeric(4,4)", nullable: true),
                    vl_fcp_uf_destino = table.Column<decimal>(type: "numeric(13,2)", nullable: true),
                    vl_base_uf_destino = table.Column<decimal>(type: "numeric(13,2)", nullable: true),
                    pc_icms_uf_destino = table.Column<decimal>(type: "numeric(4,4)", nullable: true),
                    pc_icms_interno = table.Column<decimal>(type: "numeric(2,2)", nullable: true),
                    pc_icms_interno_partilha = table.Column<decimal>(type: "numeric(4,4)", nullable: true),
                    vl_icms_uf_destino = table.Column<decimal>(type: "numeric(13,2)", nullable: true),
                    vl_icms_uf_remetente = table.Column<decimal>(type: "numeric(13,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nfei", x => x.id_geral);
                    table.ForeignKey(
                        name: "fk_nfei_cxa_conta",
                        column: x => x.cd_conta,
                        principalTable: "cxa_conta",
                        principalColumn: "cd_conta",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_nfeproduto",
                        column: x => x.cd_prodserv,
                        principalTable: "produto",
                        principalColumn: "cd_produto",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_nfei_nfec",
                        column: x => x.id_nfec,
                        principalTable: "nfec",
                        principalColumn: "id_geral",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "orcamento_i",
                columns: table => new
                {
                    cd_filial = table.Column<int>(nullable: false),
                    nr_os = table.Column<int>(nullable: false),
                    nr_sequencia = table.Column<int>(nullable: false),
                    cd_produto = table.Column<string>(maxLength: 15, nullable: false),
                    nm_produto = table.Column<string>(maxLength: 60, nullable: true),
                    un_medida = table.Column<string>(maxLength: 6, nullable: true),
                    fl_servico = table.Column<string>(maxLength: 1, nullable: true),
                    qt_produto = table.Column<double>(nullable: true),
                    box = table.Column<string>(maxLength: 10, nullable: true),
                    local_estocagem = table.Column<string>(maxLength: 40, nullable: true),
                    vl_bruto = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    pc_desconto = table.Column<decimal>(type: "numeric(9,2)", nullable: true),
                    vl_liquido = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_total = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    dt_emissao = table.Column<DateTime>(type: "date", nullable: false, defaultValueSql: "CURRENT_DATE"),
                    complemento = table.Column<string>(nullable: true),
                    cd_funcionario = table.Column<int>(nullable: true),
                    vl_custo = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    dt_atz = table.Column<DateTime>(type: "date", nullable: true, defaultValueSql: "CURRENT_DATE"),
                    cd_original = table.Column<string>(maxLength: 20, nullable: true),
                    cd_barras = table.Column<string>(maxLength: 20, nullable: true),
                    placa_veiculo = table.Column<string>(maxLength: 8, nullable: true),
                    kilometragem = table.Column<int>(nullable: true),
                    vl_ipi = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    nr_serie_equip = table.Column<string>(maxLength: 32, nullable: true),
                    pc_acrescimo = table.Column<decimal>(type: "numeric(9,2)", nullable: true),
                    vl_desconto = table.Column<decimal>(type: "numeric(9,2)", nullable: true),
                    vl_acrescimo = table.Column<decimal>(type: "numeric(9,2)", nullable: true),
                    fator_conversao = table.Column<double>(nullable: true),
                    qt_venda = table.Column<double>(nullable: true),
                    un_venda = table.Column<string>(maxLength: 6, nullable: true),
                    fl_item_cancelado = table.Column<bool>(nullable: true),
                    hash_orcamento_i_d3 = table.Column<string>(maxLength: 70, nullable: true),
                    fl_reservando_estoque = table.Column<bool>(nullable: true),
                    fl_alteracao = table.Column<string>(maxLength: 1, nullable: true),
                    hr_alteracao = table.Column<string>(maxLength: 6, nullable: true),
                    cd_ped_comp = table.Column<string>(maxLength: 15, nullable: true),
                    nr_item_ped_comp = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orcamento_i", x => new { x.cd_filial, x.nr_os, x.nr_sequencia });
                    table.ForeignKey(
                        name: "fk_orcproduto",
                        column: x => x.cd_produto,
                        principalTable: "produto",
                        principalColumn: "cd_produto",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ordem_producao_i",
                columns: table => new
                {
                    id_geral = table.Column<long>(nullable: false),
                    id_ordem_producao_c = table.Column<long>(nullable: false),
                    cd_item = table.Column<string>(maxLength: 15, nullable: false),
                    qt_producao = table.Column<double>(nullable: true),
                    qt_produzido = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ordem_producao_i", x => x.id_geral);
                    table.ForeignKey(
                        name: "fk_ordem_producao_i_cd_produto",
                        column: x => x.cd_item,
                        principalTable: "produto",
                        principalColumn: "cd_produto",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_ordem_producao_i_id_ordem_c",
                        column: x => x.id_ordem_producao_c,
                        principalTable: "ordem_producao_c",
                        principalColumn: "id_geral",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "prod_composto",
                columns: table => new
                {
                    cd_produto = table.Column<string>(maxLength: 15, nullable: false),
                    cd_composto = table.Column<string>(maxLength: 15, nullable: false),
                    qt_composto = table.Column<double>(nullable: true),
                    nm_prodcomposto = table.Column<string>(maxLength: 62, nullable: false),
                    dt_atz = table.Column<DateTime>(type: "date", nullable: true, defaultValueSql: "CURRENT_DATE"),
                    qt_liquido = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_prod_composto", x => new { x.cd_produto, x.cd_composto });
                    table.ForeignKey(
                        name: "fk_updtpproduto",
                        column: x => x.cd_produto,
                        principalTable: "produto",
                        principalColumn: "cd_produto",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "produto_lote",
                columns: table => new
                {
                    id_geral = table.Column<int>(nullable: false),
                    id_nfec = table.Column<int>(nullable: true),
                    cd_produto = table.Column<string>(maxLength: 14, nullable: false),
                    nr_lote = table.Column<string>(maxLength: 10, nullable: false),
                    dt_fabricacao = table.Column<DateTime>(type: "date", nullable: true),
                    dt_validade = table.Column<DateTime>(type: "date", nullable: true),
                    qt_entrada = table.Column<double>(nullable: true),
                    qt_saida = table.Column<double>(nullable: true),
                    id_nfsc = table.Column<int>(nullable: true),
                    dt_lancamento_lote = table.Column<DateTime>(type: "date", nullable: true),
                    nr_sequencial = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_produto_lote", x => x.id_geral);
                    table.ForeignKey(
                        name: "fk_produto_lote_produto",
                        column: x => x.cd_produto,
                        principalTable: "produto",
                        principalColumn: "cd_produto",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_produto_lote_nfec",
                        column: x => x.id_nfec,
                        principalTable: "nfec",
                        principalColumn: "id_geral",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "produto_veiculo",
                columns: table => new
                {
                    cd_filial = table.Column<int>(nullable: false),
                    cd_produto = table.Column<string>(maxLength: 15, nullable: false),
                    placa = table.Column<string>(maxLength: 8, nullable: false),
                    cd_montadora = table.Column<int>(nullable: false),
                    cd_veiculo = table.Column<int>(nullable: false),
                    chassi = table.Column<string>(maxLength: 17, nullable: true),
                    renavan = table.Column<string>(maxLength: 11, nullable: true),
                    nm_cor_montadora = table.Column<string>(maxLength: 40, nullable: true),
                    ano_mod = table.Column<int>(nullable: true),
                    ano_fab = table.Column<int>(nullable: true),
                    motor = table.Column<string>(maxLength: 17, nullable: true),
                    potencia = table.Column<string>(maxLength: 10, nullable: true),
                    passageiros = table.Column<int>(nullable: true),
                    categoria = table.Column<string>(maxLength: 20, nullable: true),
                    cilindradas = table.Column<int>(nullable: true),
                    obs = table.Column<string>(nullable: true),
                    nr_documento_nfs = table.Column<int>(nullable: true),
                    fl_novo = table.Column<string>(maxLength: 1, nullable: false),
                    km = table.Column<double>(nullable: true),
                    cd_cor = table.Column<string>(maxLength: 2, nullable: true),
                    cd_combustivel = table.Column<string>(maxLength: 2, nullable: true),
                    cd_especie = table.Column<string>(maxLength: 2, nullable: true),
                    cd_tipo = table.Column<string>(maxLength: 2, nullable: true),
                    cd_restricao = table.Column<int>(nullable: true),
                    cd_cor_montadora = table.Column<string>(maxLength: 4, nullable: true),
                    peso_liq = table.Column<decimal>(type: "numeric(15,4)", nullable: true),
                    peso_brt = table.Column<decimal>(type: "numeric(15,4)", nullable: true),
                    nr_serie = table.Column<string>(maxLength: 9, nullable: true),
                    cmkg = table.Column<string>(maxLength: 9, nullable: true),
                    dist_entre_eixos = table.Column<string>(maxLength: 10, nullable: true),
                    tp_pintura = table.Column<string>(maxLength: 1, nullable: true),
                    cd_vin = table.Column<string>(maxLength: 1, nullable: true),
                    cond_veiculo = table.Column<int>(nullable: true),
                    cd_modelo_renavan = table.Column<string>(maxLength: 6, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_produto_veiculo", x => new { x.cd_filial, x.cd_produto });
                    table.ForeignKey(
                        name: "fk_produto_veiculo_combustivel",
                        column: x => x.cd_combustivel,
                        principalTable: "veiculo_combustivel",
                        principalColumn: "cd_combustivel",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_produto_veiculo_cor",
                        column: x => x.cd_cor,
                        principalTable: "veiculo_cor",
                        principalColumn: "cd_cor",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_produto_veiculo_especie",
                        column: x => x.cd_especie,
                        principalTable: "veiculo_especie",
                        principalColumn: "cd_especie",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_veiculo_despesas_produto",
                        column: x => x.cd_produto,
                        principalTable: "produto",
                        principalColumn: "cd_produto",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_produto_veiculo_tipo",
                        column: x => x.cd_tipo,
                        principalTable: "veiculo_tipo",
                        principalColumn: "cd_tipo",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_veiculo_cd_montadora",
                        columns: x => new { x.cd_filial, x.cd_montadora },
                        principalTable: "montadora",
                        principalColumns: new[] { "cd_filial", "cd_montadora" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_veiculo_cd_veiculo",
                        columns: x => new { x.cd_filial, x.cd_veiculo },
                        principalTable: "veiculo",
                        principalColumns: new[] { "cd_filial", "cd_veiculo" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "veiprod",
                columns: table => new
                {
                    cd_filial = table.Column<int>(nullable: false),
                    cd_veiculo = table.Column<int>(nullable: false),
                    cd_produto = table.Column<string>(maxLength: 15, nullable: false),
                    dt_atz = table.Column<DateTime>(type: "date", nullable: true, defaultValueSql: "CURRENT_DATE"),
                    id_geral = table.Column<int>(nullable: false),
                    ano_inicial = table.Column<int>(nullable: true),
                    ano_final = table.Column<int>(nullable: true),
                    cd_motor = table.Column<int>(nullable: true),
                    cd_complemento = table.Column<int>(nullable: true),
                    cd_montadora = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_veiprod", x => x.id_geral);
                    table.ForeignKey(
                        name: "fk_veiprod_complemento",
                        column: x => x.cd_complemento,
                        principalTable: "veiculo_complemento",
                        principalColumn: "cd_complemento",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_veiprod_motor",
                        column: x => x.cd_motor,
                        principalTable: "veiculo_motor",
                        principalColumn: "cd_motor",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_veiproduto",
                        column: x => x.cd_produto,
                        principalTable: "produto",
                        principalColumn: "cd_produto",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_veiprod_montadora",
                        columns: x => new { x.cd_filial, x.cd_montadora },
                        principalTable: "montadora",
                        principalColumns: new[] { "cd_filial", "cd_montadora" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_veicproduto",
                        columns: x => new { x.cd_filial, x.cd_veiculo },
                        principalTable: "veiculo",
                        principalColumns: new[] { "cd_filial", "cd_veiculo" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "fornecedor_contato",
                columns: table => new
                {
                    cd_fornecedor = table.Column<int>(nullable: false),
                    cd_contato = table.Column<int>(nullable: false),
                    cd_filial = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_fornecedor_contato", x => new { x.cd_fornecedor, x.cd_contato });
                    table.ForeignKey(
                        name: "fk_fornecedor_contato_contato",
                        column: x => x.cd_contato,
                        principalTable: "contato",
                        principalColumn: "id_contato",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_fornecedor_contato",
                        columns: x => new { x.cd_filial, x.cd_fornecedor },
                        principalTable: "fornecedor",
                        principalColumns: new[] { "cd_filial", "cd_fornecedor" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "funcionario",
                columns: table => new
                {
                    cd_filial = table.Column<int>(nullable: false),
                    cd_funcionario = table.Column<int>(nullable: false),
                    nm_funcionario = table.Column<string>(maxLength: 80, nullable: false),
                    endereco = table.Column<string>(maxLength: 80, nullable: true),
                    bairro = table.Column<string>(maxLength: 30, nullable: true),
                    cd_cidade = table.Column<int>(nullable: false),
                    cep = table.Column<string>(maxLength: 10, nullable: true),
                    fone = table.Column<string>(maxLength: 20, nullable: true),
                    fax = table.Column<string>(maxLength: 20, nullable: true),
                    dt_admissao = table.Column<DateTime>(type: "date", nullable: true, defaultValueSql: "CURRENT_DATE"),
                    dt_aniversario = table.Column<DateTime>(type: "date", nullable: true),
                    fl_vendedor = table.Column<bool>(nullable: true),
                    cota_mensal = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    dt_atz = table.Column<DateTime>(type: "date", nullable: true, defaultValueSql: "CURRENT_DATE"),
                    cd_filial_padrao = table.Column<int>(nullable: true),
                    fl_alterar_filial = table.Column<bool>(nullable: true),
                    fl_controlar_acesso = table.Column<bool>(nullable: true),
                    login = table.Column<string>(maxLength: 15, nullable: true),
                    senha = table.Column<string>(maxLength: 10, nullable: true),
                    fl_usuario = table.Column<bool>(nullable: true),
                    cd_cargo = table.Column<int>(nullable: true),
                    cd_caixa = table.Column<int>(nullable: true),
                    fl_nao_acessa_valores = table.Column<bool>(nullable: true),
                    smtp_email = table.Column<string>(maxLength: 100, nullable: true),
                    e_mail = table.Column<string>(maxLength: 80, nullable: true),
                    nm_usuario_smtp = table.Column<string>(maxLength: 50, nullable: true),
                    fl_exibe_custos = table.Column<string>(maxLength: 1, nullable: true),
                    senha_smtp = table.Column<string>(maxLength: 50, nullable: true),
                    ssl_smtp = table.Column<string>(maxLength: 1, nullable: true),
                    cd_usr = table.Column<int>(nullable: true),
                    cd_usuario = table.Column<int>(nullable: true),
                    fl_ativo = table.Column<char>(nullable: false, defaultValueSql: "'S'::bpchar"),
                    fl_ve_saldo_cxa_emp_fechamento = table.Column<string>(maxLength: 1, nullable: true),
                    msg_padrao_nfe = table.Column<string>(nullable: true),
                    porta_smtp = table.Column<int>(nullable: true),
                    cpf = table.Column<string>(maxLength: 18, nullable: true),
                    rg = table.Column<string>(maxLength: 18, nullable: true),
                    cnh = table.Column<string>(maxLength: 18, nullable: true),
                    pis = table.Column<string>(maxLength: 18, nullable: true),
                    fl_mecanico = table.Column<bool>(nullable: false),
                    custo_hora = table.Column<decimal>(type: "numeric(9,2)", nullable: true),
                    valor_venda = table.Column<decimal>(type: "numeric(9,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_funcionario", x => new { x.cd_filial, x.cd_funcionario });
                    table.ForeignKey(
                        name: "cargo_funcionario_fk",
                        columns: x => new { x.cd_cargo, x.cd_filial },
                        principalTable: "cargo",
                        principalColumns: new[] { "cd_cargo", "cd_filial" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "cob_retorno_parcela",
                columns: table => new
                {
                    id_geral = table.Column<long>(nullable: false),
                    cd_retorno = table.Column<long>(nullable: false),
                    nr_nosso_numero = table.Column<string>(maxLength: 50, nullable: false),
                    id_parcela = table.Column<string>(maxLength: 100, nullable: true),
                    cd_movimento_retorno = table.Column<string>(maxLength: 10, nullable: false),
                    cd_motivo_movimento_retorno1 = table.Column<string>(maxLength: 10, nullable: true),
                    cd_motivo_movimento_retorno2 = table.Column<string>(maxLength: 10, nullable: true),
                    cd_motivo_movimento_retorno3 = table.Column<string>(maxLength: 10, nullable: true),
                    cd_motivo_movimento_retorno4 = table.Column<string>(maxLength: 10, nullable: true),
                    cd_motivo_movimento_retorno5 = table.Column<string>(maxLength: 10, nullable: true),
                    dt_ocorrencia = table.Column<DateTime>(type: "date", nullable: false),
                    dt_credito = table.Column<DateTime>(type: "date", nullable: true),
                    dt_debito_tarifa = table.Column<DateTime>(type: "date", nullable: true),
                    vl_despesa_cobranca = table.Column<decimal>(type: "numeric(14,2)", nullable: false),
                    vl_acrescimo = table.Column<decimal>(type: "numeric(14,2)", nullable: false),
                    vl_desconto = table.Column<decimal>(type: "numeric(14,2)", nullable: false),
                    vl_abatimento = table.Column<decimal>(type: "numeric(14,2)", nullable: false),
                    vl_iof = table.Column<decimal>(type: "numeric(14,2)", nullable: false),
                    vl_pago = table.Column<decimal>(type: "numeric(14,2)", nullable: false),
                    vl_liquido = table.Column<decimal>(type: "numeric(14,2)", nullable: false),
                    vl_outras_despesas = table.Column<decimal>(type: "numeric(14,2)", nullable: false),
                    vl_outros_creditos = table.Column<decimal>(type: "numeric(14,2)", nullable: false),
                    fl_processado = table.Column<string>(maxLength: 1, nullable: true),
                    vl_tarifa = table.Column<decimal>(type: "numeric(14,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cob_retorno_parcela", x => x.id_geral);
                    table.ForeignKey(
                        name: "fk_cob_retorno_cd_retorno",
                        column: x => x.cd_retorno,
                        principalTable: "cob_retorno",
                        principalColumn: "cd_retorno",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "mdfe",
                columns: table => new
                {
                    cd_filial = table.Column<int>(nullable: false),
                    id_geral = table.Column<int>(nullable: false),
                    cd_modelo = table.Column<string>(maxLength: 3, nullable: false),
                    nr_serie = table.Column<string>(maxLength: 3, nullable: false),
                    nr_mdf = table.Column<int>(nullable: false),
                    cd_modalidade = table.Column<int>(nullable: false),
                    dt_emissao = table.Column<DateTime>(nullable: false),
                    tp_emitente = table.Column<int>(nullable: false),
                    tp_emissao = table.Column<int>(nullable: false),
                    cd_cidade_carregamento = table.Column<int>(nullable: false),
                    uf_descarregamento = table.Column<string>(maxLength: 2, nullable: false),
                    cd_proprietario_veiculo = table.Column<int>(nullable: false),
                    id_fornveic = table.Column<int>(nullable: false),
                    qt_cte = table.Column<int>(nullable: true),
                    qt_ct = table.Column<int>(nullable: true),
                    qt_nfe = table.Column<int>(nullable: true),
                    qt_nf = table.Column<int>(nullable: true),
                    vl_carga = table.Column<decimal>(type: "numeric(15,2)", nullable: true),
                    peso_bruto_carga = table.Column<decimal>(type: "numeric(15,4)", nullable: true),
                    cd_status_mdfe = table.Column<int>(nullable: true),
                    chave_acesso_mdfe = table.Column<string>(maxLength: 44, nullable: true),
                    nr_recibo_mdfe = table.Column<string>(maxLength: 15, nullable: true),
                    nr_protocolo_mdfe = table.Column<string>(maxLength: 15, nullable: true),
                    arq_xml = table.Column<string>(nullable: true),
                    dt_atz = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mdfe", x => x.id_geral);
                    table.ForeignKey(
                        name: "fk_mdfe_cidade",
                        column: x => x.cd_cidade_carregamento,
                        principalTable: "cidade",
                        principalColumn: "cd_cidade",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_mdfe_filial",
                        column: x => x.cd_filial,
                        principalTable: "filial",
                        principalColumn: "cd_filial",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_mdfe_modelo_dcto",
                        column: x => x.cd_modelo,
                        principalTable: "modelo_dcto",
                        principalColumn: "cd_modelo",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_mdfe_serie",
                        column: x => x.nr_serie,
                        principalTable: "nr_serie_nfs",
                        principalColumn: "nr_serie",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_mdfe_proprietario",
                        columns: x => new { x.cd_filial, x.cd_proprietario_veiculo },
                        principalTable: "fornecedor",
                        principalColumns: new[] { "cd_filial", "cd_fornecedor" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_mdfe_fornveic",
                        columns: x => new { x.cd_filial, x.id_fornveic },
                        principalTable: "fornveic",
                        principalColumns: new[] { "cd_filial", "id_geral" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "orcamento_c",
                columns: table => new
                {
                    cd_filial = table.Column<int>(nullable: false),
                    nr_os = table.Column<int>(nullable: false),
                    placa_veiculo = table.Column<string>(maxLength: 8, nullable: false),
                    kilometragem = table.Column<int>(nullable: true),
                    cd_clifor = table.Column<int>(nullable: true),
                    nm_clifor = table.Column<string>(maxLength: 80, nullable: true),
                    tel_mail = table.Column<string>(maxLength: 50, nullable: true),
                    vl_acrescimos = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_descontos = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_mercadorias = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_servicos = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_total = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    cd_condpgto = table.Column<int>(nullable: false),
                    vl_entrada = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    dt_emissao = table.Column<DateTime>(type: "date", nullable: true),
                    dt_validade = table.Column<DateTime>(type: "date", nullable: true),
                    problema = table.Column<string>(nullable: true),
                    cd_usuario = table.Column<int>(nullable: true),
                    dt_atz = table.Column<DateTime>(type: "date", nullable: true, defaultValueSql: "CURRENT_DATE"),
                    nm_cidade = table.Column<string>(maxLength: 40, nullable: true),
                    uf = table.Column<string>(maxLength: 2, nullable: true),
                    nm_montadora = table.Column<string>(maxLength: 40, nullable: true),
                    nm_veiculo = table.Column<string>(maxLength: 70, nullable: true),
                    motivo_cancelamento = table.Column<string>(maxLength: 80, nullable: true),
                    obs = table.Column<string>(nullable: true),
                    vl_ipi = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    cd_situacao = table.Column<int>(nullable: false),
                    fl_agrupado = table.Column<bool>(nullable: false),
                    fl_cancelado = table.Column<bool>(nullable: false),
                    fl_finalizado = table.Column<bool>(nullable: false),
                    dt_entrega = table.Column<DateTime>(type: "date", nullable: true),
                    nr_pre_venda = table.Column<int>(nullable: true),
                    cd_frente_caixa = table.Column<int>(nullable: true),
                    fl_dav_impresso = table.Column<string>(maxLength: 1, nullable: true),
                    id_end_entrega = table.Column<int>(nullable: true),
                    hash_orcamento_c_d2 = table.Column<string>(maxLength: 70, nullable: true),
                    hash_orcamento_c_d3 = table.Column<string>(maxLength: 70, nullable: true),
                    cd_tabela_preco = table.Column<int>(nullable: true),
                    fl_exporta_dav_pdf = table.Column<bool>(nullable: true),
                    datahora_cancelamento = table.Column<DateTime>(nullable: true),
                    usuario_cancelamento = table.Column<int>(nullable: true),
                    vl_icmsst = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    fl_envia_paf = table.Column<string>(maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orcamento_c", x => new { x.cd_filial, x.nr_os });
                    table.ForeignKey(
                        name: "fk_orcamento_c_frente_caixa",
                        column: x => x.cd_frente_caixa,
                        principalTable: "frente_caixa",
                        principalColumn: "cd_frente_caixa",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_orcamento_c_situacao",
                        column: x => x.cd_situacao,
                        principalTable: "situacao",
                        principalColumn: "cd_situacao",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_orcamento_c_tabela_preco",
                        column: x => x.cd_tabela_preco,
                        principalTable: "tabela_preco",
                        principalColumn: "cd_tabela_preco",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_orcamento_c_usuario",
                        column: x => x.usuario_cancelamento,
                        principalTable: "usuario",
                        principalColumn: "cd_usuario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "custcomp",
                columns: table => new
                {
                    cd_filial = table.Column<int>(nullable: false),
                    cd_produto = table.Column<string>(maxLength: 15, nullable: false),
                    dt_lancamento = table.Column<DateTime>(type: "date", nullable: false, defaultValueSql: "CURRENT_DATE"),
                    custo_compra_nomi = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    custo_medio_nomi = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    qtde_nomi = table.Column<double>(nullable: false),
                    dt_atz = table.Column<DateTime>(type: "date", nullable: true, defaultValueSql: "CURRENT_DATE"),
                    fl_custo_alterado = table.Column<string>(maxLength: 1, nullable: true),
                    custo_compra_simples = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    id_nfei = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_custcomp", x => new { x.cd_filial, x.cd_produto, x.id_nfei });
                    table.ForeignKey(
                        name: "fk_cusproduto",
                        column: x => x.cd_produto,
                        principalTable: "produto",
                        principalColumn: "cd_produto",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_custcomp_nfei",
                        column: x => x.id_nfei,
                        principalTable: "nfei",
                        principalColumn: "id_geral",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "nfei_importacao",
                columns: table => new
                {
                    id_geral = table.Column<int>(nullable: false),
                    id_nfei = table.Column<int>(nullable: false),
                    nr_adicao = table.Column<int>(nullable: false),
                    nr_seq_adicao = table.Column<int>(nullable: false),
                    cd_fabricante = table.Column<int>(nullable: false),
                    vl_desconto_di = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    vl_base_ii = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    vl_ii = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    vl_siscomex = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    vl_desp_aduaneira = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    vl_iof = table.Column<decimal>(type: "numeric(14,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nfei_importacao", x => x.id_geral);
                    table.ForeignKey(
                        name: "fk_nfei_importacao_nfei",
                        column: x => x.id_nfei,
                        principalTable: "nfei",
                        principalColumn: "id_geral",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "nfeicomplemento",
                columns: table => new
                {
                    complemento = table.Column<string>(nullable: true),
                    dt_atz = table.Column<DateTime>(type: "date", nullable: true, defaultValueSql: "CURRENT_DATE"),
                    id_nfei = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nfeicomplemento", x => x.id_nfei);
                    table.ForeignKey(
                        name: "fk_nfeicomplemento_nfei",
                        column: x => x.id_nfei,
                        principalTable: "nfei",
                        principalColumn: "id_geral",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "produto_serie",
                columns: table => new
                {
                    id_geral = table.Column<int>(nullable: false),
                    cd_filial = table.Column<int>(nullable: false),
                    cd_produto = table.Column<string>(maxLength: 15, nullable: false),
                    nr_serie = table.Column<string>(maxLength: 32, nullable: false),
                    nr_nfs = table.Column<int>(nullable: true),
                    nr_os = table.Column<int>(nullable: true),
                    nr_sequencia_nfs = table.Column<int>(nullable: true),
                    id_nfei = table.Column<int>(nullable: true),
                    nr_sequencia_os = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_produto_serie", x => x.id_geral);
                    table.ForeignKey(
                        name: "fk_produto_serie_produto",
                        column: x => x.cd_produto,
                        principalTable: "produto",
                        principalColumn: "cd_produto",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_produto_serie_nfei",
                        column: x => x.id_nfei,
                        principalTable: "nfei",
                        principalColumn: "id_geral",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "orcamento_i_agrupa",
                columns: table => new
                {
                    cd_filial = table.Column<int>(nullable: false),
                    nr_os = table.Column<int>(nullable: false),
                    nr_sequencia_equip = table.Column<int>(nullable: false),
                    nr_sequencia_servico = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orcamento_i_agrupa", x => new { x.cd_filial, x.nr_os, x.nr_sequencia_equip, x.nr_sequencia_servico });
                    table.ForeignKey(
                        name: "fk_orcamento_i_agrupa_equip",
                        columns: x => new { x.cd_filial, x.nr_os, x.nr_sequencia_equip },
                        principalTable: "orcamento_i",
                        principalColumns: new[] { "cd_filial", "nr_os", "nr_sequencia" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_orcamento_i_agrupa_servico",
                        columns: x => new { x.cd_filial, x.nr_os, x.nr_sequencia_servico },
                        principalTable: "orcamento_i",
                        principalColumns: new[] { "cd_filial", "nr_os", "nr_sequencia" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "orcamento_i_reserva_estoque",
                columns: table => new
                {
                    cd_filial = table.Column<int>(nullable: false),
                    nr_os = table.Column<int>(nullable: false),
                    nr_sequencia = table.Column<int>(nullable: false),
                    cd_produto = table.Column<string>(maxLength: 15, nullable: true),
                    qt_reservado = table.Column<decimal>(type: "numeric(18,4)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orcamento_i_reserva_estoque", x => new { x.cd_filial, x.nr_os, x.nr_sequencia });
                    table.ForeignKey(
                        name: "fk_orcamento_i_reserva_estoque_",
                        columns: x => new { x.cd_filial, x.nr_os, x.nr_sequencia },
                        principalTable: "orcamento_i",
                        principalColumns: new[] { "cd_filial", "nr_os", "nr_sequencia" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "produto_veiculos_injecao",
                columns: table => new
                {
                    id_geral = table.Column<int>(nullable: false),
                    id_produto_veiculos = table.Column<int>(nullable: false),
                    cd_injecao = table.Column<int>(nullable: false),
                    dt_atz = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_produto_veiculos_injecao", x => x.id_geral);
                    table.ForeignKey(
                        name: "fk_prodinje_prodinje",
                        column: x => x.cd_injecao,
                        principalTable: "veiculo_injecao",
                        principalColumn: "cd_injecao",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_prodinje_prodveic",
                        column: x => x.id_produto_veiculos,
                        principalTable: "veiprod",
                        principalColumn: "id_geral",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "produto_veiculos_transmissao",
                columns: table => new
                {
                    id_geral = table.Column<int>(nullable: false),
                    id_produto_veiculos = table.Column<int>(nullable: false),
                    cd_transmissao = table.Column<int>(nullable: false),
                    dt_atz = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_produto_veiculos_transmissao", x => x.id_geral);
                    table.ForeignKey(
                        name: "fk_veictrans_prodtrans",
                        column: x => x.cd_transmissao,
                        principalTable: "veiculo_transmissao",
                        principalColumn: "cd_transmissao",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_veictrans_prodveic",
                        column: x => x.id_produto_veiculos,
                        principalTable: "veiprod",
                        principalColumn: "id_geral",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "cliente",
                columns: table => new
                {
                    cd_filial = table.Column<int>(nullable: false),
                    cd_cliente = table.Column<int>(nullable: false),
                    nm_clifor = table.Column<string>(maxLength: 80, nullable: false),
                    nm_fantasia = table.Column<string>(maxLength: 80, nullable: true),
                    fl_clifor = table.Column<string>(maxLength: 1, nullable: true),
                    endereco = table.Column<string>(maxLength: 80, nullable: true),
                    bairro = table.Column<string>(maxLength: 30, nullable: true),
                    cd_cidade = table.Column<int>(nullable: false),
                    cep = table.Column<string>(maxLength: 10, nullable: true),
                    fone = table.Column<string>(maxLength: 20, nullable: true),
                    fax = table.Column<string>(maxLength: 20, nullable: true),
                    pessoa_contato = table.Column<string>(maxLength: 40, nullable: true),
                    dt_cadastro = table.Column<DateTime>(type: "date", nullable: true, defaultValueSql: "CURRENT_DATE"),
                    dt_aniversario = table.Column<DateTime>(type: "date", nullable: true),
                    tp_pessoa = table.Column<string>(maxLength: 1, nullable: true),
                    cgc_cpf = table.Column<string>(maxLength: 18, nullable: true),
                    local_trabalho = table.Column<string>(maxLength: 40, nullable: true),
                    fone_trabalho = table.Column<string>(maxLength: 20, nullable: true),
                    inscricao = table.Column<string>(maxLength: 18, nullable: true),
                    observacao_clifor = table.Column<string>(nullable: true),
                    fl_cont_ncont = table.Column<bool>(nullable: true),
                    fl_simples = table.Column<bool>(nullable: true),
                    e_mail = table.Column<string>(maxLength: 200, nullable: true),
                    celular = table.Column<string>(maxLength: 20, nullable: true),
                    cd_vendedor = table.Column<int>(nullable: true),
                    limite_credito = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    nm_conjuge = table.Column<string>(maxLength: 75, nullable: true),
                    rg_conjuge = table.Column<string>(maxLength: 18, nullable: true),
                    cpf_conjuge = table.Column<string>(maxLength: 18, nullable: true),
                    dt_nasc_conj = table.Column<DateTime>(type: "date", nullable: true),
                    trab_conj = table.Column<string>(maxLength: 40, nullable: true),
                    fone_com = table.Column<string>(maxLength: 20, nullable: true),
                    salario = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    obs_conj = table.Column<string>(nullable: true),
                    cd_fornecedor = table.Column<int>(nullable: true),
                    fl_spc = table.Column<bool>(nullable: true),
                    dt_spc = table.Column<DateTime>(type: "date", nullable: true),
                    dt_atz = table.Column<DateTime>(type: "date", nullable: true, defaultValueSql: "CURRENT_DATE"),
                    dt_admissao = table.Column<DateTime>(type: "date", nullable: true),
                    nm_pai = table.Column<string>(maxLength: 80, nullable: true),
                    nm_mae = table.Column<string>(maxLength: 80, nullable: true),
                    local_nasc = table.Column<string>(maxLength: 30, nullable: true),
                    fl_imprimir_fatura = table.Column<string>(maxLength: 1, nullable: true),
                    fl_agricultor = table.Column<string>(maxLength: 1, nullable: true),
                    tipo = table.Column<string>(maxLength: 48, nullable: true),
                    fl_bloqueado = table.Column<bool>(nullable: true),
                    motivo_bloqueio = table.Column<string>(nullable: true),
                    cod_func_bloqueou = table.Column<int>(nullable: true),
                    numero = table.Column<string>(maxLength: 50, nullable: true),
                    complemento = table.Column<string>(maxLength: 20, nullable: true),
                    fl_ativo = table.Column<string>(maxLength: 1, nullable: true),
                    cd_conta_contabil = table.Column<int>(nullable: true),
                    cd_grupo_cliente = table.Column<short>(nullable: false),
                    inscricao_suframa = table.Column<string>(maxLength: 9, nullable: true),
                    hash_cliente_d2 = table.Column<string>(maxLength: 70, nullable: true),
                    fl_cliente_rede_uniagro = table.Column<string>(maxLength: 1, nullable: true),
                    cargo = table.Column<string>(maxLength: 15, nullable: true),
                    local_trabalho_conjuge = table.Column<string>(maxLength: 20, nullable: true),
                    fone_trabalho_conjuge = table.Column<string>(maxLength: 15, nullable: true),
                    dt_admissao_conjuge = table.Column<DateTime>(type: "date", nullable: true),
                    renda_conjuge = table.Column<decimal>(type: "numeric(15,2)", nullable: true),
                    cargo_conjuge = table.Column<string>(maxLength: 15, nullable: true),
                    ref_1 = table.Column<string>(maxLength: 20, nullable: true),
                    ref_2 = table.Column<string>(maxLength: 20, nullable: true),
                    tel_ref_1 = table.Column<string>(maxLength: 15, nullable: true),
                    tel_ref_2 = table.Column<string>(maxLength: 15, nullable: true),
                    ref_3 = table.Column<string>(maxLength: 20, nullable: true),
                    ref_4 = table.Column<string>(maxLength: 20, nullable: true),
                    tel_ref_3 = table.Column<string>(maxLength: 20, nullable: true),
                    tel_ref_4 = table.Column<string>(maxLength: 20, nullable: true),
                    fl_exibe_obs = table.Column<bool>(nullable: true),
                    im = table.Column<string>(maxLength: 10, nullable: true),
                    fl_od_pesferico = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    fl_od_pcilindrico = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    fl_od_peixo = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    fl_es_pesferico = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    fl_es_pcilindrico = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    fl_es_peixo = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    fl_od_lesferico = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    fl_od_lcilindrico = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    fl_od_leixo = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    fl_es_lesferico = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    fl_es_lcilindrico = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    fl_es_leixo = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    motivo_protesto = table.Column<string>(nullable: true),
                    fl_protestado = table.Column<bool>(nullable: true),
                    cd_func_protestou = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cliente", x => new { x.cd_filial, x.cd_cliente });
                    table.UniqueConstraint("AK_cliente_cd_cliente", x => x.cd_cliente);
                    table.ForeignKey(
                        name: "fk_cliente_conta_contabil",
                        column: x => x.cd_conta_contabil,
                        principalTable: "conta_contabil",
                        principalColumn: "cd_conta",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_cliefilial",
                        column: x => x.cd_filial,
                        principalTable: "filial",
                        principalColumn: "cd_filial",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_cliefuncionario",
                        columns: x => new { x.cd_filial, x.cd_vendedor },
                        principalTable: "funcionario",
                        principalColumns: new[] { "cd_filial", "cd_funcionario" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "comissao",
                columns: table => new
                {
                    cd_filial = table.Column<int>(nullable: false),
                    cd_grupo_comissao = table.Column<int>(nullable: false),
                    cd_funcionario = table.Column<int>(nullable: false),
                    pc_sobre_comissao = table.Column<decimal>(type: "numeric(9,2)", nullable: true, defaultValueSql: "100"),
                    pc_minimo = table.Column<decimal>(type: "numeric(9,2)", nullable: true),
                    dt_atz = table.Column<DateTime>(type: "date", nullable: false, defaultValueSql: "'2018-10-26'::date"),
                    fl_comissao_abaixo_min = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_comissao", x => new { x.cd_funcionario, x.cd_grupo_comissao, x.cd_filial });
                    table.ForeignKey(
                        name: "filial_comissao_fk",
                        column: x => x.cd_filial,
                        principalTable: "filial",
                        principalColumn: "cd_filial",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "grupo_comissao_comissao_fk",
                        column: x => x.cd_grupo_comissao,
                        principalTable: "grupo_comissao",
                        principalColumn: "cd_grupo_comissao",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "funcionario_comissao_fk",
                        columns: x => new { x.cd_filial, x.cd_funcionario },
                        principalTable: "funcionario",
                        principalColumns: new[] { "cd_filial", "cd_funcionario" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "crptitulo_funcionario",
                columns: table => new
                {
                    cd_filial = table.Column<int>(nullable: false),
                    cd_tipo_conta = table.Column<int>(nullable: false),
                    cd_clifor = table.Column<int>(nullable: false),
                    nr_titulo = table.Column<string>(maxLength: 15, nullable: false),
                    cd_funcionario = table.Column<int>(nullable: false),
                    obs = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_crptitulo_funcionario", x => new { x.cd_filial, x.cd_tipo_conta, x.cd_clifor, x.nr_titulo, x.cd_funcionario });
                    table.ForeignKey(
                        name: "fk_crptitulo_funcionario_func",
                        columns: x => new { x.cd_filial, x.cd_funcionario },
                        principalTable: "funcionario",
                        principalColumns: new[] { "cd_filial", "cd_funcionario" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "mdfe_condutor",
                columns: table => new
                {
                    cd_filial = table.Column<int>(nullable: false),
                    id_geral = table.Column<int>(nullable: false),
                    id_mdfe = table.Column<int>(nullable: true),
                    cd_fornecedor = table.Column<int>(nullable: true),
                    cd_motorista = table.Column<int>(nullable: true),
                    dt_atz = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mdfe_condutor", x => x.id_geral);
                    table.ForeignKey(
                        name: "fk_mdfe_condutor_filial",
                        column: x => x.cd_filial,
                        principalTable: "filial",
                        principalColumn: "cd_filial",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_mdfe_condutor_motorista",
                        column: x => x.cd_motorista,
                        principalTable: "motorista",
                        principalColumn: "cd_motorista",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_mdfe_condutor_mdfe",
                        column: x => x.id_mdfe,
                        principalTable: "mdfe",
                        principalColumn: "id_geral",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_mdfe_condutor_fornecedor",
                        columns: x => new { x.cd_filial, x.cd_fornecedor },
                        principalTable: "fornecedor",
                        principalColumns: new[] { "cd_filial", "cd_fornecedor" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "mdfe_documento",
                columns: table => new
                {
                    cd_filial = table.Column<int>(nullable: false),
                    id_geral = table.Column<int>(nullable: false),
                    id_mdfe = table.Column<int>(nullable: true),
                    id_nf = table.Column<int>(nullable: true),
                    dt_atz = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mdfe_documento", x => x.id_geral);
                    table.ForeignKey(
                        name: "fk_mdfe_documento_filial",
                        column: x => x.cd_filial,
                        principalTable: "filial",
                        principalColumn: "cd_filial",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_mdfe_documento_mdfe",
                        column: x => x.id_mdfe,
                        principalTable: "mdfe",
                        principalColumn: "id_geral",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "mdfe_evento",
                columns: table => new
                {
                    cd_filial = table.Column<int>(nullable: false),
                    id_geral = table.Column<int>(nullable: false),
                    id_mdfe = table.Column<int>(nullable: false),
                    nr_sequencia = table.Column<int>(nullable: false),
                    tp_evento = table.Column<int>(nullable: true),
                    nm_evento = table.Column<string>(maxLength: 40, nullable: false),
                    arq_xml = table.Column<string>(nullable: true),
                    nr_protocolo = table.Column<string>(maxLength: 15, nullable: true),
                    dt_atz = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mdfe_evento", x => x.id_geral);
                    table.ForeignKey(
                        name: "fk_mdfe_evento_filial",
                        column: x => x.cd_filial,
                        principalTable: "filial",
                        principalColumn: "cd_filial",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_mdfe_evento_mdfe",
                        column: x => x.id_mdfe,
                        principalTable: "mdfe",
                        principalColumn: "id_geral",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "mdfe_percurso",
                columns: table => new
                {
                    cd_filial = table.Column<int>(nullable: false),
                    id_geral = table.Column<int>(nullable: false),
                    id_mdfe = table.Column<int>(nullable: false),
                    nr_sequencia = table.Column<int>(nullable: false),
                    uf = table.Column<string>(maxLength: 2, nullable: true),
                    dt_atz = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mdfe_percurso", x => x.id_geral);
                    table.ForeignKey(
                        name: "fk_mdfe_percurso_filial",
                        column: x => x.cd_filial,
                        principalTable: "filial",
                        principalColumn: "cd_filial",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_mdfe_percurso_mdfe",
                        column: x => x.id_mdfe,
                        principalTable: "mdfe",
                        principalColumn: "id_geral",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "apontamento_de_servico",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false),
                    cd_filial = table.Column<int>(nullable: false),
                    cd_funcionario = table.Column<int>(nullable: false),
                    data = table.Column<DateTime>(type: "date", nullable: false),
                    hora_inicial = table.Column<TimeSpan>(type: "time without time zone", nullable: false),
                    hora_final = table.Column<TimeSpan>(type: "time without time zone", nullable: false),
                    descricao = table.Column<string>(maxLength: 500, nullable: true),
                    status = table.Column<int>(nullable: true),
                    dt_atz = table.Column<DateTime>(type: "date", nullable: true, defaultValueSql: "CURRENT_DATE"),
                    nr_os = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_apontamento_de_servico", x => new { x.cd_filial, x.id });
                    table.ForeignKey(
                        name: "fk_apontamento_de_servico_2",
                        columns: x => new { x.cd_filial, x.cd_funcionario },
                        principalTable: "funcionario",
                        principalColumns: new[] { "cd_filial", "cd_funcionario" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_apontamento_de_servico_1",
                        columns: x => new { x.cd_filial, x.nr_os },
                        principalTable: "orcamento_c",
                        principalColumns: new[] { "cd_filial", "nr_os" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "auditor_estoque_c",
                columns: table => new
                {
                    cd_filial = table.Column<int>(nullable: false),
                    id_geral = table.Column<int>(nullable: false),
                    dt_hr_inicio = table.Column<DateTime>(nullable: true),
                    dt_hr_finalizacao = table.Column<DateTime>(nullable: true),
                    cd_usuario = table.Column<int>(nullable: true),
                    nr_os = table.Column<int>(nullable: true),
                    nr_pedido_compra = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_auditor_estoque_c", x => new { x.cd_filial, x.id_geral });
                    table.ForeignKey(
                        name: "fk_auditorc_pedidoc",
                        column: x => x.nr_pedido_compra,
                        principalTable: "pedido_c",
                        principalColumn: "nr_pedido",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_auditorc_orcamentoc",
                        columns: x => new { x.cd_filial, x.nr_os },
                        principalTable: "orcamento_c",
                        principalColumns: new[] { "cd_filial", "nr_os" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "orcamento_contato",
                columns: table => new
                {
                    cd_filial = table.Column<int>(nullable: false),
                    nr_os = table.Column<int>(nullable: false),
                    cd_contato = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orcamento_contato", x => new { x.nr_os, x.cd_contato });
                    table.ForeignKey(
                        name: "fk_orcamento_contato_contato",
                        column: x => x.cd_contato,
                        principalTable: "contato",
                        principalColumn: "id_contato",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_orcamento_contato_orc",
                        columns: x => new { x.cd_filial, x.nr_os },
                        principalTable: "orcamento_c",
                        principalColumns: new[] { "cd_filial", "nr_os" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "cliente_contato",
                columns: table => new
                {
                    cd_cliente = table.Column<int>(nullable: false),
                    cd_contato = table.Column<int>(nullable: false),
                    cd_filial = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cliente_contato", x => new { x.cd_cliente, x.cd_contato });
                    table.ForeignKey(
                        name: "fk_cliente_contato_contato",
                        column: x => x.cd_contato,
                        principalTable: "contato",
                        principalColumn: "id_contato",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_cliente_contato",
                        columns: x => new { x.cd_filial, x.cd_cliente },
                        principalTable: "cliente",
                        principalColumns: new[] { "cd_filial", "cd_cliente" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "cliente_entrega",
                columns: table => new
                {
                    id_geral = table.Column<int>(nullable: false),
                    cd_cliente = table.Column<int>(nullable: false),
                    nr_sequencia = table.Column<int>(nullable: false),
                    nm_local = table.Column<string>(maxLength: 80, nullable: false),
                    endereco_logradouro = table.Column<string>(maxLength: 80, nullable: true),
                    endereco_numero = table.Column<string>(maxLength: 80, nullable: true),
                    endereco_complemento = table.Column<string>(maxLength: 20, nullable: true),
                    bairro = table.Column<string>(maxLength: 80, nullable: true),
                    cep = table.Column<string>(maxLength: 10, nullable: true),
                    cd_cidade = table.Column<int>(nullable: true),
                    telefone = table.Column<string>(maxLength: 20, nullable: true),
                    fax = table.Column<string>(maxLength: 20, nullable: true),
                    celular = table.Column<string>(maxLength: 20, nullable: true),
                    e_mail = table.Column<string>(maxLength: 80, nullable: true),
                    obs = table.Column<string>(nullable: true),
                    nr_autorizacao = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cliente_entrega", x => x.id_geral);
                    table.ForeignKey(
                        name: "fk_cliente_entrega_cidade",
                        column: x => x.cd_cidade,
                        principalTable: "cidade",
                        principalColumn: "cd_cidade",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_cliente_entrega_cliente",
                        column: x => x.cd_cliente,
                        principalTable: "cliente",
                        principalColumn: "cd_cliente",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "cliente_resumo_financeiro",
                columns: table => new
                {
                    cd_cliente = table.Column<int>(nullable: false),
                    cd_filial = table.Column<int>(nullable: false),
                    vl_limite = table.Column<decimal>(type: "numeric(15,2)", nullable: true),
                    vl_a_vencer = table.Column<decimal>(type: "numeric(15,2)", nullable: true),
                    vl_atrasado = table.Column<decimal>(type: "numeric(15,2)", nullable: true),
                    vl_cheque_pre = table.Column<decimal>(type: "numeric(15,2)", nullable: true),
                    dt_ultima_compra = table.Column<DateTime>(type: "date", nullable: true),
                    dt_atz = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cliente_resumo_financeiro", x => new { x.cd_cliente, x.cd_filial });
                    table.ForeignKey(
                        name: "fk_cliente_resumo_financeiro_cl",
                        column: x => x.cd_cliente,
                        principalTable: "cliente",
                        principalColumn: "cd_cliente",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_cliente_resumo_financeiro_fi",
                        column: x => x.cd_filial,
                        principalTable: "filial_bd",
                        principalColumn: "cd_filial",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "clieveic",
                columns: table => new
                {
                    cd_filial = table.Column<int>(nullable: false),
                    cd_cliente = table.Column<int>(nullable: false),
                    placa_veiculo = table.Column<string>(maxLength: 8, nullable: false),
                    fl_proprietario = table.Column<bool>(nullable: true),
                    nm_veiculo = table.Column<string>(maxLength: 40, nullable: false),
                    ano_fabricacao = table.Column<int>(nullable: false),
                    nr_frota = table.Column<string>(maxLength: 11, nullable: true),
                    obs = table.Column<string>(nullable: true),
                    cor = table.Column<string>(maxLength: 50, nullable: true),
                    motor = table.Column<string>(maxLength: 20, nullable: true),
                    nr_chassi = table.Column<string>(maxLength: 30, nullable: true),
                    cd_montadora = table.Column<int>(nullable: false),
                    dt_atz = table.Column<DateTime>(type: "date", nullable: true, defaultValueSql: "CURRENT_DATE"),
                    renavan = table.Column<string>(maxLength: 11, nullable: true),
                    cd_veiculo = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clieveic", x => new { x.cd_filial, x.cd_cliente, x.placa_veiculo });
                    table.ForeignKey(
                        name: "fk_delcliente",
                        columns: x => new { x.cd_filial, x.cd_cliente },
                        principalTable: "cliente",
                        principalColumns: new[] { "cd_filial", "cd_cliente" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_veiccliente",
                        columns: x => new { x.cd_filial, x.cd_montadora },
                        principalTable: "veiculo",
                        principalColumns: new[] { "cd_filial", "cd_veiculo" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "movimento_seguradora",
                columns: table => new
                {
                    nr_documento = table.Column<int>(nullable: false),
                    vl_franquia = table.Column<decimal>(type: "numeric(9,2)", nullable: true),
                    vl_abatido = table.Column<decimal>(type: "numeric(9,2)", nullable: true),
                    dt_atz = table.Column<DateTime>(type: "date", nullable: true, defaultValueSql: "CURRENT_DATE"),
                    cd_seguradora = table.Column<int>(nullable: true),
                    cd_cliente = table.Column<int>(nullable: true),
                    nr_documento_origem = table.Column<int>(nullable: true),
                    nr_lcto = table.Column<int>(nullable: true),
                    cd_filial = table.Column<int>(nullable: false),
                    cd_caixa = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_movimento_seguradora", x => x.nr_documento);
                    table.ForeignKey(
                        name: "fk_movimento_seg_cliente",
                        columns: x => new { x.cd_filial, x.cd_cliente },
                        principalTable: "cliente",
                        principalColumns: new[] { "cd_filial", "cd_cliente" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_movimento_seg_seguradora",
                        columns: x => new { x.cd_filial, x.cd_seguradora },
                        principalTable: "fornecedor",
                        principalColumns: new[] { "cd_filial", "cd_fornecedor" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_movimento_seg_lcto",
                        columns: x => new { x.cd_filial, x.cd_caixa, x.nr_lcto },
                        principalTable: "movimento_cxa",
                        principalColumns: new[] { "cd_filial", "cd_caixa", "nr_lcto" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "nfsc",
                columns: table => new
                {
                    cd_filial = table.Column<int>(nullable: false),
                    nr_documento = table.Column<int>(nullable: false),
                    nr_nf = table.Column<int>(nullable: true),
                    nr_cupom = table.Column<int>(nullable: true),
                    placa_veiculo = table.Column<string>(maxLength: 8, nullable: true),
                    kilometragem = table.Column<int>(nullable: true),
                    cd_clifor = table.Column<int>(nullable: false),
                    cd_operacao = table.Column<int>(nullable: true),
                    dt_emissao = table.Column<DateTime>(type: "date", nullable: false, defaultValueSql: "CURRENT_DATE"),
                    vl_acrescimos = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_descontos = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_mercadorias = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_servicos = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_total = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    cd_condpgto = table.Column<int>(nullable: true),
                    vl_entrada = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_acres_financeiro = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_financiado = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    cd_cancelamento = table.Column<int>(nullable: false),
                    peso_total = table.Column<double>(nullable: true),
                    qt_pecas = table.Column<double>(nullable: true),
                    obs = table.Column<string>(nullable: true),
                    nr_ecf = table.Column<int>(nullable: true),
                    cd_natoper = table.Column<string>(maxLength: 40, nullable: true),
                    fl_cont_ncont = table.Column<string>(maxLength: 1, nullable: true),
                    cd_transportadora = table.Column<int>(nullable: true),
                    dt_lancamento = table.Column<DateTime>(type: "date", nullable: false, defaultValueSql: "CURRENT_DATE"),
                    dt_saida = table.Column<DateTime>(type: "date", nullable: false, defaultValueSql: "CURRENT_DATE"),
                    uf_origem = table.Column<string>(maxLength: 2, nullable: false),
                    uf_destino = table.Column<string>(maxLength: 2, nullable: false),
                    peso_liquido = table.Column<double>(nullable: true),
                    vl_frete = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_seguro = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_base_icm = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_icm = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_base_icm_subst = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_icm_subst = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_ipi = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_iss = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    tp_frete = table.Column<string>(maxLength: 1, nullable: true),
                    qt_volumes = table.Column<double>(nullable: true),
                    especie_volumes = table.Column<string>(maxLength: 15, nullable: true),
                    marca_volumes = table.Column<string>(maxLength: 15, nullable: true),
                    nr_volumes = table.Column<double>(nullable: true),
                    cd_usuario = table.Column<int>(nullable: false),
                    vl_base_comissao = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_comissao = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    fl_pago_frete = table.Column<string>(maxLength: 1, nullable: true),
                    fl_emprsimples = table.Column<string>(maxLength: 1, nullable: true),
                    fl_clisimples = table.Column<string>(maxLength: 1, nullable: true),
                    nr_os_ori = table.Column<int>(nullable: true),
                    dt_atz = table.Column<DateTime>(type: "date", nullable: true, defaultValueSql: "CURRENT_DATE"),
                    vl_outros = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    uf_placa_tansp = table.Column<string>(maxLength: 2, nullable: true),
                    placa_transp = table.Column<string>(maxLength: 8, nullable: true),
                    fl_controlar_estoque = table.Column<string>(maxLength: 1, nullable: true),
                    nr_sr = table.Column<long>(nullable: true),
                    fl_cd_conta = table.Column<string>(maxLength: 1, nullable: true),
                    fl_ignorar_cxa_cta = table.Column<string>(maxLength: 1, nullable: false),
                    fl_iss_retido = table.Column<string>(maxLength: 1, nullable: true),
                    vl_iss_subst = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    nr_sequencial = table.Column<int>(nullable: true),
                    fl_transferencia = table.Column<bool>(nullable: false),
                    total_cst = table.Column<string>(nullable: true),
                    aliq_icm_frete = table.Column<double>(nullable: true),
                    cd_impfiscal = table.Column<int>(nullable: true),
                    serie_nfs = table.Column<string>(maxLength: 3, nullable: true),
                    nsu = table.Column<string>(maxLength: 10, nullable: true),
                    base_icm_proprio_st = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_icm_proprio_st = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_base_pis = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_pis = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_base_cofins = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_cofins = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_base_ipi = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_base_iss = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_desconto_item = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_isento_itens = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_outros_itens = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    obs2 = table.Column<string>(nullable: true),
                    fl_complemento_icms = table.Column<string>(maxLength: 1, nullable: true),
                    alic_icm_simples = table.Column<decimal>(type: "numeric(5,2)", nullable: true),
                    vl_base_icm_simples = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_icm_simples = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    nr_protocolo_nfe = table.Column<string>(maxLength: 50, nullable: true),
                    dt_processamento_nfe = table.Column<DateTime>(type: "date", nullable: true),
                    status = table.Column<int>(nullable: true),
                    nr_lote_nfe = table.Column<string>(maxLength: 15, nullable: true),
                    nr_recibo_nfe = table.Column<string>(maxLength: 15, nullable: true),
                    nr_protocolo_canc_nfe = table.Column<string>(maxLength: 15, nullable: true),
                    chave_acesso_nfe = table.Column<string>(maxLength: 44, nullable: true),
                    ecf_coo = table.Column<int>(nullable: true),
                    ecf_mf_adicional = table.Column<string>(maxLength: 1, nullable: true),
                    hr_emissao = table.Column<TimeSpan>(type: "time without time zone", nullable: true),
                    id_end_entrega = table.Column<int>(nullable: true),
                    cd_modelo = table.Column<string>(maxLength: 3, nullable: true),
                    id_nfec_devolucao = table.Column<int>(nullable: true),
                    fl_consumo = table.Column<string>(maxLength: 1, nullable: true),
                    vl_icm_frete = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    cfop_frete = table.Column<string>(maxLength: 10, nullable: true),
                    nr_aidf = table.Column<string>(maxLength: 20, nullable: true),
                    conhecimento_vl_frete = table.Column<decimal>(type: "numeric(9,2)", nullable: true),
                    vl_base_icm_subst_ant = table.Column<decimal>(type: "numeric(9,2)", nullable: true),
                    vl_icm_subst_ant = table.Column<decimal>(type: "numeric(9,2)", nullable: true),
                    hr_processamento_nfe = table.Column<TimeSpan>(type: "time without time zone", nullable: true),
                    dpec_id = table.Column<string>(maxLength: 10, nullable: true),
                    dpec_nr_registro = table.Column<string>(maxLength: 14, nullable: true),
                    dpec_dt_registro = table.Column<DateTime>(type: "date", nullable: true),
                    dpec_hr_registro = table.Column<TimeSpan>(type: "time without time zone", nullable: true),
                    cd_barras_adicional_nfe = table.Column<string>(maxLength: 36, nullable: true),
                    tp_emissao_nfe = table.Column<int>(nullable: true),
                    cd_cidade_embarque = table.Column<int>(nullable: true),
                    hash_nfsc_r4 = table.Column<string>(maxLength: 70, nullable: true),
                    hash_nfsc_r5 = table.Column<string>(maxLength: 70, nullable: true),
                    hash_nfsc_r7 = table.Column<string>(maxLength: 70, nullable: true),
                    cd_tabela_preco = table.Column<int>(nullable: true),
                    vl_icm_subst_dev = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_base_icm_subst_dev = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_base_ipi_dev = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_ipi_dev = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    url_servico = table.Column<string>(maxLength: 250, nullable: true),
                    nr_rps = table.Column<int>(nullable: true),
                    vl_base_csll = table.Column<decimal>(type: "numeric(9,2)", nullable: true),
                    vl_csll = table.Column<decimal>(type: "numeric(9,2)", nullable: true),
                    vl_base_ir = table.Column<decimal>(type: "numeric(9,2)", nullable: true),
                    vl_ir = table.Column<decimal>(type: "numeric(9,2)", nullable: true),
                    vl_trib_nacional = table.Column<decimal>(type: "numeric(9,2)", nullable: true),
                    vl_trib_importado = table.Column<decimal>(type: "numeric(9,2)", nullable: true),
                    vl_trib_estadual = table.Column<decimal>(type: "numeric(9,2)", nullable: true),
                    vl_trib_municipal = table.Column<decimal>(type: "numeric(9,2)", nullable: true),
                    recinto_alfandegado = table.Column<string>(maxLength: 60, nullable: true),
                    vl_base_inss = table.Column<decimal>(type: "numeric(9,2)", nullable: true),
                    vl_inss = table.Column<decimal>(type: "numeric(9,2)", nullable: true),
                    vl_fcp = table.Column<decimal>(type: "numeric(13,2)", nullable: true),
                    vl_fcp_st = table.Column<decimal>(type: "numeric(13,2)", nullable: true),
                    vl_fcp_st_retido = table.Column<decimal>(type: "numeric(13,2)", nullable: true),
                    vl_icms_uf_dest = table.Column<decimal>(type: "numeric(13,2)", nullable: true),
                    vl_icms_uf_remet = table.Column<decimal>(type: "numeric(13,2)", nullable: true),
                    vl_fcp_uf_dest = table.Column<decimal>(type: "numeric(13,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nfsc", x => new { x.cd_filial, x.nr_documento });
                    table.ForeignKey(
                        name: "fk_nfsc_impfiscal",
                        column: x => x.cd_impfiscal,
                        principalTable: "impfiscal",
                        principalColumn: "cd_impfiscal",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_nfsc_cd_modelo",
                        column: x => x.cd_modelo,
                        principalTable: "modelo_dcto",
                        principalColumn: "cd_modelo",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_nfsc_tabela_preco",
                        column: x => x.cd_tabela_preco,
                        principalTable: "tabela_preco",
                        principalColumn: "cd_tabela_preco",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_nfsc_id_nfec_devolucao",
                        column: x => x.id_nfec_devolucao,
                        principalTable: "nfec",
                        principalColumn: "id_geral",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_nfscliente",
                        columns: x => new { x.cd_filial, x.cd_clifor },
                        principalTable: "cliente",
                        principalColumns: new[] { "cd_filial", "cd_cliente" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "produto_cliente",
                columns: table => new
                {
                    cd_filial = table.Column<int>(nullable: false),
                    cd_cliente = table.Column<int>(nullable: false),
                    nr_sequencia = table.Column<int>(nullable: false),
                    cd_produto = table.Column<string>(maxLength: 15, nullable: false),
                    nr_serie = table.Column<string>(maxLength: 32, nullable: false),
                    obs = table.Column<string>(nullable: true),
                    ano_fabricacao = table.Column<int>(nullable: true),
                    ano_modelo = table.Column<int>(nullable: true),
                    data_aquisicao = table.Column<DateTime>(type: "date", nullable: true),
                    cor = table.Column<string>(maxLength: 250, nullable: true),
                    num_chassi = table.Column<string>(maxLength: 250, nullable: true),
                    num_motor = table.Column<string>(maxLength: 250, nullable: true),
                    cd_combustivel = table.Column<string>(maxLength: 2, nullable: true),
                    num_transmissao = table.Column<string>(maxLength: 100, nullable: true),
                    serie_transmissao = table.Column<string>(maxLength: 100, nullable: true),
                    num_diferencial = table.Column<int>(nullable: true),
                    torre = table.Column<string>(maxLength: 100, nullable: true),
                    entrega_tecnica = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_produto_cliente", x => new { x.cd_filial, x.cd_cliente, x.nr_sequencia });
                    table.ForeignKey(
                        name: "fk_produto_cliente_combustivel",
                        column: x => x.cd_combustivel,
                        principalTable: "veiculo_combustivel",
                        principalColumn: "cd_combustivel",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_produto_cliente_produto",
                        column: x => x.cd_produto,
                        principalTable: "produto",
                        principalColumn: "cd_produto",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_produto_cliente_cliente",
                        columns: x => new { x.cd_filial, x.cd_cliente },
                        principalTable: "cliente",
                        principalColumns: new[] { "cd_filial", "cd_cliente" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "propriedade",
                columns: table => new
                {
                    cd_propriedade = table.Column<int>(nullable: false),
                    nm_propriedade = table.Column<string>(maxLength: 60, nullable: true),
                    endereco = table.Column<string>(maxLength: 60, nullable: true),
                    caixa_postal = table.Column<string>(maxLength: 10, nullable: true),
                    cep = table.Column<string>(maxLength: 10, nullable: true),
                    cd_cidade = table.Column<int>(nullable: true),
                    cnpj = table.Column<string>(maxLength: 18, nullable: true),
                    ie = table.Column<string>(maxLength: 18, nullable: true),
                    incra = table.Column<string>(maxLength: 10, nullable: true),
                    area = table.Column<double>(nullable: true),
                    cd_contato = table.Column<int>(nullable: true),
                    telefone = table.Column<string>(maxLength: 20, nullable: true),
                    fax = table.Column<string>(maxLength: 20, nullable: true),
                    email = table.Column<string>(maxLength: 70, nullable: true),
                    cd_cliente = table.Column<int>(nullable: true),
                    cd_filial = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_propriedade", x => x.cd_propriedade);
                    table.ForeignKey(
                        name: "fk_propriedade_cidade",
                        column: x => x.cd_cidade,
                        principalTable: "cidade",
                        principalColumn: "cd_cidade",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_propriedade_contato",
                        column: x => x.cd_contato,
                        principalTable: "contato",
                        principalColumn: "id_contato",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_propriedade_cliente",
                        columns: x => new { x.cd_filial, x.cd_cliente },
                        principalTable: "cliente",
                        principalColumns: new[] { "cd_filial", "cd_cliente" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "auditor_estoque_i",
                columns: table => new
                {
                    cd_filial = table.Column<int>(nullable: false),
                    id_auditor_c = table.Column<int>(nullable: false),
                    nr_sequencial = table.Column<int>(nullable: false),
                    cd_produto = table.Column<string>(maxLength: 15, nullable: true),
                    qt_atual = table.Column<decimal>(type: "numeric(15,4)", nullable: true),
                    qt_dif = table.Column<decimal>(type: "numeric(15,4)", nullable: true),
                    cd_usuario = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_auditor_estoque_i", x => new { x.cd_filial, x.id_auditor_c, x.nr_sequencial });
                    table.ForeignKey(
                        name: "fk_auditori_auditorc",
                        columns: x => new { x.cd_filial, x.id_auditor_c },
                        principalTable: "auditor_estoque_c",
                        principalColumns: new[] { "cd_filial", "id_geral" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "nfc_frete",
                columns: table => new
                {
                    id_geral = table.Column<int>(nullable: false),
                    nr_documento_nfsc = table.Column<int>(nullable: true),
                    id_nfec = table.Column<int>(nullable: true),
                    id_frete = table.Column<int>(nullable: false),
                    cd_filial_nfsc = table.Column<int>(nullable: true),
                    pc_rateio = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nfc_frete", x => x.id_geral);
                    table.ForeignKey(
                        name: "fk_nfc_frete_frete",
                        column: x => x.id_frete,
                        principalTable: "nfec",
                        principalColumn: "id_geral",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_nfc_frete_nfec",
                        column: x => x.id_nfec,
                        principalTable: "nfec",
                        principalColumn: "id_geral",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_nfc_frete_nfsc",
                        columns: x => new { x.cd_filial_nfsc, x.nr_documento_nfsc },
                        principalTable: "nfsc",
                        principalColumns: new[] { "cd_filial", "nr_documento" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "nfsc_mensagem",
                columns: table => new
                {
                    id_geral = table.Column<int>(nullable: false),
                    cd_filial = table.Column<int>(nullable: false),
                    nr_documento = table.Column<int>(nullable: false),
                    cd_mensagem = table.Column<int>(nullable: false),
                    mensagem = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nfsc_mensagem", x => x.id_geral);
                    table.ForeignKey(
                        name: "fk_nfsc_mensagem_nota",
                        column: x => x.cd_mensagem,
                        principalTable: "mensagem_nota",
                        principalColumn: "cd_mensagem",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_nfsc_mensagem_nfsc",
                        columns: x => new { x.cd_filial, x.nr_documento },
                        principalTable: "nfsc",
                        principalColumns: new[] { "cd_filial", "nr_documento" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "nfsi",
                columns: table => new
                {
                    cd_filial = table.Column<int>(nullable: false),
                    nr_documento = table.Column<int>(nullable: false),
                    nr_sequencia = table.Column<int>(nullable: false),
                    cd_prodserv = table.Column<string>(maxLength: 15, nullable: false),
                    nm_prodserv = table.Column<string>(maxLength: 60, nullable: true),
                    fl_servico = table.Column<string>(maxLength: 1, nullable: true),
                    qt_produto = table.Column<double>(nullable: true),
                    vl_bruto = table.Column<decimal>(type: "numeric(18,8)", nullable: true),
                    pc_desconto = table.Column<decimal>(type: "numeric(9,2)", nullable: true),
                    vl_liquido = table.Column<decimal>(type: "numeric(18,8)", nullable: true),
                    vl_total = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    preco_minimo = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    cd_funcionario = table.Column<int>(nullable: false),
                    dt_emissao = table.Column<DateTime>(type: "date", nullable: false, defaultValueSql: "CURRENT_DATE"),
                    peso_liquido = table.Column<double>(nullable: true),
                    cd_cancelamento = table.Column<int>(nullable: true),
                    cst = table.Column<string>(maxLength: 4, nullable: true),
                    pc_red_base_icm = table.Column<decimal>(type: "numeric(9,2)", nullable: true),
                    alic_icm = table.Column<decimal>(type: "numeric(9,2)", nullable: true),
                    alic_icm_subst = table.Column<decimal>(type: "numeric(9,2)", nullable: true),
                    alic_ipi = table.Column<decimal>(type: "numeric(9,2)", nullable: true),
                    alic_iss = table.Column<decimal>(type: "numeric(9,2)", nullable: true),
                    vl_base_icm = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_icm = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_icm_subst = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_ipi = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_iss = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    fl_tributacao_inf = table.Column<string>(maxLength: 1, nullable: true),
                    vl_base_comissao = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_comissao = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    pc_comissao = table.Column<decimal>(type: "numeric(9,2)", nullable: true),
                    fl_comissao_inf = table.Column<string>(maxLength: 1, nullable: true),
                    compl = table.Column<string>(nullable: true),
                    dt_atz = table.Column<DateTime>(type: "date", nullable: true, defaultValueSql: "CURRENT_DATE"),
                    un = table.Column<string>(maxLength: 6, nullable: true),
                    fl_controlar_estoque = table.Column<string>(maxLength: 1, nullable: true),
                    placa_veiculo = table.Column<string>(maxLength: 8, nullable: true),
                    kilometragem = table.Column<int>(nullable: true),
                    fl_classfiscal = table.Column<string>(maxLength: 5, nullable: true),
                    cd_conta = table.Column<int>(nullable: true),
                    vl_iss_subst = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    fl_composto = table.Column<string>(maxLength: 1, nullable: true),
                    composicao = table.Column<string>(nullable: true),
                    vl_base_icm_subst = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_frete_rateado = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    alic_uf_destino = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    cfop = table.Column<string>(maxLength: 10, nullable: true),
                    vl_desconto = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_desconto_rateado = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_acrescimo_rateado = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_seguro_rateado = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_contabil = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_outros = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_isento = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    alic_pis = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_base_pis = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_pis = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    alic_cofins = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_base_cofins = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_cofins = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_base_iss = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_base_ipi = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    iat = table.Column<string>(maxLength: 1, nullable: true),
                    pc_acrescimo = table.Column<decimal>(type: "numeric(9,2)", nullable: true),
                    pc_red_base_icm_proprio_st = table.Column<decimal>(type: "numeric(6,2)", nullable: true),
                    pc_red_base_icm_subst = table.Column<decimal>(type: "numeric(6,2)", nullable: true),
                    alic_icm_proprio_st = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_base_icm_proprio_st = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_icm_proprio_st = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_acrescimo = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    fator_conversao = table.Column<double>(nullable: true),
                    qt_venda = table.Column<double>(nullable: true),
                    un_venda = table.Column<string>(maxLength: 6, nullable: true),
                    vl_liquido_venda = table.Column<decimal>(type: "numeric(18,8)", nullable: true),
                    cst_ipi = table.Column<string>(maxLength: 2, nullable: true),
                    cst_pis = table.Column<string>(maxLength: 2, nullable: true),
                    cst_cofins = table.Column<string>(maxLength: 2, nullable: true),
                    tp_operacao_veic_novo = table.Column<int>(nullable: true),
                    vl_icm_frete = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    conhecimento_vl_frete = table.Column<decimal>(type: "numeric(9,2)", nullable: true),
                    vl_base_icm_subst_ant = table.Column<decimal>(type: "numeric(9,2)", nullable: true),
                    vl_icm_subst_ant = table.Column<decimal>(type: "numeric(9,2)", nullable: true),
                    nr_sequencia_os_ori = table.Column<int>(nullable: true),
                    fl_soma_total = table.Column<string>(maxLength: 1, nullable: true),
                    hash_nfsi_r5 = table.Column<string>(maxLength: 70, nullable: true),
                    vl_icm_subst_dev = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_base_icm_subst_dev = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    alic_icm_subst_dev = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    pc_red_base_icm_subst_dev = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_base_ipi_dev = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_ipi_dev = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    alic_ipi_dev = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    mva_dev = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    cd_fci = table.Column<string>(maxLength: 36, nullable: true),
                    alic_csll = table.Column<decimal>(type: "numeric(9,2)", nullable: true),
                    alic_irrf = table.Column<decimal>(type: "numeric(9,2)", nullable: true),
                    vl_base_csll = table.Column<decimal>(type: "numeric(9,2)", nullable: true),
                    vl_csll = table.Column<decimal>(type: "numeric(9,2)", nullable: true),
                    vl_base_ir = table.Column<decimal>(type: "numeric(9,2)", nullable: true),
                    vl_ir = table.Column<decimal>(type: "numeric(9,2)", nullable: true),
                    vl_trib_nacional = table.Column<decimal>(type: "numeric(9,2)", nullable: true),
                    vl_trib_importado = table.Column<decimal>(type: "numeric(9,2)", nullable: true),
                    vl_trib_estadual = table.Column<decimal>(type: "numeric(9,2)", nullable: true),
                    vl_trib_municipal = table.Column<decimal>(type: "numeric(9,2)", nullable: true),
                    vl_base_inss = table.Column<decimal>(type: "numeric(9,2)", nullable: true),
                    vl_inss = table.Column<decimal>(type: "numeric(9,2)", nullable: true),
                    nr_sequencia_dev = table.Column<int>(nullable: true),
                    nm_cest = table.Column<string>(maxLength: 7, nullable: true),
                    nm_class_fiscal = table.Column<string>(maxLength: 10, nullable: true),
                    cd_ped_comp = table.Column<string>(maxLength: 15, nullable: true),
                    nr_item_ped_comp = table.Column<int>(nullable: true),
                    un_trib = table.Column<string>(maxLength: 6, nullable: true),
                    vl_trib = table.Column<decimal>(type: "numeric(18,8)", nullable: true),
                    qt_trib = table.Column<double>(nullable: true),
                    pc_fcp = table.Column<decimal>(type: "numeric(4,4)", nullable: true),
                    vl_fcp = table.Column<decimal>(type: "numeric(13,2)", nullable: true),
                    vl_base_fcp = table.Column<decimal>(type: "numeric(13,2)", nullable: true),
                    vl_base_fcp_st = table.Column<decimal>(type: "numeric(13,2)", nullable: true),
                    pc_fcp_st = table.Column<decimal>(type: "numeric(4,4)", nullable: true),
                    vl_fcp_st = table.Column<decimal>(type: "numeric(13,2)", nullable: true),
                    vl_fcp_st_retido = table.Column<decimal>(type: "numeric(13,2)", nullable: true),
                    pc_fcp_st_retido = table.Column<decimal>(type: "numeric(4,4)", nullable: true),
                    vl_base_fcp_st_retido = table.Column<decimal>(type: "numeric(13,2)", nullable: true),
                    vl_base_fcp_uf_destino = table.Column<decimal>(type: "numeric(13,2)", nullable: true),
                    pc_fcp_uf_destino = table.Column<decimal>(type: "numeric(4,4)", nullable: true),
                    vl_fcp_uf_destino = table.Column<decimal>(type: "numeric(13,2)", nullable: true),
                    vl_base_uf_destino = table.Column<decimal>(type: "numeric(13,2)", nullable: true),
                    pc_icms_uf_destino = table.Column<decimal>(type: "numeric(4,4)", nullable: true),
                    pc_icms_interno = table.Column<decimal>(type: "numeric(2,2)", nullable: true),
                    pc_icms_interno_partilha = table.Column<decimal>(type: "numeric(4,4)", nullable: true),
                    vl_icms_uf_destino = table.Column<decimal>(type: "numeric(13,2)", nullable: true),
                    vl_icms_uf_remetente = table.Column<decimal>(type: "numeric(13,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nfsi", x => new { x.cd_filial, x.nr_documento, x.nr_sequencia });
                    table.ForeignKey(
                        name: "fk_nfsi_cxa_conta",
                        column: x => x.cd_conta,
                        principalTable: "cxa_conta",
                        principalColumn: "cd_conta",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_nfsi_nfsc",
                        columns: x => new { x.cd_filial, x.nr_documento },
                        principalTable: "nfsc",
                        principalColumns: new[] { "cd_filial", "nr_documento" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "veiculo_despesas",
                columns: table => new
                {
                    cd_filial = table.Column<int>(nullable: false),
                    cd_produto = table.Column<string>(maxLength: 15, nullable: false),
                    nr_sequencial = table.Column<int>(nullable: false),
                    dt_compra = table.Column<DateTime>(type: "date", nullable: true),
                    vl_compra = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_frete = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_servicos = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_pecas = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_serv_terceiros = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_despachante = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_comissao = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    observacao = table.Column<string>(nullable: true),
                    custo_total = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_compra_real = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    vl_venda_real = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    dcto_venda = table.Column<int>(nullable: true),
                    vl_ipva = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    id_nfei = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_veiculo_despesas", x => new { x.cd_filial, x.cd_produto, x.nr_sequencial });
                    table.ForeignKey(
                        name: "fk_veiculo_despesas_nfei",
                        column: x => x.id_nfei,
                        principalTable: "nfei",
                        principalColumn: "id_geral",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_veiculo_despesas_nfs",
                        columns: x => new { x.cd_filial, x.dcto_venda },
                        principalTable: "nfsc",
                        principalColumns: new[] { "cd_filial", "nr_documento" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "cliente_propriedade",
                columns: table => new
                {
                    cd_filial = table.Column<int>(nullable: false),
                    cd_cliente = table.Column<int>(nullable: false),
                    cd_propriedade = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cliente_propriedade", x => new { x.cd_filial, x.cd_cliente, x.cd_propriedade });
                    table.ForeignKey(
                        name: "fk_cliente_propriedade_propried",
                        column: x => x.cd_propriedade,
                        principalTable: "propriedade",
                        principalColumn: "cd_propriedade",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_cliente_propriedade_cliente",
                        columns: x => new { x.cd_filial, x.cd_cliente },
                        principalTable: "cliente",
                        principalColumns: new[] { "cd_filial", "cd_cliente" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "receita_agro",
                columns: table => new
                {
                    dt_emissao = table.Column<DateTime>(type: "date", nullable: true),
                    nr_art = table.Column<int>(nullable: true),
                    nr_receita = table.Column<int>(nullable: false),
                    nr_sequencia = table.Column<int>(nullable: false),
                    serie_nf = table.Column<string>(maxLength: 3, nullable: true),
                    cd_cliente = table.Column<int>(nullable: true),
                    cd_propriedade = table.Column<int>(nullable: true),
                    cd_prodserv = table.Column<int>(nullable: false),
                    cultura = table.Column<string>(maxLength: 100, nullable: true),
                    diagnostico = table.Column<string>(nullable: true),
                    area = table.Column<decimal>(type: "numeric(15,3)", nullable: true),
                    epoca_aplicacao = table.Column<string>(maxLength: 80, nullable: true),
                    modalidade_aplicacao = table.Column<int>(nullable: true),
                    intervalo_seg = table.Column<string>(maxLength: 80, nullable: true),
                    dosagem = table.Column<string>(maxLength: 15, nullable: true),
                    volume_calda = table.Column<string>(maxLength: 21, nullable: true),
                    qt_total = table.Column<decimal>(type: "numeric(15,2)", nullable: false),
                    precaucao = table.Column<string>(nullable: true),
                    epis = table.Column<string>(nullable: true),
                    orientacao = table.Column<string>(nullable: true),
                    cd_agronomo = table.Column<int>(nullable: true),
                    qt_aplicacao = table.Column<string>(maxLength: 20, nullable: true),
                    nr_nf = table.Column<int>(nullable: false),
                    cd_filial = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_receita_agro", x => new { x.cd_filial, x.nr_nf, x.nr_sequencia, x.nr_receita });
                    table.ForeignKey(
                        name: "fk_receita_agro_propriedade",
                        column: x => x.cd_propriedade,
                        principalTable: "propriedade",
                        principalColumn: "cd_propriedade",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_receita_agro_cliente",
                        columns: x => new { x.cd_filial, x.cd_cliente },
                        principalTable: "cliente",
                        principalColumns: new[] { "cd_filial", "cd_cliente" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "lcto_flex",
                columns: table => new
                {
                    id_geral = table.Column<int>(nullable: false),
                    cd_vendedor = table.Column<int>(nullable: false),
                    dt_lcto = table.Column<DateTime>(type: "date", nullable: false, defaultValueSql: "CURRENT_DATE"),
                    valor = table.Column<decimal>(type: "numeric(15,2)", nullable: false),
                    fl_deb_cred = table.Column<string>(maxLength: 1, nullable: false),
                    obs = table.Column<string>(nullable: true),
                    nr_documento = table.Column<int>(nullable: true),
                    cd_filial = table.Column<int>(nullable: false),
                    nr_sequencia = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lcto_flex", x => x.id_geral);
                    table.ForeignKey(
                        name: "fk_lcto_flex_filial",
                        column: x => x.cd_filial,
                        principalTable: "filial",
                        principalColumn: "cd_filial",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_lcto_flex_funcionario",
                        columns: x => new { x.cd_filial, x.cd_vendedor },
                        principalTable: "funcionario",
                        principalColumns: new[] { "cd_filial", "cd_funcionario" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_lcto_flex_nfsi",
                        columns: x => new { x.cd_filial, x.nr_documento, x.nr_sequencia },
                        principalTable: "nfsi",
                        principalColumns: new[] { "cd_filial", "nr_documento", "nr_sequencia" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "nfsi_cupom",
                columns: table => new
                {
                    cd_filial = table.Column<int>(nullable: false),
                    nr_documento = table.Column<int>(nullable: false),
                    nr_sequencia = table.Column<int>(nullable: false),
                    vl_base_icm = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    alic_icm = table.Column<double>(nullable: true),
                    pc_red_base_icm = table.Column<double>(nullable: true),
                    vl_icm = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    vl_base_icm_proprio_st = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    alic_icm_proprio_st = table.Column<double>(nullable: true),
                    pc_red_base_icm_proprio_st = table.Column<double>(nullable: true),
                    vl_icm_proprio_st = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    vl_base_icm_subst = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    alic_icm_subst = table.Column<double>(nullable: true),
                    pc_red_base_icm_subst = table.Column<double>(nullable: true),
                    mva = table.Column<double>(nullable: true),
                    vl_icm_subst = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    cst = table.Column<string>(maxLength: 4, nullable: true),
                    tp_imposto_ecf = table.Column<int>(nullable: true),
                    cfop = table.Column<string>(maxLength: 10, nullable: true),
                    hash_nfsi_cupom_r5 = table.Column<string>(maxLength: 70, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nfsi_cupom", x => new { x.cd_filial, x.nr_documento, x.nr_sequencia });
                    table.ForeignKey(
                        name: "fk_nfsi_cupom_nfsi",
                        columns: x => new { x.cd_filial, x.nr_documento, x.nr_sequencia },
                        principalTable: "nfsi",
                        principalColumns: new[] { "cd_filial", "nr_documento", "nr_sequencia" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_acesso_acao_perfil_id_acesso_acao",
                table: "acesso_acao_perfil",
                column: "id_acesso_acao");

            migrationBuilder.CreateIndex(
                name: "IX_acesso_acao_rel_campo_id_acao",
                table: "acesso_acao_rel_campo",
                column: "id_acao");

            migrationBuilder.CreateIndex(
                name: "unq_acesso_acao_rel_filtro_orde",
                table: "acesso_acao_rel_filtro",
                columns: new[] { "id_acao", "nr_ordem" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_acesso_acao_usuario_id_acesso_acao",
                table: "acesso_acao_usuario",
                column: "id_acesso_acao");

            migrationBuilder.CreateIndex(
                name: "IX_acesso_menu_id_menu_pai",
                table: "acesso_menu",
                column: "id_menu_pai");

            migrationBuilder.CreateIndex(
                name: "IX_administradora_conta_caixa",
                table: "administradora",
                column: "conta_caixa");

            migrationBuilder.CreateIndex(
                name: "IX_administradora_id_bandeira",
                table: "administradora",
                column: "id_bandeira");

            migrationBuilder.CreateIndex(
                name: "IX_agenda_cd_situacao",
                table: "agenda",
                column: "cd_situacao");

            migrationBuilder.CreateIndex(
                name: "idx_agenda_data",
                table: "agenda",
                column: "dt_hr_evento");

            migrationBuilder.CreateIndex(
                name: "idx_agenda_situacao_nome",
                table: "agenda_situacao",
                column: "nm_situacao");

            migrationBuilder.CreateIndex(
                name: "IX_agronomo_cd_cidade",
                table: "agronomo",
                column: "cd_cidade");

            migrationBuilder.CreateIndex(
                name: "alteracao_cad_item_idx1",
                table: "alteracao_cad_item",
                column: "cd_item");

            migrationBuilder.CreateIndex(
                name: "IX_apontamento_de_servico_cd_filial_cd_funcionario",
                table: "apontamento_de_servico",
                columns: new[] { "cd_filial", "cd_funcionario" });

            migrationBuilder.CreateIndex(
                name: "IX_apontamento_de_servico_cd_filial_nr_os",
                table: "apontamento_de_servico",
                columns: new[] { "cd_filial", "nr_os" });

            migrationBuilder.CreateIndex(
                name: "IX_auditor_estoque_c_nr_pedido_compra",
                table: "auditor_estoque_c",
                column: "nr_pedido_compra");

            migrationBuilder.CreateIndex(
                name: "IX_auditor_estoque_c_cd_filial_nr_os",
                table: "auditor_estoque_c",
                columns: new[] { "cd_filial", "nr_os" });

            migrationBuilder.CreateIndex(
                name: "IX_caixa_cd_conta_contabil",
                table: "caixa",
                column: "cd_conta_contabil");

            migrationBuilder.CreateIndex(
                name: "IX_cargo_cd_filial",
                table: "cargo",
                column: "cd_filial");

            migrationBuilder.CreateIndex(
                name: "unq1_carta_correcao",
                table: "carta_correcao",
                columns: new[] { "id_nf", "fl_ent_sai", "sequencia" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "unq1_carta_correcao_hist",
                table: "carta_correcao_hist",
                columns: new[] { "id_carta_correcao", "nm_tabela", "nm_campo", "cd_mensagem", "nr_sequencia_item" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ind_cd_cidade",
                table: "cidade",
                column: "cd_cidade");

            migrationBuilder.CreateIndex(
                name: "IX_cidade_cd_regiao",
                table: "cidade",
                column: "cd_regiao");

            migrationBuilder.CreateIndex(
                name: "ind_nm_cidade",
                table: "cidade",
                column: "nm_cidade");

            migrationBuilder.CreateIndex(
                name: "ind_cliecidade",
                table: "cliente",
                column: "cd_cidade");

            migrationBuilder.CreateIndex(
                name: "unq_cliente_codigo",
                table: "cliente",
                column: "cd_cliente",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_cliente_cd_conta_contabil",
                table: "cliente",
                column: "cd_conta_contabil");

            migrationBuilder.CreateIndex(
                name: "ind_cliente_cgc_cpf",
                table: "cliente",
                column: "cgc_cpf");

            migrationBuilder.CreateIndex(
                name: "ind_nm_cliente",
                table: "cliente",
                column: "nm_clifor");

            migrationBuilder.CreateIndex(
                name: "IX_cliente_cd_filial_cd_vendedor",
                table: "cliente",
                columns: new[] { "cd_filial", "cd_vendedor" });

            migrationBuilder.CreateIndex(
                name: "IX_cliente_contato_cd_contato",
                table: "cliente_contato",
                column: "cd_contato");

            migrationBuilder.CreateIndex(
                name: "IX_cliente_contato_cd_filial_cd_cliente",
                table: "cliente_contato",
                columns: new[] { "cd_filial", "cd_cliente" });

            migrationBuilder.CreateIndex(
                name: "IX_cliente_entrega_cd_cidade",
                table: "cliente_entrega",
                column: "cd_cidade");

            migrationBuilder.CreateIndex(
                name: "unq1_cliente_entrega",
                table: "cliente_entrega",
                columns: new[] { "cd_cliente", "nr_sequencia" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "idx_nm_grupo_cliente",
                table: "cliente_grupo",
                column: "nm_grupo_cliente",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_cliente_propriedade_cd_propriedade",
                table: "cliente_propriedade",
                column: "cd_propriedade");

            migrationBuilder.CreateIndex(
                name: "IX_cliente_resumo_financeiro_cd_filial",
                table: "cliente_resumo_financeiro",
                column: "cd_filial");

            migrationBuilder.CreateIndex(
                name: "idx_placa",
                table: "clieveic",
                column: "placa_veiculo");

            migrationBuilder.CreateIndex(
                name: "IX_clieveic_cd_filial_cd_montadora",
                table: "clieveic",
                columns: new[] { "cd_filial", "cd_montadora" });

            migrationBuilder.CreateIndex(
                name: "IX_cob_bordero_cd_convenio",
                table: "cob_bordero",
                column: "cd_convenio");

            migrationBuilder.CreateIndex(
                name: "cob_bordero_idx",
                table: "cob_bordero",
                column: "dt_cadastro");

            migrationBuilder.CreateIndex(
                name: "IX_cob_bordero_parcela_cd_bordero",
                table: "cob_bordero_parcela",
                column: "cd_bordero");

            migrationBuilder.CreateIndex(
                name: "unq_cob_convenio_atributo",
                table: "cob_convenio_atributo",
                columns: new[] { "cd_convenio", "nm_campo" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "cob_convenio_forma_pgto_idx",
                table: "cob_convenio_forma_pgto",
                columns: new[] { "cd_convenio", "cd_forma_pgto", "cd_filial", "nr_carteira" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "cob_motivo_mvto_retorno_idx",
                table: "cob_motivo_movimento_retorno",
                columns: new[] { "cd_motivo", "cd_convenio" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "unq_cob_movimento_retorno",
                table: "cob_movimento_retorno",
                columns: new[] { "cd_movimento", "cd_convenio" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_cob_parcela_cd_convenio",
                table: "cob_parcela",
                column: "cd_convenio");

            migrationBuilder.CreateIndex(
                name: "unq_cob_parcela_id_origem",
                table: "cob_parcela",
                column: "id_sistema_origem",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_cob_retorno_cd_filial",
                table: "cob_retorno",
                column: "cd_filial");

            migrationBuilder.CreateIndex(
                name: "cob_retorno_nr_retorno_idx",
                table: "cob_retorno",
                column: "nr_retorno",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_cob_retorno_parcela_cd_retorno",
                table: "cob_retorno_parcela",
                column: "cd_retorno");

            migrationBuilder.CreateIndex(
                name: "cob_retorno_parcela_idx",
                table: "cob_retorno_parcela",
                columns: new[] { "nr_nosso_numero", "cd_retorno", "cd_movimento_retorno" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_comissao_cd_grupo_comissao",
                table: "comissao",
                column: "cd_grupo_comissao");

            migrationBuilder.CreateIndex(
                name: "IX_comissao_cd_filial_cd_funcionario",
                table: "comissao",
                columns: new[] { "cd_filial", "cd_funcionario" });

            migrationBuilder.CreateIndex(
                name: "ind_comissao_func_doc",
                table: "comissao_func",
                column: "nr_documento");

            migrationBuilder.CreateIndex(
                name: "IX_comissao_func_dev_id_nfec_dev",
                table: "comissao_func_dev",
                column: "id_nfec_dev");

            migrationBuilder.CreateIndex(
                name: "IX_conf_sped_pis_cofins_cd_filial",
                table: "conf_sped_pis_cofins",
                column: "cd_filial");

            migrationBuilder.CreateIndex(
                name: "IX_consulta_id_acao_cadastro",
                table: "consulta",
                column: "id_acao_cadastro");

            migrationBuilder.CreateIndex(
                name: "unq_consulta_id",
                table: "consulta",
                column: "identificador",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "unq_consulta_campo",
                table: "consulta_campo",
                columns: new[] { "id_consulta", "nm_campo" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_contato_cd_cidade",
                table: "contato",
                column: "cd_cidade");

            migrationBuilder.CreateIndex(
                name: "idx_crptitulo_cliente",
                table: "crptitulo",
                column: "cd_clifor");

            migrationBuilder.CreateIndex(
                name: "IX_crptitulo_cd_conta",
                table: "crptitulo",
                column: "cd_conta");

            migrationBuilder.CreateIndex(
                name: "crptitulo_idx_nr_documento",
                table: "crptitulo",
                column: "nr_documento");

            migrationBuilder.CreateIndex(
                name: "ind_crptitulo_numero",
                table: "crptitulo",
                column: "nr_titulo");

            migrationBuilder.CreateIndex(
                name: "crptitulo_idx_nr_reparcelado",
                table: "crptitulo",
                column: "nr_titulo_reparcelado");

            migrationBuilder.CreateIndex(
                name: "idx_crptitulo_nr_nf",
                table: "crptitulo",
                columns: new[] { "cd_tipo_conta", "nr_documento", "nr_nf_ecf", "nr_sequencial" });

            migrationBuilder.CreateIndex(
                name: "IX_crptitulo_funcionario_cd_filial_cd_funcionario",
                table: "crptitulo_funcionario",
                columns: new[] { "cd_filial", "cd_funcionario" });

            migrationBuilder.CreateIndex(
                name: "IX_crptitulo_movimento_cxa_cd_filial_cd_caixa_nr_lcto",
                table: "crptitulo_movimento_cxa",
                columns: new[] { "cd_filial", "cd_caixa", "nr_lcto" });

            migrationBuilder.CreateIndex(
                name: "crptitulo_movimento_cxa_cnc",
                table: "crptitulo_movimento_cxa",
                columns: new[] { "cd_filial", "nr_lcto", "cd_caixa" });

            migrationBuilder.CreateIndex(
                name: "crptitulo_movimento_cxa_cccnp",
                table: "crptitulo_movimento_cxa",
                columns: new[] { "cd_filial", "cd_tipo_conta", "cd_clifor", "nr_titulo", "parcela" });

            migrationBuilder.CreateIndex(
                name: "IX_cst_cd_mensagem",
                table: "cst",
                column: "cd_mensagem");

            migrationBuilder.CreateIndex(
                name: "idx_custcomp_produto",
                table: "custcomp",
                column: "cd_produto");

            migrationBuilder.CreateIndex(
                name: "IX_custcomp_id_nfei",
                table: "custcomp",
                column: "id_nfei");

            migrationBuilder.CreateIndex(
                name: "IX_cxa_conta_cd_conta_contabil",
                table: "cxa_conta",
                column: "cd_conta_contabil");

            migrationBuilder.CreateIndex(
                name: "IX_doc_nao_fiscal_c_cd_ecf",
                table: "doc_nao_fiscal_c",
                column: "cd_ecf");

            migrationBuilder.CreateIndex(
                name: "IX_doc_nao_fiscal_i_id_doc_nao_fiscal",
                table: "doc_nao_fiscal_i",
                column: "id_doc_nao_fiscal");

            migrationBuilder.CreateIndex(
                name: "IX_doc_producao_cd_filial",
                table: "doc_producao",
                column: "cd_filial");

            migrationBuilder.CreateIndex(
                name: "ind_local_estocagem",
                table: "estocagem",
                column: "local_estocagem");

            migrationBuilder.CreateIndex(
                name: "idx_estoque_ano",
                table: "estoque",
                column: "ano");

            migrationBuilder.CreateIndex(
                name: "IX_estoque_cd_produto",
                table: "estoque",
                column: "cd_produto");

            migrationBuilder.CreateIndex(
                name: "idx_estoque_mes",
                table: "estoque",
                column: "mes");

            migrationBuilder.CreateIndex(
                name: "ind_estoque_chave",
                table: "estoque",
                columns: new[] { "ano", "cd_filial", "cd_produto", "mes" });

            migrationBuilder.CreateIndex(
                name: "IX_filial_cd_conta",
                table: "filial",
                column: "cd_conta");

            migrationBuilder.CreateIndex(
                name: "IX_filial_cd_mensagem_cupom",
                table: "filial",
                column: "cd_mensagem_cupom");

            migrationBuilder.CreateIndex(
                name: "IX_filial_cd_mensagem_dav",
                table: "filial",
                column: "cd_mensagem_dav");

            migrationBuilder.CreateIndex(
                name: "IX_filial_cd_mensagem_icm_st_nota_dev",
                table: "filial",
                column: "cd_mensagem_icm_st_nota_dev");

            migrationBuilder.CreateIndex(
                name: "IX_filial_cd_mensagem_pre_venda",
                table: "filial",
                column: "cd_mensagem_pre_venda");

            migrationBuilder.CreateIndex(
                name: "IX_filial_cd_tabela_preco_padrao",
                table: "filial",
                column: "cd_tabela_preco_padrao");

            migrationBuilder.CreateIndex(
                name: "unq1_filial_email",
                table: "filial_email",
                columns: new[] { "cd_filial", "tp_email" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_fornecedor_cd_conta_contabil",
                table: "fornecedor",
                column: "cd_conta_contabil");

            migrationBuilder.CreateIndex(
                name: "IX_fornecedor_contato_cd_contato",
                table: "fornecedor_contato",
                column: "cd_contato");

            migrationBuilder.CreateIndex(
                name: "IX_fornecedor_contato_cd_filial_cd_fornecedor",
                table: "fornecedor_contato",
                columns: new[] { "cd_filial", "cd_fornecedor" });

            migrationBuilder.CreateIndex(
                name: "IX_fornveic_cd_filial_cd_fornecedor",
                table: "fornveic",
                columns: new[] { "cd_filial", "cd_fornecedor" });

            migrationBuilder.CreateIndex(
                name: "IX_fornveic_cd_filial_cd_veiculo",
                table: "fornveic",
                columns: new[] { "cd_filial", "cd_veiculo" });

            migrationBuilder.CreateIndex(
                name: "unq_fornveic",
                table: "fornveic",
                columns: new[] { "cd_fornecedor", "cd_veiculo", "placa_veiculo" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_frente_caixa_cd_operacao",
                table: "frente_caixa",
                column: "cd_operacao");

            migrationBuilder.CreateIndex(
                name: "IX_frente_caixa_cd_tabela_preco",
                table: "frente_caixa",
                column: "cd_tabela_preco");

            migrationBuilder.CreateIndex(
                name: "IX_funcionario_cd_cargo_cd_filial",
                table: "funcionario",
                columns: new[] { "cd_cargo", "cd_filial" });

            migrationBuilder.CreateIndex(
                name: "IX_help_atz_alteracao_id_help_atz",
                table: "help_atz_alteracao",
                column: "id_help_atz");

            migrationBuilder.CreateIndex(
                name: "IX_lcto_flex_cd_filial_cd_vendedor",
                table: "lcto_flex",
                columns: new[] { "cd_filial", "cd_vendedor" });

            migrationBuilder.CreateIndex(
                name: "IX_lcto_flex_cd_filial_nr_documento_nr_sequencia",
                table: "lcto_flex",
                columns: new[] { "cd_filial", "nr_documento", "nr_sequencia" });

            migrationBuilder.CreateIndex(
                name: "IX_mdfe_cd_cidade_carregamento",
                table: "mdfe",
                column: "cd_cidade_carregamento");

            migrationBuilder.CreateIndex(
                name: "IX_mdfe_cd_modelo",
                table: "mdfe",
                column: "cd_modelo");

            migrationBuilder.CreateIndex(
                name: "IX_mdfe_nr_serie",
                table: "mdfe",
                column: "nr_serie");

            migrationBuilder.CreateIndex(
                name: "IX_mdfe_cd_filial_cd_proprietario_veiculo",
                table: "mdfe",
                columns: new[] { "cd_filial", "cd_proprietario_veiculo" });

            migrationBuilder.CreateIndex(
                name: "IX_mdfe_cd_filial_id_fornveic",
                table: "mdfe",
                columns: new[] { "cd_filial", "id_fornveic" });

            migrationBuilder.CreateIndex(
                name: "unq_mdfe",
                table: "mdfe",
                columns: new[] { "cd_filial", "cd_modelo", "nr_serie", "nr_mdf" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_mdfe_condutor_cd_motorista",
                table: "mdfe_condutor",
                column: "cd_motorista");

            migrationBuilder.CreateIndex(
                name: "IX_mdfe_condutor_id_mdfe",
                table: "mdfe_condutor",
                column: "id_mdfe");

            migrationBuilder.CreateIndex(
                name: "IX_mdfe_condutor_cd_filial_cd_fornecedor",
                table: "mdfe_condutor",
                columns: new[] { "cd_filial", "cd_fornecedor" });

            migrationBuilder.CreateIndex(
                name: "IX_mdfe_documento_cd_filial",
                table: "mdfe_documento",
                column: "cd_filial");

            migrationBuilder.CreateIndex(
                name: "IX_mdfe_documento_id_mdfe",
                table: "mdfe_documento",
                column: "id_mdfe");

            migrationBuilder.CreateIndex(
                name: "IX_mdfe_evento_cd_filial",
                table: "mdfe_evento",
                column: "cd_filial");

            migrationBuilder.CreateIndex(
                name: "IX_mdfe_evento_id_mdfe",
                table: "mdfe_evento",
                column: "id_mdfe");

            migrationBuilder.CreateIndex(
                name: "IX_mdfe_percurso_cd_filial",
                table: "mdfe_percurso",
                column: "cd_filial");

            migrationBuilder.CreateIndex(
                name: "unq_mdfe_percurso",
                table: "mdfe_percurso",
                columns: new[] { "id_mdfe", "nr_sequencia" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_motorista_cd_cidade",
                table: "motorista",
                column: "cd_cidade");

            migrationBuilder.CreateIndex(
                name: "IX_motorista_cd_filial_cd_transportador",
                table: "motorista",
                columns: new[] { "cd_filial", "cd_transportador" });

            migrationBuilder.CreateIndex(
                name: "idx_movimento_cd_caixa",
                table: "movimento_cxa",
                column: "cd_caixa");

            migrationBuilder.CreateIndex(
                name: "idx_mvto_cxa_cliente",
                table: "movimento_cxa",
                column: "cd_clifor");

            migrationBuilder.CreateIndex(
                name: "IX_movimento_cxa_cd_conta",
                table: "movimento_cxa",
                column: "cd_conta");

            migrationBuilder.CreateIndex(
                name: "idx_movimento_cd_historico",
                table: "movimento_cxa",
                column: "cd_historico");

            migrationBuilder.CreateIndex(
                name: "idx_movimento_cxa_ori",
                table: "movimento_cxa",
                column: "dcto_origem");

            migrationBuilder.CreateIndex(
                name: "ind_movimento_cxa_nr_documento",
                table: "movimento_cxa",
                column: "nr_documento");

            migrationBuilder.CreateIndex(
                name: "ind_movimento_cxa_max",
                table: "movimento_cxa",
                column: "nr_lcto");

            migrationBuilder.CreateIndex(
                name: "ind_movimento_cxa_chave",
                table: "movimento_cxa",
                columns: new[] { "cd_caixa", "cd_filial", "nr_lcto" });

            migrationBuilder.CreateIndex(
                name: "IX_movimento_seguradora_cd_filial_cd_cliente",
                table: "movimento_seguradora",
                columns: new[] { "cd_filial", "cd_cliente" });

            migrationBuilder.CreateIndex(
                name: "IX_movimento_seguradora_cd_filial_cd_seguradora",
                table: "movimento_seguradora",
                columns: new[] { "cd_filial", "cd_seguradora" });

            migrationBuilder.CreateIndex(
                name: "IX_movimento_seguradora_cd_filial_cd_caixa_nr_lcto",
                table: "movimento_seguradora",
                columns: new[] { "cd_filial", "cd_caixa", "nr_lcto" });

            migrationBuilder.CreateIndex(
                name: "IX_msggrupo_cd_mensagem",
                table: "msggrupo",
                column: "cd_mensagem");

            migrationBuilder.CreateIndex(
                name: "nf_contabil_c_idx_nfsc",
                table: "nf_contabil_c",
                columns: new[] { "id_nfc", "fl_entrada_saida" });

            migrationBuilder.CreateIndex(
                name: "unq_nf_contabil_c",
                table: "nf_contabil_c",
                columns: new[] { "cd_filial", "nr_nf", "nr_cupom", "cd_clifor", "serie_nf", "fl_entrada_saida", "ecf_cd" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "unq_nf_contabil_cfop",
                table: "nf_contabil_cfop",
                columns: new[] { "id_nf_contabil_c", "cst", "cfop", "imposto_aliq", "imposto_tipo" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "nf_contabil_i_id_nf_contabil_c",
                table: "nf_contabil_i",
                column: "id_nf_contabil_c");

            migrationBuilder.CreateIndex(
                name: "unq_nf_contabil_i",
                table: "nf_contabil_i",
                columns: new[] { "id_nf_contabil_c", "nr_sequencia" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "unq1_nf_referenciada",
                table: "nf_referenciada",
                columns: new[] { "fl_entrada_saida", "nr_documento", "fl_entrada_saida_ref", "nr_documento_ref" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_nfc_frete_id_frete",
                table: "nfc_frete",
                column: "id_frete");

            migrationBuilder.CreateIndex(
                name: "IX_nfc_frete_id_nfec",
                table: "nfc_frete",
                column: "id_nfec");

            migrationBuilder.CreateIndex(
                name: "IX_nfc_frete_cd_filial_nfsc_nr_documento_nfsc",
                table: "nfc_frete",
                columns: new[] { "cd_filial_nfsc", "nr_documento_nfsc" });

            migrationBuilder.CreateIndex(
                name: "idx_nfec_clifor",
                table: "nfec",
                column: "cd_clifor");

            migrationBuilder.CreateIndex(
                name: "IX_nfec_cd_conta",
                table: "nfec",
                column: "cd_conta");

            migrationBuilder.CreateIndex(
                name: "idx_nfec_nr_dcto_devolucao",
                table: "nfec",
                column: "nr_dcto_devolucao");

            migrationBuilder.CreateIndex(
                name: "IX_nfec_nr_pedido",
                table: "nfec",
                column: "nr_pedido");

            migrationBuilder.CreateIndex(
                name: "unq1_nfec",
                table: "nfec",
                columns: new[] { "cd_filial", "nr_dcto", "cd_clifor", "fl_impresso", "serie_nf" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_nfec_importacao_id_nfec",
                table: "nfec_importacao",
                column: "id_nfec");

            migrationBuilder.CreateIndex(
                name: "IX_nfec_mensagem_cd_mensagem",
                table: "nfec_mensagem",
                column: "cd_mensagem");

            migrationBuilder.CreateIndex(
                name: "IX_nfec_mensagem_id_nfec",
                table: "nfec_mensagem",
                column: "id_nfec");

            migrationBuilder.CreateIndex(
                name: "IX_nfei_cd_conta",
                table: "nfei",
                column: "cd_conta");

            migrationBuilder.CreateIndex(
                name: "IX_nfei_cd_prodserv",
                table: "nfei",
                column: "cd_prodserv");

            migrationBuilder.CreateIndex(
                name: "IX_nfei_id_nfec",
                table: "nfei",
                column: "id_nfec");

            migrationBuilder.CreateIndex(
                name: "IX_nfei_importacao_id_nfei",
                table: "nfei_importacao",
                column: "id_nfei");

            migrationBuilder.CreateIndex(
                name: "idx_nfsc_cancelamento",
                table: "nfsc",
                column: "cd_cancelamento");

            migrationBuilder.CreateIndex(
                name: "idx_nfsc_cliente",
                table: "nfsc",
                column: "cd_clifor");

            migrationBuilder.CreateIndex(
                name: "ind_nfsc_filial",
                table: "nfsc",
                column: "cd_filial");

            migrationBuilder.CreateIndex(
                name: "IX_nfsc_cd_impfiscal",
                table: "nfsc",
                column: "cd_impfiscal");

            migrationBuilder.CreateIndex(
                name: "IX_nfsc_cd_modelo",
                table: "nfsc",
                column: "cd_modelo");

            migrationBuilder.CreateIndex(
                name: "IX_nfsc_cd_tabela_preco",
                table: "nfsc",
                column: "cd_tabela_preco");

            migrationBuilder.CreateIndex(
                name: "idx_nfsc_data",
                table: "nfsc",
                column: "dt_emissao");

            migrationBuilder.CreateIndex(
                name: "IX_nfsc_id_nfec_devolucao",
                table: "nfsc",
                column: "id_nfec_devolucao");

            migrationBuilder.CreateIndex(
                name: "ind_nfsc_doc",
                table: "nfsc",
                column: "nr_documento");

            migrationBuilder.CreateIndex(
                name: "idx_nfsc_nr_sequencial",
                table: "nfsc",
                column: "nr_sequencial");

            migrationBuilder.CreateIndex(
                name: "IX_nfsc_cd_filial_cd_clifor",
                table: "nfsc",
                columns: new[] { "cd_filial", "cd_clifor" });

            migrationBuilder.CreateIndex(
                name: "nfsc_chave",
                table: "nfsc",
                columns: new[] { "cd_filial", "nr_documento" });

            migrationBuilder.CreateIndex(
                name: "idx_nr_nf",
                table: "nfsc",
                columns: new[] { "cd_filial", "nr_nf" });

            migrationBuilder.CreateIndex(
                name: "idx_nfsc_os",
                table: "nfsc",
                columns: new[] { "cd_filial", "nr_os_ori" });

            migrationBuilder.CreateIndex(
                name: "nfsc_idx_documento_filial",
                table: "nfsc",
                columns: new[] { "nr_documento", "cd_filial" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_nfsc_mensagem_cd_mensagem",
                table: "nfsc_mensagem",
                column: "cd_mensagem");

            migrationBuilder.CreateIndex(
                name: "IX_nfsc_mensagem_cd_filial_nr_documento",
                table: "nfsc_mensagem",
                columns: new[] { "cd_filial", "nr_documento" });

            migrationBuilder.CreateIndex(
                name: "IX_nfsi_cd_conta",
                table: "nfsi",
                column: "cd_conta");

            migrationBuilder.CreateIndex(
                name: "ind_cd_filial",
                table: "nfsi",
                column: "cd_filial");

            migrationBuilder.CreateIndex(
                name: "idx_cd_prodserv",
                table: "nfsi",
                column: "cd_prodserv");

            migrationBuilder.CreateIndex(
                name: "ind_nfsi_doc",
                table: "nfsi",
                column: "nr_documento");

            migrationBuilder.CreateIndex(
                name: "ind_nfsi_chave",
                table: "nfsi",
                columns: new[] { "cd_filial", "nr_documento", "nr_sequencia" });

            migrationBuilder.CreateIndex(
                name: "IX_nsu_produto_negativo_id_nsu",
                table: "nsu_produto_negativo",
                column: "id_nsu");

            migrationBuilder.CreateIndex(
                name: "IX_operacao_cfop_regra_cd_cfop_regra",
                table: "operacao_cfop_regra",
                column: "cd_cfop_regra");

            migrationBuilder.CreateIndex(
                name: "unq1_operacao_cfop_regra",
                table: "operacao_cfop_regra",
                columns: new[] { "cd_operacao", "cd_cfop_regra" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_operacao_es_cd_bc_cred_piscofins",
                table: "operacao_es",
                column: "cd_bc_cred_piscofins");

            migrationBuilder.CreateIndex(
                name: "IX_operacao_es_cd_conta_movimento",
                table: "operacao_es",
                column: "cd_conta_movimento");

            migrationBuilder.CreateIndex(
                name: "IX_operacao_es_cd_grupo_op",
                table: "operacao_es",
                column: "cd_grupo_op");

            migrationBuilder.CreateIndex(
                name: "IX_operacao_es_cd_mensagem",
                table: "operacao_es",
                column: "cd_mensagem");

            migrationBuilder.CreateIndex(
                name: "IX_operacao_es_cd_modelo",
                table: "operacao_es",
                column: "cd_modelo");

            migrationBuilder.CreateIndex(
                name: "IX_operacao_es_cd_tp_cred_piscofins",
                table: "operacao_es",
                column: "cd_tp_cred_piscofins");

            migrationBuilder.CreateIndex(
                name: "IX_operacao_es_id_tributacao_grupo",
                table: "operacao_es",
                column: "id_tributacao_grupo");

            migrationBuilder.CreateIndex(
                name: "IX_operacao_es_id_tributacao_grupo_pis_cofins",
                table: "operacao_es",
                column: "id_tributacao_grupo_pis_cofins");

            migrationBuilder.CreateIndex(
                name: "IX_orcamento_c_cd_situacao",
                table: "orcamento_c",
                column: "cd_situacao");

            migrationBuilder.CreateIndex(
                name: "IX_orcamento_c_cd_tabela_preco",
                table: "orcamento_c",
                column: "cd_tabela_preco");

            migrationBuilder.CreateIndex(
                name: "ind_orcamento_c_agrupado",
                table: "orcamento_c",
                column: "fl_agrupado");

            migrationBuilder.CreateIndex(
                name: "ind_orcamento_c_cancelado",
                table: "orcamento_c",
                column: "fl_cancelado");

            migrationBuilder.CreateIndex(
                name: "ind_orcamento_c_finalizado",
                table: "orcamento_c",
                column: "fl_finalizado");

            migrationBuilder.CreateIndex(
                name: "idx_orcamento_c_nr_os",
                table: "orcamento_c",
                column: "nr_os");

            migrationBuilder.CreateIndex(
                name: "IX_orcamento_c_usuario_cancelamento",
                table: "orcamento_c",
                column: "usuario_cancelamento");

            migrationBuilder.CreateIndex(
                name: "idx_orcamento_c_frente_caixa",
                table: "orcamento_c",
                columns: new[] { "cd_frente_caixa", "fl_dav_impresso" });

            migrationBuilder.CreateIndex(
                name: "IX_orcamento_contato_cd_contato",
                table: "orcamento_contato",
                column: "cd_contato");

            migrationBuilder.CreateIndex(
                name: "IX_orcamento_contato_cd_filial_nr_os",
                table: "orcamento_contato",
                columns: new[] { "cd_filial", "nr_os" });

            migrationBuilder.CreateIndex(
                name: "IX_orcamento_i_cd_produto",
                table: "orcamento_i",
                column: "cd_produto");

            migrationBuilder.CreateIndex(
                name: "idx_orcamento_i_nr_os",
                table: "orcamento_i",
                column: "nr_os");

            migrationBuilder.CreateIndex(
                name: "orcamento_i_idxcd_filial_nr_os",
                table: "orcamento_i",
                columns: new[] { "cd_filial", "nr_os" });

            migrationBuilder.CreateIndex(
                name: "IX_orcamento_i_agrupa_cd_filial_nr_os_nr_sequencia_servico",
                table: "orcamento_i_agrupa",
                columns: new[] { "cd_filial", "nr_os", "nr_sequencia_servico" });

            migrationBuilder.CreateIndex(
                name: "reserva_estoque_idx_cd_produto",
                table: "orcamento_i_reserva_estoque",
                column: "cd_produto");

            migrationBuilder.CreateIndex(
                name: "reserva_estoque_idx_nr_os",
                table: "orcamento_i_reserva_estoque",
                column: "nr_os");

            migrationBuilder.CreateIndex(
                name: "IX_orcamento_nfe_id_nfec",
                table: "orcamento_nfe",
                column: "id_nfec");

            migrationBuilder.CreateIndex(
                name: "idx_orcamento_situacao_data",
                table: "orcamento_situacao",
                column: "dt_modificacao");

            migrationBuilder.CreateIndex(
                name: "unq1_ordem_producao_c",
                table: "ordem_producao_c",
                columns: new[] { "cd_filial", "nr_ordem_producao" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ordem_producao_i_cd_item",
                table: "ordem_producao_i",
                column: "cd_item");

            migrationBuilder.CreateIndex(
                name: "unq_ordem_producao_i",
                table: "ordem_producao_i",
                columns: new[] { "id_ordem_producao_c", "cd_item" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_pafecf_e3_cd_impfiscal",
                table: "pafecf_e3",
                column: "cd_impfiscal");

            migrationBuilder.CreateIndex(
                name: "ind_pedido_func",
                table: "pedido_c",
                column: "cd_funcionario");

            migrationBuilder.CreateIndex(
                name: "ind_pedido_data",
                table: "pedido_c",
                column: "dt_emissao");

            migrationBuilder.CreateIndex(
                name: "ind_pedido_situacao",
                table: "pedido_c",
                column: "fl_situacao");

            migrationBuilder.CreateIndex(
                name: "ind_pedido_i_produto",
                table: "pedido_i",
                column: "cd_produto");

            migrationBuilder.CreateIndex(
                name: "IX_pedido_i_un_medida",
                table: "pedido_i",
                column: "un_medida");

            migrationBuilder.CreateIndex(
                name: "unq_pedido_produto",
                table: "pedido_i",
                columns: new[] { "nr_pedido", "cd_produto" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_produto_cd_cfop_regra",
                table: "produto",
                column: "cd_cfop_regra");

            migrationBuilder.CreateIndex(
                name: "IX_produto_cd_class_fiscal",
                table: "produto",
                column: "cd_class_fiscal");

            migrationBuilder.CreateIndex(
                name: "IX_produto_cd_grupo_comissao",
                table: "produto",
                column: "cd_grupo_comissao");

            migrationBuilder.CreateIndex(
                name: "IX_produto_cd_gruprod",
                table: "produto",
                column: "cd_gruprod");

            migrationBuilder.CreateIndex(
                name: "IX_produto_cd_marca",
                table: "produto",
                column: "cd_marca");

            migrationBuilder.CreateIndex(
                name: "ind_cd_produto",
                table: "produto",
                column: "cd_produto");

            migrationBuilder.CreateIndex(
                name: "IX_produto_cd_subgruprod",
                table: "produto",
                column: "cd_subgruprod");

            migrationBuilder.CreateIndex(
                name: "IX_produto_codigo_tributacao_municipio",
                table: "produto",
                column: "codigo_tributacao_municipio");

            migrationBuilder.CreateIndex(
                name: "ind_produto_composto",
                table: "produto",
                column: "fl_composto");

            migrationBuilder.CreateIndex(
                name: "IX_produto_id_trib_grupo_piscofins",
                table: "produto",
                column: "id_trib_grupo_piscofins");

            migrationBuilder.CreateIndex(
                name: "IX_produto_id_tributacao_grupo",
                table: "produto",
                column: "id_tributacao_grupo");

            migrationBuilder.CreateIndex(
                name: "ind_produto_local",
                table: "produto",
                column: "local_estocagem");

            migrationBuilder.CreateIndex(
                name: "ind_nm_produto",
                table: "produto",
                column: "nm_produto");

            migrationBuilder.CreateIndex(
                name: "IX_produto_tp_produto",
                table: "produto",
                column: "tp_produto");

            migrationBuilder.CreateIndex(
                name: "IX_produto_un_armazenagem",
                table: "produto",
                column: "un_armazenagem");

            migrationBuilder.CreateIndex(
                name: "IX_produto_un_compra",
                table: "produto",
                column: "un_compra");

            migrationBuilder.CreateIndex(
                name: "IX_produto_un_medida",
                table: "produto",
                column: "un_medida");

            migrationBuilder.CreateIndex(
                name: "unq1_produto_class_fiscal_mva",
                table: "produto_class_fiscal_mva",
                columns: new[] { "cd_class_fiscal", "uf_origem", "uf_destino" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_produto_cliente_cd_combustivel",
                table: "produto_cliente",
                column: "cd_combustivel");

            migrationBuilder.CreateIndex(
                name: "unq_produto_cliente",
                table: "produto_cliente",
                columns: new[] { "cd_produto", "nr_serie" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_produto_fornecedor_id_unimportacao",
                table: "produto_fornecedor",
                column: "id_unimportacao");

            migrationBuilder.CreateIndex(
                name: "IX_produto_lote_cd_produto",
                table: "produto_lote",
                column: "cd_produto");

            migrationBuilder.CreateIndex(
                name: "unq1_produto_lote",
                table: "produto_lote",
                columns: new[] { "id_nfec", "cd_produto", "nr_lote", "nr_sequencial", "id_nfsc" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_produto_serie_cd_produto",
                table: "produto_serie",
                column: "cd_produto");

            migrationBuilder.CreateIndex(
                name: "IX_produto_serie_id_nfei",
                table: "produto_serie",
                column: "id_nfei");

            migrationBuilder.CreateIndex(
                name: "unq_produto_serie",
                table: "produto_serie",
                columns: new[] { "cd_filial", "cd_produto", "nr_serie", "id_nfei" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "idx_cd_barras",
                table: "produto_unidade",
                column: "cd_barras");

            migrationBuilder.CreateIndex(
                name: "IX_produto_veiculo_cd_combustivel",
                table: "produto_veiculo",
                column: "cd_combustivel");

            migrationBuilder.CreateIndex(
                name: "IX_produto_veiculo_cd_cor",
                table: "produto_veiculo",
                column: "cd_cor");

            migrationBuilder.CreateIndex(
                name: "IX_produto_veiculo_cd_especie",
                table: "produto_veiculo",
                column: "cd_especie");

            migrationBuilder.CreateIndex(
                name: "IX_produto_veiculo_cd_produto",
                table: "produto_veiculo",
                column: "cd_produto");

            migrationBuilder.CreateIndex(
                name: "IX_produto_veiculo_cd_tipo",
                table: "produto_veiculo",
                column: "cd_tipo");

            migrationBuilder.CreateIndex(
                name: "unq_produto_veiculo_placa",
                table: "produto_veiculo",
                column: "placa",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_produto_veiculo_cd_filial_cd_montadora",
                table: "produto_veiculo",
                columns: new[] { "cd_filial", "cd_montadora" });

            migrationBuilder.CreateIndex(
                name: "IX_produto_veiculo_cd_filial_cd_veiculo",
                table: "produto_veiculo",
                columns: new[] { "cd_filial", "cd_veiculo" });

            migrationBuilder.CreateIndex(
                name: "IX_produto_veiculos_injecao_cd_injecao",
                table: "produto_veiculos_injecao",
                column: "cd_injecao");

            migrationBuilder.CreateIndex(
                name: "unq_produto_veiculos_injecao",
                table: "produto_veiculos_injecao",
                columns: new[] { "id_produto_veiculos", "cd_injecao" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_produto_veiculos_transmissao_cd_transmissao",
                table: "produto_veiculos_transmissao",
                column: "cd_transmissao");

            migrationBuilder.CreateIndex(
                name: "unq_produto_veiculos_transmiss",
                table: "produto_veiculos_transmissao",
                columns: new[] { "id_produto_veiculos", "cd_transmissao" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_propriedade_cd_cidade",
                table: "propriedade",
                column: "cd_cidade");

            migrationBuilder.CreateIndex(
                name: "IX_propriedade_cd_contato",
                table: "propriedade",
                column: "cd_contato");

            migrationBuilder.CreateIndex(
                name: "IX_propriedade_cd_filial_cd_cliente",
                table: "propriedade",
                columns: new[] { "cd_filial", "cd_cliente" });

            migrationBuilder.CreateIndex(
                name: "unq1_protocolo_icms",
                table: "protocolo_icms",
                column: "nr_protocolo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_protocolo_icms_class_fiscal_cd_class_fiscal",
                table: "protocolo_icms_class_fiscal",
                column: "cd_class_fiscal");

            migrationBuilder.CreateIndex(
                name: "unq1_protocolo_icms_class_fisca",
                table: "protocolo_icms_class_fiscal",
                columns: new[] { "id_protocolo", "cd_class_fiscal" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_receita_agro_cd_propriedade",
                table: "receita_agro",
                column: "cd_propriedade");

            migrationBuilder.CreateIndex(
                name: "IX_receita_agro_cd_filial_cd_cliente",
                table: "receita_agro",
                columns: new[] { "cd_filial", "cd_cliente" });

            migrationBuilder.CreateIndex(
                name: "IX_situacao_cd_precedente",
                table: "situacao",
                column: "cd_precedente");

            migrationBuilder.CreateIndex(
                name: "idx_situacao_reserva",
                table: "situacao",
                column: "fl_reserva_estoque");

            migrationBuilder.CreateIndex(
                name: "idx_situacao_nome",
                table: "situacao",
                column: "nm_situacao");

            migrationBuilder.CreateIndex(
                name: "unq1_tabela_preco_produto",
                table: "tabela_preco_produto",
                columns: new[] { "cd_tabela_preco", "cd_produto" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "unq1_tributacao",
                table: "tributacao",
                columns: new[] { "id_tributacao_grupo", "uf_origem", "uf_destino" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tributacao_aliquota_cd_mensagem",
                table: "tributacao_aliquota",
                column: "cd_mensagem");

            migrationBuilder.CreateIndex(
                name: "IX_tributacao_aliquota_cst",
                table: "tributacao_aliquota",
                column: "cst");

            migrationBuilder.CreateIndex(
                name: "unq1_tributacao_aliquota",
                table: "tributacao_aliquota",
                columns: new[] { "id_tributacao", "tp_tributacao" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tributacao_grupo_pis_cofins_cofins_compra_cst",
                table: "tributacao_grupo_pis_cofins",
                column: "cofins_compra_cst");

            migrationBuilder.CreateIndex(
                name: "IX_tributacao_grupo_pis_cofins_cofins_venda_cst",
                table: "tributacao_grupo_pis_cofins",
                column: "cofins_venda_cst");

            migrationBuilder.CreateIndex(
                name: "IX_tributacao_grupo_pis_cofins_pis_compra_cst",
                table: "tributacao_grupo_pis_cofins",
                column: "pis_compra_cst");

            migrationBuilder.CreateIndex(
                name: "IX_tributacao_grupo_pis_cofins_pis_venda_cst",
                table: "tributacao_grupo_pis_cofins",
                column: "pis_venda_cst");

            migrationBuilder.CreateIndex(
                name: "IX_usuario_perfil_cd_perfil",
                table: "usuario_perfil",
                column: "cd_perfil");

            migrationBuilder.CreateIndex(
                name: "ind_veiculo_nome",
                table: "veiculo",
                column: "nm_veiculo");

            migrationBuilder.CreateIndex(
                name: "IX_veiculo_cd_filial_cd_montadora",
                table: "veiculo",
                columns: new[] { "cd_filial", "cd_montadora" });

            migrationBuilder.CreateIndex(
                name: "ind_veiculo_despesas_cd_produto",
                table: "veiculo_despesas",
                column: "cd_produto");

            migrationBuilder.CreateIndex(
                name: "IX_veiculo_despesas_id_nfei",
                table: "veiculo_despesas",
                column: "id_nfei");

            migrationBuilder.CreateIndex(
                name: "IX_veiculo_despesas_cd_filial_dcto_venda",
                table: "veiculo_despesas",
                columns: new[] { "cd_filial", "dcto_venda" });

            migrationBuilder.CreateIndex(
                name: "IX_veiculo_modelo_complemento_cd_complemento",
                table: "veiculo_modelo_complemento",
                column: "cd_complemento");

            migrationBuilder.CreateIndex(
                name: "unq_veiculo_modelo_complemento",
                table: "veiculo_modelo_complemento",
                columns: new[] { "cd_filial", "cd_modelo", "cd_complemento" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_veiculo_modelo_injecao_cd_injecao",
                table: "veiculo_modelo_injecao",
                column: "cd_injecao");

            migrationBuilder.CreateIndex(
                name: "unq_veiculo_modelo_injecao",
                table: "veiculo_modelo_injecao",
                columns: new[] { "cd_filial", "cd_modelo", "cd_injecao" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_veiculo_modelo_motor_cd_motor",
                table: "veiculo_modelo_motor",
                column: "cd_motor");

            migrationBuilder.CreateIndex(
                name: "unq_veiculo_modelo_motor",
                table: "veiculo_modelo_motor",
                columns: new[] { "cd_filial", "cd_modelo", "cd_motor" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_veiculo_modelo_transmissao_cd_transmissao",
                table: "veiculo_modelo_transmissao",
                column: "cd_transmissao");

            migrationBuilder.CreateIndex(
                name: "unq_veiculo_modelo_transmissao",
                table: "veiculo_modelo_transmissao",
                columns: new[] { "cd_filial", "cd_modelo", "cd_transmissao" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_veiprod_cd_complemento",
                table: "veiprod",
                column: "cd_complemento");

            migrationBuilder.CreateIndex(
                name: "IX_veiprod_cd_motor",
                table: "veiprod",
                column: "cd_motor");

            migrationBuilder.CreateIndex(
                name: "IX_veiprod_cd_produto",
                table: "veiprod",
                column: "cd_produto");

            migrationBuilder.CreateIndex(
                name: "IX_veiprod_cd_filial_cd_montadora",
                table: "veiprod",
                columns: new[] { "cd_filial", "cd_montadora" });

            migrationBuilder.CreateIndex(
                name: "IX_veiprod_cd_filial_cd_veiculo",
                table: "veiprod",
                columns: new[] { "cd_filial", "cd_veiculo" });

            migrationBuilder.CreateIndex(
                name: "unq_veiprod",
                table: "veiprod",
                columns: new[] { "cd_veiculo", "cd_produto", "cd_motor", "cd_complemento", "cd_montadora" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "acesso");

            migrationBuilder.DropTable(
                name: "acesso_acao_perfil");

            migrationBuilder.DropTable(
                name: "acesso_acao_rel_campo");

            migrationBuilder.DropTable(
                name: "acesso_acao_rel_filtro");

            migrationBuilder.DropTable(
                name: "acesso_acao_usuario");

            migrationBuilder.DropTable(
                name: "acesso_menu");

            migrationBuilder.DropTable(
                name: "administradora_taxas");

            migrationBuilder.DropTable(
                name: "agenda");

            migrationBuilder.DropTable(
                name: "agronomo");

            migrationBuilder.DropTable(
                name: "alteracao_cad_item");

            migrationBuilder.DropTable(
                name: "alteracao_cad_participante");

            migrationBuilder.DropTable(
                name: "anp");

            migrationBuilder.DropTable(
                name: "anvisa");

            migrationBuilder.DropTable(
                name: "aplicacao");

            migrationBuilder.DropTable(
                name: "apontamento_de_servico");

            migrationBuilder.DropTable(
                name: "auditor_estoque_i");

            migrationBuilder.DropTable(
                name: "autoriza_xml");

            migrationBuilder.DropTable(
                name: "banco");

            migrationBuilder.DropTable(
                name: "beneficio_fiscal");

            migrationBuilder.DropTable(
                name: "carta_correcao_hist");

            migrationBuilder.DropTable(
                name: "cest");

            migrationBuilder.DropTable(
                name: "cfop");

            migrationBuilder.DropTable(
                name: "class_lista_servico");

            migrationBuilder.DropTable(
                name: "cliente_contato");

            migrationBuilder.DropTable(
                name: "cliente_entrega");

            migrationBuilder.DropTable(
                name: "cliente_grupo");

            migrationBuilder.DropTable(
                name: "cliente_propriedade");

            migrationBuilder.DropTable(
                name: "cliente_resumo_financeiro");

            migrationBuilder.DropTable(
                name: "cliente_resumo_financeiro_log");

            migrationBuilder.DropTable(
                name: "clieveic");

            migrationBuilder.DropTable(
                name: "cob_bordero_parcela");

            migrationBuilder.DropTable(
                name: "cob_convenio_atributo");

            migrationBuilder.DropTable(
                name: "cob_convenio_forma_pgto");

            migrationBuilder.DropTable(
                name: "cob_motivo_movimento_retorno");

            migrationBuilder.DropTable(
                name: "cob_movimento_retorno");

            migrationBuilder.DropTable(
                name: "cob_retorno_parcela");

            migrationBuilder.DropTable(
                name: "comissao");

            migrationBuilder.DropTable(
                name: "comissao_func");

            migrationBuilder.DropTable(
                name: "comissao_func_dev");

            migrationBuilder.DropTable(
                name: "conf_estudo_lucratividade");

            migrationBuilder.DropTable(
                name: "conf_sped_pis_cofins");

            migrationBuilder.DropTable(
                name: "construcao");

            migrationBuilder.DropTable(
                name: "consulta_campo");

            migrationBuilder.DropTable(
                name: "contabilista");

            migrationBuilder.DropTable(
                name: "crptitulo_agrupado");

            migrationBuilder.DropTable(
                name: "crptitulo_funcionario");

            migrationBuilder.DropTable(
                name: "crptitulo_movimento_cxa");

            migrationBuilder.DropTable(
                name: "cst_ipi");

            migrationBuilder.DropTable(
                name: "custcomp");

            migrationBuilder.DropTable(
                name: "cxa_abertura");

            migrationBuilder.DropTable(
                name: "cxa_acesso");

            migrationBuilder.DropTable(
                name: "doc_nao_fiscal_i");

            migrationBuilder.DropTable(
                name: "doc_producao");

            migrationBuilder.DropTable(
                name: "estocagem");

            migrationBuilder.DropTable(
                name: "estoque");

            migrationBuilder.DropTable(
                name: "filial_conf_nfe_nfse");

            migrationBuilder.DropTable(
                name: "filial_email");

            migrationBuilder.DropTable(
                name: "filial_ie_st");

            migrationBuilder.DropTable(
                name: "fornecedor_contato");

            migrationBuilder.DropTable(
                name: "fornprod");

            migrationBuilder.DropTable(
                name: "HASH");

            migrationBuilder.DropTable(
                name: "help_atz_alteracao");

            migrationBuilder.DropTable(
                name: "impfiscal_aliquota");

            migrationBuilder.DropTable(
                name: "lcto_flex");

            migrationBuilder.DropTable(
                name: "log_sistema");

            migrationBuilder.DropTable(
                name: "mdfe_condutor");

            migrationBuilder.DropTable(
                name: "mdfe_documento");

            migrationBuilder.DropTable(
                name: "mdfe_evento");

            migrationBuilder.DropTable(
                name: "mdfe_percurso");

            migrationBuilder.DropTable(
                name: "medida");

            migrationBuilder.DropTable(
                name: "modelo");

            migrationBuilder.DropTable(
                name: "motivo_devolucao");

            migrationBuilder.DropTable(
                name: "movimento_cxa_vinculo");

            migrationBuilder.DropTable(
                name: "movimento_seguradora");

            migrationBuilder.DropTable(
                name: "msggrupo");

            migrationBuilder.DropTable(
                name: "nf_contabil_cfop");

            migrationBuilder.DropTable(
                name: "nf_contabil_i");

            migrationBuilder.DropTable(
                name: "nf_referenciada");

            migrationBuilder.DropTable(
                name: "nf_xml");

            migrationBuilder.DropTable(
                name: "nfc_frete");

            migrationBuilder.DropTable(
                name: "nfe_contingencia");

            migrationBuilder.DropTable(
                name: "nfe_inutilizacao");

            migrationBuilder.DropTable(
                name: "nfec_conhecimento");

            migrationBuilder.DropTable(
                name: "nfec_energia_eletrica");

            migrationBuilder.DropTable(
                name: "nfec_importacao");

            migrationBuilder.DropTable(
                name: "nfec_mensagem");

            migrationBuilder.DropTable(
                name: "nfei_importacao");

            migrationBuilder.DropTable(
                name: "nfeicomplemento");

            migrationBuilder.DropTable(
                name: "nfsc_mensagem");

            migrationBuilder.DropTable(
                name: "nfsc_servico");

            migrationBuilder.DropTable(
                name: "nfsi_cupom");

            migrationBuilder.DropTable(
                name: "nfsicomplemento");

            migrationBuilder.DropTable(
                name: "nsu_produto_negativo");

            migrationBuilder.DropTable(
                name: "operacao_cfop_regra");

            migrationBuilder.DropTable(
                name: "orcamento_agrupado");

            migrationBuilder.DropTable(
                name: "orcamento_contato");

            migrationBuilder.DropTable(
                name: "orcamento_dav");

            migrationBuilder.DropTable(
                name: "orcamento_frete");

            migrationBuilder.DropTable(
                name: "orcamento_i_agrupa");

            migrationBuilder.DropTable(
                name: "orcamento_i_reserva_estoque");

            migrationBuilder.DropTable(
                name: "orcamento_imagem");

            migrationBuilder.DropTable(
                name: "orcamento_nfe");

            migrationBuilder.DropTable(
                name: "orcamento_situacao");

            migrationBuilder.DropTable(
                name: "ordem_producao_i");

            migrationBuilder.DropTable(
                name: "pafecf_e3");

            migrationBuilder.DropTable(
                name: "pedido_afv_c");

            migrationBuilder.DropTable(
                name: "pedido_afv_i");

            migrationBuilder.DropTable(
                name: "pedido_frete");

            migrationBuilder.DropTable(
                name: "pedido_i");

            migrationBuilder.DropTable(
                name: "pl_historico");

            migrationBuilder.DropTable(
                name: "prod_composto");

            migrationBuilder.DropTable(
                name: "prod_original");

            migrationBuilder.DropTable(
                name: "prod_relacionado");

            migrationBuilder.DropTable(
                name: "produto_altprec");

            migrationBuilder.DropTable(
                name: "produto_class_fiscal_ibpt");

            migrationBuilder.DropTable(
                name: "produto_class_fiscal_mva");

            migrationBuilder.DropTable(
                name: "produto_cliente");

            migrationBuilder.DropTable(
                name: "produto_fornecedor");

            migrationBuilder.DropTable(
                name: "produto_lote");

            migrationBuilder.DropTable(
                name: "produto_serie");

            migrationBuilder.DropTable(
                name: "produto_unidade");

            migrationBuilder.DropTable(
                name: "produto_veiculo");

            migrationBuilder.DropTable(
                name: "produto_veiculos_injecao");

            migrationBuilder.DropTable(
                name: "produto_veiculos_transmissao");

            migrationBuilder.DropTable(
                name: "protocolo_icms_class_fiscal");

            migrationBuilder.DropTable(
                name: "receita_agro");

            migrationBuilder.DropTable(
                name: "recibo");

            migrationBuilder.DropTable(
                name: "reducao_z_totalizador");

            migrationBuilder.DropTable(
                name: "reducaoz");

            migrationBuilder.DropTable(
                name: "ref_nota_produtor");

            migrationBuilder.DropTable(
                name: "saldo_cxa_dia");

            migrationBuilder.DropTable(
                name: "tabela_preco_produto");

            migrationBuilder.DropTable(
                name: "tabvcto");

            migrationBuilder.DropTable(
                name: "tipocobr");

            migrationBuilder.DropTable(
                name: "tributacao_aliquota");

            migrationBuilder.DropTable(
                name: "usuario_perfil");

            migrationBuilder.DropTable(
                name: "veiculo_despesas");

            migrationBuilder.DropTable(
                name: "veiculo_modelo_complemento");

            migrationBuilder.DropTable(
                name: "veiculo_modelo_injecao");

            migrationBuilder.DropTable(
                name: "veiculo_modelo_motor");

            migrationBuilder.DropTable(
                name: "veiculo_modelo_transmissao");

            migrationBuilder.DropTable(
                name: "acesso_acao_relatorio");

            migrationBuilder.DropTable(
                name: "administradora");

            migrationBuilder.DropTable(
                name: "agenda_situacao");

            migrationBuilder.DropTable(
                name: "auditor_estoque_c");

            migrationBuilder.DropTable(
                name: "carta_correcao");

            migrationBuilder.DropTable(
                name: "filial_bd");

            migrationBuilder.DropTable(
                name: "cob_bordero");

            migrationBuilder.DropTable(
                name: "cob_parcela");

            migrationBuilder.DropTable(
                name: "cob_retorno");

            migrationBuilder.DropTable(
                name: "consulta");

            migrationBuilder.DropTable(
                name: "crptitulo");

            migrationBuilder.DropTable(
                name: "doc_nao_fiscal_c");

            migrationBuilder.DropTable(
                name: "help_atz");

            migrationBuilder.DropTable(
                name: "motorista");

            migrationBuilder.DropTable(
                name: "mdfe");

            migrationBuilder.DropTable(
                name: "movimento_cxa");

            migrationBuilder.DropTable(
                name: "nf_contabil_c");

            migrationBuilder.DropTable(
                name: "nfsi");

            migrationBuilder.DropTable(
                name: "nsu");

            migrationBuilder.DropTable(
                name: "orcamento_i");

            migrationBuilder.DropTable(
                name: "ordem_producao_c");

            migrationBuilder.DropTable(
                name: "fornecedor_unmedida");

            migrationBuilder.DropTable(
                name: "veiculo_combustivel");

            migrationBuilder.DropTable(
                name: "veiculo_cor");

            migrationBuilder.DropTable(
                name: "veiculo_especie");

            migrationBuilder.DropTable(
                name: "veiculo_tipo");

            migrationBuilder.DropTable(
                name: "veiprod");

            migrationBuilder.DropTable(
                name: "protocolo_icms");

            migrationBuilder.DropTable(
                name: "propriedade");

            migrationBuilder.DropTable(
                name: "reducao_z");

            migrationBuilder.DropTable(
                name: "cst");

            migrationBuilder.DropTable(
                name: "tributacao");

            migrationBuilder.DropTable(
                name: "perfil_acesso");

            migrationBuilder.DropTable(
                name: "nfei");

            migrationBuilder.DropTable(
                name: "veiculo_injecao");

            migrationBuilder.DropTable(
                name: "veiculo_transmissao");

            migrationBuilder.DropTable(
                name: "administradora_bandeira");

            migrationBuilder.DropTable(
                name: "orcamento_c");

            migrationBuilder.DropTable(
                name: "cob_convenio");

            migrationBuilder.DropTable(
                name: "acesso_acao");

            migrationBuilder.DropTable(
                name: "nr_serie_nfs");

            migrationBuilder.DropTable(
                name: "fornveic");

            migrationBuilder.DropTable(
                name: "caixa");

            migrationBuilder.DropTable(
                name: "nfsc");

            migrationBuilder.DropTable(
                name: "veiculo_complemento");

            migrationBuilder.DropTable(
                name: "veiculo_motor");

            migrationBuilder.DropTable(
                name: "contato");

            migrationBuilder.DropTable(
                name: "produto");

            migrationBuilder.DropTable(
                name: "frente_caixa");

            migrationBuilder.DropTable(
                name: "situacao");

            migrationBuilder.DropTable(
                name: "usuario");

            migrationBuilder.DropTable(
                name: "fornecedor");

            migrationBuilder.DropTable(
                name: "veiculo");

            migrationBuilder.DropTable(
                name: "impfiscal");

            migrationBuilder.DropTable(
                name: "nfec");

            migrationBuilder.DropTable(
                name: "cliente");

            migrationBuilder.DropTable(
                name: "cidade");

            migrationBuilder.DropTable(
                name: "cfop_regra");

            migrationBuilder.DropTable(
                name: "produto_class_fiscal");

            migrationBuilder.DropTable(
                name: "grupo_comissao");

            migrationBuilder.DropTable(
                name: "gruprod");

            migrationBuilder.DropTable(
                name: "marca");

            migrationBuilder.DropTable(
                name: "subgruprod");

            migrationBuilder.DropTable(
                name: "codigo_tributacao_municipio");

            migrationBuilder.DropTable(
                name: "produto_tipo");

            migrationBuilder.DropTable(
                name: "un_medida");

            migrationBuilder.DropTable(
                name: "operacao_es");

            migrationBuilder.DropTable(
                name: "montadora");

            migrationBuilder.DropTable(
                name: "pedido_c");

            migrationBuilder.DropTable(
                name: "funcionario");

            migrationBuilder.DropTable(
                name: "regiao");

            migrationBuilder.DropTable(
                name: "tab_437_sped_piscofins");

            migrationBuilder.DropTable(
                name: "grupo_operacao_es");

            migrationBuilder.DropTable(
                name: "modelo_dcto");

            migrationBuilder.DropTable(
                name: "tab_436_sped_piscofins");

            migrationBuilder.DropTable(
                name: "tributacao_grupo");

            migrationBuilder.DropTable(
                name: "tributacao_grupo_pis_cofins");

            migrationBuilder.DropTable(
                name: "cargo");

            migrationBuilder.DropTable(
                name: "cst_pis_cofins");

            migrationBuilder.DropTable(
                name: "filial");

            migrationBuilder.DropTable(
                name: "cxa_conta");

            migrationBuilder.DropTable(
                name: "mensagem_nota");

            migrationBuilder.DropTable(
                name: "tabela_preco");

            migrationBuilder.DropTable(
                name: "conta_contabil");
        }
    }
}
