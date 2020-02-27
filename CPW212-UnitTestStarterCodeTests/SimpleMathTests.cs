using Microsoft.VisualStudio.TestTools.UnitTesting;
using CPW212_UnitTestStarterCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW212_UnitTestStarterCode.Tests
{
    [TestClass()]
    public class SimpleMathTests
    {
        [TestMethod()]
        [DataRow(5, 10)]
        [DataRow(0, 100)]
        [DataRow(-1, -10)]
        [DataRow(0, -0)]
        public void Add_TwoNumbers_ReturnsSum(double num1, double num2)
        {
            // Use the DataRow values to test the Add method
            double expectedValue = num1 + num2;
            double returnValue = SimpleMath.Add(num1, num2);

            Assert.AreEqual(expectedValue, returnValue);
        }

        [TestMethod]
        public void Multiply_TwoNumbers_ReturnsProduct()
        {
            double Test1Value1 = 12.3;
            double Test1Vaule2 = 2.0;
            double Test1ExpectedValue = Test1Value1 * Test1Vaule2;

            double Test2Value1 = 12.0;
            double Test2Vaule2 = 12.0;
            double Test2EexpectedValue = Test2Value1 * Test2Vaule2;

            double Test3Value1 = 25.5;
            double Test3Vaule2 = 100;
            double Test3EexpectedValue = Test3Value1 * Test3Vaule2;

            Assert.AreEqual(Test1ExpectedValue, SimpleMath.Multiply(Test1Value1, Test1Vaule2));
            Assert.AreEqual(Test2EexpectedValue, SimpleMath.Multiply(Test2Value1, Test2Vaule2));
            Assert.AreEqual(Test3EexpectedValue, SimpleMath.Multiply(Test3Value1, Test3Vaule2));
        }

        [TestMethod]
        public void Divide_DenominatorZero_ThrowsArgumentException()
        {
            // Divide by zero should throw an argument exception with a message
            // "Denominator cannot be zero"
            double num1 = 55;
            double num2 = 0;
            Assert.ThrowsException<ArgumentException>(() => SimpleMath.Divide(num1, num2));
        }

        // TODO: Test Divide method with two valid numbers
        [TestMethod()]
        [DataRow(5, 10)]
        [DataRow(0, 100)]
        [DataRow(-1, -10)]
        [DataRow(0, -4)]
        public void Divide_TwoValidNumbers_ReturnQuotient(double num1, double num2)
        {
            double expectedValue = num1 / num2;
            Assert.AreEqual(expectedValue, SimpleMath.Divide(num1, num2));
        }

        // TODO: Test subtract method with two valid numbers
        [TestMethod()]
        [DataRow(5, 10)]
        [DataRow(0, 100)]
        [DataRow(-1, -10)]
        [DataRow(0, -200)]
        public void Subtract_TwoValidNumbersPositveAndNegitive_ReturnDifference(double num1, double num2)
        {
            double expectedValue = num1 - num2;
            Assert.AreEqual(expectedValue, SimpleMath.Subtract(num1, num2));
        }
    }
}