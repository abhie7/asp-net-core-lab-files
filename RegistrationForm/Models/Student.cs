using System.ComponentModel.DataAnnotations;

namespace RegistrationForm.Models
{
	public class Student
	{
        [Required(ErrorMessage = "Enter Enrollment No.")]
        //[Range(1,9, ErrorMessage = "Enrollment no. should be between 1 and 8 digits")]
        public long? EnrollmentNo { get; set; }

        [Required(ErrorMessage = "Enter name")]
        [StringLength(50)]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Enter address")]
        [StringLength(100)]
        public string? Address { get; set; }

        [Required(ErrorMessage = "Enter email")]
        [StringLength(50)]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Enter password")]
        [DataType(DataType.Password)]
        [StringLength(100, MinimumLength = 4, ErrorMessage = "Password must be at least 5 characters long.")]
        public string? Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string? ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Enter mobile number")]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Mobile number should be 10 digits")]
        public double? Mobile { get; set; }

        public Gender Gender { get; set; } //radio

        public Hobby Hobby { get; set; } //checkbox

        public City City { get; set; } //dropdown
    }

    public enum Gender
    {
        Male, Female
    }

    public enum Hobby
    {
        Coding, Guitar, Football, Cooking
    }

    public enum City
    {
        Vadodara, Mumbai, Pune, Kolkata, Delhi, Ahmedabad, Chennai, Bengaluru
    }
}