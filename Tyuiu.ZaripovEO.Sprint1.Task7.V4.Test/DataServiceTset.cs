using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZaripovEO.Sprint1.Task7.V4.Lib;

namespace Tyuiu.ZaripovEO.Sprint1.Task7.V4.Test
{
    [TestClass]
    public class DataServiceTset
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 3;
            double y = 4;
            double wait = 1.625;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
