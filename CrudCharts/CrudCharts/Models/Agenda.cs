using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class Agenda
    {
        public int CdEvento { get; set; }
        public DateTime DtHrEvento { get; set; }
        public string NmEvento { get; set; }
        public int? CdSituacao { get; set; }

        public AgendaSituacao CdSituacaoNavigation { get; set; }
    }
}
