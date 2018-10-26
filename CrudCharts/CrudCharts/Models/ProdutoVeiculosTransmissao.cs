using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class ProdutoVeiculosTransmissao
    {
        public int IdGeral { get; set; }
        public int IdProdutoVeiculos { get; set; }
        public int CdTransmissao { get; set; }
        public DateTime? DtAtz { get; set; }

        public VeiculoTransmissao CdTransmissaoNavigation { get; set; }
        public Veiprod IdProdutoVeiculosNavigation { get; set; }
    }
}
