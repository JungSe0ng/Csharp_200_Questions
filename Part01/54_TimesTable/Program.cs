using System;

namespace _54_TimesTable
{
    // 이중 루프를 이용하여 구구단 출력
    class Program
    {
        static void Main(string[] args)
        {
            for (int y = 1; y <= 9; y++)
            {
                for (int x = 2; x <= 9; x++)
                    Console.Write("{0} x {1} = {2,2}    ", x, y, x * y);
                Console.WriteLine();
            }
        }
    }
}
