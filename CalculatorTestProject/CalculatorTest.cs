using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using prjCon_Cs_Calculatrice;

namespace CalculatorTestProject
{
    [TestClass]
    public class CalculatorTest
    {
        // TEST ADD 
        [TestMethod]
        public void TestADD_DoubleNumber_Addition()
        {
            // ARRANGE
            double expected = 4;
            double number_1 = 2;
            double number_2 = 2;

            // ACT
            double actual = Program.Add(number_1, number_2);

            // ASSERT
            Assert.AreEqual(expected, actual);
        }

        // TEST SUBSTRACT 
        [TestMethod]
        public void TestSUBSTRACT_DoubleNumber_Addition()
        {
            // ARRANGE
            double expected = 4;
            double number_1 = 10;
            double number_2 = 6;

            // ACT
            double actual = Program.Substract(number_1, number_2);

            // ASSERT
            Assert.AreEqual(expected, actual);
        }

        // TEST MULTIPLY 
        [TestMethod]
        public void TestMULTIPLY_DoubleNumber_Addition()
        {
            // ARRANGE
            double expected = 36;
            double number_1 = 6;
            double number_2 = 6;

            // ACT
            double actual = Program.Multiply(number_1, number_2);

            // ASSERT
            Assert.AreEqual(expected, actual);
        }

        // TEST DIVIDE 
        [TestMethod]
        public void TestDIVIDE_DoubleNumber_Divition()
        {
            // ARRANGE
            double expected = 5;
            double numerator = 20;
            double denominator = 4;

            // ACT
            double actual = Program.Divide(numerator, denominator);

            // ASSERT
            Assert.AreEqual(expected, actual);
        }
    }
}
