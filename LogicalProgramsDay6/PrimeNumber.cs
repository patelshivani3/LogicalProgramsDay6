using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramsDay6
{
    internal class PrimeNumber
    {
        public static void Number()
        {

            int num = 1;
            Console.WriteLine("Enter a number to check Prime : ");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    num = 0;
                }
            }
            if (num == 1)
            {
                Console.WriteLine("It is a Prime Number");
            }
            else
            {
                Console.WriteLine("It is not a Prime Number");
            }
        }
    }
}
