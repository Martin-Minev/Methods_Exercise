using System;

namespace Smallest_of_Three_Numbers
{
    class Program
    {
        public static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            PrintSmallestNumber(a, b, c);
        }

        static void PrintSmallestNumber(int a, int b, int c)
        {
            if (a < b && a < c)
            {
                Console.WriteLine(a);
            }

            else if (b < a && b < c)
            {
                Console.WriteLine(b);
            }

            else if (c < a && c < b)
            {
                Console.WriteLine(c);
            }

            else
            {
                Console.WriteLine(a);
            }
        }
    }
}
