using System;

namespace _58_ArrayClass
{
    // 배열과 Array 클래스
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 5, 25, 75, 35, 15 };    // 배열을 선언하고 초기화
            printArray(a);

            int[] b;
            b = (int[])a.Clone();               // 배열 복사 방법 1
            printArray(b);

            int[] c = new int[10];
            Array.Copy(a, 0, c, 1, 3);          // 배열 복사 방법 2
            printArray(c);

            a.CopyTo(c, 3);                     // 배열 복사 방법 3
            printArray(c);

            Array.Sort(a);                      // 오름차순으로 정렬
            printArray(a);

            Array.Reverse(a);                   // 내림차순으로 정렬
            printArray(a);

            Array.Clear(a,0, a.Length);         // 배열을 초기화
            printArray(a);
        }
        private static void printArray(int[] a)
        {
            foreach(var i in a)
                Console.Write("{0,5}",i);
            Console.WriteLine();
        }
    }
}
