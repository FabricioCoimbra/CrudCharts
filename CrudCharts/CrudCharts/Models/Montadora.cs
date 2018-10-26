using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class Montadora
    {
        public Montadora()
        {
            ProdutoVeiculo = new HashSet<ProdutoVeiculo>();
            Veiculo = new HashSet<Veiculo>();
            Veiprod = new HashSet<Veiprod>();
        }

        public int CdFilial { get; set; }
        public int CdMontadora { get; set; }
        public string NmMontadora { get; set; }
        public DateTime? DtAtz { get; set; }

        public ICollection<ProdutoVeiculo> ProdutoVeiculo { get; set; }
        public ICollection<Veiculo> Veiculo { get; set; }
        public ICollection<Veiprod> Veiprod { get; set; }
    }
}
