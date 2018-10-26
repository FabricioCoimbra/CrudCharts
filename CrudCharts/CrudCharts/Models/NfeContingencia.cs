using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class NfeContingencia
    {
        public int IdGeral { get; set; }
        public int? CdStatus { get; set; }
        public DateTime? DtInicio { get; set; }
        public TimeSpan? HrInicio { get; set; }
        public DateTime? DtFim { get; set; }
        public TimeSpan? HrFim { get; set; }
        public string Motivo { get; set; }
        public int? CdFilial { get; set; }
    }
}
