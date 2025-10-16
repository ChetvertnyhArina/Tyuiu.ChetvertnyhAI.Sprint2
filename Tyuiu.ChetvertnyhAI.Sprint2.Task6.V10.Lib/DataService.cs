using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.ChetvertnyhAI.Sprint2.Task6.V10.Lib
{
    public class DataService : ISprint2Task6V10
    {
        public string FindDateOfPreviousDay(int g, int m, int n)
        {
            {
                string res;

                int year = g;
                switch (n)
                {
                    case 1:
                        if (m == 1)
                        {
                            m = 12;
                            year -= 1;
                            n = 31;
                        }
                        else
                        {
                            switch (m)
                            {
                                case 1:
                                    n = 31;
                                    m = 12;
                                    break;
                                default:
                                    m = m - 1;
                                    switch (m)
                                    {
                                        case 1:
                                        case 3:
                                        case 5:
                                        case 7:
                                        case 8:
                                        case 10:
                                            n = 31;
                                            break;
                                        case 2:
                                            n = 28;
                                            break;
                                        default:
                                            n = 30;
                                            break;
                                    }
                                    break;
                            }
                        }
                        break;
                    default:
                        n = n - 1;
                        break;
                }
                res = ($"{n.ToString("D2")}.{m.ToString("D2")}.{year}");
                return res;

            }
        }
    }
}
