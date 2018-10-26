using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class MensagemNota
    {
        public MensagemNota()
        {
            Cst = new HashSet<Cst>();
            FilialCdMensagemCupomNavigation = new HashSet<Filial>();
            FilialCdMensagemDavNavigation = new HashSet<Filial>();
            FilialCdMensagemIcmStNotaDevNavigation = new HashSet<Filial>();
            FilialCdMensagemPreVendaNavigation = new HashSet<Filial>();
            Msggrupo = new HashSet<Msggrupo>();
            NfecMensagem = new HashSet<NfecMensagem>();
            NfscMensagem = new HashSet<NfscMensagem>();
            OperacaoEs = new HashSet<OperacaoEs>();
            TributacaoAliquota = new HashSet<TributacaoAliquota>();
        }

        public int CdMensagem { get; set; }
        public string NmMensagem { get; set; }
        public string FlFiscal { get; set; }
        public string Mensagem { get; set; }
        public char FlInformacoesFisco { get; set; }

        public ICollection<Cst> Cst { get; set; }
        public ICollection<Filial> FilialCdMensagemCupomNavigation { get; set; }
        public ICollection<Filial> FilialCdMensagemDavNavigation { get; set; }
        public ICollection<Filial> FilialCdMensagemIcmStNotaDevNavigation { get; set; }
        public ICollection<Filial> FilialCdMensagemPreVendaNavigation { get; set; }
        public ICollection<Msggrupo> Msggrupo { get; set; }
        public ICollection<NfecMensagem> NfecMensagem { get; set; }
        public ICollection<NfscMensagem> NfscMensagem { get; set; }
        public ICollection<OperacaoEs> OperacaoEs { get; set; }
        public ICollection<TributacaoAliquota> TributacaoAliquota { get; set; }
    }
}
