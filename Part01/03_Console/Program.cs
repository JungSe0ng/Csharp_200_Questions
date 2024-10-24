using System;
using System.Globalization;

// 03 콘솔에서 읽고 쓰기
namespace _03_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello ");
            Console.WriteLine("World!");
            Console.Write("이름을 입력하세요 : ");

            string name = Console.ReadLine();
            Console.Write("안녕하세요, ");
            Console.Write(name);
            Console.WriteLine("님!");
        }
    }
}
