using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KrutikovaVP.Sprint2.Task6.V9.Lib;

namespace Tyuiu.KrutikovaVP.Sprint2.Task6.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfNextDay()
        {
            DataService ds = new DataService();
            Assert.AreEqual("5 января", ds.FindDateOfNextDay(1, 4));
            Assert.AreEqual("16 февраля", ds.FindDateOfNextDay(2, 15));
            Assert.AreEqual("1 апреля", ds.FindDateOfNextDay(3, 31));
            Assert.AreEqual("4 апреля", ds.FindDateOfNextDay(4, 3));
            Assert.AreEqual("1 июня", ds.FindDateOfNextDay(5, 31));
            Assert.AreEqual("7 июня", ds.FindDateOfNextDay(6, 6));
            Assert.AreEqual("13 июля", ds.FindDateOfNextDay(7, 12));
            Assert.AreEqual("20 августа", ds.FindDateOfNextDay(8, 19));
            Assert.AreEqual("1 сентября", ds.FindDateOfNextDay(8, 31));
            Assert.AreEqual("12 октября", ds.FindDateOfNextDay(10, 11));
            Assert.AreEqual("8 ноября", ds.FindDateOfNextDay(11, 7));
            Assert.AreEqual("Это последний день года.", ds.FindDateOfNextDay(12, 31));

            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindDateOfNextDay(13, 5);
            });

        }
    }
}
