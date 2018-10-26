using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class Cst
    {
        public Cst()
        {
            TributacaoAliquota = new HashSet<TributacaoAliquota>();
        }

        public string CdCst { get; set; }
        public string NmCst { get; set; }
        public string FlDiferencaBaseTotal { get; set; }
        public string FlIcm { get; set; }
        public string FlReducao { get; set; }
        public string FlIcmSubst { get; set; }
        public int? CdMensagem { get; set; }
        public string FlSimples { get; set; }
        public string HashCstD3 { get; set; }
        public string HashCstP2 { get; set; }
        public string FlCalcPartilha { get; set; }
        public string FlPermiteCredito { get; set; }

        public MensagemNota CdMensagemNavigation { get; set; }
        public ICollection<TributacaoAliquota> TributacaoAliquota { get; set; }
    }
}
