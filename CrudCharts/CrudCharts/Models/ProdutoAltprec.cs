using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class ProdutoAltprec
    {
        public int IdGeral { get; set; }
        public string CdProduto { get; set; }
        public int CdFuncionario { get; set; }
        public DateTime DtAlteracao { get; set; }
        public string NmForm { get; set; }
        public string DescForm { get; set; }
        public decimal PrecoVendaAnt { get; set; }
        public decimal PrecoVendaNovo { get; set; }
        public decimal PrecoVendaMinAnt { get; set; }
        public decimal PrecoVendaMinNovo { get; set; }
        public decimal PrecoVendaFlexMaxAnt { get; set; }
        public decimal PrecoVendaFlexMaxNovo { get; set; }
        public decimal PrecoVendaFlexMinAnt { get; set; }
        public decimal PrecoVendaFlexMinNovo { get; set; }
        public int? CdTabelaPreco { get; set; }
        public TimeSpan? HrAlteracao { get; set; }
        public int? IdNfec { get; set; }
    }
}
