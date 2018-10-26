using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class VeiculoCor
    {
        public VeiculoCor()
        {
            ProdutoVeiculo = new HashSet<ProdutoVeiculo>();
        }

        public string CdCor { get; set; }
        public string Descricao { get; set; }

        public ICollection<ProdutoVeiculo> ProdutoVeiculo { get; set; }
    }
}
