using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SecondApp.Models;

namespace SecondApp.Controllers
{
	public class HelloController : Controller
	{
		// Get: /<Controller>/
		public IActionResult Index()
		{
			ViewData["Message"] = "Let's study ASP.NET MVC";
			return View();
		}
	}
}
