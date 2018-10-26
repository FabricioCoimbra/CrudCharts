using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class CobConvenioAtributo
    {
        public int CdAtributo { get; set; }
        public int CdConvenio { get; set; }
        public int NrOrdem { get; set; }
        public string NmCampo { get; set; }
        public string NmTituloCampo { get; set; }
        public string TipoCampo { get; set; }
        public string VlAtributo { get; set; }
        public int? CdFormaPgto { get; set; }

        public CobConvenio CdConvenioNavigation { get; set; }
    }
}
