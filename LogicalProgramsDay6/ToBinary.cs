using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramsDay6
{
    internal class ToBinary
    {
        public static int[] binary = new int[8];
        public static void GetBinary()
        {
            Console.WriteLine("Enter a Decimal Number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; num > 0; i++)
            {
                binary[i] = num % 2;
                num =num/2;
            }
            for (int i = binary.Length - 1; i >= 0; i--)
            {
                Console.Write(binary[i] + " ");
            }
        }
    }
}
