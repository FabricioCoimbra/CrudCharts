using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class Propriedade
    {
        public Propriedade()
        {
            ClientePropriedade = new HashSet<ClientePropriedade>();
            ReceitaAgro = new HashSet<ReceitaAgro>();
        }

        public int CdPropriedade { get; set; }
        public string NmPropriedade { get; set; }
        public string Endereco { get; set; }
        public string CaixaPostal { get; set; }
        public string Cep { get; set; }
        public int? CdCidade { get; set; }
        public string Cnpj { get; set; }
        public string Ie { get; set; }
        public string Incra { get; set; }
        public double? Area { get; set; }
        public int? CdContato { get; set; }
        public string Telefone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public int? CdCliente { get; set; }
        public int? CdFilial { get; set; }

        public Cliente Cd { get; set; }
        public Cidade CdCidadeNavigation { get; set; }
        public Contato CdContatoNavigation { get; set; }
        public ICollection<ClientePropriedade> ClientePropriedade { get; set; }
        public ICollection<ReceitaAgro> ReceitaAgro { get; set; }
    }
}
