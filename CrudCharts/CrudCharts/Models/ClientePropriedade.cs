using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class ClientePropriedade
    {
        public int CdFilial { get; set; }
        public int CdCliente { get; set; }
        public int CdPropriedade { get; set; }

        public Cliente Cd { get; set; }
        public Propriedade CdPropriedadeNavigation { get; set; }
    }
}
