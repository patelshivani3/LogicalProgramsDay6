using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramsDay6
{
    internal class CouponNumber
    {
        public static void Number()
        {
            int i = 0, count = 0;
            Console.Write("\nEnter the number of distinct coupons:");
            int coupon = Convert.ToInt32(Console.ReadLine());
            bool[] is_collected = new bool[coupon];
            while (i < coupon)
            {
                Random random = new Random();
                int option = random.Next(1, 100);
                int coupon1 = (int)(random.NextDouble() * coupon);
                count++;
                if (!is_collected[coupon1])
                {
                    i++;
                    is_collected[coupon1] = true;
                }
            }
            Console.WriteLine("Total random number needed to have all distinct coupons : " + count);
        }
        
       
    }
}
