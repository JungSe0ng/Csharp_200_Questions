using System;

namespace _13_TypeConversion
{
    // 캐스팅과 자료형 변환
    class Program
    {
        static void Main(string[] args)
        {
            int num = 2147483647;
            long bigNum = num;          // 암시적 형변환
            Console.WriteLine(bigNum);

            double x = 1234.5;
            int a;

            a = (int)x;                 // 명시적 형변환
            Console.WriteLine(a);
        }
    }
}
