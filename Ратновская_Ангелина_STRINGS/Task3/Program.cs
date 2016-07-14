using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Task3
{
    class Program
    {
        static bool IsDate(string str)
        {
            var pattern = @"(0[1-9]|1[0-9]|2[0-9]|3[01])-(0[1-9]|1[0-9]|2[0-9]|3[01])-([0-9]{4})";
            Regex reg = new Regex(pattern);
            return reg.IsMatch(str);
        }

        static string HtmlConverter(string str)
        {
            var pattern = "</?([a-zA-Z])+( [ a-zA-Z-]+=(”|\")[ a-zA-Z0-9;:-]+(”|\"))*>";
            Regex reg = new Regex(pattern);
            return reg.Replace(str, "_");
        }

        static void GetEmails(string str)
        {
            var pattern = @"[a-zA-Z0-9][a-zA-Z0-9\._-]*@[a-zA-Z0-9][a-zA-Z0-9_-]*[\.][a-zA-Z0-9]{2,6}";
            Regex reg = new Regex(pattern);

            var list = (from Match match in reg.Matches(str) select match.Value).ToList();

            foreach (var element in list)
            {
                Console.WriteLine(element);
            }
            Console.ReadLine();
        }

        static void GetNotation(string str)
        {
            var pattern1 = @"\d+";
            Regex reg1 = new Regex(pattern1);
            var pattern2 = @"";
            Regex reg2 = new Regex(pattern2);

            if (reg1.IsMatch(str)) Console.WriteLine("Это число в обычной нотации");
            if (reg2.IsMatch(str)) Console.WriteLine("Это число в научной нотации");
            else Console.WriteLine("Это не число в обычной нотации и не число в научной нотации");

            Console.ReadKey();

        }
        static void Main(string[] args)
        {
            GetNotation("5435");
        }
    }
}
