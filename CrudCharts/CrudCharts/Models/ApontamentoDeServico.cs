using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class ApontamentoDeServico
    {
        public int Id { get; set; }
        public int CdFilial { get; set; }
        public int CdFuncionario { get; set; }
        public DateTime Data { get; set; }
        public TimeSpan HoraInicial { get; set; }
        public TimeSpan HoraFinal { get; set; }
        public string Descricao { get; set; }
        public int? Status { get; set; }
        public DateTime? DtAtz { get; set; }
        public int? NrOs { get; set; }

        public Funcionario CdF { get; set; }
        public OrcamentoC OrcamentoC { get; set; }
    }
}
