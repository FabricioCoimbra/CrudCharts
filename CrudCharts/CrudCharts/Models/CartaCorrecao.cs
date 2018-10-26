using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class CartaCorrecao
    {
        public CartaCorrecao()
        {
            CartaCorrecaoHist = new HashSet<CartaCorrecaoHist>();
        }

        public int IdGeral { get; set; }
        public int CdFilial { get; set; }
        public int IdNf { get; set; }
        public string FlEntSai { get; set; }
        public int Sequencia { get; set; }
        public string ChaveAcessoNfe { get; set; }
        public string Protocolo { get; set; }
        public DateTime? DtAutorizacao { get; set; }
        public TimeSpan? HrAutorizacao { get; set; }
        public string Correcao { get; set; }
        public string Xml { get; set; }

        public ICollection<CartaCorrecaoHist> CartaCorrecaoHist { get; set; }
    }
}
