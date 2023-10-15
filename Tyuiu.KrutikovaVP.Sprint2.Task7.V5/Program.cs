using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KrutikovaVP.Sprint2.Task7.V5.Lib;

namespace Tyuiu.KrutikovaVP.Sprint2.Task7.V5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            double x,y;

            Console.Title = "Спринт #2 | Выполнил: Крутикова В. П. | АСОиУБ-23-3";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #2                                                                *");
            Console.WriteLine("* Тема: Алгоритмы разветвляющейся структуры                                *");
            Console.WriteLine("* Задание #7                                                               *");
            Console.WriteLine("* Вариант #5                                                               *");
            Console.WriteLine("* Выполнил: Крутикова Валерия Павловна | АСОиУБ-23-3                       *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу, которая запрашивает исходные данные и вычисляет,     *");
            Console.WriteLine("* находится ли точка с координатами X,Y в заштрихованной области           *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");


            Console.WriteLine("Введите значение X: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение Y: ");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            if (ds.CheckDotInShadedArea(x, y))
                Console.WriteLine("Точка находится в заштриохванной области");
            else
                Console.WriteLine("Точка не находится в заштриохванной области");
            Console.ReadKey();

        }
    }
}
