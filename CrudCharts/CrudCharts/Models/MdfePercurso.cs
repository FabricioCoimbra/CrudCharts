using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class MdfePercurso
    {
        public int CdFilial { get; set; }
        public int IdGeral { get; set; }
        public int IdMdfe { get; set; }
        public int NrSequencia { get; set; }
        public string Uf { get; set; }
        public DateTime? DtAtz { get; set; }

        public Filial CdFilialNavigation { get; set; }
        public Mdfe IdMdfeNavigation { get; set; }
    }
}
