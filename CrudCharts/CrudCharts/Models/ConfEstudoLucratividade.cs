using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class ConfEstudoLucratividade
    {
        public string CdProduto { get; set; }
        public double? PcDeQuebra { get; set; }
        public double? PcDespesasOperacionais { get; set; }
        public double? PcCsll { get; set; }
        public double? PcIrrj { get; set; }
        public double? PcAliqSimplesNacional { get; set; }
        public double? PcCustoFixo { get; set; }
        public double? PcOutrasDespesas { get; set; }
    }
}
