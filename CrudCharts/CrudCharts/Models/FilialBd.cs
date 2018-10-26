using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class FilialBd
    {
        public FilialBd()
        {
            ClienteResumoFinanceiro = new HashSet<ClienteResumoFinanceiro>();
        }

        public int CdFilial { get; set; }
        public string NmFilial { get; set; }
        public string NmServidorBd { get; set; }
        public string NmBd { get; set; }
        public string NmUsuario { get; set; }
        public string Senha { get; set; }
        public bool FlSincronizarContas { get; set; }
        public char FlDadosContasDesatualizados { get; set; }
        public int NrMinutosContasDesatualizado { get; set; }

        public ClienteResumoFinanceiroLog ClienteResumoFinanceiroLog { get; set; }
        public ICollection<ClienteResumoFinanceiro> ClienteResumoFinanceiro { get; set; }
    }
}
