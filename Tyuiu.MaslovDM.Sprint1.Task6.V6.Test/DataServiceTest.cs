using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MaslovDM.Sprint1.Task6.V6.Lib;

namespace Tyuiu.MaslovDM.Sprint1.Task6.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            DataService ds = new DataService();
            string str = "Привет мир";
            string res = ds.DeleteFirstLetter(str);
            string wait = "ривет ир";
            Assert.AreEqual(wait, res);
        }
    }
}