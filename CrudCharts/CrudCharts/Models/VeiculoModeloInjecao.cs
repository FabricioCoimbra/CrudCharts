using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class VeiculoModeloInjecao
    {
        public int CdFilial { get; set; }
        public int IdGeral { get; set; }
        public int CdModelo { get; set; }
        public int CdInjecao { get; set; }
        public DateTime? DtAtz { get; set; }

        public Veiculo Cd { get; set; }
        public VeiculoInjecao CdInjecaoNavigation { get; set; }
    }
}
