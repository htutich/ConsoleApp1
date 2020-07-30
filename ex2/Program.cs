using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Написать метод подсчета количества цифр числа.
Алексеев Артём
*/

namespace ex2
{
    class Program
    {
        static int countNumbers(int value)
        {
            string str = Convert.ToString((value < 0)?(value * -1):value);
            return str.Length;
        }

        static void Main(string[] args)
        {
            int count = countNumbers(-93223944);
            Console.WriteLine($"{count}");
            Console.ReadLine();
        }
    }
}
