using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramsDay6
{
    internal class PerfectNumber
    {
        public static void Number()
        {
            int sum = 0 , i = 1;
            Console.WriteLine("Enter the Number to check perfect Number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            while (i < num)
            {
                if (num % i == 0)
                {
                    sum += i;
                    Console.Write(" " + i);
                }
                i++;
            }
            Console.WriteLine("\nSum of factors :" + sum);
            if (sum == num)
            {
                Console.WriteLine("{0} is a Perfect Number", num);
            }
            else
            {
                Console.WriteLine("{0} is not a Perfect Number", num);
            }
        }
    }
}
