using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ShtolVA.Sprint2.Task6.V11.Lib;

namespace Tyuiu.ShtolVA.Sprint2.Task6.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfNextDay()
        {
            DataService ds = new DataService();
            int g, m, n;
            g = 2007;
            m = 5;
            n = 9;
            string func = ds.FindDateOfNextDay(g, m, n);
            string wait = "10.05.2007";
            Assert.AreEqual(wait, func);
        }
    }
}
