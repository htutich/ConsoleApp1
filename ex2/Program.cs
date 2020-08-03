using System;

//а)  С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке). 
//Требуется подсчитать сумму всех нечётных положительных чисел. Сами числа и сумму вывести на экран, используя tryParse.
//Алексеев Артём

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            string n;
            int sum = 0;
            string all = "";

            do
            {
                n = Console.ReadLine();
                if (int.TryParse(n, out int i) && (i > 0) && (i % 2 != 0))
                {
                    sum += i;
                    all += $" {i}";
                }

            } while (n != "0");

            Console.WriteLine($"Сумма чисел {sum}; \nВсе числа - {all}");

            Console.ReadLine();
        }

    }
}
