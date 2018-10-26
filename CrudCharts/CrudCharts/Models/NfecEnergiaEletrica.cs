using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class NfecEnergiaEletrica
    {
        public int IdNfec { get; set; }
        public string CodCons { get; set; }
        public int? TpLigacao { get; set; }
        public string CodGrupoTensao { get; set; }

        public Nfec IdNfecNavigation { get; set; }
    }
}
