using Microsoft.AspNetCore.Mvc;
using SanaFirstProject.Models;
using System.Diagnostics;

namespace SanaFirstProject.Controllers
{
	public class HomeController : Controller
	{
		
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index(User user)
		{
			return View(user);
		}

		

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}