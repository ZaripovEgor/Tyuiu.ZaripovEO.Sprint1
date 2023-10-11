using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZaripovEO.Sprint1.Task1.V12.Lib;

namespace Tyuiu.ZaripovEO.Sprint1.Task1.V12.Test
{
    [TestClass]
    public class DataServiseTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double y = 2.0;
            double x = 4.0;

            var res = ds.Calculate(x, y);
            Assert.AreEqual(1, res);
        }
    }
}
