using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class AuditorEstoqueI
    {
        public int CdFilial { get; set; }
        public int IdAuditorC { get; set; }
        public int NrSequencial { get; set; }
        public string CdProduto { get; set; }
        public decimal? QtAtual { get; set; }
        public decimal? QtDif { get; set; }
        public int? CdUsuario { get; set; }

        public AuditorEstoqueC AuditorEstoqueC { get; set; }
    }
}
