using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class OrdemProducaoI
    {
        public long IdGeral { get; set; }
        public long IdOrdemProducaoC { get; set; }
        public string CdItem { get; set; }
        public double? QtProducao { get; set; }
        public double? QtProduzido { get; set; }

        public Produto CdItemNavigation { get; set; }
        public OrdemProducaoC IdOrdemProducaoCNavigation { get; set; }
    }
}
