using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KrutikovaVP.Sprint2.Task2.V14.Lib;

namespace Tyuiu.KrutikovaVP.Sprint2.Task2.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            int x = 5;
            int y = 6;
            var res = ds.CheckDotInShadedArea(x, y);
            var wait = true;
            Assert.AreEqual(wait, res);

        }
        
    }
}
