using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class HelpAtz
    {
        public HelpAtz()
        {
            HelpAtzAlteracao = new HashSet<HelpAtzAlteracao>();
        }

        public int IdGeral { get; set; }
        public string Descricao { get; set; }
        public int VersaoBd { get; set; }
        public string VersaoSistema { get; set; }

        public ICollection<HelpAtzAlteracao> HelpAtzAlteracao { get; set; }
    }
}
