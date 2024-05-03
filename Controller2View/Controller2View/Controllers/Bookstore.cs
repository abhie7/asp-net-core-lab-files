using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Controller2View.Controllers
{
	[Controller]
	public class Bookstore : Controller
	{
		public IActionResult Index()
		{
			ViewData["name"] = "Asp .Net Core";
			ViewData["author"] = "Mcgrow Hills";
			ViewData["price"] = 5000;

			return View();
		}
	}
}

