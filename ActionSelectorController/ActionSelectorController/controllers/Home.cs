using Microsoft.AspNetCore.Mvc;
using System.Web.Mvc;

namespace ActionSelectorController.controllers
{
	[Controller]
	public class Home : Controller
	{
        [ActionName("i1")]
        public string index()
        {
            return "index page";
        }

        [ActionName("Modify")]
        public string Edit()
        {
            return "Hello from updated method";
        }

        [HttpPost]
        //[HttpGet]
        public string Delete()
        {
            return "hello from delete method";
        }

        [NonAction]
        public string Update()
        {
            return "hello from update method";
        }

    }
}

