using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class AgendaSituacao
    {
        public AgendaSituacao()
        {
            Agenda = new HashSet<Agenda>();
        }

        public int CdSituacao { get; set; }
        public string NmSituacao { get; set; }
        public DateTime DtAtz { get; set; }

        public ICollection<Agenda> Agenda { get; set; }
    }
}
