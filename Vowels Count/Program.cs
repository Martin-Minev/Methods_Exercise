using System;

namespace Vowels_Count
{
    class Program
    {
        public static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();

            int result = CountOfVowels(text);
            Console.WriteLine(result);

        }

        static int CountOfVowels(string text)
        {
            int counter = 0;

            for (int i = 0; i < text.Length; i++)
            {
                char currentChar = text[i];

                if (currentChar == 'u')
                {
                    counter++;
                }
                else if (currentChar == 'a')
                {
                    counter++;
                }
                else if (currentChar == 'i')
                {
                    counter++;
                }
                else if (currentChar == 'o')
                {
                    counter++;
                }
                else if (currentChar == 'e')
                {
                    counter++;
                }
                else if (currentChar == 'y')
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
