using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("исрпо самый лучший предмет!");
            Console.Write("Введите размерность матрицы n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] mas = new int[n, n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    mas[i, j] = random.Next(0, 10);
                    Console.Write($"{mas[i, j]} \t");
                }
                Console.WriteLine();
            }
            int x = 0;
            int y = 0;
            //очень важные изменения
            //без которых код не будет работать
        }
    }
}