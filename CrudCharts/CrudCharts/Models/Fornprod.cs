using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class Fornprod
    {
        public int CdFilial { get; set; }
        public int CdFornecedor { get; set; }
        public int CdProduto { get; set; }
        public DateTime? DtAtz { get; set; }
    }
}
