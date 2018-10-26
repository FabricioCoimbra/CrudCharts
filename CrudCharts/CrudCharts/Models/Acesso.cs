using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class Acesso
    {
        public int CdFilial { get; set; }
        public string NmLogin { get; set; }
        public string NmPrograma { get; set; }
        public DateTime? DtAtz { get; set; }
    }
}
