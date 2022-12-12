using System;

namespace Task1_HomeWork_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Verilmiş iki ədədi toplayıb nəticəsini qaytaran metod
            Console.WriteLine(Sum());
        }

        static int GetNumber()
        {
            string number = Console.ReadLine();
            return Convert.ToInt32(number);
        }

        static int Sum()
        {
            Console.WriteLine("num1:");
            var num1 = GetNumber();

            Console.WriteLine("num2:");
            var num2 = GetNumber();

             int sum=num1+ num2;
            return sum; 


        }
    }
}
