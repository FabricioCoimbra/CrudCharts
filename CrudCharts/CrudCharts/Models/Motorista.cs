using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class Motorista
    {
        public Motorista()
        {
            MdfeCondutor = new HashSet<MdfeCondutor>();
        }

        public int CdFilial { get; set; }
        public int CdMotorista { get; set; }
        public int CdCidade { get; set; }
        public int CdTransportador { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Cnh { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }

        public Fornecedor Cd { get; set; }
        public Cidade CdCidadeNavigation { get; set; }
        public ICollection<MdfeCondutor> MdfeCondutor { get; set; }
    }
}
