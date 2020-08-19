using System;
using ClassLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MarketCalculatorTest
{
    [TestClass]
    public class CalculateTest
    {
        [TestMethod]
        public void CalculaterUsingAdditionOperator()
        {
            //Arrange
            Operations calc = new Operations();
            string expected = "658867";

            //Act
            string actual = calc.Calculate("577756", "81111","+");

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalcualateUsingSubtractionOperator()
        {
            //Arrange
            Operations calc = new Operations();
            string expected = "496645";

            //Act
            string actual = calc.Calculate("577756", "81111", "-");

            //Assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void CalculateUsingMultiplicationOperator()
        {
            //Arrange
            Operations calc = new Operations();
            string expected = "62908916";

            //Act
            string actual = calc.Calculate("7756", "8111", "*");

            //Assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void CalculateUsingDivisionOperator()
        {
            //Arrange
            Operations calc = new Operations();
            string expected = "123789";

            //Act
            string actual = calc.Calculate("1237890", "10", "/");

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
