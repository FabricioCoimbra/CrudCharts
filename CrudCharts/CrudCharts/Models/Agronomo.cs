using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class Agronomo
    {
        public int CdAgronomo { get; set; }
        public string NmAgronomo { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string Complemento { get; set; }
        public int? Numero { get; set; }
        public int? CdCrea { get; set; }
        public string CreaRegistro { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public string Obs { get; set; }
        public int? CdCidade { get; set; }
        public int CdFilial { get; set; }
        public string Cep { get; set; }

        public Cidade CdCidadeNavigation { get; set; }
    }
}
