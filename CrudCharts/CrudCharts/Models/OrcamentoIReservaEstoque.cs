using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class OrcamentoIReservaEstoque
    {
        public int CdFilial { get; set; }
        public int NrOs { get; set; }
        public int NrSequencia { get; set; }
        public string CdProduto { get; set; }
        public decimal? QtReservado { get; set; }

        public OrcamentoI OrcamentoI { get; set; }
    }
}
