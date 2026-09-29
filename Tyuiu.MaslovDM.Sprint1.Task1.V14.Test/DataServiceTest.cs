using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MaslovDM.Sprint1.Task1.V14.Lib;

namespace Tyuiu.MaslovDM.Sprint1.Task1.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double a = 1.0;
            double b = 2.0;
            double c = 3.0;
            double res = ds.Calculate(a, b, c);

            Assert.AreEqual(0.867, Math.Round(res, 3));
        }
    }
}