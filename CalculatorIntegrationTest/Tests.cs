using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace CalculatorIntegrationTest
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void IntegrationTestOne()
        {
            Calculator.Calculator cl = new Calculator.Calculator();

            int result = cl.Add(2, cl.Exp1(2, cl.Div(10, 2)));
            Assert.AreEqual(34, result);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException),
        "Division by zero exception.")]
        public void IntegrationTestTwo()
        {
            Calculator.Calculator cl = new Calculator.Calculator();

            int result = cl.Add(2, cl.Exp1(2, cl.Div(10, cl.DivByZero(2,0))));
            Assert.AreEqual(34, result);
        }

        [TestMethod]
        [ExpectedException(typeof(OverflowException),
        "Overflow exception.")]
        public void IntegrationTestThree()
        {
            Calculator.Calculator cl = new Calculator.Calculator();
            int result = cl.Exp1(10, cl.Add(6, cl.Div(12, 2)));
            Assert.AreEqual(34, result);
        }

        //shoudl fail because exp1 implementation is wrong
        [TestMethod]
        public void IntegrationTestFour()
        {
            Calculator.Calculator cl = new Calculator.Calculator();

            int result = cl.Add(2, cl.Exp1(2, cl.Div(0, cl.DivByZero(2, 2))));
            Assert.AreEqual(3, result);
        }


        [TestMethod]
        public void IntegrationTestFive()
        {
            Calculator.Calculator cl = new Calculator.Calculator();

            int result = cl.Add(2, cl.Exp2(2, cl.Div(0, cl.DivByZero(2, 2))));
            Assert.AreEqual(3, result);
        }
    }
}
