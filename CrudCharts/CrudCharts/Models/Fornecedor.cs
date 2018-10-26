using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class Fornecedor
    {
        public Fornecedor()
        {
            FornecedorContato = new HashSet<FornecedorContato>();
            Fornveic = new HashSet<Fornveic>();
            Mdfe = new HashSet<Mdfe>();
            MdfeCondutor = new HashSet<MdfeCondutor>();
            Motorista = new HashSet<Motorista>();
            MovimentoSeguradora = new HashSet<MovimentoSeguradora>();
        }

        public int CdFilial { get; set; }
        public int CdFornecedor { get; set; }
        public string NmFornecedor { get; set; }
        public string NmFantasia { get; set; }
        public string FlFornecedor { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public int CdCidade { get; set; }
        public string Cep { get; set; }
        public string Fone { get; set; }
        public string Fax { get; set; }
        public string PessoaContato { get; set; }
        public DateTime? DtCadastro { get; set; }
        public string Cnpj { get; set; }
        public string Inscricao { get; set; }
        public string ObservacaoFornecedor { get; set; }
        public string EMail { get; set; }
        public string Celular { get; set; }
        public DateTime? DtAtz { get; set; }
        public int? CdCliente { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public int? CdContaContabil { get; set; }
        public string InscricaoSuframa { get; set; }
        public string FlTransportador { get; set; }
        public string FlSimples { get; set; }
        public char? FlAgricultor { get; set; }
        public char? FlAtivo { get; set; }
        public string Rntrc { get; set; }
        public string FlSeguradora { get; set; }
        public bool? FlContNcont { get; set; }

        public ContaContabil CdContaContabilNavigation { get; set; }
        public ICollection<FornecedorContato> FornecedorContato { get; set; }
        public ICollection<Fornveic> Fornveic { get; set; }
        public ICollection<Mdfe> Mdfe { get; set; }
        public ICollection<MdfeCondutor> MdfeCondutor { get; set; }
        public ICollection<Motorista> Motorista { get; set; }
        public ICollection<MovimentoSeguradora> MovimentoSeguradora { get; set; }
    }
}
