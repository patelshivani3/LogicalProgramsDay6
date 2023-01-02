using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramsDay6
{
    internal class TemperatureConversion
    {
        public static void TempConvert()
        {
            // Celsius to Fahrenheit
            Console.WriteLine("Enter a temprature in Celsius  : ");
            float Celsius = Convert.ToInt32(Console.ReadLine());
            float celToFahren = ((Celsius * 9 / 5) + 32);
            Console.WriteLine("temp in fahrenheit :" + celToFahren);
            // Fahrenheit to Celsius
            Console.WriteLine("Enter a temprature in Fahrenheit : ");
            float Fahrenheit = Convert.ToSingle(Console.ReadLine());
            float fahToCelsius = (Fahrenheit - 32) * (5 / (float)9);
            Console.WriteLine("temp in Celsius :" + fahToCelsius);

        }
    }
}
