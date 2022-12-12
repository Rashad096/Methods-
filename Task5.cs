using System;

namespace Task5__HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Verilmiş 4 ədədin ortalamasını tapıb qaytaran metod
            Console.WriteLine("Birinci eded:");
            var input = Console.ReadLine();
            double a = Convert.ToInt32(input);

            Console.WriteLine("Ikinci eded:");
            var input2 = Console.ReadLine();
            double b = Convert.ToInt32(input2);

            Console.WriteLine("Ucuncu eded:");
            var input3 = Console.ReadLine();
            double c = Convert.ToInt32(input3);

            Console.WriteLine("Dorduncu eded:");
            var input4 = Console.ReadLine();
            double d = Convert.ToInt32(input4);

            double midresult = Mid(a,b,c,d);
            Console.WriteLine(midresult);
        }

        static double Mid(double num, double num2, double num3, double num4)
        {
           double result=(num+num2+num3+num4)/4;   
            return result;
        }


    }
}
