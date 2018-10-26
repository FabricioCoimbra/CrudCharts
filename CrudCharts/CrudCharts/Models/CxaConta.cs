using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class CxaConta
    {
        public CxaConta()
        {
            Administradora = new HashSet<Administradora>();
            Crptitulo = new HashSet<Crptitulo>();
            Filial = new HashSet<Filial>();
            MovimentoCxa = new HashSet<MovimentoCxa>();
            Nfec = new HashSet<Nfec>();
            Nfei = new HashSet<Nfei>();
            Nfsi = new HashSet<Nfsi>();
            OperacaoEs = new HashSet<OperacaoEs>();
        }

        public int CdConta { get; set; }
        public string NmConta { get; set; }
        public string CdCompleto { get; set; }
        public int GrauSuperior { get; set; }
        public int TpConta { get; set; }
        public DateTime DtAtz { get; set; }
        public int? CdHistorico { get; set; }
        public int? CdFilial { get; set; }
        public string FlFixvar { get; set; }
        public int? CdContaContabil { get; set; }
        public char? FlAtivo { get; set; }
        public string FlFranquia { get; set; }

        public ContaContabil CdContaContabilNavigation { get; set; }
        public ICollection<Administradora> Administradora { get; set; }
        public ICollection<Crptitulo> Crptitulo { get; set; }
        public ICollection<Filial> Filial { get; set; }
        public ICollection<MovimentoCxa> MovimentoCxa { get; set; }
        public ICollection<Nfec> Nfec { get; set; }
        public ICollection<Nfei> Nfei { get; set; }
        public ICollection<Nfsi> Nfsi { get; set; }
        public ICollection<OperacaoEs> OperacaoEs { get; set; }
    }
}
