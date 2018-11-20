using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CrudCharts.Models;
using System.Data;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace CrudCharts.Controllers
{
	public class HomeController : Controller
	{
		private readonly TreinamentoContext _context;

		public HomeController(TreinamentoContext context)
		{
			_context = context;
		}

		public IActionResult Index()
		{
			ViewData["Message"] = "Meu titulo personalizado";

			var meses = new string[] { "January", "February", "March", "April", "May", "June", "July" };
			
			return View(meses);
		}

		public IActionResult About()
		{
			ViewData["Message"] = "January";

			return View();
		}

		public IActionResult Contact()
		{
			ViewData["Message"] = "Your contact page.";

			return View();
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}

		//Item 1 - Deve identificar potenciais vendas futuras com base nos serviços/produtos oferecidos;
		//listar os 10 produtos mais vendidos naquele mes nos tres anos anteriores
		[HttpPost]
		public JsonResult NovoGrafico()
		{
			//https://www.devmedia.com.br/linq-e-csharp-efetuando-consultas-com-lambda-expressions/38863
			List<RankingVendas> ListaProdutosMaisVendidos = new List<RankingVendas>();

			DateTime data = DateTime.Today;
			DateTime primeiroDiaDoMes = new DateTime(data.Year, data.Month, 1);
			DateTime ultimoDiaDoMes = new DateTime(data.Year, data.Month, DateTime.DaysInMonth(data.Year, data.Month));
			DateTime InicioEstemesDoAnoPassado = primeiroDiaDoMes.AddYears(-1);
			DateTime FimEstemesDoAnoPassado = ultimoDiaDoMes.AddYears(-1);

			DateTime InicioAnoRetrasado = primeiroDiaDoMes.AddYears(-2);
			DateTime FimAnoRetrasado = ultimoDiaDoMes.AddYears(-2);

			DateTime InicioTerceiroAno = primeiroDiaDoMes.AddYears(-3);
			DateTime FimTerceiroAno = ultimoDiaDoMes.AddYears(-3);


			//https://docs.microsoft.com/pt-br/aspnet/core/data/ef-mvc/sort-filter-page?view=aspnetcore-2.0
			IQueryable<RankingVendas> produtosPorQuantidade =
				from nota in _context.Nfsi
				//filtra apenas essas vendas no mesmo mes do ano passado
				where (nota.DtEmissao >= InicioEstemesDoAnoPassado && nota.DtEmissao <= FimEstemesDoAnoPassado) || 
					  (nota.DtEmissao >= InicioAnoRetrasado && nota.DtEmissao <= FimAnoRetrasado) ||
					  (nota.DtEmissao >= InicioTerceiroAno && nota.DtEmissao <= FimTerceiroAno)
				group nota by nota.CdProdserv into grupoProduto
				select new RankingVendas()
				{
					cd_prodserv = int.Parse(grupoProduto.Key),
					quantidadeProdutosvendidos = grupoProduto.Count()
				};

			ListaProdutosMaisVendidos = produtosPorQuantidade.AsNoTracking().Take(10).OrderByDescending(x => x.quantidadeProdutosvendidos).ToList();
			List<RankingVendas> ListaCompleta = new List<RankingVendas>();
			foreach (var produto in ListaProdutosMaisVendidos)
			{
				var valor = _context.Nfsi.Where(k => k.CdProdserv.Equals(produto.cd_prodserv)).Sum(x => x.VlLiquido);
				ListaCompleta.Add(new RankingVendas { cd_prodserv = produto.cd_prodserv,
					quantidadeProdutosvendidos = produto.quantidadeProdutosvendidos,
					valorProdutosVendidos = (Double)valor
				});
			}

				List<object> iDados = new List<object>();
			//Criando dados de exemplo
			DataTable dt = new DataTable();
			dt.Columns.Add("Vendas", System.Type.GetType("System.String"));
			dt.Columns.Add("QuantidadeVendida", System.Type.GetType("System.Int32"));
			dt.Columns.Add("ValorVendido", System.Type.GetType("System.Double"));
			DataRow dr;

			foreach (var produto in ListaCompleta)
			{
				dr = dt.NewRow();
				dr["Vendas"] = "Produto " + produto.cd_prodserv.ToString();//nao funcionou pegar o nome do produto + _context.Produto.Where(x => x.CdProduto.Equals(produto.cd_prodserv)).First().NmProduto;
				dr["QuantidadeVendida"] = produto.quantidadeProdutosvendidos;
				dr["ValorVendido"] = produto.valorProdutosVendidos;
				dt.Rows.Add(dr);			
			}
			
			//Percorrendo e extraindo cada DataColumn para List<Object> não sei porque?
			foreach (DataColumn dc in dt.Columns)
			{
				List<object> x = new List<object>();
				x = (from DataRow drr in dt.Rows select drr[dc.ColumnName]).ToList();
				iDados.Add(x);
			}
			//Dados retornados no formato JSON
			return Json(iDados);
		}

		//grupos de produtos menos vendidos nos utilmos 3 anos;
		[HttpPost]
		public JsonResult GruposMenosVendidos()
		{
			//https://www.devmedia.com.br/linq-e-csharp-efetuando-consultas-com-lambda-expressions/38863
			List<RankingVendas> ListaProdutosMaisVendidos = new List<RankingVendas>();

			DateTime data = DateTime.Today;
			DateTime primeiroDiaDoMes = new DateTime(data.Year, data.Month, 1);
			DateTime ultimoDiaDoMes = new DateTime(data.Year, data.Month, DateTime.DaysInMonth(data.Year, data.Month));
			DateTime InicioEstemesDoAnoPassado = primeiroDiaDoMes.AddYears(-1);
			DateTime FimEstemesDoAnoPassado = ultimoDiaDoMes.AddYears(-1);

			DateTime InicioAnoRetrasado = primeiroDiaDoMes.AddYears(-2);
			DateTime FimAnoRetrasado = ultimoDiaDoMes.AddYears(-2);

			DateTime InicioTerceiroAno = primeiroDiaDoMes.AddYears(-3);
			DateTime FimTerceiroAno = ultimoDiaDoMes.AddYears(-3);


			//https://docs.microsoft.com/pt-br/aspnet/core/data/ef-mvc/sort-filter-page?view=aspnetcore-2.0
			IQueryable<RankingVendas> produtosPorQuantidade =
				from nota in _context.Nfsi
					//filtra apenas essas vendas no mesmo mes do ano passado
				where (nota.DtEmissao >= InicioEstemesDoAnoPassado && nota.DtEmissao <= FimEstemesDoAnoPassado) ||
					  (nota.DtEmissao >= InicioAnoRetrasado && nota.DtEmissao <= FimAnoRetrasado) ||
					  (nota.DtEmissao >= InicioTerceiroAno && nota.DtEmissao <= FimTerceiroAno)
				join produto in _context.Produto on nota.CdProdserv equals produto.CdProduto
				join grupo in _context.Gruprod on produto.CdGruprod equals grupo.CdGruprod
				group grupo by grupo.CdGruprod into grupoProduto
				select new RankingVendas()
				{
					cd_prodserv = grupoProduto.Key,
					quantidadeProdutosvendidos = grupoProduto.Count()
				};

			ListaProdutosMaisVendidos = produtosPorQuantidade.AsNoTracking().Take(5).OrderBy(x => x.quantidadeProdutosvendidos).ToList();
			List<RankingVendas> ListaCompleta = new List<RankingVendas>();
			foreach (var produto in ListaProdutosMaisVendidos)
			{
				var valor = _context.Nfsi.Where(k => k.CdProdserv.Equals(produto.cd_prodserv)).Sum(x => x.VlLiquido);
				ListaCompleta.Add(new RankingVendas
				{
					cd_prodserv = produto.cd_prodserv,
					quantidadeProdutosvendidos = produto.quantidadeProdutosvendidos,
					valorProdutosVendidos = (Double)valor
				});
			}

			List<object> iDados = new List<object>();
			//Criando dados de exemplo
			DataTable dt = new DataTable();
			dt.Columns.Add("Vendas", System.Type.GetType("System.String"));
			dt.Columns.Add("QuantidadeVendida", System.Type.GetType("System.Int32"));
			dt.Columns.Add("ValorVendido", System.Type.GetType("System.Double"));
			DataRow dr;

			foreach (var produto in ListaCompleta)
			{
				dr = dt.NewRow();
				dr["Vendas"] = "Grupo " + produto.cd_prodserv.ToString();//nao funcionou pegar o nome do produto + _context.Produto.Where(x => x.CdProduto.Equals(produto.cd_prodserv)).First().NmProduto;
				dr["QuantidadeVendida"] = produto.quantidadeProdutosvendidos;
				dr["ValorVendido"] = produto.valorProdutosVendidos;
				dt.Rows.Add(dr);
			}

			//Percorrendo e extraindo cada DataColumn para List<Object> não sei porque?
			foreach (DataColumn dc in dt.Columns)
			{
				List<object> x = new List<object>();
				x = (from DataRow drr in dt.Rows select drr[dc.ColumnName]).ToList();
				iDados.Add(x);
			}
			//Dados retornados no formato JSON
			return Json(iDados);
		}
	}
}
