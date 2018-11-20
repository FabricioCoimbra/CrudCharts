﻿using System;
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

		[HttpPost]
		public JsonResult NovoGrafico()
		{
			//https://www.devmedia.com.br/linq-e-csharp-efetuando-consultas-com-lambda-expressions/38863
			List<RankingVendas> ListaProdutosMaisVendidos = new List<RankingVendas>();

			//https://docs.microsoft.com/pt-br/aspnet/core/data/ef-mvc/sort-filter-page?view=aspnetcore-2.0
			IQueryable<RankingVendas> produtosPorQuantidade =
				from nota in _context.Nfsi
				group nota by nota.CdProdserv into grupoProduto
				select new RankingVendas()
				{
					cd_prodserv = int.Parse(grupoProduto.Key),
					quantidadeProdutosvendidos = grupoProduto.Count()
				};

			ListaProdutosMaisVendidos = produtosPorQuantidade.AsNoTracking().Take(10).OrderByDescending(x => x.quantidadeProdutosvendidos).ToList();
			foreach (var produto in ListaProdutosMaisVendidos)
			{
				var valor = _context.Nfsi.Where(k => k.CdProdserv.Equals(produto.cd_prodserv)).Sum(x => x.QtVenda);
			}
			List<object> iDados = new List<object>();
			//Criando dados de exemplo
			DataTable dt = new DataTable();
			dt.Columns.Add("Vendas", System.Type.GetType("System.String"));
			dt.Columns.Add("QuantidadeVendida", System.Type.GetType("System.Int32"));
			DataRow dr;

			foreach (var produto in ListaProdutosMaisVendidos){
				dr = dt.NewRow();
				dr["Vendas"] = $"Produto {0}" + produto.cd_prodserv.ToString();
				dr["QuantidadeVendida"] = produto.quantidadeProdutosvendidos;
				dt.Rows.Add(dr);			
			}
			
			//Percorrendo e extraindo cada DataColumn para List<Object>
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
