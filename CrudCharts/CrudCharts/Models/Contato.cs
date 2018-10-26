using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class Contato
    {
        public Contato()
        {
            ClienteContato = new HashSet<ClienteContato>();
            FornecedorContato = new HashSet<FornecedorContato>();
            OrcamentoContato = new HashSet<OrcamentoContato>();
            Propriedade = new HashSet<Propriedade>();
        }

        public int IdContato { get; set; }
        public string NmContato { get; set; }
        public string Departamento { get; set; }
        public string Telefone { get; set; }
        public string EMail { get; set; }
        public DateTime? DtNascimento { get; set; }
        public string EnderecoLogradouro { get; set; }
        public short? EnderecoNumero { get; set; }
        public string EnderecoComplemento { get; set; }
        public string Bairro { get; set; }
        public int? CdCidade { get; set; }
        public string Cep { get; set; }
        public string FoneComercial { get; set; }
        public string Fax { get; set; }
        public string Celular { get; set; }
        public string Obs { get; set; }
        public int TpContato { get; set; }

        public Cidade CdCidadeNavigation { get; set; }
        public ICollection<ClienteContato> ClienteContato { get; set; }
        public ICollection<FornecedorContato> FornecedorContato { get; set; }
        public ICollection<OrcamentoContato> OrcamentoContato { get; set; }
        public ICollection<Propriedade> Propriedade { get; set; }
    }
}
