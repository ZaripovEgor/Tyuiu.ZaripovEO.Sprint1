using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ZaripovEO.Sprint1.Task2.V29.Lib
{
    public class DataService : ISprint1Task2V29
    {
        public int ConvertSecondsToHours(int value)
        {
            return value / 60;
        }
    }
}

