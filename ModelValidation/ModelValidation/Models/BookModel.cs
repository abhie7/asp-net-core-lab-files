using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
namespace ModelValidation.Models

{
    public class BookModel
    {
        //[FromRoute]
        [Required]
        public int? BookId { get; set; }

        //[FromQuery]
        //[Required]
        [Required(ErrorMessage = "Bookname is required.")]
        [Display(Name = "abhie")]
        [StringLength(100,MinimumLength = 4, ErrorMessage = "Fuddu Noob")] //"{0} must be atleast {2} chars and less than {1} chars."
        //[RegularExpression("^[a-z][A-Z]$",ErrorMessage = "Given book name is not valid.")]
        public string BookName { get; set; }

        [Required]
        //[NoValidate]
        public string Author { get; set; }

        [Range(0,999.99,ErrorMessage = "Price should be under 1000")]
        public decimal? Price { get; set; }

        [EmailAddress(ErrorMessage = "Noob Email address")]
        public string Email { get; set; }
    }
}