using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.BardievaGA.Sprint1.Task2.V16.Lib;

namespace Tyuiu.BardievaGA.Sprint1.Task2.V16.Test
{
    [TestClass]
    public class DataServiseTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataServise ds = new DataServise();
            int x = 15;
            var res = ds.CalculatePerimetrCircle(x);
            Assert.AreEqual(94.245, res);
        }
    }
}
