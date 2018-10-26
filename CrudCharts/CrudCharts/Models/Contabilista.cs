using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class Contabilista
    {
        public int CdFilial { get; set; }
        public int CdContabilista { get; set; }
        public string NmContabilista { get; set; }
        public string Cpf { get; set; }
        public string Crc { get; set; }
        public string CnpjEscritorioCont { get; set; }
        public string Cep { get; set; }
        public string Endereco { get; set; }
        public int? Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Fone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public int CdCidade { get; set; }
    }
}
