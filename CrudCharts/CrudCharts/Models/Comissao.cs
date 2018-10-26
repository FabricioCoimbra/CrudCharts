using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class Comissao
    {
        public int CdFilial { get; set; }
        public int CdGrupoComissao { get; set; }
        public int CdFuncionario { get; set; }
        public decimal? PcSobreComissao { get; set; }
        public decimal? PcMinimo { get; set; }
        public DateTime DtAtz { get; set; }
        public bool? FlComissaoAbaixoMin { get; set; }

        public Funcionario CdF { get; set; }
        public Filial CdFilialNavigation { get; set; }
        public GrupoComissao CdGrupoComissaoNavigation { get; set; }
    }
}
