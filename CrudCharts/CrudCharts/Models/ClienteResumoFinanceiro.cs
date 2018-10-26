using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class ClienteResumoFinanceiro
    {
        public int CdCliente { get; set; }
        public int CdFilial { get; set; }
        public decimal? VlLimite { get; set; }
        public decimal? VlAVencer { get; set; }
        public decimal? VlAtrasado { get; set; }
        public decimal? VlChequePre { get; set; }
        public DateTime? DtUltimaCompra { get; set; }
        public DateTime? DtAtz { get; set; }

        public Cliente CdClienteNavigation { get; set; }
        public FilialBd CdFilialNavigation { get; set; }
    }
}
