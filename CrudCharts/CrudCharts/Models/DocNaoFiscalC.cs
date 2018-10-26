using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class DocNaoFiscalC
    {
        public DocNaoFiscalC()
        {
            DocNaoFiscalI = new HashSet<DocNaoFiscalI>();
        }

        public long IdGeral { get; set; }
        public int CdEcf { get; set; }
        public string FlMfAdicional { get; set; }
        public int? Coo { get; set; }
        public int? NrDoc { get; set; }
        public string TipoDoc { get; set; }
        public DateTime DtEmissao { get; set; }
        public TimeSpan? HrEmissao { get; set; }
        public int? Gnf { get; set; }
        public string HashDocNaoFiscalCR6 { get; set; }
        public string HashDocNaoFiscalCR7 { get; set; }
        public int? NrDctoNfsc { get; set; }

        public Impfiscal CdEcfNavigation { get; set; }
        public ICollection<DocNaoFiscalI> DocNaoFiscalI { get; set; }
    }
}
