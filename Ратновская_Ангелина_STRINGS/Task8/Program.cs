using System.Text;
using System.Threading;
using System.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task8
{
    class Program
    {
        static void StringBuilder()
        {
            StringBuilder sb = new StringBuilder();
            int N = 100;

            for (int i = 0; i < N; i++)
            {
                sb.Append("*");
            }
        }
        static void String()
        {
            string str = "";
            int N = 100;

            for (int i = 0; i < N; i++)
            {
                str += "*";
            }
        }
        static void Main()
        {
            Stopwatch stopWatch = new Stopwatch();

            stopWatch.Start();
            String();
            stopWatch.Stop();

            var stringTime = stopWatch.Elapsed;

            stopWatch.Reset();

            stopWatch.Start();
            StringBuilder();
            stopWatch.Stop();

            var stringBuilderTime = stopWatch.Elapsed;

            Console.WriteLine($"Время, затраченное StringBuilder = {stringBuilderTime.TotalMilliseconds}\nВремя, затраченное String = {stringTime.TotalMilliseconds}");
            Console.ReadKey();
        }
    }
}
