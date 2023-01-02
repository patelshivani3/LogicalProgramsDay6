using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramsDay6
{
    internal class MonthlyPayment
    {
        public static void GetPayment()
        {
            Console.WriteLine("Enter principal amount :");
            double P = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter year :");
            double Y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter rate of interest:");
            double R = Convert.ToDouble(Console.ReadLine());

            double n = 12 * Y;
            double r = R / (12 * 100);

            double payment = (P * r) / (1 - Math.Pow((1 + r), -n));
            Console.WriteLine("Monthly payment is : " + payment);

        }
    }
}
