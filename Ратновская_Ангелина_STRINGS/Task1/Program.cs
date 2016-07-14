using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert English text");
            Console.WriteLine();
            var str = Console.ReadLine();
            Console.WriteLine();
            string[] split = str.Split(' ');

            List<char> signsList = new List<char>();

            for (int i = 0; i < 64; i++)
            {
                signsList.Add((char)i);
            }
            for (int i = 91; i < 96; i++)
            {
                signsList.Add((char)i);
            }
            for (int i = 123; i < 255; i++)
            {
                signsList.Add((char)i);
            }


            foreach (var element in split)
            {
                split[Array.IndexOf(split, element)] = element.Trim(signsList.ToArray());
                
            }

            List<string> allWords = split.ToList<string>();
            allWords.RemoveAll(elements => elements == "");

            Console.WriteLine("All the words of the text:");
            Console.WriteLine();

            foreach (var word in allWords)
            {
                Console.WriteLine(word);
            }


            int[] lenghts = new int[allWords.Count];

            foreach (var element in allWords)
            {
                lenghts[allWords.IndexOf(element)] = element.Length;
            }

            var mediumLenght = lenghts.Sum() / lenghts.Length;

            Console.WriteLine();
            Console.WriteLine($"Средняя длина слова = {mediumLenght}");
            Console.ReadLine();
        }
    }
}
