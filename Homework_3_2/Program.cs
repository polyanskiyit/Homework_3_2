using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3_2
{
    class Program
    {
        //Простий метод розвернення стрічки
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


        //Метод розвернення великих стрічкок
        static string ReverseStringBuilder(string inputString)
        {
            StringBuilder stringBuilder = new StringBuilder(inputString.Length);
            for(int i = inputString.Length; i-- != 0;)
            {
                stringBuilder.Append(inputString[i]);
            }
            return stringBuilder.ToString();
        }

        //Найшвидший метод розвернення стрічки (небезпечний)
        //static unsafe string ReverseUnsafeCopy(string str)
        //{
        //    if (str.Length <= 1) return str;
        //    char tmp;
        //    String copy = String.Copy(str);
        //    fixed (char* buf = copy)
        //    {
        //        char* p = buf;
        //        char* q = buf + str.Length - 1;
        //        while (p < q)
        //        {
        //            tmp = *p;
        //            *p = *q;
        //            *q = tmp;
        //            p++; q--;
        //        }
        //    }
        //    return copy;
        //}





        static void Main(string[] args)
        {
            Console.Write("\nВведiть слово: ");
            string inputString = Console.ReadLine();

            //string outputString = inputString.Reverse().Aggregate(string.Empty, (acc, ch) => acc + ch);
            //string outputString = new string(inputString.ToCharArray().Reverse().ToArray());

            string outputString = ReverseString(inputString);
            //string outputString = ReverseStringBuilder(inputString);
            //string outputString = ReverseUnsafeCopy(inputString);

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
