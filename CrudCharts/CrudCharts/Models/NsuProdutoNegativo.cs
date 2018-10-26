using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class NsuProdutoNegativo
    {
        public int IdGeral { get; set; }
        public int IdNsu { get; set; }
        public string CdProduto { get; set; }
        public double? QtProduto { get; set; }

        public Nsu IdNsuNavigation { get; set; }
    }
}
