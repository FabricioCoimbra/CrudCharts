using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class CstPisCofins
    {
        public CstPisCofins()
        {
            TributacaoGrupoPisCofinsCofinsCompraCstNavigation = new HashSet<TributacaoGrupoPisCofins>();
            TributacaoGrupoPisCofinsCofinsVendaCstNavigation = new HashSet<TributacaoGrupoPisCofins>();
            TributacaoGrupoPisCofinsPisCompraCstNavigation = new HashSet<TributacaoGrupoPisCofins>();
            TributacaoGrupoPisCofinsPisVendaCstNavigation = new HashSet<TributacaoGrupoPisCofins>();
        }

        public string CdCstPisCofins { get; set; }
        public string Descricao { get; set; }
        public char FlTributada { get; set; }
        public char? FlEntSai { get; set; }

        public ICollection<TributacaoGrupoPisCofins> TributacaoGrupoPisCofinsCofinsCompraCstNavigation { get; set; }
        public ICollection<TributacaoGrupoPisCofins> TributacaoGrupoPisCofinsCofinsVendaCstNavigation { get; set; }
        public ICollection<TributacaoGrupoPisCofins> TributacaoGrupoPisCofinsPisCompraCstNavigation { get; set; }
        public ICollection<TributacaoGrupoPisCofins> TributacaoGrupoPisCofinsPisVendaCstNavigation { get; set; }
    }
}
