using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class FrenteCaixa
    {
        public FrenteCaixa()
        {
            OrcamentoC = new HashSet<OrcamentoC>();
        }

        public int CdFrenteCaixa { get; set; }
        public string NmFrenteCaixa { get; set; }
        public string FlUtilizado { get; set; }
        public int CdOperacao { get; set; }
        public int CdTabelaPreco { get; set; }
        public string Importa { get; set; }
        public string Exporta { get; set; }
        public string NomeArquivo { get; set; }

        public OperacaoEs CdOperacaoNavigation { get; set; }
        public TabelaPreco CdTabelaPrecoNavigation { get; set; }
        public ICollection<OrcamentoC> OrcamentoC { get; set; }
    }
}
