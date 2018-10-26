using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class Tab436SpedPiscofins
    {
        public Tab436SpedPiscofins()
        {
            OperacaoEs = new HashSet<OperacaoEs>();
        }

        public string CdTpCredito { get; set; }
        public string Descricao { get; set; }

        public ICollection<OperacaoEs> OperacaoEs { get; set; }
    }
}
