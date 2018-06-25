using System.ComponentModel.DataAnnotations;

namespace FDMC.App.Models.BindingModels
{
    public class UserLoginBindingModel
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
