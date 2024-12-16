using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task10_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int b = 0;
            if (!TryInputNumber("Введите число b", out b))
            {
                Console.ReadKey();
                return;
            }
            if (b == 0)
            {
                Console.WriteLine("Условие b != 0 не выполняется");
                Console.ReadKey();
                return;
            }
            long sumOfSquares = 0;

            for (var i = -b; i <= b * b; i++)
            {
                sumOfSquares += (long)Math.Pow(i, 2);
            }
            Console.WriteLine($"Сумма квадратов всех целых чисел от -{b} до {b * b} равна: {sumOfSquares}");
            Console.ReadKey();
        }

        static bool TryInputNumber(string message, out int number)
        {
            Console.WriteLine(message);
            var input = Console.ReadLine();

            if (!int.TryParse(input, out number))
            {
                Console.WriteLine("Ошибка ввода");
                return false;
            }
            return true;
        }

    }
}
