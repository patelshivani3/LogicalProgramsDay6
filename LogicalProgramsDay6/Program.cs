﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramsDay6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nWelcome to Logical Programs.");
            Console.WriteLine("\n1.Fibonacci Series\n2.Perfect Number\n3.Prime Number");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    FibonacciSeries.Series();
                    break;

                case 2:
                    PerfectNumber.Number();
                    break;

                case 3:
                    PrimeNumber.Number();
                    break;  
                default:
                    Console.WriteLine("Choose from above options only.");
                    break;
            }
            Console.ReadLine();
        }
    }
}
