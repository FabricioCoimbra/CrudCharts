using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class OrcamentoSituacao
    {
        public int CdFilial { get; set; }
        public int NrOs { get; set; }
        public DateTime DtModificacao { get; set; }
        public int CdFuncionario { get; set; }
        public int CdSituacao { get; set; }
    }
}
