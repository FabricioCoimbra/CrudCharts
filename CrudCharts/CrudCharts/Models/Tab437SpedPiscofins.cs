using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class Tab437SpedPiscofins
    {
        public Tab437SpedPiscofins()
        {
            OperacaoEs = new HashSet<OperacaoEs>();
        }

        public string CdBcCredito { get; set; }
        public string Descricao { get; set; }

        public ICollection<OperacaoEs> OperacaoEs { get; set; }
    }
}
