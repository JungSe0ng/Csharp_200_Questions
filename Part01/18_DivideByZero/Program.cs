using System;

namespace _18_DivideByZero
{
    // DivideByZeroException과 try ~ catch 문
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 10, y = 0;

            //  Console.WriteLine(10.0 / y);
            //  Console.WriteLine(x / y);       // 예외 발생

            try
            {
                Console.WriteLine(x / y);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
