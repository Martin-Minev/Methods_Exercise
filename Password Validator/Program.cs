using System;

namespace Password_Validator
{
    class Program
    {
        public static void Main(string[] args)
        {
            string password = Console.ReadLine();
            bool invalidLenght = SymbolsCount(password);
            bool invalidLettersAndDigits = LettersAndDigits(password);
            bool invalidDigitsCount = DigitsCount(password);

            if (invalidLenght && invalidLettersAndDigits && invalidDigitsCount)
            {
                Console.WriteLine("Password is valid");
            }
            else
            {
                if (!SymbolsCount(password))
                {
                    Console.WriteLine("Password must be between 6 and 10 characters");
                }

                if (!LettersAndDigits(password))
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                }
                if (!DigitsCount(password))
                {
                    Console.WriteLine("Password must have at least 2 digits");
                }
            }
        }
        private static bool DigitsCount(string password)
        {
            int count = 0;
            foreach (char c in password)
            {
                if (char.IsDigit(c))
                {

                    count++;
                }
            }
            if (count >= 2)
            {
                return true;
            }
            return false;
        }
        private static bool LettersAndDigits(string password)
        {
            foreach (char c in password)
            {
                if (!char.IsLetterOrDigit(c))
                {

                    return false;
                }
            }
            return true;
        }
        private static bool SymbolsCount(string password)
        {
            if (password.Length >= 6 && password.Length <= 10)
            {
                return true;
            }
            return false;
        }
    }
}
