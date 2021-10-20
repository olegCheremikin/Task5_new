using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[7];
            int Sum = 0;
            for (int i = 0; i < 7; i++)
            {
                Console.Write("Введите {0} число массива: ", i + 1);
                array[i] = Convert.ToInt32(Console.ReadLine());
                Sum += array[i];
            }
            Console.Write("Среднее арифметическое элементов массива = {0}", Sum / 7);
            Console.ReadKey();
        }
    }
}
