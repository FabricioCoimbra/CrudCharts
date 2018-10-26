using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class Impfiscal
    {
        public Impfiscal()
        {
            DocNaoFiscalC = new HashSet<DocNaoFiscalC>();
            ImpfiscalAliquota = new HashSet<ImpfiscalAliquota>();
            Nfsc = new HashSet<Nfsc>();
            PafecfE3 = new HashSet<PafecfE3>();
            ReducaoZ = new HashSet<ReducaoZ>();
        }

        public int CdImpfiscal { get; set; }
        public string NmImpfiscal { get; set; }
        public int CdModelo { get; set; }
        public string NrSerie { get; set; }
        public string PortaComunicacao { get; set; }
        public DateTime? DtAtz { get; set; }
        public string NmDinheiro { get; set; }
        public string NmCheque { get; set; }
        public string NmCartao { get; set; }
        public string NmOutros { get; set; }
        public string NmAPrazo { get; set; }
        public bool FlIntervencao { get; set; }
        public int? NrPdv { get; set; }
        public string NmModelo { get; set; }
        public string FlMfAdicional { get; set; }
        public int CdUsuarioEcf { get; set; }
        public string Cniee { get; set; }
        public string Tipo { get; set; }
        public string NmMarca { get; set; }
        public string VersaoSb { get; set; }
        public DateTime? DtInstalacaoSb { get; set; }
        public TimeSpan? HrInstalacaoSb { get; set; }
        public string FlLmfAutomatica { get; set; }
        public string NmConsultaCheque { get; set; }
        public string HashImpfiscalE1 { get; set; }
        public string HashImpfiscalR1 { get; set; }
        public string HashImpfiscalR2 { get; set; }
        public string HashImpfiscalR3 { get; set; }
        public string HashImpfiscalR4 { get; set; }
        public string HashImpfiscalR5 { get; set; }
        public string HashImpfiscalR6 { get; set; }
        public string HashImpfiscalR7 { get; set; }

        public ICollection<DocNaoFiscalC> DocNaoFiscalC { get; set; }
        public ICollection<ImpfiscalAliquota> ImpfiscalAliquota { get; set; }
        public ICollection<Nfsc> Nfsc { get; set; }
        public ICollection<PafecfE3> PafecfE3 { get; set; }
        public ICollection<ReducaoZ> ReducaoZ { get; set; }
    }
}
