using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class Fornveic
    {
        public Fornveic()
        {
            Mdfe = new HashSet<Mdfe>();
        }

        public int CdFilial { get; set; }
        public int IdGeral { get; set; }
        public int CdFornecedor { get; set; }
        public int CdVeiculo { get; set; }
        public int TpRodado { get; set; }
        public int TpCarroceria { get; set; }
        public decimal Tara { get; set; }
        public decimal Capacidade { get; set; }
        public string PlacaVeiculo { get; set; }
        public string Uf { get; set; }
        public string Observacoes { get; set; }
        public DateTime? DtAtz { get; set; }

        public Veiculo Cd { get; set; }
        public Fornecedor CdF { get; set; }
        public Filial CdFilialNavigation { get; set; }
        public ICollection<Mdfe> Mdfe { get; set; }
    }
}
