using System;

namespace Homework_3_2
{
    class Program
    {
        public static bool Palindrom(string s)
        {
            for (int i = 0; i < s.Length / 2; i++)
            {
                if (s[i] != s[s.Length - i - 1])
                {
                    return false;
                }
            }
            return true;
        }

        static void Main(string[] args)
        {
            Console.Write("\nВведiть слово: ");
            string inputString = Console.ReadLine();

            bool checkStringForPalindrom = Palindrom(inputString);

            if (checkStringForPalindrom)
            {
                Console.WriteLine("\n\nСтрiчка '{0}' палiндром!", inputString);
            }
            else
            {
                Console.WriteLine("\n\nСтрiчка '{0}' не палiндром!", inputString);
            }

            Console.Read();
        }
    }
}
