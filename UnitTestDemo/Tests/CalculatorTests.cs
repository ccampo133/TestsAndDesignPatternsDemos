using System;
using NUnit.Framework;
using UnitTestDemo.Lib;

namespace UnitTestDemo.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        // This test method shows how to test the state of an
        // object after it has been modified; in this case via
        // the Memory property's `set` accessor.
        [Test]
        public void TestMemory()
        { 
            // Arrange
            int memoryVal = 20;
            var calculator = new Calculator();

            // Act
            calculator.Memory = memoryVal;

            // Assert
            Assert.AreEqual(memoryVal, calculator.Memory);
        }

        [Test]
        public void TestAddition()
        {
            // Arrange
            int firstNumber = 2;
            int secondNumber = 2;
            var calculator = new Calculator();

            // Act
            int sum = calculator.Add(firstNumber, secondNumber);

            // Assert
            // The actual expected result is 4, as 2 + 2 = 4, not 5 
            // (unless our society has become Owellian by the time you
            // read this). The purpose of this is to demonstrate a
            // case where the actual production code may be OK, but
            // the test is buggy. Set the expectedSum = 4 to make this
            // test pass.
            int expectedSum = 5; //4
            Assert.AreEqual(expectedSum, sum);
        }

        [Test]
        public void TestMultiplication()
        {
            // Arrange
            int firstNumber = 10;
            int secondNumber = 3;
            var calculator = new Calculator();

            // Act
            int product = calculator.Multiply(firstNumber, secondNumber);

            // Assert
            int expectedProduct = 30;
            Assert.AreEqual(expectedProduct, product);
        }

        [Test]
        public void TestDivision()
        { 
            // Arrange
            int numerator = 100;
            int denominator = 5;
            var calculator = new Calculator();

            // Act
            int quotient = calculator.Divide(numerator, denominator);

            // Assert
            int expectedQuotient = 20;
            Assert.AreEqual(expectedQuotient, quotient);
        }

        // Cases where exceptions are expected (or unexpected) can
        // also be tested.
        [Test]
        public void TestDivideByZeroException()
        {
            // Arrange
            int numerator = 100;
            int denominator = 0;
            var calculator = new Calculator();

            // Act
            // Assert
            Assert.Throws<DivideByZeroException>(() => calculator.Divide(numerator, denominator));
        }

        [Test]
        public void TestExponentiation()
        {
            // Arrange
            double expBase = 10;
            double power = 2;
            var calculator = new Calculator();

            // Act
            double result = calculator.Power(expBase, power);

            // Assert
            double expectedResult = 100;
            Assert.AreEqual(expectedResult, result);
        }       

        [Test]
        public void TestLogarithmWithBase()
        {
            // Arrange
            double logBase = 2;
            double value = 256;
            var calculator = new Calculator();

            // Act
            double result = calculator.Log(value, logBase);

            // Assert
            double expectedResult = 8;
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void TestLogarithmWithoutBase()
        {
            // Arrange
            double value = Math.E;
            var calculator = new Calculator();

            // Act
            double result = calculator.Log(value);

            // Assert
            double expectedResult = 1;
            Assert.AreEqual(expectedResult, result);
        }
    }
}
