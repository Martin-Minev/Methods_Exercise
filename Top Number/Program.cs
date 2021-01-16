using System;

namespace Top_Number
{
    class Program
    {
        public static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            PrintTopInteger(number);
        }

        static void PrintTopInteger(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                string currentNumber = i.ToString();
                bool isOddDigit = false;
                int sumOfDigits = 0;

                foreach (var curr in currentNumber)
                {
                    int parseNumber = (int)curr;

                    if (parseNumber % 2 == 1)
                    {
                        isOddDigit = true;
                    }

                    sumOfDigits += parseNumber;
                }
                if (sumOfDigits % 8 == 0 && isOddDigit)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
