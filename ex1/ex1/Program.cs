using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Написать метод, возвращающий минимальное из трёх чисел.
Алексеев Артём
*/
namespace ex1
{
    class Program
    {

        static double minNumber(params int[] numbers)
        {
            double min = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                min = (min > numbers[i]) ? numbers[i] : min;
            }
            return min;
        }

        static void Main(string[] args)
        {
            double min = minNumber(3, 5, 7, 3, 4, 7, 1);
            Console.WriteLine($"{min:F2}");
            Console.ReadLine();
        }
    }
}
