using NUnit.Framework;
using Assignment;

namespace Assignment.Tests
{
    public class CalculatorTests
    {
        [Test]
        public void Add_ReturnsCorrectResult()
        {
            var calc = new Calculator(5, 3, '+');
            Assert.That(calc.Calculate(), Is.EqualTo(8));
        }

        [Test]
        public void Subtract_ReturnsCorrectResult()
        {
            var calc = new Calculator(10, 4, '-');
            Assert.That(calc.Calculate(), Is.EqualTo(6));
        }

        [Test]
        public void Multiply_ReturnsCorrectResult()
        {
            var calc = new Calculator(6, 7, '*');
            Assert.That(calc.Calculate(), Is.EqualTo(42));
        }

        [Test]
        public void Divide_ReturnsCorrectResult()
        {
            var calc = new Calculator(20, 5, '/');
            Assert.That(calc.Calculate(), Is.EqualTo(4));
        }

        [Test]
        public void DivisionByZero_ThrowsException()
        {
            var calc = new Calculator(5, 0, '/');
            Assert.Throws<DivideByZeroException>(() => calc.Calculate());
        }

        [Test]
        public void InvalidOperator_ThrowsException()
        {
            var calc = new Calculator(5, 5, 'x');
            Assert.Throws<InvalidOperationException>(() => calc.Calculate());
        }
    }
}