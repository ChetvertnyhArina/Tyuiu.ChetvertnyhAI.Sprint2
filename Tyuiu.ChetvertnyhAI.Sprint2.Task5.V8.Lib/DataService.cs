using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.ChetvertnyhAI.Sprint2.Task5.V8.Lib
{
    public class DataService : ISprint2Task5V8
    {
        public string FindDateOfPreviousDay(int n, int m)
        {
            string res;
            if (m >= 1 && m <= 12)
            {
                switch (n)
                {
                    case 1:
                        res = "31." + (m - 1);
                        break;
                    case 2:
                        res = "01." + m;
                        break;
                    case 3:
                        res = "02." + m;
                        break;
                    case 4:
                        res = "03." + m;
                        break;
                    case 5:
                        res = "04." + m;
                        break;
                    case 6:
                        res = "05." + m;
                        break;
                    case 7:
                        res = "06." + m;
                        break;
                    case 8:
                        res = "07." + m;
                        break;
                    case 9:
                        res = "08." + m;
                        break;
                    case 10:
                        res = "09." + m;
                        break;
                    case 11:
                        res = "10." + m;
                        break;
                    case 12:
                        res = "11." + m;
                        break;
                    case 13:
                        res = "12." + m;
                        break;
                    case 14:
                        res = "13." + m;
                        break;
                    case 15:
                        res = "14." + m;
                        break;
                    case 16:
                        res = "15." + m;
                        break;
                    case 17:
                        res = "16." + m;
                        break;
                    case 18:
                        res = "17." + m;
                        break;
                    case 19:
                        res = "18." + m;
                        break;
                    case 20:
                        res = "19." + m;
                        break; 
                    case 21:
                        res = "20." + m;
                        break;
                    case 22:
                        res = "21." + m;
                        break;
                    case 23:
                        res = "22." + m;
                        break;
                    case 24:
                        res = "23." + m;
                        break;
                    case 25:
                        res = "24." + m;
                        break;
                    case 26:
                        res = "25." + m;
                        break;
                    case 27:
                        res = "26." + m;
                        break;
                    case 28:
                        res = "27." + m;
                        break;
                    case 29:
                        res = "28." + m;
                        break;
                    case 30:
                        res = "29." + m;
                        break;
                    case 31:
                        res = "30." + m;
                        break;
                    default:
                        throw new ArgumentException($"День должен быть от 1 до 31. Значение {n}");
                }
            }
            else
            {
                res = "0";
            }
            return res;

        }
    }
}
