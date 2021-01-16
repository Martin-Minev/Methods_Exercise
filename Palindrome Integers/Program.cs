using System;

namespace Palindrome_Integers
{
    class Program
    {
        public static void Main(string[] args)
        {
            string checkString = Console.ReadLine();

            while (checkString != "END")
            {
                // int currentNumber = int.Parse(checkString);
                string result = IsPalindrome(checkString).ToString().ToLower();
                Console.WriteLine(result);
                checkString = Console.ReadLine();
            }
        }

        static bool IsPalindrome(string checkString)
        {

            if (checkString == null || checkString.Length == 0)
            {
                return false;
            }
            int strMaxIndex = checkString.Length - 1;
            for (int i = 0; i < checkString.Length / 2; i++)
            {
                if (checkString[i] != checkString[strMaxIndex - i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
