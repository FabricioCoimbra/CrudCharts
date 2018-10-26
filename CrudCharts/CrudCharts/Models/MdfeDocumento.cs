using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class MdfeDocumento
    {
        public int CdFilial { get; set; }
        public int IdGeral { get; set; }
        public int? IdMdfe { get; set; }
        public int? IdNf { get; set; }
        public DateTime? DtAtz { get; set; }

        public Filial CdFilialNavigation { get; set; }
        public Mdfe IdMdfeNavigation { get; set; }
    }
}
