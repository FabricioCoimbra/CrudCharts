using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class ComissaoFuncDev
    {
        public int CdFilial { get; set; }
        public int NrDocumento { get; set; }
        public int NrSequencia { get; set; }
        public int CdFuncionario { get; set; }
        public int NrParcela { get; set; }
        public int NrSequenciaDev { get; set; }
        public double VlBase { get; set; }
        public double PcComissao { get; set; }
        public double VlComissao { get; set; }
        public int IdNfecDev { get; set; }

        public Nfec IdNfecDevNavigation { get; set; }
    }
}
