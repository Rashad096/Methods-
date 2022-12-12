using System;

namespace Task____HomeWork_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Verilmiş ədədin rəqəmlərin cəmini qaytaran metod
            Console.WriteLine();
            var input = Console.ReadLine();
            int number = Convert.ToInt32(input);
            int result = DigitSum(number);
            Console.WriteLine(result);  
        }

        static int DigitSum(int num)
        {
            int sum = 0;

            while (num != 0)
            {
                int lastnum = num % 10;
                sum += lastnum;
                num= (num - lastnum) / 10;
            }
            return sum; 
        }
    }
}
