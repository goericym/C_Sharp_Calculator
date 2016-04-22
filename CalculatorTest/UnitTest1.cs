using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
namespace CalculatorTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodPlus()
        {
            ClassPlus target = new ClassPlus(); // TODO: Initialize to an appropriate value
            double expected = 6; // TODO: Initialize to an appropriate value
            double actual;
            actual = target.Result(2, 4);
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }
        [TestMethod]
        public void MyTestMethodMinus()
        {
            ClassMinus target = new ClassMinus(); // TODO: Initialize to an appropriate value
            double expected = -2; // TODO: Initialize to an appropriate value
            double actual;
            actual = target.Result(2, 4);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void MyTestMethodDivid()
        {

            ClassDivid target = new ClassDivid(); // TODO: Initialize to an appropriate value
            double expected = 0.5; // TODO: Initialize to an appropriate value
            double actual;
            actual = target.Result(2, 4);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void MyTestMethodDivid1()
        {

            ClassDivid target = new ClassDivid(); // TODO: Initialize to an appropriate value
            double expected = 0; // TODO: Initialize to an appropriate value
            double actual;
            actual = target.Result(0, 4);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void MyTestMethodDivid2()
        {
            ClassDivid target = new ClassDivid(); // TODO: Initialize to an appropriate value
            double expected = double.MaxValue; // TODO: Initialize to an appropriate value
            double actual;
            actual = target.Result(4, 0);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void MyTestMethodDivid3()
        {
            ClassDivid target = new ClassDivid(); // TODO: Initialize to an appropriate value
            double expected = -3; // TODO: Initialize to an appropriate value
            double actual;
            actual = target.Result(6, -2);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void MyTestMethodMultiply()
        {
            ClassMultiply target = new ClassMultiply(); // TODO: Initialize to an appropriate value
            double expected = 6; // TODO: Initialize to an appropriate value
            double actual;
            actual = target.Result(3, 2);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void MyTestMethodNP()
        {
            ClassNP target = new ClassNP(); // TODO: Initialize to an appropriate value
            double expected = -3; // TODO: Initialize to an appropriate value
            double actual;
            actual = target.Result(3);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void MyTestMethodNP1()
        {
            ClassNP target = new ClassNP(); // TODO: Initialize to an appropriate value
            double expected = 3; // TODO: Initialize to an appropriate value
            double actual;
            actual = target.Result(-3);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void MyTestMethodDot()
        {
            ClassDot target = new ClassDot(); // TODO: Initialize to an appropriate value
            string expected = "3."; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.Result("3");
            Assert.AreEqual(expected, actual);
        }
    }

}
