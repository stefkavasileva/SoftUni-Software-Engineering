using System.ComponentModel.DataAnnotations;

namespace MeTube.App.Models.BindingModels
{
    public class UserRegisterBindingModel
    {
        [Required(ErrorMessage = "Username is required")]
        [MinLength(5,ErrorMessage = "Username must be at least five cheracters long")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [MinLength(6, ErrorMessage = "Password must be at least six cheracters long")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm password field is required")]
        [MinLength(6, ErrorMessage = "Password must be at least six cheracters long")]
        [Compare("Password",ErrorMessage = "Password do not match")]
        public string ConfirmPassword { get; set; }

        [Required (ErrorMessage = "Email is required")]
        [DataType(DataType.EmailAddress,ErrorMessage = "Email is invalid, try example@domain.com")]
        public string Email { get; set; }
    }
}
