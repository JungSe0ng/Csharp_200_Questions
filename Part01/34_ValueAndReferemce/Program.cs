using System;
using System.Net.WebSockets;
using System.Security.Cryptography.X509Certificates;

namespace _34_ValueAndReferemce
{
    // 값 형식과 참조형식, ref 키워드
    class Program
    {
        static void Main(string[] args)
        {
            string s = "before passing";
            Console.WriteLine(s);
            
            Test(s);
            Console.WriteLine(s);
            
            Test(ref s);
            Console.WriteLine(s);

        }
        public static void Test(string s)
        {
            s = "after passing";
        }
        public static void Test(ref string s)
        {
            s = "after passing";
        }
    }
}
