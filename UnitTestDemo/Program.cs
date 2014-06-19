using System;
using UnitTestDemo.Lib;

namespace UnitTestDemo
{
    static class Program
    {
        /*
         * This demo is designed to illustrate the concept of unit
         * testing. The main program demonstrates a simple calculator
         * class and some of its various use cases. The Lib directory
         * contains the code for the calculator class, and the Tests
         * directory contains the unit tests for the calculator class.
         * In an actual production scenario, you will want to make
         * the unit tests themselves a separate assembly (.dll) in 
         * the solution, so they can be built and packaged separate 
         * from the main application they are testing. The tests are
         * included in this assembly for simplicity's sake.
         * 
         * The tests methods for addition, multiplication, and
         * exponentiation are intentionally written to fail. The
         * addition test fails due to an errorin the test itself, 
         * while the multiplication and exponentiation tests fail due 
         * to bugs in the calculator "production" code itself.
         * 
         */
        static void Main(string[] args)
        {
            var calculator = new Calculator();

            // Set memory
            calculator.Memory = 12;
            Console.WriteLine("Calculator memory = " + calculator.Memory);

            // Do addition
            int firstNumber = 10;
            int secondNumber = 20;
            int sum = calculator.Add(firstNumber, secondNumber);
            Console.WriteLine(String.Format("Sum of {0} plus {1} = {2}", firstNumber, secondNumber, sum));

            // Do multiplication
            int product = calculator.Multiply(firstNumber, secondNumber);
            Console.WriteLine(String.Format("Product of {0} times {1} = {2}", firstNumber, secondNumber, product));

            // Do division
            int numerator = 4;
            int denominator = 2;
            int quotient = calculator.Divide(numerator, denominator);
            Console.WriteLine(String.Format("Quotient of {0} divided by {1} = {2}", numerator, denominator, quotient));

            // Do exponentiation
            double baseNumber = 2;
            double power = 8;
            double exponent = calculator.Power(baseNumber, power);
            Console.WriteLine(String.Format("Value of {0} to the power {1} = {2}", baseNumber, power, exponent));

            // Take the logarithm
            double logarithm = calculator.Log(power, exponent);
            Console.WriteLine(String.Format("Value of LOG base {0} of {1} = {2}", exponent, power, logarithm));

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
