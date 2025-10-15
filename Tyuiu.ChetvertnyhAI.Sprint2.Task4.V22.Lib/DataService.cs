using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.ChetvertnyhAI.Sprint2.Task4.V22.Lib
{
    public class DataService : ISprint2Task4V22
    {
        public double Calculate(double x, double y)
        {
            double z = x - 3 > y * 2 - 21 ? x * x + 12 * y - (2 / x) : ((x * x) + (Math.Cos(y) * Math.Cos(y)) + 17) / ((y * y) - (Math.Sin(y) * Math.Sin(y)) + 3);
            return Math.Round(z, 3);
        }
    }
}
