using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class HelpAtzAlteracao
    {
        public int IdGeral { get; set; }
        public int IdHelpAtz { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public int? IdImagem { get; set; }

        public HelpAtz IdHelpAtzNavigation { get; set; }
    }
}
