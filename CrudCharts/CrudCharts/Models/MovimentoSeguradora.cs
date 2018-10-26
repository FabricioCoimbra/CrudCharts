using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class MovimentoSeguradora
    {
        public int NrDocumento { get; set; }
        public decimal? VlFranquia { get; set; }
        public decimal? VlAbatido { get; set; }
        public DateTime? DtAtz { get; set; }
        public int? CdSeguradora { get; set; }
        public int? CdCliente { get; set; }
        public int? NrDocumentoOrigem { get; set; }
        public int? NrLcto { get; set; }
        public int CdFilial { get; set; }
        public int? CdCaixa { get; set; }

        public Cliente Cd { get; set; }
        public Fornecedor CdNavigation { get; set; }
        public MovimentoCxa MovimentoCxa { get; set; }
    }
}
