//Controllers.BookController.cs
using Microsoft.AspNetCore.Mvc;
using ModelValidation.Models;

namespace ModelValidation.Controllers
{
    [Controller]
    public class BookController : Controller
    {
        //localhost:7252/books/123/abhie/auth
        [Route("/books/{BookId?}/{BookName?}/{Author?}/{Price?}")]
        public IActionResult BookBind(BookModel b1)
        {
            // //Method1
            //if (b1.BookId.HasValue == false)
            //{
            //    return Content("Book id is not provided.", "text/plain");
            //}
            ////Valiadate by controller but now we validate by model class
            //else if (String.IsNullOrEmpty(b1.BookName))
            //{
            //    return BadRequest("Book name is not provided");
            //}
            //return Content($"Book id is: {b1.BookId} \n" +
            //$"Book Name is: {b1.BookName}", "text/plain");

            //Method2
            if (!ModelState.IsValid)
            {
                List<String> errors = new List<string>();
                foreach (var values in ModelState.Values)
                {
                    foreach (var error in values.Errors)
                    {
                        errors.Add(error.ErrorMessage);
                    }
                }
                string errormsg = String.Join("\n", errors);
                return BadRequest(errormsg);
            }
            return Content($"Book id is: {b1.BookId} \n" +
             $"Book Name is: {b1.BookName} \n" +
             $"Book Author is: {b1.Author} \n" +
             $"Book Price is: {b1.Price} \n" +
             $"Email is: {b1.Email}", "text/plain");

            ////Method3
            //if (!ModelState.IsValid)
            //{
            //    return BadRequest("Some Fields are not entered.");
            //}
            //return Content($"Book id is: {b1.BookId} \n" +
            // $"Book Name is: {b1.BookName} \n" +
            // $"Book Author is: {b1.Author}", "text/plain");
        } 
    }
}