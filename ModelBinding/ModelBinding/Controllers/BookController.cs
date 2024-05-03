using Microsoft.AspNetCore.Mvc;
using ModelBinding.Models;

namespace ModelBinding.Controllers
{
	[Controller]
	public class BookController : Controller
	{
        //localhost:7252/bookdata/123/abhie
        [Route("/bookdata/{bookid}/{author}")]
		public IActionResult BookBind(Book BookModel)
		{
			if (BookModel.BookId.HasValue == false)
			{
				return Content("Book id is not provided.", "text/plain");
			}
			else
			{
				return Content($"book id is: {BookModel.BookId} \n" +
					$"book author is: {BookModel.Author}", "text/plain");
			}
		}
	}
}

