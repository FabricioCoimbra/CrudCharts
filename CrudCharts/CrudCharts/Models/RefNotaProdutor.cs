using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class RefNotaProdutor
    {
        public int CdFilial { get; set; }
        public int CodReferencia { get; set; }
        public int IdNfec { get; set; }
        public string DataNfProdutor { get; set; }
        public string ModeloNfProdutor { get; set; }
        public string SerieNfProdutor { get; set; }
        public string NrNfProdutor { get; set; }
    }
}
