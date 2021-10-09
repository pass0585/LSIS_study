using System;
using ClassLibrary1.Calculate;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class CalculateTest
    {
        [TestMethod]
        public void Plus_WhenInputAandInputB_returnAplusB()
        {
            // AAA

            // 1A Arrange
            int inputA = 1;
            int inputB = 2;
            int expected = 3;
            
            //ininin 2A Act
            Calculate calculate = new Calculate();
            int actual = calculate.Plus(inputA, inputB);

            // 3A Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MyCalc_WhenAisBiggerThanBorEqual_returnAplubB()
        {
            // Arrange
            int inputA = 5;
            int inputB = 3;
            int expected = 8;

            // Act
            Calculate calculate = new Calculate();
            int actual = calculate.MyCalc(inputA, inputB);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MyCalc_WhenAisSmallerThanB_returnAminusB()
        {
            // Arrange
            int inputA = 1;
            int inputB = 3;
            int expected = -2;

            // Act
            Calculate calculate = new Calculate();
            int actual = calculate.MyCalc(inputA, inputB);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
