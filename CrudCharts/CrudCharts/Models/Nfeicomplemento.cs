using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class Nfeicomplemento
    {
        public string Complemento { get; set; }
        public DateTime? DtAtz { get; set; }
        public int IdNfei { get; set; }

        public Nfei IdNfeiNavigation { get; set; }
    }
}
