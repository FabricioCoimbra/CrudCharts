using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class Veiculo
    {
        public Veiculo()
        {
            Clieveic = new HashSet<Clieveic>();
            Fornveic = new HashSet<Fornveic>();
            ProdutoVeiculo = new HashSet<ProdutoVeiculo>();
            VeiculoModeloComplemento = new HashSet<VeiculoModeloComplemento>();
            VeiculoModeloInjecao = new HashSet<VeiculoModeloInjecao>();
            VeiculoModeloMotor = new HashSet<VeiculoModeloMotor>();
            VeiculoModeloTransmissao = new HashSet<VeiculoModeloTransmissao>();
            Veiprod = new HashSet<Veiprod>();
        }

        public int CdFilial { get; set; }
        public int CdVeiculo { get; set; }
        public int CdMontadora { get; set; }
        public string NmVeiculo { get; set; }
        public DateTime? DtAtz { get; set; }

        public Montadora Cd { get; set; }
        public ICollection<Clieveic> Clieveic { get; set; }
        public ICollection<Fornveic> Fornveic { get; set; }
        public ICollection<ProdutoVeiculo> ProdutoVeiculo { get; set; }
        public ICollection<VeiculoModeloComplemento> VeiculoModeloComplemento { get; set; }
        public ICollection<VeiculoModeloInjecao> VeiculoModeloInjecao { get; set; }
        public ICollection<VeiculoModeloMotor> VeiculoModeloMotor { get; set; }
        public ICollection<VeiculoModeloTransmissao> VeiculoModeloTransmissao { get; set; }
        public ICollection<Veiprod> Veiprod { get; set; }
    }
}
