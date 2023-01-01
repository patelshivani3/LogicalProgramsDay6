using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramsDay6
{
    internal class ReverseNumber
    {
        public static void Number()
        {
            int rem = 0, rev = 0;
            Console.WriteLine("Enter a Number to make it reverse : ");
            int number = Convert.ToInt32(Console.ReadLine());
            while (number != 0)
            {
                rem = number % 10;
                rev = rev * 10 + rem;
                number = number / 10;
            }
            Console.WriteLine("Reverse of number is : {0}.", rev);
        }
    }
}
