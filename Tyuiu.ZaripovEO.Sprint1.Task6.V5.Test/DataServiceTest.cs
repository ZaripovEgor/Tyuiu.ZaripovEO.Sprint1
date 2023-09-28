using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using Tyuiu.ZaripovEO.Sprint1.Task6.V5.Lib;

namespace Tyuiu.ZaripovEO.Sprint1.Task6.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string strTest = "жил казак шил шалаш";
            DataService ds = new DataService();
            string[] slova = strTest.Split(' ');
            string res = "";
            for (int i = 0; i < slova.Length; i++)
            {
                string word = slova[i];
                string rev = new string(word.Reverse().ToArray());
                if (word == rev)
                {
                    res += (word + " ");
                }
            }
            string wait = "казак шалаш ";
            Assert.AreEqual(wait, res);
        }
    }
}