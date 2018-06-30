using System.ComponentModel.DataAnnotations;

namespace TicketSystem.App.Models.BindingModels
{
    public class UserLoginBindingModel
    {
        [Required(ErrorMessage = "Please enter your email address")]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$",ErrorMessage = "Invalid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter your password")]
        public string Password { get; set; }
    }
}
