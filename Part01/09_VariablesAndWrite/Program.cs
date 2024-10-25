using System;

namespace _09_VariablesAndWrite
{
    // 두 변수를 출력하는 방법
    internal class Program
    {
        static void Main(string[] args)
        {
            int v1 = 100;
            double v2 = 1.234;

            // Console.WriteLine(v1, v2);   // 에러가 발생합니다.
            Console.WriteLine(v1.ToString() + ", " + v2.ToString());
            Console.WriteLine("v1 = " + v1 + ", v2 = " + v2);
            Console.WriteLine("v1 = {0}, v2 = {1}", v1, v2);
            Console.WriteLine($"v1 = {v1}, v2 = {v2}");
        }
    }
}
