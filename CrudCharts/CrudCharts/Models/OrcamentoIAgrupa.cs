using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class OrcamentoIAgrupa
    {
        public int CdFilial { get; set; }
        public int NrOs { get; set; }
        public int NrSequenciaEquip { get; set; }
        public int NrSequenciaServico { get; set; }

        public OrcamentoI OrcamentoI { get; set; }
        public OrcamentoI OrcamentoINavigation { get; set; }
    }
}
