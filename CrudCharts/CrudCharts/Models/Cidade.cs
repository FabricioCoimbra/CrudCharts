using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class Cidade
    {
        public Cidade()
        {
            Agronomo = new HashSet<Agronomo>();
            ClienteEntrega = new HashSet<ClienteEntrega>();
            Contato = new HashSet<Contato>();
            Mdfe = new HashSet<Mdfe>();
            Motorista = new HashSet<Motorista>();
            Propriedade = new HashSet<Propriedade>();
        }

        public int CdCidade { get; set; }
        public string NmCidade { get; set; }
        public string Uf { get; set; }
        public int? CdRegiao { get; set; }
        public DateTime? DtAtz { get; set; }
        public int? CdFilial { get; set; }
        public int? CdIbge { get; set; }
        public int? CdPais { get; set; }

        public Regiao CdRegiaoNavigation { get; set; }
        public ICollection<Agronomo> Agronomo { get; set; }
        public ICollection<ClienteEntrega> ClienteEntrega { get; set; }
        public ICollection<Contato> Contato { get; set; }
        public ICollection<Mdfe> Mdfe { get; set; }
        public ICollection<Motorista> Motorista { get; set; }
        public ICollection<Propriedade> Propriedade { get; set; }
    }
}
