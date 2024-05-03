using System.ComponentModel.DataAnnotations;
namespace FormTagHelper.Models
{
	public class Employee
	{
		public string? Ename { get; set; }

		public int? Age { get; set; }

		public Gender Gender { get; set; }	
		
		public string? Mstatus { get; set; }
		public string? Description { get; set; }
	}

	public enum Gender
	{
		Male, Female
	}
}

