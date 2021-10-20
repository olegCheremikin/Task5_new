using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение N: ");
            int n = int.Parse(Console.ReadLine());
            int[,] arr = new int[n, n];
            for (int i = 0; i < arr.GetLength(0); i++)
                for (int j = 0; j < arr.GetLength(1); j++)
                    arr[i, j] = (i + j) % 2 == 1 ? 0 : 1;
            Console.WriteLine("Двумерный массив NxN:");
            for (int i = 0; i < arr.GetLength(0); i++, Console.WriteLine())
                for (int j = 0; j < arr.GetLength(1); j++)
                    Console.Write("{0,3}", arr[i, j]);
            Console.ReadKey();
        }
    }
}
