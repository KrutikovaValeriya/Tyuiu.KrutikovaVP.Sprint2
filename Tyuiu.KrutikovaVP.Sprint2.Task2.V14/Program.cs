using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KrutikovaVP.Sprint2.Task2.V14.Lib;

namespace Tyuiu.KrutikovaVP.Sprint2.Task2.V14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int x, y;

            Console.Title = "Спринт #2 | Выполнил: Крутикова В. П. | АСОиУБ-23-3";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #2                                                                *");
            Console.WriteLine("* Тема: Алгоритмы разветвляющейся структуры                                *");
            Console.WriteLine("* Задание #2                                                               *");
            Console.WriteLine("* Вариант #14                                                              *");
            Console.WriteLine("* Выполнил: Крутикова Валерия Павловна | АСОиУБ-23-3                       *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу, которая запрашивает целые значения с клавиатуры      *");
            Console.WriteLine("* и вычисляет находится ли точка с координатами X,Y                        *");
            Console.WriteLine("* в заштрихованной области                                                 *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            
            Console.WriteLine("Введите значение координаты X: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение координаты Y: ");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            var res = ds.CheckDotInShadedArea(x, y);

            if (res)
                Console.WriteLine("Данная точка входит в заштрихованную область");
            else
                Console.WriteLine("Данная точка не входит в заштрихованную область");

            Console.ReadKey();

        }
    }
}
