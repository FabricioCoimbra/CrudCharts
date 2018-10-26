using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class VeiculoTransmissao
    {
        public VeiculoTransmissao()
        {
            ProdutoVeiculosTransmissao = new HashSet<ProdutoVeiculosTransmissao>();
            VeiculoModeloTransmissao = new HashSet<VeiculoModeloTransmissao>();
        }

        public int CdTransmissao { get; set; }
        public string Descricao { get; set; }
        public DateTime? DtAtz { get; set; }

        public ICollection<ProdutoVeiculosTransmissao> ProdutoVeiculosTransmissao { get; set; }
        public ICollection<VeiculoModeloTransmissao> VeiculoModeloTransmissao { get; set; }
    }
}
