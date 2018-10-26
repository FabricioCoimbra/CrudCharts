using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class Consulta
    {
        public Consulta()
        {
            ConsultaCampo = new HashSet<ConsultaCampo>();
        }

        public int IdConsulta { get; set; }
        public string Identificador { get; set; }
        public string Titulo { get; set; }
        public string ComandoSql { get; set; }
        public string TabelaCadastro { get; set; }
        public int CampoInicial { get; set; }
        public string SqlAgrupamento { get; set; }
        public int? CdConexao { get; set; }
        public long? IdAcaoCadastro { get; set; }

        public AcessoAcao IdAcaoCadastroNavigation { get; set; }
        public ICollection<ConsultaCampo> ConsultaCampo { get; set; }
    }
}
