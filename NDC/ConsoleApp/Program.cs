using Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sally is 54 years old and her mother is 80, 
            //how many years ago was Sally’s mother three times her age? 

            var sally = new Calculator.Calculator()
            { Amount = 54 };
            var mother = new Calculator.Calculator()
            { Amount = 80 };
            var years = new Calculator.Calculator()
            { Amount = 0 };

            while (mother.Amount / sally.Amount != 3)
            {
                mother.Subtract(1);
                sally.Subtract(1);
                years.Add(1);
            }

            Console.WriteLine($"{years.Amount} ago Sally's mother was three times her age. " +
                $"Sally was {sally.Amount} and her mother {mother.Amount}");

            Console.ReadKey();
        }

        int value1;
        int value3;
        int value4;
        int value5;
        int value2;
        int value6;
        string value7;

    }
}
