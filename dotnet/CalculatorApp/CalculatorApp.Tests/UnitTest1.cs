using System;
using Xunit;

namespace CalculatorApp.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void Add_ReturnsCorrectResult()
        {
            // Arrange
            double firstNumber = 2;
            double secondNumber = 3;

            // Act
            double result = Calculator.Add(firstNumber, secondNumber);

            // Assert
            Assert.Equal(5, result);
        }

        [Fact]
        public void Subtract_ReturnsCorrectResult()
        {
            // Arrange
            double firstNumber = 5;
            double secondNumber = 3;

            // Act
            double result = Calculator.Subtract(firstNumber, secondNumber);

            // Assert
            Assert.Equal(2, result);
        }

        [Fact]
        public void Multiply_ReturnsCorrectResult()
        {
            // Arrange
            double firstNumber = 2;
            double secondNumber = 3;

            // Act
            double result = Calculator.Multiply(firstNumber, secondNumber);

            // Assert
            Assert.Equal(6, result);
        }

        [Fact]
        public void Divide_ReturnsCorrectResult()
        {
            // Arrange
            double firstNumber = 6;
            double secondNumber = 3;

            // Act
            double result = Calculator.Divide(firstNumber, secondNumber);

            // Assert
            Assert.Equal(2, result);
        }

        [Fact]
        public void Divide_ByZeroThrowsArgumentException()
        {
            // Arrange
            double firstNumber = 6;
            double secondNumber = 0;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => Calculator.Divide(firstNumber, secondNumber));
        }

        [Fact]
        public void PerformOperation_Add_ReturnsCorrectResult()
        {
            // Arrange
            double firstNumber = 2;
            double secondNumber = 3;
            string operation = "+";

            // Act
            double result = Calculator.PerformOperation(firstNumber, secondNumber, operation);

            // Assert
            Assert.Equal(5, result);
        }

        [Fact]
        public void PerformOperation_Subtract_ReturnsCorrectResult()
        {
            // Arrange
            double firstNumber = 5;
            double secondNumber = 3;
            string operation = "-";

            // Act
            double result = Calculator.PerformOperation(firstNumber, secondNumber, operation);

            // Assert
            Assert.Equal(2, result);
        }

        [Fact]
        public void PerformOperation_Multiply_ReturnsCorrectResult()
        {
            // Arrange
            double firstNumber = 2;
            double secondNumber = 3;
            string operation = "*";

            // Act
            double result = Calculator.PerformOperation(firstNumber, secondNumber, operation);

            // Assert
            Assert.Equal(6, result);
        }

        [Fact]
        public void PerformOperation_Divide_ReturnsCorrectResult()
        {
            // Arrange
            double firstNumber = 6;
            double secondNumber = 3;
            string operation = "/";

            // Act
            double result = Calculator.PerformOperation(firstNumber, secondNumber, operation);

            // Assert
            Assert.Equal(2, result);
        }

        [Fact]
        public void PerformOperation_UnknownOperationThrowsArgumentException()
        {
            // Arrange
            double firstNumber = 6;
            double secondNumber = 3;
            string operation = "%";

            // Act & Assert
            Assert.Throws<ArgumentException>(() => Calculator.PerformOperation(firstNumber, secondNumber, operation));
        }

        [Fact]
        public void PerformOperation_DivideByZeroThrowsArgumentException()
        {
            // Arrange
            double firstNumber = 6;
            double secondNumber = 0;
            string operation = "/";

            // Act & Assert
            Assert.Throws<ArgumentException>(() => Calculator.PerformOperation(firstNumber, secondNumber, operation));
        }

        [Fact]
        public void Power_ReturnsCorrectResult()
        {
            // Arrange
            double firstNumber = 2;
            double secondNumber = 3;

            // Act
            double result = Calculator.Power(firstNumber, secondNumber);

            // Assert
            Assert.Equal(8, result);
        }

        [Fact]
        public void SquareRoot_ReturnsCorrectResult()
        {
            // Arrange
            double number = 9;

            // Act
            double result = Calculator.SquareRoot(number);

            // Assert
            Assert.Equal(3, result);
        }

        [Fact]
        public void SquareRoot_ThrowsExceptionForNegativeNumber()
        {
            // Arrange
            double number = -1;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => Calculator.SquareRoot(number));
        }
    }
}