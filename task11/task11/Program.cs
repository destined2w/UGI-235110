using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральное число b:");
            if (!int.TryParse(Console.ReadLine(), out int b) || b <= 0)
            {
                Console.WriteLine("Ошибка ввода. b должно быть натуральным числом.");
                return;
            }

            int[] array = new int[15];
            FillSequence(array, b);
            Console.WriteLine("Исходный массив:");
            PrintArray(array);

            ChangeSignAtOddIndexes(array);
            Console.WriteLine("Массив после изменения знаков элементов с нечетным индексом:");
            PrintArray(array);

            double average = CalculateAverage(array);
            Console.WriteLine($"Среднее арифметическое: {average:F3}");

            Console.WriteLine("Введите целое число k:");
            if (!int.TryParse(Console.ReadLine(), out int k) || k == 0)
            {
                Console.WriteLine("Ошибка ввода. k должно быть ненулевым целым числом.");
                return;
            }

            int[] remainders = GetRemainders(array, k);
            Console.WriteLine("Остатки от деления элементов массива на k:");
            PrintArray(remainders);
            Console.ReadKey();
        }

        static void FillSequence(int[] array, int b)
        {
            int a = 2;
            for (int n = 0; n < array.Length; n++)
            {
                array[n] = a * n - b;
            }
        }

        static void PrintArray(int[] array)
        {
            Console.WriteLine(string.Join("; ", array));
        }

        static void ChangeSignAtOddIndexes(int[] array)
        {
            for (int i = 1; i < array.Length; i += 2)
            {
                array[i] = -array[i];
            }
        }

        static double CalculateAverage(int[] array)
        {
            double sum = 0;
            foreach (int value in array)
            {
                sum += value;
            }
            return sum / array.Length;
        }

        static int[] GetRemainders(int[] array, int k)
        {
            int[] remainders = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                remainders[i] = array[i] % k;
            }
            return remainders;
        }
    }
}