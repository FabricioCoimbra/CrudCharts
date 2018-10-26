using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class PlHistorico
    {
        public int CdFilial { get; set; }
        public int CdHistorico { get; set; }
        public string Descricao { get; set; }
        public bool? Complemento { get; set; }
        public DateTime? DtAtz { get; set; }
    }
}
