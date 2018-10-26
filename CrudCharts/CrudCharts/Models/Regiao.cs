using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class Regiao
    {
        public Regiao()
        {
            Cidade = new HashSet<Cidade>();
        }

        public int CdRegiao { get; set; }
        public string NmRegiao { get; set; }
        public DateTime? DtAtz { get; set; }
        public int? CdFilial { get; set; }

        public ICollection<Cidade> Cidade { get; set; }
    }
}
