using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class TributacaoGrupoPisCofins
    {
        public TributacaoGrupoPisCofins()
        {
            OperacaoEs = new HashSet<OperacaoEs>();
            Produto = new HashSet<Produto>();
        }

        public int CdTributacao { get; set; }
        public string NmTributacao { get; set; }
        public string PisCompraCst { get; set; }
        public decimal? PisCompraPcAliq { get; set; }
        public string PisVendaCst { get; set; }
        public decimal? PisVendaPcAliq { get; set; }
        public string CofinsCompraCst { get; set; }
        public decimal? CofinsCompraPcAliq { get; set; }
        public string CofinsVendaCst { get; set; }
        public decimal? CofinsVendaPcAliq { get; set; }
        public DateTime? DtAtz { get; set; }
        public string PisDevCompraCst { get; set; }
        public decimal? PisDevCompraPcAliq { get; set; }
        public string PisDevVendaCst { get; set; }
        public decimal? PisDevVendaPcAliq { get; set; }
        public string CofinsDevCompraCst { get; set; }
        public decimal? CofinsDevCompraPcAliq { get; set; }
        public string CofinsDevVendaCst { get; set; }
        public decimal? CofinsDevVendaPcAliq { get; set; }

        public CstPisCofins CofinsCompraCstNavigation { get; set; }
        public CstPisCofins CofinsVendaCstNavigation { get; set; }
        public CstPisCofins PisCompraCstNavigation { get; set; }
        public CstPisCofins PisVendaCstNavigation { get; set; }
        public ICollection<OperacaoEs> OperacaoEs { get; set; }
        public ICollection<Produto> Produto { get; set; }
    }
}
