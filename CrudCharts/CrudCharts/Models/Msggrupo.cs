using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class Msggrupo
    {
        public int CdGruprod { get; set; }
        public string UfOrigem { get; set; }
        public string UfDestino { get; set; }
        public DateTime? DtAtz { get; set; }
        public int? CdMensagem { get; set; }

        public Gruprod CdGruprodNavigation { get; set; }
        public MensagemNota CdMensagemNavigation { get; set; }
    }
}
