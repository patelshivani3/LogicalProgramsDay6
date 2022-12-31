using System;
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
            Console.WriteLine("\n1.Fibonacci Series");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                // Fibonacci Series
                case 1:
                    FibonacciSeries.Series();
                    break;

                default:
                    Console.WriteLine("Choose from above options only.");
                    break;
            }
            Console.ReadLine();
        }
    }
}
