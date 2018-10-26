using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class VeiculoTipo
    {
        public VeiculoTipo()
        {
            ProdutoVeiculo = new HashSet<ProdutoVeiculo>();
        }

        public string CdTipo { get; set; }
        public string Descricao { get; set; }

        public ICollection<ProdutoVeiculo> ProdutoVeiculo { get; set; }
    }
}
