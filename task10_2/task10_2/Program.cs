using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task10_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество чисел (n): ");
            int n = int.Parse(Console.ReadLine());

            double product = 1;

            Console.WriteLine("Введите числа:");
            for (int i = 0; i < n; i++)
            {
                double a = double.Parse(Console.ReadLine());
                product *= Math.Abs(a);
            }

            Console.WriteLine($"Произведение модулей чисел: {product}");
            Console.ReadKey();
        }
    }
}
