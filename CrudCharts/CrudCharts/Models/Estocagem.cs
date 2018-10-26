using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class Estocagem
    {
        public int CdFilial { get; set; }
        public string LocalEstocagem { get; set; }
        public string NmLocal { get; set; }
        public DateTime? DtAtz { get; set; }
    }
}
