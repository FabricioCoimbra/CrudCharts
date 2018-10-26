using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class CobMotivoMovimentoRetorno
    {
        public long IdGeral { get; set; }
        public string CdMotivo { get; set; }
        public string Descricao { get; set; }
        public int? CdConvenio { get; set; }
    }
}
