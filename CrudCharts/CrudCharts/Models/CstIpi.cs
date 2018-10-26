using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class CstIpi
    {
        public string CdCstIpi { get; set; }
        public string Descricao { get; set; }
        public char FlTributada { get; set; }
        public char? FlEntSai { get; set; }
    }
}
