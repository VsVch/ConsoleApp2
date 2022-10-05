using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {

            int chas = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());

            int minutes = chas * 60 + min + 15;

            chas = minutes / 60;
            if (chas==24)

            {
                chas = 0;
            }
            min = minutes % 60;

            if (min < 10)
            {
                Console.WriteLine($"{chas}:0{min}");
            }
            else

            {
                Console.WriteLine($"{chas}:{min}");
            }




        }
    }
}
