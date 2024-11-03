using System;
using System.Net.WebSockets;

namespace _56_LoopPyramid
{
    // 이중 루프와 피라미드 출력
    class Program
    {
        static void Main(string[] args)
        {
            // (1)
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write("*");
                Console.WriteLine();
            }
            Console.WriteLine();

            //(2)
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.WriteLine();
            }
            Console.WriteLine();

            // (3)
            for (int i = 5; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write("*");
                Console.WriteLine();
            }
            Console.WriteLine();

            // (4)
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5 - i; j++)
                    Console.Write(" ");
                for (int j = 1; j <= i; j++)
                    Console.Write("*");
                Console.WriteLine();
            }
            Console.WriteLine();

            // (5)
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5 - i; j++)
                    Console.Write(" ");
                for (int j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.WriteLine();
            }
            Console.WriteLine();

            // (6)
            for (int i = 5; i >= 1; i--)
            {
                for (int j = 1; j <= 5 - i; j++)
                    Console.Write(" ");
                for (int j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.WriteLine();
            }
        }
    }
}
