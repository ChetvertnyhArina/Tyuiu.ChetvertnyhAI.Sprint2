using Tyuiu.ChetvertnyhAI.Sprint2.Task5.V8.Lib;
namespace Tyuiu.ChetvertnyhAI.Sprint2.Task5.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void FindDateOfPreviousDay()
        {
            DataService ds = new DataService();
            int m = 9;
            int n = 8;
            string res = ds.FindDateOfPreviousDay(n, m);
            string wait = "07." + m;
            Assert.AreEqual(wait, res);


        }
    }
}
