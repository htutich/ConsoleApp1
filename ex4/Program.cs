using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a1 = 400;
            int a2 = 500;
            Console.WriteLine($" {a1} {a2}");
            int a3 = a1;
            a1 = a2;
            a2 = a3;
            Console.WriteLine($" {a1} {a2}");
            Console.WriteLine("\n\n\n\n");




            string b1 = "fsdfsdf";
            string b2 = "c333";
            Console.WriteLine($" {b1} {b2}");

            (b1, b2) = (b2, b1);
            Console.WriteLine($" {b1} {b2}");


            Console.ReadLine();

        }
    }
}
