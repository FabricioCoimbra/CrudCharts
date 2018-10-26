using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class PedidoAfvC
    {
        public int CdFilial { get; set; }
        public int NrPedido { get; set; }
        public int? CdClifor { get; set; }
        public decimal? VlAcrescimos { get; set; }
        public decimal? VlDescontos { get; set; }
        public decimal? VlMercadorias { get; set; }
        public decimal? VlServicos { get; set; }
        public decimal? VlTotal { get; set; }
        public int CdCondpgto { get; set; }
        public decimal? VlEntrada { get; set; }
        public DateTime? DtEmissao { get; set; }
        public DateTime? DtValidade { get; set; }
        public int? CdUsuario { get; set; }
        public DateTime? DtAtz { get; set; }
        public string MotivoCancelamento { get; set; }
        public string Obs { get; set; }
        public short IndicePreco { get; set; }
        public decimal? VlIpi { get; set; }
        public int CdSituacao { get; set; }
        public bool FlAgrupado { get; set; }
        public bool FlCancelado { get; set; }
        public bool FlFinalizado { get; set; }
        public DateTime? DtEntrega { get; set; }
        public char? FlTransmitido { get; set; }
        public bool? FlGerado { get; set; }
        public int? NrOsGerada { get; set; }
        public int? NrDavGerada { get; set; }
    }
}
