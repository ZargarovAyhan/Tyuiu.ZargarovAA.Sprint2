using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ZargarovAA.Sprint2.Task4.V20.Lib;
namespace Tyuiu.ZargarovAA.Sprint2.Task4.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 2;
            double res = ds.Calculate(x, y);
            double wait = 18;
            Assert.AreEqual(wait, res);
        }
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 10;
            double y = 10;
            double res = ds.Calculate(x, y);
            double wait = 99.9;
            Assert.AreEqual(wait, res);

        }
    }
}
