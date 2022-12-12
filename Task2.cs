using System;
using System.Xml.Schema;

namespace Task2__HomeWork_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Verilmiş ədədin kvadratını qaytaran metod
            Console.WriteLine("Ededi daxil edin: ");
            string input = Console.ReadLine();
            int number=Convert.ToInt32(input);           
            var result=NumtoNum(number);
            Console.WriteLine(result);
        }


        static int NumtoNum(int num)
        {
            int total= num * num;
            return total;
        }
    }
}
