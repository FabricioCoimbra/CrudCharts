using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class Subgruprod
    {
        public Subgruprod()
        {
            Produto = new HashSet<Produto>();
        }

        public int CdSubgruprod { get; set; }
        public int CdGruprod { get; set; }
        public string NmSubgruprod { get; set; }
        public DateTime? DtAtz { get; set; }

        public ICollection<Produto> Produto { get; set; }
    }
}
