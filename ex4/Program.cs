using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*

Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль. 
На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). 
Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, 
программа пропускает его дальше или не пропускает. 
С помощью цикла do while ограничить ввод пароля тремя попытками.

Алексеев Артём
*/
namespace ex4
{
    class Program
    {
        static bool Auth()
        {
            string login = "root";
            string pass = "GeekBrains";

            bool doit = true;
            int trys = 3;

            string chlogin = "";
            string chpass = "";

            while (doit)
            {
                if (chlogin == "")
                {
                    Console.WriteLine("Ведите логин");
                    chlogin = Console.ReadLine();
                }

                if (chpass == "")
                {
                    Console.WriteLine("Ведите пароль");
                    chpass = Console.ReadLine();
                }

                if (chlogin != login || chpass != pass)
                {
                    trys--;
                    Console.WriteLine($"Неверный логин или пароль. Осталось попыток {trys}");
                    chlogin = "";
                    chpass = "";
                }

                if(trys == 0)
                {
                    doit = false;
                }

                if (chlogin == login && chpass == pass)
                {
                    break;
                }
            }
            return doit;
        }
        static void Main(string[] args)
        {
            if(Auth())
            {
                Console.WriteLine("Добро пожаловать!");
            } 
            else
            {
                Console.WriteLine("Попытки авторизации исчерпаны!");
            }
            Console.ReadLine();
        }
    }
}
