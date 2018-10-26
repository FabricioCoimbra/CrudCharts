using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class AcessoAcaoRelFiltro
    {
        public long Id { get; set; }
        public long IdAcao { get; set; }
        public string NmFiltro { get; set; }
        public string NmParametroSql { get; set; }
        public string NmCampo { get; set; }
        public string Comentario { get; set; }
        public string RotuloFiltro { get; set; }
        public int? CdConsulta { get; set; }
        public string TipoDado { get; set; }
        public int NrOrdem { get; set; }
        public string ValorPadrao { get; set; }
        public string Multivalor { get; set; }
        public string NmCampoRetorno { get; set; }
        public string TipoDadoParametro { get; set; }
        public string FlSelecaoMultipla { get; set; }

        public AcessoAcaoRelatorio IdAcaoNavigation { get; set; }
    }
}
