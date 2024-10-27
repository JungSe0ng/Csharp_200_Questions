using System;

namespace _19_Overflow
{
    // OverflowException 과 checked키워드
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("int.MaxValue = {0}", int.MaxValue);
            //int x = int.MaxValue, y = 0;
            //y = x + 10;
            //Console.WriteLine("int.MaxValue + 10 = {0}", y);

            // y = int.MaxValue + 10; // 이 문장은 컴파일 할 때 에러가 나옵니다.
            int x = int.MaxValue, y = 0;

            checked
            {
                try
                {
                    y = x + 10;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            Console.WriteLine("int.MaxValue + 10 = {0}", y);
        }
    }
}
