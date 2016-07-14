using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первую строку");
            var str1 = Console.ReadLine();
            Console.WriteLine("Введите вторую строку");
            var str2 = Console.ReadLine();

            str2 = new string(str2.Distinct().ToArray());
            string result = str1;
            
            for (int i = 0; i < str2.Length; i++)
            {
                if (str1.Contains(str2[i]))
                {
                    var symbol = Char.ToString(str2[i]);
                    result = result.Replace(symbol, symbol + symbol);
                }
            }
            Console.WriteLine(result);
            Console.ReadKey();

        }
    }
}
