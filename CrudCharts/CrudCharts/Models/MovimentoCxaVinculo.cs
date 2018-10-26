using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class MovimentoCxaVinculo
    {
        public int IdGeral { get; set; }
        public int CdFilialO { get; set; }
        public int NrLctoO { get; set; }
        public int CdCaixaO { get; set; }
        public int CdFilialD { get; set; }
        public int NrLctoD { get; set; }
        public int CdCaixaD { get; set; }
    }
}
