using Tyuiu.ChetvertnyhAI.Sprint2.Task4.V22.Lib;
namespace Tyuiu.ChetvertnyhAI.Sprint2.Task4.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 25;
            double y = 19;
            double res = ds.Calculate(x, y);
            double wait = 852.92;
            Assert.AreEqual(wait, res);
        }


        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 10;
            double y = 15;
            double res = ds.Calculate(x, y);
            double wait = 0.517;
            Assert.AreEqual(wait, res);
        }
    }
}
