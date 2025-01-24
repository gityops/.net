using System.ComponentModel.DataAnnotations;

namespace practical14.Models
{
    public class Person
    {
        [Required(ErrorMessage = "Name is required")]
        [StringLength(100, ErrorMessage = "Name can't be longer than 100 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Age is required")]
        [Range(1, 120, ErrorMessage = "Age must be between 1 and 120")]
        public int Age { get; set; }

        public bool IsValid(out List<string> validationErrors)
        {
            validationErrors = new List<string>();
            if (string.IsNullOrWhiteSpace(Name))
            {
                validationErrors.Add("Name is required.");
            }
            if (!new EmailAddressAttribute().IsValid(Email))
            {
                validationErrors.Add("Invalid Email Address.");
            }
            if (Age < 1 || Age > 120)
            {
                validationErrors.Add("Age must be between 1 and 120.");
            }
            return validationErrors.Count == 0;
        }
    }
}
