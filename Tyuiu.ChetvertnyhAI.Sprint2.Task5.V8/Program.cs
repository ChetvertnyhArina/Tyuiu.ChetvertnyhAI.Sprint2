using Tyuiu.ChetvertnyhAI.Sprint2.Task5.V8.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        string res;
        Console.Title = "Спринт #2 | Выполнила: Четвертных А. И. | ИСТНб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Оператор switch                                                   *");
        Console.WriteLine("* Задание #5                                                              *");
        Console.WriteLine("* Вариант #8                                                              *");
        Console.WriteLine("* Выполнила: Четвертных Арина Игоревна | ИСТНб-25-1                       *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дата некоторого дня характеризуется двумя натуральными числами:         *");
        Console.WriteLine("* m (порядковый номер месяца) и n (число).По заданным n и m определить    *");
        Console.WriteLine("* дату предыдущего дня (принять, что n и m не характеризуют 1 января).    *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Введите день: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите номер месяца: ");
        int m = Convert.ToInt32(Console.ReadLine());
        if (((m < 1) || (m > 12)) || ((n < 1) || (n > 31)))
        {
            res = "Введены неверные значения";
        }
        else
        {
            res = "Предыдущий день: " + ds.FindDateOfPreviousDay(m, n);
        }
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(res);
        Console.ReadKey();
    }
}