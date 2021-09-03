using System;

namespace LeapYear
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Type in a year to see if it is a leap year:");

            int answer = Convert.ToInt32(Console.ReadLine());

            if(isLeapYear(answer)) Console.WriteLine("yay");
            else                   Console.WriteLine("nay");
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
