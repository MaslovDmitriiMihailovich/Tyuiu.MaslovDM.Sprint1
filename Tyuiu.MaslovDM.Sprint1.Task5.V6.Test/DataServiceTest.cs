using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MaslovDM.Sprint1.Task5.V6.Lib;

namespace Tyuiu.MaslovDM.Sprint1.Task5.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int k = 1;
            int res = ds.Calculate(k);
            Assert.AreEqual(1, res);

            k = 7;
            res = ds.Calculate(k);
            Assert.AreEqual(7, res);

            k = 8;
            res = ds.Calculate(k);
            Assert.AreEqual(1, res);
        }
    }
}