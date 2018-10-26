using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class VeiculoComplemento
    {
        public VeiculoComplemento()
        {
            VeiculoModeloComplemento = new HashSet<VeiculoModeloComplemento>();
            Veiprod = new HashSet<Veiprod>();
        }

        public int CdComplemento { get; set; }
        public string Descricao { get; set; }
        public DateTime? DtAtz { get; set; }

        public ICollection<VeiculoModeloComplemento> VeiculoModeloComplemento { get; set; }
        public ICollection<Veiprod> Veiprod { get; set; }
    }
}
