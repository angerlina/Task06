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
            var pattern = @"[a-zA-Z0-9]+|[_]*@[a-zA-Z0-9][\.][a-zA-Z]{2,6}";
            Regex reg = new Regex(pattern);
            var list = new List<string>();
            foreach (Match match in reg.Matches(str))
            {
                list.Add(match.Value);
            }

            foreach (var element in list)
            {
                Console.WriteLine(element);
            }
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            GetEmails("iratnovskaya@gmail.com, iratnogdfgvskaya@gmail.com");
            //Напишите программу, которая находит и выводит на экран все содержащиеся во введенной с клавиатуры текстовой строке адреса электронной почты. Учесть, что имя почтового ящика может содержать буквы, цифры, точку, дефис и знак подчеркивания, 
            //    причем первым и последним символами могут быть только буквы или цифры. Для имен поддоменов действуют те же самые правила, но точка допустимой не является. Имя домена первого уровня может состоять только из букв в количестве от 2 до 6.
            
        }
    }
}
