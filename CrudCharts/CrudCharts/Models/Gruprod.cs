using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class Gruprod
    {
        public Gruprod()
        {
            Msggrupo = new HashSet<Msggrupo>();
            Produto = new HashSet<Produto>();
        }

        public int CdGruprod { get; set; }
        public string NmGruprod { get; set; }
        public DateTime? DtAtz { get; set; }

        public ICollection<Msggrupo> Msggrupo { get; set; }
        public ICollection<Produto> Produto { get; set; }
    }
}
