using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class ProdutoUnidade
    {
        public string CdProduto { get; set; }
        public string UnMedida { get; set; }
        public double FatorConversao { get; set; }
        public string CdBarras { get; set; }
        public string FlTipo { get; set; }
        public DateTime? DtAtz { get; set; }
    }
}
