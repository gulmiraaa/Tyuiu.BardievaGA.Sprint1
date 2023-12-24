using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


using Tyuiu.BardievaGA.Sprint1.Task1.V7.Lib;

namespace Tyuiu.BardievaGA.Sprint1.Task1.V7.Test
{
    [TestClass]
    public class DataServiseTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataServise ds = new DataServise();
            double x = 2.0;
            double y = 3.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(2, res);

        }
    }
}
