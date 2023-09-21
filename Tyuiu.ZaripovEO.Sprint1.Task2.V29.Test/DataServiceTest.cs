using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZaripovEO.Sprint1.Task2.V29.Lib;

namespace Tyuiu.ZaripovEO.Sprint1.Task2.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 120;
            var res = ds.ConvertSecondsToHours(x);
            Assert.AreEqual(2, res);
        }
    }
}
