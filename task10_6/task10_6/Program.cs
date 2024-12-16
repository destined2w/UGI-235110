using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task10_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, k;

            if (!TryInputNumber("Введите начало промежутка (a):", out a))
                return;

            if (!TryInputNumber("Введите конец промежутка (b):", out b))
                return;

            if (a >= b)
            {
                Console.WriteLine("Ошибка: a должно быть меньше b.");
                return;
            }

            if (!TryInputNumber("Введите количество делителей (k):", out k) || k < 2)
            {
                Console.WriteLine("Ошибка: k должно быть не меньше 2.");
                return;
            }

            int counter = 0;

            for (int number = a; number <= b; number++)
            {
                if (CountDivisors(number) == k)
                {
                    Console.Write($"{number}, ");
                    counter++;
                }
            }

            if (counter == 0)
                Console.WriteLine($"\nЧисел с {k} делителями в промежутке [{a}, {b}] не найдено.");
            else
                Console.WriteLine("\b\b ");

            Console.ReadKey();
        }

        static int CountDivisors(int num)
        {
            int count = 0;

            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                    count++;
            }

            return count;
        }

        static bool TryInputNumber(string message, out int number)
        {
            Console.WriteLine(message);
            var input = Console.ReadLine();

            if (!int.TryParse(input, out number) || number <= 0)
            {
                Console.WriteLine("Ошибка ввода: введите натуральное число.");
                return false;
            }

            return true;
        }
    }
}