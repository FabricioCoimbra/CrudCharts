using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class CobConvenioFormaPgto
    {
        public int CdFilial { get; set; }
        public int CdFormaPgto { get; set; }
        public int CdConvenio { get; set; }
        public string NrCarteira { get; set; }
        public string SgCarteira { get; set; }
        public string VariacaoCarteira { get; set; }
        public string FlRegistrada { get; set; }
        public int IdGeral { get; set; }

        public CobConvenio CdConvenioNavigation { get; set; }
    }
}
