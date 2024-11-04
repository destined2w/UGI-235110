using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task07_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите позицию белой ладьи (например, a1):");
            var whiteRookPosition = Console.ReadLine();

            if (!IsPositionCorrect(whiteRookPosition))
            {
                Console.WriteLine("Некорректная позиция ладьи");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Введите позицию черного коня (например, a1):");
            var blackKnightPosition = Console.ReadLine();

            if (!IsPositionCorrect(blackKnightPosition) || whiteRookPosition == blackKnightPosition)
            {
                Console.WriteLine("Некорректная позиция черного коня");
                Console.ReadKey();
                return;
            }

            if (IsKnightStrike(blackKnightPosition, whiteRookPosition))
            {
                Console.WriteLine("Черный конь атакует белую ладью.");
            }
            else
            {
                Console.WriteLine("Черный конь не атакует белую ладью.");
                Console.WriteLine("Введите ход белой ладьи (например, a3):");
                var move = Console.ReadLine();

                if (IsRookMoveValid(whiteRookPosition, move))
                    Console.WriteLine("Ход разрешен");
                else
                    Console.WriteLine("Ход запрещен");
            }

            Console.ReadKey();
        }

        static bool IsPositionCorrect(string position)
        {
            if (position.Length != 2)
                return false;

            int row;
            int column;
            DecodePosition(position, out column, out row);

            return column >= 1 && column <= 8 && row >= 1 && row <= 8;
        }

        static bool IsKnightStrike(string knightPosition, string rookPosition)
        {
            int kr, kc, rr, rc;
            DecodePosition(knightPosition, out kc, out kr);
            DecodePosition(rookPosition, out rc, out rr);

            return (kc + 2 == rc && kr + 1 == rr) ||
                   (kc + 2 == rc && kr - 1 == rr) ||
                   (kc - 2 == rc && kr + 1 == rr) ||
                   (kc - 2 == rc && kr - 1 == rr) ||
                   (kc + 1 == rc && kr + 2 == rr) ||
                   (kc + 1 == rc && kr - 2 == rr) ||
                   (kc - 1 == rc && kr + 2 == rr) ||
                   (kc - 1 == rc && kr - 2 == rr);
        }


        static bool IsRookMoveValid(string startPosition, string movePosition)
        {
            if (!IsPositionCorrect(movePosition))
                return false;

            int startColumn, startRow, moveColumn, moveRow;
            DecodePosition(startPosition, out startColumn, out startRow);
            DecodePosition(movePosition, out moveColumn, out moveRow);
            return startColumn == moveColumn || startRow == moveRow;
        }

        static void DecodePosition(string position, out int column, out int row)
        {
            row = int.Parse(position[1].ToString());
            column = (int)position[0] - 0x60;
        }
    }
}