using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class AdministradoraBandeira
    {
        public AdministradoraBandeira()
        {
            Administradora = new HashSet<Administradora>();
        }

        public int IdGeral { get; set; }
        public string Descricao { get; set; }
        public string CdBandeira { get; set; }

        public ICollection<Administradora> Administradora { get; set; }
    }
}
