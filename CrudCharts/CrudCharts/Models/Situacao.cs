using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class Situacao
    {
        public Situacao()
        {
            InverseCdPrecedenteNavigation = new HashSet<Situacao>();
            OrcamentoC = new HashSet<OrcamentoC>();
        }

        public int CdSituacao { get; set; }
        public string NmSituacao { get; set; }
        public bool FlInicial { get; set; }
        public bool FlFinal { get; set; }
        public bool FlReservaEstoque { get; set; }
        public bool FlDescricaoServico { get; set; }
        public int? CdPrecedente { get; set; }
        public string EndArqModelo { get; set; }
        public string Cor { get; set; }
        public bool FlProdutoSerie { get; set; }
        public bool FlBloqueiaEstoque { get; set; }
        public bool? FlPreVenda { get; set; }
        public bool? FlOrdemServico { get; set; }
        public bool? FlPrecoCusto { get; set; }
        public bool? FlExportaDavPdf { get; set; }
        public string EndArqModeloPdf { get; set; }
        public string FlEnviaEmail { get; set; }
        public string FlIpi { get; set; }
        public string FlIcmsst { get; set; }
        public bool? FlPedComp { get; set; }

        public Situacao CdPrecedenteNavigation { get; set; }
        public ICollection<Situacao> InverseCdPrecedenteNavigation { get; set; }
        public ICollection<OrcamentoC> OrcamentoC { get; set; }
    }
}
