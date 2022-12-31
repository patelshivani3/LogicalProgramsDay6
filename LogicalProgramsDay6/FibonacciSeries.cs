using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramsDay6
{
    internal class FibonacciSeries
    {
        public static void Series()
        {
            int a = 0, b = 1, c;
            Console.WriteLine("Enter a number : ");
            int count = Convert.ToInt32(Console.ReadLine());
            Console.Write(a + "," + b);
            for (int i = 2; i <= count; i++)
            {
                c = a + b;
                Console.Write("," + c);
                a = b;
                b = c;
            }
        }
    }
}
