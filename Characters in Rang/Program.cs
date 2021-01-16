using System;

namespace Characters_in_Rang
{
    class Program
    {
        public static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());

            PrintCharsInbetween(firstChar, secondChar);
        }

        static void PrintCharsInbetween(char firstChar, char secondChar)
        {
            if (firstChar > secondChar)
            {
                char first = firstChar;
                firstChar = secondChar;
                secondChar = first;
            }

            for (int i = firstChar + 1; i < secondChar; i++)
            {

                Console.Write((char)i + " ");

            }
        }
    }
}
