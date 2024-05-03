using Microsoft.AspNetCore.Mvc;
namespace ModelBinding.Models
{
	public class Book
	{
		//[FromRoute]
		public int? BookId { get; set; }

		//[FromQuery]
		public string Author { get; set; }
	}
}

