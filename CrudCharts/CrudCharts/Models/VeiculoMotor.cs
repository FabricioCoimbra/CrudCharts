using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class VeiculoMotor
    {
        public VeiculoMotor()
        {
            VeiculoModeloMotor = new HashSet<VeiculoModeloMotor>();
            Veiprod = new HashSet<Veiprod>();
        }

        public int CdMotor { get; set; }
        public string Descricao { get; set; }
        public DateTime? DtAtz { get; set; }

        public ICollection<VeiculoModeloMotor> VeiculoModeloMotor { get; set; }
        public ICollection<Veiprod> Veiprod { get; set; }
    }
}
