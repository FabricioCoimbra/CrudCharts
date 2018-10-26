using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class CodigoTributacaoMunicipio
    {
        public CodigoTributacaoMunicipio()
        {
            Produto = new HashSet<Produto>();
        }

        public int CdTributacaoMunicipio { get; set; }
        public string NmTributacaoMunicipio { get; set; }

        public ICollection<Produto> Produto { get; set; }
    }
}
