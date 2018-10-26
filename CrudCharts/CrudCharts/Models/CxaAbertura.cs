using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class CxaAbertura
    {
        public int CdFilial { get; set; }
        public int CdCaixa { get; set; }
        public int CdFuncionario { get; set; }
        public int NrSequencial { get; set; }
        public int CdCaixaOrigem { get; set; }
        public DateTime DtAbertura { get; set; }
        public TimeSpan HoraAbertura { get; set; }
        public DateTime? DtFechamento { get; set; }
        public TimeSpan? HoraFechamento { get; set; }
        public decimal VlIniOutros { get; set; }
        public decimal VlIniCheque { get; set; }
        public decimal VlIniCartao { get; set; }
        public decimal VlIniDinheiro { get; set; }
        public decimal? VlFimOutros { get; set; }
        public decimal? VlFimCheque { get; set; }
        public decimal? VlFimCartao { get; set; }
        public decimal? VlFimDinheiro { get; set; }
        public string FlFechado { get; set; }
        public DateTime DtAtz { get; set; }
    }
}
