using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class MovimentoCxa
    {
        public MovimentoCxa()
        {
            CrptituloMovimentoCxa = new HashSet<CrptituloMovimentoCxa>();
            MovimentoSeguradora = new HashSet<MovimentoSeguradora>();
        }

        public int CdFilial { get; set; }
        public int NrLcto { get; set; }
        public int CdCaixa { get; set; }
        public DateTime? DtMvto { get; set; }
        public int? CdConta { get; set; }
        public string Complemento { get; set; }
        public decimal? VlEntrada { get; set; }
        public decimal? VlSaida { get; set; }
        public int? CdBanco { get; set; }
        public string CdAgencia { get; set; }
        public string NrCc { get; set; }
        public int? CdClifor { get; set; }
        public string NmTitular { get; set; }
        public DateTime? DtBomPara { get; set; }
        public DateTime? DtAtz { get; set; }
        public string FlOrigem { get; set; }
        public int? CdHistorico { get; set; }
        public int CdFuncionario { get; set; }
        public string FlCheque { get; set; }
        public int NrSequencial { get; set; }
        public bool? FlCancelado { get; set; }
        public string NrCheque { get; set; }
        public DateTime? DtInclusao { get; set; }
        public DateTime? DtCompensacao { get; set; }
        public string MotivoDevolucao { get; set; }
        public string Destinatario { get; set; }
        public string DctoOrigem { get; set; }
        public string FlCompensado { get; set; }
        public string FlDestino { get; set; }
        public int? NrDocumento { get; set; }
        public string NrSerie { get; set; }
        public string TpCartao { get; set; }
        public short? TpIntegracao { get; set; }
        public string HashA2 { get; set; }
        public string HashH2 { get; set; }

        public Caixa Cd { get; set; }
        public CxaConta CdContaNavigation { get; set; }
        public ICollection<CrptituloMovimentoCxa> CrptituloMovimentoCxa { get; set; }
        public ICollection<MovimentoSeguradora> MovimentoSeguradora { get; set; }
    }
}
