namespace KittenApp.Web.Models.BindingModels
{
    using System.ComponentModel.DataAnnotations;

    public class UserLoggingInModel
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
