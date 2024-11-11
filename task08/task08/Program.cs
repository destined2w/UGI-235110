using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace task08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите х:");
            Console.WriteLine("Результат: " + Function(double.Parse(Console.ReadLine())));
            Console.ReadKey();
        }
        static double Function(double x)
        {
            double result = 0;
            if (x > 2)
            {
                result = 2;
            }
            else if ((0 < x) & (x <= 2))
            {
                result = 0;
            }
            else if (x <= 0)
            {
                result = (-3) * x;
            }
                return result;
        }
    }
}
