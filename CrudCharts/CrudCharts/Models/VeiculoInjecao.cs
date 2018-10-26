using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class VeiculoInjecao
    {
        public VeiculoInjecao()
        {
            ProdutoVeiculosInjecao = new HashSet<ProdutoVeiculosInjecao>();
            VeiculoModeloInjecao = new HashSet<VeiculoModeloInjecao>();
        }

        public int CdInjecao { get; set; }
        public string Descricao { get; set; }
        public DateTime? DtAtz { get; set; }

        public ICollection<ProdutoVeiculosInjecao> ProdutoVeiculosInjecao { get; set; }
        public ICollection<VeiculoModeloInjecao> VeiculoModeloInjecao { get; set; }
    }
}
