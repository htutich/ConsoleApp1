using System;
using System.IO;
/*
Реализуйте задачу 1 в виде статического класса StaticClass;
а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
б) *Добавьте статический метод для считывания массива из текстового файла. Метод должен возвращать массив целых чисел;
в)**Добавьте обработку ситуации отсутствия файла на диске.

Алексеев Артём
*/
namespace ex2
{
    static class StaticClass
    {

        public static int ParCount(int[] IntArr)
        {
            int parcount = 0;

            for (int j = 1; j < IntArr.Length; j++)
            {
                if (IntArr[j - 1] % 3 == 0 ^ IntArr[j] % 3 == 0)
                {
                    parcount++;
                    Console.WriteLine($"Пара: {IntArr[j-1]} {IntArr[j]}");
                }
            }

            return parcount;
        }

        public static int[] getArrayFromFile(string filename)
        {
            if (File.Exists(filename))
            {
                Console.WriteLine("Чтение массива из файла.");
                string[] fl = File.ReadAllLines(filename);
                int[] IntArr = new int[fl.Length];

                for (int i = 0; i < fl.Length; i++)
                {
                    IntArr[i] = int.Parse(fl[i]);
                }

                return IntArr;

            }
            else
            {
                Console.WriteLine("Ошибка загрузки файла.");

                Random rnd = new Random();

                int[] IntArr = new int[20];
                string fullarray = "";

                for (int i = 0; i < IntArr.Length; i++)
                {
                    int val = rnd.Next(-10000, 10000);
                    fullarray += $"{val} ";
                    IntArr[i] = val;
                }
                Console.WriteLine($"Сгенерирован массив: {fullarray}");

                return IntArr;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            string path = "array.txt";
            int[] IntArr = StaticClass.getArrayFromFile(path);
            int parcount = StaticClass.ParCount(IntArr);

            Console.WriteLine($"Колличество пар: {parcount}");

            Console.ReadLine();

        }
    }
}
