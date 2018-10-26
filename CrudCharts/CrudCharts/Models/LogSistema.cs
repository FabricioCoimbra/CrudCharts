using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class LogSistema
    {
        public long IdGeral { get; set; }
        public DateTime? DtHrExclusao { get; set; }
        public int? CdUsuario { get; set; }
        public string Tabela { get; set; }
        public string Observacao { get; set; }
    }
}
