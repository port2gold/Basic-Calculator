using System;
using ClassLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MarketCalculatorTest
{
    [TestClass]
    public class DivisionTest
    {
        [TestMethod]
        public void DivisionByZero()
        {
            //Arrange
            Operations calc = new Operations();
            var expected = "Error!!!";

            //Act
            var actual = calc.Division("50", "0");
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DivisionOfLargeNumbers()
        {
            //Arrange
            Operations calc = new Operations();
            string expected = "3848387";

            //Act
            string actual = calc.Division("38483870", "10");

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void DivisionOfDoubles()
        {
            //Arrange
            Operations calc = new Operations();
            string expected = "18.38";

            //Act
            string actual = calc.Division("45.95", "2.5");

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
