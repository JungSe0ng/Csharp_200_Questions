using System;

namespace _45_MultiplicationTable
{
    // 반복문으로 구구단 출력
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("구구단의 출력할 단수를 입력하세요 : ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 9; i++)
            {
                Console.WriteLine("{0} x {1}  = {2}", n, i, n * i);
            }
        }
    }
}
