using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class Administradora
    {
        public Administradora()
        {
            AdministradoraTaxas = new HashSet<AdministradoraTaxas>();
        }

        public int CdAdministradora { get; set; }
        public string NmAdministradora { get; set; }
        public int? DiasPagamentoAdm { get; set; }
        public DateTime? DtAtz { get; set; }
        public int? DiasPagamentoLoja { get; set; }
        public int? ContaCaixa { get; set; }
        public int? CdCaixa { get; set; }
        public decimal? PcCobrancaDebito { get; set; }
        public decimal? PcCobrancaAdm { get; set; }
        public int? CdFilial { get; set; }
        public int? CdCidade { get; set; }
        public string Cnpj { get; set; }
        public string Inscricao { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public int? IdBandeira { get; set; }

        public CxaConta ContaCaixaNavigation { get; set; }
        public AdministradoraBandeira IdBandeiraNavigation { get; set; }
        public ICollection<AdministradoraTaxas> AdministradoraTaxas { get; set; }
    }
}
