using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class PafecfE3
    {
        public int IdGeral { get; set; }
        public int CdImpfiscal { get; set; }
        public DateTime Data { get; set; }
        public TimeSpan Hora { get; set; }
        public string HashE3 { get; set; }

        public Impfiscal CdImpfiscalNavigation { get; set; }
    }
}
