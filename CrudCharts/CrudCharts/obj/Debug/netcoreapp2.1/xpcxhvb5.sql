CREATE TABLE IF NOT EXISTS "__EFMigrationsHistory" (
    "MigrationId" character varying(150) NOT NULL,
    "ProductVersion" character varying(32) NOT NULL,
    CONSTRAINT "PK___EFMigrationsHistory" PRIMARY KEY ("MigrationId")
);

CREATE TABLE "Login" (
    "Id" integer NOT NULL,
    "Usuario" text NOT NULL,
    "Senha" text NULL,
    CONSTRAINT "PK_Login" PRIMARY KEY ("Id")
);

CREATE TABLE "PedidoFrete" (
    "Id" integer NOT NULL,
    "UfOrigem" text NULL,
    "UfDestino" text NULL,
    "Status" integer NULL,
    CONSTRAINT "PK_PedidoFrete" PRIMARY KEY ("Id")
);

CREATE TABLE "Rotas" (
    "Id" integer NOT NULL,
    "UfOrigem" text NOT NULL,
    "UfDestino" text NOT NULL,
    "Distancia" double precision NOT NULL,
    "Preco" double precision NULL,
    CONSTRAINT "PK_Rotas" PRIMARY KEY ("Id")
);

INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
VALUES ('20181026022659_InitialCreate', '2.2.0-preview1-35029');

CREATE TABLE acesso (
    cd_filial integer NOT NULL,
    nm_login character varying(15) NOT NULL,
    nm_programa character varying(200) NOT NULL,
    dt_atz date NULL DEFAULT (CURRENT_DATE),
    CONSTRAINT "PK_acesso" PRIMARY KEY (nm_programa, nm_login, cd_filial)
);

CREATE TABLE acesso_acao (
    id_geral bigint NOT NULL,
    cd_acesso character varying(10) NULL,
    nm_acao character varying(200) NOT NULL,
    nm_procedimento character varying(200) NOT NULL,
    fl_classificacao character varying(1) NOT NULL,
    obs text NULL,
    fl_alterar character varying(1) NULL,
    fl_inserir character varying(1) NULL,
    fl_excluir character varying(1) NULL,
    fl_permitir_filial character varying(1) NULL,
    cd_conexao integer NULL,
    tp_empresa integer NULL,
    CONSTRAINT "PK_acesso_acao" PRIMARY KEY (id_geral)
);

CREATE TABLE acesso_menu (
    id_geral bigint NOT NULL,
    nm_titulo character varying(200) NOT NULL,
    id_menu_pai bigint NULL,
    nr_ordem integer NOT NULL,
    nm_tecla_atalho character varying(30) NULL,
    CONSTRAINT "PK_acesso_menu" PRIMARY KEY (id_geral),
    CONSTRAINT fk_acesso_menu_acesso_menu FOREIGN KEY (id_menu_pai) REFERENCES acesso_menu (id_geral) ON DELETE CASCADE
);

CREATE TABLE administradora_bandeira (
    id_geral integer NOT NULL,
    descricao character varying(100) NULL,
    cd_bandeira character varying(3) NULL,
    CONSTRAINT "PK_administradora_bandeira" PRIMARY KEY (id_geral)
);

CREATE TABLE agenda_situacao (
    cd_situacao integer NOT NULL,
    nm_situacao character varying(30) NOT NULL,
    dt_atz date NOT NULL DEFAULT (CURRENT_DATE),
    CONSTRAINT "PK_agenda_situacao" PRIMARY KEY (cd_situacao)
);

CREATE TABLE alteracao_cad_item (
    id_geral integer NOT NULL,
    cd_item character varying(15) NOT NULL,
    nr_campo integer NOT NULL,
    cont_ant character varying(120) NULL,
    dt_alt date NOT NULL,
    CONSTRAINT "PK_alteracao_cad_item" PRIMARY KEY (id_geral)
);

CREATE TABLE alteracao_cad_participante (
    id_geral integer NOT NULL,
    cd_participante integer NULL,
    tp_participante character varying(1) NULL,
    nr_campo integer NULL,
    cont_ant character varying(100) NULL,
    dt_alt date NULL,
    CONSTRAINT "PK_alteracao_cad_participante" PRIMARY KEY (id_geral)
);

CREATE TABLE anp (
    codigo character varying(5) NOT NULL,
    cd_anp character varying(9) NOT NULL,
    descricao_anp character varying(95) NULL,
    pc_glp numeric(18,4) NULL,
    pc_gas_nacional numeric(18,4) NULL,
    pc_gas_importado numeric(18,4) NULL,
    codif character varying(21) NULL,
    vl_partida numeric(15,4) NULL,
    CONSTRAINT "PK_anp" PRIMARY KEY (codigo)
);

CREATE TABLE anvisa (
    codigo character varying(5) NOT NULL,
    cd_anvisa character varying(9) NOT NULL,
    preco numeric(15,2) NULL,
    descricao_anvisa text NULL,
    CONSTRAINT "PK_anvisa" PRIMARY KEY (codigo)
);

CREATE TABLE aplicacao (
    cd_aplicacao integer NOT NULL,
    nm_aplicacao character varying(80) NOT NULL,
    dt_atz date NOT NULL,
    CONSTRAINT "PK_aplicacao" PRIMARY KEY (cd_aplicacao)
);

CREATE TABLE autoriza_xml (
    cnpj character varying(18) NOT NULL,
    descricao character varying(120) NOT NULL,
    CONSTRAINT "PK_autoriza_xml" PRIMARY KEY (cnpj)
);

CREATE TABLE banco (
    cd_banco integer NOT NULL,
    nm_banco character varying(80) NOT NULL,
    nm_arq_boleto character varying(20) NULL,
    dt_atz date NULL DEFAULT (CURRENT_DATE),
    CONSTRAINT "PK_banco" PRIMARY KEY (cd_banco)
);

CREATE TABLE beneficio_fiscal (
    id integer NOT NULL,
    cod_ajur character varying(10) NULL,
    desc_ajur character varying(500) NULL,
    dt_ini date NULL,
    dt_fim date NULL,
    CONSTRAINT "PK_beneficio_fiscal" PRIMARY KEY (id)
);

CREATE TABLE carta_correcao (
    id_geral integer NOT NULL,
    cd_filial integer NOT NULL,
    id_nf integer NOT NULL,
    fl_ent_sai character varying(1) NOT NULL,
    sequencia integer NOT NULL,
    chave_acesso_nfe character varying(44) NULL,
    protocolo character varying(20) NULL,
    dt_autorizacao date NULL,
    hr_autorizacao time without time zone NULL,
    correcao text NULL,
    xml text NULL,
    CONSTRAINT "PK_carta_correcao" PRIMARY KEY (id_geral)
);

CREATE TABLE cest (
    cd_cest integer NOT NULL,
    descricao_cest character varying(999) NOT NULL,
    cest character varying(7) NOT NULL,
    CONSTRAINT "PK_cest" PRIMARY KEY (cd_cest)
);

CREATE TABLE cfop (
    cfop character varying(5) NOT NULL,
    descricao character varying(200) NOT NULL,
    aplicacao text NULL,
    CONSTRAINT "PK_cfop" PRIMARY KEY (cfop)
);

CREATE TABLE cfop_regra (
    cd_cfop_regra integer NOT NULL,
    nm_cfop_regra character varying(80) NOT NULL,
    CONSTRAINT "PK_cfop_regra" PRIMARY KEY (cd_cfop_regra)
);

CREATE TABLE class_lista_servico (
    cd_lista_servico character varying(4) NOT NULL,
    nm_lista_servico character varying(1000) NULL,
    CONSTRAINT "PK_class_lista_servico" PRIMARY KEY (cd_lista_servico)
);

CREATE TABLE cliente_grupo (
    cd_grupo_cliente smallint NOT NULL,
    nm_grupo_cliente character varying(40) NOT NULL,
    CONSTRAINT "PK_cliente_grupo" PRIMARY KEY (cd_grupo_cliente)
);

CREATE TABLE cob_convenio (
    cd_convenio integer NOT NULL,
    nm_convenio character varying(40) NOT NULL,
    fl_remessa character varying(1) NOT NULL,
    fl_retorno_remessa character varying(1) NOT NULL,
    fl_emissor character varying(1) NOT NULL,
    fl_aceite character varying(1) NOT NULL,
    nr_convenio character varying(15) NOT NULL,
    nr_sequencial bigint NOT NULL,
    nr_ultima_remessa bigint NULL,
    mensagem text NULL,
    fl_padrao_remessa character varying(1) NULL,
    fl_protesto character varying(1) NOT NULL,
    nr_dias_protesto smallint NOT NULL,
    mensagem_protesto text NULL,
    local_pagamento character varying(300) NOT NULL,
    nr_agencia character varying(10) NULL,
    nr_dv_agencia character varying(2) NULL,
    nr_banco integer NOT NULL,
    nr_conta character varying(10) NULL,
    nr_dv_conta character varying(2) NULL,
    nr_dv_banco character varying(2) NULL,
    tp_cobranca character varying(3) NULL,
    sg_especie character varying(3) NULL,
    nm_agencia character varying(80) NULL,
    unidade_cedente character varying(80) NULL,
    op_conta numeric(3,0) NULL,
    nm_banco character varying(80) NULL,
    diretorio character varying(150) NULL,
    cd_instrucao1 character varying(2) NULL,
    cd_instrucao2 character varying(2) NULL,
    nr_dias_baixa integer NULL,
    cd_caixa integer NULL,
    diretorio_remessa character varying(200) NULL,
    diretorio_retorno character varying(200) NULL,
    fl_deb_automatico character varying(1) NULL,
    fl_nr_nfs character varying(1) NULL,
    layout_boleto character varying(200) NULL,
    fl_sinc_nr_seq boolean NULL,
    CONSTRAINT "PK_cob_convenio" PRIMARY KEY (cd_convenio)
);

CREATE TABLE cob_motivo_movimento_retorno (
    id_geral bigint NOT NULL,
    cd_motivo character varying(10) NOT NULL,
    descricao character varying(255) NULL,
    cd_convenio integer NULL,
    CONSTRAINT "PK_cob_motivo_movimento_retorno" PRIMARY KEY (id_geral)
);

CREATE TABLE cob_movimento_retorno (
    id_geral bigint NOT NULL,
    cd_movimento character varying(10) NOT NULL,
    descricao character varying(255) NULL,
    fl_tipo character varying(1) NULL,
    cd_convenio integer NULL,
    CONSTRAINT "PK_cob_movimento_retorno" PRIMARY KEY (id_geral)
);

CREATE TABLE codigo_tributacao_municipio (
    cd_tributacao_municipio integer NOT NULL,
    nm_tributacao_municipio character varying(100) NOT NULL,
    CONSTRAINT "PK_codigo_tributacao_municipio" PRIMARY KEY (cd_tributacao_municipio)
);

CREATE TABLE comissao_func (
    cd_filial integer NOT NULL,
    nr_documento integer NOT NULL,
    nr_sequencia integer NOT NULL,
    cd_funcionario integer NOT NULL,
    nr_parcela integer NOT NULL,
    nr_nf integer NULL,
    nr_cupom integer NULL,
    nr_sr integer NULL,
    vl_total numeric(9,2) NOT NULL,
    pc_sobre_comissao numeric(9,2) NOT NULL,
    pc_minimo numeric(9,2) NULL,
    pc_comissao numeric(9,2) NOT NULL,
    pc_minimo_comissao numeric(9,2) NULL,
    vl_comissao numeric(9,4) NOT NULL,
    vl_pago numeric(9,2) NULL,
    dt_emissao timestamp without time zone NOT NULL,
    dt_ult_pgto timestamp without time zone NULL,
    pc_comissao_grupo numeric(9,2) NOT NULL,
    pc_parcela double precision NULL,
    dt_vcto timestamp without time zone NOT NULL,
    vl_base numeric(18,4) NOT NULL,
    CONSTRAINT "PK_comissao_func" PRIMARY KEY (cd_filial, nr_documento, nr_sequencia, cd_funcionario, nr_parcela)
);

CREATE TABLE conf_estudo_lucratividade (
    cd_produto character varying(15) NOT NULL,
    pc_de_quebra double precision NULL,
    pc_despesas_operacionais double precision NULL,
    pc_csll double precision NULL,
    pc_irrj double precision NULL,
    pc_aliq_simples_nacional double precision NULL,
    pc_custo_fixo double precision NULL,
    pc_outras_despesas double precision NULL,
    CONSTRAINT "PK_conf_estudo_lucratividade" PRIMARY KEY (cd_produto)
);

CREATE TABLE construcao (
    cd_construcao integer NOT NULL,
    nm_construcao character varying(80) NOT NULL,
    dt_atz date NOT NULL,
    CONSTRAINT "PK_construcao" PRIMARY KEY (cd_construcao)
);

CREATE TABLE conta_contabil (
    cd_conta integer NOT NULL,
    nm_conta character varying(50) NOT NULL,
    cd_historico integer NULL,
    dt_atz date NULL,
    CONSTRAINT "PK_conta_contabil" PRIMARY KEY (cd_conta)
);

CREATE TABLE contabilista (
    cd_filial integer NOT NULL,
    cd_contabilista integer NOT NULL,
    nm_contabilista character varying(100) NOT NULL,
    cpf character varying(14) NOT NULL,
    crc character varying(15) NOT NULL,
    cnpj_escritorio_cont character varying(18) NULL,
    cep character varying(10) NULL,
    endereco character varying(60) NULL,
    numero integer NULL,
    complemento character varying(20) NULL,
    bairro character varying(30) NULL,
    fone character varying(16) NULL,
    fax character varying(16) NULL,
    email character varying(100) NULL,
    cd_cidade integer NOT NULL,
    CONSTRAINT "PK_contabilista" PRIMARY KEY (cd_filial, cd_contabilista)
);

CREATE TABLE crptitulo_agrupado (
    cd_filial_o integer NOT NULL,
    cd_tipo_conta_o integer NOT NULL,
    nr_titulo_o character varying(15) NOT NULL,
    parcela_o integer NOT NULL,
    cd_clifor_o integer NOT NULL,
    cd_filial_d integer NULL,
    cd_tipo_conta_d integer NULL,
    nr_titulo_d character varying(15) NULL,
    parcela_d integer NULL,
    cd_clifor_d integer NULL,
    dt_agrupamento date NULL,
    CONSTRAINT "PK_crptitulo_agrupado" PRIMARY KEY (cd_filial_o, cd_tipo_conta_o, nr_titulo_o, parcela_o, cd_clifor_o)
);

CREATE TABLE cst_ipi (
    cd_cst_ipi character varying(10) NOT NULL,
    descricao character varying(100) NOT NULL,
    fl_tributada character(1) NOT NULL DEFAULT ('N'::bpchar),
    fl_ent_sai character(1) NULL,
    CONSTRAINT "PK_cst_ipi" PRIMARY KEY (cd_cst_ipi)
);

CREATE TABLE cst_pis_cofins (
    cd_cst_pis_cofins character varying(10) NOT NULL,
    descricao character varying(200) NOT NULL,
    fl_tributada character(1) NOT NULL DEFAULT ('N'::bpchar),
    fl_ent_sai character(1) NULL,
    CONSTRAINT "PK_cst_pis_cofins" PRIMARY KEY (cd_cst_pis_cofins)
);

CREATE TABLE cxa_abertura (
    cd_filial integer NOT NULL,
    cd_caixa integer NOT NULL,
    cd_funcionario integer NOT NULL,
    nr_sequencial integer NOT NULL,
    cd_caixa_origem integer NOT NULL,
    dt_abertura date NOT NULL,
    hora_abertura time without time zone NOT NULL,
    dt_fechamento date NULL,
    hora_fechamento time without time zone NULL,
    vl_ini_outros numeric(18,4) NOT NULL,
    vl_ini_cheque numeric(18,4) NOT NULL,
    vl_ini_cartao numeric(18,4) NOT NULL,
    vl_ini_dinheiro numeric(18,4) NOT NULL,
    vl_fim_outros numeric(18,4) NULL,
    vl_fim_cheque numeric(18,4) NULL,
    vl_fim_cartao numeric(18,4) NULL,
    vl_fim_dinheiro numeric(18,4) NULL,
    fl_fechado character varying(1) NOT NULL,
    dt_atz date NOT NULL DEFAULT (CURRENT_DATE),
    CONSTRAINT "PK_cxa_abertura" PRIMARY KEY (cd_filial, cd_caixa, cd_funcionario, nr_sequencial)
);

CREATE TABLE cxa_acesso (
    cd_filial integer NOT NULL,
    cd_funcionario integer NOT NULL,
    cd_caixa integer NOT NULL,
    leitura character(1) NULL,
    gravacao character(1) NULL,
    exclusao character(1) NULL,
    obs character varying(40) NULL,
    dt_atz date NULL DEFAULT (CURRENT_DATE),
    CONSTRAINT "PK_cxa_acesso" PRIMARY KEY (cd_filial, cd_funcionario, cd_caixa)
);

CREATE TABLE estocagem (
    cd_filial integer NOT NULL,
    local_estocagem character varying(10) NOT NULL,
    nm_local character varying(40) NOT NULL,
    dt_atz date NULL DEFAULT (CURRENT_DATE),
    CONSTRAINT "PK_estocagem" PRIMARY KEY (cd_filial, local_estocagem)
);

CREATE TABLE filial_bd (
    cd_filial integer NOT NULL,
    nm_filial character varying(50) NOT NULL,
    nm_servidor_bd character varying(100) NOT NULL,
    nm_bd character varying(200) NOT NULL,
    nm_usuario character varying(50) NOT NULL,
    senha character varying(100) NOT NULL,
    fl_sincronizar_contas boolean NOT NULL,
    fl_dados_contas_desatualizados character(1) NOT NULL DEFAULT ('I'::bpchar),
    nr_minutos_contas_desatualizado integer NOT NULL DEFAULT (10),
    CONSTRAINT "PK_filial_bd" PRIMARY KEY (cd_filial)
);

CREATE TABLE filial_conf_nfe_nfse (
    cd_filial integer NOT NULL,
    certificado_caminho character varying(100) NULL,
    certificado_senha character varying(20) NULL,
    certificado_numero_serie character varying(60) NULL,
    path_schema_nfse character varying(100) NULL,
    path_xml_nfse character varying(100) NULL,
    tp_ambiente_nfse character varying(1) NULL,
    regime_especial_trib_nfse integer NULL,
    tempo_espera_consulta integer NULL,
    tentativas integer NULL,
    path_schema_nfe character varying(100) NULL,
    path_xml_nfe character varying(100) NULL,
    tp_ambiente_nfe character varying(1) NULL,
    visualizar boolean NULL,
    logoprefeitura character varying(100) NULL,
    logonfe character varying(100) NULL,
    versao_nfe character varying(1) NULL,
    path_xml_mdfe character varying(100) NULL,
    path_schema_mdfe character varying(100) NULL,
    tp_ambiente_mdfe character varying(1) NULL,
    senha_webserv character varying(100) NULL,
    usuario_webserv character varying(100) NULL,
    fl_envia_email character varying(1) NULL,
    email_nfe character varying(100) NULL,
    csc character varying(36) NULL,
    id_csc character varying(6) NULL,
    CONSTRAINT "PK_filial_conf_nfe_nfse" PRIMARY KEY (cd_filial)
);

CREATE TABLE fornecedor_unmedida (
    id_geral integer NOT NULL,
    cd_fornecedor integer NULL,
    un_medida character varying(6) NULL,
    un_medida_forn character varying(6) NULL,
    dt_atz date NULL,
    CONSTRAINT "PK_fornecedor_unmedida" PRIMARY KEY (id_geral)
);

CREATE TABLE fornprod (
    cd_filial integer NOT NULL,
    cd_fornecedor integer NOT NULL,
    cd_produto integer NOT NULL,
    dt_atz date NULL DEFAULT (CURRENT_DATE),
    CONSTRAINT "PK_fornprod" PRIMARY KEY (cd_filial, cd_fornecedor, cd_produto)
);

CREATE TABLE grupo_comissao (
    cd_grupo_comissao integer NOT NULL,
    descricao character varying(40) NOT NULL,
    pc_comissao numeric(9,2) NOT NULL,
    CONSTRAINT "PK_grupo_comissao" PRIMARY KEY (cd_grupo_comissao)
);

CREATE TABLE grupo_operacao_es (
    cd_grupo character varying(2) NOT NULL,
    nm_grupo character varying(50) NULL,
    CONSTRAINT "PK_grupo_operacao_es" PRIMARY KEY (cd_grupo)
);

CREATE TABLE gruprod (
    cd_gruprod integer NOT NULL,
    nm_gruprod character varying(40) NOT NULL,
    dt_atz date NULL DEFAULT (CURRENT_DATE),
    CONSTRAINT "PK_gruprod" PRIMARY KEY (cd_gruprod)
);

CREATE TABLE "HASH" (
    id_geral integer NOT NULL,
    nm_tabela character varying(30) NOT NULL,
    "HASH" character varying(70) NOT NULL,
    fl_valido character varying(1) NULL,
    CONSTRAINT "PK_HASH" PRIMARY KEY (id_geral)
);

CREATE TABLE help_atz (
    id_geral integer NOT NULL,
    descricao text NOT NULL,
    versao_bd integer NOT NULL,
    versao_sistema character varying(12) NOT NULL,
    CONSTRAINT "PK_help_atz" PRIMARY KEY (id_geral)
);

CREATE TABLE impfiscal (
    cd_impfiscal integer NOT NULL,
    nm_impfiscal character varying(40) NOT NULL,
    cd_modelo integer NOT NULL,
    nr_serie character varying(80) NOT NULL,
    porta_comunicacao character varying(10) NOT NULL,
    dt_atz date NULL DEFAULT (CURRENT_DATE),
    nm_dinheiro character varying(25) NULL,
    nm_cheque character varying(25) NULL,
    nm_cartao character varying(25) NULL,
    nm_outros character varying(25) NULL,
    nm_a_prazo character varying(25) NULL,
    fl_intervencao boolean NOT NULL,
    nr_pdv integer NULL,
    nm_modelo character varying(20) NOT NULL,
    fl_mf_adicional character varying(1) NOT NULL,
    cd_usuario_ecf integer NOT NULL,
    cniee character varying(6) NOT NULL,
    tipo character varying(10) NOT NULL,
    nm_marca character varying(20) NOT NULL,
    versao_sb character varying(11) NOT NULL,
    dt_instalacao_sb date NULL,
    hr_instalacao_sb time without time zone NULL,
    fl_lmf_automatica character varying(1) NULL,
    nm_consulta_cheque character varying(25) NULL,
    hash_impfiscal_e1 character varying(70) NULL,
    hash_impfiscal_r1 character varying(70) NULL,
    hash_impfiscal_r2 character varying(70) NULL,
    hash_impfiscal_r3 character varying(70) NULL,
    hash_impfiscal_r4 character varying(70) NULL,
    hash_impfiscal_r5 character varying(70) NULL,
    hash_impfiscal_r6 character varying(70) NULL,
    hash_impfiscal_r7 character varying(70) NULL,
    CONSTRAINT "PK_impfiscal" PRIMARY KEY (cd_impfiscal)
);

CREATE TABLE log_sistema (
    id_geral bigint NOT NULL,
    dt_hr_exclusao date NULL,
    cd_usuario integer NULL,
    tabela character varying(40) NULL,
    observacao text NULL,
    CONSTRAINT "PK_log_sistema" PRIMARY KEY (id_geral)
);

CREATE TABLE marca (
    cd_marca integer NOT NULL,
    nm_marca character varying(40) NOT NULL,
    dt_atz date NULL DEFAULT (CURRENT_DATE),
    CONSTRAINT "PK_marca" PRIMARY KEY (cd_marca)
);

CREATE TABLE medida (
    cd_medida integer NOT NULL,
    nm_medida character varying(80) NOT NULL,
    dt_atz date NOT NULL,
    CONSTRAINT "PK_medida" PRIMARY KEY (cd_medida)
);

CREATE TABLE mensagem_nota (
    cd_mensagem integer NOT NULL,
    nm_mensagem character varying(30) NULL,
    fl_fiscal character varying(1) NOT NULL,
    mensagem text NOT NULL,
    fl_informacoes_fisco character(1) NOT NULL,
    CONSTRAINT "PK_mensagem_nota" PRIMARY KEY (cd_mensagem)
);

CREATE TABLE modelo (
    cd_modelo integer NOT NULL,
    nm_modelo character varying(80) NOT NULL,
    dt_atz date NOT NULL,
    CONSTRAINT "PK_modelo" PRIMARY KEY (cd_modelo)
);

CREATE TABLE modelo_dcto (
    cd_modelo character varying(3) NOT NULL,
    nm_modelo character varying(50) NULL,
    CONSTRAINT "PK_modelo_dcto" PRIMARY KEY (cd_modelo)
);

CREATE TABLE montadora (
    cd_filial integer NOT NULL,
    cd_montadora integer NOT NULL,
    nm_montadora character varying(40) NOT NULL,
    dt_atz date NULL DEFAULT (CURRENT_DATE),
    CONSTRAINT "PK_montadora" PRIMARY KEY (cd_filial, cd_montadora)
);

CREATE TABLE motivo_devolucao (
    cd_motivo_devolucao integer NOT NULL,
    nm_motivo_devolucao character varying(50) NOT NULL,
    dt_atz timestamp without time zone NULL,
    CONSTRAINT "PK_motivo_devolucao" PRIMARY KEY (cd_motivo_devolucao)
);

CREATE TABLE movimento_cxa_vinculo (
    id_geral integer NOT NULL,
    cd_filial_o integer NOT NULL,
    nr_lcto_o integer NOT NULL,
    cd_caixa_o integer NOT NULL,
    cd_filial_d integer NOT NULL,
    nr_lcto_d integer NOT NULL,
    cd_caixa_d integer NOT NULL,
    CONSTRAINT "PK_movimento_cxa_vinculo" PRIMARY KEY (id_geral)
);

CREATE TABLE nf_contabil_c (
    id_geral integer NOT NULL,
    cd_filial integer NULL,
    id_nfc integer NULL,
    fl_entrada_saida character varying(1) NULL,
    nr_nf bigint NULL,
    nr_cupom integer NULL,
    cd_clifor integer NULL,
    serie_nf character varying(3) NULL,
    clifor_cnpj_cpf character varying(18) NULL,
    clifor_ie_rg character varying(18) NULL,
    uf_destino character varying(2) NULL,
    uf_origem character varying(2) NULL,
    dt_emissao date NULL,
    cd_modelo character varying(3) NULL,
    fl_impresso character varying(1) NULL,
    icms_normal_base numeric(14,2) NULL,
    icms_normal_vl numeric(14,2) NULL,
    icms_proprio_base numeric(14,2) NULL,
    icms_proprio_vl numeric(14,2) NULL,
    icms_st_base numeric(14,2) NULL,
    icms_st_vl numeric(14,2) NULL,
    iss_base numeric(14,2) NULL,
    iss_vl numeric(14,2) NULL,
    ipi_base numeric(14,2) NULL,
    ipi_vl numeric(14,2) NULL,
    pis_vl_base numeric(14,2) NULL,
    pis_vl numeric(14,2) NULL,
    cofins_vl_base numeric(14,2) NULL,
    cofins_vl numeric(14,2) NULL,
    vl_desconto_item numeric(14,2) NULL,
    vl_desconto numeric(14,2) NULL,
    vl_acrescimo numeric(14,2) NULL,
    vl_seguro numeric(14,2) NULL,
    vl_frete numeric(14,2) NULL,
    vl_total numeric(14,2) NULL,
    vl_isento_itens numeric(14,2) NULL,
    vl_outros_itens numeric(14,2) NULL,
    ecf_cd integer NULL,
    ecf_nr_fabricacao character varying(40) NULL,
    ecf_nr_pdv integer NULL,
    fl_cancelado character varying(1) NULL,
    obs text NULL,
    nm_operacao character varying(40) NULL,
    vl_mercadorias numeric(14,2) NULL,
    vl_servicos numeric(14,2) NULL,
    cond_pgto integer NULL,
    cd_transportadora integer NULL,
    dt_entrada_saida date NULL,
    frete_vl_icm numeric(14,2) NULL,
    frete_cfop character varying(10) NULL,
    sub_serie character varying(3) NULL,
    icms_st_ant_base numeric(14,2) NULL,
    icms_st_ant_vl numeric(14,2) NULL,
    hr_emissao time without time zone NULL,
    ecf_nr_coo_cupom integer NULL,
    fl_simples character varying(1) NULL,
    nfe_chave_acesso character varying(44) NULL,
    nfe_nr_protocolo character varying(50) NULL,
    nfe_dt_processamento date NULL,
    nfe_tp_emissao integer NULL,
    nfe_nr_lote character varying(15) NULL,
    nfe_nr_recibo character varying(15) NULL,
    vl_fcp numeric(13,2) NULL,
    vl_fcp_st numeric(13,2) NULL,
    vl_fcp_st_retido numeric(13,2) NULL,
    vl_icms_uf_dest numeric(13,2) NULL,
    vl_icms_uf_remet numeric(13,2) NULL,
    vl_fcp_uf_dest numeric(13,2) NULL,
    CONSTRAINT "PK_nf_contabil_c" PRIMARY KEY (id_geral)
);

CREATE TABLE nf_referenciada (
    id_geral integer NOT NULL,
    fl_entrada_saida character varying(1) NULL,
    nr_documento integer NULL,
    fl_entrada_saida_ref character varying(1) NULL,
    nr_documento_ref integer NULL,
    CONSTRAINT "PK_nf_referenciada" PRIMARY KEY (id_geral)
);

CREATE TABLE nf_xml (
    id_nf integer NOT NULL,
    fl_ent_sai character(1) NOT NULL,
    xml text NULL,
    dt_atz date NULL DEFAULT (CURRENT_DATE),
    xml_canc text NULL,
    CONSTRAINT "PK_nf_xml" PRIMARY KEY (id_nf, fl_ent_sai)
);

CREATE TABLE nfe_contingencia (
    id_geral integer NOT NULL,
    cd_status integer NULL,
    dt_inicio date NULL,
    hr_inicio time without time zone NULL,
    dt_fim date NULL,
    hr_fim time without time zone NULL,
    motivo character varying(50) NULL,
    cd_filial integer NULL,
    CONSTRAINT "PK_nfe_contingencia" PRIMARY KEY (id_geral)
);

CREATE TABLE nfe_inutilizacao (
    id_geral integer NOT NULL,
    nr_nf integer NOT NULL,
    serie_nf character varying(3) NOT NULL,
    dt_processamento_inut date NOT NULL,
    nr_protocolo_inut character varying(15) NOT NULL,
    cd_usuario integer NOT NULL,
    motivo character varying(80) NOT NULL,
    CONSTRAINT "PK_nfe_inutilizacao" PRIMARY KEY (id_geral)
);

CREATE TABLE nfsc_servico (
    nr_documento integer NOT NULL,
    cd_cidade_prestacao integer NULL,
    cd_nat_operacao integer NULL,
    incentivo_cultural boolean NULL,
    CONSTRAINT "PK_nfsc_servico" PRIMARY KEY (nr_documento)
);

CREATE TABLE nfsicomplemento (
    cd_filial integer NOT NULL,
    nr_os integer NOT NULL,
    nr_sequencia integer NOT NULL,
    complemento text NULL,
    dt_atz date NULL DEFAULT (CURRENT_DATE),
    CONSTRAINT "PK_nfsicomplemento" PRIMARY KEY (cd_filial, nr_os, nr_sequencia)
);

CREATE TABLE nr_serie_nfs (
    nr_serie character varying(3) NOT NULL,
    nr_ult_nfsaida integer NULL,
    nr_ult_nfservico bigint NULL,
    end_arquivo_modelo text NULL,
    fl_bloco_manual character varying(1) NULL DEFAULT ('N'::character varying),
    nr_aidf character varying(20) NULL,
    end_arquivo_fsda text NULL,
    CONSTRAINT "PK_nr_serie_nfs" PRIMARY KEY (nr_serie)
);

CREATE TABLE nsu (
    id_geral integer NOT NULL,
    nsu character varying(10) NOT NULL,
    nr_documento integer NOT NULL,
    serie character varying(3) NOT NULL,
    cd_clifor integer NOT NULL,
    fl_tipo character varying(1) NOT NULL,
    dt_emissao date NOT NULL,
    hr_emissao time without time zone NOT NULL,
    CONSTRAINT "PK_nsu" PRIMARY KEY (id_geral)
);

CREATE TABLE orcamento_agrupado (
    nr_os integer NOT NULL,
    nr_os_agrupada integer NOT NULL,
    CONSTRAINT "PK_orcamento_agrupado" PRIMARY KEY (nr_os, nr_os_agrupada)
);

CREATE TABLE orcamento_dav (
    nr_os integer NOT NULL,
    nr_sequencia integer NOT NULL,
    nr_dav integer NULL,
    nr_coo_dav integer NULL,
    nr_coo_cupom integer NULL,
    cd_usuario integer NULL,
    dt_atz date NULL,
    cd_impfiscal integer NULL,
    mf_adicional character varying(1) NULL,
    fl_cancelado character varying(1) NULL,
    vl_total_dav numeric(18,4) NULL,
    nr_ccf_cupom integer NULL,
    hash_orcamento_dav_d2 character varying(70) NULL,
    hash_orcamento_dav_d3 character varying(70) NULL,
    CONSTRAINT "PK_orcamento_dav" PRIMARY KEY (nr_os, nr_sequencia)
);

CREATE TABLE orcamento_frete (
    cd_filial integer NOT NULL,
    nr_os integer NOT NULL,
    cd_transportadora integer NOT NULL,
    tp_frete character varying(1) NOT NULL,
    marca_volumes character varying(15) NULL,
    especie_volumes character varying(15) NULL,
    qt_volumes double precision NULL,
    nr_volumes double precision NULL,
    peso_liquido double precision NULL,
    peso_total double precision NULL,
    placa_transp character varying(8) NULL,
    uf_placa_transp character varying(2) NULL,
    CONSTRAINT "PK_orcamento_frete" PRIMARY KEY (cd_filial, nr_os)
);

CREATE TABLE orcamento_imagem (
    id_geral integer NOT NULL,
    nr_os integer NOT NULL,
    obs character varying(200) NULL,
    imagem text NOT NULL,
    dt_atz date NOT NULL DEFAULT (CURRENT_DATE),
    CONSTRAINT "PK_orcamento_imagem" PRIMARY KEY (id_geral, nr_os)
);

CREATE TABLE orcamento_situacao (
    cd_filial integer NOT NULL,
    nr_os integer NOT NULL,
    dt_modificacao timestamp without time zone NOT NULL,
    cd_funcionario integer NOT NULL,
    cd_situacao integer NOT NULL,
    CONSTRAINT "PK_orcamento_situacao" PRIMARY KEY (cd_filial, nr_os, dt_modificacao)
);

CREATE TABLE ordem_producao_c (
    id_geral bigint NOT NULL,
    cd_filial integer NOT NULL,
    nr_ordem_producao integer NOT NULL,
    dt_emissao date NULL,
    dt_previsao date NULL,
    cd_situacao character varying(1) NULL,
    cd_funcionario integer NULL,
    nr_maquina character varying(100) NULL,
    turno character varying(100) NULL,
    CONSTRAINT "PK_ordem_producao_c" PRIMARY KEY (id_geral)
);

CREATE TABLE pedido_afv_c (
    cd_filial integer NOT NULL,
    nr_pedido integer NOT NULL,
    cd_clifor integer NULL,
    vl_acrescimos numeric(18,4) NULL,
    vl_descontos numeric(18,4) NULL,
    vl_mercadorias numeric(18,4) NULL,
    vl_servicos numeric(18,4) NULL,
    vl_total numeric(18,4) NULL,
    cd_condpgto integer NOT NULL,
    vl_entrada numeric(18,4) NULL,
    dt_emissao date NULL,
    dt_validade date NULL,
    cd_usuario integer NULL,
    dt_atz date NULL DEFAULT (CURRENT_DATE),
    motivo_cancelamento character varying(80) NULL,
    obs text NULL,
    indice_preco smallint NOT NULL,
    vl_ipi numeric(18,4) NULL,
    cd_situacao integer NOT NULL,
    fl_agrupado boolean NOT NULL,
    fl_cancelado boolean NOT NULL,
    fl_finalizado boolean NOT NULL,
    dt_entrega date NULL,
    fl_transmitido character(1) NULL DEFAULT ('N'::bpchar),
    fl_gerado boolean NULL,
    nr_os_gerada integer NULL,
    nr_dav_gerada integer NULL,
    CONSTRAINT "PK_pedido_afv_c" PRIMARY KEY (cd_filial, nr_pedido)
);

CREATE TABLE pedido_afv_i (
    cd_filial integer NOT NULL,
    nr_pedido integer NOT NULL,
    nr_sequencia integer NOT NULL,
    cd_produto character varying(15) NOT NULL,
    nm_produto character varying(60) NULL,
    un_medida character varying(3) NULL,
    fl_servico character varying(1) NULL,
    qt_produto double precision NULL,
    vl_bruto numeric(18,4) NULL,
    pc_desconto numeric(9,2) NULL,
    vl_liquido numeric(18,4) NULL,
    vl_total numeric(18,4) NULL,
    dt_emissao date NOT NULL DEFAULT (CURRENT_DATE),
    complemento text NULL,
    cd_funcionario integer NULL,
    vl_custo numeric(18,4) NULL,
    dt_atz date NULL DEFAULT (CURRENT_DATE),
    cd_original character varying(20) NULL,
    cd_barras character varying(20) NULL,
    placa_veiculo character varying(8) NULL,
    kilometragem integer NULL,
    vl_ipi numeric(18,4) NULL,
    CONSTRAINT "PK_pedido_afv_i" PRIMARY KEY (cd_filial, nr_pedido, nr_sequencia)
);

CREATE TABLE pedido_c (
    nr_pedido integer NOT NULL,
    cd_funcionario integer NULL,
    fl_situacao character(1) NOT NULL,
    dt_emissao date NOT NULL,
    cd_fornecedor integer NOT NULL,
    dt_validade date NULL,
    cd_condpgto integer NOT NULL,
    obs text NULL,
    motivo_cancelamento text NULL,
    vl_total numeric(18,4) NULL,
    dt_atz date NOT NULL DEFAULT (CURRENT_DATE),
    CONSTRAINT "PK_pedido_c" PRIMARY KEY (nr_pedido)
);

CREATE TABLE pedido_frete (
    cd_filial integer NOT NULL,
    nr_pedido integer NOT NULL,
    cd_transportadora integer NOT NULL,
    tp_frete character varying(1) NOT NULL,
    marca_volumes character varying(15) NULL,
    especie_volumes character varying(15) NULL,
    qt_volumes double precision NULL,
    nr_volumes double precision NULL,
    peso_liquido double precision NULL,
    peso_total double precision NULL,
    placa_transp character varying(8) NULL,
    uf_placa_transp character varying(2) NULL,
    CONSTRAINT "PK_pedido_frete" PRIMARY KEY (cd_filial, nr_pedido)
);

CREATE TABLE perfil_acesso (
    cd_perfil integer NOT NULL,
    nm_perfil character varying(40) NOT NULL,
    fl_acesso_irrestrito character varying(1) NULL,
    fl_ativo character varying(1) NOT NULL,
    CONSTRAINT "PK_perfil_acesso" PRIMARY KEY (cd_perfil)
);

CREATE TABLE pl_historico (
    cd_filial integer NOT NULL,
    cd_historico integer NOT NULL,
    descricao character varying(40) NOT NULL,
    complemento boolean NULL,
    dt_atz date NULL DEFAULT (CURRENT_DATE),
    CONSTRAINT "PK_pl_historico" PRIMARY KEY (cd_filial, cd_historico)
);

CREATE TABLE prod_original (
    cd_produto_alt character varying(20) NOT NULL,
    cd_produto_ori character varying(20) NOT NULL,
    dt_atz date NULL DEFAULT (CURRENT_DATE),
    CONSTRAINT "PK_prod_original" PRIMARY KEY (cd_produto_alt, cd_produto_ori)
);

CREATE TABLE prod_relacionado (
    cd_produto character varying(15) NOT NULL,
    cd_relacionado character varying(15) NOT NULL,
    qt_relacionado double precision NULL,
    dt_atz date NULL DEFAULT (CURRENT_DATE),
    CONSTRAINT "PK_prod_relacionado" PRIMARY KEY (cd_produto, cd_relacionado)
);

CREATE TABLE produto_altprec (
    id_geral integer NOT NULL,
    cd_produto character varying(15) NOT NULL,
    cd_funcionario integer NOT NULL,
    dt_alteracao date NOT NULL,
    nm_form character varying(40) NOT NULL,
    desc_form character varying(60) NOT NULL,
    preco_venda_ant numeric(18,4) NOT NULL,
    preco_venda_novo numeric(18,4) NOT NULL,
    preco_venda_min_ant numeric(18,4) NOT NULL,
    preco_venda_min_novo numeric(18,4) NOT NULL,
    preco_venda_flex_max_ant numeric(18,4) NOT NULL,
    preco_venda_flex_max_novo numeric(18,4) NOT NULL,
    preco_venda_flex_min_ant numeric(18,4) NOT NULL,
    preco_venda_flex_min_novo numeric(18,4) NOT NULL,
    cd_tabela_preco integer NULL,
    hr_alteracao time without time zone NULL,
    id_nfec integer NULL,
    CONSTRAINT "PK_produto_altprec" PRIMARY KEY (id_geral)
);

CREATE TABLE produto_class_fiscal (
    cd_class_fiscal character varying(5) NOT NULL,
    nm_class_fiscal character varying(10) NOT NULL,
    dt_atz date NULL,
    descricao character(200) NULL,
    aliq_ipi double precision NULL,
    cst_ipi_compra character varying(2) NULL,
    cst_ipi_venda character varying(2) NULL,
    cst_pis_compra character varying(2) NULL,
    cst_pis_venda character varying(2) NULL,
    cst_cofins_compra character varying(2) NULL,
    cst_cofins_venda character varying(2) NULL,
    fl_calcular_pis_cofins character varying(1) NULL,
    fl_reducao_mva_simples character varying(1) NULL,
    cd_enquadramento_compra character varying(3) NULL,
    cd_enquadramento_venda character varying(3) NULL,
    cd_cest integer NULL,
    un_trib character varying(6) NULL,
    CONSTRAINT "PK_produto_class_fiscal" PRIMARY KEY (cd_class_fiscal)
);

CREATE TABLE produto_class_fiscal_ibpt (
    id_geral integer NOT NULL,
    codigo character varying(10) NULL,
    tabela integer NULL,
    aliq_nac_fed numeric(5,2) NULL,
    aliq_imp_fed numeric(5,2) NULL,
    aliq_est numeric(5,2) NULL,
    aliq_mun numeric(5,2) NULL,
    dt_inicio timestamp without time zone NULL,
    dt_final timestamp without time zone NULL,
    versao_ibpt character varying(10) NULL,
    uf character varying(3) NULL,
    fonte character varying(30) NULL,
    CONSTRAINT "PK_produto_class_fiscal_ibpt" PRIMARY KEY (id_geral)
);

CREATE TABLE produto_tipo (
    cd_tipo character varying(2) NOT NULL,
    descricao character varying(50) NOT NULL,
    fl_permite_composicao boolean NULL,
    fl_controlar_estoq boolean NULL,
    fl_inventario boolean NULL,
    fl_permitevenda character varying(1) NULL,
    CONSTRAINT "PK_produto_tipo" PRIMARY KEY (cd_tipo)
);

CREATE TABLE produto_unidade (
    cd_produto character varying(15) NOT NULL,
    un_medida character varying(6) NOT NULL,
    fator_conversao double precision NOT NULL,
    cd_barras character varying(20) NULL,
    fl_tipo character varying(1) NULL,
    dt_atz date NULL,
    CONSTRAINT "PK_produto_unidade" PRIMARY KEY (cd_produto, un_medida)
);

CREATE TABLE protocolo_icms (
    id_geral integer NOT NULL,
    nr_protocolo character varying(10) NOT NULL,
    descricao character varying(50) NULL,
    dt_protocolo date NULL,
    CONSTRAINT "PK_protocolo_icms" PRIMARY KEY (id_geral)
);

CREATE TABLE recibo (
    nr_recibo integer NOT NULL,
    nm_pago character varying(100) NOT NULL,
    proveniente character varying(1023) NULL,
    dt_pgto date NOT NULL DEFAULT (CURRENT_DATE),
    vl_pago numeric(18,4) NOT NULL,
    dt_atz date NULL DEFAULT (CURRENT_DATE),
    cd_filial integer NULL,
    assinatura character varying(80) NULL,
    CONSTRAINT "PK_recibo" PRIMARY KEY (nr_recibo)
);

CREATE TABLE reducaoz (
    nr_serie_ecf character varying(20) NOT NULL,
    al_01 numeric(4,2) NULL,
    al_02 numeric(4,2) NULL,
    al_03 numeric(4,2) NULL,
    al_04 numeric(4,2) NULL,
    al_05 numeric(4,2) NULL,
    al_06 numeric(4,2) NULL,
    vl_01 numeric(18,4) NULL,
    vl_02 numeric(18,4) NULL,
    vl_03 numeric(18,4) NULL,
    vl_04 numeric(18,4) NULL,
    vl_05 numeric(18,4) NULL,
    vl_06 numeric(18,4) NULL,
    vl_substituicao numeric(18,4) NULL,
    vl_isento numeric(18,4) NULL,
    vl_cancelamento numeric(18,4) NULL,
    vl_nao_inc numeric(18,4) NULL,
    vl_desconto numeric(18,4) NULL,
    vl_issqn numeric(18,4) NULL,
    vl_total_geral numeric(18,4) NULL,
    vl_bruto_dia numeric(18,4) NULL,
    nr_pdv integer NOT NULL,
    contador_z integer NULL,
    contador_inicial integer NULL,
    contador_final integer NULL,
    contador_ro integer NULL,
    dt_reducao date NOT NULL,
    CONSTRAINT "PK_reducaoz" PRIMARY KEY (nr_serie_ecf, nr_pdv, dt_reducao)
);

CREATE TABLE ref_nota_produtor (
    cd_filial integer NOT NULL,
    cod_referencia integer NOT NULL,
    id_nfec integer NOT NULL,
    data_nf_produtor character varying(4) NOT NULL,
    modelo_nf_produtor character varying(4) NOT NULL,
    serie_nf_produtor character varying(4) NOT NULL,
    nr_nf_produtor character varying(18) NOT NULL,
    CONSTRAINT "PK_ref_nota_produtor" PRIMARY KEY (cod_referencia)
);

CREATE TABLE regiao (
    cd_regiao integer NOT NULL,
    nm_regiao character varying(60) NOT NULL,
    dt_atz date NULL DEFAULT (CURRENT_DATE),
    cd_filial integer NULL,
    CONSTRAINT "PK_regiao" PRIMARY KEY (cd_regiao)
);

CREATE TABLE saldo_cxa_dia (
    cd_filial integer NOT NULL,
    cd_caixa integer NOT NULL,
    dt_caixa date NOT NULL,
    vl_saldo numeric(18,4) NULL,
    CONSTRAINT "PK_saldo_cxa_dia" PRIMARY KEY (cd_filial, cd_caixa, dt_caixa)
);

CREATE TABLE situacao (
    cd_situacao integer NOT NULL,
    nm_situacao character varying(50) NOT NULL,
    fl_inicial boolean NOT NULL,
    fl_final boolean NOT NULL,
    fl_reserva_estoque boolean NOT NULL,
    fl_descricao_servico boolean NOT NULL,
    cd_precedente integer NULL,
    end_arq_modelo text NULL,
    cor character varying(30) NULL,
    fl_produto_serie boolean NOT NULL,
    fl_bloqueia_estoque boolean NOT NULL,
    fl_pre_venda boolean NULL,
    fl_ordem_servico boolean NULL,
    fl_preco_custo boolean NULL,
    fl_exporta_dav_pdf boolean NULL,
    end_arq_modelo_pdf character varying(1000) NULL,
    fl_envia_email character varying(1) NULL,
    fl_ipi character varying(1) NULL,
    fl_icmsst character varying(1) NULL,
    fl_ped_comp boolean NULL,
    CONSTRAINT "PK_situacao" PRIMARY KEY (cd_situacao),
    CONSTRAINT fk_situacao_precedencia FOREIGN KEY (cd_precedente) REFERENCES situacao (cd_situacao) ON DELETE CASCADE
);

CREATE TABLE subgruprod (
    cd_subgruprod integer NOT NULL,
    cd_gruprod integer NOT NULL,
    nm_subgruprod character varying(40) NOT NULL,
    dt_atz date NULL DEFAULT (CURRENT_DATE),
    CONSTRAINT "PK_subgruprod" PRIMARY KEY (cd_subgruprod)
);

CREATE TABLE tab_436_sped_piscofins (
    cd_tp_credito character varying(3) NOT NULL,
    descricao character varying(255) NOT NULL,
    CONSTRAINT "PK_tab_436_sped_piscofins" PRIMARY KEY (cd_tp_credito)
);

CREATE TABLE tab_437_sped_piscofins (
    cd_bc_credito character varying(2) NOT NULL,
    descricao character varying(255) NOT NULL,
    CONSTRAINT "PK_tab_437_sped_piscofins" PRIMARY KEY (cd_bc_credito)
);

CREATE TABLE tabela_preco (
    cd_tabela_preco integer NOT NULL,
    nm_tabela_preco character varying(40) NULL,
    fl_percentual character varying(1) NULL,
    CONSTRAINT "PK_tabela_preco" PRIMARY KEY (cd_tabela_preco)
);

CREATE TABLE tabvcto (
    cd_filial integer NOT NULL,
    nr_os integer NOT NULL,
    parcela integer NOT NULL,
    prazo_parcela integer NOT NULL,
    dt_vcto date NOT NULL DEFAULT (CURRENT_DATE),
    pc_parcela numeric(9,2) NULL,
    vl_vcto numeric(18,4) NOT NULL,
    dt_atz date NULL DEFAULT (CURRENT_DATE),
    CONSTRAINT "PK_tabvcto" PRIMARY KEY (cd_filial, nr_os, parcela)
);

CREATE TABLE tipocobr (
    cd_tipocobr integer NOT NULL,
    nm_tipocobr character varying(80) NOT NULL,
    fl_emitir_bloqueto boolean NULL,
    dt_atz timestamp without time zone NULL,
    vl_acrescimo numeric(18,4) NULL,
    fl_imprime_parcela boolean NOT NULL,
    tp_cobranca character varying(2) NULL,
    descricao_tp_cobranca character varying(40) NULL,
    fl_imprime_carne_ecf boolean NULL,
    fl_imprime_comprovante_ecf boolean NULL,
    taxa_desc numeric(9,2) NULL,
    fl_porcentagem boolean NULL,
    CONSTRAINT "PK_tipocobr" PRIMARY KEY (cd_tipocobr)
);

CREATE TABLE tributacao_grupo (
    id_tributacao_grupo integer NOT NULL,
    nm_tributacao_grupo character varying(40) NULL,
    dt_atz date NULL,
    CONSTRAINT "PK_tributacao_grupo" PRIMARY KEY (id_tributacao_grupo)
);

CREATE TABLE un_medida (
    un_medida character varying(6) NOT NULL,
    descricao character varying(60) NOT NULL,
    CONSTRAINT "PK_un_medida" PRIMARY KEY (un_medida)
);

CREATE TABLE usuario (
    cd_usuario integer NOT NULL,
    login character varying(15) NOT NULL,
    senha character varying(30) NULL,
    fl_acesso_irrestrito character varying(1) NULL,
    fl_ativo character varying(1) NULL,
    fl_ctrl_cxa_retaguarda character varying(1) NOT NULL,
    fl_ctrl_filial character varying(1) NULL,
    cd_funcionario integer NULL,
    fl_sessao_dif_instalacao character varying(20) NULL,
    CONSTRAINT "PK_usuario" PRIMARY KEY (cd_usuario)
);

CREATE TABLE veiculo_combustivel (
    cd_combustivel character varying(2) NOT NULL,
    descricao character varying(20) NULL,
    CONSTRAINT "PK_veiculo_combustivel" PRIMARY KEY (cd_combustivel)
);

CREATE TABLE veiculo_complemento (
    cd_complemento integer NOT NULL,
    descricao character varying(100) NULL,
    dt_atz date NULL,
    CONSTRAINT "PK_veiculo_complemento" PRIMARY KEY (cd_complemento)
);

CREATE TABLE veiculo_cor (
    cd_cor character varying(2) NOT NULL,
    descricao character varying(20) NULL,
    CONSTRAINT "PK_veiculo_cor" PRIMARY KEY (cd_cor)
);

CREATE TABLE veiculo_especie (
    cd_especie character varying(2) NOT NULL,
    descricao character varying(20) NULL,
    CONSTRAINT "PK_veiculo_especie" PRIMARY KEY (cd_especie)
);

CREATE TABLE veiculo_injecao (
    cd_injecao integer NOT NULL,
    descricao character varying(100) NULL,
    dt_atz date NULL,
    CONSTRAINT "PK_veiculo_injecao" PRIMARY KEY (cd_injecao)
);

CREATE TABLE veiculo_motor (
    cd_motor integer NOT NULL,
    descricao character varying(100) NULL,
    dt_atz date NULL,
    CONSTRAINT "PK_veiculo_motor" PRIMARY KEY (cd_motor)
);

CREATE TABLE veiculo_tipo (
    cd_tipo character varying(2) NOT NULL,
    descricao character varying(20) NULL,
    CONSTRAINT "PK_veiculo_tipo" PRIMARY KEY (cd_tipo)
);

CREATE TABLE veiculo_transmissao (
    cd_transmissao integer NOT NULL,
    descricao character varying(100) NULL,
    dt_atz date NULL,
    CONSTRAINT "PK_veiculo_transmissao" PRIMARY KEY (cd_transmissao)
);

CREATE TABLE acesso_acao_rel_campo (
    id_geral bigint NOT NULL,
    id_acao bigint NOT NULL,
    nr_ordem bigint NOT NULL,
    nm_campo character varying(30) NOT NULL,
    fl_grid character(1) NOT NULL,
    fl_tipo_sumarizacao character(1) NULL,
    nm_titulo_campo character varying(30) NOT NULL,
    fl_grafico character(1) NULL,
    tipo_campo character varying(20) NULL,
    topo integer NULL,
    esquerda integer NULL,
    CONSTRAINT "PK_acesso_acao_rel_campo" PRIMARY KEY (id_geral),
    CONSTRAINT fk_acesso_acao_rel_campo_idacao FOREIGN KEY (id_acao) REFERENCES acesso_acao (id_geral) ON DELETE CASCADE
);

CREATE TABLE acesso_acao_relatorio (
    id_acao bigint NOT NULL,
    path_modelo character varying(100) NULL,
    tipo integer NOT NULL,
    sql_rel text NULL,
    CONSTRAINT "PK_acesso_acao_relatorio" PRIMARY KEY (id_acao),
    CONSTRAINT fk_acesso_acao_relatorio_1 FOREIGN KEY (id_acao) REFERENCES acesso_acao (id_geral) ON DELETE CASCADE
);

CREATE TABLE consulta (
    id_consulta integer NOT NULL,
    identificador character varying(18) NOT NULL,
    titulo character varying(100) NOT NULL,
    comando_sql text NOT NULL,
    tabela_cadastro character varying(50) NULL,
    campo_inicial integer NOT NULL DEFAULT (1),
    sql_agrupamento text NULL,
    cd_conexao integer NULL,
    id_acao_cadastro bigint NULL,
    CONSTRAINT "PK_consulta" PRIMARY KEY (id_consulta),
    CONSTRAINT fk_consulta_acao FOREIGN KEY (id_acao_cadastro) REFERENCES acesso_acao (id_geral) ON DELETE RESTRICT
);

CREATE TABLE agenda (
    cd_evento integer NOT NULL,
    dt_hr_evento timestamp without time zone NOT NULL,
    nm_evento text NOT NULL,
    cd_situacao integer NULL,
    CONSTRAINT "PK_agenda" PRIMARY KEY (cd_evento),
    CONSTRAINT fk_agenda_situacao FOREIGN KEY (cd_situacao) REFERENCES agenda_situacao (cd_situacao) ON DELETE RESTRICT
);

CREATE TABLE carta_correcao_hist (
    id_geral integer NOT NULL,
    id_carta_correcao integer NULL,
    nm_tabela character varying(20) NULL,
    nm_campo character varying(20) NULL,
    nr_sequencia_item character varying(4) NULL,
    cd_mensagem character varying(4) NULL,
    cont_ant text NULL,
    cont_atu text NULL,
    CONSTRAINT "PK_carta_correcao_hist" PRIMARY KEY (id_geral),
    CONSTRAINT fk_carta_correcao FOREIGN KEY (id_carta_correcao) REFERENCES carta_correcao (id_geral) ON DELETE CASCADE
);

CREATE TABLE cob_bordero (
    cd_bordero integer NOT NULL,
    cd_convenio integer NOT NULL,
    dt_cadastro date NOT NULL,
    dt_envio_remessa date NULL,
    CONSTRAINT "PK_cob_bordero" PRIMARY KEY (cd_bordero),
    CONSTRAINT fk_cob_bordero_convenio FOREIGN KEY (cd_convenio) REFERENCES cob_convenio (cd_convenio) ON DELETE RESTRICT
);

CREATE TABLE cob_convenio_atributo (
    cd_atributo integer NOT NULL,
    cd_convenio integer NOT NULL,
    nr_ordem integer NOT NULL,
    nm_campo character varying(30) NOT NULL,
    nm_titulo_campo character varying(30) NOT NULL,
    tipo_campo character varying(20) NULL,
    vl_atributo character varying(1000) NULL,
    cd_forma_pgto integer NULL,
    CONSTRAINT "PK_cob_convenio_atributo" PRIMARY KEY (cd_atributo),
    CONSTRAINT fk_cob_convenio_atributo_conv FOREIGN KEY (cd_convenio) REFERENCES cob_convenio (cd_convenio) ON DELETE RESTRICT
);

CREATE TABLE cob_convenio_forma_pgto (
    cd_filial integer NOT NULL,
    cd_forma_pgto integer NOT NULL,
    cd_convenio integer NOT NULL,
    nr_carteira character varying(15) NOT NULL,
    sg_carteira character varying(8) NULL,
    variacao_carteira character varying(3) NULL,
    fl_registrada character varying(1) NOT NULL,
    id_geral integer NOT NULL,
    CONSTRAINT "PK_cob_convenio_forma_pgto" PRIMARY KEY (id_geral),
    CONSTRAINT fk_cob_convenio_forma_pgto FOREIGN KEY (cd_convenio) REFERENCES cob_convenio (cd_convenio) ON DELETE CASCADE
);

CREATE TABLE cob_parcela (
    id_geral bigint NOT NULL,
    vl_parcela numeric(10,2) NULL,
    nm_cedente character varying(1000) NOT NULL,
    id_sistema_origem character varying(100) NOT NULL,
    nm_especie character varying(10) NULL,
    nr_documento character varying(15) NULL,
    nr_carteira character varying(10) NULL,
    dt_emissao date NOT NULL,
    dt_vcto date NOT NULL,
    vl_desconto numeric(10,2) NOT NULL,
    vl_outras_deducoes numeric(10,2) NOT NULL,
    vl_abatimento numeric(10,2) NOT NULL,
    vl_mora numeric(10,2) NOT NULL,
    vl_juros numeric(10,2) NOT NULL,
    vl_outros_acrescimos numeric(10,2) NOT NULL,
    instrucoes text NULL,
    observacoes text NULL,
    nr_nosso_numero character varying(50) NULL,
    nr_sequencial_remessa integer NULL,
    cd_convenio integer NULL,
    CONSTRAINT "PK_cob_parcela" PRIMARY KEY (id_geral),
    CONSTRAINT cob_parcela_fk FOREIGN KEY (cd_convenio) REFERENCES cob_convenio (cd_convenio) ON DELETE RESTRICT
);

CREATE TABLE caixa (
    cd_filial integer NOT NULL,
    cd_caixa integer NOT NULL,
    nm_caixa character varying(50) NOT NULL,
    fl_tipo character varying(1) NOT NULL,
    dt_atz date NULL DEFAULT (CURRENT_DATE),
    saldo_anterior numeric(18,4) NULL,
    agencia character varying(10) NULL,
    conta character varying(15) NULL,
    gerente character varying(40) NULL,
    endereco character varying(40) NULL,
    cidade character varying(30) NULL,
    estado character varying(2) NULL,
    fone character varying(15) NULL,
    fax character varying(15) NULL,
    http character varying(80) NULL,
    e_mail character varying(80) NULL,
    cd_usr integer NULL,
    cd_conta_contabil integer NULL,
    limite numeric(18,4) NULL,
    CONSTRAINT "PK_caixa" PRIMARY KEY (cd_filial, cd_caixa),
    CONSTRAINT fk_caixa_conta_contabil FOREIGN KEY (cd_conta_contabil) REFERENCES conta_contabil (cd_conta) ON DELETE RESTRICT
);

CREATE TABLE cxa_conta (
    cd_conta integer NOT NULL,
    nm_conta character varying(50) NOT NULL,
    cd_completo character varying(30) NOT NULL,
    grau_superior integer NOT NULL,
    tp_conta integer NOT NULL,
    dt_atz timestamp without time zone NOT NULL,
    cd_historico integer NULL,
    cd_filial integer NULL,
    fl_fixvar character varying(1) NOT NULL DEFAULT ('N'::character varying),
    cd_conta_contabil integer NULL,
    fl_ativo character(1) NULL,
    fl_franquia character varying(1) NULL,
    CONSTRAINT "PK_cxa_conta" PRIMARY KEY (cd_conta),
    CONSTRAINT fk_cxa_conta_conta_contabil FOREIGN KEY (cd_conta_contabil) REFERENCES conta_contabil (cd_conta) ON DELETE RESTRICT
);

CREATE TABLE fornecedor (
    cd_filial integer NOT NULL,
    cd_fornecedor integer NOT NULL,
    nm_fornecedor character varying(80) NOT NULL,
    nm_fantasia character varying(80) NULL,
    fl_fornecedor character varying(1) NULL,
    endereco character varying(80) NULL,
    bairro character varying(30) NULL,
    cd_cidade integer NOT NULL,
    cep character varying(10) NULL,
    fone character varying(20) NULL,
    fax character varying(20) NULL,
    pessoa_contato character varying(40) NULL,
    dt_cadastro date NULL DEFAULT (CURRENT_DATE),
    cnpj character varying(18) NULL,
    inscricao character varying(18) NULL,
    observacao_fornecedor text NULL,
    e_mail character varying(70) NULL,
    celular character varying(20) NULL,
    dt_atz date NULL DEFAULT (CURRENT_DATE),
    cd_cliente integer NULL,
    numero character varying(50) NULL,
    complemento character varying(20) NULL,
    cd_conta_contabil integer NULL,
    inscricao_suframa character varying(9) NULL,
    fl_transportador character varying(1) NULL,
    fl_simples character varying(1) NULL,
    fl_agricultor character(1) NULL,
    fl_ativo character(1) NULL,
    rntrc character varying(8) NULL,
    fl_seguradora character varying(1) NULL,
    fl_cont_ncont boolean NULL,
    CONSTRAINT "PK_fornecedor" PRIMARY KEY (cd_filial, cd_fornecedor),
    CONSTRAINT fk_fornecedor_conta_contabil FOREIGN KEY (cd_conta_contabil) REFERENCES conta_contabil (cd_conta) ON DELETE RESTRICT
);

CREATE TABLE tributacao_grupo_pis_cofins (
    cd_tributacao integer NOT NULL,
    nm_tributacao character varying(40) NULL,
    pis_compra_cst character varying(2) NULL,
    pis_compra_pc_aliq numeric(8,4) NULL,
    pis_venda_cst character varying(2) NULL,
    pis_venda_pc_aliq numeric(8,4) NULL,
    cofins_compra_cst character varying(2) NULL,
    cofins_compra_pc_aliq numeric(8,4) NULL,
    cofins_venda_cst character varying(2) NULL,
    cofins_venda_pc_aliq numeric(8,4) NULL,
    dt_atz date NULL,
    pis_dev_compra_cst character varying(2) NULL,
    pis_dev_compra_pc_aliq numeric(8,4) NULL,
    pis_dev_venda_cst character varying(2) NULL,
    pis_dev_venda_pc_aliq numeric(8,4) NULL,
    cofins_dev_compra_cst character varying(2) NULL,
    cofins_dev_compra_pc_aliq numeric(8,4) NULL,
    cofins_dev_venda_cst character varying(2) NULL,
    cofins_dev_venda_pc_aliq numeric(8,4) NULL,
    CONSTRAINT "PK_tributacao_grupo_pis_cofins" PRIMARY KEY (cd_tributacao),
    CONSTRAINT fk_trib_compra_cst FOREIGN KEY (cofins_compra_cst) REFERENCES cst_pis_cofins (cd_cst_pis_cofins) ON DELETE RESTRICT,
    CONSTRAINT fk_trib_venda_cst FOREIGN KEY (cofins_venda_cst) REFERENCES cst_pis_cofins (cd_cst_pis_cofins) ON DELETE RESTRICT,
    CONSTRAINT fk_trib_pis_compra_cst FOREIGN KEY (pis_compra_cst) REFERENCES cst_pis_cofins (cd_cst_pis_cofins) ON DELETE RESTRICT,
    CONSTRAINT fk_trib_cofins_venda_cst FOREIGN KEY (pis_venda_cst) REFERENCES cst_pis_cofins (cd_cst_pis_cofins) ON DELETE RESTRICT
);

CREATE TABLE cliente_resumo_financeiro_log (
    cd_filial integer NOT NULL,
    dt_atz timestamp without time zone NOT NULL,
    fl_status character(1) NOT NULL,
    CONSTRAINT "PK_cliente_resumo_financeiro_log" PRIMARY KEY (cd_filial),
    CONSTRAINT fk_cliente_resumo_log_filial FOREIGN KEY (cd_filial) REFERENCES filial_bd (cd_filial) ON DELETE CASCADE
);

CREATE TABLE produto_fornecedor (
    cd_filial integer NOT NULL,
    cd_fornecedor integer NOT NULL,
    cd_produto character varying(15) NOT NULL,
    cd_prod_forn character varying(61) NOT NULL,
    dt_atz date NULL,
    id_unimportacao integer NULL,
    id_produto_fornecedor integer NOT NULL,
    CONSTRAINT "PK_produto_fornecedor" PRIMARY KEY (id_produto_fornecedor),
    CONSTRAINT fk_proforn_fornun FOREIGN KEY (id_unimportacao) REFERENCES fornecedor_unmedida (id_geral) ON DELETE RESTRICT
);

CREATE TABLE help_atz_alteracao (
    id_geral integer NOT NULL,
    id_help_atz integer NOT NULL,
    titulo text NOT NULL,
    descricao text NOT NULL,
    id_imagem integer NULL,
    CONSTRAINT "PK_help_atz_alteracao" PRIMARY KEY (id_geral),
    CONSTRAINT fk_help_atz_alteracao_help_atz FOREIGN KEY (id_help_atz) REFERENCES help_atz (id_geral) ON DELETE RESTRICT
);

CREATE TABLE doc_nao_fiscal_c (
    id_geral bigint NOT NULL,
    cd_ecf integer NOT NULL,
    fl_mf_adicional character varying(1) NOT NULL DEFAULT ('N'::character varying),
    coo integer NULL,
    nr_doc integer NULL,
    tipo_doc character varying(2) NOT NULL,
    dt_emissao date NOT NULL,
    hr_emissao time without time zone NULL,
    gnf integer NULL,
    hash_doc_nao_fiscal_c_r6 character varying(70) NULL,
    hash_doc_nao_fiscal_c_r7 character varying(70) NULL,
    nr_dcto_nfsc integer NULL,
    CONSTRAINT "PK_doc_nao_fiscal_c" PRIMARY KEY (id_geral),
    CONSTRAINT fk_doc_nao_fiscal_c_impfiscal FOREIGN KEY (cd_ecf) REFERENCES impfiscal (cd_impfiscal) ON DELETE CASCADE
);

CREATE TABLE impfiscal_aliquota (
    cd_impfiscal integer NOT NULL,
    pc_imposto double precision NOT NULL,
    fl_imposto character varying(1) NOT NULL,
    nr_ordem_ecf integer NULL,
    CONSTRAINT "PK_impfiscal_aliquota" PRIMARY KEY (cd_impfiscal, pc_imposto, fl_imposto),
    CONSTRAINT fk_impfiscal_aliquota_impfiscal FOREIGN KEY (cd_impfiscal) REFERENCES impfiscal (cd_impfiscal) ON DELETE CASCADE
);

CREATE TABLE pafecf_e3 (
    id_geral integer NOT NULL,
    cd_impfiscal integer NOT NULL,
    data date NOT NULL,
    hora time without time zone NOT NULL,
    hash_e3 character varying(70) NULL,
    CONSTRAINT "PK_pafecf_e3" PRIMARY KEY (id_geral),
    CONSTRAINT fk_pafecf_e3 FOREIGN KEY (cd_impfiscal) REFERENCES impfiscal (cd_impfiscal) ON DELETE RESTRICT
);

CREATE TABLE reducao_z (
    cd_impfiscal integer NOT NULL,
    dt_reducao date NOT NULL,
    contador_z integer NOT NULL,
    vl_substituicao numeric(13,2) NULL,
    vl_isento numeric(13,2) NULL,
    vl_cancelamento numeric(13,2) NULL,
    vl_nao_incidente numeric(13,2) NULL,
    vl_desconto numeric(13,2) NULL,
    vl_gt numeric(13,2) NULL,
    vl_bruto numeric(13,2) NULL,
    cro integer NOT NULL,
    nr_cupom_inicial integer NOT NULL,
    nr_cupom_final integer NOT NULL,
    coo integer NULL,
    hr_emissao time without time zone NULL,
    dt_emissao date NULL,
    fl_incidencia_desc_iss character varying(1) NULL,
    icm_vl_cancelamento numeric(13,2) NULL,
    icm_vl_desconto numeric(13,2) NULL,
    icm_vl_acrescimo numeric(13,2) NULL,
    iss_vl_cancelamento numeric(13,2) NULL,
    iss_vl_desconto numeric(13,2) NULL,
    iss_vl_acrescimo numeric(13,2) NULL,
    vl_opnf numeric(13,2) NULL,
    mf_adicional character varying(1) NULL,
    vl_acrescimo numeric(13,2) NULL,
    hash_reducao_z_r2 character varying(70) NULL,
    hash_reducao_z_r3 character varying(70) NULL,
    fl_reducao_enviada character varying(1) NULL,
    fl_estoque_enviado character varying(1) NULL,
    cam_arq_reducao character varying(999) NULL,
    cam_arq_estoque character varying(999) NULL,
    CONSTRAINT "PK_reducao_z" PRIMARY KEY (cd_impfiscal, dt_reducao),
    CONSTRAINT fk_rez FOREIGN KEY (cd_impfiscal) REFERENCES impfiscal (cd_impfiscal) ON DELETE CASCADE
);

CREATE TABLE cst (
    cd_cst character varying(4) NOT NULL,
    nm_cst character varying(100) NOT NULL,
    fl_diferenca_base_total character varying(1) NULL,
    fl_icm character varying(1) NULL,
    fl_reducao character varying(1) NULL,
    fl_icm_subst character varying(1) NULL,
    cd_mensagem integer NULL,
    fl_simples character varying(1) NULL,
    hash_cst_d3 character varying(70) NULL,
    hash_cst_p2 character varying(70) NULL,
    fl_calc_partilha character varying(1) NULL,
    fl_permite_credito character varying(1) NULL,
    CONSTRAINT "PK_cst" PRIMARY KEY (cd_cst),
    CONSTRAINT fk_cst_mensagem FOREIGN KEY (cd_mensagem) REFERENCES mensagem_nota (cd_mensagem) ON DELETE RESTRICT
);

CREATE TABLE msggrupo (
    cd_gruprod integer NOT NULL,
    uf_origem character varying(2) NOT NULL,
    uf_destino character varying(2) NOT NULL,
    dt_atz date NULL DEFAULT (CURRENT_DATE),
    cd_mensagem integer NULL,
    CONSTRAINT "PK_msggrupo" PRIMARY KEY (cd_gruprod, uf_origem, uf_destino),
    CONSTRAINT gruprod_msggrupo_fk FOREIGN KEY (cd_gruprod) REFERENCES gruprod (cd_gruprod) ON DELETE RESTRICT,
    CONSTRAINT fk_msggrupo_cd_mensagem FOREIGN KEY (cd_mensagem) REFERENCES mensagem_nota (cd_mensagem) ON DELETE RESTRICT
);

CREATE TABLE veiculo (
    cd_filial integer NOT NULL,
    cd_veiculo integer NOT NULL,
    cd_montadora integer NOT NULL,
    nm_veiculo character varying(70) NOT NULL,
    dt_atz date NULL DEFAULT (CURRENT_DATE),
    CONSTRAINT "PK_veiculo" PRIMARY KEY (cd_filial, cd_veiculo),
    CONSTRAINT fk_veimontadora FOREIGN KEY (cd_filial, cd_montadora) REFERENCES montadora (cd_filial, cd_montadora) ON DELETE RESTRICT
);

CREATE TABLE nf_contabil_cfop (
    id_geral integer NOT NULL,
    id_nf_contabil_c integer NOT NULL,
    cfop character varying(10) NOT NULL,
    imposto_aliq numeric(14,2) NOT NULL,
    imposto_tipo character varying(1) NOT NULL,
    imposto_vl_base numeric(14,2) NULL,
    imposto_vl numeric(14,2) NULL,
    icms_st_vl_base numeric(14,2) NULL,
    icms_st_vl numeric(14,2) NULL,
    vl_isento numeric(14,2) NULL,
    vl_outros numeric(14,2) NULL,
    vl_total numeric(14,2) NULL,
    cst character varying(4) NULL,
    imposto_vl_red_base numeric(14,2) NULL,
    CONSTRAINT "PK_nf_contabil_cfop" PRIMARY KEY (id_geral),
    CONSTRAINT fk_nf_contabil_cfop_nf_cont_c FOREIGN KEY (id_nf_contabil_c) REFERENCES nf_contabil_c (id_geral) ON DELETE CASCADE
);

CREATE TABLE nf_contabil_i (
    id_geral integer NOT NULL,
    id_nf_contabil_c integer NOT NULL,
    nr_sequencia integer NOT NULL,
    cd_item character varying(15) NOT NULL,
    qt_item double precision NULL,
    vl_bruto numeric(18,8) NULL,
    vl_desconto numeric(14,2) NULL,
    vl_unitario numeric(18,8) NULL,
    vl_total numeric(18,4) NULL,
    cfop character varying(10) NULL,
    cst character varying(4) NULL,
    pc_reducao numeric(6,2) NULL,
    icms_normal_aliq numeric(6,2) NULL,
    icms_normal_vl_base numeric(14,2) NULL,
    icms_normal_vl numeric(14,2) NULL,
    icms_proprio_aliq numeric(6,2) NULL,
    icms_proprio_vl_base numeric(14,2) NULL,
    icms_proprio_vl numeric(14,2) NULL,
    icms_st_mva numeric(6,2) NULL,
    icms_st_vl_base numeric(14,2) NULL,
    icms_st_vl numeric(14,2) NULL,
    iss_aliq numeric(6,2) NULL,
    iss_vl_base numeric(14,2) NULL,
    iss_vl numeric(14,2) NULL,
    ipi_aliq numeric(6,2) NULL,
    ipi_vl_base numeric(14,2) NULL,
    ipi_vl numeric(14,2) NULL,
    pis_aliq numeric(6,2) NULL,
    pis_vl_base numeric(14,2) NULL,
    pis_vl numeric(14,2) NULL,
    cofins_aliq numeric(6,2) NULL,
    cofins_vl_base numeric(14,2) NULL,
    cofins_vl numeric(14,2) NULL,
    vl_outros numeric(14,2) NULL,
    vl_isento numeric(14,2) NULL,
    vl_desconto_rateado numeric(14,2) NULL,
    vl_acrescimo_rateado numeric(14,2) NULL,
    vl_frete_rateado numeric(14,2) NULL,
    vl_seguro_rateado numeric(14,2) NULL,
    vl_contabil numeric(14,2) NULL,
    fl_cancelado character varying(1) NULL,
    un_medida character varying(6) NULL,
    fl_produto character varying(1) NULL,
    icms_normal_pc_red numeric(6,2) NULL,
    icms_proprio_pc_red numeric(6,2) NULL,
    icms_st_pc_red numeric(6,2) NULL,
    icms_st_aliq_destino numeric(6,2) NULL,
    un_compra_venda character varying(6) NULL,
    vl_unitario_compra_venda numeric(18,8) NULL,
    ipi_cst character varying(2) NULL,
    pis_cst character varying(2) NULL,
    cofins_cst character varying(2) NULL,
    vl_acrescimo numeric(14,2) NULL,
    icms_frete_vl numeric(14,2) NULL,
    icms_st_ant_vl_base numeric(14,2) NULL,
    icms_st_ant_vl numeric(14,2) NULL,
    fl_soma_total character varying(1) NULL,
    qt_compra_venda double precision NULL,
    pc_fcp numeric(4,4) NULL,
    vl_fcp numeric(13,2) NULL,
    vl_base_fcp numeric(13,2) NULL,
    vl_base_fcp_st numeric(13,2) NULL,
    pc_fcp_st numeric(4,4) NULL,
    vl_fcp_st numeric(13,2) NULL,
    vl_fcp_st_retido numeric(13,2) NULL,
    pc_fcp_st_retido numeric(4,4) NULL,
    vl_base_fcp_st_retido numeric(13,2) NULL,
    vl_base_fcp_uf_destino numeric(13,2) NULL,
    pc_fcp_uf_destino numeric(4,4) NULL,
    vl_fcp_uf_destino numeric(13,2) NULL,
    vl_base_uf_destino numeric(13,2) NULL,
    pc_icms_uf_destino numeric(4,4) NULL,
    pc_icms_interno numeric(2,2) NULL,
    pc_icms_interno_partilha numeric(4,4) NULL,
    vl_icms_uf_destino numeric(13,2) NULL,
    vl_icms_uf_remetente numeric(13,2) NULL,
    CONSTRAINT "PK_nf_contabil_i" PRIMARY KEY (id_geral),
    CONSTRAINT fk_nf_contabil_i_nf_contabil_c FOREIGN KEY (id_nf_contabil_c) REFERENCES nf_contabil_c (id_geral) ON DELETE CASCADE
);

CREATE TABLE nsu_produto_negativo (
    id_geral integer NOT NULL,
    id_nsu integer NOT NULL,
    cd_produto character varying(15) NOT NULL,
    qt_produto double precision NULL,
    CONSTRAINT "PK_nsu_produto_negativo" PRIMARY KEY (id_geral),
    CONSTRAINT fk_nsu_produto_nsu FOREIGN KEY (id_nsu) REFERENCES nsu (id_geral) ON DELETE RESTRICT
);

CREATE TABLE acesso_acao_perfil (
    cd_perfil_acesso integer NOT NULL,
    id_acesso_acao bigint NOT NULL,
    fl_inserir character varying(1) NOT NULL,
    fl_editar character varying(1) NOT NULL,
    fl_excluir character varying(1) NOT NULL,
    fl_acesso character varying(1) NOT NULL,
    CONSTRAINT "PK_acesso_acao_perfil" PRIMARY KEY (cd_perfil_acesso, id_acesso_acao),
    CONSTRAINT fk_acesso_acao_perfil_per FOREIGN KEY (cd_perfil_acesso) REFERENCES perfil_acesso (cd_perfil) ON DELETE CASCADE,
    CONSTRAINT fk_acesso_acao_perfil_aca FOREIGN KEY (id_acesso_acao) REFERENCES acesso_acao (id_geral) ON DELETE CASCADE
);

CREATE TABLE produto_class_fiscal_mva (
    id_geral integer NOT NULL,
    cd_class_fiscal character varying(5) NOT NULL,
    uf_origem character varying(2) NOT NULL,
    uf_destino character varying(2) NOT NULL,
    mva double precision NOT NULL,
    dt_atz date NULL,
    CONSTRAINT "PK_produto_class_fiscal_mva" PRIMARY KEY (id_geral),
    CONSTRAINT fk_produto_class_fiscal_mva_ncm FOREIGN KEY (cd_class_fiscal) REFERENCES produto_class_fiscal (cd_class_fiscal) ON DELETE CASCADE
);

CREATE TABLE protocolo_icms_class_fiscal (
    id_geral integer NOT NULL,
    id_protocolo integer NOT NULL,
    cd_class_fiscal character varying(5) NOT NULL,
    mva_especifica double precision NULL,
    CONSTRAINT "PK_protocolo_icms_class_fiscal" PRIMARY KEY (id_geral),
    CONSTRAINT fk_protocolo_icms_class_fiscal FOREIGN KEY (cd_class_fiscal) REFERENCES produto_class_fiscal (cd_class_fiscal) ON DELETE RESTRICT,
    CONSTRAINT fk_protocolo_icms_protocolo FOREIGN KEY (id_protocolo) REFERENCES protocolo_icms (id_geral) ON DELETE RESTRICT
);

CREATE TABLE cidade (
    cd_cidade integer NOT NULL,
    nm_cidade character varying(40) NOT NULL,
    uf character varying(3) NOT NULL,
    cd_regiao integer NULL,
    dt_atz date NULL DEFAULT (CURRENT_DATE),
    cd_filial integer NULL,
    cd_ibge integer NULL,
    cd_pais integer NULL,
    CONSTRAINT "PK_cidade" PRIMARY KEY (cd_cidade),
    CONSTRAINT cidade_cd_regiao_fkey FOREIGN KEY (cd_regiao) REFERENCES regiao (cd_regiao) ON DELETE RESTRICT
);

CREATE TABLE tabela_preco_produto (
    id_geral integer NOT NULL,
    cd_tabela_preco integer NOT NULL,
    cd_produto character varying(15) NOT NULL,
    preco_venda numeric(15,2) NOT NULL,
    preco_venda_min numeric(15,2) NOT NULL,
    preco_venda_flex_max numeric(15,2) NULL,
    preco_venda_flex_min numeric(15,2) NULL,
    pc_markup_min numeric(5,2) NULL,
    pc_markup numeric(5,2) NULL,
    fl_utiliza_markup character varying(1) NOT NULL,
    hash_tabela_preco_produto_p2 character varying(70) NULL,
    pc_markup_flex_min numeric(15,2) NULL,
    pc_markup_flex_max numeric(15,2) NULL,
    fl_utiliza_markup_flex character varying(1) NULL,
    dt_atz date NULL DEFAULT (CURRENT_DATE),
    CONSTRAINT "PK_tabela_preco_produto" PRIMARY KEY (id_geral),
    CONSTRAINT fk_tabela_preco_produto_tabela FOREIGN KEY (cd_tabela_preco) REFERENCES tabela_preco (cd_tabela_preco) ON DELETE RESTRICT
);

CREATE TABLE tributacao (
    id_geral integer NOT NULL,
    id_tributacao_grupo integer NOT NULL,
    uf_origem character varying(2) NOT NULL,
    uf_destino character varying(2) NOT NULL,
    dt_atz date NULL,
    CONSTRAINT "PK_tributacao" PRIMARY KEY (id_geral),
    CONSTRAINT fk_tributacao_tributacao_grupo FOREIGN KEY (id_tributacao_grupo) REFERENCES tributacao_grupo (id_tributacao_grupo) ON DELETE CASCADE
);

CREATE TABLE pedido_i (
    nr_pedido integer NOT NULL,
    nr_sequencia integer NOT NULL,
    cd_produto character varying(15) NOT NULL,
    qt_produto double precision NOT NULL,
    vl_unitario numeric(18,4) NULL,
    dt_atz date NOT NULL DEFAULT (CURRENT_DATE),
    un_medida character varying(6) NULL,
    qt_compra double precision NULL,
    un_compra character varying(6) NULL,
    fator_conversao double precision NULL,
    nm_produto character varying(80) NULL,
    cd_produto_fornecedor character varying(25) NULL,
    CONSTRAINT "PK_pedido_i" PRIMARY KEY (nr_pedido, nr_sequencia),
    CONSTRAINT fk_pedido FOREIGN KEY (nr_pedido) REFERENCES pedido_c (nr_pedido) ON DELETE CASCADE,
    CONSTRAINT fk_pedido_i_un_medida FOREIGN KEY (un_medida) REFERENCES un_medida (un_medida) ON DELETE RESTRICT
);

CREATE TABLE acesso_acao_usuario (
    cd_usuario integer NOT NULL,
    id_acesso_acao bigint NOT NULL,
    fl_inserir character varying(1) NOT NULL,
    fl_editar character varying(1) NOT NULL,
    fl_excluir character varying(1) NOT NULL,
    fl_acesso character varying(1) NOT NULL,
    CONSTRAINT "PK_acesso_acao_usuario" PRIMARY KEY (cd_usuario, id_acesso_acao),
    CONSTRAINT fk_acesso_acao_usuario_u FOREIGN KEY (cd_usuario) REFERENCES usuario (cd_usuario) ON DELETE CASCADE,
    CONSTRAINT fk_acesso_acao_usuario_a FOREIGN KEY (id_acesso_acao) REFERENCES acesso_acao (id_geral) ON DELETE CASCADE
);

CREATE TABLE usuario_perfil (
    cd_usuario integer NOT NULL,
    cd_perfil integer NOT NULL,
    CONSTRAINT "PK_usuario_perfil" PRIMARY KEY (cd_usuario, cd_perfil),
    CONSTRAINT fk_usuario_perfil_perfil FOREIGN KEY (cd_perfil) REFERENCES perfil_acesso (cd_perfil) ON DELETE CASCADE,
    CONSTRAINT fk_usuario_perfil_usuario FOREIGN KEY (cd_usuario) REFERENCES usuario (cd_usuario) ON DELETE CASCADE
);

CREATE TABLE acesso_acao_rel_filtro (
    id bigint NOT NULL,
    id_acao bigint NOT NULL,
    nm_filtro character varying(40) NOT NULL,
    nm_parametro_sql character varying(40) NULL,
    nm_campo character varying(40) NULL,
    comentario character varying(40) NULL,
    rotulo_filtro character varying(40) NULL,
    cd_consulta integer NULL,
    tipo_dado character varying(40) NULL,
    nr_ordem integer NOT NULL,
    valor_padrao character varying(40) NULL,
    multivalor text NULL,
    nm_campo_retorno character varying(40) NULL,
    tipo_dado_parametro character varying(40) NULL,
    fl_selecao_multipla character varying(1) NULL,
    CONSTRAINT "PK_acesso_acao_rel_filtro" PRIMARY KEY (id),
    CONSTRAINT acesso_acao_rel_filtro_fk FOREIGN KEY (id_acao) REFERENCES acesso_acao_relatorio (id_acao) ON DELETE CASCADE
);

CREATE TABLE consulta_campo (
    id_geral integer NOT NULL,
    id_consulta integer NOT NULL,
    nm_campo character varying(30) NOT NULL,
    nm_titulo character varying(100) NULL,
    nr_posicao integer NULL,
    tamanho_campo integer NULL,
    tipo_campo character varying(20) NULL,
    CONSTRAINT "PK_consulta_campo" PRIMARY KEY (id_geral),
    CONSTRAINT fk_id_consulta FOREIGN KEY (id_consulta) REFERENCES consulta (id_consulta) ON DELETE CASCADE
);

CREATE TABLE cob_bordero_parcela (
    id_parcela bigint NOT NULL,
    cd_bordero integer NOT NULL,
    CONSTRAINT "PK_cob_bordero_parcela" PRIMARY KEY (id_parcela, cd_bordero),
    CONSTRAINT fk_cob_bordero_parcela FOREIGN KEY (cd_bordero) REFERENCES cob_bordero (cd_bordero) ON DELETE RESTRICT,
    CONSTRAINT fk_cob_bordero_parcela_bor FOREIGN KEY (id_parcela) REFERENCES cob_parcela (id_geral) ON DELETE RESTRICT
);

CREATE TABLE administradora (
    cd_administradora integer NOT NULL,
    nm_administradora character varying(80) NOT NULL,
    dias_pagamento_adm integer NULL,
    dt_atz date NULL DEFAULT (CURRENT_DATE),
    dias_pagamento_loja integer NULL,
    conta_caixa integer NULL,
    cd_caixa integer NULL,
    pc_cobranca_debito numeric(18,4) NULL,
    pc_cobranca_adm numeric(18,4) NULL,
    cd_filial integer NULL,
    cd_cidade integer NULL,
    cnpj character varying(18) NULL,
    inscricao character varying(18) NULL,
    endereco character varying(80) NULL,
    numero character varying(50) NULL,
    complemento character varying(20) NULL,
    bairro character varying(30) NULL,
    id_bandeira integer NULL,
    CONSTRAINT "PK_administradora" PRIMARY KEY (cd_administradora),
    CONSTRAINT fk_administradora_conta_caixa FOREIGN KEY (conta_caixa) REFERENCES cxa_conta (cd_conta) ON DELETE CASCADE,
    CONSTRAINT fk_administradora_bandeira FOREIGN KEY (id_bandeira) REFERENCES administradora_bandeira (id_geral) ON DELETE RESTRICT
);

CREATE TABLE crptitulo (
    cd_filial integer NOT NULL,
    cd_tipo_conta integer NOT NULL,
    cd_clifor integer NOT NULL,
    nr_titulo character varying(15) NOT NULL,
    parcela integer NOT NULL,
    dt_emissao date NOT NULL DEFAULT (CURRENT_DATE),
    dt_inclusao date NOT NULL DEFAULT (CURRENT_DATE),
    dt_vcto_ori date NOT NULL DEFAULT (CURRENT_DATE),
    dt_vcto date NOT NULL DEFAULT (CURRENT_DATE),
    dt_ult_pgto date NULL,
    cd_banco_ori integer NOT NULL,
    cd_banco integer NOT NULL,
    cd_tipocobr_ori integer NOT NULL,
    cd_tipocobr integer NOT NULL,
    cd_vendedor integer NOT NULL,
    fl_prev_realizado character varying(1) NULL,
    vl_comissao numeric(18,4) NULL,
    vl_nominal numeric(18,4) NULL,
    vl_juros numeric(18,4) NULL,
    vl_baixas_nominal numeric(18,4) NULL,
    vl_descontos numeric(18,4) NULL,
    vl_saldo numeric(18,4) NULL,
    cd_caixa integer NOT NULL,
    dt_atz date NULL DEFAULT (CURRENT_DATE),
    nr_nf_ecf bigint NULL,
    prazo_parcela integer NOT NULL,
    pc_parcela numeric(5,2) NULL,
    cd_conta integer NULL,
    vl_acrescimo numeric(18,4) NULL,
    fl_reparcelado character varying(1) NULL,
    nr_documento integer NULL,
    obs text NULL,
    nr_sequencial integer NULL,
    pc_parcela_total double precision NULL,
    motivo_alteracao character varying(120) NULL,
    nr_titulo_reparcelado character varying(15) NULL,
    nr_se character varying(3) NULL,
    vl_multa numeric(18,4) NULL,
    fl_imprime_carne character varying(1) NULL,
    fl_imprime_comprovante character varying(1) NULL,
    cd_frente_caixa_carne integer NULL,
    vl_devolucoes numeric(9,2) NULL,
    motivo_alteracao_valor text NULL,
    cd_funcionario integer NULL,
    CONSTRAINT "PK_crptitulo" PRIMARY KEY (cd_filial, cd_tipo_conta, cd_clifor, nr_titulo, parcela),
    CONSTRAINT fk_crptitulo_cxa_conta FOREIGN KEY (cd_conta) REFERENCES cxa_conta (cd_conta) ON DELETE RESTRICT
);

CREATE TABLE filial (
    cd_filial integer NOT NULL,
    nm_filial character varying(50) NOT NULL,
    endereco character varying(50) NULL,
    bairro character varying(30) NULL,
    cidade character varying(50) NOT NULL,
    uf character varying(2) NOT NULL,
    cep character varying(10) NULL,
    fone character varying(16) NULL,
    fax character varying(16) NULL,
    cgc character varying(18) NULL,
    ie character varying(18) NULL,
    nr_ult_nfs integer NULL,
    fl_informar_nr_nf boolean NULL,
    fl_valor_seguro boolean NULL,
    fl_valor_frete boolean NULL,
    fl_valor_desconto boolean NULL,
    fl_imprimir_nfs boolean NULL,
    fl_controlar_estoq boolean NULL,
    fl_imprime_nf boolean NULL,
    pc_pis numeric(15,2) NULL,
    pc_cofins numeric(15,2) NULL,
    email character varying(75) NULL,
    fl_calcula_comissao boolean NULL,
    fl_controle_credito boolean NULL,
    cd_conta integer NULL,
    cd_cliente_consumidor integer NULL,
    cd_filial_fornecedor integer NULL,
    fl_cons_prod character varying(1) NULL,
    im character varying(10) NULL,
    empresa_simples character varying(1) NULL,
    custo_em_orcamento character varying(1) NULL,
    taxa_juros numeric(10,3) NULL,
    dt_atz timestamp without time zone NULL,
    dias_vcto integer NULL DEFAULT (0),
    fl_controle_contas character varying(1) NULL DEFAULT ('N'::character varying),
    tp_comissao character varying(1) NOT NULL DEFAULT ('I'::character varying),
    fl_comissao_vendabaixa character varying(1) NULL,
    modulo integer NULL,
    cd_usr_padrao integer NULL,
    cd_cliente_empresa integer NULL,
    fl_orc_imp_vend_cliente character varying(1) NULL,
    fl_altera_vend_orc character varying(1) NULL,
    fl_cliente_cnpj_dupl character varying(1) NULL,
    fl_item_dupl_nfs character varying(1) NULL,
    fl_item_dupl_nfe character varying(1) NULL,
    fl_orc_prod_sem_vendedor character varying(1) NULL,
    fl_orc_exibir_ult_venda character varying(1) NULL,
    vl_id_geral integer NULL,
    fl_deducao_piscofins character varying(1) NULL,
    fl_orc_serv_sem_vendedor character varying(1) NULL,
    aliq_icms_simples numeric(5,2) NULL,
    cd_cidade integer NULL,
    numero integer NULL,
    complemento character varying(20) NULL,
    tp_ambiente_nfe integer NULL,
    nota_eletronica character varying(1) NULL,
    nr_lote_nfe integer NULL,
    fl_venda_vista_cliente_bloq character varying(1) NULL,
    fl_venda_prazo_cliente_bloq character varying(1) NULL,
    fl_deducao_icms boolean NULL,
    cd_fornecedor_imposto_st integer NULL,
    dt_ultima_integracao date NULL,
    fl_imprimir_orc_ecf boolean NULL,
    fl_utiliza_conta_contabil boolean NULL,
    tp_sistema integer NULL,
    fl_industria boolean NULL,
    ind_perfil_sped character varying(1) NULL,
    suframa character varying(9) NULL,
    nm_fantasia character varying(50) NULL,
    ind_apur_ipi integer NULL,
    nr_serie_producao character varying(3) NULL,
    cd_op_entrada_producao integer NULL,
    cd_op_saida_producao integer NULL,
    fl_fitossanitario_sira character varying(1) NULL,
    fl_utiliza_paf boolean NULL,
    fl_armaz_interfoc character(1) NULL,
    fl_contribuinte character varying(1) NULL,
    cd_mensagem_cupom integer NULL,
    cd_mensagem_dav integer NULL,
    cd_mensagem_pre_venda integer NULL,
    fl_custo_frete_st character varying(1) NULL,
    fl_orc_exibir_vl_compra character varying(1) NULL,
    cd_transportadora integer NULL,
    cd_mensagem_icm_ret_ant integer NULL,
    tp_status_nfe integer NULL,
    fl_simples_excesso_receita character varying(1) NULL,
    cd_crt integer NULL,
    cd_mensagem_simples integer NULL,
    cnae_fiscal character varying(7) NULL,
    nfe_conjugada character varying(1) NULL,
    cd_mensagem_tot_trib integer NULL,
    fl_utiliza_integracao character(1) NULL,
    vl_multa_contas numeric(6,3) NULL,
    cd_mensagem_icm_st_nota_dev integer NULL,
    cd_ctbl_exporta smallint NULL,
    fl_apenas_vendedor_doc character(1) NOT NULL DEFAULT ('N'::bpchar),
    fl_real_presumido character(1) NULL,
    dt_atz_estoque date NULL,
    hr_atz_estoque time without time zone NULL,
    cd_impfiscal_atz_estoque integer NULL,
    hash_filial_e1 character varying(70) NULL,
    hash_filial_r1 character varying(70) NULL,
    fl_rede_uniagro character varying(1) NULL,
    fl_venda_outros_uf character varying(1) NULL,
    fl_flex character varying(1) NULL,
    fl_pos_venda character varying(1) NULL,
    tp_cli_padrao_venda character varying(1) NULL,
    fl_conhe_frete_st character varying(1) NULL,
    fl_st_nota_esta character varying(1) NULL,
    cd_tabela_preco_padrao integer NULL,
    cd_mensagem_ipi_nota_dev integer NULL,
    fl_nota_eletronica_municipal character(1) NULL,
    tp_ambiente_nfe_municipal character(1) NULL,
    fl_contigencia_municipal character(1) NULL,
    fl_imprime_ordem_entrega boolean NULL,
    cd_mensagem_desconto_ro integer NULL,
    cod_versao_efd character varying(3) NULL,
    fl_calcula_prazo_data_saida boolean NULL,
    fl_adiciona_st_custo_produto boolean NULL,
    fl_imprime_carne_ecf boolean NULL,
    dir_arq_carne_ecf character varying(150) NULL,
    dir_arq_comprovante_ecf character varying(150) NULL,
    fl_imp_vendedor_cliente_nfsc character varying(1) NULL,
    fl_multa_porcentagem character varying(1) NULL,
    fuso_horario character varying(6) NULL,
    fl_bloq_cancelamento_ecf character varying(1) NULL,
    fl_calcula_diferenca_icms character varying(1) NULL,
    fl_filial_tit_cartao character varying(1) NULL,
    fl_importar_vendedor_primeiro character(1) NULL,
    fl_importar_vendedor_segundo character(1) NULL,
    fl_importar_vendedor_terceiro character(1) NULL,
    bloquear_edicao_juros_multa character(1) NULL,
    database_auditor character(1) NULL,
    fl_utiliza_nfce character varying(1) NULL,
    cf_informa_documento boolean NULL,
    tp_icms_entrada_frete character varying(1) NULL,
    tp_piscofins_entrada_frete character varying(1) NULL,
    tp_icms_saida_frete character varying(1) NULL,
    tp_piscofins_saida_frete character varying(1) NULL,
    cd_prodfrete_venda character varying(15) NULL,
    cd_prodfrete_vendas_c character varying(15) NULL,
    cd_prodfrete_saida character varying(15) NULL,
    cd_prodfrete_saidas_c character varying(15) NULL,
    cd_prodfrete_compra character varying(15) NULL,
    cd_prodfrete_compras_c character varying(15) NULL,
    cd_prodfrete_trans character varying(15) NULL,
    cd_prodfrete_entrada character varying(15) NULL,
    cd_prodfrete_entradas_c character varying(15) NULL,
    cst_frete_icmscred character varying(4) NULL,
    cst_frete_icms_ncred character varying(4) NULL,
    fl_manifesto_eletronico character varying(1) NULL,
    fl_senha_supervisor_dav character varying(1) NULL,
    fl_cod_clifor_danfe character varying(1) NULL,
    fl_seguradora character varying(1) NULL,
    vl_min_inss numeric(10,3) NULL,
    vl_min_csll numeric(10,3) NULL,
    dias_juro integer NULL,
    dias_multa integer NULL,
    cd_mensagem_reducao integer NULL,
    cd_mensagem_difal integer NULL,
    fl_oculista character varying(1) NULL,
    fl_envia_blocox character varying(1) NULL,
    fl_alterar_markup_cadastro boolean NULL,
    fl_desconto_incondicionado boolean NULL,
    calculoconveniost boolean NULL,
    cd_mensagem_fcp integer NULL,
    CONSTRAINT "PK_filial" PRIMARY KEY (cd_filial),
    CONSTRAINT fk_filial_cxa_conta FOREIGN KEY (cd_conta) REFERENCES cxa_conta (cd_conta) ON DELETE RESTRICT,
    CONSTRAINT fk_filial_msg_cupom FOREIGN KEY (cd_mensagem_cupom) REFERENCES mensagem_nota (cd_mensagem) ON DELETE RESTRICT,
    CONSTRAINT fk_filial_msg_dav FOREIGN KEY (cd_mensagem_dav) REFERENCES mensagem_nota (cd_mensagem) ON DELETE RESTRICT,
    CONSTRAINT fk_filial_msg_icm_st FOREIGN KEY (cd_mensagem_icm_st_nota_dev) REFERENCES mensagem_nota (cd_mensagem) ON DELETE RESTRICT,
    CONSTRAINT fk_filial_msg_pre_venda FOREIGN KEY (cd_mensagem_pre_venda) REFERENCES mensagem_nota (cd_mensagem) ON DELETE RESTRICT,
    CONSTRAINT fk_filial_preco FOREIGN KEY (cd_tabela_preco_padrao) REFERENCES tabela_preco (cd_tabela_preco) ON DELETE RESTRICT
);

CREATE TABLE movimento_cxa (
    cd_filial integer NOT NULL,
    nr_lcto integer NOT NULL,
    cd_caixa integer NOT NULL,
    dt_mvto date NULL,
    cd_conta integer NULL,
    complemento character varying(1000) NULL,
    vl_entrada numeric(18,4) NULL,
    vl_saida numeric(18,4) NULL,
    cd_banco integer NULL,
    cd_agencia character varying(10) NULL,
    nr_cc character varying(15) NULL,
    cd_clifor integer NULL,
    nm_titular character varying(80) NULL,
    dt_bom_para date NULL,
    dt_atz date NULL DEFAULT (CURRENT_DATE),
    fl_origem character varying(1) NULL,
    cd_historico integer NULL,
    cd_funcionario integer NOT NULL,
    fl_cheque character varying(1) NOT NULL,
    nr_sequencial integer NOT NULL,
    fl_cancelado boolean NULL,
    nr_cheque character varying(15) NULL,
    dt_inclusao date NULL,
    dt_compensacao date NULL,
    motivo_devolucao character varying(80) NULL,
    destinatario character varying(80) NULL,
    dcto_origem character varying(25) NULL,
    fl_compensado character varying(1) NULL,
    fl_destino character varying(1) NULL,
    nr_documento integer NULL,
    nr_serie character varying(3) NULL,
    tp_cartao character varying(1) NULL,
    tp_integracao smallint NULL,
    hash_a2 character varying(70) NULL,
    hash_h2 character varying(70) NULL,
    CONSTRAINT "PK_movimento_cxa" PRIMARY KEY (cd_filial, cd_caixa, nr_lcto),
    CONSTRAINT fk_movimento_cxa_cxa_conta FOREIGN KEY (cd_conta) REFERENCES cxa_conta (cd_conta) ON DELETE RESTRICT,
    CONSTRAINT fk_movimento_cxa_caixa FOREIGN KEY (cd_filial, cd_caixa) REFERENCES caixa (cd_filial, cd_caixa) ON DELETE RESTRICT
);

CREATE TABLE nfec (
    cd_filial integer NOT NULL,
    nr_dcto bigint NOT NULL,
    cd_clifor integer NOT NULL,
    fl_impresso boolean NULL,
    serie_nf character varying(3) NOT NULL,
    cd_operacao integer NULL,
    dt_emissao date NOT NULL DEFAULT (CURRENT_DATE),
    dt_lancamento date NOT NULL DEFAULT (CURRENT_DATE),
    vl_acrescimos numeric(18,4) NULL,
    vl_descontos numeric(18,4) NULL,
    vl_mercadorias numeric(18,4) NULL,
    vl_servicos numeric(18,4) NULL,
    vl_total numeric(18,4) NULL,
    cd_condpgto integer NULL,
    vl_entrada numeric(18,4) NULL,
    vl_acres_financeiro numeric(18,4) NULL,
    vl_financiado numeric(18,4) NULL,
    peso_total double precision NULL,
    qt_pecas double precision NULL,
    obs text NULL,
    cd_natoper character varying(40) NOT NULL,
    fl_cont_ncont character varying(1) NULL,
    cd_transportadora integer NULL,
    uf_origem character varying(2) NOT NULL,
    uf_destino character varying(2) NOT NULL,
    peso_liquido double precision NULL,
    vl_frete numeric(18,4) NULL,
    vl_seguro numeric(18,4) NULL,
    vl_base_icm numeric(18,4) NULL,
    vl_icm numeric(18,4) NULL,
    vl_base_icm_subst numeric(18,4) NULL,
    vl_icm_subst numeric(18,4) NULL,
    vl_ipi numeric(18,4) NULL,
    vl_iss numeric(18,4) NULL,
    tp_frete character varying(1) NULL,
    qt_volumes double precision NULL,
    especie_volumes character varying(15) NULL,
    marca_volumes character varying(15) NULL,
    nr_volumes double precision NULL,
    cd_banco integer NOT NULL,
    cd_tipocobr integer NOT NULL,
    cd_conta integer NOT NULL,
    cd_funcionario integer NOT NULL,
    dt_atz date NULL DEFAULT (CURRENT_DATE),
    placa_transp character varying(8) NULL,
    uf_placa_transp character varying(2) NULL,
    vl_outros numeric(18,4) NULL,
    fl_cd_conta character varying(1) NULL,
    fl_ignorar_cxa_cta character varying(1) NOT NULL,
    fl_transferencia boolean NOT NULL,
    nr_pedido integer NULL,
    fl_controlar_estoque character varying(1) NULL,
    nsu character varying(10) NULL,
    nr_dcto_devolucao integer NULL,
    vl_base_pis numeric(18,4) NULL,
    vl_pis numeric(18,4) NULL,
    vl_base_cofins numeric(18,4) NULL,
    vl_cofins numeric(18,4) NULL,
    vl_base_ipi numeric(18,4) NULL,
    vl_base_iss numeric(18,4) NULL,
    vl_desconto_item numeric(18,4) NULL,
    vl_isento_itens numeric(18,4) NULL,
    vl_outros_itens numeric(18,4) NULL,
    nr_protocolo_nfe character varying(15) NULL,
    dt_processamento_nfe date NULL,
    status integer NULL,
    nr_lote_nfe character varying(15) NULL,
    nr_recibo_nfe character varying(15) NULL,
    nr_protocolo_canc_nfe character varying(15) NULL,
    chave_acesso_nfe character varying(44) NULL,
    obs2 text NULL,
    conhecimento_vl_frete numeric(18,4) NULL,
    conhecimento_vl_st numeric(18,4) NULL,
    conhecimento_vl_icm numeric(18,4) NULL,
    base_icm_proprio_st numeric(18,4) NULL,
    vl_icm_proprio_st numeric(18,4) NULL,
    vl_base_icm_subst_real numeric(18,4) NULL,
    vl_icm_subst_real numeric(18,4) NULL,
    fl_calcular_custo character varying(1) NULL,
    cd_modelo character varying(3) NULL,
    id_geral integer NOT NULL,
    conhecimento_base_icm numeric(18,4) NULL,
    conhecimento_base_st numeric(18,4) NULL,
    fl_consumo character varying(1) NULL,
    vl_icm_frete numeric(18,4) NULL,
    cfop_frete character varying(10) NULL,
    sub_serie character varying(3) NULL,
    nr_aidf character varying(20) NULL,
    fl_conhec_frete boolean NULL,
    vl_base_icm_subst_ant numeric(9,2) NULL,
    vl_icm_subst_ant numeric(9,2) NULL,
    hr_emissao time without time zone NULL,
    cupom_nr_pdv integer NULL,
    cupom_nr_coo integer NULL,
    fl_simples character varying(1) NULL,
    hr_processamento_nfe time without time zone NULL,
    dpec_id character varying(10) NULL,
    dpec_nr_registro character varying(14) NULL,
    dpec_dt_registro date NULL,
    dpec_hr_registro time without time zone NULL,
    cd_barras_adicional_nfe character varying(36) NULL,
    tp_emissao_nfe integer NULL,
    vl_icm_subst_dev numeric(18,4) NULL,
    vl_base_icm_subst_dev numeric(18,4) NULL,
    vl_base_ipi_dev numeric(18,4) NULL,
    vl_ipi_dev numeric(18,4) NULL,
    vl_fcp numeric(13,2) NULL,
    vl_fcp_st numeric(13,2) NULL,
    vl_fcp_st_retido numeric(13,2) NULL,
    vl_icms_uf_dest numeric(13,2) NULL,
    vl_icms_uf_remet numeric(13,2) NULL,
    vl_fcp_uf_dest numeric(13,2) NULL,
    CONSTRAINT "PK_nfec" PRIMARY KEY (id_geral),
    CONSTRAINT fk_nfec_cxa_conta FOREIGN KEY (cd_conta) REFERENCES cxa_conta (cd_conta) ON DELETE RESTRICT,
    CONSTRAINT fk_nfec_pedido FOREIGN KEY (nr_pedido) REFERENCES pedido_c (nr_pedido) ON DELETE RESTRICT
);

CREATE TABLE operacao_es (
    cd_operacao integer NOT NULL,
    nm_operacao character varying(40) NULL,
    fl_ent_sai character varying(1) NOT NULL,
    fl_calcular_custo boolean NULL,
    fl_calcular_ipi boolean NULL,
    fl_controlar_estoq boolean NULL,
    fl_calcular_comissao boolean NULL,
    fl_ignora_caixa_contas boolean NULL,
    fl_cd_conta character varying(1) NULL,
    fl_calcular_icms character varying(1) NULL,
    dt_atz date NULL DEFAULT (CURRENT_DATE),
    fl_tributar_frete boolean NOT NULL,
    fl_reducao_juridica boolean NOT NULL,
    fl_calcular_iss character varying(1) NOT NULL,
    fl_sugerir_preco character varying(1) NULL,
    cd_grupo_op character varying(2) NULL,
    fl_ativo character varying(1) NULL,
    cd_conta_movimento integer NULL,
    cd_modelo character varying(3) NOT NULL,
    cd_mensagem integer NULL,
    nat_operacao character varying(40) NOT NULL,
    id_tributacao_grupo integer NULL,
    fl_importacao character varying(1) NULL,
    finalidade character varying(1) NULL,
    cst_pis_dif character varying(5) NULL,
    cst_cofins_dif character varying(5) NULL,
    fl_credito_icms_st boolean NULL,
    fl_credito_ipi boolean NULL,
    cd_bc_cred_piscofins character varying(2) NULL,
    cd_tp_cred_piscofins character varying(3) NULL,
    id_tributacao_grupo_pis_cofins integer NULL,
    fl_credita_icm_proprio_st character varying(1) NULL,
    fl_inclui_ipi_base_pis character varying(1) NULL,
    fl_inclui_icms_st_base_pis character varying(1) NULL,
    ind_presencial character varying(1) NULL,
    fl_referenciar_nota character(1) NULL,
    fl_info_xml character(1) NULL,
    fl_cxa_franquia character varying(1) NULL,
    CONSTRAINT "PK_operacao_es" PRIMARY KEY (cd_operacao),
    CONSTRAINT fk_operacao_es_cd_bc_cred_pisco FOREIGN KEY (cd_bc_cred_piscofins) REFERENCES tab_437_sped_piscofins (cd_bc_credito) ON DELETE RESTRICT,
    CONSTRAINT fk_operacao_es_cxa_conta FOREIGN KEY (cd_conta_movimento) REFERENCES cxa_conta (cd_conta) ON DELETE RESTRICT,
    CONSTRAINT fk_operacao_es_grupo_op FOREIGN KEY (cd_grupo_op) REFERENCES grupo_operacao_es (cd_grupo) ON DELETE RESTRICT,
    CONSTRAINT fk_operacao_es_cd_mensagem FOREIGN KEY (cd_mensagem) REFERENCES mensagem_nota (cd_mensagem) ON DELETE RESTRICT,
    CONSTRAINT fk_operacao_es_cd_modelo FOREIGN KEY (cd_modelo) REFERENCES modelo_dcto (cd_modelo) ON DELETE RESTRICT,
    CONSTRAINT fk_operacao_es_cd_tp_cred_pisco FOREIGN KEY (cd_tp_cred_piscofins) REFERENCES tab_436_sped_piscofins (cd_tp_credito) ON DELETE RESTRICT,
    CONSTRAINT fk_operacao_es_id_trib_grupo FOREIGN KEY (id_tributacao_grupo) REFERENCES tributacao_grupo (id_tributacao_grupo) ON DELETE RESTRICT,
    CONSTRAINT fk_operacao_es_id_trib_pis_cofi FOREIGN KEY (id_tributacao_grupo_pis_cofins) REFERENCES tributacao_grupo_pis_cofins (cd_tributacao) ON DELETE RESTRICT
);

CREATE TABLE produto (
    cd_produto character varying(15) NOT NULL,
    nm_produto character varying(120) NOT NULL,
    fl_ativo boolean NULL,
    cd_gruprod integer NOT NULL,
    cd_marca integer NOT NULL,
    box character varying(10) NULL,
    un_medida character varying(6) NOT NULL,
    peso_liquido double precision NULL,
    cd_original character varying(200) NULL,
    qt_estoque_min double precision NULL,
    qt_estoque_max double precision NULL,
    pc_lucro_liquido numeric(18,4) NULL,
    meses_garantia integer NULL,
    meses_vida_util integer NULL,
    qt_venda_media_mes double precision NULL,
    qt_estoque_medio_mes double precision NULL,
    qt_compra_media_mes double precision NULL,
    giro_medio_em_dias double precision NULL,
    aliq_ipi numeric(9,2) NULL,
    obs text NULL,
    fl_original boolean NULL,
    fl_inf_complemento boolean NULL,
    fl_controlar_estoq boolean NULL,
    tipo character varying(10) NULL,
    cd_subgruprod integer NULL,
    pc_preco_venda numeric(18,4) NULL,
    aliq_iss numeric(9,2) NULL,
    fl_servico character varying(1) NULL,
    fl_composto character varying(1) NULL,
    local_estocagem character varying(10) NULL,
    qt_estoque double precision NULL,
    pc_comissao numeric(5,2) NULL,
    cd_aplicacao integer NULL,
    cd_construcao integer NULL,
    cd_modelo integer NULL,
    cd_medida integer NULL,
    dt_atz date NULL,
    fl_classfiscal character varying(5) NULL,
    cd_grupo_comissao integer NULL,
    garantia_km integer NULL,
    nm_reduzido character varying(60) NULL,
    fl_validade boolean NULL,
    qt_dias_validade integer NULL,
    dias_man_prev integer NULL,
    fl_contrato boolean NOT NULL,
    cd_fabricante character varying(200) NULL,
    fl_controla_serie boolean NULL,
    fl_composto_soma_itens character varying(1) NULL,
    cd_class_fiscal character varying(5) NULL,
    class_lista_servico character varying(10) NULL,
    fl_consumo boolean NULL,
    fl_pesavel boolean NULL,
    un_compra character varying(6) NOT NULL,
    un_armazenagem character varying(6) NOT NULL,
    tp_produto character varying(2) NULL,
    dt_cadastro date NULL,
    fl_fitossanitario_sira character varying(1) NULL,
    fl_controla_lote boolean NULL,
    id_tributacao_grupo integer NULL,
    cd_conta_contabil integer NULL,
    fl_fracionar character(1) NULL,
    cd_tributacao_iss character varying(1) NULL,
    fl_cesta_basica character varying(1) NULL,
    id_trib_grupo_piscofins integer NULL,
    qt_estoque_anterior double precision NULL,
    hash_produto_e2 character varying(70) NULL,
    hash_produto_p2 character varying(70) NULL,
    cd_cfop_regra integer NULL,
    cd_produto_anp character varying(9) NULL,
    cd_fci character varying(36) NULL,
    codigo_tributacao_municipio integer NULL,
    aliq_irrf numeric(9,2) NULL,
    aliq_csll numeric(9,2) NULL,
    fl_retem boolean NULL,
    aliq_inss numeric(9,2) NULL,
    cst_int character varying(3) NULL,
    cst_ext character varying(3) NULL,
    pc_subst_trib numeric(18,4) NULL,
    nm_comercial_fito character varying(60) NULL,
    tp_modalidade_fito integer NULL,
    metodo_fito integer NULL,
    epoca_fito character varying(20) NULL,
    intervalo_fito integer NULL,
    tp_intervalo_fito integer NULL,
    class_toxico_fito integer NULL,
    epi_fito text NULL,
    especificacoes_fito text NULL,
    precaucoes_fito text NULL,
    cd_produto_anvisa character varying(5) NULL,
    fl_escala_relevante character(1) NULL DEFAULT ('S'::bpchar),
    cnpj_fabricante character varying(20) NULL,
    nome_fabricante character varying(70) NULL,
    cod_ajur character varying(10) NULL,
    desc_ajur character varying(500) NULL,
    CONSTRAINT "PK_produto" PRIMARY KEY (cd_produto),
    CONSTRAINT fk_produto_cfop_regra FOREIGN KEY (cd_cfop_regra) REFERENCES cfop_regra (cd_cfop_regra) ON DELETE RESTRICT,
    CONSTRAINT fk_produto_class_fiscal FOREIGN KEY (cd_class_fiscal) REFERENCES produto_class_fiscal (cd_class_fiscal) ON DELETE RESTRICT,
    CONSTRAINT grupo_comissao_produto_fk FOREIGN KEY (cd_grupo_comissao) REFERENCES grupo_comissao (cd_grupo_comissao) ON DELETE RESTRICT,
    CONSTRAINT produto_cd_gruprod_fkey FOREIGN KEY (cd_gruprod) REFERENCES gruprod (cd_gruprod) ON DELETE RESTRICT,
    CONSTRAINT produto_cd_marca_fkey FOREIGN KEY (cd_marca) REFERENCES marca (cd_marca) ON DELETE RESTRICT,
    CONSTRAINT fk_subproduto FOREIGN KEY (cd_subgruprod) REFERENCES subgruprod (cd_subgruprod) ON DELETE RESTRICT,
    CONSTRAINT fk_produto_tribmuni FOREIGN KEY (codigo_tributacao_municipio) REFERENCES codigo_tributacao_municipio (cd_tributacao_municipio) ON DELETE RESTRICT,
    CONSTRAINT fk_produto_grupo_trib_piscofins FOREIGN KEY (id_trib_grupo_piscofins) REFERENCES tributacao_grupo_pis_cofins (cd_tributacao) ON DELETE RESTRICT,
    CONSTRAINT fk_produto_tributacao_grupo FOREIGN KEY (id_tributacao_grupo) REFERENCES tributacao_grupo (id_tributacao_grupo) ON DELETE RESTRICT,
    CONSTRAINT fk_produto_tp_produto FOREIGN KEY (tp_produto) REFERENCES produto_tipo (cd_tipo) ON DELETE RESTRICT,
    CONSTRAINT fk_produto_un_armazenagem FOREIGN KEY (un_armazenagem) REFERENCES un_medida (un_medida) ON DELETE RESTRICT,
    CONSTRAINT fk_produto_un_compra FOREIGN KEY (un_compra) REFERENCES un_medida (un_medida) ON DELETE RESTRICT,
    CONSTRAINT fk_produto_un_medida FOREIGN KEY (un_medida) REFERENCES un_medida (un_medida) ON DELETE RESTRICT
);

CREATE TABLE doc_nao_fiscal_i (
    id_geral bigint NOT NULL,
    id_doc_nao_fiscal bigint NOT NULL,
    nm_pagamento character varying(25) NOT NULL,
    vl_pago numeric(9,2) NULL,
    CONSTRAINT "PK_doc_nao_fiscal_i" PRIMARY KEY (id_geral),
    CONSTRAINT fk_doc_n_fiscal_i_doc_n_fisc_c FOREIGN KEY (id_doc_nao_fiscal) REFERENCES doc_nao_fiscal_c (id_geral) ON DELETE CASCADE
);

CREATE TABLE reducao_z_totalizador (
    cd_impfiscal integer NOT NULL,
    dt_reducao date NOT NULL,
    pc_imposto double precision NOT NULL,
    vl_vendido numeric(18,4) NOT NULL,
    tp_imposto character varying(1) NOT NULL,
    nr_ordem integer NULL,
    hash_reducao_z_totalizador_r3 character varying(70) NULL,
    CONSTRAINT "PK_reducao_z_totalizador" PRIMARY KEY (cd_impfiscal, dt_reducao, pc_imposto, tp_imposto),
    CONSTRAINT fk_rzt_rz FOREIGN KEY (cd_impfiscal, dt_reducao) REFERENCES reducao_z (cd_impfiscal, dt_reducao) ON DELETE CASCADE
);

CREATE TABLE veiculo_modelo_complemento (
    cd_filial integer NOT NULL,
    id_geral integer NOT NULL,
    cd_modelo integer NOT NULL,
    cd_complemento integer NOT NULL,
    dt_atz timestamp without time zone NULL,
    CONSTRAINT "PK_veiculo_modelo_complemento" PRIMARY KEY (cd_filial, id_geral),
    CONSTRAINT fk_veic_compl_mod_complemento FOREIGN KEY (cd_complemento) REFERENCES veiculo_complemento (cd_complemento) ON DELETE RESTRICT,
    CONSTRAINT fk_veic_compl_mod_veiculo FOREIGN KEY (cd_filial, cd_modelo) REFERENCES veiculo (cd_filial, cd_veiculo) ON DELETE RESTRICT
);

CREATE TABLE veiculo_modelo_injecao (
    cd_filial integer NOT NULL,
    id_geral integer NOT NULL,
    cd_modelo integer NOT NULL,
    cd_injecao integer NOT NULL,
    dt_atz timestamp without time zone NULL,
    CONSTRAINT "PK_veiculo_modelo_injecao" PRIMARY KEY (cd_filial, id_geral),
    CONSTRAINT fk_veic_inj_mod_injecao FOREIGN KEY (cd_injecao) REFERENCES veiculo_injecao (cd_injecao) ON DELETE RESTRICT,
    CONSTRAINT fk_veic_inj_mod_veiculo FOREIGN KEY (cd_filial, cd_modelo) REFERENCES veiculo (cd_filial, cd_veiculo) ON DELETE RESTRICT
);

CREATE TABLE veiculo_modelo_motor (
    cd_filial integer NOT NULL,
    id_geral integer NOT NULL,
    cd_modelo integer NOT NULL,
    cd_motor integer NOT NULL,
    dt_atz timestamp without time zone NULL,
    CONSTRAINT "PK_veiculo_modelo_motor" PRIMARY KEY (cd_filial, id_geral),
    CONSTRAINT fk_veic_mot_mod_injecao FOREIGN KEY (cd_motor) REFERENCES veiculo_motor (cd_motor) ON DELETE RESTRICT,
    CONSTRAINT fk_veic_mot_mod_veiculo FOREIGN KEY (cd_filial, cd_modelo) REFERENCES veiculo (cd_filial, cd_veiculo) ON DELETE RESTRICT
);

CREATE TABLE veiculo_modelo_transmissao (
    cd_filial integer NOT NULL,
    id_geral integer NOT NULL,
    cd_modelo integer NOT NULL,
    cd_transmissao integer NOT NULL,
    dt_atz timestamp without time zone NULL,
    CONSTRAINT "PK_veiculo_modelo_transmissao" PRIMARY KEY (cd_filial, id_geral),
    CONSTRAINT fk_veic_trans_mod_injecao FOREIGN KEY (cd_transmissao) REFERENCES veiculo_transmissao (cd_transmissao) ON DELETE RESTRICT,
    CONSTRAINT fk_veic_trans_mod_veiculo FOREIGN KEY (cd_filial, cd_modelo) REFERENCES veiculo (cd_filial, cd_veiculo) ON DELETE RESTRICT
);

CREATE TABLE agronomo (
    cd_agronomo integer NOT NULL,
    nm_agronomo character varying(34) NULL,
    cpf character varying(18) NOT NULL,
    rg character varying(20) NULL,
    endereco character varying(40) NULL,
    bairro character varying(25) NULL,
    complemento character varying(10) NULL,
    numero integer NULL,
    cd_crea integer NULL,
    crea_registro character varying(20) NULL,
    telefone character varying(20) NULL,
    celular character varying(20) NULL,
    email character varying(40) NULL,
    obs text NULL,
    cd_cidade integer NULL,
    cd_filial integer NOT NULL,
    cep character varying(10) NULL,
    CONSTRAINT "PK_agronomo" PRIMARY KEY (cd_agronomo, cpf, cd_filial),
    CONSTRAINT fk_agronomo_cidade FOREIGN KEY (cd_cidade) REFERENCES cidade (cd_cidade) ON DELETE CASCADE
);

CREATE TABLE contato (
    id_contato integer NOT NULL,
    nm_contato character varying(60) NULL,
    departamento character varying(30) NULL,
    telefone character varying(20) NULL,
    e_mail character varying(70) NULL,
    dt_nascimento date NULL,
    endereco_logradouro character varying(80) NULL,
    endereco_numero smallint NULL,
    endereco_complemento character varying(20) NULL,
    bairro character varying(80) NULL,
    cd_cidade integer NULL,
    cep character varying(10) NULL,
    fone_comercial character varying(20) NULL,
    fax character varying(20) NULL,
    celular character varying(20) NULL,
    obs character varying(255) NULL,
    tp_contato integer NOT NULL,
    CONSTRAINT "PK_contato" PRIMARY KEY (id_contato),
    CONSTRAINT fk_contato_cidade FOREIGN KEY (cd_cidade) REFERENCES cidade (cd_cidade) ON DELETE RESTRICT
);

CREATE TABLE motorista (
    cd_filial integer NOT NULL,
    cd_motorista integer NOT NULL,
    cd_cidade integer NOT NULL,
    cd_transportador integer NOT NULL,
    nome character varying(80) NULL,
    cpf character varying(11) NULL,
    cnh character varying(11) NULL,
    telefone character varying(15) NULL,
    celular character varying(15) NULL,
    CONSTRAINT "PK_motorista" PRIMARY KEY (cd_motorista),
    CONSTRAINT fk_motorista_cidade FOREIGN KEY (cd_cidade) REFERENCES cidade (cd_cidade) ON DELETE RESTRICT,
    CONSTRAINT fk_motorista_transportador FOREIGN KEY (cd_filial, cd_transportador) REFERENCES fornecedor (cd_filial, cd_fornecedor) ON DELETE RESTRICT
);

CREATE TABLE tributacao_aliquota (
    id_geral integer NOT NULL,
    id_tributacao integer NOT NULL,
    cst character varying(4) NOT NULL,
    cd_mensagem integer NULL,
    dt_atz date NULL,
    hash_tributacao_aliquota_d3 character varying(70) NULL,
    hash_tributacao_aliquota_p2 character varying(70) NULL,
    tp_tributacao character varying(1) NOT NULL,
    icm_aliq_normal double precision NULL,
    icm_aliq_proprio double precision NULL,
    icm_aliq_subst double precision NULL,
    icm_red_normal double precision NULL,
    icm_red_proprio double precision NULL,
    icm_red_subst double precision NULL,
    fl_reducao_aliq_normal character varying(1) NULL,
    fl_reducao_aliq_proprio character varying(1) NULL,
    fl_reducao_aliq_subst character varying(1) NULL,
    aliq_fcp double precision NULL,
    CONSTRAINT "PK_tributacao_aliquota" PRIMARY KEY (id_geral),
    CONSTRAINT fk_tributacao_aliquota_mensagem FOREIGN KEY (cd_mensagem) REFERENCES mensagem_nota (cd_mensagem) ON DELETE RESTRICT,
    CONSTRAINT fk_tributacao_aliquota_1 FOREIGN KEY (cst) REFERENCES cst (cd_cst) ON DELETE RESTRICT,
    CONSTRAINT fk_tributacao_aliquota_tributac FOREIGN KEY (id_tributacao) REFERENCES tributacao (id_geral) ON DELETE CASCADE
);

CREATE TABLE administradora_taxas (
    cd_administradora integer NOT NULL,
    qt_parcelas integer NOT NULL,
    pc_cobranca_loja numeric(9,3) NULL,
    CONSTRAINT "PK_administradora_taxas" PRIMARY KEY (cd_administradora, qt_parcelas),
    CONSTRAINT fk_administradora_taxas_cd_adm FOREIGN KEY (cd_administradora) REFERENCES administradora (cd_administradora) ON DELETE RESTRICT
);

CREATE TABLE cargo (
    cd_filial integer NOT NULL,
    cd_cargo integer NOT NULL,
    descricao character varying(40) NOT NULL,
    fl_libera_limite boolean NULL,
    dt_atz date NOT NULL DEFAULT ('2018-10-26'::date),
    fl_comissao_total character varying(1) NULL,
    CONSTRAINT "PK_cargo" PRIMARY KEY (cd_cargo, cd_filial),
    CONSTRAINT filial_cargo_fk FOREIGN KEY (cd_filial) REFERENCES filial (cd_filial) ON DELETE RESTRICT
);

CREATE TABLE cob_retorno (
    cd_retorno bigint NOT NULL,
    cd_filial integer NULL,
    nr_retorno character varying(20) NOT NULL,
    fl_processado character varying(1) NULL,
    arquivo text NULL,
    cd_convenio bigint NULL,
    CONSTRAINT "PK_cob_retorno" PRIMARY KEY (cd_retorno),
    CONSTRAINT fk_cob_retorno_filial FOREIGN KEY (cd_filial) REFERENCES filial (cd_filial) ON DELETE RESTRICT
);

CREATE TABLE conf_sped_pis_cofins (
    id_geral integer NOT NULL,
    tipo_escrit character varying(1) NOT NULL,
    ind_sit_esp character varying(1) NULL,
    ind_nat_pj character varying(2) NULL,
    ind_ativ character varying(1) NOT NULL,
    cod_inc_trib integer NOT NULL,
    ind_apro_cred integer NULL,
    cod_tipo_cont integer NULL,
    ind_reg_cu integer NULL,
    cd_filial integer NOT NULL,
    cod_ver character varying(10) NULL,
    fl_base_pis_lucro_veic character varying(1) NULL,
    ind_escri integer NULL,
    CONSTRAINT "PK_conf_sped_pis_cofins" PRIMARY KEY (id_geral),
    CONSTRAINT fk_conf_sped_pis_cofins_filial FOREIGN KEY (cd_filial) REFERENCES filial (cd_filial) ON DELETE RESTRICT
);

CREATE TABLE doc_producao (
    cd_filial integer NOT NULL,
    nr_documento integer NOT NULL,
    nr_ordem_producao integer NULL,
    id_nfec integer NOT NULL,
    id_nfsc integer NOT NULL,
    cd_cancelamento integer NOT NULL,
    qt_produzido double precision NULL,
    dt_producao date NOT NULL,
    dt_emissao date NOT NULL,
    CONSTRAINT "PK_doc_producao" PRIMARY KEY (nr_documento),
    CONSTRAINT fk_doc_producao_filial FOREIGN KEY (cd_filial) REFERENCES filial (cd_filial) ON DELETE RESTRICT
);

CREATE TABLE filial_email (
    id_geral integer NOT NULL,
    cd_filial integer NULL,
    tp_email integer NULL,
    nm_origem character varying(50) NULL,
    servidor_smtp character varying(50) NULL,
    email character varying(100) NULL,
    usuario character varying(100) NULL,
    senha character varying(50) NULL,
    ssl character varying(1) NULL,
    porta integer NULL,
    CONSTRAINT "PK_filial_email" PRIMARY KEY (id_geral),
    CONSTRAINT fk_filial_email_filial FOREIGN KEY (cd_filial) REFERENCES filial (cd_filial) ON DELETE CASCADE
);

CREATE TABLE filial_ie_st (
    cd_filial integer NOT NULL,
    uf character varying(2) NOT NULL,
    ie_st character varying(18) NOT NULL,
    CONSTRAINT "PK_filial_ie_st" PRIMARY KEY (cd_filial, uf),
    CONSTRAINT fk_filial_ie_st_filial FOREIGN KEY (cd_filial) REFERENCES filial (cd_filial) ON DELETE CASCADE
);

CREATE TABLE fornveic (
    cd_filial integer NOT NULL,
    id_geral integer NOT NULL,
    cd_fornecedor integer NOT NULL,
    cd_veiculo integer NOT NULL,
    tp_rodado integer NOT NULL,
    tp_carroceria integer NOT NULL,
    tara numeric(9,2) NOT NULL,
    capacidade numeric(9,2) NOT NULL,
    placa_veiculo character varying(8) NULL,
    uf character varying(2) NULL,
    observacoes character varying(2000) NULL,
    dt_atz timestamp without time zone NULL,
    CONSTRAINT "PK_fornveic" PRIMARY KEY (cd_filial, id_geral),
    CONSTRAINT fk_fornveic_filial FOREIGN KEY (cd_filial) REFERENCES filial (cd_filial) ON DELETE RESTRICT,
    CONSTRAINT fk_fornveic_fornecedor FOREIGN KEY (cd_filial, cd_fornecedor) REFERENCES fornecedor (cd_filial, cd_fornecedor) ON DELETE RESTRICT,
    CONSTRAINT fk_fornveic_veiculo FOREIGN KEY (cd_filial, cd_veiculo) REFERENCES veiculo (cd_filial, cd_veiculo) ON DELETE RESTRICT
);

CREATE TABLE crptitulo_movimento_cxa (
    cd_filial integer NOT NULL,
    cd_tipo_conta integer NOT NULL,
    cd_clifor integer NOT NULL,
    nr_titulo character varying(15) NOT NULL,
    parcela integer NOT NULL,
    nr_lcto integer NOT NULL,
    cd_caixa integer NOT NULL,
    dt_atz date NULL,
    CONSTRAINT "PK_crptitulo_movimento_cxa" PRIMARY KEY (cd_filial, cd_tipo_conta, cd_clifor, nr_titulo, parcela, nr_lcto, cd_caixa),
    CONSTRAINT fk_crptitulo_movimento_cxa FOREIGN KEY (cd_filial, cd_caixa, nr_lcto) REFERENCES movimento_cxa (cd_filial, cd_caixa, nr_lcto) ON DELETE RESTRICT,
    CONSTRAINT fk_crptitulo_movimento_cxa_1 FOREIGN KEY (cd_filial, cd_tipo_conta, cd_clifor, nr_titulo, parcela) REFERENCES crptitulo (cd_filial, cd_tipo_conta, cd_clifor, nr_titulo, parcela) ON DELETE RESTRICT
);

CREATE TABLE comissao_func_dev (
    cd_filial integer NOT NULL,
    nr_documento integer NOT NULL,
    nr_sequencia integer NOT NULL,
    cd_funcionario integer NOT NULL,
    nr_parcela integer NOT NULL,
    nr_sequencia_dev integer NOT NULL,
    vl_base double precision NOT NULL,
    pc_comissao double precision NOT NULL,
    vl_comissao double precision NOT NULL,
    id_nfec_dev integer NOT NULL,
    CONSTRAINT "PK_comissao_func_dev" PRIMARY KEY (cd_filial, nr_documento, nr_sequencia, cd_funcionario, nr_parcela, nr_sequencia_dev),
    CONSTRAINT fk_comissao_func_dev_nfec FOREIGN KEY (id_nfec_dev) REFERENCES nfec (id_geral) ON DELETE CASCADE
);

CREATE TABLE nfec_conhecimento (
    id_nfec integer NOT NULL,
    vl_frete_volume numeric(18,4) NULL,
    vl_frete numeric(18,4) NULL,
    vl_sec_cat numeric(18,4) NULL,
    vl_pedagio numeric(18,4) NULL,
    vl_outros numeric(18,4) NULL,
    tp_cte integer NULL,
    CONSTRAINT "PK_nfec_conhecimento" PRIMARY KEY (id_nfec),
    CONSTRAINT fk_nfec_conhecimento_nfec FOREIGN KEY (id_nfec) REFERENCES nfec (id_geral) ON DELETE CASCADE
);

CREATE TABLE nfec_energia_eletrica (
    id_nfec integer NOT NULL,
    cod_cons character varying(2) NULL,
    tp_ligacao integer NULL,
    cod_grupo_tensao character varying(2) NULL,
    CONSTRAINT "PK_nfec_energia_eletrica" PRIMARY KEY (id_nfec),
    CONSTRAINT fk_nfec_energia_eletrica_1 FOREIGN KEY (id_nfec) REFERENCES nfec (id_geral) ON DELETE CASCADE
);

CREATE TABLE nfec_importacao (
    id_geral integer NOT NULL,
    id_nfec integer NOT NULL,
    nr_di character varying(10) NOT NULL,
    dt_di date NOT NULL,
    cd_cidade_desembaraco integer NOT NULL,
    dt_desembaraco date NOT NULL,
    vl_base_ii numeric(14,2) NULL,
    vl_ii numeric(14,2) NULL,
    vl_siscomex numeric(14,2) NULL,
    vl_desp_aduaneira numeric(14,2) NULL,
    vl_iof numeric(14,2) NULL,
    taxa_dolar numeric(9,2) NULL,
    fl_custo_ii character varying(1) NULL,
    fl_custo_ipi character varying(1) NULL,
    fl_custo_icm character varying(1) NULL,
    fl_custo_pis_cofins character varying(1) NULL,
    tp_viatransp integer NULL,
    vl_afrmm numeric(14,2) NULL,
    tp_intermedio integer NULL,
    cgc_cpf_adquirente character varying(18) NULL,
    uf_terceiro character varying(3) NULL,
    CONSTRAINT "PK_nfec_importacao" PRIMARY KEY (id_geral),
    CONSTRAINT fk_nfec_importacao_nfec FOREIGN KEY (id_nfec) REFERENCES nfec (id_geral) ON DELETE CASCADE
);

CREATE TABLE nfec_mensagem (
    id_geral integer NOT NULL,
    cd_mensagem integer NOT NULL,
    mensagem text NOT NULL,
    id_nfec integer NULL,
    CONSTRAINT "PK_nfec_mensagem" PRIMARY KEY (id_geral),
    CONSTRAINT fk_nfec_mensagem_nota FOREIGN KEY (cd_mensagem) REFERENCES mensagem_nota (cd_mensagem) ON DELETE RESTRICT,
    CONSTRAINT fk_nfec_mensagem_nfec FOREIGN KEY (id_nfec) REFERENCES nfec (id_geral) ON DELETE CASCADE
);

CREATE TABLE orcamento_nfe (
    nr_os integer NOT NULL,
    id_nfec integer NOT NULL,
    CONSTRAINT "PK_orcamento_nfe" PRIMARY KEY (nr_os, id_nfec),
    CONSTRAINT fk_orcamento_nfe_nfec FOREIGN KEY (id_nfec) REFERENCES nfec (id_geral) ON DELETE CASCADE
);

CREATE TABLE frente_caixa (
    cd_frente_caixa integer NOT NULL,
    nm_frente_caixa character varying(60) NOT NULL,
    fl_utilizado character varying(1) NOT NULL,
    cd_operacao integer NOT NULL,
    cd_tabela_preco integer NOT NULL,
    importa character varying(200) NOT NULL,
    exporta character varying(200) NOT NULL,
    nome_arquivo character varying(20) NOT NULL,
    CONSTRAINT "PK_frente_caixa" PRIMARY KEY (cd_frente_caixa),
    CONSTRAINT fk_frente_caixa_1 FOREIGN KEY (cd_operacao) REFERENCES operacao_es (cd_operacao) ON DELETE RESTRICT,
    CONSTRAINT fk_frente_caixa_2 FOREIGN KEY (cd_tabela_preco) REFERENCES tabela_preco (cd_tabela_preco) ON DELETE RESTRICT
);

CREATE TABLE operacao_cfop_regra (
    id_geral integer NOT NULL,
    cd_operacao integer NOT NULL,
    cd_cfop_regra integer NOT NULL,
    cfop_int_cont character varying(20) NOT NULL,
    cfop_int_ncont character varying(20) NOT NULL,
    cfop_ext_cont character varying(20) NOT NULL,
    cfop_ext_ncont character varying(20) NOT NULL,
    cfop_subst_int_cont character varying(10) NULL,
    cfop_subst_int_ncont character varying(10) NULL,
    cfop_subst_ext_cont character varying(10) NULL,
    cfop_subst_ext_ncont character varying(10) NULL,
    cfop_subst_int_ncont_ret character varying(10) NULL,
    cfop_subst_int_cont_ret character varying(10) NULL,
    cfop_subst_ext_cont_ret character varying(10) NULL,
    cfop_subst_ext_ncont_ret character varying(10) NULL,
    CONSTRAINT "PK_operacao_cfop_regra" PRIMARY KEY (id_geral),
    CONSTRAINT fk_operacao_cfop_regra_1 FOREIGN KEY (cd_cfop_regra) REFERENCES cfop_regra (cd_cfop_regra) ON DELETE CASCADE,
    CONSTRAINT fk_operacao_cfop_regra_2 FOREIGN KEY (cd_operacao) REFERENCES operacao_es (cd_operacao) ON DELETE CASCADE
);

CREATE TABLE estoque (
    cd_filial integer NOT NULL,
    cd_produto character varying(15) NOT NULL,
    ano integer NOT NULL,
    mes integer NOT NULL,
    qt_entradas double precision NULL,
    qt_saidas double precision NULL,
    qtde double precision NULL,
    dt_atz date NULL DEFAULT (CURRENT_DATE),
    qt_entradas2 double precision NULL,
    qt_saidas2 double precision NULL,
    qtde2 double precision NULL,
    CONSTRAINT "PK_estoque" PRIMARY KEY (cd_filial, cd_produto, mes, ano),
    CONSTRAINT fk_estproduto FOREIGN KEY (cd_produto) REFERENCES produto (cd_produto) ON DELETE RESTRICT
);

CREATE TABLE nfei (
    nr_sequencia integer NOT NULL,
    cd_prodserv character varying(15) NOT NULL,
    fl_servico character varying(1) NULL,
    qt_produto double precision NULL,
    vl_bruto numeric(18,8) NULL,
    vl_total numeric(18,4) NULL,
    dt_lancamento date NOT NULL DEFAULT (CURRENT_DATE),
    peso_liquido double precision NULL,
    cd_atualizacao integer NULL,
    cst character varying(4) NULL,
    pc_red_base_icm numeric(9,2) NULL,
    aliq_icm numeric(9,2) NULL,
    aliq_icm_subst numeric(9,2) NULL,
    aliq_ipi numeric(9,2) NULL,
    aliq_iss numeric(9,2) NULL,
    vl_base_icm numeric(18,4) NULL,
    vl_icm numeric(18,4) NULL,
    vl_icm_subst numeric(18,4) NULL,
    vl_ipi numeric(18,4) NULL,
    vl_iss numeric(18,4) NULL,
    compl text NULL,
    nm_produto character varying(50) NULL,
    dt_atz date NULL DEFAULT (CURRENT_DATE),
    un_medida character varying(6) NULL,
    pc_desconto numeric(18,4) NULL,
    vl_base_icm_subst numeric(18,4) NULL,
    cd_conta integer NULL,
    fator_conversao double precision NULL,
    fl_controlar_estoque character varying(1) NULL,
    pc_markup numeric(18,4) NULL,
    cfop character varying(10) NULL,
    vl_desconto numeric(18,4) NULL,
    vl_desconto_rateado numeric(18,4) NULL,
    vl_acrescimo_rateado numeric(18,4) NULL,
    vl_frete_rateado numeric(18,4) NULL,
    vl_seguro_rateado numeric(18,4) NULL,
    vl_contabil numeric(18,4) NULL,
    vl_outros numeric(18,4) NULL,
    vl_isento numeric(18,4) NULL,
    aliq_pis numeric(18,4) NULL,
    vl_base_pis numeric(18,4) NULL,
    vl_pis numeric(18,4) NULL,
    aliq_cofins numeric(18,4) NULL,
    vl_base_cofins numeric(18,4) NULL,
    vl_cofins numeric(18,4) NULL,
    vl_base_iss numeric(18,4) NULL,
    vl_base_ipi numeric(18,4) NULL,
    aliq_icm_proprio_st numeric(18,4) NULL,
    vl_base_icm_proprio_st numeric(18,4) NULL,
    vl_icm_proprio_st numeric(18,4) NULL,
    aliq_icm_subst_real numeric(18,4) NULL,
    vl_base_icm_subst_real numeric(18,4) NULL,
    vl_icm_subst_real numeric(18,4) NULL,
    aliq_uf_destino numeric(6,2) NULL,
    pc_red_base_icm_subst numeric(6,2) NULL,
    pc_red_base_icm_proprio_st numeric(6,2) NULL,
    qt_compra double precision NULL,
    un_compra character varying(6) NULL,
    vl_unitario numeric(18,8) NULL,
    vl_unitario_compra numeric(18,8) NULL,
    cst_ipi character varying(2) NULL,
    cst_pis character varying(2) NULL,
    cst_cofins character varying(2) NULL,
    id_geral integer NOT NULL,
    id_nfec integer NULL,
    conhecimento_vl_frete numeric(18,4) NULL,
    conhecimento_base_icm numeric(18,4) NULL,
    conhecimento_vl_icm numeric(18,4) NULL,
    conhecimento_base_st numeric(18,4) NULL,
    conhecimento_vl_st numeric(18,4) NULL,
    vl_icm_frete numeric(18,4) NULL,
    cst_ori character varying(4) NULL,
    aliq_icm_ori double precision NULL,
    pc_red_base_icm_ori double precision NULL,
    vl_base_icm_ori numeric(18,4) NULL,
    vl_icm_ori numeric(18,4) NULL,
    aliq_icm_proprio_st_ori double precision NULL,
    pc_red_base_icm_proprio_st_ori double precision NULL,
    vl_base_icm_proprio_st_ori numeric(18,4) NULL,
    vl_icm_proprio_st_ori numeric(18,4) NULL,
    mva_ori double precision NULL,
    aliq_icm_subst_ori double precision NULL,
    pc_red_base_icm_subst_ori double precision NULL,
    vl_base_icm_subst_ori numeric(18,4) NULL,
    vl_icm_subst_ori numeric(18,4) NULL,
    cfop_ori character varying(10) NULL,
    vl_base_icm_subst_ant numeric(9,2) NULL,
    vl_icm_subst_ant numeric(9,2) NULL,
    fl_soma_total character varying(1) NULL,
    fl_validado character(1) NULL,
    classificacao_ctbl character varying(3) NULL,
    vl_outras_despesas numeric(14,4) NULL,
    vl_icm_subst_dev numeric(18,4) NULL,
    vl_base_icm_subst_dev numeric(18,4) NULL,
    alic_icm_subst_dev numeric(18,4) NULL,
    pc_red_base_icm_subst_dev numeric(18,4) NULL,
    vl_base_ipi_dev numeric(18,4) NULL,
    vl_ipi_dev numeric(18,4) NULL,
    alic_ipi_dev numeric(18,4) NULL,
    mva_dev numeric(18,4) NULL,
    icms_normal_dif_pc_aliq numeric(18,4) NULL,
    icms_normal_dif_vl_base numeric(18,4) NULL,
    icms_normal_dif_valor numeric(18,4) NULL,
    natureza_frete integer NULL,
    nr_sequencia_dev integer NULL,
    pc_fcp numeric(4,4) NULL,
    vl_fcp numeric(13,2) NULL,
    vl_base_fcp numeric(13,2) NULL,
    vl_base_fcp_st numeric(13,2) NULL,
    pc_fcp_st numeric(4,4) NULL,
    vl_fcp_st numeric(13,2) NULL,
    vl_fcp_st_retido numeric(13,2) NULL,
    pc_fcp_st_retido numeric(4,4) NULL,
    vl_base_fcp_st_retido numeric(13,2) NULL,
    vl_base_fcp_uf_destino numeric(13,2) NULL,
    pc_fcp_uf_destino numeric(4,4) NULL,
    vl_fcp_uf_destino numeric(13,2) NULL,
    vl_base_uf_destino numeric(13,2) NULL,
    pc_icms_uf_destino numeric(4,4) NULL,
    pc_icms_interno numeric(2,2) NULL,
    pc_icms_interno_partilha numeric(4,4) NULL,
    vl_icms_uf_destino numeric(13,2) NULL,
    vl_icms_uf_remetente numeric(13,2) NULL,
    CONSTRAINT "PK_nfei" PRIMARY KEY (id_geral),
    CONSTRAINT fk_nfei_cxa_conta FOREIGN KEY (cd_conta) REFERENCES cxa_conta (cd_conta) ON DELETE RESTRICT,
    CONSTRAINT fk_nfeproduto FOREIGN KEY (cd_prodserv) REFERENCES produto (cd_produto) ON DELETE RESTRICT,
    CONSTRAINT fk_nfei_nfec FOREIGN KEY (id_nfec) REFERENCES nfec (id_geral) ON DELETE CASCADE
);

CREATE TABLE orcamento_i (
    cd_filial integer NOT NULL,
    nr_os integer NOT NULL,
    nr_sequencia integer NOT NULL,
    cd_produto character varying(15) NOT NULL,
    nm_produto character varying(60) NULL,
    un_medida character varying(6) NULL,
    fl_servico character varying(1) NULL,
    qt_produto double precision NULL,
    box character varying(10) NULL,
    local_estocagem character varying(40) NULL,
    vl_bruto numeric(18,4) NULL,
    pc_desconto numeric(9,2) NULL,
    vl_liquido numeric(18,4) NULL,
    vl_total numeric(18,4) NULL,
    dt_emissao date NOT NULL DEFAULT (CURRENT_DATE),
    complemento text NULL,
    cd_funcionario integer NULL,
    vl_custo numeric(18,4) NULL,
    dt_atz date NULL DEFAULT (CURRENT_DATE),
    cd_original character varying(20) NULL,
    cd_barras character varying(20) NULL,
    placa_veiculo character varying(8) NULL,
    kilometragem integer NULL,
    vl_ipi numeric(18,4) NULL,
    nr_serie_equip character varying(32) NULL,
    pc_acrescimo numeric(9,2) NULL,
    vl_desconto numeric(9,2) NULL,
    vl_acrescimo numeric(9,2) NULL,
    fator_conversao double precision NULL,
    qt_venda double precision NULL,
    un_venda character varying(6) NULL,
    fl_item_cancelado boolean NULL,
    hash_orcamento_i_d3 character varying(70) NULL,
    fl_reservando_estoque boolean NULL,
    fl_alteracao character varying(1) NULL,
    hr_alteracao character varying(6) NULL,
    cd_ped_comp character varying(15) NULL,
    nr_item_ped_comp integer NULL,
    CONSTRAINT "PK_orcamento_i" PRIMARY KEY (cd_filial, nr_os, nr_sequencia),
    CONSTRAINT fk_orcproduto FOREIGN KEY (cd_produto) REFERENCES produto (cd_produto) ON DELETE RESTRICT
);

CREATE TABLE ordem_producao_i (
    id_geral bigint NOT NULL,
    id_ordem_producao_c bigint NOT NULL,
    cd_item character varying(15) NOT NULL,
    qt_producao double precision NULL,
    qt_produzido double precision NULL,
    CONSTRAINT "PK_ordem_producao_i" PRIMARY KEY (id_geral),
    CONSTRAINT fk_ordem_producao_i_cd_produto FOREIGN KEY (cd_item) REFERENCES produto (cd_produto) ON DELETE RESTRICT,
    CONSTRAINT fk_ordem_producao_i_id_ordem_c FOREIGN KEY (id_ordem_producao_c) REFERENCES ordem_producao_c (id_geral) ON DELETE RESTRICT
);

CREATE TABLE prod_composto (
    cd_produto character varying(15) NOT NULL,
    cd_composto character varying(15) NOT NULL,
    qt_composto double precision NULL,
    nm_prodcomposto character varying(62) NOT NULL,
    dt_atz date NULL DEFAULT (CURRENT_DATE),
    qt_liquido double precision NULL,
    CONSTRAINT "PK_prod_composto" PRIMARY KEY (cd_produto, cd_composto),
    CONSTRAINT fk_updtpproduto FOREIGN KEY (cd_produto) REFERENCES produto (cd_produto) ON DELETE RESTRICT
);

CREATE TABLE produto_lote (
    id_geral integer NOT NULL,
    id_nfec integer NULL,
    cd_produto character varying(14) NOT NULL,
    nr_lote character varying(10) NOT NULL,
    dt_fabricacao date NULL,
    dt_validade date NULL,
    qt_entrada double precision NULL,
    qt_saida double precision NULL,
    id_nfsc integer NULL,
    dt_lancamento_lote date NULL,
    nr_sequencial integer NOT NULL,
    CONSTRAINT "PK_produto_lote" PRIMARY KEY (id_geral),
    CONSTRAINT fk_produto_lote_produto FOREIGN KEY (cd_produto) REFERENCES produto (cd_produto) ON DELETE RESTRICT,
    CONSTRAINT fk_produto_lote_nfec FOREIGN KEY (id_nfec) REFERENCES nfec (id_geral) ON DELETE CASCADE
);

CREATE TABLE produto_veiculo (
    cd_filial integer NOT NULL,
    cd_produto character varying(15) NOT NULL,
    placa character varying(8) NOT NULL,
    cd_montadora integer NOT NULL,
    cd_veiculo integer NOT NULL,
    chassi character varying(17) NULL,
    renavan character varying(11) NULL,
    nm_cor_montadora character varying(40) NULL,
    ano_mod integer NULL,
    ano_fab integer NULL,
    motor character varying(17) NULL,
    potencia character varying(10) NULL,
    passageiros integer NULL,
    categoria character varying(20) NULL,
    cilindradas integer NULL,
    obs text NULL,
    nr_documento_nfs integer NULL,
    fl_novo character varying(1) NOT NULL,
    km double precision NULL,
    cd_cor character varying(2) NULL,
    cd_combustivel character varying(2) NULL,
    cd_especie character varying(2) NULL,
    cd_tipo character varying(2) NULL,
    cd_restricao integer NULL,
    cd_cor_montadora character varying(4) NULL,
    peso_liq numeric(15,4) NULL,
    peso_brt numeric(15,4) NULL,
    nr_serie character varying(9) NULL,
    cmkg character varying(9) NULL,
    dist_entre_eixos character varying(10) NULL,
    tp_pintura character varying(1) NULL,
    cd_vin character varying(1) NULL,
    cond_veiculo integer NULL,
    cd_modelo_renavan character varying(6) NULL,
    CONSTRAINT "PK_produto_veiculo" PRIMARY KEY (cd_filial, cd_produto),
    CONSTRAINT fk_produto_veiculo_combustivel FOREIGN KEY (cd_combustivel) REFERENCES veiculo_combustivel (cd_combustivel) ON DELETE RESTRICT,
    CONSTRAINT fk_produto_veiculo_cor FOREIGN KEY (cd_cor) REFERENCES veiculo_cor (cd_cor) ON DELETE RESTRICT,
    CONSTRAINT fk_produto_veiculo_especie FOREIGN KEY (cd_especie) REFERENCES veiculo_especie (cd_especie) ON DELETE RESTRICT,
    CONSTRAINT fk_veiculo_despesas_produto FOREIGN KEY (cd_produto) REFERENCES produto (cd_produto) ON DELETE CASCADE,
    CONSTRAINT fk_produto_veiculo_tipo FOREIGN KEY (cd_tipo) REFERENCES veiculo_tipo (cd_tipo) ON DELETE RESTRICT,
    CONSTRAINT fk_veiculo_cd_montadora FOREIGN KEY (cd_filial, cd_montadora) REFERENCES montadora (cd_filial, cd_montadora) ON DELETE CASCADE,
    CONSTRAINT fk_veiculo_cd_veiculo FOREIGN KEY (cd_filial, cd_veiculo) REFERENCES veiculo (cd_filial, cd_veiculo) ON DELETE CASCADE
);

CREATE TABLE veiprod (
    cd_filial integer NOT NULL,
    cd_veiculo integer NOT NULL,
    cd_produto character varying(15) NOT NULL,
    dt_atz date NULL DEFAULT (CURRENT_DATE),
    id_geral integer NOT NULL,
    ano_inicial integer NULL,
    ano_final integer NULL,
    cd_motor integer NULL,
    cd_complemento integer NULL,
    cd_montadora integer NULL,
    CONSTRAINT "PK_veiprod" PRIMARY KEY (id_geral),
    CONSTRAINT fk_veiprod_complemento FOREIGN KEY (cd_complemento) REFERENCES veiculo_complemento (cd_complemento) ON DELETE RESTRICT,
    CONSTRAINT fk_veiprod_motor FOREIGN KEY (cd_motor) REFERENCES veiculo_motor (cd_motor) ON DELETE RESTRICT,
    CONSTRAINT fk_veiproduto FOREIGN KEY (cd_produto) REFERENCES produto (cd_produto) ON DELETE RESTRICT,
    CONSTRAINT fk_veiprod_montadora FOREIGN KEY (cd_filial, cd_montadora) REFERENCES montadora (cd_filial, cd_montadora) ON DELETE RESTRICT,
    CONSTRAINT fk_veicproduto FOREIGN KEY (cd_filial, cd_veiculo) REFERENCES veiculo (cd_filial, cd_veiculo) ON DELETE RESTRICT
);

CREATE TABLE fornecedor_contato (
    cd_fornecedor integer NOT NULL,
    cd_contato integer NOT NULL,
    cd_filial integer NOT NULL,
    CONSTRAINT "PK_fornecedor_contato" PRIMARY KEY (cd_fornecedor, cd_contato),
    CONSTRAINT fk_fornecedor_contato_contato FOREIGN KEY (cd_contato) REFERENCES contato (id_contato) ON DELETE CASCADE,
    CONSTRAINT fk_fornecedor_contato FOREIGN KEY (cd_filial, cd_fornecedor) REFERENCES fornecedor (cd_filial, cd_fornecedor) ON DELETE RESTRICT
);

CREATE TABLE funcionario (
    cd_filial integer NOT NULL,
    cd_funcionario integer NOT NULL,
    nm_funcionario character varying(80) NOT NULL,
    endereco character varying(80) NULL,
    bairro character varying(30) NULL,
    cd_cidade integer NOT NULL,
    cep character varying(10) NULL,
    fone character varying(20) NULL,
    fax character varying(20) NULL,
    dt_admissao date NULL DEFAULT (CURRENT_DATE),
    dt_aniversario date NULL,
    fl_vendedor boolean NULL,
    cota_mensal numeric(18,4) NULL,
    dt_atz date NULL DEFAULT (CURRENT_DATE),
    cd_filial_padrao integer NULL,
    fl_alterar_filial boolean NULL,
    fl_controlar_acesso boolean NULL,
    login character varying(15) NULL,
    senha character varying(10) NULL,
    fl_usuario boolean NULL,
    cd_cargo integer NULL,
    cd_caixa integer NULL,
    fl_nao_acessa_valores boolean NULL,
    smtp_email character varying(100) NULL,
    e_mail character varying(80) NULL,
    nm_usuario_smtp character varying(50) NULL,
    fl_exibe_custos character varying(1) NULL,
    senha_smtp character varying(50) NULL,
    ssl_smtp character varying(1) NULL,
    cd_usr integer NULL,
    cd_usuario integer NULL,
    fl_ativo character(1) NOT NULL DEFAULT ('S'::bpchar),
    fl_ve_saldo_cxa_emp_fechamento character varying(1) NULL,
    msg_padrao_nfe text NULL,
    porta_smtp integer NULL,
    cpf character varying(18) NULL,
    rg character varying(18) NULL,
    cnh character varying(18) NULL,
    pis character varying(18) NULL,
    fl_mecanico boolean NOT NULL,
    custo_hora numeric(9,2) NULL,
    valor_venda numeric(9,2) NULL,
    CONSTRAINT "PK_funcionario" PRIMARY KEY (cd_filial, cd_funcionario),
    CONSTRAINT cargo_funcionario_fk FOREIGN KEY (cd_cargo, cd_filial) REFERENCES cargo (cd_cargo, cd_filial) ON DELETE RESTRICT
);

CREATE TABLE cob_retorno_parcela (
    id_geral bigint NOT NULL,
    cd_retorno bigint NOT NULL,
    nr_nosso_numero character varying(50) NOT NULL,
    id_parcela character varying(100) NULL,
    cd_movimento_retorno character varying(10) NOT NULL,
    cd_motivo_movimento_retorno1 character varying(10) NULL,
    cd_motivo_movimento_retorno2 character varying(10) NULL,
    cd_motivo_movimento_retorno3 character varying(10) NULL,
    cd_motivo_movimento_retorno4 character varying(10) NULL,
    cd_motivo_movimento_retorno5 character varying(10) NULL,
    dt_ocorrencia date NOT NULL,
    dt_credito date NULL,
    dt_debito_tarifa date NULL,
    vl_despesa_cobranca numeric(14,2) NOT NULL,
    vl_acrescimo numeric(14,2) NOT NULL,
    vl_desconto numeric(14,2) NOT NULL,
    vl_abatimento numeric(14,2) NOT NULL,
    vl_iof numeric(14,2) NOT NULL,
    vl_pago numeric(14,2) NOT NULL,
    vl_liquido numeric(14,2) NOT NULL,
    vl_outras_despesas numeric(14,2) NOT NULL,
    vl_outros_creditos numeric(14,2) NOT NULL,
    fl_processado character varying(1) NULL,
    vl_tarifa numeric(14,2) NOT NULL,
    CONSTRAINT "PK_cob_retorno_parcela" PRIMARY KEY (id_geral),
    CONSTRAINT fk_cob_retorno_cd_retorno FOREIGN KEY (cd_retorno) REFERENCES cob_retorno (cd_retorno) ON DELETE RESTRICT
);

CREATE TABLE mdfe (
    cd_filial integer NOT NULL,
    id_geral integer NOT NULL,
    cd_modelo character varying(3) NOT NULL,
    nr_serie character varying(3) NOT NULL,
    nr_mdf integer NOT NULL,
    cd_modalidade integer NOT NULL,
    dt_emissao timestamp without time zone NOT NULL,
    tp_emitente integer NOT NULL,
    tp_emissao integer NOT NULL,
    cd_cidade_carregamento integer NOT NULL,
    uf_descarregamento character varying(2) NOT NULL,
    cd_proprietario_veiculo integer NOT NULL,
    id_fornveic integer NOT NULL,
    qt_cte integer NULL,
    qt_ct integer NULL,
    qt_nfe integer NULL,
    qt_nf integer NULL,
    vl_carga numeric(15,2) NULL,
    peso_bruto_carga numeric(15,4) NULL,
    cd_status_mdfe integer NULL,
    chave_acesso_mdfe character varying(44) NULL,
    nr_recibo_mdfe character varying(15) NULL,
    nr_protocolo_mdfe character varying(15) NULL,
    arq_xml text NULL,
    dt_atz timestamp without time zone NULL,
    CONSTRAINT "PK_mdfe" PRIMARY KEY (id_geral),
    CONSTRAINT fk_mdfe_cidade FOREIGN KEY (cd_cidade_carregamento) REFERENCES cidade (cd_cidade) ON DELETE RESTRICT,
    CONSTRAINT fk_mdfe_filial FOREIGN KEY (cd_filial) REFERENCES filial (cd_filial) ON DELETE RESTRICT,
    CONSTRAINT fk_mdfe_modelo_dcto FOREIGN KEY (cd_modelo) REFERENCES modelo_dcto (cd_modelo) ON DELETE RESTRICT,
    CONSTRAINT fk_mdfe_serie FOREIGN KEY (nr_serie) REFERENCES nr_serie_nfs (nr_serie) ON DELETE RESTRICT,
    CONSTRAINT fk_mdfe_proprietario FOREIGN KEY (cd_filial, cd_proprietario_veiculo) REFERENCES fornecedor (cd_filial, cd_fornecedor) ON DELETE RESTRICT,
    CONSTRAINT fk_mdfe_fornveic FOREIGN KEY (cd_filial, id_fornveic) REFERENCES fornveic (cd_filial, id_geral) ON DELETE RESTRICT
);

CREATE TABLE orcamento_c (
    cd_filial integer NOT NULL,
    nr_os integer NOT NULL,
    placa_veiculo character varying(8) NOT NULL,
    kilometragem integer NULL,
    cd_clifor integer NULL,
    nm_clifor character varying(80) NULL,
    tel_mail character varying(50) NULL,
    vl_acrescimos numeric(18,4) NULL,
    vl_descontos numeric(18,4) NULL,
    vl_mercadorias numeric(18,4) NULL,
    vl_servicos numeric(18,4) NULL,
    vl_total numeric(18,4) NULL,
    cd_condpgto integer NOT NULL,
    vl_entrada numeric(18,4) NULL,
    dt_emissao date NULL,
    dt_validade date NULL,
    problema text NULL,
    cd_usuario integer NULL,
    dt_atz date NULL DEFAULT (CURRENT_DATE),
    nm_cidade character varying(40) NULL,
    uf character varying(2) NULL,
    nm_montadora character varying(40) NULL,
    nm_veiculo character varying(70) NULL,
    motivo_cancelamento character varying(80) NULL,
    obs text NULL,
    vl_ipi numeric(18,4) NULL,
    cd_situacao integer NOT NULL,
    fl_agrupado boolean NOT NULL,
    fl_cancelado boolean NOT NULL,
    fl_finalizado boolean NOT NULL,
    dt_entrega date NULL,
    nr_pre_venda integer NULL,
    cd_frente_caixa integer NULL,
    fl_dav_impresso character varying(1) NULL,
    id_end_entrega integer NULL,
    hash_orcamento_c_d2 character varying(70) NULL,
    hash_orcamento_c_d3 character varying(70) NULL,
    cd_tabela_preco integer NULL,
    fl_exporta_dav_pdf boolean NULL,
    datahora_cancelamento timestamp without time zone NULL,
    usuario_cancelamento integer NULL,
    vl_icmsst numeric(18,4) NULL,
    fl_envia_paf character varying(1) NULL,
    CONSTRAINT "PK_orcamento_c" PRIMARY KEY (cd_filial, nr_os),
    CONSTRAINT fk_orcamento_c_frente_caixa FOREIGN KEY (cd_frente_caixa) REFERENCES frente_caixa (cd_frente_caixa) ON DELETE RESTRICT,
    CONSTRAINT fk_orcamento_c_situacao FOREIGN KEY (cd_situacao) REFERENCES situacao (cd_situacao) ON DELETE RESTRICT,
    CONSTRAINT fk_orcamento_c_tabela_preco FOREIGN KEY (cd_tabela_preco) REFERENCES tabela_preco (cd_tabela_preco) ON DELETE RESTRICT,
    CONSTRAINT fk_orcamento_c_usuario FOREIGN KEY (usuario_cancelamento) REFERENCES usuario (cd_usuario) ON DELETE RESTRICT
);

CREATE TABLE custcomp (
    cd_filial integer NOT NULL,
    cd_produto character varying(15) NOT NULL,
    dt_lancamento date NOT NULL DEFAULT (CURRENT_DATE),
    custo_compra_nomi numeric(18,4) NULL,
    custo_medio_nomi numeric(18,4) NULL,
    qtde_nomi double precision NOT NULL,
    dt_atz date NULL DEFAULT (CURRENT_DATE),
    fl_custo_alterado character varying(1) NULL,
    custo_compra_simples numeric(18,4) NULL,
    id_nfei integer NOT NULL,
    CONSTRAINT "PK_custcomp" PRIMARY KEY (cd_filial, cd_produto, id_nfei),
    CONSTRAINT fk_cusproduto FOREIGN KEY (cd_produto) REFERENCES produto (cd_produto) ON DELETE RESTRICT,
    CONSTRAINT fk_custcomp_nfei FOREIGN KEY (id_nfei) REFERENCES nfei (id_geral) ON DELETE CASCADE
);

CREATE TABLE nfei_importacao (
    id_geral integer NOT NULL,
    id_nfei integer NOT NULL,
    nr_adicao integer NOT NULL,
    nr_seq_adicao integer NOT NULL,
    cd_fabricante integer NOT NULL,
    vl_desconto_di numeric(14,2) NULL,
    vl_base_ii numeric(14,2) NULL,
    vl_ii numeric(14,2) NULL,
    vl_siscomex numeric(14,2) NULL,
    vl_desp_aduaneira numeric(14,2) NULL,
    vl_iof numeric(14,2) NULL,
    CONSTRAINT "PK_nfei_importacao" PRIMARY KEY (id_geral),
    CONSTRAINT fk_nfei_importacao_nfei FOREIGN KEY (id_nfei) REFERENCES nfei (id_geral) ON DELETE CASCADE
);

CREATE TABLE nfeicomplemento (
    complemento text NULL,
    dt_atz date NULL DEFAULT (CURRENT_DATE),
    id_nfei integer NOT NULL,
    CONSTRAINT "PK_nfeicomplemento" PRIMARY KEY (id_nfei),
    CONSTRAINT fk_nfeicomplemento_nfei FOREIGN KEY (id_nfei) REFERENCES nfei (id_geral) ON DELETE CASCADE
);

CREATE TABLE produto_serie (
    id_geral integer NOT NULL,
    cd_filial integer NOT NULL,
    cd_produto character varying(15) NOT NULL,
    nr_serie character varying(32) NOT NULL,
    nr_nfs integer NULL,
    nr_os integer NULL,
    nr_sequencia_nfs integer NULL,
    id_nfei integer NULL,
    nr_sequencia_os integer NULL,
    CONSTRAINT "PK_produto_serie" PRIMARY KEY (id_geral),
    CONSTRAINT fk_produto_serie_produto FOREIGN KEY (cd_produto) REFERENCES produto (cd_produto) ON DELETE RESTRICT,
    CONSTRAINT fk_produto_serie_nfei FOREIGN KEY (id_nfei) REFERENCES nfei (id_geral) ON DELETE CASCADE
);

CREATE TABLE orcamento_i_agrupa (
    cd_filial integer NOT NULL,
    nr_os integer NOT NULL,
    nr_sequencia_equip integer NOT NULL,
    nr_sequencia_servico integer NOT NULL,
    CONSTRAINT "PK_orcamento_i_agrupa" PRIMARY KEY (cd_filial, nr_os, nr_sequencia_equip, nr_sequencia_servico),
    CONSTRAINT fk_orcamento_i_agrupa_equip FOREIGN KEY (cd_filial, nr_os, nr_sequencia_equip) REFERENCES orcamento_i (cd_filial, nr_os, nr_sequencia) ON DELETE RESTRICT,
    CONSTRAINT fk_orcamento_i_agrupa_servico FOREIGN KEY (cd_filial, nr_os, nr_sequencia_servico) REFERENCES orcamento_i (cd_filial, nr_os, nr_sequencia) ON DELETE RESTRICT
);

CREATE TABLE orcamento_i_reserva_estoque (
    cd_filial integer NOT NULL,
    nr_os integer NOT NULL,
    nr_sequencia integer NOT NULL,
    cd_produto character varying(15) NULL,
    qt_reservado numeric(18,4) NULL,
    CONSTRAINT "PK_orcamento_i_reserva_estoque" PRIMARY KEY (cd_filial, nr_os, nr_sequencia),
    CONSTRAINT fk_orcamento_i_reserva_estoque_ FOREIGN KEY (cd_filial, nr_os, nr_sequencia) REFERENCES orcamento_i (cd_filial, nr_os, nr_sequencia) ON DELETE CASCADE
);

CREATE TABLE produto_veiculos_injecao (
    id_geral integer NOT NULL,
    id_produto_veiculos integer NOT NULL,
    cd_injecao integer NOT NULL,
    dt_atz timestamp without time zone NULL,
    CONSTRAINT "PK_produto_veiculos_injecao" PRIMARY KEY (id_geral),
    CONSTRAINT fk_prodinje_prodinje FOREIGN KEY (cd_injecao) REFERENCES veiculo_injecao (cd_injecao) ON DELETE RESTRICT,
    CONSTRAINT fk_prodinje_prodveic FOREIGN KEY (id_produto_veiculos) REFERENCES veiprod (id_geral) ON DELETE CASCADE
);

CREATE TABLE produto_veiculos_transmissao (
    id_geral integer NOT NULL,
    id_produto_veiculos integer NOT NULL,
    cd_transmissao integer NOT NULL,
    dt_atz timestamp without time zone NULL,
    CONSTRAINT "PK_produto_veiculos_transmissao" PRIMARY KEY (id_geral),
    CONSTRAINT fk_veictrans_prodtrans FOREIGN KEY (cd_transmissao) REFERENCES veiculo_transmissao (cd_transmissao) ON DELETE RESTRICT,
    CONSTRAINT fk_veictrans_prodveic FOREIGN KEY (id_produto_veiculos) REFERENCES veiprod (id_geral) ON DELETE CASCADE
);

CREATE TABLE cliente (
    cd_filial integer NOT NULL,
    cd_cliente integer NOT NULL,
    nm_clifor character varying(80) NOT NULL,
    nm_fantasia character varying(80) NULL,
    fl_clifor character varying(1) NULL,
    endereco character varying(80) NULL,
    bairro character varying(30) NULL,
    cd_cidade integer NOT NULL,
    cep character varying(10) NULL,
    fone character varying(20) NULL,
    fax character varying(20) NULL,
    pessoa_contato character varying(40) NULL,
    dt_cadastro date NULL DEFAULT (CURRENT_DATE),
    dt_aniversario date NULL,
    tp_pessoa character varying(1) NULL,
    cgc_cpf character varying(18) NULL,
    local_trabalho character varying(40) NULL,
    fone_trabalho character varying(20) NULL,
    inscricao character varying(18) NULL,
    observacao_clifor text NULL,
    fl_cont_ncont boolean NULL,
    fl_simples boolean NULL,
    e_mail character varying(200) NULL,
    celular character varying(20) NULL,
    cd_vendedor integer NULL,
    limite_credito numeric(18,4) NULL,
    nm_conjuge character varying(75) NULL,
    rg_conjuge character varying(18) NULL,
    cpf_conjuge character varying(18) NULL,
    dt_nasc_conj date NULL,
    trab_conj character varying(40) NULL,
    fone_com character varying(20) NULL,
    salario numeric(18,4) NULL,
    obs_conj text NULL,
    cd_fornecedor integer NULL,
    fl_spc boolean NULL,
    dt_spc date NULL,
    dt_atz date NULL DEFAULT (CURRENT_DATE),
    dt_admissao date NULL,
    nm_pai character varying(80) NULL,
    nm_mae character varying(80) NULL,
    local_nasc character varying(30) NULL,
    fl_imprimir_fatura character varying(1) NULL,
    fl_agricultor character varying(1) NULL,
    tipo character varying(48) NULL,
    fl_bloqueado boolean NULL,
    motivo_bloqueio text NULL,
    cod_func_bloqueou integer NULL,
    numero character varying(50) NULL,
    complemento character varying(20) NULL,
    fl_ativo character varying(1) NULL,
    cd_conta_contabil integer NULL,
    cd_grupo_cliente smallint NOT NULL,
    inscricao_suframa character varying(9) NULL,
    hash_cliente_d2 character varying(70) NULL,
    fl_cliente_rede_uniagro character varying(1) NULL,
    cargo character varying(15) NULL,
    local_trabalho_conjuge character varying(20) NULL,
    fone_trabalho_conjuge character varying(15) NULL,
    dt_admissao_conjuge date NULL,
    renda_conjuge numeric(15,2) NULL,
    cargo_conjuge character varying(15) NULL,
    ref_1 character varying(20) NULL,
    ref_2 character varying(20) NULL,
    tel_ref_1 character varying(15) NULL,
    tel_ref_2 character varying(15) NULL,
    ref_3 character varying(20) NULL,
    ref_4 character varying(20) NULL,
    tel_ref_3 character varying(20) NULL,
    tel_ref_4 character varying(20) NULL,
    fl_exibe_obs boolean NULL,
    im character varying(10) NULL,
    fl_od_pesferico numeric(18,4) NULL,
    fl_od_pcilindrico numeric(18,4) NULL,
    fl_od_peixo numeric(18,4) NULL,
    fl_es_pesferico numeric(18,4) NULL,
    fl_es_pcilindrico numeric(18,4) NULL,
    fl_es_peixo numeric(18,4) NULL,
    fl_od_lesferico numeric(18,4) NULL,
    fl_od_lcilindrico numeric(18,4) NULL,
    fl_od_leixo numeric(18,4) NULL,
    fl_es_lesferico numeric(18,4) NULL,
    fl_es_lcilindrico numeric(18,4) NULL,
    fl_es_leixo numeric(18,4) NULL,
    motivo_protesto text NULL,
    fl_protestado boolean NULL,
    cd_func_protestou integer NULL,
    CONSTRAINT "PK_cliente" PRIMARY KEY (cd_filial, cd_cliente),
    CONSTRAINT "AK_cliente_cd_cliente" UNIQUE (cd_cliente),
    CONSTRAINT fk_cliente_conta_contabil FOREIGN KEY (cd_conta_contabil) REFERENCES conta_contabil (cd_conta) ON DELETE RESTRICT,
    CONSTRAINT fk_cliefilial FOREIGN KEY (cd_filial) REFERENCES filial (cd_filial) ON DELETE RESTRICT,
    CONSTRAINT fk_cliefuncionario FOREIGN KEY (cd_filial, cd_vendedor) REFERENCES funcionario (cd_filial, cd_funcionario) ON DELETE RESTRICT
);

CREATE TABLE comissao (
    cd_filial integer NOT NULL,
    cd_grupo_comissao integer NOT NULL,
    cd_funcionario integer NOT NULL,
    pc_sobre_comissao numeric(9,2) NULL DEFAULT (100),
    pc_minimo numeric(9,2) NULL,
    dt_atz date NOT NULL DEFAULT ('2018-10-26'::date),
    fl_comissao_abaixo_min boolean NULL,
    CONSTRAINT "PK_comissao" PRIMARY KEY (cd_funcionario, cd_grupo_comissao, cd_filial),
    CONSTRAINT filial_comissao_fk FOREIGN KEY (cd_filial) REFERENCES filial (cd_filial) ON DELETE RESTRICT,
    CONSTRAINT grupo_comissao_comissao_fk FOREIGN KEY (cd_grupo_comissao) REFERENCES grupo_comissao (cd_grupo_comissao) ON DELETE RESTRICT,
    CONSTRAINT funcionario_comissao_fk FOREIGN KEY (cd_filial, cd_funcionario) REFERENCES funcionario (cd_filial, cd_funcionario) ON DELETE RESTRICT
);

CREATE TABLE crptitulo_funcionario (
    cd_filial integer NOT NULL,
    cd_tipo_conta integer NOT NULL,
    cd_clifor integer NOT NULL,
    nr_titulo character varying(15) NOT NULL,
    cd_funcionario integer NOT NULL,
    obs text NULL,
    CONSTRAINT "PK_crptitulo_funcionario" PRIMARY KEY (cd_filial, cd_tipo_conta, cd_clifor, nr_titulo, cd_funcionario),
    CONSTRAINT fk_crptitulo_funcionario_func FOREIGN KEY (cd_filial, cd_funcionario) REFERENCES funcionario (cd_filial, cd_funcionario) ON DELETE CASCADE
);

CREATE TABLE mdfe_condutor (
    cd_filial integer NOT NULL,
    id_geral integer NOT NULL,
    id_mdfe integer NULL,
    cd_fornecedor integer NULL,
    cd_motorista integer NULL,
    dt_atz timestamp without time zone NULL,
    CONSTRAINT "PK_mdfe_condutor" PRIMARY KEY (id_geral),
    CONSTRAINT fk_mdfe_condutor_filial FOREIGN KEY (cd_filial) REFERENCES filial (cd_filial) ON DELETE RESTRICT,
    CONSTRAINT fk_mdfe_condutor_motorista FOREIGN KEY (cd_motorista) REFERENCES motorista (cd_motorista) ON DELETE RESTRICT,
    CONSTRAINT fk_mdfe_condutor_mdfe FOREIGN KEY (id_mdfe) REFERENCES mdfe (id_geral) ON DELETE RESTRICT,
    CONSTRAINT fk_mdfe_condutor_fornecedor FOREIGN KEY (cd_filial, cd_fornecedor) REFERENCES fornecedor (cd_filial, cd_fornecedor) ON DELETE RESTRICT
);

CREATE TABLE mdfe_documento (
    cd_filial integer NOT NULL,
    id_geral integer NOT NULL,
    id_mdfe integer NULL,
    id_nf integer NULL,
    dt_atz timestamp without time zone NULL,
    CONSTRAINT "PK_mdfe_documento" PRIMARY KEY (id_geral),
    CONSTRAINT fk_mdfe_documento_filial FOREIGN KEY (cd_filial) REFERENCES filial (cd_filial) ON DELETE RESTRICT,
    CONSTRAINT fk_mdfe_documento_mdfe FOREIGN KEY (id_mdfe) REFERENCES mdfe (id_geral) ON DELETE RESTRICT
);

CREATE TABLE mdfe_evento (
    cd_filial integer NOT NULL,
    id_geral integer NOT NULL,
    id_mdfe integer NOT NULL,
    nr_sequencia integer NOT NULL,
    tp_evento integer NULL,
    nm_evento character varying(40) NOT NULL,
    arq_xml text NULL,
    nr_protocolo character varying(15) NULL,
    dt_atz timestamp without time zone NULL,
    CONSTRAINT "PK_mdfe_evento" PRIMARY KEY (id_geral),
    CONSTRAINT fk_mdfe_evento_filial FOREIGN KEY (cd_filial) REFERENCES filial (cd_filial) ON DELETE RESTRICT,
    CONSTRAINT fk_mdfe_evento_mdfe FOREIGN KEY (id_mdfe) REFERENCES mdfe (id_geral) ON DELETE RESTRICT
);

CREATE TABLE mdfe_percurso (
    cd_filial integer NOT NULL,
    id_geral integer NOT NULL,
    id_mdfe integer NOT NULL,
    nr_sequencia integer NOT NULL,
    uf character varying(2) NULL,
    dt_atz timestamp without time zone NULL,
    CONSTRAINT "PK_mdfe_percurso" PRIMARY KEY (id_geral),
    CONSTRAINT fk_mdfe_percurso_filial FOREIGN KEY (cd_filial) REFERENCES filial (cd_filial) ON DELETE RESTRICT,
    CONSTRAINT fk_mdfe_percurso_mdfe FOREIGN KEY (id_mdfe) REFERENCES mdfe (id_geral) ON DELETE RESTRICT
);

CREATE TABLE apontamento_de_servico (
    id integer NOT NULL,
    cd_filial integer NOT NULL,
    cd_funcionario integer NOT NULL,
    data date NOT NULL,
    hora_inicial time without time zone NOT NULL,
    hora_final time without time zone NOT NULL,
    descricao character varying(500) NULL,
    status integer NULL,
    dt_atz date NULL DEFAULT (CURRENT_DATE),
    nr_os integer NULL,
    CONSTRAINT "PK_apontamento_de_servico" PRIMARY KEY (cd_filial, id),
    CONSTRAINT fk_apontamento_de_servico_2 FOREIGN KEY (cd_filial, cd_funcionario) REFERENCES funcionario (cd_filial, cd_funcionario) ON DELETE RESTRICT,
    CONSTRAINT fk_apontamento_de_servico_1 FOREIGN KEY (cd_filial, nr_os) REFERENCES orcamento_c (cd_filial, nr_os) ON DELETE RESTRICT
);

CREATE TABLE auditor_estoque_c (
    cd_filial integer NOT NULL,
    id_geral integer NOT NULL,
    dt_hr_inicio timestamp without time zone NULL,
    dt_hr_finalizacao timestamp without time zone NULL,
    cd_usuario integer NULL,
    nr_os integer NULL,
    nr_pedido_compra integer NULL,
    CONSTRAINT "PK_auditor_estoque_c" PRIMARY KEY (cd_filial, id_geral),
    CONSTRAINT fk_auditorc_pedidoc FOREIGN KEY (nr_pedido_compra) REFERENCES pedido_c (nr_pedido) ON DELETE RESTRICT,
    CONSTRAINT fk_auditorc_orcamentoc FOREIGN KEY (cd_filial, nr_os) REFERENCES orcamento_c (cd_filial, nr_os) ON DELETE RESTRICT
);

CREATE TABLE orcamento_contato (
    cd_filial integer NOT NULL,
    nr_os integer NOT NULL,
    cd_contato integer NOT NULL,
    CONSTRAINT "PK_orcamento_contato" PRIMARY KEY (nr_os, cd_contato),
    CONSTRAINT fk_orcamento_contato_contato FOREIGN KEY (cd_contato) REFERENCES contato (id_contato) ON DELETE CASCADE,
    CONSTRAINT fk_orcamento_contato_orc FOREIGN KEY (cd_filial, nr_os) REFERENCES orcamento_c (cd_filial, nr_os) ON DELETE RESTRICT
);

CREATE TABLE cliente_contato (
    cd_cliente integer NOT NULL,
    cd_contato integer NOT NULL,
    cd_filial integer NOT NULL,
    CONSTRAINT "PK_cliente_contato" PRIMARY KEY (cd_cliente, cd_contato),
    CONSTRAINT fk_cliente_contato_contato FOREIGN KEY (cd_contato) REFERENCES contato (id_contato) ON DELETE CASCADE,
    CONSTRAINT fk_cliente_contato FOREIGN KEY (cd_filial, cd_cliente) REFERENCES cliente (cd_filial, cd_cliente) ON DELETE RESTRICT
);

CREATE TABLE cliente_entrega (
    id_geral integer NOT NULL,
    cd_cliente integer NOT NULL,
    nr_sequencia integer NOT NULL,
    nm_local character varying(80) NOT NULL,
    endereco_logradouro character varying(80) NULL,
    endereco_numero character varying(80) NULL,
    endereco_complemento character varying(20) NULL,
    bairro character varying(80) NULL,
    cep character varying(10) NULL,
    cd_cidade integer NULL,
    telefone character varying(20) NULL,
    fax character varying(20) NULL,
    celular character varying(20) NULL,
    e_mail character varying(80) NULL,
    obs text NULL,
    nr_autorizacao character varying(50) NULL,
    CONSTRAINT "PK_cliente_entrega" PRIMARY KEY (id_geral),
    CONSTRAINT fk_cliente_entrega_cidade FOREIGN KEY (cd_cidade) REFERENCES cidade (cd_cidade) ON DELETE RESTRICT,
    CONSTRAINT fk_cliente_entrega_cliente FOREIGN KEY (cd_cliente) REFERENCES cliente (cd_cliente) ON DELETE CASCADE
);

CREATE TABLE cliente_resumo_financeiro (
    cd_cliente integer NOT NULL,
    cd_filial integer NOT NULL,
    vl_limite numeric(15,2) NULL,
    vl_a_vencer numeric(15,2) NULL,
    vl_atrasado numeric(15,2) NULL,
    vl_cheque_pre numeric(15,2) NULL,
    dt_ultima_compra date NULL,
    dt_atz date NULL,
    CONSTRAINT "PK_cliente_resumo_financeiro" PRIMARY KEY (cd_cliente, cd_filial),
    CONSTRAINT fk_cliente_resumo_financeiro_cl FOREIGN KEY (cd_cliente) REFERENCES cliente (cd_cliente) ON DELETE CASCADE,
    CONSTRAINT fk_cliente_resumo_financeiro_fi FOREIGN KEY (cd_filial) REFERENCES filial_bd (cd_filial) ON DELETE CASCADE
);

CREATE TABLE clieveic (
    cd_filial integer NOT NULL,
    cd_cliente integer NOT NULL,
    placa_veiculo character varying(8) NOT NULL,
    fl_proprietario boolean NULL,
    nm_veiculo character varying(40) NOT NULL,
    ano_fabricacao integer NOT NULL,
    nr_frota character varying(11) NULL,
    obs text NULL,
    cor character varying(50) NULL,
    motor character varying(20) NULL,
    nr_chassi character varying(30) NULL,
    cd_montadora integer NOT NULL,
    dt_atz date NULL DEFAULT (CURRENT_DATE),
    renavan character varying(11) NULL,
    cd_veiculo integer NULL,
    CONSTRAINT "PK_clieveic" PRIMARY KEY (cd_filial, cd_cliente, placa_veiculo),
    CONSTRAINT fk_delcliente FOREIGN KEY (cd_filial, cd_cliente) REFERENCES cliente (cd_filial, cd_cliente) ON DELETE CASCADE,
    CONSTRAINT fk_veiccliente FOREIGN KEY (cd_filial, cd_montadora) REFERENCES veiculo (cd_filial, cd_veiculo) ON DELETE RESTRICT
);

CREATE TABLE movimento_seguradora (
    nr_documento integer NOT NULL,
    vl_franquia numeric(9,2) NULL,
    vl_abatido numeric(9,2) NULL,
    dt_atz date NULL DEFAULT (CURRENT_DATE),
    cd_seguradora integer NULL,
    cd_cliente integer NULL,
    nr_documento_origem integer NULL,
    nr_lcto integer NULL,
    cd_filial integer NOT NULL,
    cd_caixa integer NULL,
    CONSTRAINT "PK_movimento_seguradora" PRIMARY KEY (nr_documento),
    CONSTRAINT fk_movimento_seg_cliente FOREIGN KEY (cd_filial, cd_cliente) REFERENCES cliente (cd_filial, cd_cliente) ON DELETE RESTRICT,
    CONSTRAINT fk_movimento_seg_seguradora FOREIGN KEY (cd_filial, cd_seguradora) REFERENCES fornecedor (cd_filial, cd_fornecedor) ON DELETE RESTRICT,
    CONSTRAINT fk_movimento_seg_lcto FOREIGN KEY (cd_filial, cd_caixa, nr_lcto) REFERENCES movimento_cxa (cd_filial, cd_caixa, nr_lcto) ON DELETE RESTRICT
);

CREATE TABLE nfsc (
    cd_filial integer NOT NULL,
    nr_documento integer NOT NULL,
    nr_nf integer NULL,
    nr_cupom integer NULL,
    placa_veiculo character varying(8) NULL,
    kilometragem integer NULL,
    cd_clifor integer NOT NULL,
    cd_operacao integer NULL,
    dt_emissao date NOT NULL DEFAULT (CURRENT_DATE),
    vl_acrescimos numeric(18,4) NULL,
    vl_descontos numeric(18,4) NULL,
    vl_mercadorias numeric(18,4) NULL,
    vl_servicos numeric(18,4) NULL,
    vl_total numeric(18,4) NULL,
    cd_condpgto integer NULL,
    vl_entrada numeric(18,4) NULL,
    vl_acres_financeiro numeric(18,4) NULL,
    vl_financiado numeric(18,4) NULL,
    cd_cancelamento integer NOT NULL,
    peso_total double precision NULL,
    qt_pecas double precision NULL,
    obs text NULL,
    nr_ecf integer NULL,
    cd_natoper character varying(40) NULL,
    fl_cont_ncont character varying(1) NULL,
    cd_transportadora integer NULL,
    dt_lancamento date NOT NULL DEFAULT (CURRENT_DATE),
    dt_saida date NOT NULL DEFAULT (CURRENT_DATE),
    uf_origem character varying(2) NOT NULL,
    uf_destino character varying(2) NOT NULL,
    peso_liquido double precision NULL,
    vl_frete numeric(18,4) NULL,
    vl_seguro numeric(18,4) NULL,
    vl_base_icm numeric(18,4) NULL,
    vl_icm numeric(18,4) NULL,
    vl_base_icm_subst numeric(18,4) NULL,
    vl_icm_subst numeric(18,4) NULL,
    vl_ipi numeric(18,4) NULL,
    vl_iss numeric(18,4) NULL,
    tp_frete character varying(1) NULL,
    qt_volumes double precision NULL,
    especie_volumes character varying(15) NULL,
    marca_volumes character varying(15) NULL,
    nr_volumes double precision NULL,
    cd_usuario integer NOT NULL,
    vl_base_comissao numeric(18,4) NULL,
    vl_comissao numeric(18,4) NULL,
    fl_pago_frete character varying(1) NULL,
    fl_emprsimples character varying(1) NULL,
    fl_clisimples character varying(1) NULL,
    nr_os_ori integer NULL,
    dt_atz date NULL DEFAULT (CURRENT_DATE),
    vl_outros numeric(18,4) NULL,
    uf_placa_tansp character varying(2) NULL,
    placa_transp character varying(8) NULL,
    fl_controlar_estoque character varying(1) NULL,
    nr_sr bigint NULL,
    fl_cd_conta character varying(1) NULL,
    fl_ignorar_cxa_cta character varying(1) NOT NULL,
    fl_iss_retido character varying(1) NULL,
    vl_iss_subst numeric(18,4) NULL,
    nr_sequencial integer NULL,
    fl_transferencia boolean NOT NULL,
    total_cst text NULL,
    aliq_icm_frete double precision NULL,
    cd_impfiscal integer NULL,
    serie_nfs character varying(3) NULL,
    nsu character varying(10) NULL,
    base_icm_proprio_st numeric(18,4) NULL,
    vl_icm_proprio_st numeric(18,4) NULL,
    vl_base_pis numeric(18,4) NULL,
    vl_pis numeric(18,4) NULL,
    vl_base_cofins numeric(18,4) NULL,
    vl_cofins numeric(18,4) NULL,
    vl_base_ipi numeric(18,4) NULL,
    vl_base_iss numeric(18,4) NULL,
    vl_desconto_item numeric(18,4) NULL,
    vl_isento_itens numeric(18,4) NULL,
    vl_outros_itens numeric(18,4) NULL,
    obs2 text NULL,
    fl_complemento_icms character varying(1) NULL,
    alic_icm_simples numeric(5,2) NULL,
    vl_base_icm_simples numeric(18,4) NULL,
    vl_icm_simples numeric(18,4) NULL,
    nr_protocolo_nfe character varying(50) NULL,
    dt_processamento_nfe date NULL,
    status integer NULL,
    nr_lote_nfe character varying(15) NULL,
    nr_recibo_nfe character varying(15) NULL,
    nr_protocolo_canc_nfe character varying(15) NULL,
    chave_acesso_nfe character varying(44) NULL,
    ecf_coo integer NULL,
    ecf_mf_adicional character varying(1) NULL,
    hr_emissao time without time zone NULL,
    id_end_entrega integer NULL,
    cd_modelo character varying(3) NULL,
    id_nfec_devolucao integer NULL,
    fl_consumo character varying(1) NULL,
    vl_icm_frete numeric(18,4) NULL,
    cfop_frete character varying(10) NULL,
    nr_aidf character varying(20) NULL,
    conhecimento_vl_frete numeric(9,2) NULL,
    vl_base_icm_subst_ant numeric(9,2) NULL,
    vl_icm_subst_ant numeric(9,2) NULL,
    hr_processamento_nfe time without time zone NULL,
    dpec_id character varying(10) NULL,
    dpec_nr_registro character varying(14) NULL,
    dpec_dt_registro date NULL,
    dpec_hr_registro time without time zone NULL,
    cd_barras_adicional_nfe character varying(36) NULL,
    tp_emissao_nfe integer NULL,
    cd_cidade_embarque integer NULL,
    hash_nfsc_r4 character varying(70) NULL,
    hash_nfsc_r5 character varying(70) NULL,
    hash_nfsc_r7 character varying(70) NULL,
    cd_tabela_preco integer NULL,
    vl_icm_subst_dev numeric(18,4) NULL,
    vl_base_icm_subst_dev numeric(18,4) NULL,
    vl_base_ipi_dev numeric(18,4) NULL,
    vl_ipi_dev numeric(18,4) NULL,
    url_servico character varying(250) NULL,
    nr_rps integer NULL,
    vl_base_csll numeric(9,2) NULL,
    vl_csll numeric(9,2) NULL,
    vl_base_ir numeric(9,2) NULL,
    vl_ir numeric(9,2) NULL,
    vl_trib_nacional numeric(9,2) NULL,
    vl_trib_importado numeric(9,2) NULL,
    vl_trib_estadual numeric(9,2) NULL,
    vl_trib_municipal numeric(9,2) NULL,
    recinto_alfandegado character varying(60) NULL,
    vl_base_inss numeric(9,2) NULL,
    vl_inss numeric(9,2) NULL,
    vl_fcp numeric(13,2) NULL,
    vl_fcp_st numeric(13,2) NULL,
    vl_fcp_st_retido numeric(13,2) NULL,
    vl_icms_uf_dest numeric(13,2) NULL,
    vl_icms_uf_remet numeric(13,2) NULL,
    vl_fcp_uf_dest numeric(13,2) NULL,
    CONSTRAINT "PK_nfsc" PRIMARY KEY (cd_filial, nr_documento),
    CONSTRAINT fk_nfsc_impfiscal FOREIGN KEY (cd_impfiscal) REFERENCES impfiscal (cd_impfiscal) ON DELETE RESTRICT,
    CONSTRAINT fk_nfsc_cd_modelo FOREIGN KEY (cd_modelo) REFERENCES modelo_dcto (cd_modelo) ON DELETE RESTRICT,
    CONSTRAINT fk_nfsc_tabela_preco FOREIGN KEY (cd_tabela_preco) REFERENCES tabela_preco (cd_tabela_preco) ON DELETE RESTRICT,
    CONSTRAINT fk_nfsc_id_nfec_devolucao FOREIGN KEY (id_nfec_devolucao) REFERENCES nfec (id_geral) ON DELETE RESTRICT,
    CONSTRAINT fk_nfscliente FOREIGN KEY (cd_filial, cd_clifor) REFERENCES cliente (cd_filial, cd_cliente) ON DELETE RESTRICT
);

CREATE TABLE produto_cliente (
    cd_filial integer NOT NULL,
    cd_cliente integer NOT NULL,
    nr_sequencia integer NOT NULL,
    cd_produto character varying(15) NOT NULL,
    nr_serie character varying(32) NOT NULL,
    obs text NULL,
    ano_fabricacao integer NULL,
    ano_modelo integer NULL,
    data_aquisicao date NULL,
    cor character varying(250) NULL,
    num_chassi character varying(250) NULL,
    num_motor character varying(250) NULL,
    cd_combustivel character varying(2) NULL,
    num_transmissao character varying(100) NULL,
    serie_transmissao character varying(100) NULL,
    num_diferencial integer NULL,
    torre character varying(100) NULL,
    entrega_tecnica date NULL,
    CONSTRAINT "PK_produto_cliente" PRIMARY KEY (cd_filial, cd_cliente, nr_sequencia),
    CONSTRAINT fk_produto_cliente_combustivel FOREIGN KEY (cd_combustivel) REFERENCES veiculo_combustivel (cd_combustivel) ON DELETE RESTRICT,
    CONSTRAINT fk_produto_cliente_produto FOREIGN KEY (cd_produto) REFERENCES produto (cd_produto) ON DELETE RESTRICT,
    CONSTRAINT fk_produto_cliente_cliente FOREIGN KEY (cd_filial, cd_cliente) REFERENCES cliente (cd_filial, cd_cliente) ON DELETE CASCADE
);

CREATE TABLE propriedade (
    cd_propriedade integer NOT NULL,
    nm_propriedade character varying(60) NULL,
    endereco character varying(60) NULL,
    caixa_postal character varying(10) NULL,
    cep character varying(10) NULL,
    cd_cidade integer NULL,
    cnpj character varying(18) NULL,
    ie character varying(18) NULL,
    incra character varying(10) NULL,
    area double precision NULL,
    cd_contato integer NULL,
    telefone character varying(20) NULL,
    fax character varying(20) NULL,
    email character varying(70) NULL,
    cd_cliente integer NULL,
    cd_filial integer NULL,
    CONSTRAINT "PK_propriedade" PRIMARY KEY (cd_propriedade),
    CONSTRAINT fk_propriedade_cidade FOREIGN KEY (cd_cidade) REFERENCES cidade (cd_cidade) ON DELETE RESTRICT,
    CONSTRAINT fk_propriedade_contato FOREIGN KEY (cd_contato) REFERENCES contato (id_contato) ON DELETE CASCADE,
    CONSTRAINT fk_propriedade_cliente FOREIGN KEY (cd_filial, cd_cliente) REFERENCES cliente (cd_filial, cd_cliente) ON DELETE RESTRICT
);

CREATE TABLE auditor_estoque_i (
    cd_filial integer NOT NULL,
    id_auditor_c integer NOT NULL,
    nr_sequencial integer NOT NULL,
    cd_produto character varying(15) NULL,
    qt_atual numeric(15,4) NULL,
    qt_dif numeric(15,4) NULL,
    cd_usuario integer NULL,
    CONSTRAINT "PK_auditor_estoque_i" PRIMARY KEY (cd_filial, id_auditor_c, nr_sequencial),
    CONSTRAINT fk_auditori_auditorc FOREIGN KEY (cd_filial, id_auditor_c) REFERENCES auditor_estoque_c (cd_filial, id_geral) ON DELETE RESTRICT
);

CREATE TABLE nfc_frete (
    id_geral integer NOT NULL,
    nr_documento_nfsc integer NULL,
    id_nfec integer NULL,
    id_frete integer NOT NULL,
    cd_filial_nfsc integer NULL,
    pc_rateio double precision NULL,
    CONSTRAINT "PK_nfc_frete" PRIMARY KEY (id_geral),
    CONSTRAINT fk_nfc_frete_frete FOREIGN KEY (id_frete) REFERENCES nfec (id_geral) ON DELETE CASCADE,
    CONSTRAINT fk_nfc_frete_nfec FOREIGN KEY (id_nfec) REFERENCES nfec (id_geral) ON DELETE CASCADE,
    CONSTRAINT fk_nfc_frete_nfsc FOREIGN KEY (cd_filial_nfsc, nr_documento_nfsc) REFERENCES nfsc (cd_filial, nr_documento) ON DELETE CASCADE
);

CREATE TABLE nfsc_mensagem (
    id_geral integer NOT NULL,
    cd_filial integer NOT NULL,
    nr_documento integer NOT NULL,
    cd_mensagem integer NOT NULL,
    mensagem text NOT NULL,
    CONSTRAINT "PK_nfsc_mensagem" PRIMARY KEY (id_geral),
    CONSTRAINT fk_nfsc_mensagem_nota FOREIGN KEY (cd_mensagem) REFERENCES mensagem_nota (cd_mensagem) ON DELETE RESTRICT,
    CONSTRAINT fk_nfsc_mensagem_nfsc FOREIGN KEY (cd_filial, nr_documento) REFERENCES nfsc (cd_filial, nr_documento) ON DELETE CASCADE
);

CREATE TABLE nfsi (
    cd_filial integer NOT NULL,
    nr_documento integer NOT NULL,
    nr_sequencia integer NOT NULL,
    cd_prodserv character varying(15) NOT NULL,
    nm_prodserv character varying(60) NULL,
    fl_servico character varying(1) NULL,
    qt_produto double precision NULL,
    vl_bruto numeric(18,8) NULL,
    pc_desconto numeric(9,2) NULL,
    vl_liquido numeric(18,8) NULL,
    vl_total numeric(18,4) NULL,
    preco_minimo numeric(18,4) NULL,
    cd_funcionario integer NOT NULL,
    dt_emissao date NOT NULL DEFAULT (CURRENT_DATE),
    peso_liquido double precision NULL,
    cd_cancelamento integer NULL,
    cst character varying(4) NULL,
    pc_red_base_icm numeric(9,2) NULL,
    alic_icm numeric(9,2) NULL,
    alic_icm_subst numeric(9,2) NULL,
    alic_ipi numeric(9,2) NULL,
    alic_iss numeric(9,2) NULL,
    vl_base_icm numeric(18,4) NULL,
    vl_icm numeric(18,4) NULL,
    vl_icm_subst numeric(18,4) NULL,
    vl_ipi numeric(18,4) NULL,
    vl_iss numeric(18,4) NULL,
    fl_tributacao_inf character varying(1) NULL,
    vl_base_comissao numeric(18,4) NULL,
    vl_comissao numeric(18,4) NULL,
    pc_comissao numeric(9,2) NULL,
    fl_comissao_inf character varying(1) NULL,
    compl text NULL,
    dt_atz date NULL DEFAULT (CURRENT_DATE),
    un character varying(6) NULL,
    fl_controlar_estoque character varying(1) NULL,
    placa_veiculo character varying(8) NULL,
    kilometragem integer NULL,
    fl_classfiscal character varying(5) NULL,
    cd_conta integer NULL,
    vl_iss_subst numeric(18,4) NULL,
    fl_composto character varying(1) NULL,
    composicao text NULL,
    vl_base_icm_subst numeric(18,4) NULL,
    vl_frete_rateado numeric(18,4) NULL,
    alic_uf_destino numeric(18,4) NULL,
    cfop character varying(10) NULL,
    vl_desconto numeric(18,4) NULL,
    vl_desconto_rateado numeric(18,4) NULL,
    vl_acrescimo_rateado numeric(18,4) NULL,
    vl_seguro_rateado numeric(18,4) NULL,
    vl_contabil numeric(18,4) NULL,
    vl_outros numeric(18,4) NULL,
    vl_isento numeric(18,4) NULL,
    alic_pis numeric(18,4) NULL,
    vl_base_pis numeric(18,4) NULL,
    vl_pis numeric(18,4) NULL,
    alic_cofins numeric(18,4) NULL,
    vl_base_cofins numeric(18,4) NULL,
    vl_cofins numeric(18,4) NULL,
    vl_base_iss numeric(18,4) NULL,
    vl_base_ipi numeric(18,4) NULL,
    iat character varying(1) NULL,
    pc_acrescimo numeric(9,2) NULL,
    pc_red_base_icm_proprio_st numeric(6,2) NULL,
    pc_red_base_icm_subst numeric(6,2) NULL,
    alic_icm_proprio_st numeric(18,4) NULL,
    vl_base_icm_proprio_st numeric(18,4) NULL,
    vl_icm_proprio_st numeric(18,4) NULL,
    vl_acrescimo numeric(18,4) NULL,
    fator_conversao double precision NULL,
    qt_venda double precision NULL,
    un_venda character varying(6) NULL,
    vl_liquido_venda numeric(18,8) NULL,
    cst_ipi character varying(2) NULL,
    cst_pis character varying(2) NULL,
    cst_cofins character varying(2) NULL,
    tp_operacao_veic_novo integer NULL,
    vl_icm_frete numeric(18,4) NULL,
    conhecimento_vl_frete numeric(9,2) NULL,
    vl_base_icm_subst_ant numeric(9,2) NULL,
    vl_icm_subst_ant numeric(9,2) NULL,
    nr_sequencia_os_ori integer NULL,
    fl_soma_total character varying(1) NULL,
    hash_nfsi_r5 character varying(70) NULL,
    vl_icm_subst_dev numeric(18,4) NULL,
    vl_base_icm_subst_dev numeric(18,4) NULL,
    alic_icm_subst_dev numeric(18,4) NULL,
    pc_red_base_icm_subst_dev numeric(18,4) NULL,
    vl_base_ipi_dev numeric(18,4) NULL,
    vl_ipi_dev numeric(18,4) NULL,
    alic_ipi_dev numeric(18,4) NULL,
    mva_dev numeric(18,4) NULL,
    cd_fci character varying(36) NULL,
    alic_csll numeric(9,2) NULL,
    alic_irrf numeric(9,2) NULL,
    vl_base_csll numeric(9,2) NULL,
    vl_csll numeric(9,2) NULL,
    vl_base_ir numeric(9,2) NULL,
    vl_ir numeric(9,2) NULL,
    vl_trib_nacional numeric(9,2) NULL,
    vl_trib_importado numeric(9,2) NULL,
    vl_trib_estadual numeric(9,2) NULL,
    vl_trib_municipal numeric(9,2) NULL,
    vl_base_inss numeric(9,2) NULL,
    vl_inss numeric(9,2) NULL,
    nr_sequencia_dev integer NULL,
    nm_cest character varying(7) NULL,
    nm_class_fiscal character varying(10) NULL,
    cd_ped_comp character varying(15) NULL,
    nr_item_ped_comp integer NULL,
    un_trib character varying(6) NULL,
    vl_trib numeric(18,8) NULL,
    qt_trib double precision NULL,
    pc_fcp numeric(4,4) NULL,
    vl_fcp numeric(13,2) NULL,
    vl_base_fcp numeric(13,2) NULL,
    vl_base_fcp_st numeric(13,2) NULL,
    pc_fcp_st numeric(4,4) NULL,
    vl_fcp_st numeric(13,2) NULL,
    vl_fcp_st_retido numeric(13,2) NULL,
    pc_fcp_st_retido numeric(4,4) NULL,
    vl_base_fcp_st_retido numeric(13,2) NULL,
    vl_base_fcp_uf_destino numeric(13,2) NULL,
    pc_fcp_uf_destino numeric(4,4) NULL,
    vl_fcp_uf_destino numeric(13,2) NULL,
    vl_base_uf_destino numeric(13,2) NULL,
    pc_icms_uf_destino numeric(4,4) NULL,
    pc_icms_interno numeric(2,2) NULL,
    pc_icms_interno_partilha numeric(4,4) NULL,
    vl_icms_uf_destino numeric(13,2) NULL,
    vl_icms_uf_remetente numeric(13,2) NULL,
    CONSTRAINT "PK_nfsi" PRIMARY KEY (cd_filial, nr_documento, nr_sequencia),
    CONSTRAINT fk_nfsi_cxa_conta FOREIGN KEY (cd_conta) REFERENCES cxa_conta (cd_conta) ON DELETE RESTRICT,
    CONSTRAINT fk_nfsi_nfsc FOREIGN KEY (cd_filial, nr_documento) REFERENCES nfsc (cd_filial, nr_documento) ON DELETE CASCADE
);

CREATE TABLE veiculo_despesas (
    cd_filial integer NOT NULL,
    cd_produto character varying(15) NOT NULL,
    nr_sequencial integer NOT NULL,
    dt_compra date NULL,
    vl_compra numeric(18,4) NULL,
    vl_frete numeric(18,4) NULL,
    vl_servicos numeric(18,4) NULL,
    vl_pecas numeric(18,4) NULL,
    vl_serv_terceiros numeric(18,4) NULL,
    vl_despachante numeric(18,4) NULL,
    vl_comissao numeric(18,4) NULL,
    observacao text NULL,
    custo_total numeric(18,4) NULL,
    vl_compra_real numeric(18,4) NULL,
    vl_venda_real numeric(18,4) NULL,
    dcto_venda integer NULL,
    vl_ipva numeric(18,4) NULL,
    id_nfei integer NULL,
    CONSTRAINT "PK_veiculo_despesas" PRIMARY KEY (cd_filial, cd_produto, nr_sequencial),
    CONSTRAINT fk_veiculo_despesas_nfei FOREIGN KEY (id_nfei) REFERENCES nfei (id_geral) ON DELETE CASCADE,
    CONSTRAINT fk_veiculo_despesas_nfs FOREIGN KEY (cd_filial, dcto_venda) REFERENCES nfsc (cd_filial, nr_documento) ON DELETE CASCADE
);

CREATE TABLE cliente_propriedade (
    cd_filial integer NOT NULL,
    cd_cliente integer NOT NULL,
    cd_propriedade integer NOT NULL,
    CONSTRAINT "PK_cliente_propriedade" PRIMARY KEY (cd_filial, cd_cliente, cd_propriedade),
    CONSTRAINT fk_cliente_propriedade_propried FOREIGN KEY (cd_propriedade) REFERENCES propriedade (cd_propriedade) ON DELETE RESTRICT,
    CONSTRAINT fk_cliente_propriedade_cliente FOREIGN KEY (cd_filial, cd_cliente) REFERENCES cliente (cd_filial, cd_cliente) ON DELETE RESTRICT
);

CREATE TABLE receita_agro (
    dt_emissao date NULL,
    nr_art integer NULL,
    nr_receita integer NOT NULL,
    nr_sequencia integer NOT NULL,
    serie_nf character varying(3) NULL,
    cd_cliente integer NULL,
    cd_propriedade integer NULL,
    cd_prodserv integer NOT NULL,
    cultura character varying(100) NULL,
    diagnostico text NULL,
    area numeric(15,3) NULL,
    epoca_aplicacao character varying(80) NULL,
    modalidade_aplicacao integer NULL,
    intervalo_seg character varying(80) NULL,
    dosagem character varying(15) NULL,
    volume_calda character varying(21) NULL,
    qt_total numeric(15,2) NOT NULL,
    precaucao text NULL,
    epis text NULL,
    orientacao text NULL,
    cd_agronomo integer NULL,
    qt_aplicacao character varying(20) NULL,
    nr_nf integer NOT NULL,
    cd_filial integer NOT NULL,
    CONSTRAINT "PK_receita_agro" PRIMARY KEY (cd_filial, nr_nf, nr_sequencia, nr_receita),
    CONSTRAINT fk_receita_agro_propriedade FOREIGN KEY (cd_propriedade) REFERENCES propriedade (cd_propriedade) ON DELETE CASCADE,
    CONSTRAINT fk_receita_agro_cliente FOREIGN KEY (cd_filial, cd_cliente) REFERENCES cliente (cd_filial, cd_cliente) ON DELETE CASCADE
);

CREATE TABLE lcto_flex (
    id_geral integer NOT NULL,
    cd_vendedor integer NOT NULL,
    dt_lcto date NOT NULL DEFAULT (CURRENT_DATE),
    valor numeric(15,2) NOT NULL,
    fl_deb_cred character varying(1) NOT NULL,
    obs text NULL,
    nr_documento integer NULL,
    cd_filial integer NOT NULL,
    nr_sequencia integer NULL,
    CONSTRAINT "PK_lcto_flex" PRIMARY KEY (id_geral),
    CONSTRAINT fk_lcto_flex_filial FOREIGN KEY (cd_filial) REFERENCES filial (cd_filial) ON DELETE RESTRICT,
    CONSTRAINT fk_lcto_flex_funcionario FOREIGN KEY (cd_filial, cd_vendedor) REFERENCES funcionario (cd_filial, cd_funcionario) ON DELETE RESTRICT,
    CONSTRAINT fk_lcto_flex_nfsi FOREIGN KEY (cd_filial, nr_documento, nr_sequencia) REFERENCES nfsi (cd_filial, nr_documento, nr_sequencia) ON DELETE CASCADE
);

CREATE TABLE nfsi_cupom (
    cd_filial integer NOT NULL,
    nr_documento integer NOT NULL,
    nr_sequencia integer NOT NULL,
    vl_base_icm numeric(14,2) NULL,
    alic_icm double precision NULL,
    pc_red_base_icm double precision NULL,
    vl_icm numeric(14,2) NULL,
    vl_base_icm_proprio_st numeric(14,2) NULL,
    alic_icm_proprio_st double precision NULL,
    pc_red_base_icm_proprio_st double precision NULL,
    vl_icm_proprio_st numeric(14,2) NULL,
    vl_base_icm_subst numeric(14,2) NULL,
    alic_icm_subst double precision NULL,
    pc_red_base_icm_subst double precision NULL,
    mva double precision NULL,
    vl_icm_subst numeric(14,2) NULL,
    cst character varying(4) NULL,
    tp_imposto_ecf integer NULL,
    cfop character varying(10) NULL,
    hash_nfsi_cupom_r5 character varying(70) NULL,
    CONSTRAINT "PK_nfsi_cupom" PRIMARY KEY (cd_filial, nr_documento, nr_sequencia),
    CONSTRAINT fk_nfsi_cupom_nfsi FOREIGN KEY (cd_filial, nr_documento, nr_sequencia) REFERENCES nfsi (cd_filial, nr_documento, nr_sequencia) ON DELETE CASCADE
);

CREATE INDEX "IX_acesso_acao_perfil_id_acesso_acao" ON acesso_acao_perfil (id_acesso_acao);

CREATE INDEX "IX_acesso_acao_rel_campo_id_acao" ON acesso_acao_rel_campo (id_acao);

CREATE UNIQUE INDEX unq_acesso_acao_rel_filtro_orde ON acesso_acao_rel_filtro (id_acao, nr_ordem);

CREATE INDEX "IX_acesso_acao_usuario_id_acesso_acao" ON acesso_acao_usuario (id_acesso_acao);

CREATE INDEX "IX_acesso_menu_id_menu_pai" ON acesso_menu (id_menu_pai);

CREATE INDEX "IX_administradora_conta_caixa" ON administradora (conta_caixa);

CREATE INDEX "IX_administradora_id_bandeira" ON administradora (id_bandeira);

CREATE INDEX "IX_agenda_cd_situacao" ON agenda (cd_situacao);

CREATE INDEX idx_agenda_data ON agenda (dt_hr_evento);

CREATE INDEX idx_agenda_situacao_nome ON agenda_situacao (nm_situacao);

CREATE INDEX "IX_agronomo_cd_cidade" ON agronomo (cd_cidade);

CREATE INDEX alteracao_cad_item_idx1 ON alteracao_cad_item (cd_item);

CREATE INDEX "IX_apontamento_de_servico_cd_filial_cd_funcionario" ON apontamento_de_servico (cd_filial, cd_funcionario);

CREATE INDEX "IX_apontamento_de_servico_cd_filial_nr_os" ON apontamento_de_servico (cd_filial, nr_os);

CREATE INDEX "IX_auditor_estoque_c_nr_pedido_compra" ON auditor_estoque_c (nr_pedido_compra);

CREATE INDEX "IX_auditor_estoque_c_cd_filial_nr_os" ON auditor_estoque_c (cd_filial, nr_os);

CREATE INDEX "IX_caixa_cd_conta_contabil" ON caixa (cd_conta_contabil);

CREATE INDEX "IX_cargo_cd_filial" ON cargo (cd_filial);

CREATE UNIQUE INDEX unq1_carta_correcao ON carta_correcao (id_nf, fl_ent_sai, sequencia);

CREATE UNIQUE INDEX unq1_carta_correcao_hist ON carta_correcao_hist (id_carta_correcao, nm_tabela, nm_campo, cd_mensagem, nr_sequencia_item);

CREATE INDEX ind_cd_cidade ON cidade (cd_cidade);

CREATE INDEX "IX_cidade_cd_regiao" ON cidade (cd_regiao);

CREATE INDEX ind_nm_cidade ON cidade (nm_cidade);

CREATE INDEX ind_cliecidade ON cliente (cd_cidade);

CREATE UNIQUE INDEX unq_cliente_codigo ON cliente (cd_cliente);

CREATE INDEX "IX_cliente_cd_conta_contabil" ON cliente (cd_conta_contabil);

CREATE INDEX ind_cliente_cgc_cpf ON cliente (cgc_cpf);

CREATE INDEX ind_nm_cliente ON cliente (nm_clifor);

CREATE INDEX "IX_cliente_cd_filial_cd_vendedor" ON cliente (cd_filial, cd_vendedor);

CREATE INDEX "IX_cliente_contato_cd_contato" ON cliente_contato (cd_contato);

CREATE INDEX "IX_cliente_contato_cd_filial_cd_cliente" ON cliente_contato (cd_filial, cd_cliente);

CREATE INDEX "IX_cliente_entrega_cd_cidade" ON cliente_entrega (cd_cidade);

CREATE UNIQUE INDEX unq1_cliente_entrega ON cliente_entrega (cd_cliente, nr_sequencia);

CREATE UNIQUE INDEX idx_nm_grupo_cliente ON cliente_grupo (nm_grupo_cliente);

CREATE INDEX "IX_cliente_propriedade_cd_propriedade" ON cliente_propriedade (cd_propriedade);

CREATE INDEX "IX_cliente_resumo_financeiro_cd_filial" ON cliente_resumo_financeiro (cd_filial);

CREATE INDEX idx_placa ON clieveic (placa_veiculo);

CREATE INDEX "IX_clieveic_cd_filial_cd_montadora" ON clieveic (cd_filial, cd_montadora);

CREATE INDEX "IX_cob_bordero_cd_convenio" ON cob_bordero (cd_convenio);

CREATE INDEX cob_bordero_idx ON cob_bordero (dt_cadastro);

CREATE INDEX "IX_cob_bordero_parcela_cd_bordero" ON cob_bordero_parcela (cd_bordero);

CREATE UNIQUE INDEX unq_cob_convenio_atributo ON cob_convenio_atributo (cd_convenio, nm_campo);

CREATE UNIQUE INDEX cob_convenio_forma_pgto_idx ON cob_convenio_forma_pgto (cd_convenio, cd_forma_pgto, cd_filial, nr_carteira);

CREATE UNIQUE INDEX cob_motivo_mvto_retorno_idx ON cob_motivo_movimento_retorno (cd_motivo, cd_convenio);

CREATE UNIQUE INDEX unq_cob_movimento_retorno ON cob_movimento_retorno (cd_movimento, cd_convenio);

CREATE INDEX "IX_cob_parcela_cd_convenio" ON cob_parcela (cd_convenio);

CREATE UNIQUE INDEX unq_cob_parcela_id_origem ON cob_parcela (id_sistema_origem);

CREATE INDEX "IX_cob_retorno_cd_filial" ON cob_retorno (cd_filial);

CREATE UNIQUE INDEX cob_retorno_nr_retorno_idx ON cob_retorno (nr_retorno);

CREATE INDEX "IX_cob_retorno_parcela_cd_retorno" ON cob_retorno_parcela (cd_retorno);

CREATE UNIQUE INDEX cob_retorno_parcela_idx ON cob_retorno_parcela (nr_nosso_numero, cd_retorno, cd_movimento_retorno);

CREATE INDEX "IX_comissao_cd_grupo_comissao" ON comissao (cd_grupo_comissao);

CREATE INDEX "IX_comissao_cd_filial_cd_funcionario" ON comissao (cd_filial, cd_funcionario);

CREATE INDEX ind_comissao_func_doc ON comissao_func (nr_documento);

CREATE INDEX "IX_comissao_func_dev_id_nfec_dev" ON comissao_func_dev (id_nfec_dev);

CREATE INDEX "IX_conf_sped_pis_cofins_cd_filial" ON conf_sped_pis_cofins (cd_filial);

CREATE INDEX "IX_consulta_id_acao_cadastro" ON consulta (id_acao_cadastro);

CREATE UNIQUE INDEX unq_consulta_id ON consulta (identificador);

CREATE UNIQUE INDEX unq_consulta_campo ON consulta_campo (id_consulta, nm_campo);

CREATE INDEX "IX_contato_cd_cidade" ON contato (cd_cidade);

CREATE INDEX idx_crptitulo_cliente ON crptitulo (cd_clifor);

CREATE INDEX "IX_crptitulo_cd_conta" ON crptitulo (cd_conta);

CREATE INDEX crptitulo_idx_nr_documento ON crptitulo (nr_documento);

CREATE INDEX ind_crptitulo_numero ON crptitulo (nr_titulo);

CREATE INDEX crptitulo_idx_nr_reparcelado ON crptitulo (nr_titulo_reparcelado);

CREATE INDEX idx_crptitulo_nr_nf ON crptitulo (cd_tipo_conta, nr_documento, nr_nf_ecf, nr_sequencial);

CREATE INDEX "IX_crptitulo_funcionario_cd_filial_cd_funcionario" ON crptitulo_funcionario (cd_filial, cd_funcionario);

CREATE INDEX "IX_crptitulo_movimento_cxa_cd_filial_cd_caixa_nr_lcto" ON crptitulo_movimento_cxa (cd_filial, cd_caixa, nr_lcto);

CREATE INDEX crptitulo_movimento_cxa_cnc ON crptitulo_movimento_cxa (cd_filial, nr_lcto, cd_caixa);

CREATE INDEX crptitulo_movimento_cxa_cccnp ON crptitulo_movimento_cxa (cd_filial, cd_tipo_conta, cd_clifor, nr_titulo, parcela);

CREATE INDEX "IX_cst_cd_mensagem" ON cst (cd_mensagem);

CREATE INDEX idx_custcomp_produto ON custcomp (cd_produto);

CREATE INDEX "IX_custcomp_id_nfei" ON custcomp (id_nfei);

CREATE INDEX "IX_cxa_conta_cd_conta_contabil" ON cxa_conta (cd_conta_contabil);

CREATE INDEX "IX_doc_nao_fiscal_c_cd_ecf" ON doc_nao_fiscal_c (cd_ecf);

CREATE INDEX "IX_doc_nao_fiscal_i_id_doc_nao_fiscal" ON doc_nao_fiscal_i (id_doc_nao_fiscal);

CREATE INDEX "IX_doc_producao_cd_filial" ON doc_producao (cd_filial);

CREATE INDEX ind_local_estocagem ON estocagem (local_estocagem);

CREATE INDEX idx_estoque_ano ON estoque (ano);

CREATE INDEX "IX_estoque_cd_produto" ON estoque (cd_produto);

CREATE INDEX idx_estoque_mes ON estoque (mes);

CREATE INDEX ind_estoque_chave ON estoque (ano, cd_filial, cd_produto, mes);

CREATE INDEX "IX_filial_cd_conta" ON filial (cd_conta);

CREATE INDEX "IX_filial_cd_mensagem_cupom" ON filial (cd_mensagem_cupom);

CREATE INDEX "IX_filial_cd_mensagem_dav" ON filial (cd_mensagem_dav);

CREATE INDEX "IX_filial_cd_mensagem_icm_st_nota_dev" ON filial (cd_mensagem_icm_st_nota_dev);

CREATE INDEX "IX_filial_cd_mensagem_pre_venda" ON filial (cd_mensagem_pre_venda);

CREATE INDEX "IX_filial_cd_tabela_preco_padrao" ON filial (cd_tabela_preco_padrao);

CREATE UNIQUE INDEX unq1_filial_email ON filial_email (cd_filial, tp_email);

CREATE INDEX "IX_fornecedor_cd_conta_contabil" ON fornecedor (cd_conta_contabil);

CREATE INDEX "IX_fornecedor_contato_cd_contato" ON fornecedor_contato (cd_contato);

CREATE INDEX "IX_fornecedor_contato_cd_filial_cd_fornecedor" ON fornecedor_contato (cd_filial, cd_fornecedor);

CREATE INDEX "IX_fornveic_cd_filial_cd_fornecedor" ON fornveic (cd_filial, cd_fornecedor);

CREATE INDEX "IX_fornveic_cd_filial_cd_veiculo" ON fornveic (cd_filial, cd_veiculo);

CREATE UNIQUE INDEX unq_fornveic ON fornveic (cd_fornecedor, cd_veiculo, placa_veiculo);

CREATE INDEX "IX_frente_caixa_cd_operacao" ON frente_caixa (cd_operacao);

CREATE INDEX "IX_frente_caixa_cd_tabela_preco" ON frente_caixa (cd_tabela_preco);

CREATE INDEX "IX_funcionario_cd_cargo_cd_filial" ON funcionario (cd_cargo, cd_filial);

CREATE INDEX "IX_help_atz_alteracao_id_help_atz" ON help_atz_alteracao (id_help_atz);

CREATE INDEX "IX_lcto_flex_cd_filial_cd_vendedor" ON lcto_flex (cd_filial, cd_vendedor);

CREATE INDEX "IX_lcto_flex_cd_filial_nr_documento_nr_sequencia" ON lcto_flex (cd_filial, nr_documento, nr_sequencia);

CREATE INDEX "IX_mdfe_cd_cidade_carregamento" ON mdfe (cd_cidade_carregamento);

CREATE INDEX "IX_mdfe_cd_modelo" ON mdfe (cd_modelo);

CREATE INDEX "IX_mdfe_nr_serie" ON mdfe (nr_serie);

CREATE INDEX "IX_mdfe_cd_filial_cd_proprietario_veiculo" ON mdfe (cd_filial, cd_proprietario_veiculo);

CREATE INDEX "IX_mdfe_cd_filial_id_fornveic" ON mdfe (cd_filial, id_fornveic);

CREATE UNIQUE INDEX unq_mdfe ON mdfe (cd_filial, cd_modelo, nr_serie, nr_mdf);

CREATE INDEX "IX_mdfe_condutor_cd_motorista" ON mdfe_condutor (cd_motorista);

CREATE INDEX "IX_mdfe_condutor_id_mdfe" ON mdfe_condutor (id_mdfe);

CREATE INDEX "IX_mdfe_condutor_cd_filial_cd_fornecedor" ON mdfe_condutor (cd_filial, cd_fornecedor);

CREATE INDEX "IX_mdfe_documento_cd_filial" ON mdfe_documento (cd_filial);

CREATE INDEX "IX_mdfe_documento_id_mdfe" ON mdfe_documento (id_mdfe);

CREATE INDEX "IX_mdfe_evento_cd_filial" ON mdfe_evento (cd_filial);

CREATE INDEX "IX_mdfe_evento_id_mdfe" ON mdfe_evento (id_mdfe);

CREATE INDEX "IX_mdfe_percurso_cd_filial" ON mdfe_percurso (cd_filial);

CREATE UNIQUE INDEX unq_mdfe_percurso ON mdfe_percurso (id_mdfe, nr_sequencia);

CREATE INDEX "IX_motorista_cd_cidade" ON motorista (cd_cidade);

CREATE INDEX "IX_motorista_cd_filial_cd_transportador" ON motorista (cd_filial, cd_transportador);

CREATE INDEX idx_movimento_cd_caixa ON movimento_cxa (cd_caixa);

CREATE INDEX idx_mvto_cxa_cliente ON movimento_cxa (cd_clifor);

CREATE INDEX "IX_movimento_cxa_cd_conta" ON movimento_cxa (cd_conta);

CREATE INDEX idx_movimento_cd_historico ON movimento_cxa (cd_historico);

CREATE INDEX idx_movimento_cxa_ori ON movimento_cxa (dcto_origem);

CREATE INDEX ind_movimento_cxa_nr_documento ON movimento_cxa (nr_documento);

CREATE INDEX ind_movimento_cxa_max ON movimento_cxa (nr_lcto);

CREATE INDEX ind_movimento_cxa_chave ON movimento_cxa (cd_caixa, cd_filial, nr_lcto);

CREATE INDEX "IX_movimento_seguradora_cd_filial_cd_cliente" ON movimento_seguradora (cd_filial, cd_cliente);

CREATE INDEX "IX_movimento_seguradora_cd_filial_cd_seguradora" ON movimento_seguradora (cd_filial, cd_seguradora);

CREATE INDEX "IX_movimento_seguradora_cd_filial_cd_caixa_nr_lcto" ON movimento_seguradora (cd_filial, cd_caixa, nr_lcto);

CREATE INDEX "IX_msggrupo_cd_mensagem" ON msggrupo (cd_mensagem);

CREATE INDEX nf_contabil_c_idx_nfsc ON nf_contabil_c (id_nfc, fl_entrada_saida);

CREATE UNIQUE INDEX unq_nf_contabil_c ON nf_contabil_c (cd_filial, nr_nf, nr_cupom, cd_clifor, serie_nf, fl_entrada_saida, ecf_cd);

CREATE UNIQUE INDEX unq_nf_contabil_cfop ON nf_contabil_cfop (id_nf_contabil_c, cst, cfop, imposto_aliq, imposto_tipo);

CREATE INDEX nf_contabil_i_id_nf_contabil_c ON nf_contabil_i (id_nf_contabil_c);

CREATE UNIQUE INDEX unq_nf_contabil_i ON nf_contabil_i (id_nf_contabil_c, nr_sequencia);

CREATE UNIQUE INDEX unq1_nf_referenciada ON nf_referenciada (fl_entrada_saida, nr_documento, fl_entrada_saida_ref, nr_documento_ref);

CREATE INDEX "IX_nfc_frete_id_frete" ON nfc_frete (id_frete);

CREATE INDEX "IX_nfc_frete_id_nfec" ON nfc_frete (id_nfec);

CREATE INDEX "IX_nfc_frete_cd_filial_nfsc_nr_documento_nfsc" ON nfc_frete (cd_filial_nfsc, nr_documento_nfsc);

CREATE INDEX idx_nfec_clifor ON nfec (cd_clifor);

CREATE INDEX "IX_nfec_cd_conta" ON nfec (cd_conta);

CREATE INDEX idx_nfec_nr_dcto_devolucao ON nfec (nr_dcto_devolucao);

CREATE INDEX "IX_nfec_nr_pedido" ON nfec (nr_pedido);

CREATE UNIQUE INDEX unq1_nfec ON nfec (cd_filial, nr_dcto, cd_clifor, fl_impresso, serie_nf);

CREATE INDEX "IX_nfec_importacao_id_nfec" ON nfec_importacao (id_nfec);

CREATE INDEX "IX_nfec_mensagem_cd_mensagem" ON nfec_mensagem (cd_mensagem);

CREATE INDEX "IX_nfec_mensagem_id_nfec" ON nfec_mensagem (id_nfec);

CREATE INDEX "IX_nfei_cd_conta" ON nfei (cd_conta);

CREATE INDEX "IX_nfei_cd_prodserv" ON nfei (cd_prodserv);

CREATE INDEX "IX_nfei_id_nfec" ON nfei (id_nfec);

CREATE INDEX "IX_nfei_importacao_id_nfei" ON nfei_importacao (id_nfei);

CREATE INDEX idx_nfsc_cancelamento ON nfsc (cd_cancelamento);

CREATE INDEX idx_nfsc_cliente ON nfsc (cd_clifor);

CREATE INDEX ind_nfsc_filial ON nfsc (cd_filial);

CREATE INDEX "IX_nfsc_cd_impfiscal" ON nfsc (cd_impfiscal);

CREATE INDEX "IX_nfsc_cd_modelo" ON nfsc (cd_modelo);

CREATE INDEX "IX_nfsc_cd_tabela_preco" ON nfsc (cd_tabela_preco);

CREATE INDEX idx_nfsc_data ON nfsc (dt_emissao);

CREATE INDEX "IX_nfsc_id_nfec_devolucao" ON nfsc (id_nfec_devolucao);

CREATE INDEX ind_nfsc_doc ON nfsc (nr_documento);

CREATE INDEX idx_nfsc_nr_sequencial ON nfsc (nr_sequencial);

CREATE INDEX "IX_nfsc_cd_filial_cd_clifor" ON nfsc (cd_filial, cd_clifor);

CREATE INDEX nfsc_chave ON nfsc (cd_filial, nr_documento);

CREATE INDEX idx_nr_nf ON nfsc (cd_filial, nr_nf);

CREATE INDEX idx_nfsc_os ON nfsc (cd_filial, nr_os_ori);

CREATE UNIQUE INDEX nfsc_idx_documento_filial ON nfsc (nr_documento, cd_filial);

CREATE INDEX "IX_nfsc_mensagem_cd_mensagem" ON nfsc_mensagem (cd_mensagem);

CREATE INDEX "IX_nfsc_mensagem_cd_filial_nr_documento" ON nfsc_mensagem (cd_filial, nr_documento);

CREATE INDEX "IX_nfsi_cd_conta" ON nfsi (cd_conta);

CREATE INDEX ind_cd_filial ON nfsi (cd_filial);

CREATE INDEX idx_cd_prodserv ON nfsi (cd_prodserv);

CREATE INDEX ind_nfsi_doc ON nfsi (nr_documento);

CREATE INDEX ind_nfsi_chave ON nfsi (cd_filial, nr_documento, nr_sequencia);

CREATE INDEX "IX_nsu_produto_negativo_id_nsu" ON nsu_produto_negativo (id_nsu);

CREATE INDEX "IX_operacao_cfop_regra_cd_cfop_regra" ON operacao_cfop_regra (cd_cfop_regra);

CREATE UNIQUE INDEX unq1_operacao_cfop_regra ON operacao_cfop_regra (cd_operacao, cd_cfop_regra);

CREATE INDEX "IX_operacao_es_cd_bc_cred_piscofins" ON operacao_es (cd_bc_cred_piscofins);

CREATE INDEX "IX_operacao_es_cd_conta_movimento" ON operacao_es (cd_conta_movimento);

CREATE INDEX "IX_operacao_es_cd_grupo_op" ON operacao_es (cd_grupo_op);

CREATE INDEX "IX_operacao_es_cd_mensagem" ON operacao_es (cd_mensagem);

CREATE INDEX "IX_operacao_es_cd_modelo" ON operacao_es (cd_modelo);

CREATE INDEX "IX_operacao_es_cd_tp_cred_piscofins" ON operacao_es (cd_tp_cred_piscofins);

CREATE INDEX "IX_operacao_es_id_tributacao_grupo" ON operacao_es (id_tributacao_grupo);

CREATE INDEX "IX_operacao_es_id_tributacao_grupo_pis_cofins" ON operacao_es (id_tributacao_grupo_pis_cofins);

CREATE INDEX "IX_orcamento_c_cd_situacao" ON orcamento_c (cd_situacao);

CREATE INDEX "IX_orcamento_c_cd_tabela_preco" ON orcamento_c (cd_tabela_preco);

CREATE INDEX ind_orcamento_c_agrupado ON orcamento_c (fl_agrupado);

CREATE INDEX ind_orcamento_c_cancelado ON orcamento_c (fl_cancelado);

CREATE INDEX ind_orcamento_c_finalizado ON orcamento_c (fl_finalizado);

CREATE INDEX idx_orcamento_c_nr_os ON orcamento_c (nr_os);

CREATE INDEX "IX_orcamento_c_usuario_cancelamento" ON orcamento_c (usuario_cancelamento);

CREATE INDEX idx_orcamento_c_frente_caixa ON orcamento_c (cd_frente_caixa, fl_dav_impresso);

CREATE INDEX "IX_orcamento_contato_cd_contato" ON orcamento_contato (cd_contato);

CREATE INDEX "IX_orcamento_contato_cd_filial_nr_os" ON orcamento_contato (cd_filial, nr_os);

CREATE INDEX "IX_orcamento_i_cd_produto" ON orcamento_i (cd_produto);

CREATE INDEX idx_orcamento_i_nr_os ON orcamento_i (nr_os);

CREATE INDEX orcamento_i_idxcd_filial_nr_os ON orcamento_i (cd_filial, nr_os);

CREATE INDEX "IX_orcamento_i_agrupa_cd_filial_nr_os_nr_sequencia_servico" ON orcamento_i_agrupa (cd_filial, nr_os, nr_sequencia_servico);

CREATE INDEX reserva_estoque_idx_cd_produto ON orcamento_i_reserva_estoque (cd_produto);

CREATE INDEX reserva_estoque_idx_nr_os ON orcamento_i_reserva_estoque (nr_os);

CREATE INDEX "IX_orcamento_nfe_id_nfec" ON orcamento_nfe (id_nfec);

CREATE INDEX idx_orcamento_situacao_data ON orcamento_situacao (dt_modificacao);

CREATE UNIQUE INDEX unq1_ordem_producao_c ON ordem_producao_c (cd_filial, nr_ordem_producao);

CREATE INDEX "IX_ordem_producao_i_cd_item" ON ordem_producao_i (cd_item);

CREATE UNIQUE INDEX unq_ordem_producao_i ON ordem_producao_i (id_ordem_producao_c, cd_item);

CREATE INDEX "IX_pafecf_e3_cd_impfiscal" ON pafecf_e3 (cd_impfiscal);

CREATE INDEX ind_pedido_func ON pedido_c (cd_funcionario);

CREATE INDEX ind_pedido_data ON pedido_c (dt_emissao);

CREATE INDEX ind_pedido_situacao ON pedido_c (fl_situacao);

CREATE INDEX ind_pedido_i_produto ON pedido_i (cd_produto);

CREATE INDEX "IX_pedido_i_un_medida" ON pedido_i (un_medida);

CREATE UNIQUE INDEX unq_pedido_produto ON pedido_i (nr_pedido, cd_produto);

CREATE INDEX "IX_produto_cd_cfop_regra" ON produto (cd_cfop_regra);

CREATE INDEX "IX_produto_cd_class_fiscal" ON produto (cd_class_fiscal);

CREATE INDEX "IX_produto_cd_grupo_comissao" ON produto (cd_grupo_comissao);

CREATE INDEX "IX_produto_cd_gruprod" ON produto (cd_gruprod);

CREATE INDEX "IX_produto_cd_marca" ON produto (cd_marca);

CREATE INDEX ind_cd_produto ON produto (cd_produto);

CREATE INDEX "IX_produto_cd_subgruprod" ON produto (cd_subgruprod);

CREATE INDEX "IX_produto_codigo_tributacao_municipio" ON produto (codigo_tributacao_municipio);

CREATE INDEX ind_produto_composto ON produto (fl_composto);

CREATE INDEX "IX_produto_id_trib_grupo_piscofins" ON produto (id_trib_grupo_piscofins);

CREATE INDEX "IX_produto_id_tributacao_grupo" ON produto (id_tributacao_grupo);

CREATE INDEX ind_produto_local ON produto (local_estocagem);

CREATE INDEX ind_nm_produto ON produto (nm_produto);

CREATE INDEX "IX_produto_tp_produto" ON produto (tp_produto);

CREATE INDEX "IX_produto_un_armazenagem" ON produto (un_armazenagem);

CREATE INDEX "IX_produto_un_compra" ON produto (un_compra);

CREATE INDEX "IX_produto_un_medida" ON produto (un_medida);

CREATE UNIQUE INDEX unq1_produto_class_fiscal_mva ON produto_class_fiscal_mva (cd_class_fiscal, uf_origem, uf_destino);

CREATE INDEX "IX_produto_cliente_cd_combustivel" ON produto_cliente (cd_combustivel);

CREATE UNIQUE INDEX unq_produto_cliente ON produto_cliente (cd_produto, nr_serie);

CREATE INDEX "IX_produto_fornecedor_id_unimportacao" ON produto_fornecedor (id_unimportacao);

CREATE INDEX "IX_produto_lote_cd_produto" ON produto_lote (cd_produto);

CREATE UNIQUE INDEX unq1_produto_lote ON produto_lote (id_nfec, cd_produto, nr_lote, nr_sequencial, id_nfsc);

CREATE INDEX "IX_produto_serie_cd_produto" ON produto_serie (cd_produto);

CREATE INDEX "IX_produto_serie_id_nfei" ON produto_serie (id_nfei);

CREATE UNIQUE INDEX unq_produto_serie ON produto_serie (cd_filial, cd_produto, nr_serie, id_nfei);

CREATE INDEX idx_cd_barras ON produto_unidade (cd_barras);

CREATE INDEX "IX_produto_veiculo_cd_combustivel" ON produto_veiculo (cd_combustivel);

CREATE INDEX "IX_produto_veiculo_cd_cor" ON produto_veiculo (cd_cor);

CREATE INDEX "IX_produto_veiculo_cd_especie" ON produto_veiculo (cd_especie);

CREATE INDEX "IX_produto_veiculo_cd_produto" ON produto_veiculo (cd_produto);

CREATE INDEX "IX_produto_veiculo_cd_tipo" ON produto_veiculo (cd_tipo);

CREATE UNIQUE INDEX unq_produto_veiculo_placa ON produto_veiculo (placa);

CREATE INDEX "IX_produto_veiculo_cd_filial_cd_montadora" ON produto_veiculo (cd_filial, cd_montadora);

CREATE INDEX "IX_produto_veiculo_cd_filial_cd_veiculo" ON produto_veiculo (cd_filial, cd_veiculo);

CREATE INDEX "IX_produto_veiculos_injecao_cd_injecao" ON produto_veiculos_injecao (cd_injecao);

CREATE UNIQUE INDEX unq_produto_veiculos_injecao ON produto_veiculos_injecao (id_produto_veiculos, cd_injecao);

CREATE INDEX "IX_produto_veiculos_transmissao_cd_transmissao" ON produto_veiculos_transmissao (cd_transmissao);

CREATE UNIQUE INDEX unq_produto_veiculos_transmiss ON produto_veiculos_transmissao (id_produto_veiculos, cd_transmissao);

CREATE INDEX "IX_propriedade_cd_cidade" ON propriedade (cd_cidade);

CREATE INDEX "IX_propriedade_cd_contato" ON propriedade (cd_contato);

CREATE INDEX "IX_propriedade_cd_filial_cd_cliente" ON propriedade (cd_filial, cd_cliente);

CREATE UNIQUE INDEX unq1_protocolo_icms ON protocolo_icms (nr_protocolo);

CREATE INDEX "IX_protocolo_icms_class_fiscal_cd_class_fiscal" ON protocolo_icms_class_fiscal (cd_class_fiscal);

CREATE UNIQUE INDEX unq1_protocolo_icms_class_fisca ON protocolo_icms_class_fiscal (id_protocolo, cd_class_fiscal);

CREATE INDEX "IX_receita_agro_cd_propriedade" ON receita_agro (cd_propriedade);

CREATE INDEX "IX_receita_agro_cd_filial_cd_cliente" ON receita_agro (cd_filial, cd_cliente);

CREATE INDEX "IX_situacao_cd_precedente" ON situacao (cd_precedente);

CREATE INDEX idx_situacao_reserva ON situacao (fl_reserva_estoque);

CREATE INDEX idx_situacao_nome ON situacao (nm_situacao);

CREATE UNIQUE INDEX unq1_tabela_preco_produto ON tabela_preco_produto (cd_tabela_preco, cd_produto);

CREATE UNIQUE INDEX unq1_tributacao ON tributacao (id_tributacao_grupo, uf_origem, uf_destino);

CREATE INDEX "IX_tributacao_aliquota_cd_mensagem" ON tributacao_aliquota (cd_mensagem);

CREATE INDEX "IX_tributacao_aliquota_cst" ON tributacao_aliquota (cst);

CREATE UNIQUE INDEX unq1_tributacao_aliquota ON tributacao_aliquota (id_tributacao, tp_tributacao);

CREATE INDEX "IX_tributacao_grupo_pis_cofins_cofins_compra_cst" ON tributacao_grupo_pis_cofins (cofins_compra_cst);

CREATE INDEX "IX_tributacao_grupo_pis_cofins_cofins_venda_cst" ON tributacao_grupo_pis_cofins (cofins_venda_cst);

CREATE INDEX "IX_tributacao_grupo_pis_cofins_pis_compra_cst" ON tributacao_grupo_pis_cofins (pis_compra_cst);

CREATE INDEX "IX_tributacao_grupo_pis_cofins_pis_venda_cst" ON tributacao_grupo_pis_cofins (pis_venda_cst);

CREATE INDEX "IX_usuario_perfil_cd_perfil" ON usuario_perfil (cd_perfil);

CREATE INDEX ind_veiculo_nome ON veiculo (nm_veiculo);

CREATE INDEX "IX_veiculo_cd_filial_cd_montadora" ON veiculo (cd_filial, cd_montadora);

CREATE INDEX ind_veiculo_despesas_cd_produto ON veiculo_despesas (cd_produto);

CREATE INDEX "IX_veiculo_despesas_id_nfei" ON veiculo_despesas (id_nfei);

CREATE INDEX "IX_veiculo_despesas_cd_filial_dcto_venda" ON veiculo_despesas (cd_filial, dcto_venda);

CREATE INDEX "IX_veiculo_modelo_complemento_cd_complemento" ON veiculo_modelo_complemento (cd_complemento);

CREATE UNIQUE INDEX unq_veiculo_modelo_complemento ON veiculo_modelo_complemento (cd_filial, cd_modelo, cd_complemento);

CREATE INDEX "IX_veiculo_modelo_injecao_cd_injecao" ON veiculo_modelo_injecao (cd_injecao);

CREATE UNIQUE INDEX unq_veiculo_modelo_injecao ON veiculo_modelo_injecao (cd_filial, cd_modelo, cd_injecao);

CREATE INDEX "IX_veiculo_modelo_motor_cd_motor" ON veiculo_modelo_motor (cd_motor);

CREATE UNIQUE INDEX unq_veiculo_modelo_motor ON veiculo_modelo_motor (cd_filial, cd_modelo, cd_motor);

CREATE INDEX "IX_veiculo_modelo_transmissao_cd_transmissao" ON veiculo_modelo_transmissao (cd_transmissao);

CREATE UNIQUE INDEX unq_veiculo_modelo_transmissao ON veiculo_modelo_transmissao (cd_filial, cd_modelo, cd_transmissao);

CREATE INDEX "IX_veiprod_cd_complemento" ON veiprod (cd_complemento);

CREATE INDEX "IX_veiprod_cd_motor" ON veiprod (cd_motor);

CREATE INDEX "IX_veiprod_cd_produto" ON veiprod (cd_produto);

CREATE INDEX "IX_veiprod_cd_filial_cd_montadora" ON veiprod (cd_filial, cd_montadora);

CREATE INDEX "IX_veiprod_cd_filial_cd_veiculo" ON veiprod (cd_filial, cd_veiculo);

CREATE UNIQUE INDEX unq_veiprod ON veiprod (cd_veiculo, cd_produto, cd_motor, cd_complemento, cd_montadora);

INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
VALUES ('20181026033842_AddTodasTabelasPostgres', '2.2.0-preview1-35029');

