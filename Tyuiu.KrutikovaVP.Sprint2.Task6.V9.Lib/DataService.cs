using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KrutikovaVP.Sprint2.Task6.V9.Lib
{
    public class DataService : ISprint2Task6V9

    {
        public string FindDateOfNextDay(int m, int n)
        {
            n += 1;
            switch (m)
            {
                case 1: if (n > 0 && n <= 31) return $"{n} января"; else return $"{n-31} февраля";
                case 2: if (n > 0 && n <= 28) return $"{n} февраля"; else return $"{n-28} марта";
                case 3: if (n > 0 && n <= 31) return $"{n} марта"; else return $"{n-31} апреля";
                case 4: if (n > 0 && n <= 30) return $"{n} апреля"; else return $"{n-30} мая";
                case 5: if (n > 0 && n <= 31) return $"{n} мая"; else return $"{n-31} июня";
                case 6: if (n > 0 && n <= 30) return $"{n} июня"; else return $"{n-30} июля";
                case 7: if (n > 0 && n <= 31) return $"{n} июля"; else return $"{n-31} августа";
                case 8: if (n > 0 && n <= 31) return $"{n} августа"; else return $"{n-31} сентября";
                case 9: if (n > 0 && n <= 30) return $"{n} сентября"; else return $"{n-30} октября";
                case 10: if (n > 0 && n <= 31) return $"{n} октября"; else return $"{n-31} нобяря";
                case 11: if (n > 0 && n <= 30) return $"{n} ноября"; else return $"{n-30} декабря";
                case 12: if (n > 0 && n <= 31) return $"{n} декабря"; else return "Это последний день года."; 
                default: throw new ArgumentException($"Значение месяца может быть от 1 до 12. Значение {m}");
            }
        }
    }
}
