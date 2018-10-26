using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class Funcionario
    {
        public Funcionario()
        {
            ApontamentoDeServico = new HashSet<ApontamentoDeServico>();
            Cliente = new HashSet<Cliente>();
            Comissao = new HashSet<Comissao>();
            CrptituloFuncionario = new HashSet<CrptituloFuncionario>();
            LctoFlex = new HashSet<LctoFlex>();
        }

        public int CdFilial { get; set; }
        public int CdFuncionario { get; set; }
        public string NmFuncionario { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public int CdCidade { get; set; }
        public string Cep { get; set; }
        public string Fone { get; set; }
        public string Fax { get; set; }
        public DateTime? DtAdmissao { get; set; }
        public DateTime? DtAniversario { get; set; }
        public bool? FlVendedor { get; set; }
        public decimal? CotaMensal { get; set; }
        public DateTime? DtAtz { get; set; }
        public int? CdFilialPadrao { get; set; }
        public bool? FlAlterarFilial { get; set; }
        public bool? FlControlarAcesso { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public bool? FlUsuario { get; set; }
        public int? CdCargo { get; set; }
        public int? CdCaixa { get; set; }
        public bool? FlNaoAcessaValores { get; set; }
        public string SmtpEmail { get; set; }
        public string EMail { get; set; }
        public string NmUsuarioSmtp { get; set; }
        public string FlExibeCustos { get; set; }
        public string SenhaSmtp { get; set; }
        public string SslSmtp { get; set; }
        public int? CdUsr { get; set; }
        public int? CdUsuario { get; set; }
        public char FlAtivo { get; set; }
        public string FlVeSaldoCxaEmpFechamento { get; set; }
        public string MsgPadraoNfe { get; set; }
        public int? PortaSmtp { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string Cnh { get; set; }
        public string Pis { get; set; }
        public bool FlMecanico { get; set; }
        public decimal? CustoHora { get; set; }
        public decimal? ValorVenda { get; set; }

        public Cargo Cd { get; set; }
        public ICollection<ApontamentoDeServico> ApontamentoDeServico { get; set; }
        public ICollection<Cliente> Cliente { get; set; }
        public ICollection<Comissao> Comissao { get; set; }
        public ICollection<CrptituloFuncionario> CrptituloFuncionario { get; set; }
        public ICollection<LctoFlex> LctoFlex { get; set; }
    }
}
