using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class FilialEmail
    {
        public int IdGeral { get; set; }
        public int? CdFilial { get; set; }
        public int? TpEmail { get; set; }
        public string NmOrigem { get; set; }
        public string ServidorSmtp { get; set; }
        public string Email { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public string Ssl { get; set; }
        public int? Porta { get; set; }

        public Filial CdFilialNavigation { get; set; }
    }
}
