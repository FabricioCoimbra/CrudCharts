using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class AdministradoraTaxas
    {
        public int CdAdministradora { get; set; }
        public int QtParcelas { get; set; }
        public decimal? PcCobrancaLoja { get; set; }

        public Administradora CdAdministradoraNavigation { get; set; }
    }
}
