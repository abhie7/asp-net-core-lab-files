using Microsoft.AspNetCore.Mvc;
namespace ActionMethod.Controllers
{
	[Controller]
	public class Home : Controller
	{
        //      [Route("Home")]
        //[Route("/")]
        //      public String index()
        //      {
        //          return "This is the Index Action of Home Controller";
        //      }

        //public IActionResult Index()
        //{
        //    return Content("This is the Index page of the Account Controller.");
        //}

        //public IActionResult SignIn()
        //{
        //    return Content("This is the SignIn page of the Account Controller.");
        //}

        //public IActionResult SignOut()
        //{
        //    return Content("This is the SignOut page of the Account Controller.");
        //}

        //public IActionResult Registration()
        //{
        //    return Content("This is the Registration page of the Account Controller.");
        //}

        [ActionName("about")]
        public IActionResult AboutUs()
        {
            return Content("This is the about us page.");
        }

        [HttpGet]
        public IActionResult ContactUs()
        {
            return Content("This is the contact us page.");
        }

        [NonAction]
        public IActionResult SignIn()
        {
            return Content("This is the signin page.");
        }
    }
}


