using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.BardievaGA.Sprint1.Task7.V11.Lib;

namespace Tyuiu.BardievaGA.Sprint1.Task7.V11.Test
{
    [TestClass]
    public class DataServiseTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataServise ds = new DataServise();
            double x = 1;
            double y = 3;
            double wait = 1.751;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(res, wait);

        }
    }
}
