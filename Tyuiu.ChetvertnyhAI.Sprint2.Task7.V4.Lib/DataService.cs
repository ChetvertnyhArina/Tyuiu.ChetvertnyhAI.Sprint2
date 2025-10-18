using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.ChetvertnyhAI.Sprint2.Task7.V4.Lib
{
    public class DataService : ISprint2Task7V4
    {
        public bool CheckDotInShadedArea(double x, double y)
        {

            bool res = false;
            if (x * x + y * y <= 1)
            {
                if (x < 0 && y > 0)
                {
                    res = true;
                }
                if (x > 0 && y > 0 && (x * x + y * y > 0.09))
                {
                    res = true;
                }
            }
            return res;
        }    
              
    }
}
