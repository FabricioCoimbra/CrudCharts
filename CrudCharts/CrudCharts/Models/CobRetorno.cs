using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class CobRetorno
    {
        public CobRetorno()
        {
            CobRetornoParcela = new HashSet<CobRetornoParcela>();
        }

        public long CdRetorno { get; set; }
        public int? CdFilial { get; set; }
        public string NrRetorno { get; set; }
        public string FlProcessado { get; set; }
        public string Arquivo { get; set; }
        public long? CdConvenio { get; set; }

        public Filial CdFilialNavigation { get; set; }
        public ICollection<CobRetornoParcela> CobRetornoParcela { get; set; }
    }
}
