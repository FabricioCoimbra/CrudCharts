using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class ProdutoSerie
    {
        public int IdGeral { get; set; }
        public int CdFilial { get; set; }
        public string CdProduto { get; set; }
        public string NrSerie { get; set; }
        public int? NrNfs { get; set; }
        public int? NrOs { get; set; }
        public int? NrSequenciaNfs { get; set; }
        public int? IdNfei { get; set; }
        public int? NrSequenciaOs { get; set; }

        public Produto CdProdutoNavigation { get; set; }
        public Nfei IdNfeiNavigation { get; set; }
    }
}
