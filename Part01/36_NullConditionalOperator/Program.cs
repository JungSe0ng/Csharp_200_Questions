﻿using System;

namespace _36_NullConditionalOperator
{
    // Null 조건 연산자(?)
    class Program
    {
        static void Main(string[] args)
        {
            string animal = null;

            Console.WriteLine("4글자 이상인 동물의 이름만 출력합니다.");
            do
            {
                LongNameAnimal(animal);
                Console.Write("동물 이름 :");
            }
            while((animal = Console.ReadLine()) != "");
        }
        private static void LongNameAnimal(string animal) 
        {
            if(animal?.Length >= 4)
                Console.WriteLine(animal + " : "+ animal.Length);
        }
    }
}
