using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MaslovDM.Sprint1.Task7.V16.Lib;

namespace Tyuiu.MaslovDM.Sprint1.Task7.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 5.0;
            double res = ds.Calculate(x);
            double wait = 0.026;
            Assert.AreEqual(wait, res);
        }
    }
}