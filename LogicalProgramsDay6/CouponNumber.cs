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
            int coupon;
            Console.WriteLine("Enter a Number of Coupons : ");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                coupon = RandomNum();
                Console.WriteLine(coupon);
            }
        }
        public static int RandomNum()
        {
            Random random = new Random();
            random.Next();
            return random.Next();
        }
    }
}
