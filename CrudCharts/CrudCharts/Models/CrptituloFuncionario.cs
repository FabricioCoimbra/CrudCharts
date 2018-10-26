using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class CrptituloFuncionario
    {
        public int CdFilial { get; set; }
        public int CdTipoConta { get; set; }
        public int CdClifor { get; set; }
        public string NrTitulo { get; set; }
        public int CdFuncionario { get; set; }
        public string Obs { get; set; }

        public Funcionario CdF { get; set; }
    }
}
