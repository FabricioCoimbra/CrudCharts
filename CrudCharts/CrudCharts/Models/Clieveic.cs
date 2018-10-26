using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class Clieveic
    {
        public int CdFilial { get; set; }
        public int CdCliente { get; set; }
        public string PlacaVeiculo { get; set; }
        public bool? FlProprietario { get; set; }
        public string NmVeiculo { get; set; }
        public int AnoFabricacao { get; set; }
        public string NrFrota { get; set; }
        public string Obs { get; set; }
        public string Cor { get; set; }
        public string Motor { get; set; }
        public string NrChassi { get; set; }
        public int CdMontadora { get; set; }
        public DateTime? DtAtz { get; set; }
        public string Renavan { get; set; }
        public int? CdVeiculo { get; set; }

        public Cliente Cd { get; set; }
        public Veiculo CdNavigation { get; set; }
    }
}
