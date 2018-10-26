using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class Cargo
    {
        public Cargo()
        {
            Funcionario = new HashSet<Funcionario>();
        }

        public int CdFilial { get; set; }
        public int CdCargo { get; set; }
        public string Descricao { get; set; }
        public bool? FlLiberaLimite { get; set; }
        public DateTime DtAtz { get; set; }
        public string FlComissaoTotal { get; set; }

        public Filial CdFilialNavigation { get; set; }
        public ICollection<Funcionario> Funcionario { get; set; }
    }
}
