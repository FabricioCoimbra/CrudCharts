using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class ReceitaAgro
    {
        public DateTime? DtEmissao { get; set; }
        public int? NrArt { get; set; }
        public int NrReceita { get; set; }
        public int NrSequencia { get; set; }
        public string SerieNf { get; set; }
        public int? CdCliente { get; set; }
        public int? CdPropriedade { get; set; }
        public int CdProdserv { get; set; }
        public string Cultura { get; set; }
        public string Diagnostico { get; set; }
        public decimal? Area { get; set; }
        public string EpocaAplicacao { get; set; }
        public int? ModalidadeAplicacao { get; set; }
        public string IntervaloSeg { get; set; }
        public string Dosagem { get; set; }
        public string VolumeCalda { get; set; }
        public decimal QtTotal { get; set; }
        public string Precaucao { get; set; }
        public string Epis { get; set; }
        public string Orientacao { get; set; }
        public int? CdAgronomo { get; set; }
        public string QtAplicacao { get; set; }
        public int NrNf { get; set; }
        public int CdFilial { get; set; }

        public Cliente Cd { get; set; }
        public Propriedade CdPropriedadeNavigation { get; set; }
    }
}
