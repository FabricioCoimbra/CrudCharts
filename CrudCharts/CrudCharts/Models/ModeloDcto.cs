using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class ModeloDcto
    {
        public ModeloDcto()
        {
            Mdfe = new HashSet<Mdfe>();
            Nfsc = new HashSet<Nfsc>();
            OperacaoEs = new HashSet<OperacaoEs>();
        }

        public string CdModelo { get; set; }
        public string NmModelo { get; set; }

        public ICollection<Mdfe> Mdfe { get; set; }
        public ICollection<Nfsc> Nfsc { get; set; }
        public ICollection<OperacaoEs> OperacaoEs { get; set; }
    }
}
