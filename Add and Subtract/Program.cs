using System;

namespace Add_and_Subtract
{
    class Program
    {
        public static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int result = Sum(a, b);

            int finalResult = Subtract(result, c);
            Console.WriteLine(finalResult);
        }

        private static int Subtract(int result, int c)
        {
            int finalResult = result - c;
            return finalResult;
        }

        private static int Sum(int a, int b)
        {
            int result = a + b;
            return result;
        }
    }
}
