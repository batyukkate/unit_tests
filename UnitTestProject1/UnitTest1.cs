using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1_0_0()
        {
            //arange
            double x = 0;
            double expected = 0;
            //act
            WindowsFormsApp3.Form1 c = new WindowsFormsApp3.Form1();
            double actual = c.Method1(x);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod2_1_05()
        {
            //arange
            double x = 1;
            double expected = 0.5;
            //act
            WindowsFormsApp3.Form1 c = new WindowsFormsApp3.Form1();
            double actual = c.Method2(x);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod3_3_125()
        {
            //arange
            double x = 3;
            double expected = 12.5;
            //act
            WindowsFormsApp3.Form1 c = new WindowsFormsApp3.Form1();
            double actual = c.Method3(x);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod1_double_0_0()
        {
            //arange
            double x = 0;
            double expected = 0;
            //act
            WindowsFormsApp3.Form1 c = new WindowsFormsApp3.Form1();
            double actual = c.Method1(x);
            actual = c.DoubleRes(actual);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod2_double_1_1()
        {
            //arange
            double x = 1;
            double expected = 1;
            //act
            WindowsFormsApp3.Form1 c = new WindowsFormsApp3.Form1();
            double actual = c.Method2(x);
            actual = c.DoubleRes(actual);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod3_double_3_25()
        {
            //arange
            double x = 3;
            double expected = 25;
            //act
            WindowsFormsApp3.Form1 c = new WindowsFormsApp3.Form1();
            double actual = c.Method3(x);
            actual = c.DoubleRes(actual);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod1_4_1514()
        {
            //arange
            double x = 4;
            double expected = -1.514;
            //act
            WindowsFormsApp3.Form1 c = new WindowsFormsApp3.Form1();
            double actual = c.Method1(x);
            actual = Math.Round(actual, 3);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod2_4_4()
        {
            //arange
            double x = 4;
            double expected = 4;
            //act
            WindowsFormsApp3.Form1 c = new WindowsFormsApp3.Form1();
            double actual = c.Method2(x);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod3_4_195()
        {
            //arange
            double x = 4;
            double expected = 19.5;
            //act
            WindowsFormsApp3.Form1 c = new WindowsFormsApp3.Form1();
            double actual = c.Method3(x);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod3_double_4_39()
        {
            //arange
            double x = 4;
            double expected = 39;
            //act
            WindowsFormsApp3.Form1 c = new WindowsFormsApp3.Form1();
            double actual = c.Method3(x);
            actual = c.DoubleRes(actual);
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
