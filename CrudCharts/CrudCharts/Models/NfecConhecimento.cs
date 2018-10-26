using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class NfecConhecimento
    {
        public int IdNfec { get; set; }
        public decimal? VlFreteVolume { get; set; }
        public decimal? VlFrete { get; set; }
        public decimal? VlSecCat { get; set; }
        public decimal? VlPedagio { get; set; }
        public decimal? VlOutros { get; set; }
        public int? TpCte { get; set; }

        public Nfec IdNfecNavigation { get; set; }
    }
}
