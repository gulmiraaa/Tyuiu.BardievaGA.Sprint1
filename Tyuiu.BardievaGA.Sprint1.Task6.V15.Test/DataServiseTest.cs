using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.BardievaGA.Sprint1.Task6.V15.Lib;

namespace Tyuiu.BardievaGA.Sprint1.Task6.V15.Test
{
    [TestClass]
    public class DataServiseTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataServise ds = new DataServise();
            string value = "Больше букв или символов!";
            bool res = ds.CheckLettersCount(value);
            bool wait = true;
            Assert.AreEqual(res, wait);
        }
    }
}
