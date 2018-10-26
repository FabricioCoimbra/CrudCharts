using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class ConsultaCampo
    {
        public int IdGeral { get; set; }
        public int IdConsulta { get; set; }
        public string NmCampo { get; set; }
        public string NmTitulo { get; set; }
        public int? NrPosicao { get; set; }
        public int? TamanhoCampo { get; set; }
        public string TipoCampo { get; set; }

        public Consulta IdConsultaNavigation { get; set; }
    }
}
