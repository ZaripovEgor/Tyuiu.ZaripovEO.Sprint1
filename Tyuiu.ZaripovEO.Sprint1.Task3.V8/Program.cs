using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ZaripovEO.Sprint1.Task3.V8.Lib;

namespace Tyuiu.ZaripovEO.Sprint1.Task3.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт №1 | Выполнил: Зарипов Е. О. | ИСТНб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Операторы составного присваивания                                 *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #8                                                              *");
            Console.WriteLine("* Выполнил: Зарипов Егор Олегович | ИСТНб-23-1                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу вычисления величины дохода по вкладу.                *");
            Console.WriteLine("* Процентная ставка (% годовых) и время хранения (дней) задаются          *");
            Console.WriteLine("* во время работы программы.                                              *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            double startAmount;
            Console.WriteLine("Введите величина вклада (руб.)");
            startAmount = Convert.ToDouble(Console.ReadLine());
            double timeDays;
            Console.WriteLine("Введите время хранения (дней)");
            timeDays = Convert.ToDouble(Console.ReadLine());
            double percent;
            Console.WriteLine("Введите процентную ставку (% годовых)");
            percent = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            double x1 = ds.IncomeAmount(startAmount, percent, timeDays) + startAmount;
            Console.WriteLine("Величина дохода по вкладу = " + ds.IncomeAmount(startAmount, percent, timeDays));
            Console.WriteLine("Сумма по окончании срока вклада = " + x1);

            Console.ReadKey();
        }
    }

}
