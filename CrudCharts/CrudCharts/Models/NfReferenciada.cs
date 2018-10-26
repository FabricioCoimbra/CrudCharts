using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class NfReferenciada
    {
        public int IdGeral { get; set; }
        public string FlEntradaSaida { get; set; }
        public int? NrDocumento { get; set; }
        public string FlEntradaSaidaRef { get; set; }
        public int? NrDocumentoRef { get; set; }
    }
}
