using System;

//а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.
//б) Дописать класс Complex, добавив методы вычитания и произведения чисел.Проверить работу класса.
//в) Добавить диалог с использованием switch демонстрирующий работу класса.

//Алексеев Артём
namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ввод значений для комплексных чисел
            Console.Write("Введите реальное(re) значение первого комплексного числа: ");
            int userComplexReFirst = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите мнимое(im) значение первого комплексного числа: ");
            int userComplexImFirst = Convert.ToInt32(Console.ReadLine());

            Complex userComplex1 = new Complex(userComplexImFirst, userComplexReFirst);

            Console.Write("Введите реальное(re) значение второго комплексного числа: ");
            int userComplexReSecond = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите мнимое(im) значение второго комплексного числа: ");
            int userComplexImSecond = Convert.ToInt32(Console.ReadLine());

            Complex userComplex2 = new Complex(userComplexImSecond, userComplexReSecond);

            Console.WriteLine("Пожалуйста, нажмите на выбор действие(с цифровой клавиатуры), которое хотите произвести с данными комплексными числами: \n \"+\" - сложить комплексные числа;\n \"*\" - перемножить комплексные числа;\n \"-\" - вычесть комплексные числа;");
            
            //Запоминаем кнопку, которую нажал пользователь
            ConsoleKeyInfo choose = Console.ReadKey();
            
            switch (choose.Key)
            {

                // умножение.
                case ConsoleKey.Multiply: Console.WriteLine(userComplex1.Multiply(userComplex2).ToString()); break;

                // сложение
                case ConsoleKey.Add: Console.WriteLine(userComplex1.Plus(userComplex2).ToString()); break;

                // вычитание
                case ConsoleKey.Subtract:
                    Console.WriteLine("\nПожалуйста, нажмите на выбор, какое из какого числа хотите вычесть: \n1. Второе из первого.\n2. Первое из второго;");
                    choose = Console.ReadKey();

                    //Проверяем, какую цифру с клавиатуры нажали
                    if (choose.Key == ConsoleKey.NumPad1) Console.WriteLine(userComplex1.Minus(userComplex2).ToString());
                    else if (choose.Key == ConsoleKey.NumPad2) Console.WriteLine(userComplex2.Minus(userComplex1).ToString());
                    break;
            }

            Console.ReadLine();
        }
    }
}
