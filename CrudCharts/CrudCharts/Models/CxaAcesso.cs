using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class CxaAcesso
    {
        public int CdFilial { get; set; }
        public int CdFuncionario { get; set; }
        public int CdCaixa { get; set; }
        public char? Leitura { get; set; }
        public char? Gravacao { get; set; }
        public char? Exclusao { get; set; }
        public string Obs { get; set; }
        public DateTime? DtAtz { get; set; }
    }
}
