using System;

namespace Factorial_Division
{
    class Program
    {
        public static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            double caculateFactorial = GetFactorial(firstNumber);
            double caculateFactorialSecond = GetFactorial(secondNumber);

            double product = caculateFactorial / caculateFactorialSecond;
            Console.WriteLine($"{product:F2}");
        }

        private static double GetFactorial(int number)
        {
            double factorial = 1;
            while (number != 1)
            {
                factorial = factorial * number;
                number = number - 1;

            }
            return factorial;
        }
    }
}
