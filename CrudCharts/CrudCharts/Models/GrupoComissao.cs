using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class GrupoComissao
    {
        public GrupoComissao()
        {
            Comissao = new HashSet<Comissao>();
            Produto = new HashSet<Produto>();
        }

        public int CdGrupoComissao { get; set; }
        public string Descricao { get; set; }
        public decimal PcComissao { get; set; }

        public ICollection<Comissao> Comissao { get; set; }
        public ICollection<Produto> Produto { get; set; }
    }
}
