using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {

            double firstCap = double.Parse(Console.ReadLine());
            string firstMetric = Console.ReadLine();
            string secondMetric = Console.ReadLine();

            if (firstMetric == "m")
            {
                if (secondMetric == "cm")
                {
                    Console.WriteLine($"{firstCap * 100:f3}");

                }
                else if (secondMetric == "mm")
                {
                    Console.WriteLine($"{firstCap * 1000}");
                }


            }
            else if (firstMetric == "cm")
            {

                if (secondMetric == "mm")
                {
                    Console.WriteLine($"{firstCap * 100:f3}");
                }
                else if (firstMetric == "m")
                {
                    Console.WriteLine($"{firstCap / 100:f3}");
                }


            }
            else

            {

                if (secondMetric == "cm")
                {
                    Console.WriteLine($"{firstCap / 100:f3}");
                }
                else
                {
                    Console.WriteLine($"{firstCap/1000:f3}");
                }


            }














        }
    }
}
