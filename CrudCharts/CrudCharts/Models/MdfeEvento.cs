using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class MdfeEvento
    {
        public int CdFilial { get; set; }
        public int IdGeral { get; set; }
        public int IdMdfe { get; set; }
        public int NrSequencia { get; set; }
        public int? TpEvento { get; set; }
        public string NmEvento { get; set; }
        public string ArqXml { get; set; }
        public string NrProtocolo { get; set; }
        public DateTime? DtAtz { get; set; }

        public Filial CdFilialNavigation { get; set; }
        public Mdfe IdMdfeNavigation { get; set; }
    }
}
