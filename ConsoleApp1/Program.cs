using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            double chislo = double.Parse(Console.ReadLine());
            double b1 = 0;
            double b2 = 0;
            if (chislo % 2 == 0)
            {
                b1 = 1;
            }
            else if (chislo % 5 == 0)
            {
                b1 = 2;
            }
            else
            {
                b1 = 0;
            }


            if (chislo <= 100)
            {
                b2 = 5;
            }
            else if (chislo >= 1000)
            {
                b2 = chislo * 1 / 10;
            }
            else
            {
                b2 = chislo * 2 / 10;
            }
            Console.WriteLine($"{ b1 + b2}:f2");
            Console.WriteLine($"{b1+b2+chislo}:f2");

        }
    }
}
