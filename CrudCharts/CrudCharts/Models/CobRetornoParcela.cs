using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class CobRetornoParcela
    {
        public long IdGeral { get; set; }
        public long CdRetorno { get; set; }
        public string NrNossoNumero { get; set; }
        public string IdParcela { get; set; }
        public string CdMovimentoRetorno { get; set; }
        public string CdMotivoMovimentoRetorno1 { get; set; }
        public string CdMotivoMovimentoRetorno2 { get; set; }
        public string CdMotivoMovimentoRetorno3 { get; set; }
        public string CdMotivoMovimentoRetorno4 { get; set; }
        public string CdMotivoMovimentoRetorno5 { get; set; }
        public DateTime DtOcorrencia { get; set; }
        public DateTime? DtCredito { get; set; }
        public DateTime? DtDebitoTarifa { get; set; }
        public decimal VlDespesaCobranca { get; set; }
        public decimal VlAcrescimo { get; set; }
        public decimal VlDesconto { get; set; }
        public decimal VlAbatimento { get; set; }
        public decimal VlIof { get; set; }
        public decimal VlPago { get; set; }
        public decimal VlLiquido { get; set; }
        public decimal VlOutrasDespesas { get; set; }
        public decimal VlOutrosCreditos { get; set; }
        public string FlProcessado { get; set; }
        public decimal VlTarifa { get; set; }

        public CobRetorno CdRetornoNavigation { get; set; }
    }
}
