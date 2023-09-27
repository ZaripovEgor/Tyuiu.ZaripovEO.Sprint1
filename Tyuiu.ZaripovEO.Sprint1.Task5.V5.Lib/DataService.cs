using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ZaripovEO.Sprint1.Task5.V5.Lib
{
    public class DataService : ISprint1Task5V5
    {
        public int Calculate(double x)
        {
            double res = Math.Truncate((x - Math.Truncate(x)) * 10);
            int ara = Convert.ToInt32(res);
            return ara;
        }
    }
}
