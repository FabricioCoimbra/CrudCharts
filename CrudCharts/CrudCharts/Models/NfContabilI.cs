using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class NfContabilI
    {
        public int IdGeral { get; set; }
        public int IdNfContabilC { get; set; }
        public int NrSequencia { get; set; }
        public string CdItem { get; set; }
        public double? QtItem { get; set; }
        public decimal? VlBruto { get; set; }
        public decimal? VlDesconto { get; set; }
        public decimal? VlUnitario { get; set; }
        public decimal? VlTotal { get; set; }
        public string Cfop { get; set; }
        public string Cst { get; set; }
        public decimal? PcReducao { get; set; }
        public decimal? IcmsNormalAliq { get; set; }
        public decimal? IcmsNormalVlBase { get; set; }
        public decimal? IcmsNormalVl { get; set; }
        public decimal? IcmsProprioAliq { get; set; }
        public decimal? IcmsProprioVlBase { get; set; }
        public decimal? IcmsProprioVl { get; set; }
        public decimal? IcmsStMva { get; set; }
        public decimal? IcmsStVlBase { get; set; }
        public decimal? IcmsStVl { get; set; }
        public decimal? IssAliq { get; set; }
        public decimal? IssVlBase { get; set; }
        public decimal? IssVl { get; set; }
        public decimal? IpiAliq { get; set; }
        public decimal? IpiVlBase { get; set; }
        public decimal? IpiVl { get; set; }
        public decimal? PisAliq { get; set; }
        public decimal? PisVlBase { get; set; }
        public decimal? PisVl { get; set; }
        public decimal? CofinsAliq { get; set; }
        public decimal? CofinsVlBase { get; set; }
        public decimal? CofinsVl { get; set; }
        public decimal? VlOutros { get; set; }
        public decimal? VlIsento { get; set; }
        public decimal? VlDescontoRateado { get; set; }
        public decimal? VlAcrescimoRateado { get; set; }
        public decimal? VlFreteRateado { get; set; }
        public decimal? VlSeguroRateado { get; set; }
        public decimal? VlContabil { get; set; }
        public string FlCancelado { get; set; }
        public string UnMedida { get; set; }
        public string FlProduto { get; set; }
        public decimal? IcmsNormalPcRed { get; set; }
        public decimal? IcmsProprioPcRed { get; set; }
        public decimal? IcmsStPcRed { get; set; }
        public decimal? IcmsStAliqDestino { get; set; }
        public string UnCompraVenda { get; set; }
        public decimal? VlUnitarioCompraVenda { get; set; }
        public string IpiCst { get; set; }
        public string PisCst { get; set; }
        public string CofinsCst { get; set; }
        public decimal? VlAcrescimo { get; set; }
        public decimal? IcmsFreteVl { get; set; }
        public decimal? IcmsStAntVlBase { get; set; }
        public decimal? IcmsStAntVl { get; set; }
        public string FlSomaTotal { get; set; }
        public double? QtCompraVenda { get; set; }
        public decimal? PcFcp { get; set; }
        public decimal? VlFcp { get; set; }
        public decimal? VlBaseFcp { get; set; }
        public decimal? VlBaseFcpSt { get; set; }
        public decimal? PcFcpSt { get; set; }
        public decimal? VlFcpSt { get; set; }
        public decimal? VlFcpStRetido { get; set; }
        public decimal? PcFcpStRetido { get; set; }
        public decimal? VlBaseFcpStRetido { get; set; }
        public decimal? VlBaseFcpUfDestino { get; set; }
        public decimal? PcFcpUfDestino { get; set; }
        public decimal? VlFcpUfDestino { get; set; }
        public decimal? VlBaseUfDestino { get; set; }
        public decimal? PcIcmsUfDestino { get; set; }
        public decimal? PcIcmsInterno { get; set; }
        public decimal? PcIcmsInternoPartilha { get; set; }
        public decimal? VlIcmsUfDestino { get; set; }
        public decimal? VlIcmsUfRemetente { get; set; }

        public NfContabilC IdNfContabilCNavigation { get; set; }
    }
}
