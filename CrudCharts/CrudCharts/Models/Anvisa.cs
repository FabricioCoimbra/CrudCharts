using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class Anvisa
    {
        public string Codigo { get; set; }
        public string CdAnvisa { get; set; }
        public decimal? Preco { get; set; }
        public string DescricaoAnvisa { get; set; }
    }
}
