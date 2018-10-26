using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class CobBordero
    {
        public CobBordero()
        {
            CobBorderoParcela = new HashSet<CobBorderoParcela>();
        }

        public int CdBordero { get; set; }
        public int CdConvenio { get; set; }
        public DateTime DtCadastro { get; set; }
        public DateTime? DtEnvioRemessa { get; set; }

        public CobConvenio CdConvenioNavigation { get; set; }
        public ICollection<CobBorderoParcela> CobBorderoParcela { get; set; }
    }
}
