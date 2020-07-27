using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите x1");
            var _x1 = Console.ReadLine();

            Console.WriteLine("Введите y1");
            var _y1 = Console.ReadLine();

            Console.WriteLine("Введите x2");
            var _x2 = Console.ReadLine();

            Console.WriteLine("Введите y2");
            var _y2 = Console.ReadLine();

            int x1 = Convert.ToInt32(_x1);
            int x2 = Convert.ToInt32(_x2);
            int y1 = Convert.ToInt32(_y1);
            int y2 = Convert.ToInt32(_y2);


            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            Console.WriteLine($"{r:F2}");
            Console.ReadLine();
        }
    }
}
