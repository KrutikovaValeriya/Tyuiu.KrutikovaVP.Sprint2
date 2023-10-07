using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KrutikovaVP.Sprint2.Task3.V17.Lib;

namespace Tyuiu.KrutikovaVP.Sprint2.Task3.V17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            double x;

            Console.Title = "Спринт #2 | Выполнил: Крутикова В. П. | АСОиУБ-23-3";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #2                                                                *");
            Console.WriteLine("* Тема: Алгоритмы разветвляющейся структуры                                *");
            Console.WriteLine("* Задание #3                                                               *");
            Console.WriteLine("* Вариант #17                                                              *");
            Console.WriteLine("* Выполнил: Крутикова Валерия Павловна | АСОиУБ-23-3                       *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение функции Y       *");
            Console.WriteLine("* с использованием вложенных операторов if-else, где пользователь          *");
            Console.WriteLine("* вводит значение переменной X с клавиатуры                                *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");


            Console.WriteLine("Введите значение X: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            var res = ds.Calculate(x);

            Console.WriteLine($"Значение Y = {res}");


            Console.ReadKey();
        }
    }
}
