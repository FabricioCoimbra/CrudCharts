using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class CobParcela
    {
        public CobParcela()
        {
            CobBorderoParcela = new HashSet<CobBorderoParcela>();
        }

        public long IdGeral { get; set; }
        public decimal? VlParcela { get; set; }
        public string NmCedente { get; set; }
        public string IdSistemaOrigem { get; set; }
        public string NmEspecie { get; set; }
        public string NrDocumento { get; set; }
        public string NrCarteira { get; set; }
        public DateTime DtEmissao { get; set; }
        public DateTime DtVcto { get; set; }
        public decimal VlDesconto { get; set; }
        public decimal VlOutrasDeducoes { get; set; }
        public decimal VlAbatimento { get; set; }
        public decimal VlMora { get; set; }
        public decimal VlJuros { get; set; }
        public decimal VlOutrosAcrescimos { get; set; }
        public string Instrucoes { get; set; }
        public string Observacoes { get; set; }
        public string NrNossoNumero { get; set; }
        public int? NrSequencialRemessa { get; set; }
        public int? CdConvenio { get; set; }

        public CobConvenio CdConvenioNavigation { get; set; }
        public ICollection<CobBorderoParcela> CobBorderoParcela { get; set; }
    }
}
