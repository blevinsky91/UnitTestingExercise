using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object

            var instObj = new Calculator();


            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual

            var actual = instObj.Add();

            //Assert
            //Assert.Equal(expected, actual);

            Assert.Equal(10, actual);
        }

        [Theory]
        [InlineData(20, 20)]//Add test data <-------
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange

            var instObj2 = new Calculator();

            //Act

            var actual = instObj2.Subtract();

            //Assert

            Assert.Equal(10, actual);
        }

        [Theory]
        [InlineData(10, 2)]//Add test data <-------
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange

            var instObj3 = new Calculator();

            //Act

            var actual = instObj3.Multiply();

            //Assert

            Assert.Equal(10, actual);
        }

        [Theory]
        [InlineData(20, 2)]//Add test data <-------
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange

            var instObj4 = new Calculator();

            //Act

            var actual = instObj4.Divide();

            //Assert

            Assert.Equal(10, actual);

        }

    }
}
