using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class NfcFrete
    {
        public int IdGeral { get; set; }
        public int? NrDocumentoNfsc { get; set; }
        public int? IdNfec { get; set; }
        public int IdFrete { get; set; }
        public int? CdFilialNfsc { get; set; }
        public double? PcRateio { get; set; }

        public Nfec IdFreteNavigation { get; set; }
        public Nfec IdNfecNavigation { get; set; }
        public Nfsc Nfsc { get; set; }
    }
}
