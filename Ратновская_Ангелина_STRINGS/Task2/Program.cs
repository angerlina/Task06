using System;
using System.Linq;

namespace Task2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите первую строку");
            var str1 = Console.ReadLine();
            Console.WriteLine("Введите вторую строку");
            var str2 = Console.ReadLine();

            if (str2 != null)
            {
                str2 = new string(str2.Distinct().ToArray());
                string result = str1;
            
                for (int i = 0; i < str2.Length; i++)
                {
                    if (str1 != null && str1.Contains(str2[i]))
                    {
                        var symbol = Char.ToString(str2[i]);
                        result = result.Replace(symbol, symbol + symbol);
                    }
                }
                Console.WriteLine(result);
            }
            Console.ReadKey();

        }
    }
}
