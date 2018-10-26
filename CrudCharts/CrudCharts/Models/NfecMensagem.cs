using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class NfecMensagem
    {
        public int IdGeral { get; set; }
        public int CdMensagem { get; set; }
        public string Mensagem { get; set; }
        public int? IdNfec { get; set; }

        public MensagemNota CdMensagemNavigation { get; set; }
        public Nfec IdNfecNavigation { get; set; }
    }
}
