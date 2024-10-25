using System;
using System.Net.WebSockets;

namespace _08_ConsoleWriteMulti
{
    // 08 Console.WriteLine 메소드로 여러 개의 값을 출력
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("10 이하의 소수 {0}, {1}, {2}, {3}", 2, 3, 5, 7);

            string primes;
            primes = string.Format("10 이하의 소수 : {0}, {1}, {2}, {3}", 2, 3, 5, 7);
            Console.WriteLine(primes);
        }
    }
}
