using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class ProtocoloIcms
    {
        public ProtocoloIcms()
        {
            ProtocoloIcmsClassFiscal = new HashSet<ProtocoloIcmsClassFiscal>();
        }

        public int IdGeral { get; set; }
        public string NrProtocolo { get; set; }
        public string Descricao { get; set; }
        public DateTime? DtProtocolo { get; set; }

        public ICollection<ProtocoloIcmsClassFiscal> ProtocoloIcmsClassFiscal { get; set; }
    }
}
