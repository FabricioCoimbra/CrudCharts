using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class ProdRelacionado
    {
        public string CdProduto { get; set; }
        public string CdRelacionado { get; set; }
        public double? QtRelacionado { get; set; }
        public DateTime? DtAtz { get; set; }
    }
}
