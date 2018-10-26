using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class CrptituloAgrupado
    {
        public int CdFilialO { get; set; }
        public int CdTipoContaO { get; set; }
        public string NrTituloO { get; set; }
        public int ParcelaO { get; set; }
        public int CdCliforO { get; set; }
        public int? CdFilialD { get; set; }
        public int? CdTipoContaD { get; set; }
        public string NrTituloD { get; set; }
        public int? ParcelaD { get; set; }
        public int? CdCliforD { get; set; }
        public DateTime? DtAgrupamento { get; set; }
    }
}
