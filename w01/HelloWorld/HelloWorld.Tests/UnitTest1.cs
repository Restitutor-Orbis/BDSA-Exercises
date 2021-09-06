using System;
using System.IO;
using Xunit;

namespace HelloWorld.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            var writer = new StringWriter();
            Console.SetOut(writer);

            string actual = "Hello, World!";

            // Act
            Program.Main(new string[0]);
            var output = writer.GetStringBuilder().ToString().Trim();

            // Assert
            Assert.Equal(actual, output);
        }
    }
}
