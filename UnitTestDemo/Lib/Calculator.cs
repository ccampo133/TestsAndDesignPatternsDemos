using System;

namespace UnitTestDemo.Lib
{
    class Calculator
    {
        public int Memory { get; set; }

        // Adds two integers.
        public int Add(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        // Multiplies two integers. The code here is intentionally
        // incorrect, as it always adds a linear offset of 15 to the
        // product of the two numbers. This represents a runtime bug,
        // albeit a very obvious one!
        public int Multiply(int firstNumber, int secondNumber)
        {
            return (firstNumber * secondNumber) + 15;
            
            // Comment out the line above and uncomment the
            // line below fix this method's bug.
            //return firstNumber * secondNumber;
        }

        // Divides two integers.
        public int Divide(int numerator, int denominator)
        {
            return numerator / denominator;
        }

        // Raises a base double to a specified power. Again,
        // this method is intentionally incorrect, but in a
        // more subtle way than the Multiply method. Instead
        // of returning the value of `powerBase` to the power
        // `power`, it instead returns value of `power` to
        // the power `powerBase`. This bug is much more
        // more realistic, as it isn't immediately noticiable
        // yet will cause a proper test to fail immediately.
        public double Power(double powerBase, double power)
        {
            return Math.Pow(power, powerBase);

            // Comment out the line above and uncomment the
            // line below fix this method's bug.
            //return Math.Pow(powerBase, power);
        }

        // Takes the logarithm of a double. The default base is `e`,
        // but the base can be provided as an optional argument.
        public double Log(double value, double logBase = Math.E)
        {
            return Math.Log(value, logBase);
        }
    }
}
