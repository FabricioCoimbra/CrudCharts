using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class NfscServico
    {
        public int NrDocumento { get; set; }
        public int? CdCidadePrestacao { get; set; }
        public int? CdNatOperacao { get; set; }
        public bool? IncentivoCultural { get; set; }
    }
}
