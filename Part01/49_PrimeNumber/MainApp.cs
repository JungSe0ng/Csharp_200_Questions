using System;

namespace _49_PrimeNumber
{
    // 소수 판단하기
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.Write("숫자를 입력하세요 : ");
            int number = int.Parse(Console.ReadLine());
            int index;

            for (index = 2; index < number; index++)
            {
                if(number % index == 0)
                {
                    Console.WriteLine("{0}은 소수가 아닙니다.",number);
                    break;
                }
            }
            
            if(index == number)
                Console.WriteLine("{0}은 소수입니다.",number);
        }
    }
}
