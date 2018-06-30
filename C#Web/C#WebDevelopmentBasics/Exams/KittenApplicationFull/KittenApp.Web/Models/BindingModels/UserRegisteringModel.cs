namespace KittenApp.Web.Models.BindingModels
{
    using System.ComponentModel.DataAnnotations;

    public class UserRegisteringModel
    {
        [Required]
        [MinLength(5)]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [MinLength(6)]
        public string Password { get; set; }

        [Required]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
    }
}
