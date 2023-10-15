using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KrutikovaVP.Sprint2.Task4.V21.Lib;

namespace Tyuiu.KrutikovaVP.Sprint2.Task4.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 4;
            var wait = 256;
            var res = ds.Calculate(x,y);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;
            var wait = 0.726;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }

}
