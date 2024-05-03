using Microsoft.AspNetCore.Mvc;

namespace ModelDemo.Controllers
{
	[Controller]
	public class Book : Controller
	{
        //Method 1

        //URL = localhost:7009/book?bookid=69&author=abhie -> Query String method
        //[Route("/book")]
        //public IActionResult BookFunc()
        //{
        //	int? bookid = Convert.ToInt32(Request.Query["bookid"]);
        //	String? author = Convert.ToString(Request.Query["author"]);
        //	return Content($"book id is: {bookid} \nbook author is: {author}",
        //		"text/plain");
        //}

        //Method2       

        //[Route("/book")]
        //URL == localhost:7009/book/69/abhie -> Query String Method
		//[Route("/book/{bookid}/{author}")]
        [Route("/book")]
        public IActionResult BookFunc1(int? bookid, string author)
		{
            if (bookid.HasValue == false)
            {
                return Content("No bookid found. Please Enter bookid.", "text/plain");
            }
			return Content($"book id is: {bookid} \nbook author is: {author}",
				"text/plain");
        }
	}
}