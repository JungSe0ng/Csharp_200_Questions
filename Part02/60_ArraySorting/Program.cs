using System;

namespace _60_ArraySorting
{
    // 이름을 배열에 저장하고 알파벳 순으로 정렬
    class Program
    {
        static void Main(string[] args)
        {
            string[] name = { "Mouse", "Cow", "Tiger", "Rabiit", "Dragon", "Snake", "Horse" };
            PrintArray("Before Sort : ", name);

            Array.Reverse(name);
            PrintArray("After Reverse : ", name);

            Array.Sort(name);
            PrintArray("After Sort : ", name);

            Array.Reverse(name);
            PrintArray("After Reverse : ", name);

        }
        private static void PrintArray(string s, string[] name)
        {
            Console.WriteLine(s);
            foreach (var n in name)
                Console.Write("{0} ", n);
            Console.WriteLine();
        }
    }
}
