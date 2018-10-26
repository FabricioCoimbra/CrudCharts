using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class FilialIeSt
    {
        public int CdFilial { get; set; }
        public string Uf { get; set; }
        public string IeSt { get; set; }

        public Filial CdFilialNavigation { get; set; }
    }
}
