using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class OrcamentoNfe
    {
        public int NrOs { get; set; }
        public int IdNfec { get; set; }

        public Nfec IdNfecNavigation { get; set; }
    }
}
