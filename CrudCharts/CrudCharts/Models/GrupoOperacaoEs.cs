using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class GrupoOperacaoEs
    {
        public GrupoOperacaoEs()
        {
            OperacaoEs = new HashSet<OperacaoEs>();
        }

        public string CdGrupo { get; set; }
        public string NmGrupo { get; set; }

        public ICollection<OperacaoEs> OperacaoEs { get; set; }
    }
}
