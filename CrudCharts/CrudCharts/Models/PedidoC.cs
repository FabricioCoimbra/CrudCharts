using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class PedidoC
    {
        public PedidoC()
        {
            AuditorEstoqueC = new HashSet<AuditorEstoqueC>();
            Nfec = new HashSet<Nfec>();
            PedidoI = new HashSet<PedidoI>();
        }

        public int NrPedido { get; set; }
        public int? CdFuncionario { get; set; }
        public char FlSituacao { get; set; }
        public DateTime DtEmissao { get; set; }
        public int CdFornecedor { get; set; }
        public DateTime? DtValidade { get; set; }
        public int CdCondpgto { get; set; }
        public string Obs { get; set; }
        public string MotivoCancelamento { get; set; }
        public decimal? VlTotal { get; set; }
        public DateTime DtAtz { get; set; }

        public ICollection<AuditorEstoqueC> AuditorEstoqueC { get; set; }
        public ICollection<Nfec> Nfec { get; set; }
        public ICollection<PedidoI> PedidoI { get; set; }
    }
}
