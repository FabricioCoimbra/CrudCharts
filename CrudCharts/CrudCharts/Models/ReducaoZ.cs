using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class ReducaoZ
    {
        public ReducaoZ()
        {
            ReducaoZTotalizador = new HashSet<ReducaoZTotalizador>();
        }

        public int CdImpfiscal { get; set; }
        public DateTime DtReducao { get; set; }
        public int ContadorZ { get; set; }
        public decimal? VlSubstituicao { get; set; }
        public decimal? VlIsento { get; set; }
        public decimal? VlCancelamento { get; set; }
        public decimal? VlNaoIncidente { get; set; }
        public decimal? VlDesconto { get; set; }
        public decimal? VlGt { get; set; }
        public decimal? VlBruto { get; set; }
        public int Cro { get; set; }
        public int NrCupomInicial { get; set; }
        public int NrCupomFinal { get; set; }
        public int? Coo { get; set; }
        public TimeSpan? HrEmissao { get; set; }
        public DateTime? DtEmissao { get; set; }
        public string FlIncidenciaDescIss { get; set; }
        public decimal? IcmVlCancelamento { get; set; }
        public decimal? IcmVlDesconto { get; set; }
        public decimal? IcmVlAcrescimo { get; set; }
        public decimal? IssVlCancelamento { get; set; }
        public decimal? IssVlDesconto { get; set; }
        public decimal? IssVlAcrescimo { get; set; }
        public decimal? VlOpnf { get; set; }
        public string MfAdicional { get; set; }
        public decimal? VlAcrescimo { get; set; }
        public string HashReducaoZR2 { get; set; }
        public string HashReducaoZR3 { get; set; }
        public string FlReducaoEnviada { get; set; }
        public string FlEstoqueEnviado { get; set; }
        public string CamArqReducao { get; set; }
        public string CamArqEstoque { get; set; }

        public Impfiscal CdImpfiscalNavigation { get; set; }
        public ICollection<ReducaoZTotalizador> ReducaoZTotalizador { get; set; }
    }
}
