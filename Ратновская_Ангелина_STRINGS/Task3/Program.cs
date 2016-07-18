using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Task3
{
    class Program
    {
        private static void IsDate()
        {
            Console.WriteLine("Содержится ли во введенном с клавиатуры тексте дата в формате dd-mm-yyyy? Введите текст:");
            var str = Console.ReadLine();
            const string pattern = @"(0[1-9]|1[0-9]|2[0-9]|3[01])-(0[1-9]|1[0-9]|2[0-9]|3[01])-([0-9]{4})";
            Regex reg = new Regex(pattern);
            Console.WriteLine(str != null && reg.IsMatch(str) ? $"В тексте \"{str}\" содержится дата" : $"В тексте \"{str}\" нет даты");
            Console.ReadLine();
        }

        static void HtmlToStringConverter()
        {
            Console.WriteLine("Введите текст с html тегами:");
            string str = Console.ReadLine();
            const string pattern = "</?([a-zA-Z])+( [ a-zA-Z-_]+=(”|\")[ a-zA-Z0-9;:-_]+(”|\"))*>";
            Regex reg = new Regex(pattern);
            if (str != null) Console.WriteLine(reg.Replace(str, "_"));
            Console.ReadLine();
        }

        private static void GetEmails()
        {
            Console.WriteLine("Поиск имейлов в тексте. Введите текст:");
            string str = Console.ReadLine();
            const string pattern = @"[a-zA-Z0-9][a-zA-Z0-9\._-]*@[a-zA-Z0-9][a-zA-Z0-9_-]*[\.][a-zA-Z0-9]{2,6}";
            Regex reg = new Regex(pattern);
            Console.WriteLine("Найденные в тексте имейлы:");
            if (str != null)
            {
                var list = (from Match match in reg.Matches(str) select match.Value).ToList();

                foreach (var element in list)
                {
                    Console.WriteLine(element);
                }
            }

            Console.ReadLine();
        }

        private static void GetNotation()
        {
            Console.WriteLine("Определение формата записи числа. Введите число в обычной или научной нотации:");
            string str = Console.ReadLine();
            const string pattern1 = @"^\d+$";
            Regex reg1 = new Regex(pattern1);
            const string pattern2 = @"^-?\d+\.\d+(e|E)(\+?|-?)\d+$";
            Regex reg2 = new Regex(pattern2);

            if (str != null && reg1.IsMatch(str)) Console.WriteLine("Это число в обычной нотации");

            if (str != null && reg2.IsMatch(str)) Console.WriteLine("Это число в научной нотации");

            if (str != null && (!reg1.IsMatch(str)&& !reg2.IsMatch(str))) Console.WriteLine("Это не число в обычной нотации и не число в научной нотации");

            Console.ReadKey();
        }

        private static void GetAmountOfTimeString()
        {
            Console.WriteLine("Подсчет кол-ва времени в тексте. Введите текст:");
            var str = Console.ReadLine();
            const string pattern = @"(0[0-9]|1[0-9]|(\D[1-9])|[2[0-3]):[0-5][0-9]";
            Regex reg = new Regex(pattern);
            if (str != null) Console.WriteLine("Время в тексте присутствует {0} раз", reg.Matches(str).Count);
            Console.ReadKey();


        }
        static void Main()
        {
            
            IsDate();
            Console.WriteLine();
            HtmlToStringConverter();
            Console.WriteLine();
            GetEmails();
            Console.WriteLine();
            GetNotation();
            Console.WriteLine();
            GetAmountOfTimeString();

        }

    }
}
