using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class AuditorEstoqueC
    {
        public AuditorEstoqueC()
        {
            AuditorEstoqueI = new HashSet<AuditorEstoqueI>();
        }

        public int CdFilial { get; set; }
        public int IdGeral { get; set; }
        public DateTime? DtHrInicio { get; set; }
        public DateTime? DtHrFinalizacao { get; set; }
        public int? CdUsuario { get; set; }
        public int? NrOs { get; set; }
        public int? NrPedidoCompra { get; set; }

        public PedidoC NrPedidoCompraNavigation { get; set; }
        public OrcamentoC OrcamentoC { get; set; }
        public ICollection<AuditorEstoqueI> AuditorEstoqueI { get; set; }
    }
}
