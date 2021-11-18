namespace webAPI
{
    public class Utilities
    {

        private static Random random = new Random();

        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public static string RandomString(int minLength, int maxLength)
        {
            int length = random.Next(minLength, maxLength + 1);
            return RandomString(length);
        }

        public static int RandomNumber()
        {
            Random rnd = new Random();
            return rnd.Next(1000,9999);
        }
    }

}
