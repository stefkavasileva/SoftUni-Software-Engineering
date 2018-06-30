namespace SimpleMvc.Common
{
    public static class StringExtensions
    {
        public static string CapitalizeFirstLetter(this string param)
        {
            return param[0].ToString().ToUpper() + param.Substring(1);
        }
    }
}
