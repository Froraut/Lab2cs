using System;

namespace experiment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку: ");
            string s = Console.ReadLine();

            Console.Write("Неанглийские заглавные буквы: ");
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] >= 'А' && s[i] <= 'Я')
                {
                    Console.Write(s[i] + " ");
                }
            }
        }
    }
}
