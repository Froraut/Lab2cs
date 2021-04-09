using System;

namespace lab2_3s

{
    class Program
    {
        static void CountDigits(int digit, string str)
        {
            int counter = 0;
            int pointer = 0;
            while (pointer < str.Length)
            {
                if (str[pointer] == Convert.ToChar(48 + digit)) counter++;
                pointer++;
            }
            if ((counter == 2)||(counter == 3) || (counter == 4)) Console.WriteLine($"Цифра {digit} повторяется 2 разa");
            else Console.WriteLine($"Цифра {digit} повторяется {counter} раз");
            
        }
        static void Main(string[] args)
        {
            DateTime ThisMoment = new DateTime();
            ThisMoment = DateTime.Now;
            Console.WriteLine(ThisMoment);
            Console.WriteLine($"{ThisMoment.ToLongDateString()}   {ThisMoment.ToLongTimeString()}");
            string str = Convert.ToString(ThisMoment);
            for (int digit = 0; digit < 10; digit++)
            {
                CountDigits(digit, str);
            }
        }
    }
}