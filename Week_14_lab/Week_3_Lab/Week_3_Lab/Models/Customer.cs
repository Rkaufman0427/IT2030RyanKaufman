using System.ComponentModel.DataAnnotations;

namespace Week_3_Lab.Models
{
    public class Customer
    {
        [Required(ErrorMessage ="Please enter a first name")]
        [StringLength(10, ErrorMessage = "First Name must be 10 characters or less.")]
        [RegularExpression("^[a-zA-Z]+$",
            ErrorMessage = "First Name may not contain numbers or special characters.")]
        public string? FirstName { get; set; }

        [Required(ErrorMessage = "Please enter a last name")]
        [StringLength(10, ErrorMessage = "Last Name must be 10 characters or less.")]
        [RegularExpression("^[a-zA-Z]+$",
            ErrorMessage = "Last Name may not contain numbers or special characters.")]
        public string? LastName { get; set; }

        [Required(ErrorMessage = "Please enter a street address")]
        [StringLength(50, ErrorMessage = "street address must be 50 digits.")]
        [RegularExpression("[0-9-a-zA-Z]{50}",
            ErrorMessage = "Street address may not have special characters and must be 50 digits.")]
        public string? StreetAddress { get; set; }

        [Required(ErrorMessage = "Please enter a city")]
        [StringLength(20, ErrorMessage = "City must be 20 characters or less.")]
        [RegularExpression("[a-zA-Z]+$",
            ErrorMessage = "City may not contain numbers or special characters.")]
        public string? City { get; set; }

        [Required(ErrorMessage = "Please enter a state")]
        [StringLength(20, ErrorMessage = "State must be 20 characters or less.")]
        [RegularExpression("[a-zA-Z]{20}",
            ErrorMessage = "State may not contain numbers or special characters.")]
        public string? State { get; set; }

        [Required(ErrorMessage = "Please enter a zip code")]
        [StringLength(5, ErrorMessage = "Zip code must be 5 digits.")]
        [RegularExpression("[0-9]{5}",
             ErrorMessage = "Zip code may not contain numbers or special characters and must be 5 digits.")]
        public string? ZipCode { get; set; }

        [Required(ErrorMessage = "Please enter a phone number")]
        [StringLength(10, ErrorMessage = "phone number must be 10 digits.")]
        [RegularExpression("[0-9]{10}",
            ErrorMessage = "Phone number may not contain numbers or special characters and must be 10 digits.")]
        public string? Phone { get; set; }

        [Required(ErrorMessage = "Please enter a email")]
        [StringLength(50, ErrorMessage = "email must be 50 digits.")]
        [RegularExpression("[0-9-a-zA-Z]{50}",
ErrorMessage = "Email may not special characters and must be 50 digits.")]
        public string? Email { get; set; }
    }
}
