using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class Rotas
    {
        public int Id { get; set; }
        public string UfOrigem { get; set; }
        public string UfDestino { get; set; }
        public double Distancia { get; set; }
        public double? Preco { get; set; }
    }
}
