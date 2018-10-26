using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class OperacaoCfopRegra
    {
        public int IdGeral { get; set; }
        public int CdOperacao { get; set; }
        public int CdCfopRegra { get; set; }
        public string CfopIntCont { get; set; }
        public string CfopIntNcont { get; set; }
        public string CfopExtCont { get; set; }
        public string CfopExtNcont { get; set; }
        public string CfopSubstIntCont { get; set; }
        public string CfopSubstIntNcont { get; set; }
        public string CfopSubstExtCont { get; set; }
        public string CfopSubstExtNcont { get; set; }
        public string CfopSubstIntNcontRet { get; set; }
        public string CfopSubstIntContRet { get; set; }
        public string CfopSubstExtContRet { get; set; }
        public string CfopSubstExtNcontRet { get; set; }

        public CfopRegra CdCfopRegraNavigation { get; set; }
        public OperacaoEs CdOperacaoNavigation { get; set; }
    }
}
