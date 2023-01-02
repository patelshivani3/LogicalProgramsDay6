using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramsDay6
{
    internal class StopWatch
    {
        public static void GetElapsedTime()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            FibonacciSeries fibonacciSeries = new FibonacciSeries();
            fibonacciSeries.Series();
            stopwatch.Stop();
            Console.WriteLine("\nElapsed time to get Fibonacci Series is:{0} Ms" , stopwatch.ElapsedMilliseconds);
        }
    }
}
