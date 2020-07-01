using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyCalcTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Sum_10_20_is30()
        {

            int x = 10;
            int y = 20;
            int exp = 30;
            MyCalcLib.MyCalc c = new MyCalcLib.MyCalc();
            int act = c.Sum(x, y);
            Assert.AreEqual(exp, act);


        }
    }
}
