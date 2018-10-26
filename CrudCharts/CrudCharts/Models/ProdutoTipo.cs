using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class ProdutoTipo
    {
        public ProdutoTipo()
        {
            Produto = new HashSet<Produto>();
        }

        public string CdTipo { get; set; }
        public string Descricao { get; set; }
        public bool? FlPermiteComposicao { get; set; }
        public bool? FlControlarEstoq { get; set; }
        public bool? FlInventario { get; set; }
        public string FlPermitevenda { get; set; }

        public ICollection<Produto> Produto { get; set; }
    }
}
