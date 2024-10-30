using System;

namespace _33_ConstAndReadonly
{
    // 상수 const와 readonly
    class ConstEx 
    {
        public const int number = 3;
    }

    class ReadonlyEx
    {
        public readonly int number = 10;

        public ReadonlyEx()
        {
            number = 20;
        }
        public ReadonlyEx(int n)
        {
            number = n;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ConstEx.number);      // Const 사용

            ReadonlyEx inst1 =new ReadonlyEx();     // Readonly 사용
            Console.WriteLine(inst1.number);

            ReadonlyEx inst2 = new ReadonlyEx(100); // Readonly 사용
            Console.WriteLine(inst2.number);
        }
    }
}
