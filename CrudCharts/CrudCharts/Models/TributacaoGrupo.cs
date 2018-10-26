using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class TributacaoGrupo
    {
        public TributacaoGrupo()
        {
            OperacaoEs = new HashSet<OperacaoEs>();
            Produto = new HashSet<Produto>();
            Tributacao = new HashSet<Tributacao>();
        }

        public int IdTributacaoGrupo { get; set; }
        public string NmTributacaoGrupo { get; set; }
        public DateTime? DtAtz { get; set; }

        public ICollection<OperacaoEs> OperacaoEs { get; set; }
        public ICollection<Produto> Produto { get; set; }
        public ICollection<Tributacao> Tributacao { get; set; }
    }
}
