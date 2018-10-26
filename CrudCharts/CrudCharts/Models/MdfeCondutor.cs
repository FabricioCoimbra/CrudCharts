using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class MdfeCondutor
    {
        public int CdFilial { get; set; }
        public int IdGeral { get; set; }
        public int? IdMdfe { get; set; }
        public int? CdFornecedor { get; set; }
        public int? CdMotorista { get; set; }
        public DateTime? DtAtz { get; set; }

        public Fornecedor CdF { get; set; }
        public Filial CdFilialNavigation { get; set; }
        public Motorista CdMotoristaNavigation { get; set; }
        public Mdfe IdMdfeNavigation { get; set; }
    }
}
