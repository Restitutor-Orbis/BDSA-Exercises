using System;

namespace LeapYear
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(":D");
        }

        public static bool isLeapYear(int year) 
        {
            return year % 4 == 0;
        } 
    }
}
