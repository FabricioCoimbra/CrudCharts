using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class AlteracaoCadParticipante
    {
        public int IdGeral { get; set; }
        public int? CdParticipante { get; set; }
        public string TpParticipante { get; set; }
        public int? NrCampo { get; set; }
        public string ContAnt { get; set; }
        public DateTime? DtAlt { get; set; }
    }
}
