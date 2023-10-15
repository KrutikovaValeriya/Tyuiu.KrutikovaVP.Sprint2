using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KrutikovaVP.Sprint2.Task4.V21.Lib
{
    public class DataService : ISprint2Task4V21
    {
        public double Calculate(double x, double y)
        {
            return x < y - 2 ? Math.Round(Math.Pow(2 + (x + 1) / (x * x), y), 3) : Math.Round((x * x + 10) / (y * y - Math.Sin(x * x) + 12), 3);

        }
    }
}
