using System;
using System.Collections;
using Xunit;

namespace LeapYear.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void LeapYear_divisibleBy4_true()
        {
            //Arrange
            bool expected = true;

            int first = 0;
            int second = 400;
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
    }
}
