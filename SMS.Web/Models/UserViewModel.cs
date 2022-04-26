
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using SMS.Data.Models;

namespace SMS.Web.Models
{
    // copy user propertties and add a ConfirmPassword property
    public class UserViewModel
    {    
        [Required]
        public string Name { get; set; }  

        [Required]
        [EmailAddress]
        [Remote("VerifyEmailAddress", "User")]
        public string Email { get; set; }
 
        [Required]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Confirm password doesn't match, Type again !")]
        [Display(Name = "Confirm Password")]  
        public string PasswordConfirm  { get; set; }

        [Required]
        public Role Role { get; set; }

    }
}