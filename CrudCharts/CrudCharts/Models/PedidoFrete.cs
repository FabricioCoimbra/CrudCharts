using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class PedidoFrete
    {
        public int Id { get; set; }
        public string UfOrigem { get; set; }
        public string UfDestino { get; set; }
        public int? Status { get; set; }
    }
}
