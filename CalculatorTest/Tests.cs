using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace CalculatorTest
{
    [TestClass]
    public class CalculatorTest
    {
        //Addition
        [TestMethod]
        public void ShouldReturnFiveWhenPassTwoAndThree()
        {
            Calculator.Calculator cl = new Calculator.Calculator();
            int result = cl.Add(2, 3);
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void ShouldReturnOneWhenPassMinusTwoAndThree()
        {
            Calculator.Calculator cl = new Calculator.Calculator();
            int result = cl.Add(-2, 3);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void ShouldReturnIntegerFiveWhenPassIntegerNumbers()
        {
            Calculator.Calculator cl = new Calculator.Calculator();

            var result = cl.Add(2, 3);
            Assert.IsInstanceOfType(result,typeof(int));
        }

        //Multiplication
        [TestMethod]
        public void ShouldReturnSixWhenPassTwoAndThree()
        {
            Calculator.Calculator cl = new Calculator.Calculator();

            int result = cl.Mul(2, 3);
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void ShouldReturnMinusSixWhenPassTwoAndMinusThree()
        {
            Calculator.Calculator cl = new Calculator.Calculator();

            int result = cl.Mul(2, -3);
            Assert.AreEqual(-6, result);
        }

        [TestMethod]
        public void ShouldReturnSixWhenPassMinusTwoAndMinusThree()
        {
            Calculator.Calculator cl = new Calculator.Calculator();

            int result = cl.Mul(-2, -3);
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void ShouldReturnZeroWhenPassMinusTwoAndZero()
        {
            Calculator.Calculator cl = new Calculator.Calculator();

            int result = cl.Mul(-2, 0);
            Assert.AreEqual(0, result);
        }

        //Division
        [TestMethod]
        public void ShouldReturnTwoWhenPassTenAndFive()
        {
            Calculator.Calculator cl = new Calculator.Calculator();
            int result = cl.Div(10, 5);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void ShouldReturnTwoWhenPassNineAndFour()
        {
            Calculator.Calculator cl = new Calculator.Calculator();
            int result = cl.Div(9, 4);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void ShouldGetAnExceptionWhenPassTenAndZero()
        {
            Calculator.Calculator cl = new Calculator.Calculator();
            try
            {
                int result = cl.Div(10, 0);
            }
            catch(DivideByZeroException ex)
            {
                StringAssert.Contains(ex.Message, "Division by zero is not hadled by the system.");
            }
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException),
        "Division by zero exception.")]
        public void ShouldThrowAnExceptionWhenPassTenAndZero()
        {
            Calculator.Calculator cl = new Calculator.Calculator();
            int result = cl.DivByZero(10, 0);
        }

        //Substraction
        [TestMethod]
        public void ShouldReturnFiveOneWhenPassTwoAndMinusThree()
        {
            Calculator.Calculator cl = new Calculator.Calculator();

            int result = cl.Sub(2, -3);
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void ShouldReturnMinusFiveOneWhenPassMinusTwoAndThree()
        {
            Calculator.Calculator cl = new Calculator.Calculator();

            int result = cl.Sub(-2, 3);
            Assert.AreEqual(-5, result);
        }

        //Exponential
        [TestMethod]
        public void ShouldReturnSixtyFourOneWhenPassTwoAndSix()
        {
            Calculator.Calculator cl = new Calculator.Calculator();

            int result = cl.Exp1(2, 6);
            Assert.AreEqual(64, result);
        }

        [TestMethod]
        public void ShouldReturnOneWhenPassTwoAndZero()
        {
            Calculator.Calculator cl = new Calculator.Calculator();

            int result = cl.Exp2(2, 0);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
         "The first argument cannot be null.")]
        public void ShouldThrowAnExceptionWhenPassZeroAndTen()
        {
            Calculator.Calculator cl = new Calculator.Calculator();
            int result = cl.Exp3(0, 10);
        }
    }
}
