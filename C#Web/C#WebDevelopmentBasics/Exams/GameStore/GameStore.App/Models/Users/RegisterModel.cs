namespace GameStore.App.Models.Users
{
    public class RegisterModel
    {
        public string Email { get; set; }

        public string Name { get; set; }

        public string Password { get; set; }

        public string ConfirmPassword { get; set; }
    }
}
