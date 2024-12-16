using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task10_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральное число:");

            int number;
            if (!int.TryParse(Console.ReadLine(), out number) || number < 1)
            {
                Console.WriteLine("Ошибка ввода. Введите натуральное число.");
                return;
            }

            int maxDigit = -1; 
            int maxDigitPosition = 0;
            int currentPosition = 0; 
            int temp = number;

            int divider = 1;

            while (temp > 9)
            {
                temp /= 10;
                divider *= 10;
            }

            temp = number;

            while (divider > 0)
            {
                currentPosition++;
                int digit = (temp / divider) % 10; 

                if (digit > maxDigit)
                {
                    maxDigit = digit;
                    maxDigitPosition = currentPosition;
                }

                divider /= 10;
            }

            Console.WriteLine($"Порядковый номер первой наибольшей цифры: {maxDigitPosition}");
            Console.ReadKey();
        }
    }
}