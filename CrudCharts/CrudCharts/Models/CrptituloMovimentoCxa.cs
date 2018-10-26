using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class CrptituloMovimentoCxa
    {
        public int CdFilial { get; set; }
        public int CdTipoConta { get; set; }
        public int CdClifor { get; set; }
        public string NrTitulo { get; set; }
        public int Parcela { get; set; }
        public int NrLcto { get; set; }
        public int CdCaixa { get; set; }
        public DateTime? DtAtz { get; set; }

        public Crptitulo Crptitulo { get; set; }
        public MovimentoCxa MovimentoCxa { get; set; }
    }
}
