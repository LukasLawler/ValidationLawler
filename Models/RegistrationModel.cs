using System;
using System.ComponentModel.DataAnnotations;
namespace ValidationLawler.Models
{
    public class RegistrationModel
    {
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Phone number is required")]
        [Phone]
        public string PhoneNo { get; set; }
        [Required(ErrorMessage = "Address is required")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress]
        public string EmailAddress { get; set; }
        [Required(ErrorMessage = "Age is required")]
        [Range(18, 200, ErrorMessage = "Must be over 18 to register. Ages over 200 are not allowed.")]
        public int Age { get; set; }
    }
}
