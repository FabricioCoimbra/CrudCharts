using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class Veiprod
    {
        public Veiprod()
        {
            ProdutoVeiculosInjecao = new HashSet<ProdutoVeiculosInjecao>();
            ProdutoVeiculosTransmissao = new HashSet<ProdutoVeiculosTransmissao>();
        }

        public int CdFilial { get; set; }
        public int CdVeiculo { get; set; }
        public string CdProduto { get; set; }
        public DateTime? DtAtz { get; set; }
        public int IdGeral { get; set; }
        public int? AnoInicial { get; set; }
        public int? AnoFinal { get; set; }
        public int? CdMotor { get; set; }
        public int? CdComplemento { get; set; }
        public int? CdMontadora { get; set; }

        public Montadora Cd { get; set; }
        public VeiculoComplemento CdComplementoNavigation { get; set; }
        public VeiculoMotor CdMotorNavigation { get; set; }
        public Veiculo CdNavigation { get; set; }
        public Produto CdProdutoNavigation { get; set; }
        public ICollection<ProdutoVeiculosInjecao> ProdutoVeiculosInjecao { get; set; }
        public ICollection<ProdutoVeiculosTransmissao> ProdutoVeiculosTransmissao { get; set; }
    }
}
