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
            if(year % 100 == 0) 
                if(year % 400 == 0) return true;
                else                return false;
            else return year % 4 == 0;
        } 
    }
}
