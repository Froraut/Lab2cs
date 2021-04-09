using System;

namespace lab2_2s
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку:");
            string st = Console.ReadLine();
            string[] words = st.Split(' ');

            Console.WriteLine("Строка в обратном порядке: ");

            for (int i = words.Length - 1; i >= 0; i--)
            {
                Console.Write("{0} ", words[i]);
            }
        }   
    }
}
    
