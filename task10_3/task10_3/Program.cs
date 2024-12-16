using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task10_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число a (a > 1): ");
            double a = double.Parse(Console.ReadLine());

            if (a <= 1)
            {
                Console.WriteLine("Число a должно быть больше 1.");
                return;
            }

            double sum = 1;
            int n = 1; 

            for (n = 2; ; n++)
            {
                sum += 1 / Math.Sqrt(n); 

                if (sum > a)
                    break;
            }

            Console.WriteLine($"Наименьшее натуральное число n: {n}");
            Console.ReadKey();
        }
    }
}
