using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrudCharts.Models
{
	public class RankingVendas
	{
		[Key]
		public int cd_prodserv { get; set; }
		public Double quantidadeProdutosvendidos { get; set; }
		public Double valorProdutosVendidos { get; set; }
	}
}
