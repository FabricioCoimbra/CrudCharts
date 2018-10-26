using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class ProtocoloIcmsClassFiscal
    {
        public int IdGeral { get; set; }
        public int IdProtocolo { get; set; }
        public string CdClassFiscal { get; set; }
        public double? MvaEspecifica { get; set; }

        public ProdutoClassFiscal CdClassFiscalNavigation { get; set; }
        public ProtocoloIcms IdProtocoloNavigation { get; set; }
    }
}
