using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class ConfSpedPisCofins
    {
        public int IdGeral { get; set; }
        public string TipoEscrit { get; set; }
        public string IndSitEsp { get; set; }
        public string IndNatPj { get; set; }
        public string IndAtiv { get; set; }
        public int CodIncTrib { get; set; }
        public int? IndAproCred { get; set; }
        public int? CodTipoCont { get; set; }
        public int? IndRegCu { get; set; }
        public int CdFilial { get; set; }
        public string CodVer { get; set; }
        public string FlBasePisLucroVeic { get; set; }
        public int? IndEscri { get; set; }

        public Filial CdFilialNavigation { get; set; }
    }
}
