using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class CobMovimentoRetorno
    {
        public long IdGeral { get; set; }
        public string CdMovimento { get; set; }
        public string Descricao { get; set; }
        public string FlTipo { get; set; }
        public int? CdConvenio { get; set; }
    }
}
