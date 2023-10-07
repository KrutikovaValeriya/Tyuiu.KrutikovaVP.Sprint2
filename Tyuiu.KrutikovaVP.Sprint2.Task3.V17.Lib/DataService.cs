using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KrutikovaVP.Sprint2.Task3.V17.Lib
{
    public class DataService : ISprint2Task3V17
    {
        public double Calculate(double x)
        {
            double y;

            if (x>1)
            {
                y = x * x + Math.Pow((x + 1) / (x - 1), 8);
            }
                else 
                if (x == 0)
                {
                    y = (2+x-3*x)/(x - 7);
                }
                    else 
                    if (x>-21 && x<2)
                    {
                    y = Math.Pow(1 + 1 / (x * x), 4);
                    }
                        else 
                        {
                        y = x + 10 * x - 1 / x;
                        }
            return Math.Round(y,3);
        }
    }
}
