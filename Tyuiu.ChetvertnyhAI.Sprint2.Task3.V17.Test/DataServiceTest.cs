﻿using Tyuiu.ChetvertnyhAI.Sprint2.Task3.V17.Lib;
namespace Tyuiu.ChetvertnyhAI.Sprint2.Task3.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 3;
            double res = ds.Calculate(x);
            double wait = 265;
            Assert.AreEqual(wait, res);

        }


        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 0;
            double res = ds.Calculate(x);
            double wait = -0.286;
            Assert.AreEqual(wait, res);
        }


        [TestMethod]
        public void ValidCondition3()
        {
            DataService ds = new DataService();
            double x = 1;
            double res = ds.Calculate(x);
            double wait = 16;
            Assert.AreEqual(wait, res);
        }


        [TestMethod]
        public void ValidCondition4()
        {
            DataService ds = new DataService();
            double x = -22;
            double res = ds.Calculate(x);
            double wait = -241.955;
            Assert.AreEqual(wait, res);
        }
    }
}
