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

            int first = 1600;
            int second = 1604;
            int third  = 2020;

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
            int second = 1615;
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
            int second = 1700;
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

            int first = 1600;
            int second = 2000;
            int third  = 3200;

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
        
        [Fact]
        public void LeapYear_userInput_identifyTrue() {
            //Arrange
            string year = "2000";
            string expected = "yay";
            string actual;

            var reader = new StringReader(year);
            var writer = new StringWriter();
            Console.SetIn(reader);
            Console.SetOut(writer);

            //Act
            Program.Main(new string[0]);
        
            actual = writer.GetStringBuilder().ToString().Trim();

            //Assert
            Assert.Contains(expected, actual);
        }


        //Error handling

        [Fact]
        public void LeapYear_0_returnFalse() {
            //Arrange
            bool expected = false;
            bool actual;
            int year = 0;

            //Act
            actual = Program.isLeapYear(year);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void LeapYear_negativeValue_returnFalse() {
            //Arrange
            bool expected = false;
            bool actual;
            int year = -1;

            //Act
            actual = Program.isLeapYear(year);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void LeapYear_nonInteger_returnFalse() {
            //Arrange
            bool expected = false;
            bool actual;
            double year = 21.321321312;

            //Act
            actual = Program.isLeapYear((int) year);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void LeapYear_nonInteger_userInput_catchFormatException() {
            //Arrange
            string year = "32.324314352";

            FormatException expected = new System.FormatException();

            var reader = new StringReader(year);
            var writer = new StringWriter();
            Console.SetIn(reader);
            Console.SetOut(writer);

            //Act & Assert
            try 
            {
                Program.Main(new string[0]);

                Assert.True(false); //if no exception is thrown, test fails
            }
            catch(Exception e) 
            {
                if(e.GetType().Equals(expected.GetType())) Assert.True(true);
                else                                       Assert.True(false);
            }
        }

        [Fact]
        public void LeapYear_nonValue_userInput_catchFormatException() {
            //Arrange
            string year = "jeg er ikke et heltal";

            FormatException expected = new System.FormatException();

            var reader = new StringReader(year);
            var writer = new StringWriter();
            Console.SetIn(reader);
            Console.SetOut(writer);

            //Act & Assert
            try 
            {
                Program.Main(new string[0]);

                Assert.True(false); //if no exception is thrown, test fails
            }
            catch(Exception e) 
            {
                if(e.GetType().Equals(expected.GetType())) Assert.True(true);
                else                                       Assert.True(false);
            }
        }
    }
}
