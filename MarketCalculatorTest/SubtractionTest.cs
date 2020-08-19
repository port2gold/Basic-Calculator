using System;
using ClassLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MarketCalculatorTest
{
    [TestClass]
    public class SubtractionTest
    {
        [TestMethod]
        public void SubtractionOfLargeNumbers()
        {
            //Arrange
            Operations calc = new Operations();
            string expected = "496645";

            //Act
            string actual = calc.Subtraction("577756", "81111");

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SubtractionOfDouble()
        {
            //Arrange
            Operations calc = new Operations();
            string expected = "496.645";

            //Act
            string actual = calc.Subtraction("577.756", "81.111");

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SubtractionOfNegativeNumbers()
        {
            //Arrange
            Operations calc = new Operations();
            string expected = "-20000";

            //Act
            string actual = calc.Subtraction("-40000", "-20000");

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
