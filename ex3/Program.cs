using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
Алексеев Артём
*/

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool doit = true;
            int num = 0;
            Console.WriteLine("С клавиатуры вводятся числа, пока не будет введен 0. После подсчет суммы всех нечетных положительных чисел.");
            
            while (doit)
            {
                string str = Console.ReadLine();
                int nnm = Convert.ToInt32(str);

                if (nnm == 0) {
                    doit = false;
                    break;
                }
                num += (nnm % 2 == 0) ? ((nnm > 0) ? nnm : 0) : 0;

            }

            Console.WriteLine($"Сумма: {num}");
            Console.ReadLine();
        }
    }
}
