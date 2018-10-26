using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class TributacaoAliquota
    {
        public int IdGeral { get; set; }
        public int IdTributacao { get; set; }
        public string Cst { get; set; }
        public int? CdMensagem { get; set; }
        public DateTime? DtAtz { get; set; }
        public string HashTributacaoAliquotaD3 { get; set; }
        public string HashTributacaoAliquotaP2 { get; set; }
        public string TpTributacao { get; set; }
        public double? IcmAliqNormal { get; set; }
        public double? IcmAliqProprio { get; set; }
        public double? IcmAliqSubst { get; set; }
        public double? IcmRedNormal { get; set; }
        public double? IcmRedProprio { get; set; }
        public double? IcmRedSubst { get; set; }
        public string FlReducaoAliqNormal { get; set; }
        public string FlReducaoAliqProprio { get; set; }
        public string FlReducaoAliqSubst { get; set; }
        public double? AliqFcp { get; set; }

        public MensagemNota CdMensagemNavigation { get; set; }
        public Cst CstNavigation { get; set; }
        public Tributacao IdTributacaoNavigation { get; set; }
    }
}
