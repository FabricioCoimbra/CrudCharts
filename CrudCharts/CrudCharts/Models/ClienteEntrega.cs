using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class ClienteEntrega
    {
        public int IdGeral { get; set; }
        public int CdCliente { get; set; }
        public int NrSequencia { get; set; }
        public string NmLocal { get; set; }
        public string EnderecoLogradouro { get; set; }
        public string EnderecoNumero { get; set; }
        public string EnderecoComplemento { get; set; }
        public string Bairro { get; set; }
        public string Cep { get; set; }
        public int? CdCidade { get; set; }
        public string Telefone { get; set; }
        public string Fax { get; set; }
        public string Celular { get; set; }
        public string EMail { get; set; }
        public string Obs { get; set; }
        public string NrAutorizacao { get; set; }

        public Cidade CdCidadeNavigation { get; set; }
        public Cliente CdClienteNavigation { get; set; }
    }
}
