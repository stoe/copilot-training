// Get two numbers from the user and display the sum.

using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = 0;
            double secondNumber = 0;
            string? operation = null;

            // Get the first number from the user.
            while (true)
            {
                Console.Write("Enter a number: ");
                if (double.TryParse(Console.ReadLine(), out firstNumber))
                {
                    break;
                }
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }

            // Get the second number from the user.
            while (true)
            {
                Console.Write("Enter another number: ");
                if (double.TryParse(Console.ReadLine(), out secondNumber))
                {
                    break;
                }
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }

            // Get an operation from the user.
            while (true)
            {
                Console.Write("Enter an operation (+, -, *, /): ");
                operation = Console.ReadLine();
                if (operation == "+" || operation == "-" || operation == "*" || operation == "/")
                {
                    break;
                }
                Console.WriteLine("Invalid input. Please enter a valid operation.");
            }

            // Perform the operation.
            double result = Calculator.PerformOperation(firstNumber, secondNumber, operation);

            // Display the result.
            Console.WriteLine($"The result is {result}.");
        }
    }

    public static class Calculator
    {
        public static double PerformOperation(double firstNumber, double secondNumber, string operation)
        {
            switch (operation)
            {
                case "+":
                    return Add(firstNumber, secondNumber);
                case "-":
                    return Subtract(firstNumber, secondNumber);
                case "*":
                    return Multiply(firstNumber, secondNumber);
                case "/":
                    return Divide(firstNumber, secondNumber);
                default:
                    throw new ArgumentException("Unknown operation.");
            }
        }

        public static double Add(double firstNumber, double secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public static double Subtract(double firstNumber, double secondNumber)
        {
            return firstNumber - secondNumber;
        }

        public static double Multiply(double firstNumber, double secondNumber)
        {
            return firstNumber * secondNumber;
        }

        public static double Divide(double firstNumber, double secondNumber)
        {
            if (secondNumber == 0)
            {
                throw new ArgumentException("Invalid input. Cannot divide by zero.");
            }
            return firstNumber / secondNumber;
        }

        public static double Power(double firstNumber, double secondNumber)
        {
            double result = 1;
            for (int i = 0; i < secondNumber; i++)
            {
                result *= firstNumber;
            }
            return result;
        }

        public static double SquareRoot(double number)
        {
            if (number < 0)
            {
                throw new ArgumentException("Invalid input. Cannot calculate square root of a negative number.");
            }

            double guess = number / 2;
            double lastGuess = 0;

            while (guess != lastGuess)
            {
                lastGuess = guess;
                guess = (guess + number / guess) / 2;
            }

            return guess;
        }
    }
}