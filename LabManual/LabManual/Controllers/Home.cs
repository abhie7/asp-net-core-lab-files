using Microsoft.AspNetCore.Mvc;

namespace LabManual.Controllers
{
    [Controller]
    public class Home : Controller
    {
        [Route("Home")]
        [Route("/")]

        public ContentResult index()
        {
            return Content("<h1>Question 12 ASP</h1>", "text/html");
        }
    }
}
