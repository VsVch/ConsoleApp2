using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());

            double tc = 1 / (1 / a + 1 / b + 1 / c);
            double tcb = tc + tc * 15 / 100;

            double lt = tcb - d;
            double tost = Math.Floor(lt);
            double tnedo = Math.Ceiling(lt);
            double tof = Math.Abs(lt);
            tof = Math.Floor(tof);

            Console.WriteLine( "Cleaning time: {0:f2}" , tcb);




            if (lt < 0)
            {
               

                Console.WriteLine("Yes, there is a surprise - time left ->{0} hours.", tof  );
            }
            else
            {
                Console.WriteLine("No, there isn't a surprise - shortage of time ->" , tnedo    );
            }




                


        }
    }
}
