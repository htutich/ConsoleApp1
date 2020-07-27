using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя");
            var name = Console.ReadLine();

            Console.WriteLine("Введите фамилию");
            var lname = Console.ReadLine();

            Console.WriteLine("Введите возраст");
            var age = Console.ReadLine();

            Console.WriteLine("Введите рост");
            var hman = Console.ReadLine();

            Console.WriteLine("Введите вес");
            var lman = Console.ReadLine();


            Console.WriteLine(name + " " + lname + " " + age + " " + hman + " " + lman);
            Console.WriteLine("{0} {1} {2} {3} {4}", name, lname, age, hman, lman);
            Console.WriteLine($"{name} {lname} {age} {hman} {lman}");
            Console.ReadLine();
        }
    }
}
