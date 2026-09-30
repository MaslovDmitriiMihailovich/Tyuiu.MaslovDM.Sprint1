using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MaslovDM.Sprint1.Task3.V18.Lib;

namespace Tyuiu.MaslovDM.Sprint1.Task3.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double a = 9;
            double b = 7;
            double c = 2;
            double wait = 12;
            double res = ds.HowManySquares(a, b, c);
            Assert.AreEqual(wait, res);
        }
    }
}