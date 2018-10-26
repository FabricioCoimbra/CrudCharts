using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class Banco
    {
        public int CdBanco { get; set; }
        public string NmBanco { get; set; }
        public string NmArqBoleto { get; set; }
        public DateTime? DtAtz { get; set; }
    }
}
