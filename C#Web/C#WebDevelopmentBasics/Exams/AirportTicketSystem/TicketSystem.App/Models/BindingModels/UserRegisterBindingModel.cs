using System.ComponentModel.DataAnnotations;

namespace TicketSystem.App.Models.BindingModels
{
    public class UserRegisterBindingModel
    {
        public string Name { get; set; }

        [Required(ErrorMessage = "Email address is required")]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Invalid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [Compare("Password",ErrorMessage = "Password do not match")]
        public string RepeatPassword { get; set; }
    }
}
