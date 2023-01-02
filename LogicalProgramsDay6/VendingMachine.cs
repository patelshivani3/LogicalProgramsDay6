using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramsDay6
{
    internal class VendingMachine
    {
        
        //public static int[] notes = new int[] { 1000, 500, 100, 50, 10, 5, 2, 1 };
        //public static int quotient = 0;
        //public static int Count = 0;
        public static void GetNotes()
        {
            int[] notes = new int[] { 1000, 500, 100, 50, 10, 5, 2, 1 };
            int quotient = 0;
            int Count = 0;
            Console.WriteLine("Enter the amount to be returned by the Vending Machine :");
            int amount = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < notes.Length; i++)
            {
                if (amount >= notes[i])
                {
                    quotient = amount / notes[i];
                    amount = amount - (quotient * notes[i]); 
                    Console.WriteLine("{0}*{1}:{2}", notes[i], quotient, notes[i] * quotient); 
                    Count = Count + quotient;
                }
            }
            Console.WriteLine("Minimum number of notes : " + Count);
        }
    }
}