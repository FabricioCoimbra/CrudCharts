using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class ContaContabil
    {
        public ContaContabil()
        {
            Caixa = new HashSet<Caixa>();
            Cliente = new HashSet<Cliente>();
            CxaConta = new HashSet<CxaConta>();
            Fornecedor = new HashSet<Fornecedor>();
        }

        public int CdConta { get; set; }
        public string NmConta { get; set; }
        public int? CdHistorico { get; set; }
        public DateTime? DtAtz { get; set; }

        public ICollection<Caixa> Caixa { get; set; }
        public ICollection<Cliente> Cliente { get; set; }
        public ICollection<CxaConta> CxaConta { get; set; }
        public ICollection<Fornecedor> Fornecedor { get; set; }
    }
}
