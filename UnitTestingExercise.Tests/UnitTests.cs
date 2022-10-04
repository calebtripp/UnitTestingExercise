//using UnitTestingExercise;
using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)]
        [InlineData(-1, 0, 3, 2)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            var test = new Calculator();

            var actual = test.Add(num1, num2, num3);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, 2, 3)]
        [InlineData(5, -1, 6)]
        public void SubtractTest(int minuend, int subtrahend, int expected)
        {
            var test = new Calculator();

            var actual = test.Subtract(minuend, subtrahend);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2, 3, 6)]
        [InlineData(-1, 3, -3)]
        public void MultiplyTest(int mult1, int mult2, int expected)
        {
            var test = new Calculator();

            var actual = test.Multiply(mult1, mult2);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, 2, 5)]
        [InlineData(21, 7, 3)]
        public void DivideTest(int div1, int div2, int expected)
        {
            var test = new Calculator();

            var actual = test.Divide(div1, div2);

            Assert.Equal(expected, actual);
        }
    }
}
