using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class NfContabilC
    {
        public NfContabilC()
        {
            NfContabilCfop = new HashSet<NfContabilCfop>();
            NfContabilI = new HashSet<NfContabilI>();
        }

        public int IdGeral { get; set; }
        public int? CdFilial { get; set; }
        public int? IdNfc { get; set; }
        public string FlEntradaSaida { get; set; }
        public long? NrNf { get; set; }
        public int? NrCupom { get; set; }
        public int? CdClifor { get; set; }
        public string SerieNf { get; set; }
        public string CliforCnpjCpf { get; set; }
        public string CliforIeRg { get; set; }
        public string UfDestino { get; set; }
        public string UfOrigem { get; set; }
        public DateTime? DtEmissao { get; set; }
        public string CdModelo { get; set; }
        public string FlImpresso { get; set; }
        public decimal? IcmsNormalBase { get; set; }
        public decimal? IcmsNormalVl { get; set; }
        public decimal? IcmsProprioBase { get; set; }
        public decimal? IcmsProprioVl { get; set; }
        public decimal? IcmsStBase { get; set; }
        public decimal? IcmsStVl { get; set; }
        public decimal? IssBase { get; set; }
        public decimal? IssVl { get; set; }
        public decimal? IpiBase { get; set; }
        public decimal? IpiVl { get; set; }
        public decimal? PisVlBase { get; set; }
        public decimal? PisVl { get; set; }
        public decimal? CofinsVlBase { get; set; }
        public decimal? CofinsVl { get; set; }
        public decimal? VlDescontoItem { get; set; }
        public decimal? VlDesconto { get; set; }
        public decimal? VlAcrescimo { get; set; }
        public decimal? VlSeguro { get; set; }
        public decimal? VlFrete { get; set; }
        public decimal? VlTotal { get; set; }
        public decimal? VlIsentoItens { get; set; }
        public decimal? VlOutrosItens { get; set; }
        public int? EcfCd { get; set; }
        public string EcfNrFabricacao { get; set; }
        public int? EcfNrPdv { get; set; }
        public string FlCancelado { get; set; }
        public string Obs { get; set; }
        public string NmOperacao { get; set; }
        public decimal? VlMercadorias { get; set; }
        public decimal? VlServicos { get; set; }
        public int? CondPgto { get; set; }
        public int? CdTransportadora { get; set; }
        public DateTime? DtEntradaSaida { get; set; }
        public decimal? FreteVlIcm { get; set; }
        public string FreteCfop { get; set; }
        public string SubSerie { get; set; }
        public decimal? IcmsStAntBase { get; set; }
        public decimal? IcmsStAntVl { get; set; }
        public TimeSpan? HrEmissao { get; set; }
        public int? EcfNrCooCupom { get; set; }
        public string FlSimples { get; set; }
        public string NfeChaveAcesso { get; set; }
        public string NfeNrProtocolo { get; set; }
        public DateTime? NfeDtProcessamento { get; set; }
        public int? NfeTpEmissao { get; set; }
        public string NfeNrLote { get; set; }
        public string NfeNrRecibo { get; set; }
        public decimal? VlFcp { get; set; }
        public decimal? VlFcpSt { get; set; }
        public decimal? VlFcpStRetido { get; set; }
        public decimal? VlIcmsUfDest { get; set; }
        public decimal? VlIcmsUfRemet { get; set; }
        public decimal? VlFcpUfDest { get; set; }

        public ICollection<NfContabilCfop> NfContabilCfop { get; set; }
        public ICollection<NfContabilI> NfContabilI { get; set; }
    }
}
