﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            int sum = first + second + third;
            int min = sum / 60;
            int sec = sum % 60;



            if (sec >= 10)
            {
                Console.WriteLine($"{min}:{sec}");
            }

            else
            {
                Console.WriteLine($"{min}:0{sec}");
            }
        }
    }
}
