using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class CobConvenio
    {
        public CobConvenio()
        {
            CobBordero = new HashSet<CobBordero>();
            CobConvenioAtributo = new HashSet<CobConvenioAtributo>();
            CobConvenioFormaPgto = new HashSet<CobConvenioFormaPgto>();
            CobParcela = new HashSet<CobParcela>();
        }

        public int CdConvenio { get; set; }
        public string NmConvenio { get; set; }
        public string FlRemessa { get; set; }
        public string FlRetornoRemessa { get; set; }
        public string FlEmissor { get; set; }
        public string FlAceite { get; set; }
        public string NrConvenio { get; set; }
        public long NrSequencial { get; set; }
        public long? NrUltimaRemessa { get; set; }
        public string Mensagem { get; set; }
        public string FlPadraoRemessa { get; set; }
        public string FlProtesto { get; set; }
        public short NrDiasProtesto { get; set; }
        public string MensagemProtesto { get; set; }
        public string LocalPagamento { get; set; }
        public string NrAgencia { get; set; }
        public string NrDvAgencia { get; set; }
        public int NrBanco { get; set; }
        public string NrConta { get; set; }
        public string NrDvConta { get; set; }
        public string NrDvBanco { get; set; }
        public string TpCobranca { get; set; }
        public string SgEspecie { get; set; }
        public string NmAgencia { get; set; }
        public string UnidadeCedente { get; set; }
        public decimal? OpConta { get; set; }
        public string NmBanco { get; set; }
        public string Diretorio { get; set; }
        public string CdInstrucao1 { get; set; }
        public string CdInstrucao2 { get; set; }
        public int? NrDiasBaixa { get; set; }
        public int? CdCaixa { get; set; }
        public string DiretorioRemessa { get; set; }
        public string DiretorioRetorno { get; set; }
        public string FlDebAutomatico { get; set; }
        public string FlNrNfs { get; set; }
        public string LayoutBoleto { get; set; }
        public bool? FlSincNrSeq { get; set; }

        public ICollection<CobBordero> CobBordero { get; set; }
        public ICollection<CobConvenioAtributo> CobConvenioAtributo { get; set; }
        public ICollection<CobConvenioFormaPgto> CobConvenioFormaPgto { get; set; }
        public ICollection<CobParcela> CobParcela { get; set; }
    }
}
