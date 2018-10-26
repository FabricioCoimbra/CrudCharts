using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class ClienteResumoFinanceiroLog
    {
        public int CdFilial { get; set; }
        public DateTime DtAtz { get; set; }
        public char FlStatus { get; set; }

        public FilialBd CdFilialNavigation { get; set; }
    }
}
