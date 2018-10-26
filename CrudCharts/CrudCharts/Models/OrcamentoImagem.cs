using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class OrcamentoImagem
    {
        public int IdGeral { get; set; }
        public int NrOs { get; set; }
        public string Obs { get; set; }
        public string Imagem { get; set; }
        public DateTime DtAtz { get; set; }
    }
}
