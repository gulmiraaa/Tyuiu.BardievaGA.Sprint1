using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.BardievaGA.Sprint1.Task0.V19.Lib;

namespace Tyuiu.BardievaGA.Sprint1.Task0.V19.Test
{
    [TestClass]
    public class DataServiseTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(10, res);
        }
    }
}
