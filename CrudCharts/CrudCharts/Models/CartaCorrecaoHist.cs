using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class CartaCorrecaoHist
    {
        public int IdGeral { get; set; }
        public int? IdCartaCorrecao { get; set; }
        public string NmTabela { get; set; }
        public string NmCampo { get; set; }
        public string NrSequenciaItem { get; set; }
        public string CdMensagem { get; set; }
        public string ContAnt { get; set; }
        public string ContAtu { get; set; }

        public CartaCorrecao IdCartaCorrecaoNavigation { get; set; }
    }
}
