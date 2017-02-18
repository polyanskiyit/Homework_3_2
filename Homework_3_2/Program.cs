using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3_2
{
    class Program
    {
        //Метод розвернення стрічки
        static string ReverseString(string inputString)
        {
            int i = 0;
            int j = inputString.Length - 1;

            char[] newString = new char[inputString.Length];
            while (i <= j)
            {
                newString[i] = inputString[j];
                newString[j] = inputString[i];
                i++;
                j--;
            }
            return new string(newString);
        }



        static void Main(string[] args)
        {
            Console.Write("\nВведiть слово: ");
            string inputString = Console.ReadLine();
            
            //string outputString = inputString.Reverse().Aggregate(string.Empty, (acc, ch) => acc + ch);
            //string outputString = new string(inputString.ToCharArray().Reverse().ToArray());

            string outputString = ReverseString(inputString);

            if (inputString == outputString)
            {
                Console.WriteLine("\n\nСтрiчка палiндром! Result: {0};", outputString);
            }
            else
            {
                Console.WriteLine("\n\nСтрiчка не палiндром! Result: {0};", outputString);
            }

            Console.Read();
        }
    }
}
