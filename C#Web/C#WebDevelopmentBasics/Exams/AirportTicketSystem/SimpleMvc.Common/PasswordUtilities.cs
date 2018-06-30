namespace SimpleMvc.Common
{
    using System.Linq;
    using System.Security.Cryptography;

    public static class PasswordUtilities
    {
        public static string GetPasswordHash(string password)
        {
            var sha256 = SHA256Managed.Create();
            return string.Join(
                   "",
                   sha256
                       .ComputeHash(System.Text.Encoding.UTF8.GetBytes(password))
                       .Select(b => b.ToString("x2")));
        }
    }
}
