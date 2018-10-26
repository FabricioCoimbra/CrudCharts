using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class OrdemProducaoC
    {
        public OrdemProducaoC()
        {
            OrdemProducaoI = new HashSet<OrdemProducaoI>();
        }

        public long IdGeral { get; set; }
        public int CdFilial { get; set; }
        public int NrOrdemProducao { get; set; }
        public DateTime? DtEmissao { get; set; }
        public DateTime? DtPrevisao { get; set; }
        public string CdSituacao { get; set; }
        public int? CdFuncionario { get; set; }
        public string NrMaquina { get; set; }
        public string Turno { get; set; }

        public ICollection<OrdemProducaoI> OrdemProducaoI { get; set; }
    }
}
