using NUnit.Framework;
using Practices;

namespace Practices.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator _calculator;

        [SetUp]
        public void SetUp()
        {
            _calculator = new Calculator();
        }

        [Test]
        public void Additional_ValidInputs_ReturnsSum()
        {
            // Arrange
            int a = 5;
            int b = 3;

            // Act
            int result = _calculator.Additional(a, b);

            // Assert
            Assert.AreEqual(8, result);
        }

        [Test]
        public void Subtraction_ValidInputs_ReturnsDifference()
        {
            // Arrange
            int a = 5;
            int b = 3;

            // Act
            int result = _calculator.Subtraction(a, b);

            // Assert
            Assert.AreEqual(2, result);
        }

        [Test]
        public void Miltiplication_ValidInputs_ReturnsProduct()
        {
            // Arrange
            int a = 5;
            int b = 3;

            // Act
            int result = _calculator.Miltiplication(a, b);

            // Assert
            Assert.AreEqual(15, result);
        }

        [Test]
        public void Division_ValidInputs_ReturnsQuotient()
        {
            // Arrange
            int a = 6;
            int b = 3;

            // Act
            int result = _calculator.Division(a, b);

            // Assert
            Assert.AreEqual(2, result);
        }

        [Test]
        public void Division_ByZero_ThrowsDivideByZeroException()
        {
            // Arrange
            int a = 5;
            int b = 0;

            // Act & Assert
            Assert.Throws<System.DivideByZeroException>(() => _calculator.Division(a, b));
        }
    }
}
