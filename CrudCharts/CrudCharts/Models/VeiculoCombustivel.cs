using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class VeiculoCombustivel
    {
        public VeiculoCombustivel()
        {
            ProdutoCliente = new HashSet<ProdutoCliente>();
            ProdutoVeiculo = new HashSet<ProdutoVeiculo>();
        }

        public string CdCombustivel { get; set; }
        public string Descricao { get; set; }

        public ICollection<ProdutoCliente> ProdutoCliente { get; set; }
        public ICollection<ProdutoVeiculo> ProdutoVeiculo { get; set; }
    }
}
