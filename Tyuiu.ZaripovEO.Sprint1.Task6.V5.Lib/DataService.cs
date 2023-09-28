using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ZaripovEO.Sprint1.Task6.V5.Lib
{
    public class DataService : ISprint1Task6V5
    {
        public string CheckSymmetricalWords(string value)
        {
            string[] slova = value.Split(' ');
            string res = "";
            for (int i = 0; i < slova.Length; i++)
            {
                string word = slova[i];
                string rev = new string(word.Reverse().ToArray());
                if (word == rev)
                {
                    res += (word + " ");
                }
            }
            return res;
        }

    }
}