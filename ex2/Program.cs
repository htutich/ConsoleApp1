using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите вес");
            var hman = Console.ReadLine();

            Console.WriteLine("Введите рост");
            var lman = Console.ReadLine();

            var l = Convert.ToDouble(hman)  / (Convert.ToDouble(lman) * Convert.ToDouble(lman));
            Console.WriteLine($"{l}");

            Console.ReadLine();
        }
    }
}
