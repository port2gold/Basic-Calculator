using System;
using ClassLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MarketCalculatorTest
{
    [TestClass]
    public class MultiplicationTest
    {
        [TestMethod]
        public void MultiplicationOfLargeNumbers()
        {
            //Arrange
            ClassLib.Operations calc = new Operations();
            string expected = "162859021";

            //Act
            string actual = calc.Multiplication("35489", "4589");

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MultiplicationOfDoubles()
        {
            //Arrange
            Operations calc = new Operations();
            string expected = "466.86916";

            //Act
            string actual = calc.Multiplication("57.56", "8.111");

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MultiplicationOfNegativeNumbers()
        {
            //Arrange
            Operations calc = new Operations();
            string expected = "-6131916";

            //Act
            string actual = calc.Multiplication("-756", "8111");

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
