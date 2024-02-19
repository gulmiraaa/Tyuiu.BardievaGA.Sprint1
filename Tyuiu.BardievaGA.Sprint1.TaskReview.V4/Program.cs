using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.BardievaGA.Sprint1.TaskReview.V4.Lib;

namespace Tyuiu.BardievaGA.Sprint1.TaskReview.V4
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = " Спринт #1 |Выполнила: Бардиева Г. А.| ИСПб-23-1 ";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*Спринт #1                                                                *");
            Console.WriteLine("*Тема: Добавление к решению итоговых проектов по спринту                  *");
            Console.WriteLine("*Задание Review                                                           *");
            Console.WriteLine("*Вариант #4                                                               *");
            Console.WriteLine("*Выполнила: Бардиева Гулмира Алишер кизи | ИСПб-23-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*УСЛОВИЕ:                                                                 *");
            Console.WriteLine("*Написать программу, которая вычисляет математическое выражение           *");
            Console.WriteLine("*по исходным значениям данных, вводимых пользователем.                    *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("***************************************************************************");

            double x, y;

            Console.WriteLine("Введите значение X:");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение Y:");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.Calculate(x, y));

            Console.ReadLine();
        }
    }
}
