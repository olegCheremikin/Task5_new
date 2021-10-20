using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5._4
{
    class Program
    {
        static void Main(string[] args)
        {
            var rnd = new Random();
            var arr = new int[20];

            for (int i = 0; i < arr.Length; i++)
                Console.Write("{0}\t", arr[i] = rnd.Next(-50, 50));
            Console.WriteLine();

            var even = arr.Where((element, index) => index % 2 != 0);
            var odd = arr.Where((element, index) => index % 2 == 0);

            Console.WriteLine("Чётные. Количество: {0}. Сумма: {1}.", even.Count(), even.Sum());
            Console.WriteLine("Нечётные. Количество: {0}. Сумма: {1}.", odd.Count(), odd.Sum());

            Console.ReadKey();
        }
    }
}
