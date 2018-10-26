using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class NfeInutilizacao
    {
        public int IdGeral { get; set; }
        public int NrNf { get; set; }
        public string SerieNf { get; set; }
        public DateTime DtProcessamentoInut { get; set; }
        public string NrProtocoloInut { get; set; }
        public int CdUsuario { get; set; }
        public string Motivo { get; set; }
    }
}
