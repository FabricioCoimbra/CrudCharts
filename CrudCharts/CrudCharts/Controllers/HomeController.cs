﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CrudCharts.Models;
using System.Data;

namespace CrudCharts.Controllers
{
	public class HomeController : Controller
	{
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
			List<object> iDados = new List<object>();
			//Criando dados de exemplo
			DataTable dt = new DataTable();
			dt.Columns.Add("Vendas", System.Type.GetType("System.String"));
			dt.Columns.Add("Unidades", System.Type.GetType("System.Int32"));
			DataRow dr = dt.NewRow();
			dr["Vendas"] = "Chevrolet Onix";
			dr["Unidades"] = 171;
			dt.Rows.Add(dr);
			dr = dt.NewRow();
			dr["Vendas"] = "Huynday HB20";
			dr["Unidades"] = 96;
			dt.Rows.Add(dr);
			dr = dt.NewRow();
			dr["Vendas"] = "Ford Ka(Hatch)";
			dr["Unidades"] = 87;
			dt.Rows.Add(dr);
			dr = dt.NewRow();
			dr["Vendas"] = "WolksVagem Gol";
			dr["Unidades"] = 67;
			dt.Rows.Add(dr);
			dr = dt.NewRow();
			dr["Vendas"] = "Renaul Sandero";
			dr["Unidades"] = 63;
			dt.Rows.Add(dr);
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
