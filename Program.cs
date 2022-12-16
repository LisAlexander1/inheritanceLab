using System;
using System.Numerics;

//Чиннов 19 вариант средний

namespace inheritanceLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new();
            do
            {
                bool suc;
                int x1;
                int y1;
                int x2;
                int y2;
                int a;
                int b;

                do
                {
                    Console.Write("Ввведите x1 - ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    suc = int.TryParse(Console.ReadLine(), out x1);
                    Console.ResetColor();
                } while (!suc);

                do
                {
                    Console.Write("Ввведите y1 - ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    suc = int.TryParse(Console.ReadLine(), out y1);
                    Console.ResetColor();
                } while (!suc);

                do
                {
                    Console.Write("Ввведите x2 - ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    suc = int.TryParse(Console.ReadLine(), out x2);
                    Console.ResetColor();
                } while (!suc);

                do
                {
                    Console.Write("Ввведите y2 - ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    suc = int.TryParse(Console.ReadLine(), out y2);
                    Console.ResetColor();
                } while (!suc);

                do
                {
                    Console.Write("Ввведите a - ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    suc = int.TryParse(Console.ReadLine(), out a);
                    Console.ResetColor();
                } while (!suc);

                do
                {
                    Console.Write("Ввведите b - ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    suc = int.TryParse(Console.ReadLine(), out b);
                    Console.ResetColor();
                } while (!suc);

                OffsetVector vector = new(x1, y1, x2, y2, a, b);
                Console.WriteLine($"Площадь параллелограмма {vector.GetParallogramArea()}"); ;
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("Нажмите любую кнопку, чтобы начать заново, заново, заново...");
                Console.ReadKey();
                Console.Clear();
                Console.ResetColor();
            } while (true);
        }
    }
}