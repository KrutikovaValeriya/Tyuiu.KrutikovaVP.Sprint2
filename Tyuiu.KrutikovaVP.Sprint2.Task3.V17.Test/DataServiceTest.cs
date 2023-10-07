using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KrutikovaVP.Sprint2.Task3.V17.Lib;

namespace Tyuiu.KrutikovaVP.Sprint2.Task3.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 2;
            var res = ds.Calculate(x);
            var wait = 6565;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 0;
            var res = ds.Calculate(x);
            var wait = -0.286;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition3()
        {
            DataService ds = new DataService();
            double x = 1;
            var res = ds.Calculate(x);
            var wait = 16;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition4()
        {
            DataService ds = new DataService();
            double x = -25;
            var res = ds.Calculate(x);
            var wait = -274.96;
            Assert.AreEqual(wait, res);
        }
    }
}
