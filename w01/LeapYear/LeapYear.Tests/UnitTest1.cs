using System;
using System.IO;
using System.Collections;
using Xunit;

namespace LeapYear.Tests
{
    public class UnitTest1
    {
        //First rule (divisible by 4)
        [Fact]
        public void LeapYear_divisibleBy4_true()
        {
            //Arrange
            bool expected = true;

            int first = 4;
            int second = 404;
            int third  = 1604;

            //Act
            ArrayList yearList = new ArrayList();
            yearList.Add(first);
            yearList.Add(second);
            yearList.Add(third);

            //Assert
            foreach(int year in yearList) 
            {
                bool actual = Program.isLeapYear(year);
                Assert.Equal(expected, actual);
            }
        }
        [Fact]
        public void LeapYear_divisibleByOther_false()
        {
            //Arrange
            bool expected = false;

            int first = 3;
            int second = 150;
            int third  = 2021;

            //Act
            ArrayList yearList = new ArrayList();
            yearList.Add(first);
            yearList.Add(second);
            yearList.Add(third);

            //Assert
            foreach(int year in yearList) 
            {
                bool actual = Program.isLeapYear(year);
                Assert.Equal(expected, actual);
            }
        }

        //Second rule (except for years divisible by 100)

        [Fact]
        public void LeapYear_divisibleBy100_false() {
            //Arrange
            bool expected = false;

            int first = 100;
            int second = 500;
            int third  = 2100;

            //Act
            ArrayList yearList = new ArrayList();
            yearList.Add(first);
            yearList.Add(second);
            yearList.Add(third);

            //Assert
            foreach(int year in yearList) 
            {
                bool actual = Program.isLeapYear(year);
                Assert.Equal(expected, actual);
            }
        }

        //Third rule (years divisible by 400 are leap years)

        [Fact]
        public void LeapYear_divisibleBy400_true() {
            //Arrange
            bool expected = true;

            int first = 400;
            int second = 800;
            int third  = 2000;

            //Act
            ArrayList yearList = new ArrayList();
            yearList.Add(first);
            yearList.Add(second);
            yearList.Add(third);

            //Assert
            foreach(int year in yearList) 
            {
                bool actual = Program.isLeapYear(year);
                Assert.Equal(expected, actual);
            }
        }

        //user input
        //find a way to simulate a user typing in terminal
        // OR give input and see if the output in terminal is correct.

        /*
        [Fact]
        public void LeapYear_userInput_correctlyIdentified() {
            //Arrange
            string expected = "yay";
            string actual;

            var writer = new StringWriter();
            Console.SetOut(writer);

            //Act
            Program.Main(new string[0]);

            Console.WriteLine(2000);
            actual = writer.GetStringBuilder().ToString().Trim();

            //Assert
            Assert.Equal(expected, actual);
        }
        */
        

    }
}
