using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class Tributacao
    {
        public Tributacao()
        {
            TributacaoAliquota = new HashSet<TributacaoAliquota>();
        }

        public int IdGeral { get; set; }
        public int IdTributacaoGrupo { get; set; }
        public string UfOrigem { get; set; }
        public string UfDestino { get; set; }
        public DateTime? DtAtz { get; set; }

        public TributacaoGrupo IdTributacaoGrupoNavigation { get; set; }
        public ICollection<TributacaoAliquota> TributacaoAliquota { get; set; }
    }
}
