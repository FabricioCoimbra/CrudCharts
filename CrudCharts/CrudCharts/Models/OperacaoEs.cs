using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class OperacaoEs
    {
        public OperacaoEs()
        {
            FrenteCaixa = new HashSet<FrenteCaixa>();
            OperacaoCfopRegra = new HashSet<OperacaoCfopRegra>();
        }

        public int CdOperacao { get; set; }
        public string NmOperacao { get; set; }
        public string FlEntSai { get; set; }
        public bool? FlCalcularCusto { get; set; }
        public bool? FlCalcularIpi { get; set; }
        public bool? FlControlarEstoq { get; set; }
        public bool? FlCalcularComissao { get; set; }
        public bool? FlIgnoraCaixaContas { get; set; }
        public string FlCdConta { get; set; }
        public string FlCalcularIcms { get; set; }
        public DateTime? DtAtz { get; set; }
        public bool FlTributarFrete { get; set; }
        public bool FlReducaoJuridica { get; set; }
        public string FlCalcularIss { get; set; }
        public string FlSugerirPreco { get; set; }
        public string CdGrupoOp { get; set; }
        public string FlAtivo { get; set; }
        public int? CdContaMovimento { get; set; }
        public string CdModelo { get; set; }
        public int? CdMensagem { get; set; }
        public string NatOperacao { get; set; }
        public int? IdTributacaoGrupo { get; set; }
        public string FlImportacao { get; set; }
        public string Finalidade { get; set; }
        public string CstPisDif { get; set; }
        public string CstCofinsDif { get; set; }
        public bool? FlCreditoIcmsSt { get; set; }
        public bool? FlCreditoIpi { get; set; }
        public string CdBcCredPiscofins { get; set; }
        public string CdTpCredPiscofins { get; set; }
        public int? IdTributacaoGrupoPisCofins { get; set; }
        public string FlCreditaIcmProprioSt { get; set; }
        public string FlIncluiIpiBasePis { get; set; }
        public string FlIncluiIcmsStBasePis { get; set; }
        public string IndPresencial { get; set; }
        public char? FlReferenciarNota { get; set; }
        public char? FlInfoXml { get; set; }
        public string FlCxaFranquia { get; set; }

        public Tab437SpedPiscofins CdBcCredPiscofinsNavigation { get; set; }
        public CxaConta CdContaMovimentoNavigation { get; set; }
        public GrupoOperacaoEs CdGrupoOpNavigation { get; set; }
        public MensagemNota CdMensagemNavigation { get; set; }
        public ModeloDcto CdModeloNavigation { get; set; }
        public Tab436SpedPiscofins CdTpCredPiscofinsNavigation { get; set; }
        public TributacaoGrupo IdTributacaoGrupoNavigation { get; set; }
        public TributacaoGrupoPisCofins IdTributacaoGrupoPisCofinsNavigation { get; set; }
        public ICollection<FrenteCaixa> FrenteCaixa { get; set; }
        public ICollection<OperacaoCfopRegra> OperacaoCfopRegra { get; set; }
    }
}
