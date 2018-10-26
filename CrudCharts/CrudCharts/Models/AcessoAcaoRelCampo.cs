using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class AcessoAcaoRelCampo
    {
        public long IdGeral { get; set; }
        public long IdAcao { get; set; }
        public long NrOrdem { get; set; }
        public string NmCampo { get; set; }
        public char FlGrid { get; set; }
        public char? FlTipoSumarizacao { get; set; }
        public string NmTituloCampo { get; set; }
        public char? FlGrafico { get; set; }
        public string TipoCampo { get; set; }
        public int? Topo { get; set; }
        public int? Esquerda { get; set; }

        public AcessoAcao IdAcaoNavigation { get; set; }
    }
}
