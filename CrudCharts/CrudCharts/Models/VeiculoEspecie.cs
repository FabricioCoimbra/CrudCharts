using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class VeiculoEspecie
    {
        public VeiculoEspecie()
        {
            ProdutoVeiculo = new HashSet<ProdutoVeiculo>();
        }

        public string CdEspecie { get; set; }
        public string Descricao { get; set; }

        public ICollection<ProdutoVeiculo> ProdutoVeiculo { get; set; }
    }
}
