using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class FornecedorContato
    {
        public int CdFornecedor { get; set; }
        public int CdContato { get; set; }
        public int CdFilial { get; set; }

        public Contato CdContatoNavigation { get; set; }
        public Fornecedor CdF { get; set; }
    }
}
