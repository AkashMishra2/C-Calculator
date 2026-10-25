using Xunit;
using CSharp;

namespace CSharp.Tests
{
    public class CalculatorTest
    {
        private readonly Calculator cal = new Calculator();


        // ADDITION
        [Fact]
        public void AddTwoPositives()
        {
            double number1 = cal.Addition(12, 36);
            Assert.Equal(48, number1);
        }

        [Fact]
        public void AddTwoNegatives()
        {
            double number2 = cal.Addition(-12, -36);
            Assert.Equal(-48, number2);
        }

        [Fact]
        public void AddOneNegativesAndOnePositive()
        {
            double number3 = cal.Addition(12, -36);
            Assert.Equal(-24, number3);
        }

        // SUBTRACTION

        [Fact]
        public void SubTwoPositives()
        {
            double number4 = cal.Subtraction(12, 36);
            Assert.Equal(-24, number4);
        }

        [Fact]
        public void SubTwoNegatives()
        {
            double number5 = cal.Subtraction(-12, -36);
            Assert.Equal(24, number5);
        }

        [Fact]
        public void SubOneNegativesAndOnePositive()
        {
            double number6 = cal.Subtraction(-12, 36);
            Assert.Equal(-48, number6);
        }

        // MULTIPLICATION

        [Fact]
        public void MultiplyTwoPositives()
        {
            double number7 = cal.Multiplication(10, 25);
            Assert.Equal(250, number7);
        }

        [Fact]
        public void MultiplyTwoNegatives()
        {
            double number8 = cal.Multiplication(-2, -6);
            Assert.Equal(12, number8);
        }

        [Fact]
        public void MultiplyOneNegativesAndOnePositive()
        {
            double number9 = cal.Multiplication(-1, 16);
            Assert.Equal(-16, number9);
        }

        // DIVISION

        [Fact]
        public void DivideTwoPositives()
        {
            double number10 = cal.Division(25, 5);
            Assert.Equal(5, number10);
        }

        [Fact]
        public void DivideTwoNegatives()
        {
            double number11 = cal.Division(-6, -3);
            Assert.Equal(2, number11);
        }

        [Fact]
        public void DivideOneNegativesAndOnePositive()
        {
            double number12 = cal.Division(-10, 2);
            Assert.Equal(-5, number12);
        }

        [Fact]
        public void DivideFloatingPoint()
        {
            double number13 = cal.Division(105, 2);
            Assert.Equal(52.5, number13);
        }

        [Fact]
        public void DivideFloatingNegativePoint()
        {
            double number14 = cal.Division(-105, 2);
            Assert.Equal(-52.5, number14);
        }

        // ADDING MULTIPLE NUMBERS

        [Fact]
        public void AdditionNumbers()
        {
            double number15 = cal.AddMultipleNumbers(20, 62, 36, 96, 2, 41);
            Assert.Equal(257, number15);

        }

        [Fact]
        public void AdditionNumbersPosAndNeg()
        {
            double number16 = cal.AddMultipleNumbers(20, -62, 36, -96, 2, 41);
            Assert.Equal(-59, number16);

        }

        // MULTIPLYING MULTIPLE NUMBERS

        [Fact]
        public void MultiplyingNumbers()
        {
            double number17 = cal.MultiplyMultipleNumbers(12, 3, 5, 6, 8);
            Assert.Equal(8640, number17);
            
        }

        [Fact]
        public void MultiplyingNumbersPosAndNeg()
        {
            double number18 = cal.MultiplyMultipleNumbers(12, -3, -5, -6, 8);
            Assert.Equal(-8640, number18);

        }

        [Fact]
        public void MultiplyingFloatNumbersPosAndNeg()
        {
            double number19 = cal.MultiplyMultipleNumbers(12, -3.5, -5.3, -6, 8);
            Assert.Equal(-10684.8, number19, 8);

        }

    }
}

