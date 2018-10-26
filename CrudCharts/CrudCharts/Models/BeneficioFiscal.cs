using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class BeneficioFiscal
    {
        public int Id { get; set; }
        public string CodAjur { get; set; }
        public string DescAjur { get; set; }
        public DateTime? DtIni { get; set; }
        public DateTime? DtFim { get; set; }
    }
}
