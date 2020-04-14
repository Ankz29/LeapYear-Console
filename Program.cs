using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYearConsole
{
   static class Program
    {
      public  static void Main(string[] args)
        {
            Console.WriteLine("Enter the Year.. !! ");
            int Year = Convert.ToInt32(Console.ReadLine());
            Program.LeapYear(Year);        
        }
        public static void LeapYear(int LeapYr)
        {
            if (LeapYr > 999)
            {
                if ((LeapYr % 4) == 0)
                {
                    Console.WriteLine(LeapYr + " is a leap Year..");
                }
                else
                {
                    Console.WriteLine(LeapYr + " is not a leap year...");
                }
            }
            else
            {
                Console.WriteLine("Enter digit greater than 999.");
            }
            Console.ReadKey();
        }
    }
}
