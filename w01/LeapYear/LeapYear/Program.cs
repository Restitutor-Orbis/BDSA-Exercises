using System;

namespace LeapYear
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Type in a year to see if it is a leap year:");

            int answer = 0;

            while(answer == 0) {
                try 
                {
                answer = Convert.ToInt32(Console.ReadLine());
                }
                catch(System.FormatException e) 
                {
                    Console.WriteLine("Please type in an integer");
                    throw e;
                }
            }

            if(isLeapYear(answer)) Console.WriteLine("yay");
            else                   Console.WriteLine("nay");

            if(answer < 1582)      Console.WriteLine("(years before 1582 cannot be leap years)"); //should be added to isLeapYear(), but too lazy
        }
        public static bool isLeapYear(int year) 
        {
            if(1582 < year) 
                if(year % 100 == 0) 
                    if(year % 400 == 0) return true;
                    else                return false;
                else return year % 4 == 0;
            else return false;
        } 
    }
}
