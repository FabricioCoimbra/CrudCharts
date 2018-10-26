using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class Nsu
    {
        public Nsu()
        {
            NsuProdutoNegativo = new HashSet<NsuProdutoNegativo>();
        }

        public int IdGeral { get; set; }
        public string Nsu1 { get; set; }
        public int NrDocumento { get; set; }
        public string Serie { get; set; }
        public int CdClifor { get; set; }
        public string FlTipo { get; set; }
        public DateTime DtEmissao { get; set; }
        public TimeSpan HrEmissao { get; set; }

        public ICollection<NsuProdutoNegativo> NsuProdutoNegativo { get; set; }
    }
}
