using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.BardievaGA.Sprint1.TaskReview.V4.Lib;

namespace Tyuiu.BardievaGA.Sprint1.TaskReview.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 4;
            double y = 6;
            double wait = 2.565;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(res, wait);

        }
    }
}
