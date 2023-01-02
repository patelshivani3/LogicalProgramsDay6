using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramsDay6
{
    internal class DayOfWeek
    {
        public static void Days()
        {
            int d0, m0, y0, x;
            Console.Write("Enter Date from 1 to 31 : ");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Month from 1 to 12 : ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Year (YYYY) : ");
            int year = Convert.ToInt32(Console.ReadLine());

            if (day > 0 && day <= 31 && month > 0 && month <= 12 && year > 0)
            {
                y0 = year - (14 - month) / 12;
                x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
                m0 = month + 12 * ((14 - month) / 12) - 2;
                d0 = (day + x + 31 * m0 / 12) % 7;

                Console.WriteLine("Day of Week is : " + d0);
                switch (d0)
                {
                    case 0:
                        Console.WriteLine("Sunday");
                        break;
                    case 1:
                        Console.WriteLine("Monday");
                        break;
                    case 2:
                        Console.WriteLine("Tuesday");
                        break;
                    case 3:
                        Console.WriteLine("Wednesday");
                        break;
                    case 4:
                        Console.WriteLine("Thrusday");
                        break;
                    case 5:
                        Console.WriteLine("Friday");
                        break;
                    case 6:
                        Console.WriteLine("Saturday");
                        break;
                    case 7:
                        Console.WriteLine("Please Enter Correct Date.");
                        break;
                }
            }

        }
    }
}
