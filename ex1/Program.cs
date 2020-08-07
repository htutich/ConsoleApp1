using System;

/*
Дан  целочисленный  массив  из 20 элементов.  
Элементы  массива  могут принимать  целые  значения  от –10 000 до 10 000 включительно. 
Заполнить случайными числами.  Написать программу, позволяющую найти и вывести 
количество пар элементов массива, в которых только одно число делится на 3. 
В данной задаче под парой подразумевается два подряд идущих элемента массива. 
Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2. 

Алексеев Артём
 */

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();

            int[] IntArr = new int[20];
            int parcount = 0;
            string fullarray = "";

            for (int i = 0; i < IntArr.Length; i++)
            {
                int val = rnd.Next(-10000, 10000);
                fullarray += $"{val} ";
                IntArr[i] = val;
            }

            for (int j = 1; j < IntArr.Length; j++)
            {
                if (IntArr[j-1] % 3 == 0 ^ IntArr[j] % 3 == 0)
                {
                    parcount++;
                    Console.WriteLine($"Пара: {IntArr[j-1]} {IntArr[j]}");
                }
            }


            Console.WriteLine($"Массив: {fullarray}");
            Console.WriteLine($"Колличество пар: {parcount}");
            
            Console.ReadLine();
        }
    }
}
