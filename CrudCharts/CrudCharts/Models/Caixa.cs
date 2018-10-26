using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class Caixa
    {
        public Caixa()
        {
            MovimentoCxa = new HashSet<MovimentoCxa>();
        }

        public int CdFilial { get; set; }
        public int CdCaixa { get; set; }
        public string NmCaixa { get; set; }
        public string FlTipo { get; set; }
        public DateTime? DtAtz { get; set; }
        public decimal? SaldoAnterior { get; set; }
        public string Agencia { get; set; }
        public string Conta { get; set; }
        public string Gerente { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Fone { get; set; }
        public string Fax { get; set; }
        public string Http { get; set; }
        public string EMail { get; set; }
        public int? CdUsr { get; set; }
        public int? CdContaContabil { get; set; }
        public decimal? Limite { get; set; }

        public ContaContabil CdContaContabilNavigation { get; set; }
        public ICollection<MovimentoCxa> MovimentoCxa { get; set; }
    }
}
