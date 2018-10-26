using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class NfscMensagem
    {
        public int IdGeral { get; set; }
        public int CdFilial { get; set; }
        public int NrDocumento { get; set; }
        public int CdMensagem { get; set; }
        public string Mensagem { get; set; }

        public MensagemNota CdMensagemNavigation { get; set; }
        public Nfsc Nfsc { get; set; }
    }
}
