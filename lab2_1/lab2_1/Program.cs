using System;
using System.Text.RegularExpressions;

namespace lab2_1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите строку: ");
            string str = Console.ReadLine();
            Regex regex = new Regex(@"[А-Я]{1}");
            MatchCollection matches = regex.Matches(str);
            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                    Console.Write(match.Value + " ");
            }
            else
            {
                Console.WriteLine("Совпадений не найдено!");
            }
        }
    }
}
