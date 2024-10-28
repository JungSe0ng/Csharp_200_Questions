using System;

namespace _24_CompoundAssignment
{
    // 증가연산자, 감소연산자와 대입연산자의 압축
    class Program
    {
        static void Main(string[] args)
        {
            int x = 32;

            Console.WriteLine(x += 2);
            Console.WriteLine(x -= 8);
            Console.WriteLine(x *= 3);
            Console.WriteLine(x /= 2);
            Console.WriteLine(x++);
            Console.WriteLine(++x);
        }
    }
}
