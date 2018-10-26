using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class VeiculoModeloComplemento
    {
        public int CdFilial { get; set; }
        public int IdGeral { get; set; }
        public int CdModelo { get; set; }
        public int CdComplemento { get; set; }
        public DateTime? DtAtz { get; set; }

        public Veiculo Cd { get; set; }
        public VeiculoComplemento CdComplementoNavigation { get; set; }
    }
}
