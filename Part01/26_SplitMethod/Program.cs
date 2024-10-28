using System;

namespace _26_SplitMethod
{
    // String.Split()메소드를 사용한 문자열 구문 분석
    class Program
    {
        static void Main(string[] args)
        {  
            Console.Write("더하고자 하는 숫자들을 입력하세요 : ");
            string s = Console.ReadLine();
            Console.WriteLine(s);

            int sum = 0;
            string[] v = s.Split();
            foreach (var i in v)
            {
                sum += int.Parse(i);
            }
            Console.WriteLine("결과는 {0}", sum);
        }
    }
}
