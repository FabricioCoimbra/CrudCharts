using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class AcessoAcaoRelatorio
    {
        public AcessoAcaoRelatorio()
        {
            AcessoAcaoRelFiltro = new HashSet<AcessoAcaoRelFiltro>();
        }

        public long IdAcao { get; set; }
        public string PathModelo { get; set; }
        public int Tipo { get; set; }
        public string SqlRel { get; set; }

        public AcessoAcao IdAcaoNavigation { get; set; }
        public ICollection<AcessoAcaoRelFiltro> AcessoAcaoRelFiltro { get; set; }
    }
}
