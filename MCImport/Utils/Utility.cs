namespace MCImport.Utils
{
    internal class Utility
    {
        public static int GenerateRandomNumber()
        {
            Random randomNumber = new();

            return randomNumber.Next(1, 100);
        }
    }
}
