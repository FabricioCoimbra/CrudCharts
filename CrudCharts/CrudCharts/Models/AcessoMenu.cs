using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class AcessoMenu
    {
        public AcessoMenu()
        {
            InverseIdMenuPaiNavigation = new HashSet<AcessoMenu>();
        }

        public long IdGeral { get; set; }
        public string NmTitulo { get; set; }
        public long? IdMenuPai { get; set; }
        public int NrOrdem { get; set; }
        public string NmTeclaAtalho { get; set; }

        public AcessoMenu IdMenuPaiNavigation { get; set; }
        public ICollection<AcessoMenu> InverseIdMenuPaiNavigation { get; set; }
    }
}
