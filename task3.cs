using System;
using System.Reflection.Metadata;

namespace Task_3__HomeWork_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Verilmiş string dəyərində a hərfinin olub olmadığını qaytaran metod
            Console.WriteLine("Sozu daxil et:");
            var word = Console.ReadLine();
            var result=HasA(word);
            Console.WriteLine(result);
        }
         static bool HasA(string word)
        {
            bool hasA = false;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i]=='a')
                {
                    hasA = true;
                    break;
                }
                else
                {
                    hasA= false;
                }

            }
            return hasA;    
            
        }
         
         
    }
}
