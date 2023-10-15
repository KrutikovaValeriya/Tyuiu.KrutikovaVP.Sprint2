using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KrutikovaVP.Sprint2.Task6.V9.Lib;

namespace Tyuiu.KrutikovaVP.Sprint2.Task6.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int m, n;
            string res;

            Console.Title = "Спринт #2 | Выполнил: Крутикова В. П. | АСОиУБ-23-3";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #2                                                                *");
            Console.WriteLine("* Тема: Алгоритмы разветвляющейся структуры                                *");
            Console.WriteLine("* Задание #6                                                               *");
            Console.WriteLine("* Вариант #9                                                              *");
            Console.WriteLine("* Выполнил: Крутикова Валерия Павловна | АСОиУБ-23-3                       *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Дата некоторого дня характеризуется двумя натуральными числами:          *");
            Console.WriteLine("* m (порядковый номер месяца) и n (число). По заданным m и n определить    *");
            Console.WriteLine("* дату следующего дня (принять, что m и n не характеризуют 31 декабря).    *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");


            Console.WriteLine("Введите номер месяца: ");
            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число: ");
            n = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            if ((n < 0 || n > 31) || (m < 1 || m > 12))
            {
                res = "Введено неверное значение числа/месяца!";

            }
            else
            {
                res = "Это дата: "+ds.FindDateOfNextDay(m, n);
            }

            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}
