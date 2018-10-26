using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class AlteracaoCadItem
    {
        public int IdGeral { get; set; }
        public string CdItem { get; set; }
        public int NrCampo { get; set; }
        public string ContAnt { get; set; }
        public DateTime DtAlt { get; set; }
    }
}
