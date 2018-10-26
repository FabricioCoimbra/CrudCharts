using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class OrcamentoContato
    {
        public int CdFilial { get; set; }
        public int NrOs { get; set; }
        public int CdContato { get; set; }

        public Contato CdContatoNavigation { get; set; }
        public OrcamentoC OrcamentoC { get; set; }
    }
}
