using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class Cliente
    {
        public Cliente()
        {
            ClienteContato = new HashSet<ClienteContato>();
            ClienteEntrega = new HashSet<ClienteEntrega>();
            ClientePropriedade = new HashSet<ClientePropriedade>();
            ClienteResumoFinanceiro = new HashSet<ClienteResumoFinanceiro>();
            Clieveic = new HashSet<Clieveic>();
            MovimentoSeguradora = new HashSet<MovimentoSeguradora>();
            Nfsc = new HashSet<Nfsc>();
            ProdutoCliente = new HashSet<ProdutoCliente>();
            Propriedade = new HashSet<Propriedade>();
            ReceitaAgro = new HashSet<ReceitaAgro>();
        }

        public int CdFilial { get; set; }
        public int CdCliente { get; set; }
        public string NmClifor { get; set; }
        public string NmFantasia { get; set; }
        public string FlClifor { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public int CdCidade { get; set; }
        public string Cep { get; set; }
        public string Fone { get; set; }
        public string Fax { get; set; }
        public string PessoaContato { get; set; }
        public DateTime? DtCadastro { get; set; }
        public DateTime? DtAniversario { get; set; }
        public string TpPessoa { get; set; }
        public string CgcCpf { get; set; }
        public string LocalTrabalho { get; set; }
        public string FoneTrabalho { get; set; }
        public string Inscricao { get; set; }
        public string ObservacaoClifor { get; set; }
        public bool? FlContNcont { get; set; }
        public bool? FlSimples { get; set; }
        public string EMail { get; set; }
        public string Celular { get; set; }
        public int? CdVendedor { get; set; }
        public decimal? LimiteCredito { get; set; }
        public string NmConjuge { get; set; }
        public string RgConjuge { get; set; }
        public string CpfConjuge { get; set; }
        public DateTime? DtNascConj { get; set; }
        public string TrabConj { get; set; }
        public string FoneCom { get; set; }
        public decimal? Salario { get; set; }
        public string ObsConj { get; set; }
        public int? CdFornecedor { get; set; }
        public bool? FlSpc { get; set; }
        public DateTime? DtSpc { get; set; }
        public DateTime? DtAtz { get; set; }
        public DateTime? DtAdmissao { get; set; }
        public string NmPai { get; set; }
        public string NmMae { get; set; }
        public string LocalNasc { get; set; }
        public string FlImprimirFatura { get; set; }
        public string FlAgricultor { get; set; }
        public string Tipo { get; set; }
        public bool? FlBloqueado { get; set; }
        public string MotivoBloqueio { get; set; }
        public int? CodFuncBloqueou { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string FlAtivo { get; set; }
        public int? CdContaContabil { get; set; }
        public short CdGrupoCliente { get; set; }
        public string InscricaoSuframa { get; set; }
        public string HashClienteD2 { get; set; }
        public string FlClienteRedeUniagro { get; set; }
        public string Cargo { get; set; }
        public string LocalTrabalhoConjuge { get; set; }
        public string FoneTrabalhoConjuge { get; set; }
        public DateTime? DtAdmissaoConjuge { get; set; }
        public decimal? RendaConjuge { get; set; }
        public string CargoConjuge { get; set; }
        public string Ref1 { get; set; }
        public string Ref2 { get; set; }
        public string TelRef1 { get; set; }
        public string TelRef2 { get; set; }
        public string Ref3 { get; set; }
        public string Ref4 { get; set; }
        public string TelRef3 { get; set; }
        public string TelRef4 { get; set; }
        public bool? FlExibeObs { get; set; }
        public string Im { get; set; }
        public decimal? FlOdPesferico { get; set; }
        public decimal? FlOdPcilindrico { get; set; }
        public decimal? FlOdPeixo { get; set; }
        public decimal? FlEsPesferico { get; set; }
        public decimal? FlEsPcilindrico { get; set; }
        public decimal? FlEsPeixo { get; set; }
        public decimal? FlOdLesferico { get; set; }
        public decimal? FlOdLcilindrico { get; set; }
        public decimal? FlOdLeixo { get; set; }
        public decimal? FlEsLesferico { get; set; }
        public decimal? FlEsLcilindrico { get; set; }
        public decimal? FlEsLeixo { get; set; }
        public string MotivoProtesto { get; set; }
        public bool? FlProtestado { get; set; }
        public int? CdFuncProtestou { get; set; }

        public Funcionario Cd { get; set; }
        public ContaContabil CdContaContabilNavigation { get; set; }
        public Filial CdFilialNavigation { get; set; }
        public ICollection<ClienteContato> ClienteContato { get; set; }
        public ICollection<ClienteEntrega> ClienteEntrega { get; set; }
        public ICollection<ClientePropriedade> ClientePropriedade { get; set; }
        public ICollection<ClienteResumoFinanceiro> ClienteResumoFinanceiro { get; set; }
        public ICollection<Clieveic> Clieveic { get; set; }
        public ICollection<MovimentoSeguradora> MovimentoSeguradora { get; set; }
        public ICollection<Nfsc> Nfsc { get; set; }
        public ICollection<ProdutoCliente> ProdutoCliente { get; set; }
        public ICollection<Propriedade> Propriedade { get; set; }
        public ICollection<ReceitaAgro> ReceitaAgro { get; set; }
    }
}
