using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.BardievaGA.Sprint1.Task5.V6.Lib;

namespace Tyuiu.BardievaGA.Sprint1.Task5.V6.Test
{
    [TestClass]
    public class DataServiseTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            int k = 20;

            DataServise ds = new DataServise();
            double res = ds.Calculate(k);

            int result = Convert.ToInt32(res);

            int wait = 6;
            Assert.AreEqual(wait, result);
        }
    }
}
