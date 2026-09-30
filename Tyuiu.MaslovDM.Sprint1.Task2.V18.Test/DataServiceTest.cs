using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MaslovDM.Sprint1.Task2.V18.Lib;

namespace Tyuiu.MaslovDM.Sprint1.Task2.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int a = 5;
            int b = 3;
            int c = 4;
            int res = ds.Calculate(a, b, c);
            Assert.AreEqual(64, res);
        }
    }
}