using System;
namespace UnitTestingExercise
{
    public class Calculator
    {
        public int Add(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }

        public int Subtract(int minuend, int subtrahend)
        {
            return minuend - subtrahend;
        }

        public int Multiply(int mult1, int mult2)
        {
            return mult1 * mult2;
        }

        public int Divide(int div1, int div2)
        {
            return div1 / div2;
        }
    }
}
