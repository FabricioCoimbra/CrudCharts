using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CrudCharts.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DashBoardController : ControllerBase
    {
		// GET api/DashBoard
		[HttpGet]
		public IEnumerable<string> Get()
		{
			return new string[] { "January", "February", "March", "April", "May", "June", "July" };
		}

				
	}
}