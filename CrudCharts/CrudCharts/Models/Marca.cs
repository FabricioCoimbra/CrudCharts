using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class Marca
    {
        public Marca()
        {
            Produto = new HashSet<Produto>();
        }

        public int CdMarca { get; set; }
        public string NmMarca { get; set; }
        public DateTime? DtAtz { get; set; }

        public ICollection<Produto> Produto { get; set; }
    }
}
