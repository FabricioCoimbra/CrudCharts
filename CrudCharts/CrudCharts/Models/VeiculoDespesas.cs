using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class VeiculoDespesas
    {
        public int CdFilial { get; set; }
        public string CdProduto { get; set; }
        public int NrSequencial { get; set; }
        public DateTime? DtCompra { get; set; }
        public decimal? VlCompra { get; set; }
        public decimal? VlFrete { get; set; }
        public decimal? VlServicos { get; set; }
        public decimal? VlPecas { get; set; }
        public decimal? VlServTerceiros { get; set; }
        public decimal? VlDespachante { get; set; }
        public decimal? VlComissao { get; set; }
        public string Observacao { get; set; }
        public decimal? CustoTotal { get; set; }
        public decimal? VlCompraReal { get; set; }
        public decimal? VlVendaReal { get; set; }
        public int? DctoVenda { get; set; }
        public decimal? VlIpva { get; set; }
        public int? IdNfei { get; set; }

        public Nfei IdNfeiNavigation { get; set; }
        public Nfsc Nfsc { get; set; }
    }
}
