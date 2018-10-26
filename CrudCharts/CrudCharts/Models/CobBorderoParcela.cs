using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class CobBorderoParcela
    {
        public long IdParcela { get; set; }
        public int CdBordero { get; set; }

        public CobBordero CdBorderoNavigation { get; set; }
        public CobParcela IdParcelaNavigation { get; set; }
    }
}
