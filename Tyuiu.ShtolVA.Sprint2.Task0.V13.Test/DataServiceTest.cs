﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ShtolVA.Sprint2.Task0.V13.Lib;

namespace Tyuiu.ShtolVA.Sprint2.Task0.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCompareOperations()
        {
            DataService ds = new DataService();
            int x = 1905;
            int y = 475;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);
            bool[] wait = new bool[6] { false, true, false, true, false, true };

            CollectionAssert.AreEqual(wait, res);

        }
    }
}
