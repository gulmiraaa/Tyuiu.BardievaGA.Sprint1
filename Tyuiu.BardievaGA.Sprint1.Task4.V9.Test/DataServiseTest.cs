using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.BardievaGA.Sprint1.Task4.V9.Lib;

namespace Tyuiu.BardievaGA.Sprint1.Task4.V9.Test
{
    [TestClass]
    public class DataServiseTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataServise ds = new DataServise();
            double x = 4;
            double y = 2;
            double wait = 1.179;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
