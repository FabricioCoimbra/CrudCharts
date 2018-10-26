using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class UnMedida
    {
        public UnMedida()
        {
            PedidoI = new HashSet<PedidoI>();
            ProdutoUnArmazenagemNavigation = new HashSet<Produto>();
            ProdutoUnCompraNavigation = new HashSet<Produto>();
            ProdutoUnMedidaNavigation = new HashSet<Produto>();
        }

        public string UnMedida1 { get; set; }
        public string Descricao { get; set; }

        public ICollection<PedidoI> PedidoI { get; set; }
        public ICollection<Produto> ProdutoUnArmazenagemNavigation { get; set; }
        public ICollection<Produto> ProdutoUnCompraNavigation { get; set; }
        public ICollection<Produto> ProdutoUnMedidaNavigation { get; set; }
    }
}
