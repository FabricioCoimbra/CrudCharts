using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class Estoque
    {
        public int CdFilial { get; set; }
        public string CdProduto { get; set; }
        public int Ano { get; set; }
        public int Mes { get; set; }
        public double? QtEntradas { get; set; }
        public double? QtSaidas { get; set; }
        public double? Qtde { get; set; }
        public DateTime? DtAtz { get; set; }
        public double? QtEntradas2 { get; set; }
        public double? QtSaidas2 { get; set; }
        public double? Qtde2 { get; set; }

        public Produto CdProdutoNavigation { get; set; }
    }
}
