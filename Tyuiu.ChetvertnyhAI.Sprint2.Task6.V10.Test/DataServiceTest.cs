using Tyuiu.ChetvertnyhAI.Sprint2.Task6.V10.Lib;
namespace Tyuiu.ChetvertnyhAI.Sprint2.Task6.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void FindDateOfPreviousDay()
        {
            DataService ds = new DataService();
            Assert.AreEqual("1.07.2007", ds.FindDateOfPreviousDay(2007, 7, 2));
            Assert.AreEqual("4.10.2011", ds.FindDateOfPreviousDay(2011, 10, 5));
            Assert.AreEqual("31.12.1998", ds.FindDateOfPreviousDay(1999, 1, 1));
        }
    }
}
