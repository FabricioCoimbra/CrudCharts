using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class ProdutoClassFiscal
    {
        public ProdutoClassFiscal()
        {
            Produto = new HashSet<Produto>();
            ProdutoClassFiscalMva = new HashSet<ProdutoClassFiscalMva>();
            ProtocoloIcmsClassFiscal = new HashSet<ProtocoloIcmsClassFiscal>();
        }

        public string CdClassFiscal { get; set; }
        public string NmClassFiscal { get; set; }
        public DateTime? DtAtz { get; set; }
        public string Descricao { get; set; }
        public double? AliqIpi { get; set; }
        public string CstIpiCompra { get; set; }
        public string CstIpiVenda { get; set; }
        public string CstPisCompra { get; set; }
        public string CstPisVenda { get; set; }
        public string CstCofinsCompra { get; set; }
        public string CstCofinsVenda { get; set; }
        public string FlCalcularPisCofins { get; set; }
        public string FlReducaoMvaSimples { get; set; }
        public string CdEnquadramentoCompra { get; set; }
        public string CdEnquadramentoVenda { get; set; }
        public int? CdCest { get; set; }
        public string UnTrib { get; set; }

        public ICollection<Produto> Produto { get; set; }
        public ICollection<ProdutoClassFiscalMva> ProdutoClassFiscalMva { get; set; }
        public ICollection<ProtocoloIcmsClassFiscal> ProtocoloIcmsClassFiscal { get; set; }
    }
}
