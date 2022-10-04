using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)]
        [InlineData(6, 2, 1, 9)]
        [InlineData(1, 9, 4, 14)]
        [InlineData(8, 9, 0, 17)]
        [InlineData(0, 0, 0, 0)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            var m = new Calculator();

            //Act
                // call the Add method that is located in the Calculator class
                // and store its result in a variable named actual
            var actual = m.Add(num1, num2, num3);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(6, 3, 3)]
        [InlineData(9, 1, 8)]
        [InlineData(2, 2, 0)]
        [InlineData(7, 10, -3)]
        [InlineData(0, 0, 0)]
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var m = new Calculator();
            //Act
            var actual = m.Subtract(minuend, subtrhend);
            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(2, 9, 18)]
        [InlineData(7, 3, 21)]
        [InlineData(5, 2, 10)]
        [InlineData(-7, 3, -21)]
        [InlineData(0, 0, 0)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var m = new Calculator();
            //Act
            var actual = m.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(18, 9, 2)]
        [InlineData(4, 2, 2)]
        [InlineData(12, 4, 3)]
        [InlineData(9, 3, 3)]
        [InlineData(0, 0, 0)]
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var m = new Calculator();
            //Act
            var actual = m.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
