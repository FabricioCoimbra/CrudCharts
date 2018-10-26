using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class ProdutoVeiculosInjecao
    {
        public int IdGeral { get; set; }
        public int IdProdutoVeiculos { get; set; }
        public int CdInjecao { get; set; }
        public DateTime? DtAtz { get; set; }

        public VeiculoInjecao CdInjecaoNavigation { get; set; }
        public Veiprod IdProdutoVeiculosNavigation { get; set; }
    }
}
