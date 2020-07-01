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

        public void Min_50_30_is20()
        {

            int x = 50;
            int y = 30;
            int exp = 20;
            MyCalcLib.MyCalc c = new MyCalcLib.MyCalc();
            int act = c.Minus(x, y);
            Assert.AreEqual(exp, act);


        }
        public void Umn_2_3_is6()
        {

            int x = 2;
            int y = 3;
            int exp = 6;
            MyCalcLib.MyCalc c = new MyCalcLib.MyCalc();
            int act = c.Umn(x, y);
            Assert.AreEqual(exp, act);


        }
    }
}
