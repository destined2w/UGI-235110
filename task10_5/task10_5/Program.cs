using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task10_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите коэффициенты a, b, c и точность e (через пробел):");
            if (!ReadInput(out double a, out double b, out double c, out double epsilon))
            {
                Console.WriteLine("Ошибка ввода данных.");
                Console.ReadKey();
                return;
            }
            double left = -1, right = 0;
            while (CalculateFunction(a, b, c, left) >= 0)
            {
                left--;
            }
            double root = BisectionMethod(a, b, c, left, right, epsilon);

            Console.WriteLine($"Найденный корень: {root:F6}");
            Console.ReadKey();
        }

        static bool ReadInput(out double a, out double b, out double c, out double epsilon)
        {
            a = b = c = epsilon = 0;
            string[] input = Console.ReadLine().Split(' ');

            if (input.Length != 4)
                return false;

            return double.TryParse(input[0], out a) &&
                   double.TryParse(input[1], out b) &&
                   double.TryParse(input[2], out c) &&
                   double.TryParse(input[3], out epsilon) &&
                   a > 0 && b > 0 && c > 0 && epsilon > 0;
        }

        static double CalculateFunction(double a, double b, double c, double x)
        {
            return Math.Pow(x, 3) + a * Math.Pow(x, 2) + b * x + c;
        }

        static double BisectionMethod(double a, double b, double c, double left, double right, double epsilon)
        {
            double mid;

            while (Math.Abs(right - left) > epsilon)
            {
                mid = (left + right) / 2;

                double fLeft = CalculateFunction(a, b, c, left);
                double fMid = CalculateFunction(a, b, c, mid);

                if (fLeft * fMid <= 0) 
                {
                    right = mid;
                }
                else
                {
                    left = mid;
                }
            }

            return (left + right) / 2;
        }
    }
}