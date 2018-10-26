using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class ClienteContato
    {
        public int CdCliente { get; set; }
        public int CdContato { get; set; }
        public int CdFilial { get; set; }

        public Cliente Cd { get; set; }
        public Contato CdContatoNavigation { get; set; }
    }
}
