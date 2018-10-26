using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class Nfsicomplemento
    {
        public int CdFilial { get; set; }
        public int NrOs { get; set; }
        public int NrSequencia { get; set; }
        public string Complemento { get; set; }
        public DateTime? DtAtz { get; set; }
    }
}
