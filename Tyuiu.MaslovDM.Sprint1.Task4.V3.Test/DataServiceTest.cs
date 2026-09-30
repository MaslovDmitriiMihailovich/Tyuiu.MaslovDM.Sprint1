using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MaslovDM.Sprint1.Task4.V3.Lib;

namespace Tyuiu.MaslovDM.Sprint1.Task4.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 3.0;
            double y = 1.0;

            double res = ds.Calculate(x, y);
            double wait = 0.75;

            Assert.AreEqual(wait, res);
        }
    }
}