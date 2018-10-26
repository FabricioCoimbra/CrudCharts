using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class NrSerieNfs
    {
        public NrSerieNfs()
        {
            Mdfe = new HashSet<Mdfe>();
        }

        public string NrSerie { get; set; }
        public int? NrUltNfsaida { get; set; }
        public long? NrUltNfservico { get; set; }
        public string EndArquivoModelo { get; set; }
        public string FlBlocoManual { get; set; }
        public string NrAidf { get; set; }
        public string EndArquivoFsda { get; set; }

        public ICollection<Mdfe> Mdfe { get; set; }
    }
}
