using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examtask
{
    internal class Program
    {
        static void Main()
        {
            const int limit = 1000;
            bool[] hasGenerator = new bool[limit];

            for (int i = 1; i < limit; i++)
            {
                int generatedNumber = GenerateNumber(i);
                if (generatedNumber < limit)
                {
                    hasGenerator[generatedNumber] = true;
                }
            }

            Console.WriteLine("Самопорожденные числа меньше 1000:");
            for (int i = 1; i < limit; i++)
            {
                if (!hasGenerator[i])
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }

        static int GenerateNumber(int num)
        {
            int sum = num;
            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }
            return sum;
        }
    }
}
