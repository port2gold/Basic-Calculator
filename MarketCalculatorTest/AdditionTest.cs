using System;
using ClassLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MarketCalculatorTest
{
    [TestClass]
    public class AdditionTest
    {
        [TestMethod]
        public void AdditionOfIntegers()
        {
            //Arrange
            Operations calc = new Operations();
            var expected = "291034";
            

            //Act
            var actual = calc.Addition("234567", "56467");

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AdditionOfDouble()
        {
            //Arrange 
            Operations calc = new Operations();
            string expected = "3162.022";

            //Act
            var actual = calc.Addition("298.547", "2863.475");

            //Assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void AdditionOfNegativeNumbers()
        {
            //Arrange
            Operations calc = new Operations();
            string expected = "-300";

            //Act 
            string actual = calc.Addition("-100", "-200");
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
